namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mfidl/nn-mfidl-imfsampleallocatorcontrol
[SupportedOSPlatform("windows10.0.19041")]
[GeneratedComInterface, Guid("da62b958-3a38-4a97-bd27-149c640c0771")]
public partial interface IMFSampleAllocatorControl
{
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imfsampleallocatorcontrol-setdefaultallocator
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetDefaultAllocator(uint dwOutputStreamID, nint pAllocator);
    
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imfsampleallocatorcontrol-getallocatorusage
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetAllocatorUsage(uint dwOutputStreamID, out uint pdwInputStreamID, out MFSampleAllocatorUsage peUsage);
}
