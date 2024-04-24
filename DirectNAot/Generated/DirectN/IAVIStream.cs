namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/vfw/nn-vfw-iavistream
[SupportedOSPlatform("windows5.0")]
[GeneratedComInterface, Guid("00020021-0000-0000-c000-000000000046")]
public partial interface IAVIStream
{
    // https://learn.microsoft.com/windows/win32/api/vfw/nf-vfw-iavistream-create
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Create(LPARAM lParam1, LPARAM lParam2);
    
    // https://learn.microsoft.com/windows/win32/api/vfw/nf-vfw-iavistream-info
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Info(out AVISTREAMINFOW psi, int lSize);
    
    // https://learn.microsoft.com/windows/win32/api/vfw/nf-vfw-iavistream-findsample
    [PreserveSig]
    int FindSample(int lPos, int lFlags);
    
    // https://learn.microsoft.com/windows/win32/api/vfw/nf-vfw-iavistream-readformat
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT ReadFormat(int lPos, nint /* optional void* */ lpFormat, ref int lpcbFormat);
    
    // https://learn.microsoft.com/windows/win32/api/vfw/nf-vfw-iavistream-setformat
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetFormat(int lPos, nint lpFormat, int cbFormat);
    
    // https://learn.microsoft.com/windows/win32/api/vfw/nf-vfw-iavistream-read
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Read(int lStart, int lSamples, nint /* optional void* */ lpBuffer, int cbBuffer, nint /* optional int* */ plBytes, nint /* optional int* */ plSamples);
    
    // https://learn.microsoft.com/windows/win32/api/vfw/nf-vfw-iavistream-write
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Write(int lStart, int lSamples, nint lpBuffer, int cbBuffer, uint dwFlags, nint /* optional int* */ plSampWritten, nint /* optional int* */ plBytesWritten);
    
    // https://learn.microsoft.com/windows/win32/api/vfw/nf-vfw-iavistream-delete
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Delete(int lStart, int lSamples);
    
    // https://learn.microsoft.com/windows/win32/api/vfw/nf-vfw-iavistream-readdata
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT ReadData(uint fcc, nint /* optional void* */ lp, ref int lpcb);
    
    // https://learn.microsoft.com/windows/win32/api/vfw/nf-vfw-iavistream-writedata
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT WriteData(uint fcc, nint lp, int cb);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetInfo(in AVISTREAMINFOW lpInfo, int cbInfo);
}
