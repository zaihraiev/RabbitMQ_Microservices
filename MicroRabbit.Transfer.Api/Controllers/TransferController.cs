﻿using MicroRabbit.Transfer.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace MicroRabbit.Transfer.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TransferController : ControllerBase
    {
        private readonly ITransferService _transferService;

        public TransferController(ITransferService transferService)
        {
            _transferService = transferService;
        }

        [HttpGet]
        public ActionResult GetTrasferLogs() 
        {
            return Ok(_transferService.GetTransferLogs());
        }
    }
}
