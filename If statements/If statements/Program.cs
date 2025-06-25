// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

//WAP to checkk greater or lower variable betwern 2 variable



//if (10 < 20)
//{
//    Console.WriteLine("20 is greater then 10");
//}

//using System; 

//class IfElse
//{
//    static void Main(string[] args) 
//    {
//        int month = 12;
//        int year = 2081;

//        if (month <= year)
//        {
//            Console.WriteLine("Month is smaller than year"); 
//        }
//        else
//        {
//            Console.WriteLine("Month is greater than year");
//        }
//    }
//}


//WAP to display current day
//class ifelse
//{
//    static void Main(String[] args)
//    {
//        string day = "sunday";

//        if(day == "sunday")
//        {
//            Console.WriteLine("Today is sunday");
//        }
//    }
//}



//WAP to display if student age is above 18 and check their gender and dispaly their gender and Weather they are verified or not

//class IFElse
//{
//    static void Main(string[] args)
//    {
//        int age = 20;
//        String gender = "male";

//        if(age > 18 )
//        {
//            if (gender == "male")
//            {
//                Console.WriteLine("user age is above 18 and user is male ");
//            }
//        }

//    }
//}

//class IfElse
//{ 
//    static void Main(string[] args)
//    {
//        String day = "Sunday";

//        switch(day)
//        {
//            case "Monday":
//                Console.WriteLine("Monday");
//                break;
//            case "Tuesday":
//                Console.WriteLine("Tuesdy");
//                break;
//            case "Wednesday":
//                Console.WriteLine("Wednesday");
//                break;
//            case "Thursasy":
//                Console.WriteLine("Thursday");
//                break;
//            case "Friday":
//                Console.WriteLine("Friday");
//                break;
//            case "Sunday":
//                Console.WriteLine("Sunday");
//                break;
//        }

//    }
//}


//class IFElse
//{
//    static void Main(string[] args)
//    {
//        int age = 26;
//        string edu = "Bachelor";


//        if( age > 20 && edu == "Bachelor")
//        {
//            Console.WriteLine("Entery_level, Eligible for Internship");
//        }
//        else if( age > 25 && edu =="Masters")
//        {
//            Console.WriteLine("Senior-level,Eligible for Project manager");
//        }
//    }
//}



using System;

class JobEligibility
{
    static void Main(string[] args)
    {
        // Ask for user details
        Console.Write("Enter your age: ");
        int age = int.Parse(Console.ReadLine());

        Console.WriteLine("Select your education level:");
        Console.WriteLine("1. High School");
        Console.WriteLine("2. Bachelor's Degree");
        Console.WriteLine("3. Master's Degree");
        Console.Write("Enter your choice (1/2/3): ");
        int educationLevel = int.Parse(Console.ReadLine());

        // Determine job eligibility using nested if and else-if ladder
        if (age >= 18 && age <= 30)
        {
            Console.WriteLine("You qualify for Entry-Level jobs.");

            switch (educationLevel)
            {
                case 1:
                    Console.WriteLine("Recommended Job: Intern");
                    break;
                case 2:
                    Console.WriteLine("Recommended Job: Junior Developer");
                    break;
                case 3:
                    Console.WriteLine("Recommended Job: Assistant Manager");
                    break;
                default:
                    Console.WriteLine("Invalid education level.");
                    break;
            }
        }
        else if (age > 30)
        {
            Console.WriteLine("You qualify for Senior-Level jobs.");

            switch (educationLevel)
            {
                case 1:
                    Console.WriteLine("Recommended Job: Supervisor");
                    break;
                case 2:
                    Console.WriteLine("Recommended Job: Project Manager");
                    break;
                case 3:
                    Console.WriteLine("Recommended Job: Senior Consultant");
                    break;
                default:
                    Console.WriteLine("Invalid education level.");
                    break;
            }
        }
        else
        {
            Console.WriteLine("Sorry, you are not eligible for any jobs yet.");
        }

        Console.ReadLine(); // Pause console to view output
    }
}