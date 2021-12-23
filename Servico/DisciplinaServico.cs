using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;
using Persistencia;

namespace Servico
{
    public class DisciplinaServico
    {
        private DisciplinaDal disciplinaDal = new DisciplinaDal();

        public void Inserir (Disciplina disciplina)
        {
            disciplinaDal.Inserir(disciplina);
        }

        public List<Disciplina> ObterTodas()
        {
            return disciplinaDal.ObterTodas();
        }
    }
}
