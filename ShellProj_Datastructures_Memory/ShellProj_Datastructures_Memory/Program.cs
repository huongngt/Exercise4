using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShellProj_Datastructures_Memory
{
    class Program
    {
        /// <summary>
        /// The main method, will handle the menues for the program
        /// </summary>
        /// <param name="args"></param>
        static void Main()
        {
            bool run = true;
            while (true)
            {

                Console.WriteLine("Please navigate through the menu by inputting the number \n(1, 2, 3 ,4, 0) of your choice"
                    + "\n1. Examine a List"
                    + "\n2. Examine a Queue"
                    + "\n3. Examine a Stack"
                    + "\n4. CheckParanthesis"
                    + "\n0. Exit the application");
                char input = ' '; //Creates the character input to be used with the switch-case below.
                try
                {
                    input = Console.ReadLine()[0]; //Tries to set input to the first char in an input line
                }
                catch (IndexOutOfRangeException) //If the input line is empty, we ask the users for some input.
                {
                    Console.Clear();
                    Console.WriteLine("Please enter some input!");
                }
                switch (input)
                {
                    case '1':
                        ExamineList();
                        break;
                    case '2':
                        ExamineQueue();
                        break;
                    case '3':
                        ExamineStack();
                        break;
                    case '4':
                        CheckParanthesis();
                        break;
                    /*
                     * Extend the menu to include the recursive 
                     * and iterative exercises.
                     */
                    case '0':
                        return;
                    default:
                        Console.WriteLine("Please enter some valid input (0, 1, 2, 3, 4)");
                        break;
                }
            }
        }

        /// <summary>
        /// Examines the datastructure List
        /// </summary>
        public static void ExamineList()
        {
            /*
             * Loop this method untill the user inputs something to exit to main menue.
             * Create a switch statement with cases '+' and '-'
             * '+': Add the rest of the input to the list (The user could write +Adam and "Adam" would be added to the list)
             * '-': Remove the rest of the input from the list (The user could write -Adam and "Adam" would be removed from the list)
             * In both cases, look at the count and capacity of the list
             * As a default case, tell them to use only + or -
             * Below you can see some inspirational code to begin working.
            */

            List<string> theList = new List<string>();

            do {


                Console.WriteLine("Please enter values with '+' or '-' ");
                string input = Console.ReadLine();


                if (input == "0")
                {
                    break;
                }
                char nav = input[0];
                string value = input.Substring(1);
                //switch(nav){...}

                switch (nav)
                {
                    case '+':

                        theList.Add(value);
                        break;
                    case '-':
                        theList.Remove(value);
                        Console.WriteLine("Value removed from the list is: " + value);
                        break;
                    default:
                        Console.WriteLine("Please use + or -");
                        break;
                }
                foreach (var item in theList)
                {
                    Console.WriteLine("Values added to the list are: " + item);
                }

                Console.WriteLine("----------------------------------------------------");
                Console.WriteLine("Total Values added to list :" + theList.Count);
                Console.WriteLine("Capacity of the list is :" + theList.Capacity);
                Console.WriteLine("----------------------------------------------------");


            } while (true);
            Console.Clear();
            Console.ReadLine();
        }

        /// <summary>
        /// Examines the datastructure Queue
        /// </summary>
        static void ExamineQueue()
        {
            /*
             * Loop this method untill the user inputs something to exit to main menue.
             * Create a switch with cases to enqueue items or dequeue items
             * Make sure to look at the queue after Enqueueing and Dequeueing to see how it behaves
            */
            Queue<string> Testqueue = new Queue<string>();
            do
            {

                //string input = Console.ReadLine();
                Console.WriteLine("\n Press 1 to enter the Queue," +
             "\n Press 2 to leave from the Queue,\n Press 3 to see the list on queue,\n press 0 to quit ");
                char input = ' '; //Creates the character input to be used with the switch-case below.
                try
                {
                    input = Console.ReadLine()[0]; //Tries to set input to the first char in an input line
                }
                catch (IndexOutOfRangeException) //If the input line is empty, we ask the users for some input.
                {
                    Console.Clear();
                    Console.WriteLine("Please enter some input!");
                }

                if (input == '0')
                {
                    break;
                }


                string name1;
                switch (input)
                {
                    case '1':
                        Console.WriteLine("Please input your name:");
                        name1 = Console.ReadLine();
                        //Console.WriteLine("name added to queue " + name1);
                        Testqueue.Enqueue(name1);
                        Console.WriteLine("Count on Queue " + Testqueue.Count);

                        break;
                    case '2':
                        if (Testqueue.Count > 0)
                        {
                            foreach (var item in Testqueue)
                            {

                                Console.WriteLine("Names added to the Queue  " + item);

                            }
                            Console.WriteLine("Count on Queue " + Testqueue.Count);
                            Console.WriteLine("-------------------------------------");

                            Console.WriteLine("Implementing first in first out from the queue:");
                            Console.WriteLine("name deleted from queue :" + Testqueue.Dequeue());
                            Console.WriteLine("Count on Queue " + Testqueue.Count);
                        }
                        else
                        {
                            Console.WriteLine("Queue is empty,name cannot be deleted");
                        }
                        break;
                    case '3':

                        foreach (var item in Testqueue)
                        {
                            Console.WriteLine("-------------------------------------");
                            Console.WriteLine("Names added to the Queue  " + item);
                            Console.WriteLine("-------------------------------------");
                        }
                        Console.WriteLine("Count on Queue " + Testqueue.Count);
                        Console.WriteLine("-------------------------------------");
                        break;
                    default:
                        Console.WriteLine("Invalid input,to continue press 1,2,3 or 0");
                        break;
                }


            } while (true);
            Console.Clear();
            Console.ReadLine();


        }

        /// <summary>
        /// Examines the datastructure Stack
        /// </summary>
        static void ExamineStack()
        {
            /*
             * Loop this method until the user inputs something to exit to main menue.
             * Create a switch with cases to push or pop items
             * Make sure to look at the stack after pushing and and poping to see how it behaves
            */
            Stack<string> testStack = new Stack<string>();
            do
            {
                Console.WriteLine("\n Press 1 to Push," +
             "\n Press 2 to Pop,\n Press 3 to Reverse a String\n press 0 to quit ");
                char input = ' '; //Creates the character input to be used with the switch-case below.
                try
                {
                    input = Console.ReadLine()[0]; //Tries to set input to the first char in an input line
                }
                catch (IndexOutOfRangeException) //If the input line is empty, we ask the users for some input.
                {
                    Console.Clear();
                    Console.WriteLine("Please enter some input!");
                }

                if (input == '0')
                {
                    break;
                }

                switch (input)
                {
                    case '1':
                        Console.WriteLine("Please provide input:");
                        string name = Console.ReadLine();
                        testStack.Push(name);
                        foreach (var item in testStack)
                        {
                            Console.WriteLine("Names in the stack are " + item);
                        }
                        Console.WriteLine("Count in the stack: " + testStack.Count);
                        break;
                    case '2':
                        if (testStack.Count > 0)
                        {
                            Console.WriteLine("Implementing Last In First Out");
                            Console.WriteLine("Name removed from the stack is " + testStack.Pop());
                            foreach (var item in testStack)
                            {
                                Console.WriteLine("Names in the stack are " + item);
                            }
                            Console.WriteLine("Count in the stack :" + testStack.Count);
                        }
                        else
                        {
                            Console.WriteLine("Stack is empty,name cannot be deleted");
                        }
                        break;
                    case '3':
                        Console.WriteLine("Enter some input value");
                        string inputString = Console.ReadLine();
                        Stack<string> inputStack = new Stack<string>();
                        for (int i = 0; i < inputString.Length; i++)
                            inputStack.Push(inputString.Substring(i, 1));
                        string resultstring = string.Empty;
                        for (int i = 0; i < inputString.Length; i++)
                            resultstring += inputStack.Pop();
                        Console.WriteLine("Reversed string is " + resultstring);
                        break;


                }


            } while (true);
            Console.Clear();
        }

        static void CheckParanthesis()
        {
            /*
             * Use this method to check if the paranthesis in a string is Correct or incorrect.
             * Example of correct: (()), {}, [({})]
             * Example of incorrect: (()]), [), {[()}]
             */
            Console.WriteLine("Please enter some input");
            string input=Console.ReadLine();
             
            Dictionary<char, char> bracketPairs = new Dictionary<char, char>() {
            { '(', ')' },
            { '{', '}' },
            { '[', ']' },
            { '<', '>' }
                      };

            Stack<char> brackets = new Stack<char>();
            //string result;
            try {
                // Iterate through each character in the input string
                foreach (char c in input)
                {
                    // check if the character is one of the 'opening' brackets
                    if (bracketPairs.Keys.Contains(c))
                    {
                        // if yes, push to stack
                        brackets.Push(c);
                    }
                    else {
                        // check if the character is one of the 'closing' brackets
                           if (bracketPairs.Values.Contains(c))
                            {
                            // check if the closing bracket matches the 'latest' 'opening' bracket
                                        if (c == bracketPairs[brackets.First()])
                                        {
                                            brackets.Pop();
                                        }
                                        else
                                        {
                                           brackets.Push('c');
                                // if not, its an unbalanced string
                                //  Console.WriteLine("Its an unbalanced string");
                            }
                               }
                         else
                            // continue looking
                         continue;
                    }  

                }

            }
            catch
            {
                // an exception will be caught in case a closing bracket is found, 
                // before any opening bracket.
                // that implies, the string is not balanced.
              
             //  Console.WriteLine("Closing bracket is found first");
                brackets.Push('c');
               

               }

            // Ensure all brackets are closed

            if (brackets.Count() == 0)
            {

                Console.WriteLine("String is Balanced");
                Console.ReadLine();
               
            }
            else
            {
                Console.WriteLine("String is not Balanced");
                Console.ReadLine();
               
            }
            Console.Clear();
        }
        

    

    }


}
