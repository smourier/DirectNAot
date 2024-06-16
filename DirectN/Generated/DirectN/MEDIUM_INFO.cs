#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct MEDIUM_INFO
{
    public BOOL MediaPresent;
    public uint MediaType;
    public BOOL RecordInhibit;
}
