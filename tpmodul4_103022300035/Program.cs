using tpmodul4_103022300035;
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Daftar Kode Pos:");
        Console.WriteLine("---------------------------");

        string[] daftarKelurahan =
        {
            "Batununggal", "Kujangsari", "Mengger", "Wates", "Cijaura",
            "Jatisari", "Margasari", "Sekejati", "Kebonwaru", "Maleer", "Samoja"
        };

        foreach (string kel in daftarKelurahan)
        {
            Console.WriteLine($"{kel}: {KodePos.GetKodePos(kel)}");
        }

        Console.WriteLine("Door Machine");
        DoorMachine pintu = new DoorMachine();

        while (true)
        {
            Console.Write("\nMasukkan perintah (BUKA/KUNCI/KELUAR): ");
            string command = Console.ReadLine().ToUpper();
            if (command == "KELUAR")
            {
                Console.WriteLine("Program selesai");
                    break;
            }
            pintu.processCommand(command);
        }
    }
}

