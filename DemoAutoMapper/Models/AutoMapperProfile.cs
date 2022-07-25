using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using DemoAutoMapper.Models;

namespace DemoAutoMapper
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<StudentDTO, Student>()
                .ForMember(dest => dest.City, opt => opt.MapFrom(src => src.CurrentCity));
                //.ForMember(dest => dest.IsAdult, opt => opt.MapFrom(src => src.Age > 18 ? true : false));
            CreateMap<AddressDTO, Address>();
        }
    }
}
