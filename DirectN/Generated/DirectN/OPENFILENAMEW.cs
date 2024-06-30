#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/commdlg/ns-commdlg-openfilenamew
public partial struct OPENFILENAMEW
{
    public uint lStructSize;
    public HWND hwndOwner;
    public HINSTANCE hInstance;
    public PWSTR lpstrFilter;
    public PWSTR lpstrCustomFilter;
    public uint nMaxCustFilter;
    public uint nFilterIndex;
    public PWSTR lpstrFile;
    public uint nMaxFile;
    public PWSTR lpstrFileTitle;
    public uint nMaxFileTitle;
    public PWSTR lpstrInitialDir;
    public PWSTR lpstrTitle;
    public OPEN_FILENAME_FLAGS Flags;
    public ushort nFileOffset;
    public ushort nFileExtension;
    public PWSTR lpstrDefExt;
    public LPARAM lCustData;
    public nint lpfnHook;
    public PWSTR lpTemplateName;
    public nint pvReserved;
    public uint dwReserved;
    public OPEN_FILENAME_FLAGS_EX FlagsEx;
}
