using System;

namespace _20180313_Task2
{
    internal class ProgramHelper : ProgramConverter, ICodeChecker
    {
        /// <inheritdoc />
        /// <summary>
        /// A constructor that provides information on the involved classes and ID for a binding to operations.
        /// </summary>
        public ProgramHelper()
        {
            Console.WriteLine("Class ProgramHelper");
        }

        /// <summary>
        /// The CodeCheckSyntax() method verifies the correctness of converting one programming language to another.
        /// </summary>
        /// <param name="verificationString">The result of converting one programming language to another.</param>
        /// <param name="languageUsed">A verifiable programming language.</param>
        /// <returns>The result of the correct conversion - true or false.</returns>
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