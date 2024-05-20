#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wmsdkidl/nn-wmsdkidl-iwmreaderallocatorex
[GeneratedComInterface, Guid("9f762fa7-a22e-428d-93c9-ac82f3aafe5a")]
public partial interface IWMReaderAllocatorEx
{
    // https://learn.microsoft.com/windows/win32/api/wmsdkidl/nf-wmsdkidl-iwmreaderallocatorex-allocateforstreamex
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT AllocateForStreamEx(ushort wStreamNum, uint cbBuffer, out INSSBuffer ppBuffer, uint dwFlags, ulong cnsSampleTime, ulong cnsSampleDuration, nint pvContext);
    
    // https://learn.microsoft.com/windows/win32/api/wmsdkidl/nf-wmsdkidl-iwmreaderallocatorex-allocateforoutputex
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT AllocateForOutputEx(uint dwOutputNum, uint cbBuffer, out INSSBuffer ppBuffer, uint dwFlags, ulong cnsSampleTime, ulong cnsSampleDuration, nint pvContext);
}
