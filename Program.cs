using System;
using System.IO;
using Microsoft.VisualBasic;

namespace TextEditor
{
  class Program
  {
    static void Main(string[] args)
    {
      Menu();
    }

    static void Menu()
    {
      Console.Clear();
      Console.WriteLine("What Would you like to do?");
      Console.WriteLine("1 - Open file");
      Console.WriteLine("2 - Creat new file");
      Console.WriteLine("0 - Exit");
      short option = short.Parse(Console.ReadLine());

      switch (option)
      {
        case 0: System.Environment.Exit(0); break;
        case 1: Open(); break;
        case 2: Edit(); break;
        default: Menu(); break;
      }
    }

    static void Open() { }

    static void Edit() {
      Console.Clear();
      Console.WriteLine("Write your text below (ESC to exit)");
      Console.WriteLine("---------------------");
      string text = "";

      do
      {
        text += Console.ReadLine();
        text += Environment.NewLine;
      }
      while(Console.ReadKey().Key != ConsoleKey.Escape);
      Salvar(text);
    }

    static void Salvar(string text) {
      Console.Clear();
      Console.WriteLine("What path to save the file?");
      var path = Console.ReadLine();

      using(var file = new StreamWriter(path)){
        file.WriteLine(text);
      }
      Console.WriteLine($"File {path} save with succes");
      Menu();
    }
  }
}
