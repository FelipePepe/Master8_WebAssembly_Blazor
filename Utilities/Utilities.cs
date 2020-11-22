using Microsoft.AspNetCore.Components;

namespace webassemplyapp.Utilities
{
    public class Utilities
    {
        public static MarkupString ToTitle(string text) => (MarkupString)$"<b>{text.ToUpper()}</b>";
    }
}