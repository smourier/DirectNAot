namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/vfw/nn-vfw-igetframe
[SupportedOSPlatform("windows5.0")]
[GeneratedComInterface, Guid("00020023-0000-0000-c000-000000000046")]
public partial interface IGetFrame
{
    // https://learn.microsoft.com/windows/win32/api/vfw/nf-vfw-igetframe-getframe
    [PreserveSig]
    void GetFrame(int lPos);
    
    // https://learn.microsoft.com/windows/win32/api/vfw/nf-vfw-igetframe-begin
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Begin(int lStart, int lEnd, int lRate);
    
    // https://learn.microsoft.com/windows/win32/api/vfw/nf-vfw-igetframe-end
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT End();
    
    // https://learn.microsoft.com/windows/win32/api/vfw/nf-vfw-igetframe-setformat
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetFormat(in BITMAPINFOHEADER lpbi, nint /* optional void* */ lpBits, int x, int y, int dx, int dy);
}
