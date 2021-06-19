using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using APPSTOCK.Core.Models;
//using Microsoft.EntityFrameworkCore;

namespace App_Stock.Models
{
    [Keyless]
    public class DropdownModel
    {
        public int ID { get; set; }
        public string Text { get; set; }
    }
    public class DropDownChangeModel
    {
        public int ID { get; set; }
        public string Text { get; set; }
        public string Change { get; set; }
    }

    public class DropDownChangeIdTextModel
    {
        public int ID { get; set; }
        public string Text { get; set; }
        public int IdChange { get; set; }
        public string Change { get; set; }
    }
}
