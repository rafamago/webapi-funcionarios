using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.Enums;

namespace WebAPI.obj.Models
{
    public class FuncionarioModel
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }

        public DepartamentoEnum  Departamento { get; set; }
        public bool Ativo { get; set; }
        public TurnoEnum Turno { get; set; }

        public DateTime DataDeCriacao {get; set;} = DateTime.Now.ToLocalTime();
        public DateTime DataDeAlteracao {get; set;} = DateTime.Now.ToLocalTime();

    }
}