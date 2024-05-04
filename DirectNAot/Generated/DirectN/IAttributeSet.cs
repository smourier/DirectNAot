#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dsattrib/nn-dsattrib-iattributeset
[GeneratedComInterface, Guid("583ec3cc-4960-4857-982b-41a33ea0a006")]
public partial interface IAttributeSet
{
    // https://learn.microsoft.com/windows/win32/api/dsattrib/nf-dsattrib-iattributeset-setattrib
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetAttrib(Guid guidAttribute, nint /* byte array */ pbAttribute, uint dwAttributeLength);
}
