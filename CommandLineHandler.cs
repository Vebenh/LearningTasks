using CommandLine;

namespace Learning;

public class CommandLineHandler
{
    class Options
    {
        [Option('r', "recursively", Required = false, HelpText = "Recursive traversal of directories.")]
        public bool Recursively { get; set; }

        [Option('p', "path", Required = true, HelpText = "Path to the directory.")]
        public string FilePath { get; set; }
        
        [Option('m', "last_modification", Required = false, HelpText = "Sort by modification time.")]
        public bool LastMod { get; set; }

    }

    public static void ParseArgs(string[] args)
    {
        Parser.Default.ParseArguments<Options>(args)
            .WithParsed(options =>
            {
                if (options.Recursively)
                {
                    Console.WriteLine($"If recursively: {options.Recursively}");
                }
                if (!string.IsNullOrEmpty(options.FilePath))
                {
                    Console.WriteLine($"File path: {options.FilePath}");
                }
                if (options.LastMod)
                {
                    Console.WriteLine($"Last modification: {options.LastMod}");
                }
                
            })
            .WithNotParsed(errors =>
            {
                Console.WriteLine("Invalid arguments.");
            });
    }
    
}