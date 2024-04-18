namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct VMEML
{
    public nint next;
    public nuint ptr;
    public uint size;
    
    [MarshalAs(UnmanagedType.U4)]
    public bool bDiscardable;
}
