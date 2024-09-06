#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/bdaiface/nn-bdaiface-ibda_namevalueservice
[GeneratedComInterface, Guid("7f0b3150-7b81-4ad4-98e3-7e9097094301")]
public partial interface IBDA_NameValueService
{
    // https://learn.microsoft.com/windows/win32/api/bdaiface/nf-bdaiface-ibda_namevalueservice-getvaluenamebyindex
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetValueNameByIndex(uint ulIndex, out BSTR pbstrName);
    
    // https://learn.microsoft.com/windows/win32/api/bdaiface/nf-bdaiface-ibda_namevalueservice-getvalue
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetValue(BSTR bstrName, BSTR bstrLanguage, out BSTR pbstrValue);
    
    // https://learn.microsoft.com/windows/win32/api/bdaiface/nf-bdaiface-ibda_namevalueservice-setvalue
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetValue(uint ulDialogRequest, BSTR bstrLanguage, BSTR bstrName, BSTR bstrValue, uint ulReserved);
}
