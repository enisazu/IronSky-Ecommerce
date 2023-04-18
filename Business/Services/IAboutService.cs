using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Services
{
    public interface IAboutService
    {
        
        List<About> List();
        void Add(About about);
    }
}
