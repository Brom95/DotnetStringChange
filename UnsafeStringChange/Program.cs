using System.Runtime.InteropServices;

var a = "Hello, World!";
Console.WriteLine("Переменная a:");
Console.WriteLine(a);
Console.WriteLine("Прямой вывод \"Hello, World!\"");
Console.WriteLine("Hello, World!");
Console.WriteLine("\nПроизводим магию...\n");

unsafe
{
    fixed(char* c = a)
    {
        *c = 'T';
    }
}
Console.WriteLine("Переменная a:");
Console.WriteLine(a);
Console.WriteLine("Прямой вывод \"Hello, World!\""); // Tello, World!
Console.WriteLine("Hello, World!"); // Tello, World!
