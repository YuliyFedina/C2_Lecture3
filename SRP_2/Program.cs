﻿using System;
using SRP_2.Data;
using SRP_2.Model;

namespace SRP_2
{
    class Program
    {
        static void Main(string[] args)
        {
            var user = new User { Id = 1, Name = "Name" };

            var phone = new Phone { Id = 1, PhoneCode = "123", Value = "123124" };

            var userRepository = GetRepository<User>();
            userRepository.Add(user);

            var contactRepository = GetRepository<Contact>();
            contactRepository.Add(phone);

            Console.WriteLine(contactRepository.GetById(1));
            Console.ReadLine();
        }

        private static IRepository<TEntity> GetRepository<TEntity>() where TEntity : IEntity
        {
            return new EntityRepository<TEntity>();
        }
    }
}
