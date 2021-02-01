﻿namespace PurchaseApproval.Models
{
    /// <summary>
    /// Class holding request details
    /// </summary>
    public class Purchase
    {
        public Purchase(decimal amount, int number)
        {
            this.Amount = amount;
            this.Number = number;
        }

        public decimal Amount { get; private set; }

        public int Number { get; set; }
    }
}