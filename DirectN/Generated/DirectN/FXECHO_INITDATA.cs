#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/xapofx/ns-xapofx-fxecho_initdata
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct FXECHO_INITDATA : IValueGet<float>
{
    public float MaxDelay;
    
    readonly float IValueGet<float>.GetValue() => MaxDelay;
    readonly object? IValueGet.GetValue() => MaxDelay;
}
