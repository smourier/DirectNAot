#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wmsbuffer/nn-wmsbuffer-inssbuffer4
[GeneratedComInterface, Guid("b6b8fd5a-32e2-49d4-a910-c26cc85465ed")]
public partial interface INSSBuffer4 : INSSBuffer3
{
    // https://learn.microsoft.com/windows/win32/api/wmsbuffer/nf-wmsbuffer-inssbuffer4-getpropertycount
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetPropertyCount(out uint pcBufferProperties);
    
    // https://learn.microsoft.com/windows/win32/api/wmsbuffer/nf-wmsbuffer-inssbuffer4-getpropertybyindex
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetPropertyByIndex(uint dwBufferPropertyIndex, out Guid pguidBufferProperty, nint pvBufferProperty, ref uint pdwBufferPropertySize);
}
