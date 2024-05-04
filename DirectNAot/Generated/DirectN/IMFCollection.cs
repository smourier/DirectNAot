#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mfobjects/nn-mfobjects-imfcollection
[SupportedOSPlatform("windows6.0.6000")]
[GeneratedComInterface, Guid("5bc8a76b-869a-46a3-9b03-fa218a66aebe")]
public partial interface IMFCollection
{
    // https://learn.microsoft.com/windows/win32/api/mfobjects/nf-mfobjects-imfcollection-getelementcount
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetElementCount(out uint pcElements);
    
    // https://learn.microsoft.com/windows/win32/api/mfobjects/nf-mfobjects-imfcollection-getelement
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetElement(uint dwElementIndex, out nint ppUnkElement);
    
    // https://learn.microsoft.com/windows/win32/api/mfobjects/nf-mfobjects-imfcollection-addelement
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT AddElement(nint pUnkElement);
    
    // https://learn.microsoft.com/windows/win32/api/mfobjects/nf-mfobjects-imfcollection-removeelement
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT RemoveElement(uint dwElementIndex, out nint ppUnkElement);
    
    // https://learn.microsoft.com/windows/win32/api/mfobjects/nf-mfobjects-imfcollection-insertelementat
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT InsertElementAt(uint dwIndex, nint pUnknown);
    
    // https://learn.microsoft.com/windows/win32/api/mfobjects/nf-mfobjects-imfcollection-removeallelements
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT RemoveAllElements();
}
