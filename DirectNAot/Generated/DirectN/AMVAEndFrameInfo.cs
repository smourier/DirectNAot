namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/amva/ns-amva-amvaendframeinfo
[StructLayout(LayoutKind.Sequential)]
public partial struct AMVAEndFrameInfo
{
    public uint dwSizeMiscData;
    public nint pMiscData;
}
