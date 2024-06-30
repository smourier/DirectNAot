#nullable enable
namespace DirectN;

public partial struct DDHAL_DDEXEBUFCALLBACKS
{
    public uint dwSize;
    public uint dwFlags;
    public nint CanCreateExecuteBuffer;
    public nint CreateExecuteBuffer;
    public nint DestroyExecuteBuffer;
    public nint LockExecuteBuffer;
    public nint UnlockExecuteBuffer;
}
