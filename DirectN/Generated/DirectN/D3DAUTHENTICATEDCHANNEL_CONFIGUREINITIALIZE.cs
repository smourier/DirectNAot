#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/medfound/d3dauthenticatedchannel-configureinitialize
public partial struct D3DAUTHENTICATEDCHANNEL_CONFIGUREINITIALIZE
{
    public D3DAUTHENTICATEDCHANNEL_CONFIGURE_INPUT Parameters;
    public uint StartSequenceQuery;
    public uint StartSequenceConfigure;
}
