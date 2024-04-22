namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct HPTPROVIDER
{
    public static readonly HPTPROVIDER Null = new();
    
    public nint Value;
}
