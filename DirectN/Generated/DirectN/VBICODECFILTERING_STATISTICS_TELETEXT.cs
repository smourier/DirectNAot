#nullable enable
namespace DirectN;

public partial struct VBICODECFILTERING_STATISTICS_TELETEXT : IValueGet<VBICODECFILTERING_STATISTICS_COMMON>
{
    public VBICODECFILTERING_STATISTICS_COMMON Common;
    
    readonly VBICODECFILTERING_STATISTICS_COMMON IValueGet<VBICODECFILTERING_STATISTICS_COMMON>.GetValue() => Common;
    readonly object? IValueGet.GetValue() => Common;
}
