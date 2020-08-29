using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace SmartRdo.Business.Models.Validacoes
{
    public class EquipamentoValidation : AbstractValidator<Equipamento>
    {
        public EquipamentoValidation()
        {
            RuleFor(a => a.ItensChecklist).NotEmpty().WithMessage("É obrigatório informar pelo menos um item de checklist!");
            RuleFor(a => a.Nome).NotEmpty().WithMessage("É obrigatório informar o nome do equipamento!");
        }
    }
}
