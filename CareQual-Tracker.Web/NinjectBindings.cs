using AutoMapper;
using CareQual_Tracker.Application.Authentication;
using CareQual_Tracker.Application.Authentication.Interfaces;
using CareQual_Tracker.Data;
using CareQual_Tracker.Data.Repositories;
using CareQual_Tracker.Data.Repositories.Interfaces;
using CareQual_Tracker.ViewModels.Mapping;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Abstractions;
using Ninject;
using Ninject.Web.Common;
using System;
using System.Collections.Generic;
using System.Linq;
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



            var mapperConfig = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<QualificationProfile>();
                cfg.AddProfile<CareQualUserProfile>();
            }, NullLoggerFactory.Instance);

            Bind<IMapper>().ToMethod(ctx => mapperConfig.CreateMapper()).InSingletonScope();
            Bind<MapperConfiguration>().ToConstant(mapperConfig);
        }
    }
}