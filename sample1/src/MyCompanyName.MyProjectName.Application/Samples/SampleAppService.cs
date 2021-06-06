using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace MyCompanyName.MyProjectName.Samples
{
    public class SampleAppService : CrudAppService<
            Sample, //The entity
            SampleDto, //Used to show dto
            Guid, //Primary key of the entity
            PagedAndSortedResultRequestDto, //Used for paging/sorting
            CreateUpdateSampleDto>, //Used to create/update a record
        ISampleAppService //implement the ISampleAppService  
    {
        public SampleAppService(IRepository<Sample, Guid> repository) : base(repository)
        {
        }
    }
}
