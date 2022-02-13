// See https://aka.ms/new-console-template for more information
using System.IO;
Console.WriteLine("Введите строку");
string dataSet = Console.ReadLine();
string filename = "dataSet.txt";
File.WriteAllText(filename, dataSet);
