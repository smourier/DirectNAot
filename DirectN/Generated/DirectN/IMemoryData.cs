#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/austream/nn-austream-imemorydata
[GeneratedComInterface, Guid("327fc560-af60-11d0-8212-00c04fc32c45")]
public partial interface IMemoryData
{
    // https://learn.microsoft.com/windows/win32/api/austream/nf-austream-imemorydata-setbuffer
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetBuffer(uint cbSize, nint /* byte array */ pbData, uint dwFlags);
    
    // https://learn.microsoft.com/windows/win32/api/austream/nf-austream-imemorydata-getinfo
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetInfo(out uint pdwLength, out nint /* byte array */ ppbData, out uint pcbActualData);
    
    // https://learn.microsoft.com/windows/win32/api/austream/nf-austream-imemorydata-setactual
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetActual(uint cbDataValid);
}
