using DataBaseFirst.Model;
using Entity01HW.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBaseFirst
{
    class Program
    {
        public static Entity01Entities1 db = new Entity01Entities1();
        static void Main(string[] args)
        {
            var mf = db.TablesManufacturer.ToList();
            foreach (var item in mf)
            {
                Console.WriteLine(item.strName);
            }
            Console.WriteLine("*******************************");
            foreach (var item in db.TablesModel)
            {
                Console.WriteLine(item.strName);
            }
        }
    }
}
