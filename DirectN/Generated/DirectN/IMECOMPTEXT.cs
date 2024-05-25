#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/richedit/ns-richedit-imecomptext
[StructLayout(LayoutKind.Sequential)]
public partial struct IMECOMPTEXT
{
    public int cb;
    public IMECOMPTEXT_FLAGS flags;
}
