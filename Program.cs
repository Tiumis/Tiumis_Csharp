// See https://aka.ms/new-console-template for more information
namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Таблица температур по Фаренгейту и Цельсию:"); 
            Console.WriteLine("По Фаренгейту По Цельсию"); 
            int fahr; 
            for(fahr=0; fahr <= 300; fahr= fahr + 20) 
            Console.WriteLine("{0:f} {1:f}", fahr, 
            (5.0/9.0)*(fahr-32.0)); 
            Console.Write("Для продолжения нажмите любую клавишу > "); 
            Console.Read();
        }
                
     }
  }

