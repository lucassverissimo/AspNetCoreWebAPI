using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartSchool.WebAPI.Dtos
{
    public class ProfessorDto
    {
        public int Id { get; set; }
        public int Registro { get; set; }
        public string Nome { get; set; }
        public string? Telefone { get; set; }
        public int Idade { get; set; }
        public DateTime DataIni { get; set; } = DateTime.Now;
    }
}