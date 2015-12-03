using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.AutoMapper;

namespace Ementor.Classes.Dtos
{
    public class GetClassOutput
    {
        public string CategoryName { get; set; }
        public string DomainName { get; set; }
        public string DateTime { get; set; }
        public string Status { get; set; }
        public string Description { get; set; }
    }
}
