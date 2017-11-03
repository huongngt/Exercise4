using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
                Console.Clear();
                Console.WriteLine("Please navigate through the menu by inputting the number \n(1, 2, 3 ,4, 5, 6, 0) of your choice"
                    + "\n1. Examine a List"
                    + "\n2. Examine a Queue"
                    + "\n3. Examine a Stack"
                    + "\n4. CheckParanthesis"
                    + "\n5. Examine recursion"
                    + "\n6. Examine iteration"
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
                    case '5':
                        ExamineRecursion();
                        break;
                    case '6':
                        ExamineIteration();
                        break;
                    case '0':
                        return;
                    default:
                        Console.WriteLine("Please enter some valid input (0, 1, 2, 3, 4)");
                        break;
                }
            }
        }

        #region Main_Method

        /// <summary>
        /// Examines the datastructure List
        /// </summary>
        static void ExamineList()
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
            do
            {
                Console.Clear();
                Console.WriteLine("List contains:");
                Console.WriteLine(DisplayList(theList));
                Console.WriteLine("--------------------------------------------------");
                Console.WriteLine("Please input +string to put person to the list");
                Console.WriteLine("Please input -string to take person from the list");
                Console.WriteLine("Input 0 or Enter to come back to main menu");
                string input = Console.ReadLine();

                // if user enter 0 then exit to main menu
                if (input == "0" || input.Length == 0) break;

                char nav = input[0];
                string value = input.Substring(1);

                //if user enter only "+" or "-" then inform that can not process empty element
                if (value.Length == 0)
                {
                    MessageBox.Show("You can not input the empty string");
                    continue;
                }

                //normal case
                switch (nav)
                {
                    case '+':                    
                        theList.Add(value);
                        break;
                    case '-': 
                        //if user remove non-existance value, inform that the value not found                       
                        if (!theList.Remove(value))
                            MessageBox.Show("Inputed string " + value + " not found. Or the list is empty.");                                              
                        break;
                    default:
                        MessageBox.Show("Please only use + or - to update list");
                        //System.Threading.Thread.Sleep(500);
                        break;
                }
                
            } while (true);
            
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

            Queue theQueue = new Queue();
            do
            {
                Console.Clear();
                Console.WriteLine(DisplayList(theQueue));
                Console.WriteLine("--------------------------------------------------");
                Console.WriteLine("Input +string to put person into queue");
                Console.WriteLine("Input - to take person from queue");
                Console.WriteLine("Input 0 or Enter to come back to main menu");
                string input = Console.ReadLine();
                if (input == "0" || input.Length == 0) break;

                char nav = input[0];
                string value = input.Substring(1);
                switch (nav)
                {
                    case '+':
                        if (value.Length == 0)
                            MessageBox.Show("Name can not be empty");
                        else
                            theQueue.Enqueue(value);
                        break;
                    case '-':
                        if (theQueue.Count > 0)
                            theQueue.Dequeue();
                        else
                            MessageBox.Show("The queue is now empty");
                        break;
                    default:
                        MessageBox.Show("Please only use + or - to update queue");
                        //System.Threading.Thread.Sleep(500);
                        break;
                }

            } while (true);
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
            Stack theStack = new Stack();
            do
            {
                Console.Clear();
                Console.WriteLine(DisplayList(theStack));
                Console.WriteLine("--------------------------------------------------");
                Console.WriteLine("Input +string to put person into stack");
                Console.WriteLine("Input - to take person from stack");
                Console.WriteLine("Input #string to reverse string");
                Console.WriteLine("Input 0 or Enter to come back to main menu");
                string input = Console.ReadLine();
                if (input == "0" || input.Length == 0) break;

                char nav = input[0];
                string value = input.Substring(1);
                switch (nav)
                {
                    case '+':
                        if (value.Length == 0)
                            MessageBox.Show("Name can not be empty");
                        else
                            theStack.Push(value);
                        break;
                    case '-':
                        if (theStack.Count > 0)
                            theStack.Pop();
                        else
                            MessageBox.Show("The stack is now empty");
                        break;
                    case '#':
                        if (value.Length == 0)
                            MessageBox.Show("String can not be empty");
                        else                        
                            Console.WriteLine("Reversed string: " + ReverseString(value));                        
                        break;
                    default:
                        MessageBox.Show("Please only use +,- or # to update stack");
                        //System.Threading.Thread.Sleep(500);
                        break;
                }

            } while (true);

        }

        static void CheckParanthesis()
        {
            /*
             * Use this method to check if the paranthesis in a string is Correct or incorrect.
             * Example of correct: (()), {}, [({})]
             * Example of incorrect: (()]), [), {[()}]
             */
            do
            {
                Console.Clear();
                Console.WriteLine("Please input string to check paranthesis: ");
                Console.WriteLine("Press Enter to come back main menu: ");
                string input = Console.ReadLine();

                //If user enter empty string, inform they need enter valid string
                if (input.Length == 0) break;

                //Queue to contain paranthesis character in inputed string
                Queue theQueue = new Queue();
                char[] paranthesis = new char[] { '<', '>', '{', '}', '[', ']', '(', ')' };

                //algorithm: go through all character in string
                //If it is a parenthesis then:
                //If the stack is empty, put it into the stack
                //If the stack is not empty => compare it with the first element in stack
                //if not match => put it to stack
                //If match => take the element from the stack
                //If the stack is empty (everything has matched) -> input string is well formed. Otherwise -> not well formed.
                Stack theStack = new Stack();
                foreach (char ch in input)
                {
                    if (paranthesis.Contains(ch))
                    {
                        if (theStack.Count == 0 || !MatchCouple((char)theStack.Peek(),ch))
                        {
                            theStack.Push(ch);
                        }
                        else
                        {
                            theStack.Pop();
                        }
                    }                   
                       
                }                

                if (theStack.Count == 0)
                    Console.WriteLine("Inputed string is well formed");
                else
                    Console.WriteLine("Inputed string is NOT well formed");
                Console.ReadLine();
            } while (true);
            

        }

        private static void ExamineRecursion()
        {
            do
            {
                Console.Clear();
                Console.WriteLine("Input 0 or Enter to come back to main menu");
                Console.WriteLine("Input +number to calculate n:th even number");
                Console.WriteLine("Input -number to print n first number in fibonacci");
                string input = Console.ReadLine();
                if (input == "0" || input.Length == 0) break;             

                char nav = input[0];
                string value = input.Substring(1);
                int number = 0;

                //If user enter not number, inform they need enter valid value
                if (!int.TryParse(value, out number))
                {
                    MessageBox.Show("Please only use + or - with number to caculate");
                    continue;
                }

                switch (nav)
                {
                    case '+':
                        Console.WriteLine("Result: " + RecursionEven(number));
                        Console.ReadLine();
                        break;
                    case '-':
                        if (number <= 0)
                            MessageBox.Show("Please input number > 1");
                        else
                            RecursionFibonacy(0,1,1,number);
                        Console.ReadLine();
                        break;
                    default:
                        MessageBox.Show("Please only use + or - with number to caculate");
                        //System.Threading.Thread.Sleep(500);
                        break;
                }

            } while (true);
        }

        private static void ExamineIteration()
        {
            do
            {
                Console.Clear();
                Console.WriteLine("Input 0 or Enter to come back to main menu");
                Console.WriteLine("Input +number to calculate n:th even number");
                Console.WriteLine("Input -number to print n first number in fibonacci");
                string input = Console.ReadLine();
                if (input == "0" || input.Length == 0) break;

                char nav = input[0];
                string value = input.Substring(1);
                int number = 0;

                //If user enter not number, inform they need enter valid value
                if (!int.TryParse(value, out number))
                {
                    MessageBox.Show("Please only use + or - with number to caculate");
                    continue;
                }

                switch (nav)
                {
                    case '+':
                        Console.WriteLine("Result: " + IterationEven(number));
                        Console.ReadLine();
                        break;
                    case '-':
                        Console.WriteLine("Result: " + InterationFibonacy(number));
                        Console.ReadLine();
                        break;
                    default:
                        MessageBox.Show("Please only use + or - with number to caculate");
                        //System.Threading.Thread.Sleep(500);
                        break;
                }

            } while (true);
        }

        #endregion

        #region Other_Method
        //Put string into a stack
        private static string ReverseString(string input)
        {
            Stack theStack = new Stack();
            string output = "";
            foreach (char ch in input)
            {
                theStack.Push(ch);
            }
            while(theStack.Count > 0)
            {
                output += theStack.Pop();
            }
            return output;
        }

        //Display the list with capacity
        private static string DisplayList(List<string> theList)
        {
            string output = "";
            if (theList.Count == 0) output += "Empty";
            else
            {
                foreach (string s in theList)
                {
                    output += s + "\n";
                }
            }
            output += "\nCapacity of the list: " + theList.Capacity;
            return output;
        }

        //Display other collection with count
        private static string DisplayList(ICollection theList)
        {
            string output = theList.GetType().Name + " contains: \n";
            if (theList.Count == 0) output += "Empty";
            else
            {
                foreach (var s in theList)
                {
                    output += s +  "\n";
                }
            }
            output += "\nTotal: " + theList.Count;
            return output;



        }
        
        private static bool MatchCouple(char open, char close)
        {
            if (open.Equals('{') && close.Equals('}'))
                return true;
            if (open.Equals('<') && close.Equals('>'))
                return true;
            if (open.Equals('(') && close.Equals(')'))
                return true;
            if (open.Equals('[') && close.Equals(']'))
                return true;
            return false;
        }

        private static int Fibonacy(int number)
        {
            if (number == 1)
            {
                return 0;
            }
            if (number == 2)
            {
                return 1;
            }
            return (Fibonacy(number - 1) + Fibonacy(number - 2));
        }

        private static void RecursionFibonacy(int first, int second, int counter, int number)
        {
            Console.Write(first + " ");
            if (counter < number)
                RecursionFibonacy(second, first + second, counter + 1, number);            
        }

        private static int RecursionEven(int number)
        {
            if (number == 0)
            {
                return 0;
            }
            return RecursionEven(number - 1) + 2;
        }

        private static string InterationFibonacy(int number)
        {
            if (number == 1)
            {
                return "0";
            }
            if (number == 2)
            {
                return "0 1"; 
            }

            int a = 0;
            int b = 1;
            string result = "0 1";
            for (int i=3; i<= number; i++)
            {
                int c = a + b;
                result += " " + c;
                a = b;
                b = c;
            }

            return result;
        }

        private static int IterationEven(int number)
        {
            if (number == 0) return 0;
            int result = 0;
            for(int i=1; i<= number; i++)
            {
                result += 2;
            }
            return result;
        }

        #endregion
    }
}
