#nullable enable
namespace DirectN;

public partial struct D3D12_REGISTER_TRIM_NOTIFICATION
{
    public nint pfnCallback;
    public nint pContext;
    public uint CallbackCookie;
}
