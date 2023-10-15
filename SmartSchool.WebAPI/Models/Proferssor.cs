namespace SmartSchool.WebAPI.Models
{
    public class Proferssor
    {
        public Proferssor() { }
        public Proferssor(int id, string nome) 
        {
            this.Id = id;
            this.Nome = Nome;
        }
                public int Id { get; set; }
        public string Nome { get; set; }
        public IEnumerable<Disciplina> Disciplinas { get; set; }
    }
}
