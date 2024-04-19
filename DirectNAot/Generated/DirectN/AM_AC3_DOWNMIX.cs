namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct AM_AC3_DOWNMIX
{
    [MarshalAs(UnmanagedType.U4)]
    public bool fDownMix;
    
    [MarshalAs(UnmanagedType.U4)]
    public bool fDolbySurround;
}
