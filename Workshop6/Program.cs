using System;
using System.Threading;
using Workshop6.Tools;

namespace Workshop6
{
    class Program
    {


        static void Main()
        {
             Worker W1 = new Worker("W1", Enums.WorkerStatus.WAITING);
             Worker W2 = new Worker("W2", Enums.WorkerStatus.WAITING);
             Worker W3 = new Worker("W3", Enums.WorkerStatus.WAITING);
             Worker W4 = new Worker("W4", Enums.WorkerStatus.WAITING);

             Screwdriver Scr1 = new Screwdriver("Scr1", Enums.ToolStatus.FREE);
             Screwdriver Scr2 = new Screwdriver("Scr2", Enums.ToolStatus.FREE);
             Wrench Wrc1 = new Wrench("Wrc1", Enums.ToolStatus.FREE);
             Wrench Wrc2 = new Wrench("Wrc2", Enums.ToolStatus.FREE);

            InitializeWorkers(W1, W2, W3, W4, Wrc1, Scr1, Wrc2, Scr2);

            Thread w1 = new Thread(W1.Waiting);
            Thread w2 = new Thread(W2.Waiting);
            Thread w3 = new Thread(W3.Waiting);
            Thread w4 = new Thread(W4.Waiting);

            w1.Start();
            w2.Start();
            w3.Start();
            w4.Start();

            W1.Speak();
            W2.Speak();
            W3.Speak();
            W4.Speak();


    }

        public static void InitializeWorkers(Worker W1, Worker W2, Worker W3, Worker W4, Tool rightW1Tool, Tool rightW2Tool, Tool rightW3Tool, Tool rightW4Tool)
        {
            W1.LeftNeighbor = W2;
            W2.LeftNeighbor = W3;
            W3.LeftNeighbor = W4;
            W4.LeftNeighbor = W1;

            W1.Tools["right"] = rightW1Tool;
            W2.Tools["right"] = rightW2Tool;
            W3.Tools["right"] = rightW3Tool;
            W4.Tools["right"] = rightW4Tool;

            rightW1Tool.Status = Enums.ToolStatus.USED;
            rightW3Tool.Status = Enums.ToolStatus.USED;
        }
    }
}
