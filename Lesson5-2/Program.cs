// See https://aka.ms/new-console-template for more information
//Написать программу, которая при старте дописывает текущее время в файл «startup.txt».
using System.IO;
string currentTime = Convert.ToString(DateTime.Now.ToString("HH:mm:ss"));
string filename = "startup.txt";
File.WriteAllText(filename, currentTime);


