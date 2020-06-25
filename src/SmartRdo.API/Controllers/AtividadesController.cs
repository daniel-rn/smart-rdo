using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using SmartRdo.API.Controllers;
using SmartRdo.Business.Interfaces;
using SmartRdo.Business.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using AutoMapper;

namespace SmartRdo.API.Controllers
{
    public class AtividadesController : ControllerBase
    {
        private readonly IAtividadeRepository _atividadeRepository;
        private readonly IMapper _mapper;
        private readonly INotificador _notificador;
        private readonly IUser _user;

        public AtividadesController(IAtividadeRepository atividadeRepository,
                                    IMapper mapper,
                                    INotificador notificador,
                                    IUser user)
        {
            _atividadeRepository = atividadeRepository;
            _mapper = mapper;
            _user = user;
            _notificador = notificador;
        }
    }
}
