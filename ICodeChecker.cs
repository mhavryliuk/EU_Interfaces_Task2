namespace _20180313_Task2
{
    public interface ICodeChecker
    {
        /// <summary>
        /// The CodeCheckSyntax() method verifies the correctness of converting one programming language to another.
        /// </summary>
        /// <param name="verificationString">The result of converting one programming language to another.</param>
        /// <param name="languageUsed">A verifiable programming language.</param>
        /// <returns>The result of the correct conversion - true or false.</returns>
        bool CodeCheckSyntax(string verificationString, string languageUsed);
    }
}