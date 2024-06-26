﻿using System.Collections.Generic;
using BillValidator.CashCode.Driver.Models;

namespace BillValidator.CashCode.Driver.BillsDefinition
{
    public class TurkmenBillsDefinition : IBillsDefinition
    {
        public List<Bill> Bills { get; }
        public Bill InvalidBill { get; }

        public TurkmenBillsDefinition()
        {
            InvalidBill = new Bill { BillAcceptorCode = 100, MoneyValue = 0, Description = "Unrecognized/Invalid bill" };

            Bills = new List<Bill>
            {
                new Bill { BillAcceptorCode = 0, MoneyValue = 1, Description = "1 Man" },
                new Bill { BillAcceptorCode = 2, MoneyValue = 5, Description = "5 Man" },
                new Bill { BillAcceptorCode = 3, MoneyValue = 10, Description = "10 Man" },
                new Bill { BillAcceptorCode = 5, MoneyValue = 50, Description = "50 Man" },
                new Bill { BillAcceptorCode = 6, MoneyValue = 100, Description = "100 Man" },
            };
        }
    }
}
