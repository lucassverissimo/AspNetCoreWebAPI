using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using SmartSchool.WebAPI.V1.Dtos;
using SmartSchool.WebAPI.Models;
using SmartSchool.WebAPI.Helpers;

namespace SmartSchool.WebAPI.V1.Profiles
{
    public class SmartSchoolProfile : Profile
    {
        public SmartSchoolProfile()
        {
            // Aluno
            CreateMap<Aluno, AlunoDto>()
            .ForMember(dest => dest.Nome, 
                       opt => opt.MapFrom(src => $"{src.Nome} {src.Sobrenome}"))
            .ForMember(dest => dest.Idade,
                       opt => opt.MapFrom(src => src.DataNasc.CalcularIdade()));
            
            CreateMap<AlunoDto, Aluno>();
            CreateMap<Aluno, AlunoRegistrarDto>().ReverseMap();
        }
    }
}