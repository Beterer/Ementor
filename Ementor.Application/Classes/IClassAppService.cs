using Abp.Application.Services;
using Ementor.Classes.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ementor.Classes
{
    public interface IClassAppService : IApplicationService
    {
        GetAllClassesOutput GetClasses();
    }
}
