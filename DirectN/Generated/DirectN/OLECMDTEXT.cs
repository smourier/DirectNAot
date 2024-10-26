#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/docobj/ns-docobj-olecmdtext
public partial struct OLECMDTEXT
{
    public uint cmdtextf;
    public uint cwActual;
    public uint cwBuf;
    public InlineArraySystemChar_1 rgwz; // variable-length array placeholder
}
