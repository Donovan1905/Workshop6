using System;
using System.Collections.Generic;
using System.Text;
using Workshop6.Enums;

namespace Workshop6.Tools
{
    class Tool
    {
        private string name;
        private ToolStatus status;

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public ToolStatus Status
        {
            get { return this.status; }
            set { this.status = value; }
        }
    }
}
