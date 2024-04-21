namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct HMIXEROBJ
{
    public static readonly HMIXEROBJ Null = new();
    
    public nint Value;
}
