namespace Projeto.SeuDoutor.Data.Migrations
{
    using Context;
    using MySql.Data.Entity;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<SeuDoutorContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            
            // register mysql code generator
            SetSqlGenerator("MySql.Data.MySqlClient", new MySqlMigrationSqlGenerator());

            //here s the thing. Corrigir o erro do chave ser muito longa
            SetHistoryContextFactory("MySql.Data.MySqlClient", (conn, schema) => new MySqlHistoryContext(conn, schema)); 

        }

        protected override void Seed(SeuDoutorContext context)
        {                        
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
        }
    }
}
