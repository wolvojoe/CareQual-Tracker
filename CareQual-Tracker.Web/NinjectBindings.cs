using AutoMapper;
using CareQual_Tracker.Application.Administrator;
using CareQual_Tracker.Application.Administrator.Interfaces;
using CareQual_Tracker.Application.Authentication;
using CareQual_Tracker.Application.Authentication.Interfaces;
using CareQual_Tracker.Data;
using CareQual_Tracker.Data.Repositories;
using CareQual_Tracker.Data.Repositories.Interfaces;
using CareQual_Tracker.ViewModels.Mapping;
using FluentValidation;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Abstractions;
using Ninject;
using Ninject.Web.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;

namespace CareQual_Tracker.Web
{
    public class NinjectBindings : Ninject.Modules.NinjectModule
    {
        public override void Load()
        {
            Bind<CareQualTrackerDbContext>().ToSelf().InRequestScope();

            Bind<ICareQualUserRepository>().To<CareQualUserRepository>();
            Bind<ICareQualUserAuthService>().To<CareQualUserAuthService>();

            Bind<IQualificationRepository>().To<QualificationRepository>();
            Bind<IQualificationService>().To<QualificationService>();


            var mapperConfig = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<QualificationProfile>();
                cfg.AddProfile<CareQualUserProfile>();
            }, NullLoggerFactory.Instance);

            Bind<IMapper>().ToMethod(ctx => mapperConfig.CreateMapper()).InSingletonScope();
            Bind<MapperConfiguration>().ToConstant(mapperConfig);

            var assemblies = AppDomain.CurrentDomain.GetAssemblies();
            foreach (var asm in assemblies)
            {
                Type[] types;
                try { types = asm.GetTypes(); }
                catch (ReflectionTypeLoadException ex) { types = ex.Types.Where(t => t != null).ToArray(); }
                catch { continue; }

                var validatorTypes = types
                    .Where(t => t != null && !t.IsAbstract && !t.IsInterface)
                    .SelectMany(t => t.GetInterfaces(), (impl, @interface) => new { impl, @interface })
                    .Where(x => x.@interface.IsGenericType && x.@interface.GetGenericTypeDefinition() == typeof(IValidator<>))
                    .Select(x => new { Service = x.@interface, Impl = x.impl });

                foreach (var v in validatorTypes)
                {
                    Bind(v.Service).To(v.Impl).InRequestScope();
                }
            }
        }
    }
}