#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/commctrl/ns-commctrl-taskdialogconfig
[StructLayout(LayoutKind.Sequential)]
public partial struct TASKDIALOGCONFIG
{
    [StructLayout(LayoutKind.Explicit)]
    public struct _Anonymous1_e__Union
    {
        [FieldOffset(0)]
        public HICON hMainIcon;
        
        [FieldOffset(0)]
        public PWSTR pszMainIcon;
    }
    
    [StructLayout(LayoutKind.Explicit)]
    public struct _Anonymous2_e__Union
    {
        [FieldOffset(0)]
        public HICON hFooterIcon;
        
        [FieldOffset(0)]
        public PWSTR pszFooterIcon;
    }
    
    public uint cbSize;
    public HWND hwndParent;
    public HINSTANCE hInstance;
    public TASKDIALOG_FLAGS dwFlags;
    public TASKDIALOG_COMMON_BUTTON_FLAGS dwCommonButtons;
    public PWSTR pszWindowTitle;
    public _Anonymous1_e__Union Anonymous1;
    public PWSTR pszMainInstruction;
    public PWSTR pszContent;
    public uint cButtons;
    public nint pButtons;
    public int nDefaultButton;
    public uint cRadioButtons;
    public nint pRadioButtons;
    public int nDefaultRadioButton;
    public PWSTR pszVerificationText;
    public PWSTR pszExpandedInformation;
    public PWSTR pszExpandedControlText;
    public PWSTR pszCollapsedControlText;
    public _Anonymous2_e__Union Anonymous2;
    public PWSTR pszFooter;
    public nint pfCallback;
    public nint lpCallbackData;
    public uint cxWidth;
}
