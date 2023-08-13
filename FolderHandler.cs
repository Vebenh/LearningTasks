using System.Reflection;

namespace Learning;

public class FolderHandler
{
    public string CurrentDirectory { get; set; }
    public string[] Files { get; set; }
    
    public FolderHandler()
    {
        //CurrentDirectory = Directory.GetCurrentDirectory();
        CurrentDirectory = "/Users/sashatet/Makar/C#/Learning";
        ScanDirectory(CurrentDirectory);
    }

    public void ScanDirectory(string path)
    {
        try
        {
            //Получаем список файлов в указанной папке
            Files = Directory.GetFiles(path);

            // // Группируем файлы по дате создания
            // var groupedFiles = files.GroupBy(file => File.GetCreationTime(file).Date);
            //
            // // Выводим группы файлов по дате
            // foreach (var group in groupedFiles)
            // {
            //     Console.WriteLine($"Date: {group.Key.ToShortDateString()}");
            //     foreach (var file in group)
            //     {
            //         Console.WriteLine($"  {file}");
            //     }
            // }  
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
        }
    }


}