namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct HENHMETAFILE
{
    public static readonly HENHMETAFILE Null = new();
    
    public nint Value;
}
