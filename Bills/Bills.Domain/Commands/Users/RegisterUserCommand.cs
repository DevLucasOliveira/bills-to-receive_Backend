﻿using Bills.Shared.Commands;
using Flunt.Notifications;
using Flunt.Validations;

namespace Bills.Domain.Commands.Users
{
    public class RegisterUserCommand : Notifiable, ICommand
    {
        public RegisterUserCommand(string name, string userName, string password)
        {
            Name = name;
            UserName = userName;
            Password = password;
        }

        public string Name { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }

        public void Validate()
        {
            AddNotifications(
                new Contract()
                .Requires()
                .HasMinLen(UserName, 3, "UserName", "Digite um nome válido"));
        }
    }
}