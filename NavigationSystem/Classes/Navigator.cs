using NavigationSystem.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NavigationSystem.Classes
{
    public class Navigator
    {
        public IRouteStrategy RouteStrategy { get; set; }

        public void SetRouteStrategy(IRouteStrategy routeStrategy)
        {
            RouteStrategy = routeStrategy;
        }

        public string BuildRoute()
        {
            return RouteStrategy.BuildRoute();
        }
    }
}
