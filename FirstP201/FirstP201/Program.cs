using System;

namespace FirstP201
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 200;
            var check = num > 200;
            byte weekDay = 8;

            
            switch (weekDay)
            {
                case 1:
                    Console.WriteLine("Bazar ertesi");
                    break;
                case 2:
                    Console.WriteLine("Cersenbe axsami");
                    break;
                case 3:
                    Console.WriteLine("Cersenbe");
                    break;
                case 4:
                    Console.WriteLine("Cume axsami!");
                    break;
                case 5:
                    Console.WriteLine("Cume");
                    break;
                case 6:
                    Console.WriteLine("Senbe");
                    break;
                case 7:
                    Console.WriteLine("Bazar");
                    break;
                default:
                    Console.WriteLine(weekDay + " hetfenin gunu deyil!");
                    break;
            }

            int n = 17;

           for(int i = 1; i < 100; i++)
           {
                if (i % 3 == 0)
                {
                    continue;
                }

                Console.WriteLine(i);
           }

            int j = 1;
            while (j<100)
            {
                if (j % 3 == 0)
                {
                    j++;

                    continue;
                }

                Console.WriteLine(j);
                j++;
            }


            //Console.WriteLine("salam yazisi daxil edin:");
            //string input = Console.ReadLine();


            //while (input != "salam")
            //{
            //    Console.WriteLine("salam yazisi daxil edin:");
            //    input = Console.ReadLine();
            //}

            string input;
            do
            {
                Console.WriteLine("salam yazisi daxil edin:");
                input = Console.ReadLine();
            }
            while (input != "salam");


            int monthlyOrdersCount = 56;  //camel case
            int MonthlyOrdersCount = 50; // pascal case
            int monthly_orders_count = 60; // snake case
            //int mothly-orders-count = 60;  // kabab case

            int[] numbers = new int[10] { 45,-10,567,80,91,35,-1003,543,124,5435};

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    Console.WriteLine(numbers[i]);
                }
            }

            Console.WriteLine("numbers:");
            foreach(var number in numbers)
            {
                if (number % 3 == 0) continue;

                //if (number % 3 == 0)
                //{
                //    continue;
                //}

                Console.WriteLine(number);
            }

            string[] words = new string[5];

            for(int i = 0; i < words.Length; i++)
            {
                Console.WriteLine("yazi daxil et:");
                words[i] = Console.ReadLine();
            }

            Console.WriteLine("daxil edilenler:");
            foreach (var word in words)
            {
                Console.WriteLine(word);
            }

            // 1-den 8000-e qeder ededler icerisinde nece ededin reqemlerinin cemi 21-e bolunur
            var counter = 0;
            for(int i = 1; i < 8000; i++)
            {
                var num1 = i;
                var digitsSum = 0;

                while (num1 > 0)
                {
                    var lastDigit = num1 % 10;
                    digitsSum += lastDigit; // digitsSum = digitsSum+lastDigit

                    num1 = (num1 - lastDigit) / 10;
                }

                if(digitsSum % 3==0 && digitsSum % 7 == 0)
                {
                    counter++;
                }
            }

            if (counter > 0)
            {
                string output = "iceride " + counter + " sayda reqemlerinin cemi 21 olan eded var!";
                Console.WriteLine(output);
            }
            else
            {
                Console.WriteLine("icerinde reqemlerini cemi 21-e bolunen eded yoxdur!");
            }
        }
    }
}
