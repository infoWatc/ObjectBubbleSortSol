// use PrintCode.Syntax(@"C:\YourPath\toCode\fileToPrint.cs");

using System;
class PrintCode
{
    public static void Syntax(string location)
    {
        DisplaySyntax(location);        
    }

    private static void DisplaySyntax(string location)
    {
        string newText = "";
        string[] text = System.IO.File.ReadAllLines
            (location);
        foreach (string element in text)
        {
            newText += element + "\n";
        }

        Console.Write(newText);
    }
}