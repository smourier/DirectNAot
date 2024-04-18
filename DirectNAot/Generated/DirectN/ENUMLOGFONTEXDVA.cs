namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wingdi/ns-wingdi-enumlogfontexdva
[StructLayout(LayoutKind.Sequential)]
public partial struct ENUMLOGFONTEXDVA
{
    public ENUMLOGFONTEXA elfEnumLogfontEx;
    public DESIGNVECTOR elfDesignVector;
}
