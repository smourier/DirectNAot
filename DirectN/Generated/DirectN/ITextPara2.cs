#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/tom/nn-tom-itextpara2
[SupportedOSPlatform("windows8.0")]
[GeneratedComInterface, Guid("c241f5e4-7206-11d8-a2c7-00a0d1d6c6b3")]
public partial interface ITextPara2 : ITextPara
{
    // https://learn.microsoft.com/windows/win32/api/tom/nf-tom-itextpara2-getborders
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetBorders(out nint ppBorders);
    
    // https://learn.microsoft.com/windows/win32/api/tom/nf-tom-itextpara2-getduplicate2
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetDuplicate2([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ITextPara2>))] out ITextPara2 ppPara);
    
    // https://learn.microsoft.com/windows/win32/api/tom/nf-tom-itextpara2-setduplicate2
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetDuplicate2(ITextPara2? pPara);
    
    // https://learn.microsoft.com/windows/win32/api/tom/nf-tom-itextpara2-getfontalignment
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetFontAlignment(out int pValue);
    
    // https://learn.microsoft.com/windows/win32/api/tom/nf-tom-itextpara2-setfontalignment
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetFontAlignment(int Value);
    
    // https://learn.microsoft.com/windows/win32/api/tom/nf-tom-itextpara2-gethangingpunctuation
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetHangingPunctuation(out int pValue);
    
    // https://learn.microsoft.com/windows/win32/api/tom/nf-tom-itextpara2-sethangingpunctuation
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetHangingPunctuation(int Value);
    
    // https://learn.microsoft.com/windows/win32/api/tom/nf-tom-itextpara2-getsnaptogrid
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetSnapToGrid(out int pValue);
    
    // https://learn.microsoft.com/windows/win32/api/tom/nf-tom-itextpara2-setsnaptogrid
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetSnapToGrid(int Value);
    
    // https://learn.microsoft.com/windows/win32/api/tom/nf-tom-itextpara2-gettrimpunctuationatstart
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetTrimPunctuationAtStart(out int pValue);
    
    // https://learn.microsoft.com/windows/win32/api/tom/nf-tom-itextpara2-settrimpunctuationatstart
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetTrimPunctuationAtStart(int Value);
    
    // https://learn.microsoft.com/windows/win32/api/tom/nf-tom-itextpara2-geteffects
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetEffects(out int pValue, out int pMask);
    
    // https://learn.microsoft.com/windows/win32/api/tom/nf-tom-itextpara2-getproperty
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetProperty(int Type, out int pValue);
    
    // https://learn.microsoft.com/windows/win32/api/tom/nf-tom-itextpara2-isequal2
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT IsEqual2(ITextPara2? pPara, out int pB);
    
    // https://learn.microsoft.com/windows/win32/api/tom/nf-tom-itextpara2-seteffects
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetEffects(int Value, int Mask);
    
    // https://learn.microsoft.com/windows/win32/api/tom/nf-tom-itextpara2-setproperty
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetProperty(int Type, int Value);
}
