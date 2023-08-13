
namespace Learning;

class Program
{
    static void Main()
    {
        // CommandLineHandler.ParseArgs(args);
        var file = new FolderHandler();
        Console.WriteLine(file.CurrentDirectory);

        foreach (string file1 in file.Files)
        {
            Console.WriteLine(file1);

        }

        Console.WriteLine("Test Text");
        Console.ReadLine();
    }
}