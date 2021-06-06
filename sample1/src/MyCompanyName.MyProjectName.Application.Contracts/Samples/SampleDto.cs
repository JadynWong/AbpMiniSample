using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace MyCompanyName.MyProjectName.Samples
{
    public class SampleDto : ExtensibleAuditedEntityDto<Guid>
    {
        public string Name { get; set; }
    }
}
