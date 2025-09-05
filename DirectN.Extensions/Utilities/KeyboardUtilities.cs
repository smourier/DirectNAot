namespace DirectN.Extensions.Utilities;

public static class KeyboardUtilities
{
    public static bool IsShiftDown => Functions.GetKeyState((int)VIRTUAL_KEY.VK_SHIFT) < 0;
    public static bool IsControlDown => Functions.GetKeyState((int)VIRTUAL_KEY.VK_CONTROL) < 0;
    public static bool IsAltDown => Functions.GetKeyState((int)VIRTUAL_KEY.VK_MENU) < 0;

    public static KEYMODIFIERS GetKEYMODIFIERS()
    {
        KEYMODIFIERS km = 0;
        if (IsShiftDown)
        {
            km |= KEYMODIFIERS.KEYMOD_SHIFT;
        }

        if (IsControlDown)
        {
            km |= KEYMODIFIERS.KEYMOD_CONTROL;
        }

        if (IsAltDown)
        {
            km |= KEYMODIFIERS.KEYMOD_ALT;
        }
        return km;
    }
}
