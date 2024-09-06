#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d9/nn-d3d9-idirect3dcryptosession9
[SupportedOSPlatform("windows6.1")]
[GeneratedComInterface, Guid("fa0ab799-7a9c-48ca-8c5b-237e71a54434")]
public partial interface IDirect3DCryptoSession9
{
    // https://learn.microsoft.com/windows/win32/api/d3d9/nf-d3d9-idirect3dcryptosession9-getcertificatesize
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetCertificateSize(ref uint pCertificateSize);
    
    // https://learn.microsoft.com/windows/win32/api/d3d9/nf-d3d9-idirect3dcryptosession9-getcertificate
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetCertificate(uint CertifacteSize, nint /* byte array */ ppCertificate);
    
    // https://learn.microsoft.com/windows/win32/api/d3d9/nf-d3d9-idirect3dcryptosession9-negotiatekeyexchange
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT NegotiateKeyExchange(uint DataSize, nint pData);
    
    // https://learn.microsoft.com/windows/win32/api/d3d9/nf-d3d9-idirect3dcryptosession9-encryptionblt
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT EncryptionBlt(IDirect3DSurface9 pSrcSurface, IDirect3DSurface9 pDstSurface, uint DstSurfaceSize, nint pIV);
    
    // https://learn.microsoft.com/windows/win32/api/d3d9/nf-d3d9-idirect3dcryptosession9-decryptionblt
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT DecryptionBlt(IDirect3DSurface9 pSrcSurface, IDirect3DSurface9 pDstSurface, uint SrcSurfaceSize, ref D3DENCRYPTED_BLOCK_INFO pEncryptedBlockInfo, nint pContentKey, nint pIV);
    
    // https://learn.microsoft.com/windows/win32/api/d3d9/nf-d3d9-idirect3dcryptosession9-getsurfacepitch
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetSurfacePitch(IDirect3DSurface9 pSrcSurface, ref uint pSurfacePitch);
    
    // https://learn.microsoft.com/windows/win32/api/d3d9/nf-d3d9-idirect3dcryptosession9-startsessionkeyrefresh
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT StartSessionKeyRefresh(nint pRandomNumber, uint RandomNumberSize);
    
    // https://learn.microsoft.com/windows/win32/api/d3d9/nf-d3d9-idirect3dcryptosession9-finishsessionkeyrefresh
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT FinishSessionKeyRefresh();
    
    // https://learn.microsoft.com/windows/win32/api/d3d9/nf-d3d9-idirect3dcryptosession9-getencryptionbltkey
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetEncryptionBltKey(nint pReadbackKey, uint KeySize);
}
