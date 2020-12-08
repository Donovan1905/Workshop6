using System;
using System.Collections.Generic;
using System.Text;
using Workshop6.Tools;
using Workshop6.Enums;
using System.Threading;

namespace Workshop6
{

    /*
     * 
     *          ATTENTION
     *          
     *          
     *     Je n'ai pas encore finis le workshop et je compte le continuer alors j'ai fais un github : https://github.com/Donovan1905/Workshop6
     * 
     * 
     * 
     * 
     * 
     */
    class Worker
    {
        private Dictionary<string, Tool> tools = new Dictionary<string, Tool>();

        private string name;

        private WorkerStatus status;

        private Worker leftNeigbhor;

        private int done;

        public Worker(string name, WorkerStatus workerStatus)
        {
            this.Name = name;
            this.status = workerStatus;
            this.Tools.Add("right", null);
            this.Tools.Add("left", null);
        }

        public int Done
        {
            get { return this.done; }
            set { this.done = value; }
        }

        public Worker LeftNeighbor
        {
            get { return this.leftNeigbhor; }
            set { this.leftNeigbhor = value; }
        }

        public Dictionary<string, Tool> Tools
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
            this.Tools["left"].Status = ToolStatus.USED;
            Thread.Sleep(4000);
            this.Done++;
            Thread freeTool = new Thread(this.FreeTool);
            freeTool.Start();
            Thread wait = new Thread(this.Waiting);
            wait.Start();
            this.Speak();
        }

        public void Break()
        {
            this.Status = WorkerStatus.BREAK;
        }

        public void Waiting()
        {
            this.Status = WorkerStatus.WAITING;
            this.Tools["right"].Status = ToolStatus.USED;
            while(this.Tools["left"] == null && this.Tools["right"] != null);
            {
                Thread getTool = new Thread(this.GetTool);
                getTool.Start();
            }
            Thread assembling = new Thread(this.Assembling);
            assembling.Start();
        }

        public void GetTool()
       {
            if(leftNeigbhor.Tools["right"] != null && leftNeigbhor.Tools["right"].Status == ToolStatus.FREE)
            {
                this.Tools["left"] = this.leftNeigbhor.Tools["right"];
                this.leftNeigbhor.Tools["right"] = null;
            }
       }

       public void FreeTool()
       {
            this.Tools["right"].Status = ToolStatus.FREE;
            this.Tools["left"].Status = ToolStatus.FREE;
            this.leftNeigbhor.Tools["right"] = this.Tools["left"];
            this.Tools["left"] = null;
       }

        public void Speak()
        {
            Console.WriteLine("I'm {0}, i have in my right hand : {1} {2} and in my left hand {3} and i am currently {4}. My neighbor is {5}. My count is {6}", this.Name, this.Tools["right"].Name, this.Tools["right"].Status,  this.Tools["left"], this.Status, this.LeftNeighbor.Name, this.Done);
        }
    }
}
