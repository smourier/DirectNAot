namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/ddrawint/ns-ddrawint-dd_clipper_local
[StructLayout(LayoutKind.Sequential)]
public partial struct DD_CLIPPER_LOCAL
{
    public static readonly DD_CLIPPER_LOCAL Null = new();
    
    public nuint dwReserved1;
}
