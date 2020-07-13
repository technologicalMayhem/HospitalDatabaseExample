using System;

namespace HospitalDatabaseExample.Model
{
    [Flags]
    public enum EnumDepartment
    {
        Reception,
        WardA,
        WardB,
        IntensiveCare,
        EmergencyWard,
        Administration
    }
}