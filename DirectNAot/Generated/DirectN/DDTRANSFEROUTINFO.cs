namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dxmini/ns-dxmini-ddtransferoutinfo
[StructLayout(LayoutKind.Sequential)]
public partial struct DDTRANSFEROUTINFO
{
    public uint dwBufferPolarity;
}
