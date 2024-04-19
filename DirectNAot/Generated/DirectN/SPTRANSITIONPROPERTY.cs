namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct SPTRANSITIONPROPERTY
{
    public PWSTR pszName;
    public uint ulId;
    public PWSTR pszValue;
    public VARIANT vValue;
}
