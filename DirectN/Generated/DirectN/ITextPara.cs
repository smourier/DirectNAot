#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/tom/nn-tom-itextpara
[SupportedOSPlatform("windows6.0.6000")]
[GeneratedComInterface, Guid("8cc497c4-a1df-11ce-8098-00aa0047be5d")]
public partial interface ITextPara : IDispatch
{
    // https://learn.microsoft.com/windows/win32/api/tom/nf-tom-itextpara-getduplicate
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetDuplicate([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ITextPara>))] out ITextPara ppPara);
    
    // https://learn.microsoft.com/windows/win32/api/tom/nf-tom-itextpara-setduplicate
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetDuplicate(ITextPara? pPara);
    
    // https://learn.microsoft.com/windows/win32/api/tom/nf-tom-itextpara-canchange
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CanChange(out int pValue);
    
    // https://learn.microsoft.com/windows/win32/api/tom/nf-tom-itextpara-isequal
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT IsEqual(ITextPara? pPara, out int pValue);
    
    // https://learn.microsoft.com/windows/win32/api/tom/nf-tom-itextpara-reset
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Reset(int Value);
    
    // https://learn.microsoft.com/windows/win32/api/tom/nf-tom-itextpara-getstyle
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetStyle(out int pValue);
    
    // https://learn.microsoft.com/windows/win32/api/tom/nf-tom-itextpara-setstyle
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetStyle(int Value);
    
    // https://learn.microsoft.com/windows/win32/api/tom/nf-tom-itextpara-getalignment
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetAlignment(out int pValue);
    
    // https://learn.microsoft.com/windows/win32/api/tom/nf-tom-itextpara-setalignment
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetAlignment(int Value);
    
    // https://learn.microsoft.com/windows/win32/api/tom/nf-tom-itextpara-gethyphenation
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetHyphenation(out tomConstants pValue);
    
    // https://learn.microsoft.com/windows/win32/api/tom/nf-tom-itextpara-sethyphenation
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetHyphenation(int Value);
    
    // https://learn.microsoft.com/windows/win32/api/tom/nf-tom-itextpara-getfirstlineindent
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetFirstLineIndent(out float pValue);
    
    // https://learn.microsoft.com/windows/win32/api/tom/nf-tom-itextpara-getkeeptogether
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetKeepTogether(out tomConstants pValue);
    
    // https://learn.microsoft.com/windows/win32/api/tom/nf-tom-itextpara-setkeeptogether
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetKeepTogether(int Value);
    
    // https://learn.microsoft.com/windows/win32/api/tom/nf-tom-itextpara-getkeepwithnext
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetKeepWithNext(out tomConstants pValue);
    
    // https://learn.microsoft.com/windows/win32/api/tom/nf-tom-itextpara-setkeepwithnext
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetKeepWithNext(int Value);
    
    // https://learn.microsoft.com/windows/win32/api/tom/nf-tom-itextpara-getleftindent
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetLeftIndent(out float pValue);
    
    // https://learn.microsoft.com/windows/win32/api/tom/nf-tom-itextpara-getlinespacing
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetLineSpacing(out float pValue);
    
    // https://learn.microsoft.com/windows/win32/api/tom/nf-tom-itextpara-getlinespacingrule
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetLineSpacingRule(out int pValue);
    
    // https://learn.microsoft.com/windows/win32/api/tom/nf-tom-itextpara-getlistalignment
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetListAlignment(out int pValue);
    
    // https://learn.microsoft.com/windows/win32/api/tom/nf-tom-itextpara-setlistalignment
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetListAlignment(int Value);
    
    // https://learn.microsoft.com/windows/win32/api/tom/nf-tom-itextpara-getlistlevelindex
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetListLevelIndex(out int pValue);
    
    // https://learn.microsoft.com/windows/win32/api/tom/nf-tom-itextpara-setlistlevelindex
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetListLevelIndex(int Value);
    
    // https://learn.microsoft.com/windows/win32/api/tom/nf-tom-itextpara-getliststart
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetListStart(out int pValue);
    
    // https://learn.microsoft.com/windows/win32/api/tom/nf-tom-itextpara-setliststart
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetListStart(int Value);
    
    // https://learn.microsoft.com/windows/win32/api/tom/nf-tom-itextpara-getlisttab
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetListTab(out float pValue);
    
    // https://learn.microsoft.com/windows/win32/api/tom/nf-tom-itextpara-setlisttab
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetListTab(float Value);
    
    // https://learn.microsoft.com/windows/win32/api/tom/nf-tom-itextpara-getlisttype
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetListType(out int pValue);
    
    // https://learn.microsoft.com/windows/win32/api/tom/nf-tom-itextpara-setlisttype
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetListType(int Value);
    
    // https://learn.microsoft.com/windows/win32/api/tom/nf-tom-itextpara-getnolinenumber
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetNoLineNumber(out int pValue);
    
    // https://learn.microsoft.com/windows/win32/api/tom/nf-tom-itextpara-setnolinenumber
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetNoLineNumber(int Value);
    
    // https://learn.microsoft.com/windows/win32/api/tom/nf-tom-itextpara-getpagebreakbefore
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetPageBreakBefore(out int pValue);
    
    // https://learn.microsoft.com/windows/win32/api/tom/nf-tom-itextpara-setpagebreakbefore
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetPageBreakBefore(int Value);
    
    // https://learn.microsoft.com/windows/win32/api/tom/nf-tom-itextpara-getrightindent
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetRightIndent(out float pValue);
    
    // https://learn.microsoft.com/windows/win32/api/tom/nf-tom-itextpara-setrightindent
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetRightIndent(float Value);
    
    // https://learn.microsoft.com/windows/win32/api/tom/nf-tom-itextpara-setindents
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetIndents(float First, float Left, float Right);
    
    // https://learn.microsoft.com/windows/win32/api/tom/nf-tom-itextpara-setlinespacing
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetLineSpacing(int Rule, float Spacing);
    
    // https://learn.microsoft.com/windows/win32/api/tom/nf-tom-itextpara-getspaceafter
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetSpaceAfter(out float pValue);
    
    // https://learn.microsoft.com/windows/win32/api/tom/nf-tom-itextpara-setspaceafter
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetSpaceAfter(float Value);
    
    // https://learn.microsoft.com/windows/win32/api/tom/nf-tom-itextpara-getspacebefore
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetSpaceBefore(out float pValue);
    
    // https://learn.microsoft.com/windows/win32/api/tom/nf-tom-itextpara-setspacebefore
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetSpaceBefore(float Value);
    
    // https://learn.microsoft.com/windows/win32/api/tom/nf-tom-itextpara-getwidowcontrol
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetWidowControl(out int pValue);
    
    // https://learn.microsoft.com/windows/win32/api/tom/nf-tom-itextpara-setwidowcontrol
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetWidowControl(int Value);
    
    // https://learn.microsoft.com/windows/win32/api/tom/nf-tom-itextpara-gettabcount
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetTabCount(out int pCount);
    
    // https://learn.microsoft.com/windows/win32/api/tom/nf-tom-itextpara-addtab
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT AddTab(float tbPos, int tbAlign, int tbLeader);
    
    // https://learn.microsoft.com/windows/win32/api/tom/nf-tom-itextpara-clearalltabs
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT ClearAllTabs();
    
    // https://learn.microsoft.com/windows/win32/api/tom/nf-tom-itextpara-deletetab
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT DeleteTab(float tbPos);
    
    // https://learn.microsoft.com/windows/win32/api/tom/nf-tom-itextpara-gettab
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetTab(int iTab, out float ptbPos, out int ptbAlign, out int ptbLeader);
}
