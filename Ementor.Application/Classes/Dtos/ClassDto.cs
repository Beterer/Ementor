using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ementor.Classes.Dtos
{
    class ClassDto
    {
        public ClassCategory Category { get; set; }
        public DateTime DateTime { get; set; }
        public ClassStatus Status { get; set; }
    }
}
