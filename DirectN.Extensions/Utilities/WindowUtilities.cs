namespace DirectN.Utilities
{
    public static class WindowUtilities
    {
        public static uint GetPointerId(this WPARAM wParam) => wParam.Value.LOWORD();
        public static POINTER_MESSAGE_FLAGS GetPointerFlags(this WPARAM wParam) => (POINTER_MESSAGE_FLAGS)wParam.Value.HIWORD();
        public static int GetWheelDelta(this WPARAM wParam) => (int)wParam.Value.HIWORD();

        [SupportedOSPlatform("windows8.0")]
        public static POINTER_INPUT_TYPE GetPointerType(uint id)
        {
            Functions.GetPointerType(id, out var type);
            return type;
        }

        [SupportedOSPlatform("windows8.0")]
        public static POINTER_INFO GetPointerInfo(uint id)
        {
            Functions.GetPointerInfo(id, out var info);
            return info;
        }

        [SupportedOSPlatform("windows8.0")]
        public static POINTER_TOUCH_INFO GetPointerTouchInfo(uint id)
        {
            Functions.GetPointerTouchInfo(id, out var info);
            return info;
        }

        [SupportedOSPlatform("windows8.0")]
        public static POINTER_PEN_INFO GetPointerPenInfo(uint id)
        {
            Functions.GetPointerPenInfo(id, out var info);
            return info;
        }
    }
}
