﻿using System;

namespace RD.Models
{
    public class Contract
    {
        public int Id { get; set; }
        public string CounterpartyName { get; set; }
        public int CounterpartyId { get; set; }
        public int ThemeId { get; set; }
        public string? NameContract { get; set; }
        public DateTime? WorkStart { get; set; }
        public DateTime? WorkEnd { get; set; }
        public string? Props { get; set; }
        public float? Amount { get; set; }
        public string? Status { get; set; }

        public Contract()
        {
            Id = 1;
        }

        public Contract(int id, int themeId, string nameContract)
        {
            Id = id;
            NameContract = nameContract;
            ThemeId = themeId;
        }

        public Contract(int id, int themeId, string nameContract, float amount, string status)
        {
            Id = id;
            NameContract = nameContract;
            Amount = amount;
            Status = Status;
            ThemeId = themeId;
        }
    }
}
