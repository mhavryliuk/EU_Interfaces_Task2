using System;

namespace _20180313_Task2
{
    class ProgramConverter : IConvertible
    {
        // Информация о задействованных классах и ID для привязки к операциям 
        public ProgramConverter()
        {
            Console.WriteLine("\nId {0}:", TransactionID.idClass++);
            Console.WriteLine("Класс ProgramConverter");
        }

        // Конвертация кода VB в C#
        public virtual string ConvertToCSharp(string textOnVB)
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write("Завершена ");
            return $"конвертация [{textOnVB}] в C#";
        }

        // Конвертация кода C# в VB
        public virtual string ConvertToVB(string textOnCSharp)
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write("Завершена ");
            return $"конвертация [{textOnCSharp}] в VB";
        }
    }
}