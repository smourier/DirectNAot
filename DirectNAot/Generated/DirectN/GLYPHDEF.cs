namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/winddi/ns-winddi-glyphdef
[StructLayout(LayoutKind.Explicit)]
public partial struct GLYPHDEF
{
    [FieldOffset(0)]
    public nint pgb;
    
    [FieldOffset(0)]
    public nint ppo;
}
