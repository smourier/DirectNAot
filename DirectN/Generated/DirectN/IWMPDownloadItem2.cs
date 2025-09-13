#nullable enable
namespace DirectN;

[GeneratedComInterface, Guid("9fbb3336-6da3-479d-b8ff-67d46e20a987")]
public partial interface IWMPDownloadItem2 : IWMPDownloadItem
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT getItemInfo(BSTR bstrItemName, out BSTR pbstrVal);
}
