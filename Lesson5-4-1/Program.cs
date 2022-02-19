using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson5_4_1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // See https://aka.ms/new-console-template for more information
           
//Сохранить дерево каталогов и файлов по заданному пути в текстовый файл — с рекурсией и без.
            /*
            string mainDirect = @"D:\HTML CSS"; 
            Console.WriteLine(Directory.Exists(mainDirect)); // Проверяет, существует ли заданная директория
            string nextDirectory = Path.Combine(mainDirect, "Notes");
            Directory.CreateDirectory(nextDirectory);


            Directory.CreateDirectory(nextDirectory); // Создаем вложенную директорию

            string noteText = "Этот файл создан автоматически";

            string notePath = Path.Combine(nextDirectory, "Note 1.txt"); // "D:\ExampleDir\Notes\Note 1.txt"

            File.WriteAllText(notePath, noteText);

            string copyOfNotePath = Path.Combine(mainDirect, "Copy of Note 1.txt"); // "D:\ExampleDir\Copy of Note 1.txt"
            File.Copy(notePath, copyOfNotePath); // Копируем созданную заметку в "D:\ExampleDir\Copy of Note 1.txt"

            Console.WriteLine(File.Exists(copyOfNotePath)); // Проверяет, существует ли заданный файл

            File.Move(copyOfNotePath, Path.Combine(nextDirectory, "Note 2.txt")); // Перемещаем заметку в "D:\ExampleDir\Notes\Note 2.txt"

            // Создаем директорию "D:\ExampleDir\Documents" и перемещаем в нее директорию Notes
            Directory.CreateDirectory(Path.Combine(mainDirect, "Documents"));
            Directory.Move(nextDirectory, Path.Combine(mainDirect, "Documents", "Notes"));
            */

            // Перечень всех файлов и папок, вложенных в workDir
            //string[] entries = Directory.GetFileSystemEntries(mainDirect, "*", SearchOption.AllDirectories);


        public string mainDirect = Console.ReadLine();
        static void SaveDirect(string path, string file)
        {
            File.AppendAllLines(file, new[] { path });
            string[] entries = Directory.GetFileSystemEntries(mainDirect, "*", SearchOption.AllDirectories);

            for (int i = 0; i < entries.Length; i++)
            {
                Console.WriteLine(entries[i]);
            }
        }
    }
    }

