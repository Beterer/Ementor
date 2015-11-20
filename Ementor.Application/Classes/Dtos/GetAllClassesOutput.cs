using Abp.Application.Services.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ementor.Classes.Dtos
{
    public class GetAllClassesOutput : IOutputDto
    {
        public List<Class> Classes { get; set; }
    }
}
