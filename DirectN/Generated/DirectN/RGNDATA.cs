#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wingdi/ns-wingdi-rgndata
public partial struct RGNDATA
{
    public RGNDATAHEADER rdh;
    public InlineArrayFoundationCHAR_1 Buffer; // variable-length array placeholder
}
