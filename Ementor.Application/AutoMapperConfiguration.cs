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
                Title = String.Format("{0} {1}", clas.Category.Name, clas.Description),
                Type = clas.StartsAt < DateTime.Now ? "special" :
                        clas.Status == ClassStatus.Confirmed ? "success" : "warning",
                StartsAt = clas.StartsAt,
                EndsAt = clas.StartsAt.AddMinutes(clas.Minutes)
            };

            return output;
        }
    }
}
