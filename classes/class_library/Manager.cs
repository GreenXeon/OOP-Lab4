using System;
using System.Collections.Generic;
using System.Text;

namespace classes_library
{
    public class Manager : Worker
    {
        public string Department { get; set; }
        public int QuantOfInfer { get; set; }

        public override string AddWorker()
        {
            throw new NotImplementedException();
        }

        //public void CallIntoOffice()
        //{
        //    Console.WriteLine("Come to my office, please");
        //}

        public override string ChangeWorkerInfo()
        {
            throw new NotImplementedException();
        }

        public override string DeleteWorker()
        {
            throw new NotImplementedException();
        }
    }

}
