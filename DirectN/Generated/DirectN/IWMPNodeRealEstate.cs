#nullable enable
namespace DirectN;

[GeneratedComInterface, Guid("42751198-5a50-4460-bcb4-709f8bdc8e59")]
public partial interface IWMPNodeRealEstate
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetDesiredSize(ref SIZE pSize);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetRects(in RECT pSrc, in RECT pDest, in RECT pClip);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetRects(ref RECT pSrc, ref RECT pDest, ref RECT pClip);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetWindowless(BOOL fWindowless);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetWindowless(ref BOOL pfWindowless);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetFullScreen(BOOL fFullScreen);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetFullScreen(ref BOOL pfFullScreen);
}
