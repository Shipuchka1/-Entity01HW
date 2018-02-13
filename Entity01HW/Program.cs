using Entity01HW.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity01HW
{
    class Program
    {
    public static Model1 db = new Model1();
        static void Main(string[] args)
        {
            foreach (TablesManufacturer item in db.TablesManufacturer)
            {
                Console.WriteLine(item.strName);
            }
            Console.WriteLine("*******************************");
            foreach (TablesModel item in db.TablesModel)
            {
                Console.WriteLine(item.strName);
            }
        }
    }
}
