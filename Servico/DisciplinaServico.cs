using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;
using Persistencia;

namespace Servico
{
    public class DisciplinaServico
    {
        private DisciplinaDal disciplinaDal;

        public DisciplinaServico(SqlConnection connection)
        {
            disciplinaDal = new DisciplinaDal(connection);
        }


        public void Gravar (Disciplina disciplina)
        {
            disciplinaDal.Gravar(disciplina);
        }


        public List<Disciplina> ObterTodas()
        {
            return disciplinaDal.ObterTodas();
        }


        public Disciplina ObterPorId(long id)
        {
            return disciplinaDal.ObterPorId(id);
        }


        public void Remover(Disciplina disciplina)
        {
            disciplinaDal.Remover(disciplina);
        }
    }
}
