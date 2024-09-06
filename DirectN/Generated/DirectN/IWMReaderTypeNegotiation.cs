#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wmsdkidl/nn-wmsdkidl-iwmreadertypenegotiation
[GeneratedComInterface, Guid("fdbe5592-81a1-41ea-93bd-735cad1adc05")]
public partial interface IWMReaderTypeNegotiation
{
    // https://learn.microsoft.com/windows/win32/api/wmsdkidl/nf-wmsdkidl-iwmreadertypenegotiation-tryoutputprops
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT TryOutputProps(uint dwOutputNum, IWMOutputMediaProps pOutput);
}
