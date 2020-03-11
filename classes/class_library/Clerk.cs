using System;
using System.Collections.Generic;
using System.Text;

namespace classes_library
{
    public class Clerk : Worker
    {

        public string _officenum;
        public string OfficeNum
        {
            get { return _officenum; }

            set
            {
                if ((value.Length > 6) || (value.Length == 0))
                {
                    _officenum = "000000";
                }
                else
                {
                    _officenum = value;
                }
            }
        }

        

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
