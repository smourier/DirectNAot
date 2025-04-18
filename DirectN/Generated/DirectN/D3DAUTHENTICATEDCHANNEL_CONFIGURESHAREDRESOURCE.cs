#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/medfound/d3dauthenticatedchannel-configuresharedresource
public partial struct D3DAUTHENTICATEDCHANNEL_CONFIGURESHAREDRESOURCE
{
    public D3DAUTHENTICATEDCHANNEL_CONFIGURE_INPUT Parameters;
    public D3DAUTHENTICATEDCHANNEL_PROCESSIDENTIFIERTYPE ProcessIdentiferType;
    public HANDLE ProcessHandle;
    public BOOL AllowAccess;
}
