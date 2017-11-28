using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using Openddd.Authorization.Roles;
using Openddd.Authorization.Users;
using Openddd.MultiTenancy;

namespace Openddd.EntityFrameworkCore
{
    public class OpendddDbContext : AbpZeroDbContext<Tenant, Role, User, OpendddDbContext>
    {
        /* Define an IDbSet for each entity of the application */
        
        public OpendddDbContext(DbContextOptions<OpendddDbContext> options)
            : base(options)
        {
        }
    }
}
