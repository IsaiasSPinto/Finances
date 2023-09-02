﻿namespace Domain.Entities;

public class Account : Entity<Guid>
{
    public string Name { get; set; } = null!;
    public string Description { get; set; } = null!;
    public decimal Balance { get; set; }
    public Guid UserId { get; set; }
    public User User { get; set; } = null!;
    public ICollection<Transaction> Transactions { get; set; } = new List<Transaction>();   
}
