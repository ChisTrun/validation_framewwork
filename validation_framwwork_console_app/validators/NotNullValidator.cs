using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using validation_framwwork_console_app.core;

namespace validation_framwwork_console_app.validators
{
    public class NotNullValidator : ValidationHandler
    {
        public override bool Validate(object obj)
        {
            return obj != null && (next?.Validate(obj) ?? true);
        }
    }
}
