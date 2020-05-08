using System;
using System.Collections.Generic;

namespace IArchivePlugin
{
    public interface IPlugin
    { 
        void Compress(List<object> workers,string filename);
        List<object> Decompress(string filename);

    }
}
