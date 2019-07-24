using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkItOut.Business.Items
{
    public class ProfileItem
    {
        Guid UserID { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
        float HeightFt { get; set; }
        float AddInches { get; set; }
        float Weight { get; set; }
        int Age { get; set; }
        float BodyFatPct { get; set; }
        float BMI { get; set; }
    }
}
