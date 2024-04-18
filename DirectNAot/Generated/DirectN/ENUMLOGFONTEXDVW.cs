namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wingdi/ns-wingdi-enumlogfontexdvw
[StructLayout(LayoutKind.Sequential)]
public partial struct ENUMLOGFONTEXDVW
{
    public ENUMLOGFONTEXW elfEnumLogfontEx;
    public DESIGNVECTOR elfDesignVector;
}
