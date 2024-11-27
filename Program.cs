using System;
using System.IO;
using System.Reflection;

string dir ="Some.txt";
string newdir = "Some-2.txt";
//string dir ="Some-2.txt";
//string newdir ="Some.txt";
    bool exists = false;

if (Path.Exists(dir))
{
    StreamReader streamReader = new StreamReader(dir);
    using (streamReader)
    {
        string line;
        while ((line = streamReader.ReadLine()) != null)
        {
            Console.WriteLine("File content: "+line);
            streamReader.ReadLine();
        }
    }
    exists = true;
    Console.WriteLine("File exists: "+exists);
    try
    {
        File.Move(dir, newdir);
        Console.WriteLine("Renamed to " + newdir);
    }
    catch
    {
        Console.WriteLine("Error");
    }
}
else 
{
    Console.WriteLine("File exists: "+exists);
}