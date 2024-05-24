namespace DirectN.Extensions.Utilities;

[SupportedOSPlatform("windows6.0.6000")]
public class TaskDialog
{
    public static readonly nint TD_WARNING_ICON = new(unchecked((ushort)-1));
    public static readonly nint TD_ERROR_ICON = new(unchecked((ushort)-2));
    public static readonly nint TD_INFORMATION_ICON = new(unchecked((ushort)-3));
    public static readonly nint TD_SHIELD_ICON = new(unchecked((ushort)-4));

    public virtual TASKDIALOG_FLAGS Flags { get; set; }
    public virtual TASKDIALOG_COMMON_BUTTON_FLAGS CommonButtonFlags { get; set; }
    public virtual string? Title { get; set; }
    public virtual string? MainInstruction { get; set; }
    public virtual string? Content { get; set; }
    public virtual string? VerificationText { get; set; }
    public virtual string? ExpandedInformation { get; set; }
    public virtual string? CollapsedControlText { get; set; }
    public virtual string? Footer { get; set; }
    public virtual HICON MainIcon { get; set; }
    public virtual HICON FooterIcon { get; set; }
    public virtual uint Width { get; set; }

    public unsafe virtual MESSAGEBOX_RESULT Show(HWND hwnd)
    {
        var config = new TASKDIALOGCONFIG
        {
            cbSize = (uint)sizeof(TASKDIALOGCONFIG),
            hwndParent = hwnd,
            dwFlags = Flags,
            dwCommonButtons = CommonButtonFlags,
            pszWindowTitle = PWSTR.From(Title),
            pszMainInstruction = PWSTR.From(MainInstruction),
            pszContent = PWSTR.From(Content),
            pszVerificationText = PWSTR.From(VerificationText),
            pszExpandedControlText = PWSTR.From(ExpandedInformation),
            pszCollapsedControlText = PWSTR.From(CollapsedControlText),
            pszFooter = PWSTR.From(Footer),
            cxWidth = Width
        };

        config.Anonymous1.hMainIcon = MainIcon;
        config.Anonymous2.hFooterIcon = FooterIcon;
        try
        {
            int button = 0;
            int radioButton = 0;
            int verificationFlagChecked = 0;
            Functions.TaskDialogIndirect(config, (nint)(&button), (nint)(&radioButton), (nint)(&verificationFlagChecked)).ThrowOnError();
            ResultButton = button;
            ResultRadioButton = radioButton;
            ResultVerificationFlagChecked = verificationFlagChecked != 0;
            return (MESSAGEBOX_RESULT)button;
        }
        catch (EntryPointNotFoundException ex)
        {
            MessageBox.Show(hwnd, ex.GetInterestingExceptionMessage() + Environment.NewLine + Environment.NewLine + "Make sure the application's main executable has a manifest that enables visual styles.", "Task Dialog Fatal Error", MESSAGEBOX_STYLE.MB_ICONSTOP);
            return MESSAGEBOX_RESULT.IDABORT;
        }
        catch (Exception e)
        {
            MessageBox.Show(hwnd, e.GetInterestingExceptionMessage(), "Task Dialog Fatal Error", MESSAGEBOX_STYLE.MB_ICONSTOP);
            return MESSAGEBOX_RESULT.IDABORT;
        }
    }

    public int ResultButton { get; private set; }
    public int ResultRadioButton { get; private set; }
    public bool ResultVerificationFlagChecked { get; private set; }
}
