namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct DSCFXNoiseSuppress
{
    [MarshalAs(UnmanagedType.U4)]
    public bool fEnable;
}
