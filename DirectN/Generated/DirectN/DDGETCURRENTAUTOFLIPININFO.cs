#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dxmini/ns-dxmini-ddgetcurrentautoflipininfo
public partial struct DDGETCURRENTAUTOFLIPININFO : IValueGet<nint>
{
    public nint lpVideoPortData;
    
    readonly nint IValueGet<nint>.GetValue() => lpVideoPortData;
    readonly object? IValueGet.GetValue() => lpVideoPortData;
}
