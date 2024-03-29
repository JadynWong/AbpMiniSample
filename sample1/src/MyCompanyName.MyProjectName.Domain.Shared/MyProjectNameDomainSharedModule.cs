﻿using MyCompanyName.MyProjectName.Localization;
using Volo.Abp.Modularity;
using Volo.Abp.Localization;
using Volo.Abp.VirtualFileSystem;
using Volo.Abp.Validation.Localization;
using Volo.Abp.Localization.ExceptionHandling;

namespace MyCompanyName.MyProjectName
{
    [DependsOn(
        typeof(AbpLocalizationModule)
        )]
    public class MyProjectNameDomainSharedModule : AbpModule
    {
        public override void PreConfigureServices(ServiceConfigurationContext context)
        {
            MyProjectNameGlobalFeatureConfigurator.Configure();
            MyProjectNameModuleExtensionConfigurator.Configure();
        }

        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpVirtualFileSystemOptions>(options =>
            {
                options.FileSets.AddEmbedded<MyProjectNameDomainSharedModule>();
            });

            Configure<AbpLocalizationOptions>(options =>
            {
                options.Resources
                    .Add<MyProjectNameResource>("en")
                    .AddBaseTypes(typeof(AbpValidationResource))
                    .AddVirtualJson("/Localization/MyProjectName");

                options.DefaultResourceType = typeof(MyProjectNameResource);
            });

            Configure<AbpExceptionLocalizationOptions>(options =>
            {
                options.MapCodeNamespace("MyProjectName", typeof(MyProjectNameResource));
            });
        }
    }
}
