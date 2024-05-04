#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct VMEMR
{
    public nint next;
    public nint prev;
    public nint pUp;
    public nint pDown;
    public nint pLeft;
    public nint pRight;
    public nuint ptr;
    public uint size;
    public uint x;
    public uint y;
    public uint cx;
    public uint cy;
    public uint flags;
    public nuint pBits;
    
    [MarshalAs(UnmanagedType.U4)]
    public bool bDiscardable;
}
