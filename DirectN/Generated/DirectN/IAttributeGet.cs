#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dsattrib/nn-dsattrib-iattributeget
[GeneratedComInterface, Guid("52dbd1ec-e48f-4528-9232-f442a68f0ae1")]
public partial interface IAttributeGet
{
    // https://learn.microsoft.com/windows/win32/api/dsattrib/nf-dsattrib-iattributeget-getcount
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetCount(out int plCount);
    
    // https://learn.microsoft.com/windows/win32/api/dsattrib/nf-dsattrib-iattributeget-getattribindexed
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetAttribIndexed(int lIndex, out Guid pguidAttribute, nint /* byte array */ pbAttribute, ref uint pdwAttributeLength);
    
    // https://learn.microsoft.com/windows/win32/api/dsattrib/nf-dsattrib-iattributeget-getattrib
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetAttrib(Guid guidAttribute, nint /* byte array */ pbAttribute, ref uint pdwAttributeLength);
}
