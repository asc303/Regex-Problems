﻿
using System;

namespace REGEXUserRegistration
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to REGEX User Registration");
            UserRegistration validation = new UserRegistration();
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Welcome to the User Registration validation program");
                Console.WriteLine("Enter the validation to Execute : \n 1. Candidate First Name \n 2. Candidate Last Name \n 3. Candidate Email \n 4. Exit");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        Console.WriteLine(validation.ValidateFirstName("Ashutosh"));
                        break;
                    case 2:
                        Console.WriteLine(validation.ValidateLastName("Singh"));
                        break;
                    case 3:
                        Console.WriteLine(validation.ValidateEmail("Chauhansam94@gmail.com"));
                        break;
                    case 4:
                        flag = false;
                        break;
                }
            }
        }
    }
}