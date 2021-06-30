using System;
using System.IO;

if (Args.Count != 1)
{
    Console.Error.WriteLine("Error: missing argument 'directory'");
    Environment.Exit(1);
}

string dirPath = Args[0];
FileAttributes attr = File.GetAttributes(dirPath);

if (!attr.HasFlag(FileAttributes.Directory))
{
    Environment.Exit(1);
}

List<string> filePaths = Directory.EnumerateFiles(dirPath).ToList();
filePaths.Sort();

foreach (string path in filePaths)
{
    foreach (string line in File.ReadAllLines(path))
    {
        string canonicalForm = line.Normalize(NormalizationForm.FormC);
        Console.WriteLine(canonicalForm);
    }
}