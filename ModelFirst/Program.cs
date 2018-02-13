using ModelFirst.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelFirst
{
    class Program
    {
        public static ModelFirst.Model.Model1Container db = new Model.Model1Container();

        static void Main(string[] args)
        {
            Table1 t1 = new Table1();
            t1.Property1 = "p1";
            t1.Property2 = "p2";
            t1.Property3 = "p3";
            db.Table1Set.Add(t1);
            db.SaveChanges();
            var mf = db.Table1Set;
            foreach (var item in mf)
            {
                Console.WriteLine(item.Property1);
            }
            Console.WriteLine("*******************************");
            var mf1 = db.Table21Set;
            foreach (var item in mf1)
            {
                Console.WriteLine(item.Property1);
            }
            Console.WriteLine("*******************************");
           var mf2 = db.Table2Set;
            foreach (var item in mf2)
            {
                Console.WriteLine(item.Property1);
            }
         
        }
    }
}
