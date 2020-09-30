

using System;
using System.Collections.Concurrent;
using System.Runtime.InteropServices.ComTypes;

namespace Дз_4_2_вариант
{
    class Program
    {

        static void Case18()
        {
            int a = int.Parse(Console.ReadLine());
            string hundreds = "";
            string dozens = "";
            string units = "";

            switch (a / 100)
            {
                case 1:
                    hundreds = "one hundred ";
                    break;
                case 2:
                    hundreds = "two hundred ";
                    break;
                case 3:
                    hundreds = "three hundred ";
                    break;
                case 4:
                    hundreds = "four hundred ";
                    break;
                case 5:
                    hundreds = "five hundred ";
                    break;
                case 6:
                    hundreds = "six hundred ";
                    break;
                case 7:
                    hundreds = "seven hundred ";
                    break;
                case 8:
                    hundreds = "eight hundred ";
                    break;
                case 9:
                    hundreds = "nine hundred ";
                    break;
                case 0:
                    hundreds = "zero";
                    break;

            }
            int b = a % 100;
            if (b >= 0 && b < 10)
            {
                dozens = "";
            }
            else if (b >= 10 && b < 20)
            {
                switch (b)
                {
                    case 11:
                        dozens = "eleven";
                        break;
                    case 12:
                        dozens = "twelve";
                        break;
                    case 13:
                        dozens = "thirteen";
                        break;
                    case 14:
                        dozens = "fourteen";
                        break;
                    case 15:
                        dozens = "fifteen";
                        break;
                    case 16:
                        dozens = "sixteen";
                        break;
                    case 17:
                        dozens = "seventeen";
                        break;
                    case 18:
                        dozens = "eighteen";
                        break;
                    case 19:
                        dozens = "nineteen";
                        break;

                }
            }
            else if (b >= 20 && b < 30)
            {
                dozens = "twenty ";
            }
            else if (b >= 30 && b < 40)
            {
                dozens = "thirty ";
            }
            else if (b >= 40 && b < 50)
            {
                dozens = "fourty ";
            }
            else if (b >= 50 && b < 60)
            {
                dozens = "fifty ";
            }
            else if (b >= 60 && b < 70)
            {
                dozens = "sixty ";
            }
            else if (b >= 70 && b < 80)
            {
                dozens = "seventy ";
            }
            else if (b >= 80 && b < 90)
            {
                dozens = "eighty ";


            }
            else if (b >= 90 && b < 100)
            {
                dozens = "ninety ";
            }
            if (b > 10 && b < 20)
            {
                units = "";
            }
            else
            {
                switch (a % 10)
                {
                    case 1:
                        units = "one";
                        break;
                    case 2:
                        units = "two";
                        break;
                    case 3:
                        units = "three";
                        break;
                    case 4:
                        units = "four";
                        break;
                    case 5:
                        units = "five";
                        break;
                    case 6:
                        units = "six";
                        break;
                    case 7:
                        units = "seven";
                        break;
                    case 8:
                        units = "eight";
                        break;
                    case 9:
                        units = "nine ";
                        break;

                }
            }
            Console.Write(hundreds + dozens + units);// Старый код
        }
        static void Case19()
        {
            int a = int.Parse(Console.ReadLine());
            switch (a %10  )
            {
                case 0:
                
                case 1:
                    Console.WriteLine("White");
                    break;
                case 2:
                case 3:
                    Console.WriteLine("Black");
                    break;
                case 4:
                case 5:
                    Console.WriteLine("green");
                    break;
                case 6:
                case 7:
                    Console.WriteLine("red");
                    break;
                case 8:
                case 9:
                    Console.WriteLine("yellow");
                    break;
                //case 10:
                //case 11:
                //    Console.WriteLine("green");
                //    break;


            }
            switch (a % 12 - 4 )
            {

                case 0:
                    Console.WriteLine("rat");
                    break;
                case 1:
                    Console.WriteLine("bull");
                    break;
                case 2:
                    Console.WriteLine("tiger");
                    break;
                case 3:
                    Console.WriteLine("rabbit");
                    break;
                case 4:
                    Console.WriteLine("dragon");
                    break;
                case 5:
                    Console.WriteLine("snake");
                    break;
                case 6:
                    Console.WriteLine("horse");
                    break;
                case 7:
                    Console.WriteLine("goat");
                    break;
                case -4:
                case 8:
                    Console.WriteLine("monkey");
                    break;
                case -3:
                case 9:
                    Console.WriteLine("cock");
                    break;
                case -2:
                case 10:
                    Console.WriteLine("dog");
                    break;
                case -1:
                case 11:
                    Console.WriteLine("boar");
                    break;
            }
        }
        static void Case20()
        {
            string[] zz = { "Водолей","Рыбы","Овен","Телец","Рак","Близнец","Лев","Дева","Весы","Скорпион","Стрелец","Козерог" };
            
 
            int D = int.Parse(Console.ReadLine());
            int M = int.Parse(Console.ReadLine());


            switch (M)
            {
                case 1:
                    if(D>=20)
                        Console.WriteLine(zz[0]);
                    else
                        Console.WriteLine(zz[11]);
                    break;
                case 2:
                    if(D>=19)
                        Console.WriteLine(zz[1]);
                    else
                        Console.WriteLine(zz[0]);
                    break;
                case 3:
                    if(D>=21)
                        Console.WriteLine(zz[2]);
                    else
                        Console.WriteLine(zz[1]);
                    break;
                case 4:
                    if(D>=20)
                        Console.WriteLine(zz[3]);
                    else
                        Console.WriteLine(zz[2]);
                    break;
                case 5:
                    if(D>=21)
                        Console.WriteLine(zz[4]);
                    else
                        Console.WriteLine(zz[3]);
                    break;
                case 6:
                    if(D>=22)
                        Console.WriteLine(zz[5]);
                    else
                        Console.WriteLine(zz[4]);
                    break;
                case 7:
                    if(D>=23)
                        Console.WriteLine(zz[6]);
                    else
                        Console.WriteLine(zz[5]);
                    break;
                case 8:
                    if(D>=23)
                        Console.WriteLine(zz[7]);
                    else
                        Console.WriteLine(zz[6]);
                    break;
                case 9:
                    if (D >= 23)
                        Console.WriteLine(zz[8]);
                    else
                        Console.WriteLine(zz[7]);
                    break;
                case 10:
                    if (D >= 23)
                        Console.WriteLine(zz[9]);
                    else
                        Console.WriteLine(zz[8]);
                    break;
                case 11:
                    if (D >= 23)
                        Console.WriteLine(zz[10]);
                    else
                        Console.WriteLine(zz[9]);
                    break;
                case 12:
                    if (D >= 22)
                        Console.WriteLine(zz[11]);
                    else
                        Console.WriteLine(zz[10]);
                    break;
            }
            
        }
        static void For3()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int n = a - b -1;
            for(int i = 0;i < n; i++)
            {
                a = a - 1;
                Console.WriteLine(a);
            }
            Console.WriteLine(n);
        }
        static void For6()
        {
            int a = int.Parse(Console.ReadLine());
            float s, b = 0; 
             
            for (int i = 0; i < 5; i++)
            {
                b += .2f;
                s = a + a * b;
                Console.WriteLine(s);
            }
            
        }
        static void For9()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int r= 0;
            int n = a - b ;
            for (int i = 0; i < n+1; i++)
            {
                r += a*a;
                a -= 1;
                Console.WriteLine(r);
            }
            Console.WriteLine("a "+r);

        }
        static void For12()
        {
            int a = int.Parse(Console.ReadLine());
            float b = 1;
            float r = .1f;
            float o=0;

            for (int i = 0; i < a ; i++)
            {
               o = b* (b + r);
                b += r;
                Console.WriteLine(o);
            }
        }
        static void For15()
        {
            int a = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            int f= 1;
            for (int i = 0; i < n ; i++)
            {
                f *= a;
            }
            Console.WriteLine(f);
        }
        static void For18()
        {
            int a = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            int s = 1,f = 1;
            for (int i = 0; i < n; i++)
            {
                f *= -a;
                s += f;
            }
            Console.WriteLine(f);
        }
        static void For21()
        {
                int n = int.Parse(Console.ReadLine());
            float s = 1, f = 1;
            for (int i = 1; i < n; i++)
            {
                f *= i;
                s += 1/f;
            }
            Console.WriteLine(s);
        }
        static void For24()
        {
            int x = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            int s = 1, f = 1, d = 1 ;
            s = x * x;
            for (int i = 1; i < n - 1; i++)
            {
                f = -f * s / ((2 * i - 1) * 2 * i);
               d = d+1;
            }
            Console.WriteLine(d);
        }
        static void For27()
        {
            // со всеми этими формулами очень путался
        }
        static void For30()
        {
            int n = int.Parse(Console.ReadLine());
            float h,
                a= float.Parse(Console.ReadLine()), 
                b = float.Parse(Console.ReadLine());
            h = (b - a) / n;
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine((a+i*h)+" "+(1-Math.Sin(a+i*h)));
            }
        }
        static void For33()
        {
            int n = int.Parse(Console.ReadLine());
            int k = 0,k1= 1,k2 =1;
            for (int i = 0; i < n; i++)
            {
                k = k1 + k2;
                k2 = k1;
                k1 = k;
                Console.WriteLine(k);
            }
        }
        static void For36()
        {
            int n = int.Parse(Console.ReadLine());
            int s = 1;
            for (int i = 1; i < n +1 ; i++)
            {
                s += i * i;
                 
                Console.WriteLine(s);
            }
        }
        static void For39()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int n = a - b;
            for (int i = 1; i < n +2 ; i++)
            {
                
                Console.WriteLine(a);
                for (int d = 1; d < a; d++)
                {
                    Console.WriteLine(a);
                }
                a = a - 1;

            }
        }
        static void While3()
        {
            int n= int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            int s = 0;
            while (n>=k)
            {
                n -= k;
                ++s;
            }
            Console.WriteLine(s +" "+n);
        }
        static void While6()
        {
            int n = int.Parse(Console.ReadLine());
            int d = 1;
            while (n>=2)
            {
                d *= n;
                n -= 2;
            }
            Console.WriteLine(d);
        }
        static void While9()
        {
            int n = int.Parse(Console.ReadLine());
            int k = 1,d = 3;
            while (d<=n)
            {
                d *= 3;
                k++;
            }
            Console.WriteLine(k);
        }
        static void While12()
        {
            int n = int.Parse(Console.ReadLine());
            int k = 1, d  = 0;
            while (d <= n)
            {
                d +=k;
                k++;
            }
            k--;
            Console.WriteLine(k);
            Console.WriteLine(d);
        }
        static void While15()
        {

            float p = float.Parse(Console.ReadLine());
            int k = 1;
            float d = 1000;
            float s = d / 100 * p;
            Console.WriteLine(s);
            while (d <= 1100)
            {
                d += s;
                k++;
            }
            Console.WriteLine(k);
            Console.WriteLine(d);
        }
        static void While18()
        {

            int n = int.Parse(Console.ReadLine());
            int k = 0;
            int d = 0,s =1 ,m = 0 ;

            while (n>0)
            {
                d += n % 10;
                n /= 10;
                
                k++;
            }
            Console.WriteLine(k);
            Console.WriteLine(d);
        }
        static void While21()
        {

            int n = int.Parse(Console.ReadLine());
            int d= 1, k = 1;

            
            while (n > 0 && ((n%10)%2==0))
            {
                n /= 10;
            }
            Console.WriteLine((n % 10) % 2 != 0 ?"True":"False");
        }
        static void While24()
        {

            int n = int.Parse(Console.ReadLine());
            int k1 = 1, k2 = 1,k= 0;


            while (k < n)
            {
                k = k1 + k2;
                k2 = k1;
                k1 = k;
            }
            Console.WriteLine(k==n?"True":"False");
        }
        static void While27()
        {

            int n = int.Parse(Console.ReadLine());
            int k1 = 1, k2 = 1, k = 0, f = 1 ;


            while (k < n)
            {
                k = k1 + k2;
                k2 = k1;
                k1 = k;
                f++;
            }
            Console.WriteLine(f);
        }
        static void While30()
        {
         //-        
        }
        static void Main(string[] args)
        {

            While12();
        }
    }
}