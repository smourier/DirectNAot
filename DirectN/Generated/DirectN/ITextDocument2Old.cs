#nullable enable
namespace DirectN;

[GeneratedComInterface, Guid("01c25500-4268-11d1-883a-3c8b00c10000")]
public partial interface ITextDocument2Old : ITextDocument
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT AttachMsgFilter(nint pFilter);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetEffectColor(int Index, COLORREF cr);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetEffectColor(int Index, out COLORREF pcr);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetCaretType(out int pCaretType);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetCaretType(int CaretType);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetImmContext(out long pContext);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT ReleaseImmContext(long Context);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetPreferredFont(int cp, int CharRep, int Option, int CharRepCur, int curFontSize, out BSTR pbstr, out int pPitchAndFamily, out int pNewFontSize);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetNotificationMode(out int pMode);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetNotificationMode(int Mode);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetClientRect(int Type, out int pLeft, out int pTop, out int pRight, out int pBottom);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetSelection2([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ITextSelection>))] out ITextSelection ppSel);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetWindow(out int phWnd);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetFEFlags(out int pFlags);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT UpdateWindow();
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CheckTextLimit(int cch, in int pcch);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT IMEInProgress(int Value);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SysBeep();
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Update(int Mode);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Notify(int Notify);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetDocumentFont([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ITextFont>))] out ITextFont ppITextFont);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetDocumentPara([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ITextPara>))] out ITextPara ppITextPara);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetCallManager(out nint ppVoid);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT ReleaseCallManager(nint pVoid);
}
