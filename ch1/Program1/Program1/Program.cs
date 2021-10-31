using System;

namespace Program1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Запрос на ввод имени пользователя
            Console.WriteLine("Введите ваше имя:");

            // Считываем введенное имя
            string name = Console.ReadLine();

            // Выводим на экран привествие пользователю с введенным именем
            Console.WriteLine("Привет, " + name);

            // Ожидаем подтверждения от пользователя для окончания работы
            Console.WriteLine("Нажмите клавишу <Enter> для выхода...");
            Console.Read();
        }
    }
}
