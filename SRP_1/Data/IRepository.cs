﻿using SRP_1.Model;

namespace SRP_1.Data
{
    internal interface IRepository<TEntity> where TEntity : IEntity
    {
        void Add(TEntity contact);

        void Remove(TEntity contact);

        TEntity GetById(long id);

        TEntity[] GetAll();
    }
}
