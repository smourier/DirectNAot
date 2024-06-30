#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/medfound/d3dencrypted-block-info
public partial struct D3DENCRYPTED_BLOCK_INFO
{
    public uint NumEncryptedBytesAtBeginning;
    public uint NumBytesInSkipPattern;
    public uint NumBytesInEncryptPattern;
}
