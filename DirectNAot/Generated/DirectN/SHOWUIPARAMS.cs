namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct SHOWUIPARAMS
{
    public UI_TYPE UIType;
    public MESSAGEBOX_PARAMS MessageBoxParams;
}
