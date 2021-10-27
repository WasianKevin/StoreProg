using System;
using System.Threading;

int money = 100;
string answer;
int multi = 0;
bool answer2 = false;

Console.WriteLine("Psst. Hey.. You.. yes you! I was born and raised in south korea. Born with passion.");
Console.WriteLine("Passion to build.. yes.. to build Rubber Ducks!! Would you care to buy some rubber ducks?");

answer = Console.ReadLine().ToLower();



while (answer == "yes" || answer != "no" || money <= 1)
{
    while (answer != "yes" && answer != "no")
    {
        Console.WriteLine("Please answer the question.");
        answer = Console.ReadLine();
    }

    if (money <= 9)
    {
        Console.WriteLine("I'm sorry but u dont have enough money for that.");
        Console.WriteLine();
        Thread.Sleep(500);
        Console.WriteLine("Is there anything else you desire?");
        answer = Console.ReadLine();
    }

    if (answer == "yes")
    {

        Console.WriteLine("What would you want to buy?");
        Console.WriteLine();
        Console.WriteLine($"[You have {money}kr]");
        Console.WriteLine();
        Thread.Sleep(1000);
        Console.WriteLine("Yellow rubber duck       10kr");
        //Console.WriteLine("Blue rubber duck         25kr");
        //Console.WriteLine("President duck           50kr");
        //Console.WriteLine("Holy duck of dawn        150kr");
        Console.WriteLine();

        answer = Console.ReadLine();



        if (answer == "yellow rubber duck")
        {
            answer2 = false;
            while (answer2 != true)
            {
                Console.WriteLine("How many would you like?");
                answer = Console.ReadLine();
                answer2 = int.TryParse(answer, out multi);

                while (multi <= 0)
                {
                    Console.WriteLine("Stop it. Just answer the question.");
                    Thread.Sleep(1000);
                    Console.WriteLine("How many would you like?");
                    answer = Console.ReadLine();
                    answer2 = int.TryParse(answer, out multi);
                }
            }
            if (answer2 == true)
            {
                money = money - 10 * multi;
                while (money <= -1)
                {
                    Console.WriteLine("You don't have enough money for that.");
                    money = money + 10 * multi;
                    Console.WriteLine($"You have {money}kr.");
                    Thread.Sleep(1000);
                    Console.WriteLine("How many would you like?");
                    answer = Console.ReadLine();
                    answer2 = int.TryParse(answer, out multi);
                    money = money - 10 * multi;
                }

                Console.WriteLine($"You have {money}kr left. Is there anything else you desire?");
                Console.WriteLine();
                answer = Console.ReadLine();

            }
        }
    }

    if (answer == "no")
    {
        Console.WriteLine("Have a great day!");
        Thread.Sleep(2000);
        System.Environment.Exit(0);
    }



}



Console.ReadLine();

