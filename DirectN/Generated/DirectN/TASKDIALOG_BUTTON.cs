#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/commctrl/ns-commctrl-taskdialog_button
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct TASKDIALOG_BUTTON
{
    public int nButtonID;
    public PWSTR pszButtonText;
}
