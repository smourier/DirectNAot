#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/tom/nn-tom-itextdocument2
[SupportedOSPlatform("windows8.0")]
[GeneratedComInterface, Guid("c241f5e0-7206-11d8-a2c7-00a0d1d6c6b3")]
public partial interface ITextDocument2 : ITextDocument
{
    // https://learn.microsoft.com/windows/win32/api/tom/nf-tom-itextdocument2-getcarettype
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetCaretType(out int pValue);
    
    // https://learn.microsoft.com/windows/win32/api/tom/nf-tom-itextdocument2-setcarettype
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetCaretType(int Value);
    
    // https://learn.microsoft.com/windows/win32/api/tom/nf-tom-itextdocument2-getdisplays
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetDisplays([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ITextDisplays>))] out ITextDisplays ppDisplays);
    
    // https://learn.microsoft.com/windows/win32/api/tom/nf-tom-itextdocument2-getdocumentfont
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetDocumentFont([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ITextFont2>))] out ITextFont2 ppFont);
    
    // https://learn.microsoft.com/windows/win32/api/tom/nf-tom-itextdocument2-setdocumentfont
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetDocumentFont(ITextFont2? pFont);
    
    // https://learn.microsoft.com/windows/win32/api/tom/nf-tom-itextdocument2-getdocumentpara
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetDocumentPara([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ITextPara2>))] out ITextPara2 ppPara);
    
    // https://learn.microsoft.com/windows/win32/api/tom/nf-tom-itextdocument2-setdocumentpara
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetDocumentPara(ITextPara2? pPara);
    
    // https://learn.microsoft.com/windows/win32/api/tom/nf-tom-itextdocument2-geteastasianflags
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetEastAsianFlags(out tomConstants pFlags);
    
    // https://learn.microsoft.com/windows/win32/api/tom/nf-tom-itextdocument2-getgenerator
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetGenerator(out BSTR pbstr);
    
    // https://learn.microsoft.com/windows/win32/api/tom/nf-tom-itextdocument2-setimeinprogress
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetIMEInProgress(int Value);
    
    // https://learn.microsoft.com/windows/win32/api/tom/nf-tom-itextdocument2-getnotificationmode
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetNotificationMode(out int pValue);
    
    // https://learn.microsoft.com/windows/win32/api/tom/nf-tom-itextdocument2-setnotificationmode
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetNotificationMode(int Value);
    
    // https://learn.microsoft.com/windows/win32/api/tom/nf-tom-itextdocument2-getselection2
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetSelection2([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ITextSelection2>))] out ITextSelection2 ppSel);
    
    // https://learn.microsoft.com/windows/win32/api/tom/nf-tom-itextdocument2-getstoryranges2
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetStoryRanges2([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ITextStoryRanges2>))] out ITextStoryRanges2 ppStories);
    
    // https://learn.microsoft.com/windows/win32/api/tom/nf-tom-itextdocument2-gettypographyoptions
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetTypographyOptions(out int pOptions);
    
    // https://learn.microsoft.com/windows/win32/api/tom/nf-tom-itextdocument2-getversion
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetVersion(out int pValue);
    
    // https://learn.microsoft.com/windows/win32/api/tom/nf-tom-itextdocument2-getwindow
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetWindow(out long pHwnd);
    
    // https://learn.microsoft.com/windows/win32/api/tom/nf-tom-itextdocument2-attachmsgfilter
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT AttachMsgFilter(nint pFilter);
    
    // https://learn.microsoft.com/windows/win32/api/tom/nf-tom-itextdocument2-checktextlimit
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CheckTextLimit(int cch, in int pcch);
    
    // https://learn.microsoft.com/windows/win32/api/tom/nf-tom-itextdocument2-getcallmanager
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetCallManager([MarshalUsing(typeof(UniqueComInterfaceMarshaller<nint>))] out nint ppVoid);
    
    // https://learn.microsoft.com/windows/win32/api/tom/nf-tom-itextdocument2-getclientrect
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetClientRect(tomConstants Type, out int pLeft, out int pTop, out int pRight, out int pBottom);
    
    // https://learn.microsoft.com/windows/win32/api/tom/nf-tom-itextdocument2-geteffectcolor
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetEffectColor(int Index, out int pValue);
    
    // https://learn.microsoft.com/windows/win32/api/tom/nf-tom-itextdocument2-getimmcontext
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetImmContext(out long pContext);
    
    // https://learn.microsoft.com/windows/win32/api/tom/nf-tom-itextdocument2-getpreferredfont
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetPreferredFont(int cp, int CharRep, int Options, int curCharRep, int curFontSize, out BSTR pbstr, out int pPitchAndFamily, out int pNewFontSize);
    
    // https://learn.microsoft.com/windows/win32/api/tom/nf-tom-itextdocument2-getproperty
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetProperty(int Type, out int pValue);
    
    // https://learn.microsoft.com/windows/win32/api/tom/nf-tom-itextdocument2-getstrings
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetStrings([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ITextStrings>))] out ITextStrings ppStrs);
    
    // https://learn.microsoft.com/windows/win32/api/tom/nf-tom-itextdocument2-notify
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Notify(int Notify);
    
    // https://learn.microsoft.com/windows/win32/api/tom/nf-tom-itextdocument2-range2
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Range2(int cpActive, int cpAnchor, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<ITextRange2>))] out ITextRange2 ppRange);
    
    // https://learn.microsoft.com/windows/win32/api/tom/nf-tom-itextdocument2-rangefrompoint2
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT RangeFromPoint2(int x, int y, int Type, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<ITextRange2>))] out ITextRange2 ppRange);
    
    // https://learn.microsoft.com/windows/win32/api/tom/nf-tom-itextdocument2-releasecallmanager
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT ReleaseCallManager(nint pVoid);
    
    // https://learn.microsoft.com/windows/win32/api/tom/nf-tom-itextdocument2-releaseimmcontext
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT ReleaseImmContext(long Context);
    
    // https://learn.microsoft.com/windows/win32/api/tom/nf-tom-itextdocument2-seteffectcolor
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetEffectColor(int Index, int Value);
    
    // https://learn.microsoft.com/windows/win32/api/tom/nf-tom-itextdocument2-setproperty
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetProperty(int Type, int Value);
    
    // https://learn.microsoft.com/windows/win32/api/tom/nf-tom-itextdocument2-settypographyoptions
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetTypographyOptions(int Options, int Mask);
    
    // https://learn.microsoft.com/windows/win32/api/tom/nf-tom-itextdocument2-sysbeep
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SysBeep();
    
    // https://learn.microsoft.com/windows/win32/api/tom/nf-tom-itextdocument2-update
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Update(int Value);
    
    // https://learn.microsoft.com/windows/win32/api/tom/nf-tom-itextdocument2-updatewindow
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT UpdateWindow();
    
    // https://learn.microsoft.com/windows/win32/api/tom/nf-tom-itextdocument2-getmathproperties
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetMathProperties(out int pOptions);
    
    // https://learn.microsoft.com/windows/win32/api/tom/nf-tom-itextdocument2-setmathproperties
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetMathProperties(int Options, int Mask);
    
    // https://learn.microsoft.com/windows/win32/api/tom/nf-tom-itextdocument2-getactivestory
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetActiveStory([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ITextStory>))] out ITextStory ppStory);
    
    // https://learn.microsoft.com/windows/win32/api/tom/nf-tom-itextdocument2-setactivestory
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetActiveStory(ITextStory? pStory);
    
    // https://learn.microsoft.com/windows/win32/api/tom/nf-tom-itextdocument2-getmainstory
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetMainStory([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ITextStory>))] out ITextStory ppStory);
    
    // https://learn.microsoft.com/windows/win32/api/tom/nf-tom-itextdocument2-getnewstory
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetNewStory([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ITextStory>))] out ITextStory ppStory);
    
    // https://learn.microsoft.com/windows/win32/api/tom/nf-tom-itextdocument2-getstory
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetStory(int Index, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<ITextStory>))] out ITextStory ppStory);
}
