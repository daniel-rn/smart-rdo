using System;
using SmartRdo.Business.Models;
using Xunit;

namespace SmartRdo.Tests
{
    public class AtividadesTests
    {
        [Fact]
        public void Deve_retornar_o_status_da_atividade_iniciada_caso_operador_ja_preenchido_a_data_de_inicio()
        {
            var atividade = new Atividade { Inicio = DateTime.Now };
            var status = atividade.CalculeStatus();
            Assert.True(AtividadeStatus.Iniciada == status);
        }

        [Fact]
        public void Deve_retornar_o_status_da_atividade_nao_iniciada_caso_operador_nao_tenha_iniciado()
        {
            var atividade = new Atividade();
            var status = atividade.CalculeStatus();
            Assert.True(AtividadeStatus.NaoIniciada == status);
        }

        [Fact]
        public void Deve_retornar_o_status_da_atividade_aguardando_analise_caso_operador_tenha_finalizado_a_atividade()
        {
            var atividade = new Atividade { Inicio = DateTime.Now, Fim = DateTime.Now.AddDays(2) };
            var status = atividade.CalculeStatus();
            Assert.True(AtividadeStatus.AguardandoRevisao == status);
        }

        [Fact]
        public void Deve_retornar_o_status_da_atividade_concluida_caso_fiscal_tenha_finalizado_a_avaliacao_da_atividade()
        {
            var atividade = new Atividade
            {
                Inicio = DateTime.Now,
                Fim = DateTime.Now.AddDays(2),
                AvaliacaoAtividade = new AvaliacaoAtividade()
            };

            var status = atividade.CalculeStatus();
            Assert.True(AtividadeStatus.Concluida == status);
        }
    }
}
