using System;
using System.Collections.Generic;
using System.Text;

namespace APPSTOCK.Core.Models
{
    [Keyless]
    public class ResponseModel
    {
        public int Result { get; set; }
    }
    [Keyless]
    public class ResponseModelJSON
    {
        public string Result { get; set; }
    }
    [Keyless]
    public class Response
    {
        public long Result { get; set; }
    }
}
