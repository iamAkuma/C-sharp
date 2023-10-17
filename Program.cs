// // Console.Write("Hey, "); //This code will not create a new line
// // Console.WriteLine("Hello, World!");
// // Console.Beep();
// // Console.WriteLine("aKuma \n"); //This will create a space between this code and below code
// // Console.WriteLine("Hello Bro!");

// // int x; //declaration
// // x = 10; //init value

// // int y = 10;
// // int z = x + y;
// // Console.WriteLine(z);

// // int age = 21;
// // double height = 177.8; //decimal number
// // bool alive = true; //true or false
// // char symbol = '@';
// // String name = "akuma_saral";
// // String userName = symbol + name;
// // String unit = "cm";

// //constants = change garna namilos future line of code ma

// // const double pi = 3.14;

// // Console.WriteLine("The value of Pi is: " + pi);
// // Console.WriteLine("My name is " + name);
// // Console.WriteLine("My username is: " + userName);
// // Console.WriteLine("Your age is " + z);
// // Console.WriteLine("Your brother's age is " + age);
// // Console.WriteLine("Your height is " + height + unit);
// // Console.WriteLine("Are you alive?" + alive);
// // Console.WriteLine("Your symbol is " + symbol);

// // double a = 3.14;
// // int b = Convert.ToInt32(a); //Converts double to int

// // //Checking variable's data types
// // Console.WriteLine(a.GetType());
// // Console.WriteLine(b.GetType());
// // Console.WriteLine(b);

// //TypeCasting rey

// // int c = 321;
// // String e = Convert.ToString(c);

// // String f = "$";
// // char g = Convert.ToChar(f);

// // Console.WriteLine(e.GetType());
// // Console.WriteLine(g);
// // Console.WriteLine("What is your name?");
// // String name = Console.ReadLine();

// // Console.WriteLine("What is your age?");
// // int age = Convert.ToInt32(Console.ReadLine());


// // Console.WriteLine("Hello " + name);
// // Console.WriteLine("Your age is  " + age);

// // Console.ReadKey();

// // int friends = 10;
// // // friends--;
// // // friends++;
// // // friends+=2;
// // // friends -=1;
// // // friends *=2;
// // // friends /=2;
// // int remainder = friends % 2;

// // Console.WriteLine(remainder);

// // int i;
// // string[] friends = { "Friend1", "Friend2", "Friend3", "Friend4", "Friend5" };

// // for (i = 0; i < friends.Length; i++)
// // {
// //     Console.WriteLine(friends[i]);
// // }

// // double x = 3.99;
// // double y = 5;

// // double a = Math.Pow(x, 2);
// // double a = Math.Sqrt(x);
// // double a = Math.Abs(x);
// // double a = Math.Round(x);
// // double a = Math.Ceiling(x);
// // double a = Math.Floor(x);
// // double a = Math.Max(x,y);
// // double b = Math.Min(x,y);

// // Console.WriteLine(b);

// // Random random = new Random();

// // int num = random.Next(1,7);
// // int num1 = random.Next(1,7);
// // int num2 = random.Next(1,7);

// // // double num = random.NextDouble();
// // System.Console.WriteLine(num);
// // System.Console.WriteLine(num1);
// // System.Console.WriteLine(num2);

// Console.WriteLine("Enter Side A: ");
// double a = Convert.ToDouble(Console.ReadLine());

// Console.WriteLine("Enter Side B: ");
// double b = Convert.ToDouble(Console.ReadLine());

// double c = Math.Sqrt((a * a) + (b * b));
// System.Console.WriteLine("The hypotenuse is: " +c);

// String fullName = "Saral";
// fullName = fullName.ToUpper();
// fullName = fullName.ToLower();
// System.Console.WriteLine(fullName);

// int i;
// int sum = 0;
// for (i=1 ; i<=5 ; ++i){
//     sum += i;

// }
// System.Console.WriteLine("The sum of 1 to 5 is: "+sum);

// String phoneNumber = "123-456-7890";
// phoneNumber=phoneNumber.Replace("-","");
// System.Console.WriteLine(phoneNumber);

// String fullName = "saral";
// String userName = fullName.Insert(0,"@");
// System.Console.WriteLine(userName);

// int [] arr = new int[5];
// arr[0] = 1 ;
// arr[1] = 2;
// arr[2] = 3 ;
// arr[3] = 4 ;
// arr[4] = 5 ;

// int sum = arr[2] + arr [3];
// System.Console.WriteLine(sum);


//College ma gareko revision
// int[][] jArray = new int[3][];

// jArray[0] = new int[2] { 1, 2 };
// jArray[1] = new int[3] { 1, 2, 3 };
// jArray[2] = new int[4] { 1, 2, 3, 4 };

// for (int i = 0; i < jArray.Length; i++)
// {
//     for (int j = 0; j < jArray[i].Length; j++)
//     {
//         System.Console.Write(jArray[i][j] + "\t");
//     }
//     System.Console.WriteLine();
// }

//if statements
// System.Console.WriteLine("Please Enter your age: ");
// int age = Convert.ToInt32(Console.ReadLine());

// if (age >= 18 && age < 100)
// {
//     System.Console.WriteLine("Congrats, You can watch porn.");
// }
// else if (age >= 100)
// {
//     System.Console.WriteLine("Die already, bitch!");
// }
// else if (age <= 0)
// {
//     System.Console.WriteLine("Pahila yo duniya ma ta aaija!");

// }
// else
// {
//     System.Console.WriteLine("Grow up kid!");

// }

//nested if
// Console.WriteLine("Enter your age: ");
// int age = Convert.ToInt32(Console.ReadLine());

// if(age >= 18 )
// {
//     System.Console.WriteLine("You are an adult.");
//     if(age > 18)
//     {
//     System.Console.WriteLine("You are older than 18 years old!");
//     }
//     else {
//         System.Console.WriteLine("You are not older than 18 years old.");
//     }
// }
// else{
//     System.Console.WriteLine("You are still a minor.");
// }


//Sum of array

// class Program
// {
//     static void displayArr(int[] arr)
//     {
//         int sum = 0;
//         Console.WriteLine("Entered elements:");

//         for (int i = 0; i < arr.Length; i++)
//         {
//             Console.WriteLine(arr[i]);
//             sum += arr[i];
//         }

//         Console.WriteLine("Sum of elements: " + sum);
//     }

//     static void Main(string[] args)
//     {
//         int[] arr = new int[4];

//         for (int i = 0; i < 4; i++)
//         {
//             Console.Write("Enter element " + (i + 1) + ": ");
//             arr[i] = Convert.ToInt32(Console.ReadLine());
//         }

//         Program.displayArr(arr);
//     }
// }

// Iteration statements

//do-while loop
// int i=1;
// do
// {
//     System.Console.WriteLine(i);
//     i++;

// }
// while(i<=10);

//for loop
//  int i;
// for(i = 1; i <=10; i++){
// System.Console.WriteLine(i);
// }


//while loop
// int i = 1;
// while(i<=5)
// {
//     System.Console.WriteLine(i);
//     i++;
// }


//switch case
//  System.Console.WriteLine("What day is it today?");
//  string day = Console.ReadLine();

//  switch(day)
//  {
//     case "Sunday":
//     System.Console.WriteLine("Today is Sunday");
//     break;
//     case "Monday":
//     System.Console.WriteLine("Today is Monday");
//     break;
//     case "Tuesday":
//     System.Console.WriteLine("Today is Tuesday");
//     break;
//     case "Wednesday":
//     System.Console.WriteLine("Today is Wednesday");
//     break;
//     case "Thursday":
//     System.Console.WriteLine("Today is Thursday");
//     break;
//     case "Friday":
//     System.Console.WriteLine("Today is Friday");
//     break;
//     case "Saturday":
//     System.Console.WriteLine("Today is Saturday");
//     break;
//     default:
//     System.Console.WriteLine(day + " is not a day.");
//     break;
//  }

// nested loops = loops inside of other loops
            //                Uses vary. Used a lot in sorting algorithms

            Console.Write("How many rows?: ");
            int rows = Convert.ToInt32(Console.ReadLine());

            Console.Write("How many columns?: ");
            int columns = Convert.ToInt32(Console.ReadLine());

            Console.Write("What symbol: ");
            String symbol = Console.ReadLine();

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write(symbol);
                }
                Console.WriteLine();
            }

            //This is some good shit, need to learn this shit again
            //aaja ni commit badhauna lai matra lekhdai chuu

            //bujhyo //bujhyo
