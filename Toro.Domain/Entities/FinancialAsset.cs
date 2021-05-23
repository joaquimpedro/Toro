﻿using System;
using System.Collections.Generic;
using System.Text;
using Toro.Domain.Commons;

namespace Toro.Domain.Entities
{
    public class FinancialAsset : BaseEntity
    {
        public Trader Trader { get; set; }
        public Stock Stock { get; set; }
        public int amount { get; set; }
        public decimal unitPrice { get; set; }
    }
}
