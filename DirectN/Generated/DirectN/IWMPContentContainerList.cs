#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/contentpartner/nn-contentpartner-iwmpcontentcontainerlist
[GeneratedComInterface, Guid("a9937f78-0802-4af8-8b8d-e3f045bc8ab5")]
public partial interface IWMPContentContainerList
{
    // https://learn.microsoft.com/windows/win32/api/contentpartner/nf-contentpartner-iwmpcontentcontainerlist-gettransactiontype
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetTransactionType(out WMPTransactionType pwmptt);
    
    // https://learn.microsoft.com/windows/win32/api/contentpartner/nf-contentpartner-iwmpcontentcontainerlist-getcontainercount
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetContainerCount(out uint pcContainer);
    
    // https://learn.microsoft.com/windows/win32/api/contentpartner/nf-contentpartner-iwmpcontentcontainerlist-getcontainer
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetContainer(uint idxContainer, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IWMPContentContainer>))] out IWMPContentContainer ppContent);
}
