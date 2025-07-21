using System;
using System.Collections.Generic;

namespace DB.Models;

public partial class AssetsClassProfile
{
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

    public virtual SystemTransaction AddTransaction { get; set; } = null!;

    public virtual AssetsClassfication Class { get; set; } = null!;

    public virtual LtcontainerMode ContainerMode { get; set; } = null!;

    public virtual AssetMaintenancePlan? DefualtMaintancePlan { get; set; }

    public virtual LtassetUnit ItemDefualtUnitNavigation { get; set; } = null!;

    public virtual LtassetType Type { get; set; } = null!;

    public virtual SystemTransaction? UpdateTransaction { get; set; }

    public virtual LtassetUnit WeightDefualtUnitNavigation { get; set; } = null!;
}
