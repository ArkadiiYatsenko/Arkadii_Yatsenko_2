using System;
using System.Text.Json;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Laba2_sem2
{
    class Program
    {
        static void Main(string[] args)
        {
            triangle tr = new triangle();
            triangle tr2 = new triangle();
            //
            //
            Console.WriteLine("Введiть координати вершин першого трикутника, формат => x y");
            string[] tr11 = Console.ReadLine().Split(' ');
            tr.x1 = Convert.ToInt32(tr11[0]);
            tr.y1 = Convert.ToInt32(tr11[1]);
            string[] tr12 = Console.ReadLine().Split(' ');
            tr.x2 = Convert.ToInt32(tr12[0]);
            tr.y2 = Convert.ToInt32(tr12[1]);
            string[] tr13 = Console.ReadLine().Split(' ');
            tr.x3 = Convert.ToInt32(tr13[0]);
            tr.y3 = Convert.ToInt32(tr13[1]);
            Console.WriteLine("Введiть координати вершин другого трикутника, формат => x y");
            string[] tr21 = Console.ReadLine().Split(' ');
            tr2.x1 = Convert.ToInt32(tr21[0]);
            tr2.y1 = Convert.ToInt32(tr21[1]);
            string[] tr22 = Console.ReadLine().Split(' ');
            tr2.x2 = Convert.ToInt32(tr22[0]);
            tr2.y2 = Convert.ToInt32(tr22[1]);
            string[] tr23 = Console.ReadLine().Split(' ');
            tr2.x3 = Convert.ToInt32(tr23[0]);
            tr2.y3 = Convert.ToInt32(tr23[1]);
            //
            //
            SaveToJSON(tr);
            var tr1 = DeserializeObject();
            //
            //
            Console.WriteLine("------------------------------------------ Перший трикутник ---------------------------------------");
            Console.WriteLine($"Площа = {tr1.square()};");
            Console.WriteLine($"Периметр = {tr1.perimeter()};");
            Console.WriteLine($"Висота 1 = {tr1.higth(1)}, Висота 2 = {tr1.higth(2)}, Висота 3 = {tr1.higth(3)};");
            Console.WriteLine($"Медiана 1 = {tr1.median(1)}, Медiана 2 = {tr1.median(2)}, Медiана 3 = {tr1.median(3)};");
            Console.WriteLine($"Бiсектриса 1 = {tr1.bisector(1)}, Бiсектриса 2 = {tr1.bisector(2)}, Бiсектриса 3 = {tr1.bisector(3)};");
            Console.WriteLine($"Радiус вписаного кола = {tr1.radin()};");
            Console.WriteLine($"Радiус описаного кола = {tr1.radout()};");
            Console.WriteLine($"Тип трикутника - {tr1.type()};");
            Console.WriteLine();
            //
            //
            Console.WriteLine("------------------------------------------ Другий трикутник ---------------------------------------");
            Console.WriteLine($"Площа = {tr2.square()};");
            Console.WriteLine($"Периметр = {tr2.perimeter()}");
            Console.WriteLine($"Висота 1 = {tr2.higth(1)}, Висота 2 = {tr2.higth(2)}, Висота 3 = {tr2.higth(3)};");
            Console.WriteLine($"Медiана 1 = {tr2.median(1)}, Медiана 2 = {tr2.median(2)}, Медiана 3 = {tr2.median(3)};");
            Console.WriteLine($"Бiсектриса 1 = {tr2.bisector(1)}, Бiсектриса 2 = {tr2.bisector(2)}, Бiсектриса 3 = {tr2.bisector(3)};");
            Console.WriteLine($"Радiус вписаного кола = {tr2.radin()};");
            Console.WriteLine($"Радiус описаного кола = {tr2.radout()};");
            Console.WriteLine($"Тип трикутника - {tr2.type()};");
            //
            //
            Console.WriteLine($"Трикутники рiвнi? - {tr1.isEqual(tr1, tr2)}");
            //
            //
            Console.WriteLine("Вкажiть на скiльки градусiв i вiдносно чого повернути трикутник, формат => градуси : вершина опори(1, 2, 3), 0 якщо вiдносно центра кола");
            string[] s = Console.ReadLine().Split(' ');
            int gr = Convert.ToInt32(s[0]);
            int n = Convert.ToInt32(s[1]);
            Console.WriteLine("-----------------------------------------------------------------------");
            tr1.turn(gr, n);
            Console.WriteLine("-----------------------------------------------------------------------");
            tr2.turn(gr, n);
            Console.WriteLine("-----------------------------------------------------------------------");
        }
        static void SaveToJSON(triangle tr)                 
        {
            var ObjectJSON = JsonConvert.SerializeObject(tr);  
            File.WriteAllText("D:/FILES/Laba2_sem2/task.json", ObjectJSON);    
        }

        static triangle DeserializeObject() 
        {
            string filePath = @"D:/FILES/Laba2_sem2/task.json";
            if (File.Exists(filePath))  
            {
                var DeserializationObj = JsonConvert.DeserializeObject<triangle>(File.ReadAllText(filePath));
                return DeserializationObj;
            }
            else
            {
                return null;
            }
        }
    }
}

