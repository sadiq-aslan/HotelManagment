﻿using HotelAPI.Domain.Entities;
using HotelAPI.Persistence.AppDbContext.SeedData;
using HotelAPI.Persistence.Extensions;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace HotelAPI.Persistence.AppDbContext
{
    public class HotelAppContext : IdentityDbContext<HotelUser,HotelUserRole,int>
    {
        public HotelAppContext(DbContextOptions<HotelAppContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            var entitiesAssembly = typeof(BaseEntity).Assembly;
            modelBuilder.RegisterAllEntities<BaseEntity>(entitiesAssembly);
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());


            //Data seeding burada olacaq
            modelBuilder.SeedData();


        }
    }
}
