namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct HMETAFILE
{
    public static readonly HMETAFILE Null = new();
    
    public nint Value;
}
