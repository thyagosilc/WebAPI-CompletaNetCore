﻿using DevIO.Api.Controllers;
using DevIO.Business.Intefaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace DevIO.Api.V2.Controllers
{
    [ApiVersion("2.0")]
    [Route("api/v{version:apiVersion}/teste")]
    public class TesteController : MainController
    {
        private readonly ILogger _logger;
        public TesteController(INotificador notificador, IUser appUser = null, ILogger<TesteController> logger = null) : base(notificador, appUser)
        {
            _logger = logger;
        }
        [HttpGet]
        public string Valor()
        {
            _logger.LogTrace("Log de Trace");
            _logger.LogDebug("Log de Debug");
            _logger.LogInformation("Log de Informação");
            _logger.LogWarning("Log de Aviso");
            _logger.LogError("Log de Erro");
            _logger.LogCritical("Log de problema critico");

            return "Sou API V2";
        }
    }
}
