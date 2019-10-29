﻿namespace Liskov_1.Model
{
    public class Contact : IEntity
    {
        public long Id { get; set; }
        public virtual string Value { get; set; }

        public int OrderNumber { get; set; }
        public override string ToString()
        {
            return string.Format("Id={0}, Value={1}", Id, Value);
        }

        public long UserId { get; set; }
    }
}
