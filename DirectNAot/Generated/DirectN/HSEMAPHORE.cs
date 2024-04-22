namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct HSEMAPHORE
{
    public static readonly HSEMAPHORE Null = new();
    
    public nint Value;
}
