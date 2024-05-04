#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/commdlg/ns-commdlg-openfilenamea
[StructLayout(LayoutKind.Sequential)]
public partial struct OPENFILENAMEA
{
    public uint lStructSize;
    public HWND hwndOwner;
    public HINSTANCE hInstance;
    public PSTR lpstrFilter;
    public PSTR lpstrCustomFilter;
    public uint nMaxCustFilter;
    public uint nFilterIndex;
    public PSTR lpstrFile;
    public uint nMaxFile;
    public PSTR lpstrFileTitle;
    public uint nMaxFileTitle;
    public PSTR lpstrInitialDir;
    public PSTR lpstrTitle;
    public OPEN_FILENAME_FLAGS Flags;
    public ushort nFileOffset;
    public ushort nFileExtension;
    public PSTR lpstrDefExt;
    public LPARAM lCustData;
    public nint lpfnHook;
    public PSTR lpTemplateName;
    public nint pvReserved;
    public uint dwReserved;
    public OPEN_FILENAME_FLAGS_EX FlagsEx;
}
