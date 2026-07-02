#nullable enable
namespace DirectN;

public partial struct D3D12_TRIM_NOTIFICATION
{
    public nint pContext;
    public D3D12_TRIM_NOTIFICATION_FLAGS Flags;
    public ulong NumBytesToTrim;
}
