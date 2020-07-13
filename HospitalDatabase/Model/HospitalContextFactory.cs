using System.Data.Entity.Infrastructure;

namespace HospitalDatabaseExample.Model
{
    public class HospitalContextFactory : IDbContextFactory<HospitalContext>
    {
        public HospitalContext Create()
        {
            return new HospitalContext();
        }
    }
}