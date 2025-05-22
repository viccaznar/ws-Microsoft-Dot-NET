using System.IO;
using System.Collections.Generic;

var currentDirectory = Directory.GetCurrentDirectory();
var storesDirecttory = Path.Combine(currentDirectory, "stores");

var salesTotalDir = Path.Combine(currentDirectory, "salesTotalDir");
Directory.CreateDirectory(salesTotalDir); // Add this line of code
var salesFiles = FindFiles(storesDirecttory);

File.WriteAllText(Path.Combine(salesTotalDir, "totals.txt"), String.Empty);

IEnumerable<string> FindFiles(string folderName)
{
    List<string> salesFiles = new List<string>();

    var foundFiles = Directory.EnumerateFiles(folderName, "*", SearchOption.AllDirectories);

    foreach (var file in foundFiles)
    {
        var extension = Path.GetExtension(file);
        if (extension == ".json")
        {
            salesFiles.Add(file);
        }
    }

    return salesFiles;
}
