namespace DirectN;

// https://learn.microsoft.com/windows/win32/medfound/d3dauthenticatedchannel-configureuncompressedencryption
[StructLayout(LayoutKind.Sequential)]
public partial struct D3DAUTHENTICATEDCHANNEL_CONFIGUREUNCOMPRESSEDENCRYPTION
{
    public D3DAUTHENTICATEDCHANNEL_CONFIGURE_INPUT Parameters;
    public Guid EncryptionGuid;
}
