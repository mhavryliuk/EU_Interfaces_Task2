using System;

/**<remark>
 * - Определить интерфейс IConvertible, указывающий, что реализующий его класс может конвертировать блок кода в С# или VB код.
 * В интерфейсе определить два метода два ConvertToCSharp и ConvertToVB, каждый из которых принимать и возвращать строку.
 * - Создать класс ProgramHelper, реализующий интерфейс IConvertible. 
 * При написании методов вместо преобразования строки использовать простые строковые сообщения для имитации преобразования.
 * - Создать новый интерфейс ICodeChecker, определив в нем метод CodeCheckSyntax, принимающий две строки: строка для проверки и используемый язык.
 * Метод должен возвращать тип bool. Добавить в класс ProgramHelper функциональность нового интерфейса IСodeChecker.
 * - Создать класс ProgramConverter, реализующий интерфейс IConvertible. 
 * Изменить класс ProgramHelper, наследуя его от класса ProgramConverter и интерфейса ICodeChecker.
 * - Протестировать класс, создав массив объектов ProgramConverter, одни из которых имеют тип ProgramConverters, а другие – тип ProgramHelpers.
 * Затем вызвать методы преобразования и проверки кода для каждого элемента массива чтобы проверить, какие из них реализуют интерфейс IСodeChecker, а какие нет. 
</remark> */

namespace _20180313_Task2
{
    internal class Program
    {
        private static void Main()
        {
            Console.Title = "===== Maksym Havryliuk - EPAM University - .Net program =====";

            ProgramConverter[] programConverter = new ProgramConverter[3];
            programConverter[0] = new ProgramConverter();
            programConverter[1] = new ProgramHelper();
            programConverter[2] = new ProgramHelper();

            foreach (ProgramConverter element in programConverter)
            {
                // The operation ID for mapping to the called classes.
                Console.WriteLine("\nId {0}:", TransactionID.idOperation++);

                // We lead a ProgramConverter object to the ProgramHelper type.
                ProgramHelper programHelper = element as ProgramHelper;

                // Converting VB code to C#.
                string vbCode = element.ConvertToCSharp("VB CODE");
                Console.WriteLine(vbCode);

                // Checking the availability of the CodeCheckSyntax method of the ProgramHelper class.
                if (programHelper != null) // if casting is possible...
                {
                    programHelper.CodeCheckSyntax(vbCode, "C#");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Ошибка проверки синтаксиса C#. Модуль CodeCheckSyntax недоступен!");
                    Console.ForegroundColor = ConsoleColor.Gray;
                }

                // Converting C# code to VB.
                string csharpCode = element.ConvertToVB("C# CODE");
                Console.WriteLine(csharpCode);

                // Checking the availability of the CodeCheckSyntax method of the ProgramHelper class.
                if (programHelper != null) // if casting is possible...
                {
                    programHelper.CodeCheckSyntax(csharpCode, "VB");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Ошибка проверки синтаксиса VB. Модуль CodeCheckSyntax недоступен!");
                    Console.ForegroundColor = ConsoleColor.Gray;
                }
            }

            Console.ReadKey();
        }
    }
}