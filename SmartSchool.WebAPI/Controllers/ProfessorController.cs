using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SmartSchool.WebAPI.Data;
using SmartSchool.WebAPI.Models;

namespace SmartSchool.WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProfessorController : ControllerBase
    {        
        private readonly IRepository _repo;

        public ProfessorController(IRepository repo)
        {
            this._repo = repo;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_repo.GetAllProfessores());
        }

        [HttpGet("{id:int}")]
        public IActionResult GetById(int id)
        {
            var Professor = _repo.GetAllProfessoresByID(id);
            if (Professor == null) return BadRequest("O Professor não foi encontrado.");
            return Ok(Professor);
        }

        [HttpPost]
        public IActionResult Post(Professor professor)
        {
            _repo.Add(professor);
            if (_repo.SaveChanges()){
                return Ok(professor);
            }

            return BadRequest("Aluno não cadastrado");
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, Professor professor)
        {
            var prof = _repo.GetAllProfessoresByID(id);
            if (prof == null) return BadRequest("Professor não encontrado");
            _repo.Update(professor);
            if (_repo.SaveChanges())
                return Ok(professor);
            
            return BadRequest("Professor não cadastrado");
        }

        [HttpPatch("{id}")]
        public IActionResult Patch(int id, Professor professor)
        {
            var prof = _repo.GetAllProfessoresByID(id);
            if (prof == null) return BadRequest("Professor não encontrado");
            _repo.Update(professor);
            if (_repo.SaveChanges())
                return Ok(professor);
            
            return BadRequest("Professor não atualizado");
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var Professor = _repo.GetAllProfessoresByID(id);
            if (Professor == null) return BadRequest("Professor não encontrado");
            _repo.Delete(Professor);
           if (_repo.SaveChanges())
                return Ok("Professo removido");
            
            return BadRequest("Professor não removido");
        }
    }
}