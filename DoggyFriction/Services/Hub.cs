﻿using DoggyFriction.Services.Repository;

namespace DoggyFriction.Services
{
    public static class Hub
    {
        public static IRepository Repository = new JsonFileRepository();
        public static IDebtService DebtService = new DebtService();
    }
}