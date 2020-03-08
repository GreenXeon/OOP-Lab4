using System;
using System.Collections.Generic;
using System.Text;

namespace classes_library
{
    public class WorkshopWorker : Worker
    {
        public enum Shifts : byte
        {
            Morning,
            Afternoon,
            Evening,
            Night
        }

        public string WrkshopType { get; set; }
        public Shifts Sft
        {
            get
            {
                return Sft;
            }

            set
            {
                Sft = (Shifts)value;
            }
        }

        public WorkshopWorker(string sft, string wrkshop_type)
        {
            Sft = (Shifts)Enum.Parse(typeof(Shifts), sft);
            WrkshopType = wrkshop_type;

        }

        //public void HaveSmokeBreak()
        //{
        //    Console.WriteLine("I am smoking now...");
        //}

        //public void EndSmokeBreak()
        //{
        //    Console.WriteLine("I have ended smoking...");
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
