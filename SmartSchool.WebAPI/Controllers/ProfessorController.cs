using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SmartSchool.WebAPI.Data;
using SmartSchool.WebAPI.Dtos;
using SmartSchool.WebAPI.Models;

namespace SmartSchool.WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProfessorController : ControllerBase
    {        
        private readonly IRepository _repo;
        private readonly IMapper _mapper;

        public ProfessorController(IRepository repo, IMapper mapper)
        {
            this._repo = repo;
            this._mapper = mapper;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var professores = _mapper.Map<IEnumerable<ProfessorDto>>(_repo.GetAllProfessores());
            return Ok(professores);
        }

        [HttpGet("Register")]
        public IActionResult GetRegister()
        {
            return Ok(new ProfessorRegistrarDto());
        }

        [HttpGet("{id:int}")]
        public IActionResult GetById(int id)
        {
            var professor = _repo.GetAllProfessoresByID(id, true);
            if (professor == null) return BadRequest("O professor não foi encontrado.");

            var professorDto = _mapper.Map<ProfessorDto>(professor);
            return Ok(professorDto);
        }

        [HttpPost]
        public IActionResult Post(ProfessorRegistrarDto model)
        {
            var professor = _mapper.Map<Professor>(model);
            _repo.Add(professor);
            if (_repo.SaveChanges()){
                return Created($"/api/professor/{model.Id}", _mapper.Map<ProfessorDto>(professor));
            }

            return BadRequest("Professor não cadastrado");
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, ProfessorRegistrarDto model)
        {
            var professor = _repo.GetAllProfessoresByID(id);
            if (professor == null) return BadRequest("Professor não encontrado");

            _mapper.Map(model, professor);
            _repo.Update(professor);
            if (_repo.SaveChanges())
                return Created($"/api/professor/{model.Id}", _mapper.Map<ProfessorDto>(professor));
            
            return BadRequest("Professor não cadastrado");
        }

        [HttpPatch("{id}")]
        public IActionResult Patch(int id, ProfessorRegistrarDto model)
        {
            var professor = _repo.GetAllProfessoresByID(id);
            if (professor == null) return BadRequest("Professor não encontrado");

            _mapper.Map(model, professor);
            _repo.Update(professor);
            if (_repo.SaveChanges())
                return Created($"/api/professor/{model.Id}", _mapper.Map<ProfessorDto>(professor));
            
            return BadRequest("Professor não cadastrado");
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var Professor = _repo.GetAllProfessoresByID(id);
            if (Professor == null) return BadRequest("Professor não encontrado");
            _repo.Delete(Professor);
           if (_repo.SaveChanges())
                return Ok("Professor removido");
            
            return BadRequest("Professor não removido");
        }
    }
}