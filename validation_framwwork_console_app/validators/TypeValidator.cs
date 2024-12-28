using System;
using validation_framwwork_console_app.core;

namespace validation_framwwork_console_app.validators
{
    public class TypeValidator : ValidationHandler
    {
        private Type _targetType;

        public TypeValidator(Type targetType)
        {
            this._targetType = targetType;
        }

        public override bool Validate(object obj)
        {
            if (obj == null)
            {
                return false;
            }

            if (obj.GetType() == _targetType)
            {
                return next?.Validate(obj) ?? true; 
            }

            return false; 
        }
    }
}
