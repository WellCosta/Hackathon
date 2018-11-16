using System.Globalization;
using System.Linq;
using System.Text;

namespace OOP1
{
    interface IFormatter
    {
        string Format(string text);
    }

    /// <summary>
    /// Formats a text to pascal case
    /// </summary>
    class Formatter : IFormatter
    {
        // Begin: Cannot change 
        public string Format(string text)
        {
            return ToPascalCase(text);
        }

        private string ToPascalCase(string text)
        {
            return text.Substring(0, 1).ToUpper() + text.Substring(1);
        }
        // End: Cannot change
    }
}
