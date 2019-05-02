using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EntitiesER;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UnitOfWorkDR.API.Authorization;
using UnitOfWorkDR.API.Controllers;
using UnitOfWorkDR.API.UnitOfWork;

namespace UnitOfWorkDR.Controllers
{
    //[Produces("application/json")]
    [Route("api/Cuestionario")]
    public class CuestionarioController : BaseController
    {
        public CuestionarioController(IUnitOfWork unitOfWork, IApplicationContext context) : base(unitOfWork, context)
        {

        }

        [HttpGet]
        public async Task<IEnumerable<REM_CUESTIONARIO>> Get() => await UnitOfWork.CuestionarioRepository.GetAllAsync();

    }
}