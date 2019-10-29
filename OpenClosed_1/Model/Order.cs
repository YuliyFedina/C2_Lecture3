﻿namespace OpenClosed_1.Data.Model
{
    public class Order : IEntity
    {
        public long Id { get; set; }

        public int OrderNumber { get; set; }

        public int Quantity { get; set; }

        public decimal Price { get; set; }

        public long UserId { get; set; }

        public OrderType Type { get; set; }
    }
}
