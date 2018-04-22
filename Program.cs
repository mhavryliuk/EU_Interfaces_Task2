using System;

/* - Определить интерфейс IConvertible, указывающий, что реализующий его класс может конвертировать блок кода в С# или VB код. 
В интерфейсе определить два метода два ConvertToCSharp и ConvertToVB, каждый из которых принимать и возвращать строку.
- Создать класс ProgramHelper, реализующий интерфейс IConvertible. При написании методов вместо преобразования строки использовать 
простые строковые сообщения для имитации преобразования.
- Создать новый интерфейс ICodeChecker, определив в нем метод CodeCheckSyntax, принимающий две строки: строка для проверки и используемый язык.
Метод должен возвращать тип bool. Добавить в класс ProgramHelper функциональность нового интерфейса IСodeChecker.
- Создать класс ProgramConverter, реализующий интерфейс IConvertible. Изменить класс ProgramHelper, наследуя его от класса ProgramConverter
и интерфейса ICodeChecker.
- Протестировать класс, создав массив объектов ProgramConverter, одни из которых имеют тип ProgramConverters, а другие – тип ProgramHelpers.
Затем вызвать методы преобразования и проверки кода для каждого элемента массива чтобы проверить, какие из них реализуют интерфейс IСodeChecker, 
а какие нет. */

namespace _20180313_Task2
{
    class Program
    {
        static void Main()
        {
            Console.Title = "===== Maksym Havryliuk - EPAM University - .Net program =====";

            ProgramConverter[] programConverter = new ProgramConverter[3];
            programConverter[0] = new ProgramConverter();
            programConverter[1] = new ProgramHelper();
            programConverter[2] = new ProgramHelper();

            foreach (ProgramConverter element in programConverter)
            {
                // ID операции для сопоставления с вызываемыми классами
                Console.WriteLine("\nId {0}:", TransactionID.idOperation++);

                // Объект типа ProgramConverter приводим к типу ProgramHelper
                ProgramHelper programHelper = element as ProgramHelper;

                // Конвертация кода VB в C#
                string vbCode = element.ConvertToCSharp("VB CODE");
                Console.WriteLine(vbCode);

                // Проверка доступности метода CodeCheckSyntax класса ProgramHelper
                if (programHelper != null) // если приведение типа возможно...
                {
                    programHelper.CodeCheckSyntax(vbCode, "C#");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Ошибка проверки синтаксиса C#. Модуль CodeCheckSyntax недоступен!");
                    Console.ForegroundColor = ConsoleColor.Gray;
                }

                // Конвертация кода C# в VB
                string csharpCode = element.ConvertToVB("C# CODE");
                Console.WriteLine(csharpCode);

                // Проверка доступности метода CodeCheckSyntax класса ProgramHelper
                if (programHelper != null) // если приведение типа возможно...
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