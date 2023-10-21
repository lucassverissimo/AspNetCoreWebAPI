using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using SmartSchool.WebAPI.V2.Dtos;
using SmartSchool.WebAPI.Models;
using SmartSchool.WebAPI.Helpers;

namespace SmartSchool.WebAPI.V2.Profiles
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

            // Professor
            CreateMap<Professor, ProfessorDto>()
            .ForMember(dest => dest.Nome,
                       opt => opt.MapFrom(src => $"{src.Nome} {src.Sobrenome}"))
            .ForMember(dest => dest.Idade,
                       opt => opt.MapFrom(src => src.DataNasc.CalcularIdade()));
            
            CreateMap<ProfessorDto, Professor>();
            CreateMap<Professor, ProfessorRegistrarDto>().ReverseMap();
        }
    }
}