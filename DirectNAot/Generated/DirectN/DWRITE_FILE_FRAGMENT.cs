namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dwrite_3/ns-dwrite_3-dwrite_file_fragment
[StructLayout(LayoutKind.Sequential)]
public partial struct DWRITE_FILE_FRAGMENT
{
    public ulong fileOffset;
    public ulong fragmentSize;
}
