using System;
using System.Threading.Tasks;
using Application.Commands.Posts.CreatePost;
using Application.Commands.Posts.DeletePost;
using Application.Queries.Posts.GetPost;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    public class PostController : ApiControllerBase
    {
        public PostController(IMediator mediator) : base(mediator)
        {
        }

        [HttpGet]
        public async Task<IActionResult> GetPost(Guid id)
        {
            var post = await QueryAsync(new GetPostQuery {PostId = id});
            return Ok(post);
        }
        
        [HttpPost]
        public async Task<IActionResult> CreatePost(CreatePostCommand command)
        {
            var result = await CommandAsync(command);
            return Ok(result);
        }
        
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePost(Guid id)
        {
            var result = await CommandAsync(new DeletePostCommand{ PostId = id});
            return Ok(result);
        }
    }
}