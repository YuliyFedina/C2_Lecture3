﻿using System.Collections.Generic;
using System.Linq;
using Interface_1.Model;

namespace Interface_1.Data
{
    internal class EntityRepository<TEntity> : IRepository<TEntity> where TEntity : IEntity
    {
        private readonly List<TEntity> _storage = new List<TEntity>();

        public void Add(TEntity contact)
        {
            _storage.Add(contact);
        }

        public void Remove(TEntity contact)
        {
            _storage.Remove(contact);
        }

        public TEntity GetById(long id)
        {
            return _storage.FirstOrDefault(o => o.Id == id);
        }

        public TEntity[] GetAll()
        {
            return _storage.ToArray();
        }
    }
}
