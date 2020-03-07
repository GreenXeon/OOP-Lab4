using System;
using System.Collections.Generic;

namespace classes_library
{
    abstract public class Worker
    {
        public static List<Worker> WorkersList;
        public string PassNum { get; set; } = "00000000";
        public Profile Profile { get; set; }


       // public void ComeToWork()
       // {
       //     Console.WriteLine("I have already coming!");
       // }

        //public void GetAwayFromWork()
        //{
        //    Console.WriteLine("I have already been going home!");
        //}

        abstract public string AddWorker();

        abstract public string DeleteWorker();

        abstract public string ChangeWorkerInfo();

    }
 
}
