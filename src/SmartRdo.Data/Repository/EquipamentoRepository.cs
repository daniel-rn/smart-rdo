using Microsoft.EntityFrameworkCore;
using SmartRdo.Business.Interfaces.repository;
using SmartRdo.Business.Models;
using SmartRdo.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartRdo.Data.Repository
{
    public class EquipamentoRepository : Repository<Equipamento>, IEquipamentoRepository
    {
        public EquipamentoRepository(SmartRdoDbContext db) : base(db)
        {
        }

        public async Task<IEnumerable<Equipamento>> ObterTodosComItensChecklist()
        {
            return await Db.Equipamentos
                .Include(e => e.ItensChecklist)
                .ToListAsync();
        }

        public async Task<Equipamento> ObterPorIdComItensChecklist(Guid id)
        {
            return await Db.Equipamentos
                .AsNoTracking()
                .Include(e => e.ItensChecklist)
                .Where(e => e.Id == id)
                .FirstOrDefaultAsync();
        }

        public override async Task Atualizar(Equipamento equipamento)
        {
            var checklist = Db.ItensChecklistsEquipamentos.Where(i => i.IdEquipamento == equipamento.Id);
            Db.ItensChecklistsEquipamentos.RemoveRange(checklist);
            Db.ItensChecklistsEquipamentos.AddRange(equipamento.ItensChecklist);
            Db.Equipamentos.Update(equipamento);

            await SaveChanges();
        }

        public override async Task Remover(Guid id)
        {
            var checklist = Db.ItensChecklistsEquipamentos.Where(i => i.IdEquipamento == id);

            Db.ItensChecklistsEquipamentos.RemoveRange(checklist);

            Db.Remove(new Equipamento { Id = id });

            await SaveChanges();
        }
    }
}
