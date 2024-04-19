namespace DirectN;

// https://learn.microsoft.com/windows/win32/medfound/d3dauthenticatedchannel-configure-output
[StructLayout(LayoutKind.Sequential)]
public partial struct D3DAUTHENTICATEDCHANNEL_CONFIGURE_OUTPUT
{
    public D3D_OMAC omac;
    public Guid ConfigureType;
    public HANDLE hChannel;
    public uint SequenceNumber;
    public HRESULT ReturnCode;
}
