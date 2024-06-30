#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/medfound/d3dauthenticatedchannel-configure-input
public partial struct D3DAUTHENTICATEDCHANNEL_CONFIGURE_INPUT
{
    public D3D_OMAC omac;
    public Guid ConfigureType;
    public HANDLE hChannel;
    public uint SequenceNumber;
}
