namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct EMFINFO
{
    public uint nSize;
    public HDC hdc;
    public nint pvEMF;
    public nint pvCurrentRecord;
}
