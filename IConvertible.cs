namespace _20180313_Task2
{
    interface IConvertible
    {
        string ConvertToCSharp(string vbCode);
        string ConvertToVB(string csharpCode);
    }
}