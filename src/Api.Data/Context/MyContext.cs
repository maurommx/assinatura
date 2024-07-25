using System;
using Api.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using EntityFrameworkCore.UseRowNumberForPaging;
using Domain.Entities;
using Data.Mapping;

namespace Api.Data.Context
{
    public class MyContext : DbContext
    {

        public MyContext(DbContextOptions<MyContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<ModelEntity>(new ModelMap().Configure);




            //modelBuilder.Entity<UfEntity>(new UfMap().Configure);
            //modelBuilder.Entity<MunicipioEntity>(new MunicipioMap().Configure);
            //modelBuilder.Entity<CepEntity>(new CepMap().Configure);

            //modelBuilder.Entity<UserEntity>().HasData(
            //    new UserEntity
            //    {
            //        //Id = Guid.NewGuid(),
            //        Name = "Administrador",
            //        Email = "mfrinfo@mail.com",
            //        CreateAt = DateTime.Now,
            //        UpdateAt = DateTime.Now,
            //    }
            //);

            //UfSeeds.Ufs(modelBuilder);
        }

    }
}
