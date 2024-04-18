namespace DirectN;

// https://learn.microsoft.com/windows/win32/printdocs/printer-option-flags
public enum PRINTER_OPTION_FLAGS
{
    PRINTER_OPTION_NO_CACHE = 1,
    PRINTER_OPTION_CACHE = 2,
    PRINTER_OPTION_CLIENT_CHANGE = 4,
    PRINTER_OPTION_NO_CLIENT_DATA = 8,
}
