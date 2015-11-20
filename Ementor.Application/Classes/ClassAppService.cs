using Abp.Application.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ementor.Classes.Dtos;
using AutoMapper;
using Abp.Domain.Repositories;

namespace Ementor.Classes
{
    public class ClassAppService : ApplicationService, IClassAppService
    {
        //private readonly IClassRepository _classRepository;
        private readonly IRepository<Class> _classRepository;
        public GetAllClassesOutput GetClasses()
        {
            var classes = _classRepository.GetAll();

            return new GetAllClassesOutput
            {
                Classes = Mapper.Map<List<Class>>(classes)
            };
        }

        public ClassAppService(IRepository<Class> classRepository)
        {
            _classRepository = classRepository;
        }
    }
}

