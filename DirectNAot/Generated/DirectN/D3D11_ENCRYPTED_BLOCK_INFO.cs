namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d11/ns-d3d11-d3d11_encrypted_block_info
[StructLayout(LayoutKind.Sequential)]
public partial struct D3D11_ENCRYPTED_BLOCK_INFO
{
    public uint NumEncryptedBytesAtBeginning;
    public uint NumBytesInSkipPattern;
    public uint NumBytesInEncryptPattern;
}
