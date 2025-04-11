#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/shlobj_core/ns-shlobj_core-filedescriptorw
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct FILEDESCRIPTORW
{
    public uint dwFlags;
    public Guid clsid;
    public SIZE sizel;
    public POINTL pointl;
    public uint dwFileAttributes;
    public FILETIME ftCreationTime;
    public FILETIME ftLastAccessTime;
    public FILETIME ftLastWriteTime;
    public uint nFileSizeHigh;
    public uint nFileSizeLow;
    public InlineArraySystemChar_260 cFileName;
}
