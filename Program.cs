using System;
namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //const
            //string name = "Luca";
            //string cognome;
            // cognome = "Rossi";
            // int eta = 23;
            // char caratt = 'M';
            // Console.WriteLine("Antonio was here!");
            // Console.WriteLine($"mi chiamo {name} {cognome}\nsono un...{caratt} ed ho {eta} anni!");
            // Console.Read();
            //string cit = "cit: \"chi\"";
            //Console.Write(cit);
            //string formatting
            //Console.WriteLine("formattazione di {0} con {1}", name, cognome);

            // string format = string.Format("formattazione di {0} con {1}", name, cognome);

            // //interpolating string
            // Console.WriteLine($"{cognome} oppure {name}");
            // name = name.Replace('L', 'M');
            // name = name.Replace('M', 'L');
            // int leng = name.Length;

            //numbers exercise
            //Console.WriteLine("Taglio il cognome, rimane: " + cognome.Substring(3));
            //int first = 15;
            //double second = 5.0;
            //first += 5;
            //int third = first + (int)second;
            //int f = Int32.Parse("43");
            //Console.WriteLine(Math.Max(f, 7));

            //Console.WriteLine("insert first number ");
            //string one = Console.ReadLine();
            //Console.WriteLine("insert operator: ");
            //string oper = Console.ReadLine();
            //Console.WriteLine("insert second number: ");
            //string two = Console.ReadLine();

            //int num1 = 0;
            //int num2 = 0;

            //try
            //{
            //    num1 = Int32.Parse(one);
            //}
            //catch(FormatException)
            //{
            //    Console.Write("WRONG MOVE! check your input :( ");
            //}
            //catch (ArgumentNullException)
            //{
            //    Console.WriteLine("insert a number! ");
            //}
            //catch (OverflowException)
            //{
            //    Console.WriteLine("number is too big! ");
            //}

            //try
            //{
            //    num2 = Int32.Parse(two);
            //}
            //catch(FormatException)
            //{
            //  Console.Write("WRONG MOVE! check your input :( ");
            //}
            //catch (ArgumentNullException)
            //{
            //    Console.WriteLine("insert a number! ");
            //}
            //catch (OverflowException)
            //{
            //    Console.WriteLine("number is too big! ");
            //}

            //int num3 = 0;
            //switch (oper)
            //    {

            //    case "+":
            //            num3 = num1 + num2;
            //        Console.WriteLine("your result +: " + num3);
            //        break;
            //    case "-":
            //        num3 = num1 - num2;
            //        Console.WriteLine("your result -: " + num3);
            //        break;
            //    case "*":
            //    case "x":
            //    case "X":
            //        num3 = num1 * num2;
            //        Console.WriteLine("your result *: " + num3);
            //        break;
            //    case ":":
            //    case "/":
            //        num3 = num1 / num2;
            //        Console.WriteLine("your result /: " + num3);
            //        break;
            //    default: num3.ToString("WRONG MOVE! Check your input :( ");
            //        break;
            //        }
            //bool nav = 7 < 6;
            //if (nav)
            //{

            //    Console.WriteLine(nav + " its true!");
            //}
            //else if (nav ==true)
            //{
            //    Console.WriteLine(nav + ", OVP the else block");
            //}else if (!nav)
            //{
            //    if(nav == false)
            //    {
            //        int a = 9;
            //        Console.WriteLine(++a);
            //    }
            //}
            //string var1 = Console.ReadLine();
            //string var2 = Console.ReadLine();
            //try
            //{
            //    int sec = Int32.Parse(var1);
            //    int sec2 = Int32.Parse(var2);
            //    if (sec % 2 == 0 && sec2 % 2 == 0)
            //        Console.WriteLine("the numbers are not odd numbers!");
            //    else if (sec % 2 == 0 || sec2 % 2 == 0)
            //    {
            //        string axe = sec % 2 == 0 ? $"{sec2} is odd while {sec} is not odd!" : $"{sec} is odd while {sec2} is not odd!";
            //        Console.WriteLine(axe);
            //    }
            //    else Console.WriteLine("the numbers are both odd!");
            //}
            //catch (FormatException)
            //{
            //    Console.WriteLine("those are not both numbers! So... \nChecking if your input are equals...\n");
            //    if (var1 != var2) Console.WriteLine("those two inputs are not equals!");
            //    else Console.WriteLine("those two inputs are equals!");
            //}
            //catch (OverflowException)
            //{
            //    Console.WriteLine("You wrote an enormous number and broke the app! D:");
            //}
            //cicli for / foreach
            //for (int i = 0; i <= 6; i++)
            //{
            //    for (int j = i; j <= 6; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}
            //string[] nomi = { "luca", "marco", "anna", "anno" };
            //foreach(string nome in nomi){
            //    Console.WriteLine(nome);}
            greetings();
            string n = null;
            int o = 9;
            rename(age: o, nome: n); //pazzesco D:

        }
        //methods and functions
        static void greetings()
        {
            Console.WriteLine("greetings from C# function");
        }
        static void rename(string nome, int age)
        {
            if (nome == null)
            {
                nome = "Frank";
            }
            Console.WriteLine($"hi {nome}, you have {age}");
        }
    }
}