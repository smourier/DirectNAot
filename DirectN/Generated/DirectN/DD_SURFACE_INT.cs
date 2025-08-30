#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/ddrawint/ns-ddrawint-dd_surface_int
public partial struct DD_SURFACE_INT : IValueGet<nint>
{
    public nint lpLcl;
    
    readonly nint IValueGet<nint>.GetValue() => lpLcl;
    readonly object? IValueGet.GetValue() => lpLcl;
}
