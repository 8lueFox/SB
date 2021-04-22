using AutoMapper;
using ScienceBook.Web.Data.Entities;
using ScienceBook.Web.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ScienceBook.Web.Data
{
    public class SBMappingProfile : Profile
    {
        public SBMappingProfile()
        {
            CreateMap<TaskState, TaskStateViewModel>()
                .ForMember(ts => ts.TaskStateId, ex => ex.MapFrom(vm => vm.Id))
                .ReverseMap();
        }
    }
}
