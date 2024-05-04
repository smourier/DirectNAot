#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct KSQUERYBUFFER
{
    public KSIDENTIFIER Event;
    public nint EventData;
    public nint Reserved;
}
