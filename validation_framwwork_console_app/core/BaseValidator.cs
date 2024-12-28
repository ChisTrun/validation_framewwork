using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace validation_framwwork_console_app.core
{
    public interface BaseValidator
    {
        bool Validate(object obj);  
    }
}
