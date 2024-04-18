namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wingdi/ns-wingdi-handletable
[StructLayout(LayoutKind.Sequential)]
public partial struct HANDLETABLE
{
    public InlineArrayHGDIOBJ1 objectHandle; // variable-length array placeholder
}
