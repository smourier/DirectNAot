#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/tom/nn-tom-itextstory
[SupportedOSPlatform("windows8.0")]
[GeneratedComInterface, Guid("c241f5f3-7206-11d8-a2c7-00a0d1d6c6b3")]
public partial interface ITextStory
{
    // https://learn.microsoft.com/windows/win32/api/tom/nf-tom-itextstory-getactive
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetActive(out int pValue);
    
    // https://learn.microsoft.com/windows/win32/api/tom/nf-tom-itextstory-setactive
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetActive(int Value);
    
    // https://learn.microsoft.com/windows/win32/api/tom/nf-tom-itextstory-getdisplay
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetDisplay([MarshalUsing(typeof(UniqueComInterfaceMarshaller<nint>))] out nint ppDisplay);
    
    // https://learn.microsoft.com/windows/win32/api/tom/nf-tom-itextstory-getindex
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetIndex(out int pValue);
    
    // https://learn.microsoft.com/windows/win32/api/tom/nf-tom-itextstory-gettype
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetType(out int pValue);
    
    // https://learn.microsoft.com/windows/win32/api/tom/nf-tom-itextstory-settype
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetType(int Value);
    
    // https://learn.microsoft.com/windows/win32/api/tom/nf-tom-itextstory-getproperty
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetProperty(int Type, out int pValue);
    
    // https://learn.microsoft.com/windows/win32/api/tom/nf-tom-itextstory-getrange
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetRange(int cpActive, int cpAnchor, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<ITextRange2>))] out ITextRange2 ppRange);
    
    // https://learn.microsoft.com/windows/win32/api/tom/nf-tom-itextstory-gettext
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetText(int Flags, out BSTR pbstr);
    
    // https://learn.microsoft.com/windows/win32/api/tom/nf-tom-itextstory-setformattedtext
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetFormattedText(nint pUnk);
    
    // https://learn.microsoft.com/windows/win32/api/tom/nf-tom-itextstory-setproperty
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetProperty(int Type, int Value);
    
    // https://learn.microsoft.com/windows/win32/api/tom/nf-tom-itextstory-settext
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetText(int Flags, BSTR bstr);
}
