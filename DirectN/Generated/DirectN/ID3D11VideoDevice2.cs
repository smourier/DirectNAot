#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d11_4/nn-d3d11_4-id3d11videodevice2
[GeneratedComInterface, Guid("59c0cb01-35f0-4a70-8f67-87905c906a53")]
public partial interface ID3D11VideoDevice2 : ID3D11VideoDevice1
{
    // https://learn.microsoft.com/windows/win32/api/d3d11_4/nf-d3d11_4-id3d11videodevice2-checkfeaturesupport
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CheckFeatureSupport(D3D11_FEATURE_VIDEO Feature, nint pFeatureSupportData, uint FeatureSupportDataSize);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT NegotiateCryptoSessionKeyExchangeMT(ID3D11CryptoSession pCryptoSession, D3D11_CRYPTO_SESSION_KEY_EXCHANGE_FLAGS flags, uint DataSize, nint pData);
}
