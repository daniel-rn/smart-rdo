﻿using System.Collections.Generic;

namespace SmartRdo.Business.Models
{
    public class Area : Entity
    {
        public string Nome { get; set; }

        public string CodigoArea { get; set; }
        
        public IEnumerable<ResponsaveisArea> ResponsaveisDaArea { get; set; }

        #region * EF Relations *
        
        public IEnumerable<Atividade> Atividades { get; set; }
        #endregion

        public string InformacaoArea => $"{CodigoArea} - {Nome}";
    }
}
