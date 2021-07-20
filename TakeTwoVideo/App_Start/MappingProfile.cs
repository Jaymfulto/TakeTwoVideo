using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TakeTwoVideo.Dtos;
using TakeTwoVideo.Models;

namespace TakeTwoVideo.App_Start
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            Mapper.CreateMap<Customers, CustomerDto>();
            Mapper.CreateMap<CustomerDto, Customers>();
        }
    }
}