using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Case
{
    public class Snake
    {
        public string ToPascal(string orig)
        {
            if (orig == null)
            {
                return "";
            }
            var words = GetWords(orig);
            var result = "";
            TextInfo textInfo = new CultureInfo("en-US", false).TextInfo;
            foreach (string word in words) {
                result = String.Concat(result, textInfo.ToTitleCase(word));
            }
            return result;
        }
        public Array GetWords(string orig)
        {
            return orig.Split('_');
        }
    }
}
