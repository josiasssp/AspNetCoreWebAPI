namespace SmartSchool.API.Models
{
    public class AlunoDisciplina
    {

        public AlunoDisciplina() { }

        public AlunoDisciplina(int alunoId, int discplinaID)
        {
            this.AlunoId = alunoId;
            this.DiscplinaID = discplinaID;
            
        }
        public int AlunoId { get; set; }

        public Aluno Aluno { get; set; }

        public int DiscplinaID { get; set; }

        public Disciplina Disciplina { get; set; }
    }
}