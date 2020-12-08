using System;
using Workshop6.Tools;

namespace Workshop6
{
    class Program
    {
        public Worker W1 = new Worker("W1", Enums.WorkerStatus.WAITING);
        public Worker W2 = new Worker("W1", Enums.WorkerStatus.WAITING);
        public Worker W3 = new Worker("W1", Enums.WorkerStatus.WAITING);
        public Worker W4 = new Worker("W1", Enums.WorkerStatus.WAITING);

        public Screwdriver Scr1 = new Screwdriver("Scr1", Enums.ToolStatus.FREE);
        public Screwdriver Scr2 = new Screwdriver("Scr2", Enums.ToolStatus.FREE);
        public Wrench Wrc1 = new Wrench("Wrc1", Enums.ToolStatus.FREE);
        public Wrench Wrc2 = new Wrench("Wrc2", Enums.ToolStatus.FREE);

        static void Main()
        {
            

        }

        public void InitializeWorkers()
        {

        }
    }
}
