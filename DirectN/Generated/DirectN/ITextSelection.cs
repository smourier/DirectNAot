#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/tom/nn-tom-itextselection
[SupportedOSPlatform("windows6.0.6000")]
[GeneratedComInterface, Guid("8cc497c1-a1df-11ce-8098-00aa0047be5d")]
public partial interface ITextSelection : ITextRange
{
    // https://learn.microsoft.com/windows/win32/api/tom/nf-tom-itextselection-getflags
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetFlags(out int pFlags);
    
    // https://learn.microsoft.com/windows/win32/api/tom/nf-tom-itextselection-setflags
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetFlags(int Flags);
    
    // https://learn.microsoft.com/windows/win32/api/tom/nf-tom-itextselection-gettype
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetType(out int pType);
    
    // https://learn.microsoft.com/windows/win32/api/tom/nf-tom-itextselection-moveleft
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT MoveLeft(int Unit, int Count, int Extend, out int pDelta);
    
    // https://learn.microsoft.com/windows/win32/api/tom/nf-tom-itextselection-moveright
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT MoveRight(int Unit, int Count, int Extend, out int pDelta);
    
    // https://learn.microsoft.com/windows/win32/api/tom/nf-tom-itextselection-moveup
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT MoveUp(int Unit, int Count, int Extend, out int pDelta);
    
    // https://learn.microsoft.com/windows/win32/api/tom/nf-tom-itextselection-movedown
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT MoveDown(int Unit, int Count, int Extend, out int pDelta);
    
    // https://learn.microsoft.com/windows/win32/api/tom/nf-tom-itextselection-homekey
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT HomeKey(tomConstants Unit, int Extend, out int pDelta);
    
    // https://learn.microsoft.com/windows/win32/api/tom/nf-tom-itextselection-endkey
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT EndKey(int Unit, int Extend, out int pDelta);
    
    // https://learn.microsoft.com/windows/win32/api/tom/nf-tom-itextselection-typetext
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT TypeText(BSTR bstr);
}
