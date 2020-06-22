using System;
using System.Collections.Generic;

namespace SmartRdo.Business.Models
{
    public class Atividade : Entity
    {
        public string Codigo { get; set; }

        public DateTime Inicio { get; set; }

        public DateTime Fim { get; set; }

        public int Estimativa { get; set; }

        public string LocalDescarte { get; set; }

        public Cliente Cliente { get; set; }

        public IEnumerable<Operador> Operador { get; set; }
        
        public IEnumerable<Recursos> Recursos { get; set; }

        public IEnumerable<AtividadeFotos> AtividadeFotos { get; set; }
    }
}
