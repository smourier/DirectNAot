#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d9/nn-d3d9-idirect3ddevice9video
[SupportedOSPlatform("windows6.1")]
[GeneratedComInterface, Guid("26dc4561-a1ee-4ae7-96da-118a36c0ec95")]
public partial interface IDirect3DDevice9Video
{
    // https://learn.microsoft.com/windows/win32/api/d3d9/nf-d3d9-idirect3ddevice9video-getcontentprotectioncaps
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetContentProtectionCaps(in Guid pCryptoType, in Guid pDecodeProfile, ref D3DCONTENTPROTECTIONCAPS pCaps);
    
    // https://learn.microsoft.com/windows/win32/api/d3d9/nf-d3d9-idirect3ddevice9video-createauthenticatedchannel
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateAuthenticatedChannel(D3DAUTHENTICATEDCHANNELTYPE ChannelType, out IDirect3DAuthenticatedChannel9 ppAuthenticatedChannel, ref HANDLE pChannelHandle);
    
    // https://learn.microsoft.com/windows/win32/api/d3d9/nf-d3d9-idirect3ddevice9video-createcryptosession
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateCryptoSession(in Guid pCryptoType, in Guid pDecodeProfile, out IDirect3DCryptoSession9 ppCryptoSession, ref HANDLE pCryptoHandle);
}
