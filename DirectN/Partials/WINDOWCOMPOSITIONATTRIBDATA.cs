namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public struct WINDOWCOMPOSITIONATTRIBDATA
{
    public WINDOWCOMPOSITIONATTRIB dwAttrib;
    public nint pvData;
    public nint cbData;
}
