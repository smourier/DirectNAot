#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mswmdm/nn-mswmdm-iwmdmoperation3
[GeneratedComInterface, Guid("d1f9b46a-9ca8-46d8-9d0f-1ec9bae54919")]
public partial interface IWMDMOperation3 : IWMDMOperation
{
    // https://learn.microsoft.com/windows/win32/api/mswmdm/nf-mswmdm-iwmdmoperation3-transferobjectdataonclearchannel
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT TransferObjectDataOnClearChannel(nint /* byte array */ pData, ref uint pdwSize);
}
