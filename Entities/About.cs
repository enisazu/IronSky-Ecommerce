using Core.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class About : IEntity
    {
        public int Id { get; set; }
        public string OurVision { get; set; }

        public string OurMission { get; set; }
        public string WhoWeAre { get; set; }
    }
}
