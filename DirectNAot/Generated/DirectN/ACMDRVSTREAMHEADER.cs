namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct ACMDRVSTREAMHEADER
{
    public uint cbStruct;
    public uint fdwStatus;
    public nuint dwUser;
    public nint pbSrc;
    public uint cbSrcLength;
    public uint cbSrcLengthUsed;
    public nuint dwSrcUser;
    public nint pbDst;
    public uint cbDstLength;
    public uint cbDstLengthUsed;
    public nuint dwDstUser;
    public uint fdwConvert;
    public nint padshNext;
    public uint fdwDriver;
    public nuint dwDriver;
    public uint fdwPrepared;
    public nuint dwPrepared;
    public nint pbPreparedSrc;
    public uint cbPreparedSrcLength;
    public nint pbPreparedDst;
    public uint cbPreparedDstLength;
}
