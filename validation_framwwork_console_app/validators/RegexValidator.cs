using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using validation_framwwork_console_app.core;

namespace validation_framwwork_console_app.validators
{
    internal class RegexValidator : ValidationHandler
    {
            private string _pattern;

            public RegexValidator(string pattern)
            {
                _pattern = pattern;
            }

            public override bool Validate(object obj)
            {
                if (obj is string input)
                {
                    var regex = new Regex(_pattern);
                    return regex.IsMatch(input) && (next?.Validate(obj) ?? true);
                }
                return false; 
            }
    }
}
