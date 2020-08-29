using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using NToastNotify;
using SmartRdo.Business.Interfaces;
using SmartRdo.Business.Notificacoes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartRdo.MVC.Controllers
{
    public abstract class MainController : Controller
    {
        private readonly INotificador _notificador;
        private readonly IToastNotification _toastNotification;

        public MainController(INotificador notificador, IToastNotification toastNotification)
        {
            _notificador = notificador;
            _toastNotification = toastNotification;
        }

        public abstract Task<IActionResult> Index();
        

        protected ActionResult CustomResponse(object result = null)
        {
            if (OperacaoValida())
            {
                return RedirectToAction(nameof(Index));
            }

            return View(result);
        }

        protected ActionResult CustomResponse(ModelStateDictionary modelState)
        {
            if (!modelState.IsValid) NotificarErroModelInvalida(modelState);
            return CustomResponse();
        }
        protected void NotificarErroModelInvalida(ModelStateDictionary modelState)
        {
            var erros = modelState.Values.SelectMany(e => e.Errors);
            foreach (var erro in erros)
            {
                var errorMsg = erro.Exception == null ? erro.ErrorMessage : erro.Exception.Message;
                NotificarErro(errorMsg);
            }
        }

        protected void NotificarErro(string mensagem)
        {
            _notificador.Handle(new Notificacao(mensagem));
        }

        protected bool OperacaoValida()
        {
            if (_notificador.TemNotificacao())
            {
                foreach (var erro in _notificador.ObterNotificacoes())
                {
                    _toastNotification.AddErrorToastMessage(erro.Mensagem);
                }

                return false;
            }

            return true;
        }
    }
}
