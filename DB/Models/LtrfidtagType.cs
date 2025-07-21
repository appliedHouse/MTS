using System;
using System.Collections.Generic;

namespace DB.Models;

public partial class LtrfidtagType
{
    public int TagTypeId { get; set; }

    public string TagType { get; set; } = null!;

    public virtual ICollection<AssetFormEditTag> AssetFormEditTags { get; set; } = new List<AssetFormEditTag>();

    public virtual ICollection<AssetTagTransactionLog> AssetTagTransactionLogs { get; set; } = new List<AssetTagTransactionLog>();

    public virtual ICollection<AssetTag> AssetTags { get; set; } = new List<AssetTag>();

    public virtual ICollection<TempAssetEditTag> TempAssetEditTags { get; set; } = new List<TempAssetEditTag>();

    public virtual ICollection<TempAssetTag> TempAssetTags { get; set; } = new List<TempAssetTag>();
}
