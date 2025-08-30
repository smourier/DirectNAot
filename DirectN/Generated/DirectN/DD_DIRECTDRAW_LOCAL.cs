#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/ddrawint/ns-ddrawint-dd_directdraw_local
public partial struct DD_DIRECTDRAW_LOCAL : IValueGet<nint>
{
    public nint lpGbl;
    
    readonly nint IValueGet<nint>.GetValue() => lpGbl;
    readonly object? IValueGet.GetValue() => lpGbl;
}
