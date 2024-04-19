namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct MMIOINFO
{
    public uint dwFlags;
    public uint fccIOProc;
    public nint pIOProc;
    public uint wErrorRet;
    public HTASK htask;
    public int cchBuffer;
    public nint pchBuffer;
    public nint pchNext;
    public nint pchEndRead;
    public nint pchEndWrite;
    public int lBufOffset;
    public int lDiskOffset;
    public InlineArrayUInt323 adwInfo;
    public uint dwReserved1;
    public uint dwReserved2;
    public HMMIO hmmio;
}
