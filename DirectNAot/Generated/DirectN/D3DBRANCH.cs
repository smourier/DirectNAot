namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct D3DBRANCH
{
    public uint dwMask;
    public uint dwValue;
    
    [MarshalAs(UnmanagedType.U4)]
    public bool bNegate;
    public uint dwOffset;
}
