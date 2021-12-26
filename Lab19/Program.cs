using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab19
{
    class Laptop
    {
        public int Id { get; set; }
        public string Model { get; set; }
        public string CPU { get; set; }
        public double CPUv { get; set; }
        public int RAM { get; set; }
        public int SSD { get; set; }
        public int memorySize { get; set; }
        public int price { get; set; }
        public int number { get; set; }


    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Laptop> laptopList = new List<Laptop>()
            {new Laptop(){Id=101,Model="Honor MagicBook 14 2021",CPU="Intel Core i7",CPUv=2.8,RAM=16,SSD=512,memorySize=0,price=89990,number=1 },
            new Laptop() {Id=102,Model="HP 15s-eq1143ur",CPU="AMD Athlon Gold 3150U",CPUv=2.4,RAM=8,SSD=256,memorySize=0,price=33590,number=8 },
            new Laptop(){Id=103,Model="Honor MagicBook 14 2021",CPU="Intel Core i7",CPUv=3.4,RAM=16,SSD=512,memorySize=0,price=109990,number=2 },
            new Laptop(){Id=104,Model="ASUS VivoBook 15",CPU="Intel Core i3",CPUv=3.0,RAM=8,SSD=256,memorySize=0,price=55800,number=4 },
            new Laptop(){Id=105,Model="Apple MacBook Air 13.3",CPU="Apple M1 8 core",CPUv=3.2,RAM=8,SSD=256,memorySize=0,price=89990,number=33 },
            new Laptop(){Id=106,Model="Acer Predator Helios 500",CPU="Intel Core i9",CPUv=3.3,RAM=64,SSD=2048,memorySize=0,price=389900,number=13 }

         };

            Console.WriteLine("Введите название процессора:");
            string userCPU = Console.ReadLine();
            List<Laptop> listCPU = laptopList
            .Where(L => L.CPU == userCPU)
            .ToList();
            Print(listCPU);

            Console.WriteLine("Введите min ОЗУ:");
            int userRAM = Convert.ToInt32(Console.ReadLine());
            List<Laptop> listRAM = laptopList
            .Where(L => L.RAM >= userRAM)
            .ToList();
            Print(listRAM);

            Console.WriteLine("Сортировка по увеличению стоимости");
           
            List<Laptop> listPrice = laptopList
            .OrderBy(L => L.price)
            .ToList();
            Print(listPrice);

            Console.WriteLine("Группировка по процессору");
            IEnumerable<IGrouping<string, Laptop>> listCPUType = laptopList.GroupBy(L => L.CPU);
            foreach (IGrouping<string, Laptop> CPUType in listCPUType)
            {
                Console.WriteLine(CPUType.Key);
                foreach (Laptop L in CPUType)
                { Console.WriteLine($"{L.Id},{ L.Model},{ L.CPU},{ L.CPUv},{ L.RAM},{ L.SSD},{ L.memorySize},{ L.price},{ L.number}"); }
            }

            Console.WriteLine();
            Console.WriteLine("Самый дорогой ноутбук:");
            Laptop priceList = laptopList.OrderByDescending(L => L.price).FirstOrDefault();
            Console.WriteLine($"{priceList.Id},{ priceList.Model},{ priceList.CPU},{ priceList.CPUv},{ priceList.RAM},{ priceList.SSD},{ priceList.memorySize},{ priceList.price},{ priceList.number}");
            Console.WriteLine();
            Console.WriteLine("Самый дешевый ноутбук:");
            Laptop priceList2 = laptopList.OrderBy(L => L.price).FirstOrDefault();
            Console.WriteLine($"{priceList2.Id},{ priceList.Model},{ priceList2.CPU},{ priceList2.CPUv},{ priceList2.RAM},{ priceList2.SSD},{ priceList2.memorySize},{ priceList2.price},{ priceList2.number}");
            Console.WriteLine();
            Console.WriteLine(laptopList.Any(L=>L.number>30));
            
            Console.ReadKey();
        }
        static void Print (List<Laptop> laptopList)
        {
            foreach (Laptop L in laptopList)
            { Console.WriteLine($"{L.Id},{ L.Model},{ L.CPU},{ L.CPUv},{ L.RAM},{ L.SSD},{ L.memorySize},{ L.price},{ L.number}"); }
            Console.WriteLine();
        }


    }
}   
    

