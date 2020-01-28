﻿using System;

namespace HomeWork.Model
{
    internal class PhoneContact : Contact
    {
        public string PhoneCode { get; set; }

        public override string ToString()
        {
            return string.Format("Id={0}, Value={1}", Id, "(" + PhoneCode + ")" + Value);
        }
    }
}