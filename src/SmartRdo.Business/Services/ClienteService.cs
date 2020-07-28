﻿using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using SmartRdo.Business.Interfaces;
using SmartRdo.Business.Interfaces.repository;
using SmartRdo.Business.Interfaces.services;
using SmartRdo.Business.Models;

namespace SmartRdo.Business.Services
{
    public class ClienteService : BaseService, IClienteService
    {
        private readonly IClienteRepository _clienteRepository;

        public ClienteService(INotificador notificador, IClienteRepository clienteRepository) 
            : base(notificador)
        {
            _clienteRepository = clienteRepository;
        }


        public async Task Adicione(Cliente atividade)
        {
            throw new NotImplementedException();
        }

        public async Task Atualize(Cliente atividade)
        {
            throw new NotImplementedException();
        }

        public async Task Remove(Guid id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Cliente>> ObterTodos()
        {
            return await _clienteRepository.ObterTodos();
        }

        public async Task<Cliente> Consultar(Guid? id)
        {
            throw new NotImplementedException();
        }
    }
}