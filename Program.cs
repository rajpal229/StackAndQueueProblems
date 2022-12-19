namespace StackAndQueueProblems
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1. Stack \n2. Queue");
            int Command = Convert.ToInt32(Console.ReadLine());
            switch (Command)
            {
                case 1:
                    Stack_Ex stack = new Stack_Ex();
                    Console.WriteLine("1. Adding Values in Stack using Push");
                    stack.Push(70);
                    stack.Push(30);
                    stack.Push(56);
                    Console.WriteLine("Printing Stack");
                    stack.Display();

                    Console.WriteLine("Using Peek");
                    stack.Peek();

                    Console.WriteLine("Using Pop");
                    stack.Pop();
                    Console.WriteLine("Printing Remaining Stack");
                    stack.Display();

                    Console.WriteLine("Using Peek");
                    stack.Peek();

                    Console.WriteLine("Using Pop");
                    stack.Pop();
                    Console.WriteLine("Printing Remaining Stack");
                    stack.Display();

                    Console.WriteLine("Using Peek");
                    stack.Peek();

                    Console.WriteLine("Using Pop");
                    stack.Pop();
                    Console.WriteLine("Printing Remaining Stack");
                    stack.Display();
                    break;
                case 2:
                    Queue_Ex queue = new Queue_Ex();
                    Console.WriteLine("1. Adding Values in Queue using Enqueue");
                    queue.Enqueue(56);
                    queue.Enqueue(30);
                    queue.Enqueue(70);
                    Console.WriteLine("Printing Queue");
                    queue.Display();
                    break;
                default:
                    Console.WriteLine("Enter Valid option");
                    break;
            }
        }
    }
}