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
                Console.WriteLine("Please input string with + or - to update the list");
                Console.WriteLine("Input 0 to come back to main menu");
                string input = Console.ReadLine();

                // if user enter 0 then exit to main menu
                if (input == "0") break;

                //If user enter empty string, inform they need enter valid string
                if (input.Length == 0)
                {
                    MessageBox.Show("Please input the string begin with + or -");
                    continue;
                }

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


        //Display the list with capacity
        private static string DisplayList(List<string> theList)
        {
            string output ="";
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

        private static string DisplayList(ICollection theList, string Description, bool SeparateItem = true)
        {
            string output = Description + "\n";
            if (theList.Count == 0) output += "Empty";
            else
            {
                foreach (var s in theList)
                {
                    output += s + (SeparateItem ? "\n" : "");
                }
            }
            output += "\nTotal: " + theList.Count;
            return output;
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
                Console.WriteLine(DisplayList(theQueue, "Queue contains:"));
                Console.WriteLine("--------------------------------------------------");
                Console.WriteLine("Input 0 to come back to main menu");
                Console.WriteLine("Input +string to put person into queue");
                Console.WriteLine("Input - to take person from queue");
                string input = Console.ReadLine();
                if (input == "0") break;

                //If user enter empty string, inform they need enter valid string
                if (input.Length == 0)
                {
                    MessageBox.Show("Please input the string begin with + or -");
                    continue;
                }
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
            string Description = "Stack contains:";
            bool Separated = true;
            do
            {
                Console.Clear();
                Console.WriteLine(DisplayList(theStack, Description, Separated));
                Console.WriteLine("--------------------------------------------------");
                Console.WriteLine("Input 0 to come back to main menu");
                Console.WriteLine("Input #string to reverse string");
                Console.WriteLine("Input - to take person from stack");
                Console.WriteLine("Input +string to put person into stack");

                string input = Console.ReadLine();
                if (input == "0") break;
                char nav = input[0];
                string value = input.Substring(1);
                switch (nav)
                {
                    case '+':
                        if (value.Length == 0)
                            MessageBox.Show("Name can not be empty");
                        else
                            theStack.Push(value);
                        Separated = true;
                        break;
                    case '-':
                        if (theStack.Count > 0)
                            theStack.Pop();
                        else
                            MessageBox.Show("The stack is now empty");
                        Separated = true;
                        break;
                    case '#':
                        if (value.Length == 0)
                            MessageBox.Show("String can not be empty");
                        else
                        {
                            theStack = PushString(value);
                            Description = "Reversed string: ";
                            Separated = false;
                        }
                        break;
                    default:
                        MessageBox.Show("Please only use +,- or # to update stack");
                        //System.Threading.Thread.Sleep(500);
                        break;
                }

            } while (true);

        }

        //Put string into a stack
        private static Stack PushString(string input)
        {
            Stack theStack = new Stack();
            foreach (char ch in input)
            {
                theStack.Push(ch);
            }

            return theStack;
        }


        static void CheckParanthesis()
        {
            /*
             * Use this method to check if the paranthesis in a string is Correct or incorrect.
             * Example of correct: (()), {}, [({})]
             * Example of incorrect: (()]), [), {[()}]
             */
            Console.Clear();
            Console.Write("Please input string to check paranthesis: ");
            string input = Console.ReadLine();

            //If user enter empty string, inform they need enter valid string
            if (input.Length == 0)
            {
                MessageBox.Show("String can not be empty");
                return;
            }

            //Queue to contain paranthesis character in inputed string
            Queue theQueue = new Queue();            
            char[] paranthesis = new char[] { '<', '>', '{', '}', '[', ']', '(', ')' };
            foreach( char ch in input)
            {
                if (paranthesis.Contains(ch))
                    theQueue.Enqueue(ch);
            }

            //Array to check each paranthesis, can not use directly queue because it's updated through each iteration
            char[] existingParanthesis = new char[theQueue.Count];
            theQueue.CopyTo(existingParanthesis, 0);

            //algorithm: take the first paranthesis in queue, put it into stack
            //Take the second paranthesis in queue, 
            //If it is matching with the one in stack -> remove both of them from queue and stack. Otherwise, put it into stack.
            //Continue to the end of list. 
            //If the stack is empty (everything has matched) -> input string is well formed. Otherwise -> not well formed.
            Stack theStack = new Stack();
            foreach (char ch in existingParanthesis)
            {
                if (theStack.Count == 0 || !MatchClose(ch,(char) theStack.Peek()))
                {
                    theQueue.Dequeue();
                    theStack.Push(ch);
                }
                else
                {
                    theQueue.Dequeue();
                    theStack.Pop();
                }
                    
            }

            if (theStack.Count == 0)
                Console.WriteLine("Inputed string is well formed");
            else
                Console.WriteLine("Inputed string is NOT well formed");
            Console.ReadLine();
   
        }

        private static bool MatchClose(char close, char open)
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
    }
}
