// See https://aka.ms/new-console-template for more information
using System.IO;
//Ввести с клавиатуры произвольный набор данных и сохранить его в текстовый файл.
string dataSet = Console.ReadLine();
string filename = "dataSet.txt";
File.WriteAllText(filename, dataSet);