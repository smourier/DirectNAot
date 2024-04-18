namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct MONITORREG
{
    public uint cbSize;
    public nint fpCreateKey;
    public nint fpOpenKey;
    public nint fpCloseKey;
    public nint fpDeleteKey;
    public nint fpEnumKey;
    public nint fpQueryInfoKey;
    public nint fpSetValue;
    public nint fpDeleteValue;
    public nint fpEnumValue;
    public nint fpQueryValue;
}
