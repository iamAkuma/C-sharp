﻿// // // // // // // // // // Console.Write("Hey, "); //This code will not create a new line
// // // // // // // // // // Console.WriteLine("Hello, World!");
// // // // // // // // // // Console.Beep();
// // // // // // // // // // Console.WriteLine("aKuma \n"); //This will create a space between this code and below code
// // // // // // // // // // Console.WriteLine("Hello Bro!");

// // // // // // // // // // int x; //declaration
// // // // // // // // // // x = 10; //init value

// // // // // // // // // // int y = 10;
// // // // // // // // // // int z = x + y;
// // // // // // // // // // Console.WriteLine(z);

// // // // // // // // // // int age = 21;
// // // // // // // // // // double height = 177.8; //decimal number
// // // // // // // // // // bool alive = true; //true or false
// // // // // // // // // // char symbol = '@';
// // // // // // // // // // String name = "akuma_saral";
// // // // // // // // // // String userName = symbol + name;
// // // // // // // // // // String unit = "cm";

// // // // // // // // // //constants = change garna namilos future line of code ma

// // // // // // // // // // const double pi = 3.14;

// // // // // // // // // // Console.WriteLine("The value of Pi is: " + pi);
// // // // // // // // // // Console.WriteLine("My name is " + name);
// // // // // // // // // // Console.WriteLine("My username is: " + userName);
// // // // // // // // // // Console.WriteLine("Your age is " + z);
// // // // // // // // // // Console.WriteLine("Your brother's age is " + age);
// // // // // // // // // // Console.WriteLine("Your height is " + height + unit);
// // // // // // // // // // Console.WriteLine("Are you alive?" + alive);
// // // // // // // // // // Console.WriteLine("Your symbol is " + symbol);

// // // // // // // // // // double a = 3.14;
// // // // // // // // // // int b = Convert.ToInt32(a); //Converts double to int

// // // // // // // // // // //Checking variable's data types
// // // // // // // // // // Console.WriteLine(a.GetType());
// // // // // // // // // // Console.WriteLine(b.GetType());
// // // // // // // // // // Console.WriteLine(b);

// // // // // // // // // //TypeCasting rey

// // // // // // // // // // int c = 321;
// // // // // // // // // // String e = Convert.ToString(c);

// // // // // // // // // // String f = "$";
// // // // // // // // // // char g = Convert.ToChar(f);

// // // // // // // // // // Console.WriteLine(e.GetType());
// // // // // // // // // // Console.WriteLine(g);
// // // // // // // // // // Console.WriteLine("What is your name?");
// // // // // // // // // // String name = Console.ReadLine();

// // // // // // // // // // Console.WriteLine("What is your age?");
// // // // // // // // // // int age = Convert.ToInt32(Console.ReadLine());


// // // // // // // // // // Console.WriteLine("Hello " + name);
// // // // // // // // // // Console.WriteLine("Your age is  " + age);

// // // // // // // // // // Console.ReadKey();

// // // // // // // // // // int friends = 10;
// // // // // // // // // // // friends--;
// // // // // // // // // // // friends++;
// // // // // // // // // // // friends+=2;
// // // // // // // // // // // friends -=1;
// // // // // // // // // // // friends *=2;
// // // // // // // // // // // friends /=2;
// // // // // // // // // // int remainder = friends % 2;

// // // // // // // // // // Console.WriteLine(remainder);

// // // // // // // // // // int i;
// // // // // // // // // // string[] friends = { "Friend1", "Friend2", "Friend3", "Friend4", "Friend5" };

// // // // // // // // // // for (i = 0; i < friends.Length; i++)
// // // // // // // // // // {
// // // // // // // // // //     Console.WriteLine(friends[i]);
// // // // // // // // // // }

// // // // // // // // // // double x = 3.99;
// // // // // // // // // // double y = 5;

// // // // // // // // // // double a = Math.Pow(x, 2);
// // // // // // // // // // double a = Math.Sqrt(x);
// // // // // // // // // // double a = Math.Abs(x);
// // // // // // // // // // double a = Math.Round(x);
// // // // // // // // // // double a = Math.Ceiling(x);
// // // // // // // // // // double a = Math.Floor(x);
// // // // // // // // // // double a = Math.Max(x,y);
// // // // // // // // // // double b = Math.Min(x,y);

// // // // // // // // // // Console.WriteLine(b);

// // // // // // // // // // Random random = new Random();

// // // // // // // // // // int num = random.Next(1,7);
// // // // // // // // // // int num1 = random.Next(1,7);
// // // // // // // // // // int num2 = random.Next(1,7);

// // // // // // // // // // // double num = random.NextDouble();
// // // // // // // // // // System.Console.WriteLine(num);
// // // // // // // // // // System.Console.WriteLine(num1);
// // // // // // // // // // System.Console.WriteLine(num2);

// // // // // // // // // Console.WriteLine("Enter Side A: ");
// // // // // // // // // double a = Convert.ToDouble(Console.ReadLine());

// // // // // // // // // Console.WriteLine("Enter Side B: ");
// // // // // // // // // double b = Convert.ToDouble(Console.ReadLine());

// // // // // // // // // double c = Math.Sqrt((a * a) + (b * b));
// // // // // // // // // System.Console.WriteLine("The hypotenuse is: " +c);

// // // // // // // // // String fullName = "Saral";
// // // // // // // // // fullName = fullName.ToUpper();
// // // // // // // // // fullName = fullName.ToLower();
// // // // // // // // // System.Console.WriteLine(fullName);

// // // // // // // // // int i;
// // // // // // // // // int sum = 0;
// // // // // // // // // for (i=1 ; i<=5 ; ++i){
// // // // // // // // //     sum += i;

// // // // // // // // // }
// // // // // // // // // System.Console.WriteLine("The sum of 1 to 5 is: "+sum);

// // // // // // // // // String phoneNumber = "123-456-7890";
// // // // // // // // // phoneNumber=phoneNumber.Replace("-","");
// // // // // // // // // System.Console.WriteLine(phoneNumber);

// // // // // // // // // String fullName = "saral";
// // // // // // // // // String userName = fullName.Insert(0,"@");
// // // // // // // // // System.Console.WriteLine(userName);

// // // // // // // // // int [] arr = new int[5];
// // // // // // // // // arr[0] = 1 ;
// // // // // // // // // arr[1] = 2;
// // // // // // // // // arr[2] = 3 ;
// // // // // // // // // arr[3] = 4 ;
// // // // // // // // // arr[4] = 5 ;

// // // // // // // // // int sum = arr[2] + arr [3];
// // // // // // // // // System.Console.WriteLine(sum);


// // // // // // // // //College ma gareko revision
// // // // // // // // // int[][] jArray = new int[3][];

// // // // // // // // // jArray[0] = new int[2] { 1, 2 };
// // // // // // // // // jArray[1] = new int[3] { 1, 2, 3 };
// // // // // // // // // jArray[2] = new int[4] { 1, 2, 3, 4 };

// // // // // // // // // for (int i = 0; i < jArray.Length; i++)
// // // // // // // // // {
// // // // // // // // //     for (int j = 0; j < jArray[i].Length; j++)
// // // // // // // // //     {
// // // // // // // // //         System.Console.Write(jArray[i][j] + "\t");
// // // // // // // // //     }
// // // // // // // // //     System.Console.WriteLine();
// // // // // // // // // }

// // // // // // // // //if statements
// // // // // // // // // System.Console.WriteLine("Please Enter your age: ");
// // // // // // // // // int age = Convert.ToInt32(Console.ReadLine());

// // // // // // // // // if (age >= 18 && age < 100)
// // // // // // // // // {
// // // // // // // // //     System.Console.WriteLine("Congrats, You can watch porn.");
// // // // // // // // // }
// // // // // // // // // else if (age >= 100)
// // // // // // // // // {
// // // // // // // // //     System.Console.WriteLine("Die already, bitch!");
// // // // // // // // // }
// // // // // // // // // else if (age <= 0)
// // // // // // // // // {
// // // // // // // // //     System.Console.WriteLine("Pahila yo duniya ma ta aaija!");

// // // // // // // // // }
// // // // // // // // // else
// // // // // // // // // {
// // // // // // // // //     System.Console.WriteLine("Grow up kid!");

// // // // // // // // // }

// // // // // // // // //nested if
// // // // // // // // // Console.WriteLine("Enter your age: ");
// // // // // // // // // int age = Convert.ToInt32(Console.ReadLine());

// // // // // // // // // if(age >= 18 )
// // // // // // // // // {
// // // // // // // // //     System.Console.WriteLine("You are an adult.");
// // // // // // // // //     if(age > 18)
// // // // // // // // //     {
// // // // // // // // //     System.Console.WriteLine("You are older than 18 years old!");
// // // // // // // // //     }
// // // // // // // // //     else {
// // // // // // // // //         System.Console.WriteLine("You are not older than 18 years old.");
// // // // // // // // //     }
// // // // // // // // // }
// // // // // // // // // else{
// // // // // // // // //     System.Console.WriteLine("You are still a minor.");
// // // // // // // // // }


// // // // // // // // //Sum of array

// // // // // // // // // class Program
// // // // // // // // // {
// // // // // // // // //     static void displayArr(int[] arr)
// // // // // // // // //     {
// // // // // // // // //         int sum = 0;
// // // // // // // // //         Console.WriteLine("Entered elements:");

// // // // // // // // //         for (int i = 0; i < arr.Length; i++)
// // // // // // // // //         {
// // // // // // // // //             Console.WriteLine(arr[i]);
// // // // // // // // //             sum += arr[i];
// // // // // // // // //         }

// // // // // // // // //         Console.WriteLine("Sum of elements: " + sum);
// // // // // // // // //     }

// // // // // // // // //     static void Main(string[] args)
// // // // // // // // //     {
// // // // // // // // //         int[] arr = new int[4];

// // // // // // // // //         for (int i = 0; i < 4; i++)
// // // // // // // // //         {
// // // // // // // // //             Console.Write("Enter element " + (i + 1) + ": ");
// // // // // // // // //             arr[i] = Convert.ToInt32(Console.ReadLine());
// // // // // // // // //         }

// // // // // // // // //         Program.displayArr(arr);
// // // // // // // // //     }
// // // // // // // // // }

// // // // // // // // // Iteration statements

// // // // // // // // //do-while loop
// // // // // // // // // int i=1;
// // // // // // // // // do
// // // // // // // // // {
// // // // // // // // //     System.Console.WriteLine(i);
// // // // // // // // //     i++;

// // // // // // // // // }
// // // // // // // // // while(i<=10);

// // // // // // // // //for loop
// // // // // // // // //  int i;
// // // // // // // // // for(i = 1; i <=10; i++){
// // // // // // // // // System.Console.WriteLine(i);
// // // // // // // // // }


// // // // // // // // //while loop
// // // // // // // // // int i = 1;
// // // // // // // // // while(i<=5)
// // // // // // // // // {
// // // // // // // // //     System.Console.WriteLine(i);
// // // // // // // // //     i++;
// // // // // // // // // }


// // // // // // // // //switch case
// // // // // // // // //  System.Console.WriteLine("What day is it today?");
// // // // // // // // //  string day = Console.ReadLine();

// // // // // // // // //  switch(day)
// // // // // // // // //  {
// // // // // // // // //     case "Sunday":
// // // // // // // // //     System.Console.WriteLine("Today is Sunday");
// // // // // // // // //     break;
// // // // // // // // //     case "Monday":
// // // // // // // // //     System.Console.WriteLine("Today is Monday");
// // // // // // // // //     break;
// // // // // // // // //     case "Tuesday":
// // // // // // // // //     System.Console.WriteLine("Today is Tuesday");
// // // // // // // // //     break;
// // // // // // // // //     case "Wednesday":
// // // // // // // // //     System.Console.WriteLine("Today is Wednesday");
// // // // // // // // //     break;
// // // // // // // // //     case "Thursday":
// // // // // // // // //     System.Console.WriteLine("Today is Thursday");
// // // // // // // // //     break;
// // // // // // // // //     case "Friday":
// // // // // // // // //     System.Console.WriteLine("Today is Friday");
// // // // // // // // //     break;
// // // // // // // // //     case "Saturday":
// // // // // // // // //     System.Console.WriteLine("Today is Saturday");
// // // // // // // // //     break;
// // // // // // // // //     default:
// // // // // // // // //     System.Console.WriteLine(day + " is not a day.");
// // // // // // // // //     break;
// // // // // // // // //  }

// // // // // // // // // nested loops = loops inside of other loops
// // // // // // // // //                Uses vary. Used a lot in sorting algorithms

// // // // // // // // // Console.Write("How many rows?: ");
// // // // // // // // // int rows = Convert.ToInt32(Console.ReadLine());

// // // // // // // // // Console.Write("How many columns?: ");
// // // // // // // // // int columns = Convert.ToInt32(Console.ReadLine());

// // // // // // // // // Console.Write("What symbol: ");
// // // // // // // // // String symbol = Console.ReadLine();

// // // // // // // // // for (int i = 0; i < rows; i++)
// // // // // // // // // {
// // // // // // // // //     for (int j = 0; j < columns; j++)
// // // // // // // // //     {
// // // // // // // // //         Console.Write("\t" +symbol);
// // // // // // // // //     }
// // // // // // // // //     Console.WriteLine();
// // // // // // // // // }

// // // // // // // // //This is some good shit, need to learn this shit again
// // // // // // // // //aaja ni commit badhauna lai matra lekhdai chuu

// // // // // // // // //bujhyo //bujhyo


// // // // // // // // //Guess random number game

// // // // // // // // // Random random = new Random();
// // // // // // // // // bool playAgain = true;
// // // // // // // // // int min = 1;
// // // // // // // // // int max = 100;
// // // // // // // // // int guess;
// // // // // // // // // int number;
// // // // // // // // // int guesses;
// // // // // // // // // String response;

// // // // // // // // // while (playAgain)
// // // // // // // // // {
// // // // // // // // //     guess = 0;
// // // // // // // // //     guesses = 0;
// // // // // // // // //     response = "";
// // // // // // // // //     number = random.Next(min, max + 1);

// // // // // // // // //     while (guess != number)
// // // // // // // // //     {
// // // // // // // // //         System.Console.WriteLine("Guess a number between " + min + "-" + max + ":");
// // // // // // // // //         guess = Convert.ToInt32(Console.ReadLine());
// // // // // // // // //         System.Console.WriteLine("Guess: " + guess);

// // // // // // // // //         if(guess > number)
// // // // // // // // //         {
// // // // // // // // //             System.Console.WriteLine(guess + " is too high");
// // // // // // // // //         }
// // // // // // // // //         else if(guess < number)
// // // // // // // // //         {
// // // // // // // // //             System.Console.WriteLine(guess + " is too low");
// // // // // // // // //         }
// // // // // // // // //         guesses++;
// // // // // // // // //     }
// // // // // // // // //     Console.WriteLine("Number: " +number);
// // // // // // // // //     System.Console.WriteLine("YOU WIN!!");;
// // // // // // // // //     System.Console.WriteLine("Guess: " +guess);

// // // // // // // // //     Console.WriteLine("Would you like to play again (Y/N): ");
// // // // // // // // //     response = Console.ReadLine();
// // // // // // // // //     response = response.ToUpper();

// // // // // // // // //     if(response == "Y"){
// // // // // // // // //         playAgain = true;
// // // // // // // // //     }
// // // // // // // // //     else{
// // // // // // // // //         playAgain = false;
// // // // // // // // //     }

// // // // // // // // //     if(response!="Y"){
// // // // // // // // //         System.Console.WriteLine("Thanks for playing");
// // // // // // // // //     }
// // // // // // // // //     else{
// // // // // // // // //         System.Console.WriteLine("Let's start the game again!");
// // // // // // // // //     }


// // // // // // // // // }

// // // // // // // // // Rock Paper Scissors game

// // // // // // // // Random random = new Random();
// // // // // // // // bool playAgain = true;
// // // // // // // // String player;
// // // // // // // // String computer;
// // // // // // // // String answer;

// // // // // // // // while (playAgain)
// // // // // // // // {
// // // // // // // //     player = "";
// // // // // // // //     computer = "";
// // // // // // // //     answer = "";

// // // // // // // //     while (player != "ROCK" && player != "PAPER" && player != "SCISSORS")
// // // // // // // //     {
// // // // // // // //         Console.Write("Enter Rock, Paper, or Scissors: ");
// // // // // // // //         player = Console.ReadLine();
// // // // // // // //         player = player.ToUpper();
// // // // // // // //     }


// // // // // // // //     switch (random.Next(1, 4))
// // // // // // // //     {
// // // // // // // //         case 1:
// // // // // // // //             computer = "ROCK";
// // // // // // // //             break;
// // // // // // // //         case 2:
// // // // // // // //             computer = "PAPER";
// // // // // // // //             break;
// // // // // // // //         case 3:
// // // // // // // //             computer = "SCISSORS";
// // // // // // // //             break;
// // // // // // // //     }

// // // // // // // //     Console.WriteLine("Player: " + player);
// // // // // // // //     Console.WriteLine("Computer: " + computer);

// // // // // // // //     switch (player)
// // // // // // // //     {
// // // // // // // //         case "ROCK":
// // // // // // // //             if (computer == "ROCK")
// // // // // // // //             {
// // // // // // // //                 Console.WriteLine("It's a draw!");
// // // // // // // //             }
// // // // // // // //             else if (computer == "PAPER")
// // // // // // // //             {
// // // // // // // //                 Console.WriteLine("You lose!");
// // // // // // // //             }
// // // // // // // //             else
// // // // // // // //             {
// // // // // // // //                 Console.WriteLine("You win!");
// // // // // // // //             }
// // // // // // // //             break;
// // // // // // // //         case "PAPER":
// // // // // // // //             if (computer == "ROCK")
// // // // // // // //             {
// // // // // // // //                 Console.WriteLine("You win!");
// // // // // // // //             }
// // // // // // // //             else if (computer == "PAPER")
// // // // // // // //             {
// // // // // // // //                 Console.WriteLine("It's a draw!");
// // // // // // // //             }
// // // // // // // //             else
// // // // // // // //             {
// // // // // // // //                 Console.WriteLine("You lose!");
// // // // // // // //             }
// // // // // // // //             break;
// // // // // // // //         case "SCISSORS":
// // // // // // // //             if (computer == "ROCK")
// // // // // // // //             {
// // // // // // // //                 Console.WriteLine("You lose!");
// // // // // // // //             }
// // // // // // // //             else if (computer == "PAPER")
// // // // // // // //             {
// // // // // // // //                 Console.WriteLine("You win!");
// // // // // // // //             }
// // // // // // // //             else
// // // // // // // //             {
// // // // // // // //                 Console.WriteLine("It's a draw!");
// // // // // // // //             }
// // // // // // // //             break;
// // // // // // // //     }

// // // // // // // //     Console.Write("Would you like to play again (Y/N): ");
// // // // // // // //     answer = Console.ReadLine();
// // // // // // // //     answer = answer.ToUpper();

// // // // // // // //     if (answer == "Y")
// // // // // // // //     {
// // // // // // // //         playAgain = true;
// // // // // // // //     }
// // // // // // // //     else
// // // // // // // //     {
// // // // // // // //         playAgain = false;
// // // // // // // //     }

// // // // // // // // }

// // // // // // // // Console.WriteLine("Thanks for playing!");

// // // // // // // using System.Runtime.Intrinsics.Arm;

// // // // // // // do
// // // // // // // {
// // // // // // // double num1 = 0;
// // // // // // // double num2 = 0;
// // // // // // // double result = 0;

// // // // // // // Console.WriteLine("-----------------");
// // // // // // // System.Console.WriteLine("Calculator Program");
// // // // // // // Console.WriteLine("-----------------");

// // // // // // // System.Console.Write("Enter number 1: ");
// // // // // // // num1 = Convert.ToDouble(Console.ReadLine());

// // // // // // // System.Console.Write("Enter number 2: ");
// // // // // // // num2 = Convert.ToDouble(Console.ReadLine());

// // // // // // // System.Console.WriteLine("Enter an operand: ");;
// // // // // // // System.Console.WriteLine("\t+ : Add");
// // // // // // // System.Console.WriteLine("\t- : Subtract");
// // // // // // // System.Console.WriteLine("\t* : Multiply");
// // // // // // // System.Console.WriteLine("\t/ : Divide");
// // // // // // // System.Console.Write("Enter an option: ");
// // // // // // // switch (Console.ReadLine())
// // // // // // // {
// // // // // // //     case "+":
// // // // // // //     result = num1 + num2;
// // // // // // //     System.Console.WriteLine($"Your result: {num1}+{num2} = " + result);
// // // // // // //     break;
// // // // // // //      case "-":
// // // // // // //     result = num1 - num2;
// // // // // // //     System.Console.WriteLine($"Your result: {num1}-{num2} = " + result);
// // // // // // //     break;
// // // // // // //      case "*":
// // // // // // //     result = num1 * num2;
// // // // // // //     System.Console.WriteLine($"Your result: {num1}*{num2} = " + result);
// // // // // // //     break;
// // // // // // //      case "/":
// // // // // // //     result = num1 / num2;
// // // // // // //     System.Console.WriteLine($"Your result: {num1}/{num2} = " + result);
// // // // // // //     break;
// // // // // // //     default:
// // // // // // //     System.Console.WriteLine("Invalid option");
// // // // // // //     break;
// // // // // // // }
// // // // // // // System.Console.WriteLine("Would you like to continue? (Y/N)");
// // // // // // // }
// // // // // // // while(Console.ReadLine().ToUpper() == "Y");
// // // // // // // System.Console.WriteLine("Thanks for using the calculator!");

// // // // // // //Arrays

// // // // // // //array = a variable than can store multiple values, it's fixed size

// // // // // // // String[] cars = { "BMW", "Audi", "Porsche" };
// // // // // // // // for(int i = 0; i<car.Length; i++)
// // // // // // // // {
// // // // // // // //     System.Console.WriteLine(car[i]);
// // // // // // // // }


// // // // // // // foreach (String car in cars)
// // // // // // // {
// // // // // // //     Console.WriteLine(car);
// // // // // // // }

// // // // // // //method = performs a section of code, whenever it's called
// // // // // // //benefit = Let's us reuse code w/o writing it multiple times

// // // // // // static void singbday(string name, int age)
// // // // // // {
// // // // // //     Console.WriteLine("Happy Birthday to you " +name);
// // // // // //     System.Console.WriteLine("You are now " +age+ " years old!");
// // // // // //     System.Console.WriteLine();
// // // // // // }

// // // // // // String name = "Sichu";
// // // // // // int age = 21;
// // // // // // singbday(name,age);


// // // // // static double Multiply(double x, double y)
// // // // // {
// // // // //     double z = x * y;
// // // // //     return z;
// // // // // }

// // // // // //return - returns data back to the place where a method is invoked
// // // // // double x;
// // // // // double y;
// // // // // double result;

// // // // // System.Console.WriteLine("Enter in number 1: ");
// // // // // x = Convert.ToDouble(Console.ReadLine());

// // // // // System.Console.WriteLine("Enter in number 2: ");
// // // // // y = Convert.ToDouble(Console.ReadLine());

// // // // // result = Multiply(x,y);

// // // // // System.Console.WriteLine("The answer is: " +result);

// // // // //Method overloading = methods can share the same name, but different parameters
// // // // // name + parameters = signature
// // // // //methods must have a unique signature


// // // // double result;

// // // // result = Multiply(4, 5, 6);
// // // // System.Console.WriteLine("The answer is: " + result);


// // // // static double Multiply(double a, double b)
// // // // {
// // // //     return a * b;
// // // // }

// // // // static double Multiply(double a, double b, double c)
// // // // {
// // // //     return a * b * c;
// // // // }


// // // // params keyword = a method parameter that takes a variable number of arguments
// // // //must be a single dimensional array

// // //   double total = CheckOut(3.99, 5.75, 15, 1.00, 10.25);

// // //             Console.WriteLine(total);
// // //             Console.ReadKey();


// // //         static double CheckOut(params double[] prices)
// // //         {
// // //             double total = 0;

// // //             foreach (double price in prices)
// // //             {
// // //                 total += price;
// // //             }
// // //             return total;
// // //         }

// // //exception = errors that occur during execution
// //  //        try     = try some code that is considered "dangerous"
// //             //        catch   = catches and handles exceptions when they occur
// //             //        finally = always executes regardless if exception is caught or not

// //             int x;
// //             int y;
// //             double result;

// //             try
// //             {
// //                 Console.Write("Enter number 1: ");
// //                 x = Convert.ToInt32(Console.ReadLine());

// //                 Console.Write("Enter number 2: ");
// //                 y = Convert.ToInt32(Console.ReadLine());

// //                 result = x / y;

// //                 Console.WriteLine("result: " + result);
// //             }
// //             catch (FormatException e)
// //             {
// //                 Console.WriteLine("Enter ONLY numbers PLEASE!");
// //             }
// //             catch (DivideByZeroException e)
// //             {
// //                 Console.WriteLine("You can't divide by zero! IDIOT!");
// //             }
// //             catch (Exception e)
// //             {
// //                 Console.WriteLine("Something went wrong!");
// //             }
// //             finally
// //             {
// //                 Console.WriteLine("Thanks for visiting!");
// //             }


// // conditional operator = used in conditional assignment if a condition is true/false

//             //(condition) ? x : y
//             Console.WriteLine("What's the temperature outside?");
//             double temperature = Convert.ToInt32(Console.ReadLine());
//             String message;

//             message = (temperature >= 15) ? "It's warm outside!" : "It's cold outside!";

//             Console.WriteLine(message);

// String [,] carList = {
//     {"Mustang", "F-150", "Explorer"},
//     {"Corvette", "Camaro", "Silverado"},
//     {"Corolla", "Camry", "Rav4"}
// };

// carList[0,2] =  "Fusion";
// foreach(String car in carList)
// {
//     System.Console.WriteLine(car);
// }

// class Add
// {
//     void sum()
//     {
//         int a = 10, b = 10;
//         int c = a + b;
//     }
// }

// class Subtract
// {
//     void diff()
//     {

//     }

// }

// using System;

// class Add
// {
//     // Method to calculate and return the sum
//     public int Sum()
//     {
//         int a = 10, b = 10;
//         return a + b;
//     }
// }

// class Subtract
// {
//     // Method to calculate and return the difference
//     public int Diff()
//     {
//         Add obj = new Add(); // Creating an object of the Add class
//         int resultFromAdd = obj.Sum(); // Calling the Sum method from the Add class
//         int num1 = 8, num2 = 3;
//         int difference = resultFromAdd - (num1 + num2); // Calculating the difference
//         return difference;
//     }
// }

// class Program
// {
//     static void Main()
//     {
//         Subtract subtractObj = new Subtract(); // Creating an object of the Subtract class
//         int result = subtractObj.Diff(); // Calling the Diff method from the Subtract class

//         // Printing the result of subtraction
//         Console.WriteLine("Difference: " + result);
//     }
// }

// using System;

// class Add
// {
//     // Method to calculate and return the sum
//     public int Sum()
//     {
//         int a = 10, b = 10;
//         return a + b;
//     }
// }

// class Subtract
// {
//     // Property to store the result from the Sum method
//     public int ResultFromAdd { get; }

//     // Method to calculate and return the difference
//     public int Diff()
//     {
//         Add obj = new Add(); // Creating an object of the Add class
//         ResultFromAdd = obj.Sum(); // Calling the Sum method from the Add class

//         int num1 = 8, num2 = 3;
//         int difference = ResultFromAdd - (num1 + num2); // Calculating the difference

//         return difference;
//     }
// }

// class Program
// {
//     static void Main()
//     {
//         Subtract subtractObj = new Subtract(); // Creating an object of the Subtract class
//         int resultFromSubtract = subtractObj.Diff(); // Calling the Diff method from the Subtract class

//         // Printing the results
//         Console.WriteLine("Sum: " + subtractObj.ResultFromAdd); // Printing the result of addition
//         Console.WriteLine("Difference: " + resultFromSubtract); // Printing the result of subtraction
//     }
// }

String[,] parkingLot = { { "Mustang", "F-150", "Explorer" },
                                                   { "Corvette", "Camaro", "Silverado" },
                                                   { "Corolla", "Camry", "Rav4" }
                                                 };

parkingLot[0, 2] = "Fusion";
parkingLot[2, 0] = "Tacoma";
/*
foreach(String car in parkingLot)
{
    Console.WriteLine(car);
}
*/
for (int i = 0; i < parkingLot.GetLength(0); i++)
{
    for (int j = 0; j < parkingLot.GetLength(1); j++)
    {
        Console.Write(parkingLot[i, j] + "\t");
    }
    Console.WriteLine();
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorExample1
{
   
    public class Program
    {
        public double salary;
        public int age;
        public String name;
        public String address;
        public int a, b, c;
        public Program(string name, string address)
        {
            this.name = name; 
            this.address = address;
            Console.WriteLine("His name is " +name + ".");
            Console.WriteLine("His address is " +address + ".");
        }
     
        public Program(double salary)
        {
            this.salary = salary;
            Console.WriteLine("His salary is " + salary + ".");
        }
        public Program(int age)
        {
            this.age = age;
            Console.WriteLine("His age is " + age + ".");
        }

        public Program()
        {
        }

       public void display()
        {
            int a = 10;
            int b = 20;
            c = a + b;
            Console.WriteLine("The sum is " +c + ".");
        }
     
        static void Main(string[] args)
        {
            Program obj2 = new Program("Saral", "Suryabinayak");
            Program obj3 = new Program(21);
            Program obj1 = new Program(50000.00); 
            Program obj4 = new Program();
            obj4.display();
            Console.ReadLine();
        }
        
    }
}
