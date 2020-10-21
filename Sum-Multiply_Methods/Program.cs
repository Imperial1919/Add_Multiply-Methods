using System;

namespace Sum_Multiply_Methods
{
    class Program
    {

        public static int Add()
        {

            bool conditional = true;
            Console.WriteLine("Hello User! Please, type in a number any number.... That's a integer.");
            string userinput1 = Console.ReadLine();
            int firstnumber  = Int32.Parse(userinput1);
            Console.WriteLine("And another please.");
            string userinput2 = Console.ReadLine();
            int secondnumber = Int32.Parse(userinput2);



            int answer = firstnumber + secondnumber;
            Console.WriteLine($"Ok, so your answer is {answer}.");
            Console.WriteLine("Would you like to add more numbers?");
            var cont = Console.ReadLine().ToLower();
            switch (cont) {
                case "yes":
                    Console.WriteLine("Wonderful!");
                    Add();
                    break;
                case "no":
                    Console.WriteLine("I see, Have a nice day!");
                    break;
            }

            
            return answer;
        }


        public static int Multiply()
        {

            bool conditional1 = true;
            Console.WriteLine("Hello User! Please, type in a number any number.... That's a integer.");
            string userinput1 = Console.ReadLine();
            int firstnumber = Int32.Parse(userinput1);
            Console.WriteLine("And another please.");
            string userinput2 = Console.ReadLine();
            int secondnumber = Int32.Parse(userinput2);


            /// I think I just overloaded a method.
            int answer = firstnumber * secondnumber;
            Console.WriteLine($"Ok, so your answer is {answer}.");
            Console.WriteLine("Would you like to add more numbers?");
            var cont = Console.ReadLine().ToLower();
            switch (cont)
            {
                case "yes":
                    Console.WriteLine("Wonderful!");
                    Multiply();
                    break;
                case "no":
                    Console.WriteLine("I see, Have a nice day!");
                    break;
            }


            return answer;
        }



        static void Main(string[] args)
        {
            Multiply();
        }
    }
}
