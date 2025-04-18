#nullable enable
namespace DirectN;

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
    public BOOL bDiscardable;
}
