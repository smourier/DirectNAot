namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct DXVAHDETW_VIDEOPROCESSBLTSTATE
{
    public ulong pObject;
    public DXVAHD_BLT_STATE State;
    public uint DataSize;
    
    [MarshalAs(UnmanagedType.U4)]
    public bool SetState;
}
