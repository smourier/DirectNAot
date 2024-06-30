#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/nspapi/ns-nspapi-blob
public partial struct BLOB
{
    public uint cbSize;
    public nint pBlobData;
}
