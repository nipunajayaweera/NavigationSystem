using NavigationSystem.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NavigationSystem.Classes
{
    public class Walk: IRouteStrategy
    {
        public string BuildRoute()
        {
            return "Navigate from walk";
        }
    }
}
