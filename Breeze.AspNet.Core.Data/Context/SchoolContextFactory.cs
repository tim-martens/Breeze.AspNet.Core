using System.Data.Entity.Infrastructure;

namespace Breeze.AspNet.Core.Data.Context
{
    public class SchoolContextFactory : IDbContextFactory<SchoolContext>
    {
        public SchoolContext Create()
        {
            return new SchoolContext("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Breeze.Asp.Net.Core;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        }
    }
}
