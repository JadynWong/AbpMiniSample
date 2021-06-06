using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Volo.Abp.ObjectExtending;

namespace MyCompanyName.MyProjectName.Samples
{
    public class CreateUpdateSampleDto : ExtensibleObject
    {
        [Required]
        public string Name { get; set; }
    }
}
