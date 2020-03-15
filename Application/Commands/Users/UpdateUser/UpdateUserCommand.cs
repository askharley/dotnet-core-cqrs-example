using System;
using Application.Common.Interfaces;
using Domain.Entities;

namespace Application.Commands.Users.UpdateUser
{
    public class UpdateUserCommand : ICommand<User>
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Handle { get; set; }
        public string Email { get; set; }
    }
}