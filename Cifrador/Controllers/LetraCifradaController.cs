using Cifrador.Application;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cifrador.Controllers
{
    [ApiController]
    [Route("api/entradaCifrador")]
    public class LetraCifradaController : ControllerBase
    {
        private readonly ICifrarFraseApplicationService cifrarFraseApplicationService;

        public LetraCifradaController(ICifrarFraseApplicationService cifrarFraseApplicationService)
        {
            this.cifrarFraseApplicationService = cifrarFraseApplicationService;

        }

        [HttpGet]
        [Route("{frase})")]
        public string Get(string frase)
        {
            return this.cifrarFraseApplicationService.CifrarFrase(frase);
        }
    }
}
