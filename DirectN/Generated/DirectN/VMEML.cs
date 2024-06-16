#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct VMEML
{
    public nint next;
    public nuint ptr;
    public uint size;
    public BOOL bDiscardable;
}
