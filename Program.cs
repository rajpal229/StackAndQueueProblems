namespace StackAndQueueProblems
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack_Ex stack = new Stack_Ex();
            Console.WriteLine("Adding Values in Stack using Push");
            stack.push(70);
            stack.push(30);
            stack.push(56);
            Console.WriteLine("Printing Stack");
            stack.Display();
        }
    }
}