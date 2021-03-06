﻿using Blogs.EfAndSprocfForCqrs.ReadModel.Context;
using Blogs.EfAndSprocfForCqrs.ReadModel.ReadModels;
using Blogs.EfAndSprocfForCqrs.Services;

namespace Blogs.EfAndSprocfForCqrs.Dependencies
{
    public static class Defaults
    {
        public readonly static string DefaultConnectionString = Properties.Settings.Default.DefaultConnection;

        public static ReadContext DefaultContext
        {
            get
            {
                return new ReadContext(DefaultConnectionString);
            }
        }

        public static OrderReadModel DefaultOrderReadModel
        {
            get
            {
                return new OrderReadModel(DefaultContext);
            }
        }

        public static OrderService DefaultOrderService
        {
            get
            {
                return new OrderService(DefaultOrderReadModel);
            }
        }
    }
}
