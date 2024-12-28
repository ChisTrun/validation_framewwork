using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace validation_framwwork_console_app.core
{
    public abstract class ValidationHandler : BaseValidator
    {

        protected ValidationHandler? next;
        public void SetNext(ValidationHandler next) { this.next = next; }
        abstract public bool Validate(object obj);
    }
}
