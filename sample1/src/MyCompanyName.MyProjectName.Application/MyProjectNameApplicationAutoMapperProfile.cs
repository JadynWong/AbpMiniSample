﻿using AutoMapper;
using MyCompanyName.MyProjectName.Samples;

namespace MyCompanyName.MyProjectName
{
    public class MyProjectNameApplicationAutoMapperProfile : Profile
    {
        public MyProjectNameApplicationAutoMapperProfile()
        {
            /* You can configure your AutoMapper mapping configuration here.
             * Alternatively, you can split your mapping configurations
             * into multiple profile classes for a better organization. */
            CreateMap<Sample, SampleDto>()
                .MapExtraProperties();
            CreateMap<CreateUpdateSampleDto, Sample>()
                .MapExtraProperties();
        }
    }
}
