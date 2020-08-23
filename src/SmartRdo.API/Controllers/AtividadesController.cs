using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using SmartRdo.Business.Interfaces;
using SmartRdo.Business.Models;
using Microsoft.AspNetCore.Mvc;
using AutoMapper;
using SmartRdo.API.ViewModels;
using SmartRdo.Business.Interfaces.repository;
using SmartRdo.Business.Interfaces.services;

namespace SmartRdo.API.Controllers
{
    [Route("api/[controller]")]
    public class AtividadesController : MainController
    {
        private readonly IAtividadeRepository _atividadeRepository;
        private readonly IAtividadeService _atividadeService;
        private readonly IMapper _mapper;

        public AtividadesController(INotificador notificador,
                                  IAtividadeRepository atividadeRepository,
                                  IAtividadeService atividadeService,
                                  IMapper mapper,
                                  IUser user) : base(notificador, user)
        {
            _atividadeRepository = atividadeRepository;
            _atividadeService = atividadeService;
            _mapper = mapper;
        }

        [HttpPost("adicionar")]
        public async Task<ActionResult<AtividadeViewModel>> Adicione(AtividadeViewModel atividadeViewModel)
        {
            if (!ModelState.IsValid) return CustomResponse(ModelState);

            await _atividadeService.Adicione(_mapper.Map<Atividade>(atividadeViewModel));

            return CustomResponse(atividadeViewModel);
        }

        [HttpGet]
        public async Task<IEnumerable<AtividadeViewModel>> ObterTodos()
        {
            return _mapper.Map<IEnumerable<AtividadeViewModel>>(await _atividadeRepository.ObtenhaAtividadesOperadores());
        }

        [HttpGet("{id:guid}")]
        public async Task<ActionResult<AtividadeViewModel>> ObterAtividadePorOperador(Guid idOperador)
        {
            var atividadeViewModel = await ObterAtividade(idOperador);

            if (atividadeViewModel == null) return NotFound();

            return atividadeViewModel;
        }

        private async Task<AtividadeViewModel> ObterAtividade(Guid idOperador)
        {
            return _mapper.Map<AtividadeViewModel>(await _atividadeRepository.ObtenhaAtivdadeOperador(idOperador));
        }
    }
}
