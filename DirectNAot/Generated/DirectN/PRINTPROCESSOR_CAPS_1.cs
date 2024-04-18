namespace DirectN;

// https://learn.microsoft.com/windows/win32/printdocs/printprocessor-caps-1
[StructLayout(LayoutKind.Sequential)]
public partial struct PRINTPROCESSOR_CAPS_1
{
    public uint dwLevel;
    public uint dwNupOptions;
    public uint dwPageOrderFlags;
    public uint dwNumberOfCopies;
}
