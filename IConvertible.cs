namespace _20180313_Task2
{
    public interface IConvertible
    {
        /// <summary>
        /// The ConvertToCSharp() method converts the VB code to a C# code.
        /// </summary>
        /// <param name="vbCode">VB programming language code.</param>
        /// <returns>The message about the completion of the conversion.</returns>
        string ConvertToCSharp(string vbCode);

        /// <summary>
        /// The ConvertToCSharp() method converts the C# code to a VB code.
        /// </summary>
        /// <param name="csharpCode">C# programming language code.</param>
        /// <returns>The message about the completion of the conversion.</returns>
        string ConvertToVB(string csharpCode);
    }
}