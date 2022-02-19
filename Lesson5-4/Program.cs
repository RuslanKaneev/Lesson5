// See https://aka.ms/new-console-template for more information
using System.IO;

//Сохранить дерево каталогов и файлов по заданному пути в текстовый файл — с рекурсией и без.
/*
 
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
string mainDirect = @"D:\HTML CSS";

SaveDirect(mainDirect, "save.txt" );

static void SaveDirect (string path, string file)
{
  
    File.AppendAllLines(file, new[] { path });
    string[] direct = Directory.EnumerateDirectories(path).ToArray();
    
    for (int i = 0; i < direct.Length; i++)
{
        SaveDirect(direct[i],file);
        Console.WriteLine(direct[i], file);
        File.WriteAllText("save.txt", path);
    }
    Directory.GetFiles(path);
}
