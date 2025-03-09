using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpmodul4_103022300035
{
    public class KodePos
    {
        private static string[] kelurahan =
        {
        "Batununggal", "Kujangsari", "Mengger", "Wates", "Cijaura",
        "Jatisari", "Margasari", "Sekejati", "Kebonwaru", "Maleer", "Samoja"
    };

        private static string[] kodePos =
        {
        "40266", "40287", "40267", "40256", "40287",
        "40286", "40286", "40286", "40272", "40274", "40273"
    };

        public static string GetKodePos(string namaKelurahan)
        {
            for (int i = 0; i < kelurahan.Length; i++)
            {
                if (kelurahan[i] == namaKelurahan)
                {
                    return kodePos[i];
                }
            }
            return "Kode Pos tidak ditemukan";
        }
    }
}
