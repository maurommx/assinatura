using System;
using EntityFrameworkCore.UseRowNumberForPaging;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Api.Data.Context
{
    public class ContextFactory : IDesignTimeDbContextFactory<MyContext>
    {
        public MyContext CreateDbContext(string[] args)
        {
            //Usado para Criar as Migrações
            //var connectionString = "Server=localhost;Port=3306;DataBase=dbAPI2;Uid=root;Pwd=mudar@123";
            var a = Environment.GetEnvironmentVariable("Database_Host");

            var connectionString = "Server=127.0.0.1, 2354;Initial Catalog=Poly;MultipleActiveResultSets=true;User ID=sa;Password=P@ssword00";
            var optionsBuilder = new DbContextOptionsBuilder<MyContext>();
            //optionsBuilder.UseMySql(connectionString, new MySqlServerVersion(new Version(8, 0, 21)));

            optionsBuilder.UseSqlServer(connectionString, opt => opt.UseRowNumberForPaging()).UseLazyLoadingProxies();
            return new MyContext(optionsBuilder.Options);
        }
    }
}
