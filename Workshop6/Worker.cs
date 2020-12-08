using System;
using System.Collections.Generic;
using System.Text;
using Workshop6.Tools;
using Workshop6.Enums;

namespace Workshop6
{
    class Worker
    {
        private List<Tool> tools = new List<Tool>();

        private string name;

        private WorkerStatus status;

        private Worker leftNeigbhor;

        public Worker(string name, WorkerStatus workerStatus)
        {
            this.Name = name;
            this.status = workerStatus;
        }

        public Worker LeftNeighbor
        {
            get { return this.leftNeigbhor; }
            set { this.leftNeigbhor = value; }
        }

        public List<Tool> Tools
        {
            get { return this.tools; }
            set { this.tools = value; }
        }

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public WorkerStatus Status
        {
            get { return this.status; }
            set { this.status = value; }
        }

        public void Assembling()
        {
            this.Status = WorkerStatus.ASSEMBLING;
        }

        public void Break()
        {
            this.Status = WorkerStatus.BREAK;
        }

        public void Waiting()
        {
            this.Status = WorkerStatus.WAITING;
        }

       public void GetTool()
        {

        }
    }
}
