#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dxmini/ns-dxmini-ddlockininfo
public partial struct DDLOCKININFO : IValueGet<nint>
{
    public nint lpSurfaceData;
    
    readonly nint IValueGet<nint>.GetValue() => lpSurfaceData;
    readonly object? IValueGet.GetValue() => lpSurfaceData;
}
