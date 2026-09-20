namespace DirectN.Extensions.Utilities;

public static class MessageBox
{
    public static MESSAGEBOX_RESULT Show(string? text, string? caption = null, MESSAGEBOX_STYLE style = 0) => Show(HWND.Null, text, caption, style);

    public unsafe static MESSAGEBOX_RESULT Show(HWND hwnd, string? text, string? caption = null, MESSAGEBOX_STYLE style = 0)
    {
        fixed (char* pText = text)
        fixed (char* pCaption = caption)
        {
            return Functions.MessageBoxW(hwnd, new(pText), new(pCaption), style);
        }
    }
}
