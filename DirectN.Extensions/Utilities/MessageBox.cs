namespace DirectN.Extensions.Utilities;

public static class MessageBox
{
    public static MESSAGEBOX_RESULT Show(string? text, string? caption = null, MESSAGEBOX_STYLE style = 0) => Show(HWND.Null, text, caption, style);
    public static MESSAGEBOX_RESULT Show(HWND hwnd, string? text, string? caption = null, MESSAGEBOX_STYLE style = 0) => Functions.MessageBoxW(hwnd, PWSTR.From(text), PWSTR.From(caption), style);
}
