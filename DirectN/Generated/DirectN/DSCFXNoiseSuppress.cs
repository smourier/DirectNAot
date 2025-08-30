#nullable enable
namespace DirectN;

public partial struct DSCFXNoiseSuppress : IValueGet<BOOL>
{
    public BOOL fEnable;
    
    readonly BOOL IValueGet<BOOL>.GetValue() => fEnable;
    readonly object? IValueGet.GetValue() => fEnable;
}
