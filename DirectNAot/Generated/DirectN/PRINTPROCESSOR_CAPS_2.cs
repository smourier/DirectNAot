namespace DirectN;

// https://learn.microsoft.com/windows/win32/printdocs/printprocessor-caps-2
[StructLayout(LayoutKind.Sequential)]
public partial struct PRINTPROCESSOR_CAPS_2
{
    public uint dwLevel;
    public uint dwNupOptions;
    public uint dwPageOrderFlags;
    public uint dwNumberOfCopies;
    public uint dwDuplexHandlingCaps;
    public uint dwNupDirectionCaps;
    public uint dwNupBorderCaps;
    public uint dwBookletHandlingCaps;
    public uint dwScalingCaps;
}
