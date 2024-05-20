namespace DirectN.Extensions.Utilities;

public static class MessageBox
{
    public static MESSAGEBOX_RESULT Show(string? text, string? caption = null, MESSAGEBOX_STYLE style = 0) => Show(HWND.Null, text, caption, style);
    public static MESSAGEBOX_RESULT Show(HWND hwnd, string? text, string? caption = null, MESSAGEBOX_STYLE style = 0)
    {
        using var ptext = new Pwstr(text);
        using var pcaption = new Pwstr(caption);
        return Functions.MessageBoxW(hwnd, ptext, pcaption, style);
    }
}
