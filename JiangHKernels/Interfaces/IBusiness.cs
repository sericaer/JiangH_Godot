using System.Collections.Generic;

namespace JiangHKernels.Interfaces
{
    public interface IBusiness : IEntity, GMInterface
    {
        string name { get; }

        //IBranch branch { get; }

        ISociety society { get; }

        //IEnumerable<IProduct> MakeProduct();

        IEnumerable<IProduct> productsBase { get; }

        IEnumerable<IProduct> productsCurr { get; }

        IEnumerable<(string desc, double value)> efficientDetail { get; }
    }
}
