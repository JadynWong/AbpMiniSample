using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace MyCompanyName.MyProjectName.Samples
{
    public interface ISampleAppService : ICrudAppService< //Defines CRUD methods
            SampleDto, //Used to show dto
            Guid, //Primary key of the entity
            PagedAndSortedResultRequestDto, //Used for paging/sorting
            CreateUpdateSampleDto> //Used to create/update a record
    {
    }
}
