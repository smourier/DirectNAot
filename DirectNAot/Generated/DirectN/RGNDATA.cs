namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wingdi/ns-wingdi-rgndata
[StructLayout(LayoutKind.Sequential)]
public partial struct RGNDATA
{
    public RGNDATAHEADER rdh;
    public InlineArrayCHAR1 Buffer; // variable-length array placeholder
}
