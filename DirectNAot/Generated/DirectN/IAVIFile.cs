namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/vfw/nn-vfw-iavifile
[SupportedOSPlatform("windows5.0")]
[GeneratedComInterface, Guid("00020020-0000-0000-c000-000000000046")]
public partial interface IAVIFile
{
    // https://learn.microsoft.com/windows/win32/api/vfw/nf-vfw-iavifile-info
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Info(out AVIFILEINFOW pfi, int lSize);
    
    // https://learn.microsoft.com/windows/win32/api/vfw/nf-vfw-iavifile-getstream
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetStream(out IAVIStream ppStream, uint fccType, int lParam);
    
    // https://learn.microsoft.com/windows/win32/api/vfw/nf-vfw-iavifile-createstream
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateStream(out IAVIStream ppStream, in AVISTREAMINFOW psi);
    
    // https://learn.microsoft.com/windows/win32/api/vfw/nf-vfw-iavifile-writedata
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT WriteData(uint ckid, nint lpData, int cbData);
    
    // https://learn.microsoft.com/windows/win32/api/vfw/nf-vfw-iavifile-readdata
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT ReadData(uint ckid, nint lpData, ref int lpcbData);
    
    // https://learn.microsoft.com/windows/win32/api/vfw/nf-vfw-iavifile-endrecord
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT EndRecord();
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT DeleteStream(uint fccType, int lParam);
}
