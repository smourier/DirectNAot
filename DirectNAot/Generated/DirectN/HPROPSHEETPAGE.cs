namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct HPROPSHEETPAGE
{
    public static readonly HPROPSHEETPAGE Null = new();
    
    public nint Value;
}
