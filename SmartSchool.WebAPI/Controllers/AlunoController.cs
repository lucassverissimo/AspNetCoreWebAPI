using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SmartSchool.WebAPI.Models;

namespace SmartSchool.WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AlunoController : ControllerBase
    {
        public List<Aluno> alunos = new List<Aluno>() {
            new Aluno() { 
                Id = 1,
                Nome = "Marcos",
                Sobrenome = "Leite",
                Telefone = "3234124"
            },
            new Aluno() { 
                Id = 2,
                Nome = "Marta",
                Sobrenome = "Almeida",
                Telefone = "1234534"
            },
            new Aluno() { 
                Id = 3,
                Nome = "Lucas",
                Sobrenome = "Veríssimo",
                Telefone = "1243124"
            }
        };

        public AlunoController() { }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(alunos);            
        }

        [HttpGet("{id:int}")]
        public IActionResult GetById(int id)
        {
            var aluno = alunos.FirstOrDefault(x => x.Id == id);
            if (aluno == null) return BadRequest("O aluno não foi encontrado.");
            return Ok(aluno);
        }

        [HttpGet("byName")]
        public IActionResult GetByName(string nome, string sobrenome)
        {
            var aluno = alunos.FirstOrDefault(x => x.Nome.Contains(nome) && x.Sobrenome.Contains(sobrenome));
            if (aluno == null) return BadRequest("O aluno não foi encontrado.");
            return Ok(aluno);
        }

        [HttpPost]
        public IActionResult Post(Aluno aluno)
        {
            return Ok(aluno);
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, Aluno aluno)
        {
            return Ok(aluno);
        }

        [HttpPatch("{id}")]
        public IActionResult Patch(int id, Aluno aluno)
        {
            return Ok(aluno);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            return Ok();
        }
    }
}