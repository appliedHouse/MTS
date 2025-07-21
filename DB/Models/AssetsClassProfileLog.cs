using System;
using System.Collections.Generic;

namespace DB.Models;

public partial class AssetsClassProfileLog
{
    public int AssetsClassProfileLogId { get; set; }

    public int ClassId { get; set; }

    public string ProfileName { get; set; } = null!;

    public int TypeId { get; set; }

    public string? SuppliersName { get; set; }

    public decimal DefualtPrice { get; set; }

    public decimal? DefaultUnitPrice { get; set; }

    public decimal? DefaultSalePrice { get; set; }

    public decimal? DefaultExtraUnitCost { get; set; }

    public decimal? DefaultProfitUnitAmount { get; set; }

    public int ItemDefualtUnit { get; set; }

    public int WeightDefualtUnit { get; set; }

    public int? DefualtMaintancePlanId { get; set; }

    public DateTime? StartMaintancePlanDate { get; set; }

    public double DepreciationPercentage { get; set; }

    public decimal Vat { get; set; }

    public int ContainerModeId { get; set; }

    public bool ContainerHaveFixedExtraCost { get; set; }

    public Guid AddTransactionId { get; set; }

    public Guid? UpdateTransactionId { get; set; }

    public DateTime UpdateDate { get; set; }
}
