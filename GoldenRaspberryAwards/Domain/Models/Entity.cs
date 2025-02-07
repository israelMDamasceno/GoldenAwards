﻿namespace GoldenAwards.Domain.Models
{
    public abstract class Entity<T> where T : struct
    {
        public T Id { get; set; }
    }
}
