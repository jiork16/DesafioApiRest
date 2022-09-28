using Microsoft.AspNetCore.Mvc;
using DesafioJordanRodriguesApiRest.Domain.Entities;
using DesafioJordanRodriguesApiRest.Abstractions;
using DesafioJordanRodriguesApiRest.Application.Features.Command;
using MediatR;
using System.Threading.Tasks;
using DesafioJordanRodriguesApiRest.Model;
using System.Collections.Generic;
using AutoMapper;
using System;

namespace DesafioJordanRodriguesApiRest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : BaseController<UsersController>
    {
        private new readonly IMediator _mediator;
        public UsersController(IMediator mediator)
        {
            _mediator = mediator;
        }

        // GET: api/Users
        [HttpGet]
        public async Task<List<Application.Features.UserResponse>> GetUsers()
        {
            var consult = await _mediator.Send(new GetListAsyncUserQuery());
            return consult.Data;
        }

        //// GET: api/Users/5
        [HttpGet("{id}")]
        public async Task<JsonResult>  GetUser(int id)
        {
            var user = await _mediator.Send(new GetListAsyncByIdUserQuery() { IdUser = id });

            if (user == null)
            {
                return new JsonResult(new {  });
            }

            return new JsonResult(new { user = user.Data });

        }
        [HttpGet("{id}/Summary")]
        public async Task<JsonResult> GetSummary(int id)
        {
            var user = await _mediator.Send(new GetListAsyncByIdUserSummaryQuery() { IdUser = id });

            if (user == null)
            {
                return new JsonResult(new { });
            }

            return new JsonResult(new { user = user.Data });

        }

        [HttpGet("{id}/Summary/{date}")]
        public async Task<JsonResult> GetSummaryFecha(int id, string Date)
        {
            bool isValid = DateTime.TryParseExact(
               Date,
                "dd-MM-yyyy",
                System.Globalization.CultureInfo.InvariantCulture,
                System.Globalization.DateTimeStyles.None,
                out DateTime dt);
            if (isValid)
            {
                var user = await _mediator.Send(new GetListAsyncByIdUserSummaryDateQuery() { IdUser = id, Date = dt });
                return new JsonResult(new { user = user.Data });
            }
            else
            {
                return new JsonResult(new { result = "Formato de fecha dd-mm-yyyy" });
            }

            

        }
        [HttpGet("{id}/goals")]
        public async Task<JsonResult> GetGoal(int id)
        {
            var user = await _mediator.Send(new GetListAsyncByIdUserGoalQuery() { IdUser = id });
            return new JsonResult(new { user = user.Data });
        }

    }
}
