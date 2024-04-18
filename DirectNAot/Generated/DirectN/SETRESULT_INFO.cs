namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct SETRESULT_INFO
{
    public ushort cbSize;
    public ushort wReserved;
    public HANDLE hSetResult;
    public LRESULT Result;
}
