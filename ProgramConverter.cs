using System;

namespace _20180313_Task2
{
    /// <inheritdoc />
    internal class ProgramConverter : IConvertible
    {
        /// <summary>
        /// A constructor that provides information on the involved classes and ID for a binding to operations.
        /// </summary>
        public ProgramConverter()
        {
            Console.WriteLine("\nId {0}:", TransactionID.idClass++);
            Console.WriteLine("Class ProgramConverter");
        }

        /// <inheritdoc />
        /// <summary>
        /// The ConvertToCSharp() method converts the VB code to a C# code.
        /// </summary>
        /// <param name="textOnVB">VB programming language code.</param>
        /// <returns>The message about the completion of the conversion.</returns>
        public virtual string ConvertToCSharp(string textOnVB)
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write("Завершена ");
            return $"конвертация [{textOnVB}] в C#";
        }

        /// <inheritdoc />
        /// <summary>
        /// The ConvertToCSharp() method converts the C# code to a VB code.
        /// </summary>
        /// <param name="textOnCSharp">C# programming language code.</param>
        /// <returns>The message about the completion of the conversion.</returns>
        public virtual string ConvertToVB(string textOnCSharp)
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write("Завершена ");
            return $"конвертация [{textOnCSharp}] в VB";
        }
    }
}