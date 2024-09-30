// See https://aka.ms/new-console-template for more information
using TP_CSHARP_J1;

Console.WriteLine("Hello, World!");


StudyBook sb1 = new StudyBook();
StudyBook sb2 = new StudyBook(345,"Vincent Gaudel","Mathémagiques", "Isika Edition");
Journal j1 = new Journal();
Journal j2 = new Journal(57898,"Newton", "Le Pouvoir des pommes", "Gravity");
Magazine m1 = new Magazine();
Magazine m2 = new Magazine(1, "People", "Hello", "C'est nous");

Console.WriteLine(sb1.DisplayBookDetails());
Console.WriteLine(sb2.DisplayBookDetails());
Console.WriteLine(j1.DisplayBookDetails());
Console.WriteLine(j2.DisplayBookDetails());
Console.WriteLine(m1.DisplayBookDetails());
Console.WriteLine(m2.DisplayBookDetails());