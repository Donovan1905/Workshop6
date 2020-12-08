using System;
using System.Collections.Generic;
using System.Text;
using Workshop6.Enums;

namespace Workshop6.Tools
{
    class Screwdriver : Tool
    {
        public Screwdriver(string name, ToolStatus toolStatus)
        {
            this.Name = name;
            this.Status = toolStatus;
        }
    }
}
