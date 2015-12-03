using Abp.Application.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ementor.Classes.Dtos;
using AutoMapper;
using Abp.Domain.Repositories;
using Abp.AutoMapper;

namespace Ementor.Classes
{
    //TODO: use automapper
    //TODO: make all this async
    public class ClassAppService : ApplicationService, IClassAppService
    {
        //private readonly IClassRepository _classRepository;
        private readonly IRepository<Class> _classRepository;
        public async Task<List<GetClassOutput>> GetClasses()
        {
            var allClasses = await _classRepository.GetAllListAsync();
            var output = new List<GetClassOutput>();

            foreach (var clas in allClasses)
            {
                output.Add(AutoMapperConfiguration.MapClass(clas));
            }
            
            return output;
        }
        public async Task <GetClassOutput> GetClass(int classId = 1)
        {
            var clas = await _classRepository.GetAsync(classId);
            var output = AutoMapperConfiguration.MapClass(clas);

            return output;
        }

        public ClassAppService(IRepository<Class> classRepository)
        {
            _classRepository = classRepository;
        }
    }
}

