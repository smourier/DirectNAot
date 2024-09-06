#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/tom/nn-tom-itextdocument
[SupportedOSPlatform("windows6.0.6000")]
[GeneratedComInterface, Guid("8cc497c0-a1df-11ce-8098-00aa0047be5d")]
public partial interface ITextDocument : IDispatch
{
    // https://learn.microsoft.com/windows/win32/api/tom/nf-tom-itextdocument-getname
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetName(out BSTR pName);
    
    // https://learn.microsoft.com/windows/win32/api/tom/nf-tom-itextdocument-getselection
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetSelection([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ITextSelection>))] out ITextSelection ppSel);
    
    // https://learn.microsoft.com/windows/win32/api/tom/nf-tom-itextdocument-getstorycount
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetStoryCount(out int pCount);
    
    // https://learn.microsoft.com/windows/win32/api/tom/nf-tom-itextdocument-getstoryranges
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetStoryRanges([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ITextStoryRanges>))] out ITextStoryRanges ppStories);
    
    // https://learn.microsoft.com/windows/win32/api/tom/nf-tom-itextdocument-getsaved
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetSaved(out int pValue);
    
    // https://learn.microsoft.com/windows/win32/api/tom/nf-tom-itextdocument-setsaved
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetSaved(tomConstants Value);
    
    // https://learn.microsoft.com/windows/win32/api/tom/nf-tom-itextdocument-getdefaulttabstop
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetDefaultTabStop(out float pValue);
    
    // https://learn.microsoft.com/windows/win32/api/tom/nf-tom-itextdocument-setdefaulttabstop
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetDefaultTabStop(float Value);
    
    // https://learn.microsoft.com/windows/win32/api/tom/nf-tom-itextdocument-new
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT New();
    
    // https://learn.microsoft.com/windows/win32/api/tom/nf-tom-itextdocument-open
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Open(in VARIANT pVar, tomConstants Flags, int CodePage);
    
    // https://learn.microsoft.com/windows/win32/api/tom/nf-tom-itextdocument-save
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Save(in VARIANT pVar, tomConstants Flags, int CodePage);
    
    // https://learn.microsoft.com/windows/win32/api/tom/nf-tom-itextdocument-freeze
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Freeze(out int pCount);
    
    // https://learn.microsoft.com/windows/win32/api/tom/nf-tom-itextdocument-unfreeze
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Unfreeze(out int pCount);
    
    // https://learn.microsoft.com/windows/win32/api/tom/nf-tom-itextdocument-begineditcollection
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT BeginEditCollection();
    
    // https://learn.microsoft.com/windows/win32/api/tom/nf-tom-itextdocument-endeditcollection
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT EndEditCollection();
    
    // https://learn.microsoft.com/windows/win32/api/tom/nf-tom-itextdocument-undo
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Undo(int Count, out int pCount);
    
    // https://learn.microsoft.com/windows/win32/api/tom/nf-tom-itextdocument-redo
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Redo(int Count, out int pCount);
    
    // https://learn.microsoft.com/windows/win32/api/tom/nf-tom-itextdocument-range
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Range(int cpActive, int cpAnchor, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<ITextRange>))] out ITextRange ppRange);
    
    // https://learn.microsoft.com/windows/win32/api/tom/nf-tom-itextdocument-rangefrompoint
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT RangeFromPoint(int x, int y, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<ITextRange>))] out ITextRange ppRange);
}
