using System;
/*
 * ModifyString - 
 * 
 */
namespace ModifyString
{
    class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student();
            s1.Name = "Дженни";

            Student s2 = new Student();
            s2.Name = s1.Name;

            s2.Name = s1.Name.ToUpper();
            Console.WriteLine("s1 - " + s1.Name + ", s2 - " + s2.Name);

            // Ожидаем подтверждения от пользователя для окончания работы
            Console.WriteLine("Нажмите клавишу <Enter> для выхода...");
            Console.Read();
        }
    }

    class Student
    {
        public String Name;
    }
}
