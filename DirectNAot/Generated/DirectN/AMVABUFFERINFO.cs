namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/amva/ns-amva-amvabufferinfo
[StructLayout(LayoutKind.Sequential)]
public partial struct AMVABUFFERINFO
{
    public uint dwTypeIndex;
    public uint dwBufferIndex;
    public uint dwDataOffset;
    public uint dwDataSize;
}
