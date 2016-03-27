﻿using System.ComponentModel;

namespace EStore.BL.Models
{
    public enum ProductSingleStateEnum
    {
        [Description("Продается")] ForSale = 1,
        [Description("В резерве")] OnHold = 2,
        [Description("Продан")] Sold = 3
    }
}