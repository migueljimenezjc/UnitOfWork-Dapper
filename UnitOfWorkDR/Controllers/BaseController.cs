﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using UnitOfWorkDR.API.Authorization;
using UnitOfWorkDR.API.UnitOfWork;

namespace UnitOfWorkDR.API.Controllers
{
    public class BaseController : ControllerBase, IContextAware
    {
        public IUnitOfWork UnitOfWork { get; set; }
        public IApplicationContext ApplicationContext { get; set; }

        public BaseController(IUnitOfWork unitOfWork, IApplicationContext context)
        {
            UnitOfWork = unitOfWork;
            ApplicationContext = context;
        }
    }
}