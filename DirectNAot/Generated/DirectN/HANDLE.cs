namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct HANDLE
{
    public static readonly HANDLE Null = new();
    
    public nint Value;
}
