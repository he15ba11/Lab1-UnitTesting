using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarFactoryLibrary
{
    public class Honda :Car
    {
        public override void Accelerate()
        {
            velocity += 20;
        }
    }
}
