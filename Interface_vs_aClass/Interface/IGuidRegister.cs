using System;
using System.Collections.Generic;
using System.Text;
namespace Ifc;

    internal interface IGuidRegister
    {
        Guid getGuid();
        void setGuid(Guid guid);
    }

