using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using SmartRdo.API.Controllers;
using SmartRdo.Business.Interfaces;
using SmartRdo.Business.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using AutoMapper;
using SmartRdo.API.ViewModels;

namespace SmartRdo.API.Controllers
{
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

        //[ClaimsAuthorize("Produto", "Adicionar")]
        [HttpPost]
        public async Task<ActionResult<AtividadeViewModel>> Adicione(AtividadeViewModel atividadeViewModel)
        {
            if (!ModelState.IsValid) return CustomResponse(ModelState);

            await _atividadeService.Adicione(_mapper.Map<Atividade>(atividadeViewModel));

            return CustomResponse(atividadeViewModel);
        }

    }
}
