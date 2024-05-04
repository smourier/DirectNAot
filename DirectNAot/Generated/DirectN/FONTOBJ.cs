#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/winddi/ns-winddi-fontobj
[StructLayout(LayoutKind.Sequential)]
public partial struct FONTOBJ
{
    public uint iUniq;
    public uint iFace;
    public uint cxMax;
    public uint flFontType;
    public nuint iTTUniq;
    public nuint iFile;
    public SIZE sizLogResPpi;
    public uint ulStyleSize;
    public nint pvConsumer;
    public nint pvProducer;
}
