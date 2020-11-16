using AnotherLib;
using System.Collections.Generic;

namespace NDependRepro
{
    public class CtrDependentBaseClass
    {
        RootClass X;
        
        public CtrDependentBaseClass(RootClass x)
        {
            X = x;            
        }
    }
}
