using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba2_sem2
{
    class triangle
    {
        public int x1;
        public int y1;
        public int x2;
        public int y2;
        public int x3;
        public int y3;
        public bool isEqual(triangle tr1, triangle tr2)
        {
            if ((tr1.line(x1, y1, x2, y2) == tr2.line(tr2.x1, tr2.y1, tr2.x2, tr2.y2) && tr1.line(x2, y2, x3, y3) == tr2.line(tr2.x2, tr2.y2, tr2.x3, tr2.y3) && tr1.line(x1, y1, x3, y3) == tr2.line(tr2.x1, tr2.y1, tr2.x3, tr2.y3)) || (tr1.line(x1, y1, x2, y2) == tr2.line(tr2.x2, tr2.y2, tr2.x3, tr2.y3) && tr1.line(x2, y2, x3, y3) == tr2.line(tr2.x1, tr2.y1, tr2.x3, tr2.y3) && tr1.line(x1, y1, x3, y3) == tr2.line(tr2.x1, tr2.y1, tr2.x2, tr2.y2)) || (tr1.line(x1, y1, x2, y2) == tr2.line(tr2.x1, tr2.y1, tr2.x3, tr2.y3) && tr1.line(x2, y2, x3, y3) == tr2.line(tr2.x1, tr2.y1, tr2.x2, tr2.y2) && tr1.line(x1, y1, x3, y3) == tr2.line(tr2.x2, tr2.y2, tr2.x3, tr2.y3))) 
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private double line(int x1, int y1, int x2, int y2)
        {
            double ans = Math.Sqrt(((x2 - x1) * (x2 - x1)) + ((y2 - y1) * (y2 - y1)));
            return ans;
        }
        public double square()
        {
            double p = perimeter() / 2;
            double ans = Math.Sqrt(p * (p - line(x1, y1, x2, y2)) * (p - line(x2, y2, x3, y3)) * (p - line(x1, y1, x3, y3)));
            return ans;
        }
        public double perimeter()
        {
            double ans = line(x1, y1, x2, y2) + line(x2, y2, x3, y3) + line(x1, y1, x3, y3);
            return ans;
        }
        public double higth(int t)
        {
            double ans = 0;
            if (t == 1)
            {
                ans = 2 * square() / line(x2, y2, x3, y3);
            }
            else if (t == 2)
            {
                ans = 2 * square() / line(x1, y1, x3, y3);
            }
            else if (t == 3)
            {
                ans = 2 * square() / line(x1, y1, x2, y2);
            }
            return ans;
        }
        public double median(int t)
        {
            double ans = 0;
            if (t == 1)
            {
                ans = 0.5 * Math.Sqrt(2 * line(x1, y1, x2, y2) * line(x1, y1, x2, y2) + 2 * line(x1, y1, x3, y3) * line(x1, y1, x3, y3) - line(x2, y2, x3, y3) * line(x2, y2, x3, y3));
            }
            else if (t == 2)
            {
                ans = 0.5 * Math.Sqrt(2 * line(x2, y2, x3, y3) * line(x2, y2, x3, y3) + 2 * line(x1, y1, x2, y2) * line(x1, y1, x2, y2) - line(x1, y1, x3, y3) * line(x1, y1, x3, y3));
            }
            else if (t == 3)
            {
                ans = 0.5 * Math.Sqrt(2 * line(x3, y3, x2, y2) * line(x3, y3, x2, y2) + 2 * line(x1, y1, x3, y3) * line(x1, y1, x3, y3) - line(x2, y2, x1, y1) * line(x2, y2, x1, y1));
            }
            return ans;
        }
        public double bisector(int t)
        {
            double ans = 0;
            if (t == 1)
            {
                ans = Math.Sqrt(line(x1, y1, x2, y2) * line(x1, y1, x3, y3) * (line(x1, y1, x2, y2) + line(x2, y2, x3, y3) + line(x1, y1, x3, y3)) * (line(x1, y1, x2, y2) - line(x2, y2, x3, y3) + line(x1, y1, x3, y3))) / (line(x1, y1, x2, y2) + line(x1, y1, x3, y3));
            }
            else if (t == 2)
            {
                ans = Math.Sqrt(line(x3, y3, x2, y2) * line(x1, y1, x2, y2) * (line(x1, y1, x2, y2) + line(x2, y2, x3, y3) + line(x1, y1, x3, y3)) * (line(x1, y1, x2, y2) + line(x2, y2, x3, y3) - line(x1, y1, x3, y3))) / (line(x1, y1, x2, y2) + line(x2, y2, x3, y3));
            }
            else if (t == 3)
            {
                ans = Math.Sqrt(line(x1, y1, x3, y3) * line(x2, y2, x3, y3) * (line(x1, y1, x2, y2) + line(x2, y2, x3, y3) + line(x1, y1, x3, y3)) * (line(x2, y2, x3, y3) - line(x1, y1, x2, y2) + line(x1, y1, x3, y3))) / (line(x1, y1, x3, y3) + line(x2, y2, x3, y3));
            }
            return ans;
        }
        public double radin()
        {
            double ans = 0;
            ans = 2 * square() / perimeter();
            return ans;
        }
        public double radout()
        {
            double ans = 0;
            ans = 0.25 * line(x1, y1, x2, y2) * line(x2, y2, x3, y3) * line(x1, y1, x3, y3) / square();
            return ans;
        }
        public string type()
        {
            string ans = "";
            if ((line(x1, y1, x2, y2) == line(x2, y2, x3, y3)) && (line(x2, y2, x3, y3) == line(x1, y1, x3, y3)))
            {
                ans = "Рiвностороннiй";
            }
            else
            {
                if ((line(x1, y1, x2, y2) == line(x2, y2, x3, y3)) || (line(x2, y2, x3, y3) == line(x1, y1, x3, y3)) || (line(x1, y1, x2, y2) == line(x1, y1, x3, y3)))
                {
                    ans = "Рiвнобедренний ";
                }
                if ((line(x1, y1, x2, y2) * line(x1, y1, x2, y2) + line(x2, y2, x3, y3) * line(x2, y2, x3, y3) == Math.Round(line(x1, y1, x3, y3) * line(x1, y1, x3, y3), 0)) || (line(x1, y1, x2, y2) * line(x1, y1, x2, y2) + line(x1, y1, x3, y3) * line(x1, y1, x3, y3) == Math.Round(line(x2, y2, x3, y3) * line(x2, y2, x3, y3), 0) || (line(x1, y1, x3, y3) * line(x1, y1, x3, y3) + line(x2, y2, x3, y3) * line(x2, y2, x3, y3) == Math.Round(line(x1, y1, x2, y2) * line(x1, y1, x2, y2), 0))))
                {
                    ans = ans + "Прямокутний";
                }
                else if ((line(x1, y1, x2, y2) * line(x1, y1, x2, y2) + line(x2, y2, x3, y3) * line(x2, y2, x3, y3) > line(x1, y1, x3, y3) * line(x1, y1, x3, y3)) || (line(x1, y1, x2, y2) * line(x1, y1, x2, y2) + line(x1, y1, x3, y3) * line(x1, y1, x3, y3) > line(x2, y2, x3, y3) * line(x2, y2, x3, y3)) || (line(x1, y1, x3, y3) * line(x1, y1, x3, y3) + line(x2, y2, x3, y3) * line(x2, y2, x3, y3) > line(x1, y1, x2, y2) * line(x1, y1, x2, y2)))
                {
                    ans = ans + "Тупокутний";
                }
                else if ((line(x1, y1, x2, y2) * line(x1, y1, x2, y2) + line(x2, y2, x3, y3) * line(x2, y2, x3, y3) < line(x1, y1, x3, y3) * line(x1, y1, x3, y3)) || (line(x1, y1, x2, y2) * line(x1, y1, x2, y2) + line(x1, y1, x3, y3) * line(x1, y1, x3, y3) < line(x2, y2, x3, y3) * line(x2, y2, x3, y3)) || (line(x1, y1, x3, y3) * line(x1, y1, x3, y3) + line(x2, y2, x3, y3) * line(x2, y2, x3, y3) < line(x1, y1, x2, y2) * line(x1, y1, x2, y2)))
                {
                    ans = ans + "Гострокутний";
                }
            }
            return ans;
        }
        private void turnc(double gr, double x1, double y1, double x2, double y2, double x3, double y3)
        {
            gr = gr * Math.PI / 180;
            double s = square();
            double xO = (1 / (4 * s)) * ((Math.Pow(x1, 2) + Math.Pow(y1, 2)) * y2 + y1 * (Math.Pow(x3, 2) + Math.Pow(y3, 2)) + y3 * (Math.Pow(x2, 2) + Math.Pow(y2, 2)) - y2 * (Math.Pow(x3, 2) + Math.Pow(y3, 2)) - y1 * (Math.Pow(x2, 2) + Math.Pow(y2, 2)) - y3 * (Math.Pow(x1, 2) + Math.Pow(y1, 2)));
            double yO = -(1 / (4 * s));
            x1 = x1 - xO;
            y1 = y1 - yO;
            double x = x1 * Math.Cos(gr) - y1 * Math.Sin(gr);
            double y = x1 * Math.Sin(gr) + y1 * Math.Cos(gr);
            x2 = x2 - xO;
            y2 = y2 - yO;
            double xx = x2 * Math.Cos(gr) - y2 * Math.Sin(gr);
            double yy = x2 * Math.Sin(gr) + y2 * Math.Cos(gr);
            x3 = x3 - xO;
            y3 = y3 - yO;
            double xxx = x3 * Math.Cos(gr) - y3 * Math.Sin(gr);
            double yyy = x3 * Math.Sin(gr) + y3 * Math.Cos(gr);
            Console.WriteLine($"При поворотi вiдносно центра");
            Console.WriteLine($"Точка 1 {Math.Round(x, 0)}, {Math.Round(y, 0)}; точка 2 {Math.Round(xx, 0)}, {Math.Round(yy, 0)}; точка 3 {Math.Round(xxx, 0)}, {Math.Round(yyy, 0)}");
        }
        private void turnv(double gr, int n, int x1, int y1, int x2, int y2, int x3, int y3)
        {
            double a = line(x1, y1, x2, y2);
            double b = line(x2, y2, x3, y3);
            double c = line(x1, y1, x3, y3);
            gr = gr * Math.PI / 180;
            x1 = x1 - x3;
            y1 = y1 - y3;
            double x = x1 * Math.Cos(gr) - y1 * Math.Sin(gr);
            double y = x1 * Math.Sin(gr) + y1 * Math.Cos(gr);
            x2 = x2 - x3;
            y2 = y2 - y3;
            double xx = x2 * Math.Cos(gr) - y2 * Math.Sin(gr);
            double yy = x2 * Math.Sin(gr) + y2 * Math.Cos(gr);
            Console.WriteLine($"При поворотi вiдносно вершини {n}");
            if (n == 1)
            {
                Console.WriteLine($"Точка 2: {Math.Round(x, 0)}, {Math.Round(y, 0)}; Точка 3: {Math.Round(xx, 0)}, {Math.Round(yy, 0)}");
            }
            else if (n == 2)
            {
                Console.WriteLine($"Точка 1: {Math.Round(x, 0)}, {Math.Round(y, 0)}; Точка 3: {Math.Round(xx, 0)}, {Math.Round(yy, 0)}");
            }
            else
            {
                Console.WriteLine($"Точка 1: {Math.Round(x, 0)}, {Math.Round(y, 0)}; Точка 2: {Math.Round(xx, 0)}, {Math.Round(yy, 0)}");
            }
        } 
        public void turn(double gr, int n)
        {
            if (n == 0)
            {
                turnc(gr, x1, y1, x2, y2, x3, y3);
            }
            else
            {
                if (n == 1)
                {
                    turnv(gr, 1, x2, y2, x3, y3, x1, y1);
                }
                else if (n == 2)
                {
                    turnv(gr, 2, x1, y1, x3, y3, x2, y2);
                }
                else
                {
                    turnv(gr, 3, x1, y1, x2, y2, x3, y3);
                }
            }
        }
    }
}
