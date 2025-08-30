#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dxmini/ns-dxmini-ddgetpolarityininfo
public partial struct DDGETPOLARITYININFO : IValueGet<nint>
{
    public nint lpVideoPortData;
    
    readonly nint IValueGet<nint>.GetValue() => lpVideoPortData;
    readonly object? IValueGet.GetValue() => lpVideoPortData;
}
