using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulation_project
{
    class Server
    {
        public int periorty;
        public float[] probility;
        public int[] serviceTime;
        public float[] cumulativeprobility;

        public Server(int per, float[] p, int[] ST, float[] CP)
        {
            this.periorty = per;
            this.probility = p;
            this.serviceTime = ST;
        }
        public void calcule_cumulativeprobility()
        {
            for(int w=0;w<probility.Length;w++)
            {

            }
        }

    }
}
