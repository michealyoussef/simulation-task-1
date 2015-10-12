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

        public Server(int[] IT, int per, float[] p, int[] ST, float[] CP)
        {

            this.periorty = per;
            this.probility = p;
            this.serviceTime = ST;
        }
        public void calcule_cumulativeprobility()
        {
            float sum = 0;
            for (int w = 0; w < probility.Length; w++)
            {
                sum += probility[w];
                cumulativeprobility[w] = sum;
            }
        }
        public float randfunction()
        {

            Random r = new Random();
            float w = r.Next(0, 100);
            if (w > 0 && w < cumulativeprobility[0] * 100)
            {
                return this.cumulativeprobility[0] * 100;
            }
            for (int a = 1; a < cumulativeprobility.Length - 1; a++)
            {
                if (cumulativeprobility[a - 1] < w && w < cumulativeprobility[a] * 100)
                {
                    return serviceTime[a];

                }
            }
            return 0;
        }
    }
}
