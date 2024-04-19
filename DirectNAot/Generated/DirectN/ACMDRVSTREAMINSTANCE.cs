namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct ACMDRVSTREAMINSTANCE
{
    public uint cbStruct;
    public nint pwfxSrc;
    public nint pwfxDst;
    public nint pwfltr;
    public nuint dwCallback;
    public nuint dwInstance;
    public uint fdwOpen;
    public uint fdwDriver;
    public nuint dwDriver;
    public HACMSTREAM has;
}
