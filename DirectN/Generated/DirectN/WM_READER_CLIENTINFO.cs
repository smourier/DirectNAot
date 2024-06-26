﻿#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wmsdkidl/ns-wmsdkidl-wm_reader_clientinfo
public partial struct WM_READER_CLIENTINFO
{
    public uint cbSize;
    public PWSTR wszLang;
    public PWSTR wszBrowserUserAgent;
    public PWSTR wszBrowserWebPage;
    public ulong qwReserved;
    public nint pReserved;
    public PWSTR wszHostExe;
    public ulong qwHostVersion;
    public PWSTR wszPlayerUserAgent;
}
