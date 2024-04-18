namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wingdi/ns-wingdi-emrtext
[StructLayout(LayoutKind.Sequential)]
public partial struct EMRTEXT
{
    public POINTL ptlReference;
    public uint nChars;
    public uint offString;
    public uint fOptions;
    public RECTL rcl;
    public uint offDx;
}
