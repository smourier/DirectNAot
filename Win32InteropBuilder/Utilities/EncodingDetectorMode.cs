using System.ComponentModel;

namespace Win32InteropBuilder.Utilities
{
    public enum EncodingDetectorMode
    {
        [Description("Auto detect")]
        AutoDetect,

        [Description("Use UTF-8 as default")]
        UseUTF8AsDefault,

        [Description("Use ANSI as default")]
        UseAnsiAsDefault,
    }
}
