namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct DSCFXAec
{
    [MarshalAs(UnmanagedType.U4)]
    public bool fEnable;
    
    [MarshalAs(UnmanagedType.U4)]
    public bool fNoiseFill;
    public uint dwMode;
}
