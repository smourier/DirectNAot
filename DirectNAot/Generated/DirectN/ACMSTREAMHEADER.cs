namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/msacm/ns-msacm-acmstreamheader
[StructLayout(LayoutKind.Sequential)]
public partial struct ACMSTREAMHEADER
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
    public InlineArrayUInt3215 dwReservedDriver;
}
