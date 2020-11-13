using AnotherLib;
using System;
using System.Collections.Generic;

namespace NDependRepro
{
    public interface IDependentInterface
    {
        RootClass SomeGetter { get; }
        List<RootClass> ListGetter { get; }
    }
}
