using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SmartSchool.WebAPI.Data;
using SmartSchool.WebAPI.V1.Dtos;
using SmartSchool.WebAPI.Models;
using SmartSchool.WebAPI.Helpers;

namespace SmartSchool.WebAPI.V1.Controllers
{
    [ApiController]
    [ApiVersion("1.0")]
    [Route("api/v{version:apiVersion}/[controller]")]
    public class AlunoController : ControllerBase
    {        
        private readonly IRepository _repo;
        private readonly IMapper _mapper;

        public AlunoController(IRepository repo, IMapper mapper)
        {
            this._repo = repo;
            this._mapper = mapper;
        }
        /// <summary>
        /// Método responsável pela obtenção dos alunos.
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var alunos = _repo.GetAllAlunos(true);
            return Ok(_mapper.Map<IEnumerable<AlunoDto>>(alunos));            
        }
        /// <summary>
        /// Obtenção assíncrona de todos os alunos.
        /// </summary>
        /// <returns></returns>
        [HttpGet("Async")]
        public async Task<IActionResult> GetAsync([FromQuery]PageParams pageParams)
        {
            var alunos = await _repo.GetAllAlunosAsync(pageParams, true);
            var result = _mapper.Map<IEnumerable<AlunoDto>>(alunos);
            Response.AddPagination(alunos.CurrentPage, alunos.PageSize, alunos.TotalCount, alunos.TotalPages);
            return Ok(result);            
        }

        [HttpGet("GetRegister")]
        public IActionResult GetRegister()
        {            
            return Ok(new AlunoRegistrarDto());
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {            
            var aluno = _repo.GetAllAlunosByID(id, true);
            if (aluno == null) return BadRequest("O aluno não foi encontrado.");

            var alunoDto = _mapper.Map<AlunoDto>(aluno);
            return Ok(alunoDto);
        }

        [HttpGet("byName")]
        public IActionResult GetByName(string nome, string sobrenome)
        {
            var aluno = _repo.GetAllAlunosByNomeSobrenome(nome, sobrenome, true);
            if (aluno == null) return BadRequest("O aluno não foi encontrado.");
            var alunoDto = _mapper.Map<IEnumerable<AlunoDto>>(aluno);
            return Ok(alunoDto);
        }

        [HttpPost]
        public IActionResult Post(AlunoRegistrarDto model)
        {
            var aluno = _mapper.Map<Aluno>(model);
            _repo.Add(aluno);
            if (_repo.SaveChanges()){
                return Created($"/api/aluno/{model.Id}", _mapper.Map<AlunoDto>(aluno));
            }

            return BadRequest("Aluno não cadastrado");
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, AlunoRegistrarDto model)
        {
            var aluno = _repo.GetAllAlunosByID(id);
            if (aluno == null) return BadRequest("Aluno não encontrado");
            
            _mapper.Map(model, aluno);

            _repo.Update(aluno);
            if (_repo.SaveChanges()){
                return Created($"/api/aluno/{model.Id}", _mapper.Map<AlunoDto>(aluno));
            }

            return BadRequest("Aluno não atualizado");
        }

        [HttpPatch("{id}")]
        public IActionResult Patch(int id, AlunoRegistrarDto model)
        {
            var aluno = _repo.GetAllAlunosByID(id);
            if (aluno == null) return BadRequest("Aluno não encontrado");
            
            _mapper.Map(model, aluno);

            _repo.Update(aluno);
            if (_repo.SaveChanges()){
                return Created($"/api/aluno/{model.Id}", _mapper.Map<AlunoDto>(aluno));
            }

            return BadRequest("Aluno não atualizado");
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var aluno = _repo.GetAllAlunosByID(id);
            if (aluno == null) return BadRequest("Aluno não encontrado");
            
            _repo.Delete(aluno);
            if (_repo.SaveChanges()){
                return Ok("Aluno deletado");
            }

            return BadRequest("Aluno não deletado");
        }
    }
}