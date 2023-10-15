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
        private readonly SmartContext _context;

        public ProfessorController(SmartContext context)
        {
            this._context = context;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_context.Professores);
        }

        [HttpGet("{id:int}")]
        public IActionResult GetById(int id)
        {
            var Professor = _context.Professores.AsNoTracking().FirstOrDefault(x => x.Id == id);
            if (Professor == null) return BadRequest("O Professor não foi encontrado.");
            return Ok(Professor);
        }

        [HttpGet("byName")]
        public IActionResult GetByName(string nome)
        {
            var Professor = _context.Professores.AsNoTracking().FirstOrDefault(x => x.Nome.Contains(nome));
            if (Professor == null) return BadRequest("O Professor não foi encontrado.");
            return Ok(Professor);
        }

        [HttpPost]
        public IActionResult Post(Professor professor)
        {
            _context.Add(professor);
            _context.SaveChanges();
            return Ok(professor);
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, Professor professor)
        {
            var alu = _context.Professores.AsNoTracking().FirstOrDefault(x => x.Id == id);
            if (alu == null) return BadRequest("Professor não encontrado");
            _context.Update(professor);
            _context.SaveChanges();
            return Ok(professor);
        }

        [HttpPatch("{id}")]
        public IActionResult Patch(int id, Professor professor)
        {
            var alu = _context.Professores.AsNoTracking().FirstOrDefault(x => x.Id == id);
            if (alu == null) return BadRequest("Professor não encontrado");
            _context.Update(professor);
            _context.SaveChanges();
            return Ok(professor);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var alu = _context.Professores.FirstOrDefault(x => x.Id == id);
            if (alu == null) return BadRequest("Professor não encontrado");
            _context.Remove(alu);
            _context.SaveChanges();
            return Ok();
        }
    }
}