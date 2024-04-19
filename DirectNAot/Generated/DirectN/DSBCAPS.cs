namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct DSBCAPS
{
    public uint dwSize;
    public uint dwFlags;
    public uint dwBufferBytes;
    public uint dwUnlockTransferRate;
    public uint dwPlayCpuOverhead;
}
