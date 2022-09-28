using Microsoft.AspNetCore.Mvc;
using DesafioJordanRodriguesApiRest.Domain.Entities;
using DesafioJordanRodriguesApiRest.Abstractions;
using DesafioJordanRodriguesApiRest.Application.Features.Command;
using MediatR;
using System.Threading.Tasks;
using DesafioJordanRodriguesApiRest.Model;
using System.Collections.Generic;
using AutoMapper;

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

        //// PUT: api/Users/5
        //// To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        //[HttpPut("{id}")]
        //public async Task<IActionResult> PutUser(int id, User user)
        //{
        //    if (id != user.id)
        //    {
        //        return BadRequest();
        //    }

        //    _context.Entry(user).State = EntityState.Modified;

        //    try
        //    {
        //        await _context.SaveChangesAsync();
        //    }
        //    catch (DbUpdateConcurrencyException)
        //    {
        //        if (!UserExists(id))
        //        {
        //            return NotFound();
        //        }
        //        else
        //        {
        //            throw;
        //        }
        //    }

        //    return NoContent();
        //}

        //// POST: api/Users
        //// To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        //[HttpPost]
        //public async Task<ActionResult<User>> PostUser(User user)
        //{
        //    _context.Users.Add(user);
        //    await _context.SaveChangesAsync();

        //    return CreatedAtAction("GetUser", new { id = user.id }, user);
        //}

        //// DELETE: api/Users/5
        //[HttpDelete("{id}")]
        //public async Task<IActionResult> DeleteUser(int id)
        //{
        //    var user = await _context.Users.FindAsync(id);
        //    if (user == null)
        //    {
        //        return NotFound();
        //    }

        //    _context.Users.Remove(user);
        //    await _context.SaveChangesAsync();

        //    return NoContent();
        //}

        //private bool UserExists(int id)
        //{
        //    return _context.Users.Any(e => e.id == id);
        //}
    }
}
