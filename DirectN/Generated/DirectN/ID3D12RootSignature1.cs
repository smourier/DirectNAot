#nullable enable
namespace DirectN;

[GeneratedComInterface, Guid("c390bd7d-9142-4a95-b072-6d3439ade5c4")]
public partial interface ID3D12RootSignature1 : ID3D12RootSignature
{
    [PreserveSig]
    nuint GetSerializedSize();
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetSerializedData(nint pData, nuint Size);
}
