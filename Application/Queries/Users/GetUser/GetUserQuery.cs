using Application.Common.Interfaces;
using Domain.Entities;

namespace Application.Queries.Users.GetUser
{
    public class GetUserQuery : IQuery<User>
    {
        public int UserId { get; set; }
    }
}