using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prak13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //membuat objek mahasiswa 1
            Mahasiswa mhs1 = new Mahasiswa();
            mhs1.Nim = "1234";
            mhs1.NamaMahasiswa = "Erik";

            Mahasiswa mhs2 = new Mahasiswa();
            mhs2.Nim = "1235";
            mhs2.NamaMahasiswa = "Wely";

            //membuat objek list
            List<Mahasiswa> list = new List<Mahasiswa>();

            //menambah elemen pada list
            list.Add(mhs1);
            list.Add(mhs2);

            //mengakses elemen pada list
            Console.WriteLine("Nim    Nama");
            Console.WriteLine("===========");
            foreach (Mahasiswa mhs in list)
            {
                Console.WriteLine("{0},  {1}", mhs.Nim, mhs.NamaMahasiswa);
            }
            Console.ReadKey();
        }
    }
}
