#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/richedit/ns-richedit-richedit_image_parameters
[StructLayout(LayoutKind.Sequential, Pack = 4)]
public partial struct RICHEDIT_IMAGE_PARAMETERS
{
    public int xWidth;
    public int yHeight;
    public int Ascent;
    public int Type;
    public PWSTR pwszAlternateText;
    public nint pIStream;
}
