namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct DDVERSIONDATA
{
    public uint dwHALVersion;
    public nuint dwReserved1;
    public nuint dwReserved2;
}
