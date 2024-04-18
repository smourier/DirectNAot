namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d11_1/ns-d3d11_1-d3d11_key_exchange_hw_protection_output_data
[StructLayout(LayoutKind.Sequential)]
public partial struct D3D11_KEY_EXCHANGE_HW_PROTECTION_OUTPUT_DATA
{
    public uint PrivateDataSize;
    public uint MaxHWProtectionDataSize;
    public uint HWProtectionDataSize;
    public ulong TransportTime;
    public ulong ExecutionTime;
    public InlineArrayByte4 pbOutput;
}
