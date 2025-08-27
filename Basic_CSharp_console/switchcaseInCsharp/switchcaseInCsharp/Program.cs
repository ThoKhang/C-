internal class Program
{
    private static void Main(string[] args)
    {
        int a;
        Console.WriteLine("enter a: ");
        a = int.Parse(Console.ReadLine());
        switch (a)
        {
            case 0: Console.WriteLine("Right");
            break;
            case 1: Console.WriteLine("Center");
            break;
            case 2: Console.WriteLine("Left");
            break;
            default:
                Console.WriteLine("nothing");
            break;
        }
    }
}