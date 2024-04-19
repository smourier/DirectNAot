namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct SPPROPERTYINFO
{
    public PWSTR pszName;
    public uint ulId;
    public PWSTR pszValue;
    public VARIANT vValue;
}
