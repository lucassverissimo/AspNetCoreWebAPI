using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SmartSchool.WebAPI.Models;

namespace SmartSchool.WebAPI.Data
{
    public interface IRepository
    {
        void Add<T>(T entity) where T : class;
        void Update<T>(T entity) where T : class;
        void Delete<T>(T entity) where T : class;
        bool SaveChanges();

        Task<Aluno[]> GetAllAlunosAsync(bool includeProfessor = false);
        Aluno[] GetAllAlunos(bool includeProfessor = false);
        Aluno[] GetAllAlunosByDisciplinaId(int disciplinaId, bool includeProfessor = false);
        Aluno? GetAllAlunosByID(int alunoId, bool includeProfessor = false);

        Aluno[] GetAllAlunosByNomeSobrenome(string nome, string sobrenome, bool includeProfessor = false);

        Professor[] GetAllProfessores(bool includeAluno = false);
        Professor[] GetAllProfessoresByDisciplinaId(int disciplinaId, bool includeAluno = false);
        Professor? GetAllProfessoresByID(int professorId, bool includeAluno = false);
    }
}