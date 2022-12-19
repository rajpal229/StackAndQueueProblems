namespace StackAndQueueProblems
{
    internal class Program
    {
        static void Main(string[] args)
        {
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
        }
    }
}