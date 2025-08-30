#nullable enable
namespace DirectN;

public partial struct VBICODECFILTERING_STATISTICS_CC_PIN : IValueGet<VBICODECFILTERING_STATISTICS_COMMON_PIN>
{
    public VBICODECFILTERING_STATISTICS_COMMON_PIN Common;
    
    readonly VBICODECFILTERING_STATISTICS_COMMON_PIN IValueGet<VBICODECFILTERING_STATISTICS_COMMON_PIN>.GetValue() => Common;
    readonly object? IValueGet.GetValue() => Common;
}
