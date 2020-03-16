using System;
using Application.Common.Interfaces;

namespace Application.Commands.Users.CreateUser
{
    public class CreateUserCommand : ICommand<int>
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Handle { get; set; }
        public string Email { get; set; }
    }
}