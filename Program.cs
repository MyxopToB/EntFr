using System;
using System.Linq;

namespace EntFr
{
    class Program
    {
        static void Main(string[] args)
        {
            using (inventoryContext db = new inventoryContext())
            {
                Hdd disk1 = new Hdd {
                                    Manufacturer = "Seagate",
                                    Model = "sg666ujh",
                                    Capacity = 750,
                                    SerialNumber="98989775674",
                                    RegistrationNumber="027/765"
                                    };
                db.Hdd.Add(disk1);
                db.SaveChanges();
            }
            
            
            using (inventoryContext db = new inventoryContext())
            {
                var hdds =db.Hdd.ToList();
                System.Console.WriteLine("Список объектов");
                foreach (Hdd h in hdds)
                {
                    Console.WriteLine($"{h.Id}.{h.Manufacturer}  {h.Model} {h.SerialNumber}");
                }
            }
        }
    }
}
