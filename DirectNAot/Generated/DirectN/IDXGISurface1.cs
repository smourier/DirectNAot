namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dxgi/nn-dxgi-idxgisurface1
[SupportedOSPlatform("windows6.1")]
[GeneratedComInterface, Guid("4ae63092-6327-4c1b-80ae-bfe12ea32b86")]
public partial interface IDXGISurface1 : IDXGISurface
{
    // https://learn.microsoft.com/windows/win32/api/dxgi/nf-dxgi-idxgisurface1-getdc
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetDC([MarshalAs(UnmanagedType.U4)] bool Discard, out HDC phdc);
    
    // https://learn.microsoft.com/windows/win32/api/dxgi/nf-dxgi-idxgisurface1-releasedc
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT ReleaseDC(nint /* optional FoundationRECT */ pDirtyRect);
}
