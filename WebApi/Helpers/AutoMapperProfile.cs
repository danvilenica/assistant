using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Dao.DB.Models;
using Dao.DB.ViewModels;

namespace AssistantWebApi.Helpers
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<User, UserVM>();
            CreateMap<UserVM, User>();
        }
    }
}
