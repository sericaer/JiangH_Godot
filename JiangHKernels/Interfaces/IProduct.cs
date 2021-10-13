using System;
using System.Collections.Generic;
using System.Text;

namespace JiangHKernels.Interfaces
{
    public interface IProduct
    {
        ProductType type { get; }
        double value { get; set; }
    }

    public enum ProductType
    {
        Money
    }
}
