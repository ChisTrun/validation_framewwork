using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using validation_framwwork_console_app.core;

namespace validation_framwwork_console_app.validators
{
    internal class StringLengthValidator : ValidationHandler
    {
        private int _minLength;
        private int _maxLength;

        public StringLengthValidator(int minLength, int maxLength)
        {
            _minLength = minLength;
            _maxLength = maxLength;
        }

        public override bool Validate(object obj)
        {
            if (obj is string str)
            {
                return str.Length >= _minLength && str.Length <= _maxLength && (next?.Validate(obj) ?? true);
            }
            return false; 
        }
    }
}
