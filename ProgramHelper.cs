using System;

namespace _20180313_Task2
{
    class ProgramHelper : ProgramConverter, ICodeChecker
    {
        public ProgramHelper()
        {
            Console.WriteLine("Класс ProgramHelper");
        }

        // Принимаем результаты выполнения методов ConvertToCSharp / ConvertToVB и конечный язык для проверки
        public bool CodeCheckSyntax(string verificationString, string languageUsed)
        {
            switch (languageUsed)
            {
                case "C#":
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine($"Проверка операции \"{verificationString}\" ...");
                    Console.WriteLine("Пожалуйста, не выключайте компьютер до завершения проверки.");
                    return true;
                case "VB":
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine($"Запущена проверка операции \"{verificationString}\" ...");
                    Console.WriteLine("Пожалуйста, не выключайте компьютер до завершения проверки.");
                    return true;
                default:
                    return false;
            }
        }
    }
}