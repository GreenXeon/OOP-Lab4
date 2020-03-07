using System;
using System.Collections.Generic;
using System.Text;

namespace classes_library
{
    public class Clerk : Worker
    {
        public string OfficeNum { get; set; }

        //public void WaitForTheWeekEnd()
        //{
        //    Console.WriteLine("I am still waiting for the weekend");
        //}

        //public void BeingLate()
        //{
        //    Console.WriteLine("Sorry for being late");
        //}

        public override string AddWorker()
        {
            throw new NotImplementedException();
        }

        public override string DeleteWorker()
        {
            throw new NotImplementedException();
        }

        public override string ChangeWorkerInfo()
        {
            throw new NotImplementedException();
        }
    }
}
