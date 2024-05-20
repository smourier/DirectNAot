#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct DXVAHDETW_CREATEVIDEOPROCESSOR
{
    public ulong pObject;
    public ulong pD3D9Ex;
    public Guid VPGuid;
}
