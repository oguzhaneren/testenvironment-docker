﻿using System.Collections.Generic;
using System.Threading.Tasks;

namespace DAL
{
    public interface IPizzaService
    {
        Task OrderPizza(string customer, List<Pizza> pizzas);

        Task RemoveOrder(int id);
    }
}
