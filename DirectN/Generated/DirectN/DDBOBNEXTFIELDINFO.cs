#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dxmini/ns-dxmini-ddbobnextfieldinfo
public partial struct DDBOBNEXTFIELDINFO : IValueGet<nint>
{
    public nint lpSurface;
    
    readonly nint IValueGet<nint>.GetValue() => lpSurface;
    readonly object? IValueGet.GetValue() => lpSurface;
}
