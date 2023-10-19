using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartSchool.WebAPI.Helpers
{
    public static class DateTimeExtensions
    {
        public static int CalcularIdade(this DateTime dataNasc){

            if (dataNasc == DateTime.MinValue)
                return 0;
            
            int idade = DateTime.Now.Year - dataNasc.Year;

            if (DateTime.Now.DayOfYear < dataNasc.DayOfYear)
                idade--;
            
            return idade;

        }
    }
}