using System.Threading.Tasks;
using Application.Commands.Users.CreateUser;
using Application.Commands.Users.UpdateUser;
using Application.Queries.Users.GetAllUsers;
using Application.Queries.Users.GetUser;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    public class UserController : ApiControllerBase
    {
        public UserController(IMediator mediator) : base(mediator)
        {
        }
        
        [HttpGet]
        public async Task<IActionResult> GetUser(int id)
        {
            var user = await QueryAsync(new GetUserQuery {UserId = id});
            return Ok(user);
        }

        [HttpGet]
        [Route("all")]
        public async Task<IActionResult> GetAllUsers()
        {
            var users = await QueryAsync(new GetAllUsersQuery());
            return Ok(users);
        }
        
        [HttpPost]
        public async Task<IActionResult> CreateUser(CreateUserCommand command)
        {
            var userId = await CommandAsync(command);
            return Ok(userId);
        }
        
        [HttpPut]
        public async Task<IActionResult> UpdateUser(UpdateUserCommand command)
        {
            var user = await CommandAsync(command);
            return Ok(user);
        }
    }
}