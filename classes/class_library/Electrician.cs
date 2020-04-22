using System;
using System.Collections.Generic;
using System.Text;

namespace classes_library
{
    [Serializable]
    public class Electrician : Clerk
    {
        public enum Tools
        {
            Screwdriver,
            Hammer,
            Nails,
            Lantern,
            Drill

        }
        public Tools Tool { get; set; }
        

    }

}
