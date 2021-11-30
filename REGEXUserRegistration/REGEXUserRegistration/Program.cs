﻿using System;

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
                Console.WriteLine("Enter the validation to Execute : \n 1. Candidate First Name \n 2. Candidate Last Name \n 3. Candidate Email \n 4. Mobile Number \n 5. Password Rule=1 \n 6. Password Rule=2 \n 7. Password Rule=3 \n 8. Password Rule=4 \n 9. Exit");
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
                        Console.WriteLine(validation.ValidateMobile("91 9696896592"));
                        break;
                    case 5:
                        Console.WriteLine(validation.ValidatePassword1("Ashu"));
                        break;
                    case 6:
                        Console.WriteLine(validation.ValidatePassword2("Ashu1"));
                        break;
                    case 7:
                        Console.WriteLine(validation.ValidatePassword3("Ashu2"));
                        break;
                    case 8:
                        Console.WriteLine(validation.ValidatePassword4("Ashu3"));
                        break;
                    case 9:
                        flag = false;
                        break;
                }
            }
        }
    }
}