#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/oaidl/ns-oaidl-bindptr
[StructLayout(LayoutKind.Explicit)]
public partial struct BINDPTR
{
    [FieldOffset(0)]
    public nint lpfuncdesc;
    
    [FieldOffset(0)]
    public nint lpvardesc;
    
    [FieldOffset(0)]
    public nint lptcomp;
}
