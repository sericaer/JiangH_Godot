using System.Collections.Generic;

namespace JiangHKernels.Interfaces
{
    public interface IBranch : IEntity, GMInterface
    {
        string name { get; }
        IPerson owner { get; }

        ISociety society { get; }

        IEnumerable<IBusiness> businesses { get; }

        IEnumerable<IPerson> persons { get; }

        IEnumerable<IProduct> products { get; }

        //void OnDaysInc((int y, int m, int d) dateValue);
    }
}
