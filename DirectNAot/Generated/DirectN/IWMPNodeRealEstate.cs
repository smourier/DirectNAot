namespace DirectN;

[GeneratedComInterface, Guid("42751198-5a50-4460-bcb4-709f8bdc8e59")]
public partial interface IWMPNodeRealEstate
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetDesiredSize(ref FoundationSIZE pSize);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetRects(FoundationRECT pSrc, FoundationRECT pDest, FoundationRECT pClip);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetRects(ref FoundationRECT pSrc, ref FoundationRECT pDest, ref FoundationRECT pClip);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetWindowless([MarshalAs(UnmanagedType.U4)] bool fWindowless);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetWindowless([MarshalAs(UnmanagedType.U4)] ref bool pfWindowless);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetFullScreen([MarshalAs(UnmanagedType.U4)] bool fFullScreen);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetFullScreen([MarshalAs(UnmanagedType.U4)] ref bool pfFullScreen);
}
