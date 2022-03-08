using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpmodul3_1302200087
{
    class KodePos
    {
        static void getKodePos()
        {
            int[] kodepos = {40266, 40287, 40267, 40256, 40287, 40286, 40286, 40286, 40272, 40274, 40273 };
            string[] Kelurahan = {"Batununggal", "Kujangsari", "Mengger", "Wates", "Cijaura", "Jatisari", "Margasari", "Sekejati", "Kebonwaru", "Maleer", "Samoja" };
            Console.WriteLine(Kelurahan);
            Console.WriteLine(kodepos);
        }
        static void Main()
        {
            getKodePos();
        }
    }
}
