#nullable enable
namespace DirectN;

public partial struct KS_DATARANGE_BDA_ANTENNA : IValueGet<KSDATAFORMAT>
{
    public KSDATAFORMAT DataRange;
    
    readonly KSDATAFORMAT IValueGet<KSDATAFORMAT>.GetValue() => DataRange;
    readonly object? IValueGet.GetValue() => DataRange;
}
