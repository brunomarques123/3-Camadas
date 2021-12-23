using Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia
{
   public class DisciplinaDal
    {
        public List<Disciplina> Repository { get; set; } = new List<Disciplina>();

        public void Inserir(Disciplina disciplina)
        {
            this.Repository.Add(disciplina);
        }

        public List<Disciplina> ObterTodas()
        {
            return this.Repository;
        }
    }
}
