using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.AutoMapper;
using Ementor.Classes;
using Ementor.Classes.Dtos;

namespace Ementor
{
    public static class AutoMapperConfiguration
    {
        static AutoMapperConfiguration()
        {
            //AutoMapper.Mapper.Map<Class, GetClassOutput>()
            //    .ForMember()
        }

        internal static GetClassOutput MapClass(Class clas)
        {
            var output = new GetClassOutput
            {
                CategoryName = clas.Category.Name,
                DomainName = clas.Category.Domain.Name,
                DateTime = clas.DateTime.ToShortDateString(),
                Status = clas.Status.ToString(),
                Description = clas.Description
            };

            return output;
        }
    }
}
