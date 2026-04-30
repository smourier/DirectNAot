#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/commdlg/ns-commdlg-choosecolorw
public partial struct CHOOSECOLORW
{
    public uint lStructSize;
    public HWND hwndOwner;
    public HWND hInstance;
    public COLORREF rgbResult;
    public nint lpCustColors;
    public CHOOSECOLOR_FLAGS Flags;
    public LPARAM lCustData;
    public nint lpfnHook;
    public PWSTR lpTemplateName;
}
