#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct MIXEROPENDESC
{
    public HMIXER hmx;
    public nint pReserved0;
    public nuint dwCallback;
    public nuint dwInstance;
    public nuint dnDevNode;
}
