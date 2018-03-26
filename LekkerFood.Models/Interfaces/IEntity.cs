using System;
using System.Collections.Generic;

namespace LekkerFood.Models
{

    public interface IEntity<T>
    {
        T Id { get; set; }
    }
}
