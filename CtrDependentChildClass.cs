using AnotherLib;
using System.Collections.Generic;

namespace NDependRepro
{
    public class CtrDependentChildClass : CtrDependentBaseClass
    {
        List<RootClass> Xs = new List<RootClass>();
        public CtrDependentChildClass(RootClass x) : base(x)
        {
            Xs.Add(x);
        }
    }
}
