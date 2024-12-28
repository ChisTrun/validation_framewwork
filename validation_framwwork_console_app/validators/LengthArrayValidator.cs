using System;
using System.Collections;
using validation_framwwork_console_app.core;

namespace validation_framwwork_console_app.validators
{
    public class LengthArrayValidator : ValidationHandler
    {
        private readonly int _minLength;
        private readonly int _maxLength;

        public LengthArrayValidator(int minLength, int maxLength)
        {
            _minLength = minLength;
            _maxLength = maxLength;
        }

        public override bool Validate(object obj) 
        {
            if (obj is IEnumerable array)
            {
                int length = 0;
                foreach (var element in array)
                {
                    length++;
                }

                if (length >= _minLength && length <= _maxLength)
                {
                    return next?.Validate(obj) ?? true;
                }
            }

            return false;
        }
    }
}
