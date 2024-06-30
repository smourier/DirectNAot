#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d11_1/ns-d3d11_1-d3d11_key_exchange_hw_protection_data
public partial struct D3D11_KEY_EXCHANGE_HW_PROTECTION_DATA
{
    public uint HWProtectionFunctionID;
    public nint pInputData;
    public nint pOutputData;
    public HRESULT Status;
}
