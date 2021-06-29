using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SampleApp.Core.DTOs;
using SampleApp.Core.Entities;

namespace SampleApp.API.Profiles
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<SalesOrderHeader, SalesOrderHeaderDTO>()              
              .ForMember(dto => dto.SalesOrderDetailDTOs, opt => opt.MapFrom(src => src.SalesOrderDetails))
              .ForMember(dto => dto.SalesOrderHeaderSalesReasonDTOs, opt => opt.MapFrom(src => src.SalesOrderHeaderSalesReasons));
        }
    }
}
