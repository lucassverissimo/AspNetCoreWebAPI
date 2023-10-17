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
    public class AlunoController : ControllerBase
    {        
        private readonly IRepository _repo;

        public AlunoController(IRepository repo)
        {
            this._repo = repo;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_repo.GetAllAlunos(true));            
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {            
            var aluno = _repo.GetAllAlunosByID(id, true);
            if (aluno == null) return BadRequest("O aluno não foi encontrado.");
            return Ok(aluno);
        }

        [HttpGet("byName")]
        public IActionResult GetByName(string nome, string sobrenome)
        {
            var aluno = _repo.GetAllAlunosByNomeSobrenome(nome, sobrenome, true);
            if (aluno == null) return BadRequest("O aluno não foi encontrado.");
            return Ok(aluno);
        }

        [HttpPost]
        public IActionResult Post(Aluno aluno)
        {
            _repo.Add(aluno);
            if (_repo.SaveChanges()){
                return Ok(aluno);
            }

            return BadRequest("Aluno não cadastrado");
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, Aluno aluno)
        {
            var alu = _repo.GetAllAlunosByID(id);
            if (alu == null) return BadRequest("Aluno não encontrado");
            
            _repo.Update(aluno);
            if (_repo.SaveChanges()){
                return Ok(aluno);
            }

            return BadRequest("Aluno não atualizado");
        }

        [HttpPatch("{id}")]
        public IActionResult Patch(int id, Aluno aluno)
        {
            var alu = _repo.GetAllAlunosByID(id);
            if (alu == null) return BadRequest("Aluno não encontrado");
            
            _repo.Update(aluno);
            if (_repo.SaveChanges()){
                return Ok(aluno);
            }

            return BadRequest("Aluno não atualizado");
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var alu = _repo.GetAllAlunosByID(id);
            if (alu == null) return BadRequest("Aluno não encontrado");
            
            _repo.Delete(alu);
            if (_repo.SaveChanges()){
                return Ok("Aluno deletado");
            }

            return BadRequest("Aluno não deletado");
        }
    }
}