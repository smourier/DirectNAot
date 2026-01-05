#nullable enable
namespace DirectN;

public static partial class Functions
{
    // https://learn.microsoft.com/windows/win32/api/wingdi/nf-wingdi-abortdoc
    [LibraryImport("GDI32")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    public static partial int AbortDoc(HDC hdc);
    
    // https://learn.microsoft.com/windows/win32/api/msacm/nf-msacm-acmdriveradda
    [LibraryImport("MSACM32")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    public static partial uint acmDriverAddA(ref HACMDRIVERID phadid, HINSTANCE hinstModule, LPARAM lParam, uint dwPriority, uint fdwAdd);
    
    // https://learn.microsoft.com/windows/win32/api/msacm/nf-msacm-acmdriveraddw
    [LibraryImport("MSACM32", StringMarshalling = StringMarshalling.Utf16)]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    public static partial uint acmDriverAddW(ref HACMDRIVERID phadid, HINSTANCE hinstModule, LPARAM lParam, uint dwPriority, uint fdwAdd);
    
    // https://learn.microsoft.com/windows/win32/api/msacm/nf-msacm-acmdriverclose
    [LibraryImport("MSACM32")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    public static partial uint acmDriverClose(HACMDRIVER had, uint fdwClose);
    
    // https://learn.microsoft.com/windows/win32/api/msacm/nf-msacm-acmdriverdetailsa
    [LibraryImport("MSACM32")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    public static partial uint acmDriverDetailsA(HACMDRIVERID hadid, ref ACMDRIVERDETAILSA padd, uint fdwDetails);
    
    // https://learn.microsoft.com/windows/win32/api/msacm/nf-msacm-acmdriverdetailsw
    [LibraryImport("MSACM32", StringMarshalling = StringMarshalling.Utf16)]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    public static partial uint acmDriverDetailsW(HACMDRIVERID hadid, ref ACMDRIVERDETAILSW padd, uint fdwDetails);
    
    // https://learn.microsoft.com/windows/win32/api/msacm/nf-msacm-acmdriverenum
    [LibraryImport("MSACM32")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    public static partial uint acmDriverEnum(ACMDRIVERENUMCB fnCallback, nuint dwInstance, uint fdwEnum);
    
    // https://learn.microsoft.com/windows/win32/api/msacm/nf-msacm-acmdriverid
    [LibraryImport("MSACM32")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    public static partial uint acmDriverID(HACMOBJ hao, ref HACMDRIVERID phadid, uint fdwDriverID);
    
    // https://learn.microsoft.com/windows/win32/api/msacm/nf-msacm-acmdrivermessage
    [LibraryImport("MSACM32")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial LRESULT acmDriverMessage(HACMDRIVER had, uint uMsg, LPARAM lParam1, LPARAM lParam2);
    
    // https://learn.microsoft.com/windows/win32/api/msacm/nf-msacm-acmdriveropen
    [LibraryImport("MSACM32")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    public static partial uint acmDriverOpen(ref HACMDRIVER phad, HACMDRIVERID hadid, uint fdwOpen);
    
    // https://learn.microsoft.com/windows/win32/api/msacm/nf-msacm-acmdriverpriority
    [LibraryImport("MSACM32")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    public static partial uint acmDriverPriority(HACMDRIVERID hadid, uint dwPriority, uint fdwPriority);
    
    // https://learn.microsoft.com/windows/win32/api/msacm/nf-msacm-acmdriverremove
    [LibraryImport("MSACM32")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    public static partial uint acmDriverRemove(HACMDRIVERID hadid, uint fdwRemove);
    
    // https://learn.microsoft.com/windows/win32/api/msacm/nf-msacm-acmfilterchoosea
    [LibraryImport("MSACM32")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    public static partial uint acmFilterChooseA(ref ACMFILTERCHOOSEA pafltrc);
    
    // https://learn.microsoft.com/windows/win32/api/msacm/nf-msacm-acmfilterchoosew
    [LibraryImport("MSACM32", StringMarshalling = StringMarshalling.Utf16)]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    public static partial uint acmFilterChooseW(ref ACMFILTERCHOOSEW pafltrc);
    
    // https://learn.microsoft.com/windows/win32/api/msacm/nf-msacm-acmfilterdetailsa
    [LibraryImport("MSACM32")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    public static partial uint acmFilterDetailsA(HACMDRIVER had, ref ACMFILTERDETAILSA pafd, uint fdwDetails);
    
    // https://learn.microsoft.com/windows/win32/api/msacm/nf-msacm-acmfilterdetailsw
    [LibraryImport("MSACM32", StringMarshalling = StringMarshalling.Utf16)]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    public static partial uint acmFilterDetailsW(HACMDRIVER had, ref ACMFILTERDETAILSW pafd, uint fdwDetails);
    
    // https://learn.microsoft.com/windows/win32/api/msacm/nf-msacm-acmfilterenuma
    [LibraryImport("MSACM32")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    public static partial uint acmFilterEnumA(HACMDRIVER had, ref ACMFILTERDETAILSA pafd, ACMFILTERENUMCBA fnCallback, nuint dwInstance, uint fdwEnum);
    
    // https://learn.microsoft.com/windows/win32/api/msacm/nf-msacm-acmfilterenumw
    [LibraryImport("MSACM32", StringMarshalling = StringMarshalling.Utf16)]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    public static partial uint acmFilterEnumW(HACMDRIVER had, ref ACMFILTERDETAILSW pafd, ACMFILTERENUMCBW fnCallback, nuint dwInstance, uint fdwEnum);
    
    // https://learn.microsoft.com/windows/win32/api/msacm/nf-msacm-acmfiltertagdetailsa
    [LibraryImport("MSACM32")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    public static partial uint acmFilterTagDetailsA(HACMDRIVER had, ref ACMFILTERTAGDETAILSA paftd, uint fdwDetails);
    
    // https://learn.microsoft.com/windows/win32/api/msacm/nf-msacm-acmfiltertagdetailsw
    [LibraryImport("MSACM32", StringMarshalling = StringMarshalling.Utf16)]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    public static partial uint acmFilterTagDetailsW(HACMDRIVER had, ref ACMFILTERTAGDETAILSW paftd, uint fdwDetails);
    
    // https://learn.microsoft.com/windows/win32/api/msacm/nf-msacm-acmfiltertagenuma
    [LibraryImport("MSACM32")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    public static partial uint acmFilterTagEnumA(HACMDRIVER had, ref ACMFILTERTAGDETAILSA paftd, ACMFILTERTAGENUMCBA fnCallback, nuint dwInstance, uint fdwEnum);
    
    // https://learn.microsoft.com/windows/win32/api/msacm/nf-msacm-acmfiltertagenumw
    [LibraryImport("MSACM32", StringMarshalling = StringMarshalling.Utf16)]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    public static partial uint acmFilterTagEnumW(HACMDRIVER had, ref ACMFILTERTAGDETAILSW paftd, ACMFILTERTAGENUMCBW fnCallback, nuint dwInstance, uint fdwEnum);
    
    // https://learn.microsoft.com/windows/win32/api/msacm/nf-msacm-acmformatchoosea
    [LibraryImport("MSACM32")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    public static partial uint acmFormatChooseA(ref ACMFORMATCHOOSEA pafmtc);
    
    // https://learn.microsoft.com/windows/win32/api/msacm/nf-msacm-acmformatchoosew
    [LibraryImport("MSACM32", StringMarshalling = StringMarshalling.Utf16)]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    public static partial uint acmFormatChooseW(ref ACMFORMATCHOOSEW pafmtc);
    
    // https://learn.microsoft.com/windows/win32/api/msacm/nf-msacm-acmformatdetailsa
    [LibraryImport("MSACM32")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    public static partial uint acmFormatDetailsA(HACMDRIVER had, ref ACMFORMATDETAILSA pafd, uint fdwDetails);
    
    // https://learn.microsoft.com/windows/win32/api/msacm/nf-msacm-acmformatdetailsw
    [LibraryImport("MSACM32", StringMarshalling = StringMarshalling.Utf16)]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    public static partial uint acmFormatDetailsW(HACMDRIVER had, ref tACMFORMATDETAILSW pafd, uint fdwDetails);
    
    // https://learn.microsoft.com/windows/win32/api/msacm/nf-msacm-acmformatenuma
    [LibraryImport("MSACM32")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    public static partial uint acmFormatEnumA(HACMDRIVER had, ref ACMFORMATDETAILSA pafd, ACMFORMATENUMCBA fnCallback, nuint dwInstance, uint fdwEnum);
    
    // https://learn.microsoft.com/windows/win32/api/msacm/nf-msacm-acmformatenumw
    [LibraryImport("MSACM32", StringMarshalling = StringMarshalling.Utf16)]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    public static partial uint acmFormatEnumW(HACMDRIVER had, ref tACMFORMATDETAILSW pafd, ACMFORMATENUMCBW fnCallback, nuint dwInstance, uint fdwEnum);
    
    // https://learn.microsoft.com/windows/win32/api/msacm/nf-msacm-acmformatsuggest
    [LibraryImport("MSACM32")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    public static partial uint acmFormatSuggest(HACMDRIVER had, ref WAVEFORMATEX pwfxSrc, ref WAVEFORMATEX pwfxDst, uint cbwfxDst, uint fdwSuggest);
    
    // https://learn.microsoft.com/windows/win32/api/msacm/nf-msacm-acmformattagdetailsa
    [LibraryImport("MSACM32")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    public static partial uint acmFormatTagDetailsA(HACMDRIVER had, ref ACMFORMATTAGDETAILSA paftd, uint fdwDetails);
    
    // https://learn.microsoft.com/windows/win32/api/msacm/nf-msacm-acmformattagdetailsw
    [LibraryImport("MSACM32", StringMarshalling = StringMarshalling.Utf16)]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    public static partial uint acmFormatTagDetailsW(HACMDRIVER had, ref ACMFORMATTAGDETAILSW paftd, uint fdwDetails);
    
    // https://learn.microsoft.com/windows/win32/api/msacm/nf-msacm-acmformattagenuma
    [LibraryImport("MSACM32")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    public static partial uint acmFormatTagEnumA(HACMDRIVER had, ref ACMFORMATTAGDETAILSA paftd, ACMFORMATTAGENUMCBA fnCallback, nuint dwInstance, uint fdwEnum);
    
    // https://learn.microsoft.com/windows/win32/api/msacm/nf-msacm-acmformattagenumw
    [LibraryImport("MSACM32", StringMarshalling = StringMarshalling.Utf16)]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    public static partial uint acmFormatTagEnumW(HACMDRIVER had, ref ACMFORMATTAGDETAILSW paftd, ACMFORMATTAGENUMCBW fnCallback, nuint dwInstance, uint fdwEnum);
    
    // https://learn.microsoft.com/windows/win32/api/msacm/nf-msacm-acmgetversion
    [LibraryImport("MSACM32")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    public static partial uint acmGetVersion();
    
    // https://learn.microsoft.com/windows/win32/api/msacm/nf-msacm-acmmetrics
    [LibraryImport("MSACM32")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    public static partial uint acmMetrics(HACMOBJ hao, uint uMetric, nint pMetric);
    
    // https://learn.microsoft.com/windows/win32/api/msacm/nf-msacm-acmstreamclose
    [LibraryImport("MSACM32")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    public static partial uint acmStreamClose(HACMSTREAM has, uint fdwClose);
    
    // https://learn.microsoft.com/windows/win32/api/msacm/nf-msacm-acmstreamconvert
    [LibraryImport("MSACM32")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    public static partial uint acmStreamConvert(HACMSTREAM has, ref ACMSTREAMHEADER pash, uint fdwConvert);
    
    // https://learn.microsoft.com/windows/win32/api/msacm/nf-msacm-acmstreammessage
    [LibraryImport("MSACM32")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    public static partial uint acmStreamMessage(HACMSTREAM has, uint uMsg, LPARAM lParam1, LPARAM lParam2);
    
    // https://learn.microsoft.com/windows/win32/api/msacm/nf-msacm-acmstreamopen
    [LibraryImport("MSACM32")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    public static partial uint acmStreamOpen(ref HACMSTREAM phas, HACMDRIVER had, ref WAVEFORMATEX pwfxSrc, ref WAVEFORMATEX pwfxDst, ref WAVEFILTER pwfltr, nuint dwCallback, nuint dwInstance, uint fdwOpen);
    
    // https://learn.microsoft.com/windows/win32/api/msacm/nf-msacm-acmstreamprepareheader
    [LibraryImport("MSACM32")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    public static partial uint acmStreamPrepareHeader(HACMSTREAM has, ref ACMSTREAMHEADER pash, uint fdwPrepare);
    
    // https://learn.microsoft.com/windows/win32/api/msacm/nf-msacm-acmstreamreset
    [LibraryImport("MSACM32")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    public static partial uint acmStreamReset(HACMSTREAM has, uint fdwReset);
    
    // https://learn.microsoft.com/windows/win32/api/msacm/nf-msacm-acmstreamsize
    [LibraryImport("MSACM32")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    public static partial uint acmStreamSize(HACMSTREAM has, uint cbInput, ref uint pdwOutputBytes, uint fdwSize);
    
    // https://learn.microsoft.com/windows/win32/api/msacm/nf-msacm-acmstreamunprepareheader
    [LibraryImport("MSACM32")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    public static partial uint acmStreamUnprepareHeader(HACMSTREAM has, ref ACMSTREAMHEADER pash, uint fdwUnprepare);
    
    // https://learn.microsoft.com/windows/win32/api/mmdeviceapi/nf-mmdeviceapi-activateaudiointerfaceasync
    [LibraryImport("MMDevAPI")]
    [SupportedOSPlatform("windows8.0")]
    [PreserveSig]
    public static partial HRESULT ActivateAudioInterfaceAsync(PWSTR deviceInterfacePath, in Guid riid, nint /* optional PROPVARIANT* */ activationParams, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IActivateAudioInterfaceCompletionHandler>))] IActivateAudioInterfaceCompletionHandler completionHandler, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IActivateAudioInterfaceAsyncOperation>))] out IActivateAudioInterfaceAsyncOperation activationOperation);
    
    // https://learn.microsoft.com/windows/win32/api/winuser/nf-winuser-addclipboardformatlistener
    [LibraryImport("USER32", SetLastError = true)]
    [SupportedOSPlatform("windows6.0.6000")]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial BOOL AddClipboardFormatListener(HWND hwnd);
    
    // https://learn.microsoft.com/windows/win32/api/libloaderapi/nf-libloaderapi-adddlldirectory
    [LibraryImport("KERNEL32", SetLastError = true)]
    [SupportedOSPlatform("windows8.0")]
    [PreserveSig]
    public static partial nint AddDllDirectory(PWSTR NewDirectory);
    
    // https://learn.microsoft.com/windows/win32/api/winuser/nf-winuser-adjustwindowrectex
    [LibraryImport("USER32", SetLastError = true)]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial BOOL AdjustWindowRectEx(ref RECT lpRect, WINDOW_STYLE dwStyle, BOOL bMenu, WINDOW_EX_STYLE dwExStyle);
    
    // https://learn.microsoft.com/windows/win32/api/winuser/nf-winuser-adjustwindowrectexfordpi
    [LibraryImport("USER32", SetLastError = true)]
    [SupportedOSPlatform("windows10.0.14393")]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial BOOL AdjustWindowRectExForDpi(ref RECT lpRect, WINDOW_STYLE dwStyle, BOOL bMenu, WINDOW_EX_STYLE dwExStyle, uint dpi);
    
    // https://learn.microsoft.com/windows/console/allocconsole
    [LibraryImport("KERNEL32", SetLastError = true)]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial BOOL AllocConsole();
    
    // https://learn.microsoft.com/windows/win32/api/winuser/nf-winuser-allowsetforegroundwindow
    [LibraryImport("USER32", SetLastError = true)]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial BOOL AllowSetForegroundWindow(uint dwProcessId);
    
    // https://learn.microsoft.com/windows/win32/api/errors/nf-errors-amgeterrortexta
    [LibraryImport("QUARTZ")]
    [PreserveSig]
    public static partial uint AMGetErrorTextA(HRESULT hr, [MarshalUsing(CountElementName = nameof(MaxLen))] PSTR pbuffer, uint MaxLen);
    
    // https://learn.microsoft.com/windows/win32/api/errors/nf-errors-amgeterrortextw
    [LibraryImport("QUARTZ", StringMarshalling = StringMarshalling.Utf16)]
    [PreserveSig]
    public static partial uint AMGetErrorTextW(HRESULT hr, [MarshalUsing(CountElementName = nameof(MaxLen))] PWSTR pbuffer, uint MaxLen);
    
    // https://learn.microsoft.com/windows/win32/api/wingdi/nf-wingdi-anglearc
    [LibraryImport("GDI32", SetLastError = true)]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial BOOL AngleArc(HDC hdc, int x, int y, uint r, float StartAngle, float SweepAngle);
    
    // https://learn.microsoft.com/windows/win32/api/winuser/nf-winuser-appendmenuw
    [LibraryImport("USER32", StringMarshalling = StringMarshalling.Utf16, SetLastError = true)]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial BOOL AppendMenuW(HMENU hMenu, MENU_ITEM_FLAGS uFlags, nuint uIDNewItem, PWSTR lpNewItem);
    
    // https://learn.microsoft.com/windows/win32/api/wingdi/nf-wingdi-arcto
    [LibraryImport("GDI32", SetLastError = true)]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial BOOL ArcTo(HDC hdc, int left, int top, int right, int bottom, int xr1, int yr1, int xr2, int yr2);
    
    // https://learn.microsoft.com/windows/win32/api/winuser/nf-winuser-aredpiawarenesscontextsequal
    [LibraryImport("USER32", SetLastError = true)]
    [SupportedOSPlatform("windows10.0.14393")]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial BOOL AreDpiAwarenessContextsEqual(DPI_AWARENESS_CONTEXT dpiContextA, DPI_AWARENESS_CONTEXT dpiContextB);
    
    // https://learn.microsoft.com/windows/win32/api/icm/nf-icm-associatecolorprofilewithdevicea
    [LibraryImport("mscms", SetLastError = true)]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial BOOL AssociateColorProfileWithDeviceA(PSTR pMachineName, PSTR pProfileName, PSTR pDeviceName);
    
    // https://learn.microsoft.com/windows/win32/api/icm/nf-icm-associatecolorprofilewithdevicew
    [LibraryImport("mscms", StringMarshalling = StringMarshalling.Utf16, SetLastError = true)]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial BOOL AssociateColorProfileWithDeviceW(PWSTR pMachineName, PWSTR pProfileName, PWSTR pDeviceName);
    
    // https://learn.microsoft.com/windows/console/attachconsole
    [LibraryImport("KERNEL32", SetLastError = true)]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial BOOL AttachConsole(uint dwProcessId);
    
    // https://learn.microsoft.com/windows/win32/api/mmeapi/nf-mmeapi-auxgetdevcapsa
    [LibraryImport("WINMM")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    public static partial uint auxGetDevCapsA(nuint uDeviceID, nint pac, uint cbac);
    
    // https://learn.microsoft.com/windows/win32/api/mmeapi/nf-mmeapi-auxgetdevcapsw
    [LibraryImport("WINMM", StringMarshalling = StringMarshalling.Utf16)]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    public static partial uint auxGetDevCapsW(nuint uDeviceID, nint pac, uint cbac);
    
    // https://learn.microsoft.com/windows/win32/api/mmeapi/nf-mmeapi-auxgetnumdevs
    [LibraryImport("WINMM")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    public static partial uint auxGetNumDevs();
    
    // https://learn.microsoft.com/windows/win32/api/mmeapi/nf-mmeapi-auxgetvolume
    [LibraryImport("WINMM")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    public static partial uint auxGetVolume(uint uDeviceID, out uint pdwVolume);
    
    // https://learn.microsoft.com/windows/win32/api/mmeapi/nf-mmeapi-auxoutmessage
    [LibraryImport("WINMM")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    public static partial uint auxOutMessage(uint uDeviceID, uint uMsg, nuint dw1, nuint dw2);
    
    // https://learn.microsoft.com/windows/win32/api/mmeapi/nf-mmeapi-auxsetvolume
    [LibraryImport("WINMM")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    public static partial uint auxSetVolume(uint uDeviceID, uint dwVolume);
    
    // https://learn.microsoft.com/windows/win32/api/vfw/nf-vfw-avibuildfiltera
    [LibraryImport("AVIFIL32")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    public static partial HRESULT AVIBuildFilterA([MarshalUsing(CountElementName = nameof(cbFilter))] PSTR lpszFilter, int cbFilter, BOOL fSaving);
    
    // https://learn.microsoft.com/windows/win32/api/vfw/nf-vfw-avibuildfilterw
    [LibraryImport("AVIFIL32", StringMarshalling = StringMarshalling.Utf16)]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    public static partial HRESULT AVIBuildFilterW([MarshalUsing(CountElementName = nameof(cbFilter))] PWSTR lpszFilter, int cbFilter, BOOL fSaving);
    
    // https://learn.microsoft.com/windows/win32/api/vfw/nf-vfw-aviclearclipboard
    [LibraryImport("AVIFIL32")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    public static partial HRESULT AVIClearClipboard();
    
    // https://learn.microsoft.com/windows/win32/api/vfw/nf-vfw-avifileaddref
    [LibraryImport("AVIFIL32")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    public static partial uint AVIFileAddRef([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IAVIFile>))] IAVIFile pfile);
    
    // https://learn.microsoft.com/windows/win32/api/vfw/nf-vfw-avifilecreatestreama
    [LibraryImport("AVIFIL32")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    public static partial HRESULT AVIFileCreateStreamA([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IAVIFile>))] IAVIFile pfile, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IAVIStream>))] out IAVIStream ppavi, in AVISTREAMINFOA psi);
    
    // https://learn.microsoft.com/windows/win32/api/vfw/nf-vfw-avifilecreatestreamw
    [LibraryImport("AVIFIL32", StringMarshalling = StringMarshalling.Utf16)]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    public static partial HRESULT AVIFileCreateStreamW([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IAVIFile>))] IAVIFile pfile, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IAVIStream>))] out IAVIStream ppavi, in AVISTREAMINFOW psi);
    
    // https://learn.microsoft.com/windows/win32/api/vfw/nf-vfw-avifileendrecord
    [LibraryImport("AVIFIL32")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    public static partial HRESULT AVIFileEndRecord([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IAVIFile>))] IAVIFile pfile);
    
    // https://learn.microsoft.com/windows/win32/api/vfw/nf-vfw-avifileexit
    [LibraryImport("AVIFIL32")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    public static partial void AVIFileExit();
    
    // https://learn.microsoft.com/windows/win32/api/vfw/nf-vfw-avifilegetstream
    [LibraryImport("AVIFIL32")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    public static partial HRESULT AVIFileGetStream([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IAVIFile>))] IAVIFile pfile, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IAVIStream>))] out IAVIStream ppavi, uint fccType, int lParam);
    
    // https://learn.microsoft.com/windows/win32/api/vfw/nf-vfw-avifileinfoa
    [LibraryImport("AVIFIL32")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    public static partial HRESULT AVIFileInfoA([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IAVIFile>))] IAVIFile pfile, nint pfi, int lSize);
    
    // https://learn.microsoft.com/windows/win32/api/vfw/nf-vfw-avifileinfow
    [LibraryImport("AVIFIL32", StringMarshalling = StringMarshalling.Utf16)]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    public static partial HRESULT AVIFileInfoW([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IAVIFile>))] IAVIFile pfile, nint pfi, int lSize);
    
    // https://learn.microsoft.com/windows/win32/api/vfw/nf-vfw-avifileinit
    [LibraryImport("AVIFIL32")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    public static partial void AVIFileInit();
    
    // https://learn.microsoft.com/windows/win32/api/vfw/nf-vfw-avifileopena
    [LibraryImport("AVIFIL32")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    public static partial HRESULT AVIFileOpenA([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IAVIFile>))] out IAVIFile ppfile, PSTR szFile, uint uMode, nint /* optional Guid* */ lpHandler);
    
    // https://learn.microsoft.com/windows/win32/api/vfw/nf-vfw-avifileopenw
    [LibraryImport("AVIFIL32", StringMarshalling = StringMarshalling.Utf16)]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    public static partial HRESULT AVIFileOpenW([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IAVIFile>))] out IAVIFile ppfile, PWSTR szFile, uint uMode, nint /* optional Guid* */ lpHandler);
    
    // https://learn.microsoft.com/windows/win32/api/vfw/nf-vfw-avifilereaddata
    [LibraryImport("AVIFIL32")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    public static partial HRESULT AVIFileReadData([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IAVIFile>))] IAVIFile pfile, uint ckid, nint lpData, ref int lpcbData);
    
    // https://learn.microsoft.com/windows/win32/api/vfw/nf-vfw-avifilerelease
    [LibraryImport("AVIFIL32")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    public static partial uint AVIFileRelease([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IAVIFile>))] IAVIFile pfile);
    
    // https://learn.microsoft.com/windows/win32/api/vfw/nf-vfw-avifilewritedata
    [LibraryImport("AVIFIL32")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    public static partial HRESULT AVIFileWriteData([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IAVIFile>))] IAVIFile pfile, uint ckid, nint lpData, int cbData);
    
    // https://learn.microsoft.com/windows/win32/api/vfw/nf-vfw-avigetfromclipboard
    [LibraryImport("AVIFIL32")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    public static partial HRESULT AVIGetFromClipboard([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IAVIFile>))] out IAVIFile lppf);
    
    // https://learn.microsoft.com/windows/win32/api/vfw/nf-vfw-avimakecompressedstream
    [LibraryImport("AVIFIL32")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    public static partial HRESULT AVIMakeCompressedStream([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IAVIStream>))] out IAVIStream ppsCompressed, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IAVIStream>))] IAVIStream ppsSource, in AVICOMPRESSOPTIONS lpOptions, nint /* optional Guid* */ pclsidHandler);
    
    // https://learn.microsoft.com/windows/win32/api/vfw/nf-vfw-avimakefilefromstreams
    [LibraryImport("AVIFIL32")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    public static partial HRESULT AVIMakeFileFromStreams([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IAVIFile>))] out IAVIFile ppfile, int nStreams, [In][MarshalUsing(CountElementName = nameof(nStreams))] IAVIStream[] papStreams);
    
    // https://learn.microsoft.com/windows/win32/api/vfw/nf-vfw-avimakestreamfromclipboard
    [LibraryImport("AVIFIL32")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    public static partial HRESULT AVIMakeStreamFromClipboard(uint cfFormat, HANDLE hGlobal, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IAVIStream>))] out IAVIStream ppstream);
    
    // https://learn.microsoft.com/windows/win32/api/vfw/nf-vfw-aviputfileonclipboard
    [LibraryImport("AVIFIL32")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    public static partial HRESULT AVIPutFileOnClipboard([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IAVIFile>))] IAVIFile pf);
    
    // https://learn.microsoft.com/windows/win32/api/vfw/nf-vfw-avisavea
    [LibraryImport("AVIFIL32")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    public static partial HRESULT AVISaveA(PSTR szFile, nint /* optional Guid* */ pclsidHandler, AVISAVECALLBACK lpfnCallback, int nStreams, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IAVIStream>))] IAVIStream pfile, in AVICOMPRESSOPTIONS lpOptions);
    
    // https://learn.microsoft.com/windows/win32/api/vfw/nf-vfw-avisaveoptions
    [LibraryImport("AVIFIL32", SetLastError = true)]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    public static partial nint AVISaveOptions(HWND hwnd, uint uiFlags, int nStreams, [In][MarshalUsing(CountElementName = nameof(nStreams))] IAVIStream[] ppavi, [In][Out][MarshalUsing(CountElementName = nameof(nStreams))] AVICOMPRESSOPTIONS[] plpOptions);
    
    // https://learn.microsoft.com/windows/win32/api/vfw/nf-vfw-avisaveoptionsfree
    [LibraryImport("AVIFIL32")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    public static partial HRESULT AVISaveOptionsFree(int nStreams, [In][MarshalUsing(CountElementName = nameof(nStreams))] AVICOMPRESSOPTIONS[] plpOptions);
    
    // https://learn.microsoft.com/windows/win32/api/vfw/nf-vfw-avisaveva
    [LibraryImport("AVIFIL32")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    public static partial HRESULT AVISaveVA(PSTR szFile, nint /* optional Guid* */ pclsidHandler, AVISAVECALLBACK lpfnCallback, int nStreams, [In][MarshalUsing(CountElementName = nameof(nStreams))] IAVIStream[] ppavi, [In][MarshalUsing(CountElementName = nameof(nStreams))] AVICOMPRESSOPTIONS[] plpOptions);
    
    // https://learn.microsoft.com/windows/win32/api/vfw/nf-vfw-avisavevw
    [LibraryImport("AVIFIL32", StringMarshalling = StringMarshalling.Utf16)]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    public static partial HRESULT AVISaveVW(PWSTR szFile, nint /* optional Guid* */ pclsidHandler, AVISAVECALLBACK lpfnCallback, int nStreams, [In][MarshalUsing(CountElementName = nameof(nStreams))] IAVIStream[] ppavi, [In][MarshalUsing(CountElementName = nameof(nStreams))] AVICOMPRESSOPTIONS[] plpOptions);
    
    // https://learn.microsoft.com/windows/win32/api/vfw/nf-vfw-avisavew
    [LibraryImport("AVIFIL32", StringMarshalling = StringMarshalling.Utf16)]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    public static partial HRESULT AVISaveW(PWSTR szFile, nint /* optional Guid* */ pclsidHandler, AVISAVECALLBACK lpfnCallback, int nStreams, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IAVIStream>))] IAVIStream pfile, in AVICOMPRESSOPTIONS lpOptions);
    
    // https://learn.microsoft.com/windows/win32/api/vfw/nf-vfw-avistreamaddref
    [LibraryImport("AVIFIL32")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    public static partial uint AVIStreamAddRef([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IAVIStream>))] IAVIStream pavi);
    
    // https://learn.microsoft.com/windows/win32/api/vfw/nf-vfw-avistreambeginstreaming
    [LibraryImport("AVIFIL32")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    public static partial HRESULT AVIStreamBeginStreaming([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IAVIStream>))] IAVIStream pavi, int lStart, int lEnd, int lRate);
    
    // https://learn.microsoft.com/windows/win32/api/vfw/nf-vfw-avistreamcreate
    [LibraryImport("AVIFIL32")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    public static partial HRESULT AVIStreamCreate([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IAVIStream>))] out IAVIStream ppavi, int lParam1, int lParam2, nint /* optional Guid* */ pclsidHandler);
    
    // https://learn.microsoft.com/windows/win32/api/vfw/nf-vfw-avistreamendstreaming
    [LibraryImport("AVIFIL32")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    public static partial HRESULT AVIStreamEndStreaming([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IAVIStream>))] IAVIStream pavi);
    
    // https://learn.microsoft.com/windows/win32/api/vfw/nf-vfw-avistreamfindsample
    [LibraryImport("AVIFIL32")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    public static partial int AVIStreamFindSample([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IAVIStream>))] IAVIStream pavi, int lPos, int lFlags);
    
    // https://learn.microsoft.com/windows/win32/api/vfw/nf-vfw-avistreamgetframe
    [LibraryImport("AVIFIL32")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    public static partial nint AVIStreamGetFrame([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IGetFrame>))] IGetFrame pg, int lPos);
    
    // https://learn.microsoft.com/windows/win32/api/vfw/nf-vfw-avistreamgetframeclose
    [LibraryImport("AVIFIL32")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    public static partial HRESULT AVIStreamGetFrameClose([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IGetFrame>))] IGetFrame pg);
    
    // https://learn.microsoft.com/windows/win32/api/vfw/nf-vfw-avistreamgetframeopen
    [LibraryImport("AVIFIL32")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    [return: MarshalUsing(typeof(UniqueComInterfaceMarshaller<IGetFrame>))]
    public static partial IGetFrame AVIStreamGetFrameOpen([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IAVIStream>))] IAVIStream pavi, nint /* optional BITMAPINFOHEADER* */ lpbiWanted);
    
    // https://learn.microsoft.com/windows/win32/api/vfw/nf-vfw-avistreaminfoa
    [LibraryImport("AVIFIL32")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    public static partial HRESULT AVIStreamInfoA([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IAVIStream>))] IAVIStream pavi, nint psi, int lSize);
    
    // https://learn.microsoft.com/windows/win32/api/vfw/nf-vfw-avistreaminfow
    [LibraryImport("AVIFIL32", StringMarshalling = StringMarshalling.Utf16)]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    public static partial HRESULT AVIStreamInfoW([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IAVIStream>))] IAVIStream pavi, nint psi, int lSize);
    
    // https://learn.microsoft.com/windows/win32/api/vfw/nf-vfw-avistreamlength
    [LibraryImport("AVIFIL32")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    public static partial int AVIStreamLength([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IAVIStream>))] IAVIStream pavi);
    
    // https://learn.microsoft.com/windows/win32/api/vfw/nf-vfw-avistreamopenfromfilea
    [LibraryImport("AVIFIL32")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    public static partial HRESULT AVIStreamOpenFromFileA([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IAVIStream>))] out IAVIStream ppavi, PSTR szFile, uint fccType, int lParam, uint mode, nint /* optional Guid* */ pclsidHandler);
    
    // https://learn.microsoft.com/windows/win32/api/vfw/nf-vfw-avistreamopenfromfilew
    [LibraryImport("AVIFIL32", StringMarshalling = StringMarshalling.Utf16)]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    public static partial HRESULT AVIStreamOpenFromFileW([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IAVIStream>))] out IAVIStream ppavi, PWSTR szFile, uint fccType, int lParam, uint mode, nint /* optional Guid* */ pclsidHandler);
    
    // https://learn.microsoft.com/windows/win32/api/vfw/nf-vfw-avistreamread
    [LibraryImport("AVIFIL32")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    public static partial HRESULT AVIStreamRead([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IAVIStream>))] IAVIStream pavi, int lStart, int lSamples, nint /* optional void* */ lpBuffer, int cbBuffer, nint /* optional int* */ plBytes, nint /* optional int* */ plSamples);
    
    // https://learn.microsoft.com/windows/win32/api/vfw/nf-vfw-avistreamreaddata
    [LibraryImport("AVIFIL32")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    public static partial HRESULT AVIStreamReadData([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IAVIStream>))] IAVIStream pavi, uint fcc, nint /* optional void* */ lp, ref int lpcb);
    
    // https://learn.microsoft.com/windows/win32/api/vfw/nf-vfw-avistreamreadformat
    [LibraryImport("AVIFIL32")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    public static partial HRESULT AVIStreamReadFormat([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IAVIStream>))] IAVIStream pavi, int lPos, nint /* optional void* */ lpFormat, ref int lpcbFormat);
    
    // https://learn.microsoft.com/windows/win32/api/vfw/nf-vfw-avistreamrelease
    [LibraryImport("AVIFIL32")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    public static partial uint AVIStreamRelease([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IAVIStream>))] IAVIStream pavi);
    
    // https://learn.microsoft.com/windows/win32/api/vfw/nf-vfw-avistreamsampletotime
    [LibraryImport("AVIFIL32")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    public static partial int AVIStreamSampleToTime([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IAVIStream>))] IAVIStream pavi, int lSample);
    
    // https://learn.microsoft.com/windows/win32/api/vfw/nf-vfw-avistreamsetformat
    [LibraryImport("AVIFIL32")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    public static partial HRESULT AVIStreamSetFormat([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IAVIStream>))] IAVIStream pavi, int lPos, nint lpFormat, int cbFormat);
    
    // https://learn.microsoft.com/windows/win32/api/vfw/nf-vfw-avistreamstart
    [LibraryImport("AVIFIL32")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    public static partial int AVIStreamStart([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IAVIStream>))] IAVIStream pavi);
    
    // https://learn.microsoft.com/windows/win32/api/vfw/nf-vfw-avistreamtimetosample
    [LibraryImport("AVIFIL32")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    public static partial int AVIStreamTimeToSample([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IAVIStream>))] IAVIStream pavi, int lTime);
    
    // https://learn.microsoft.com/windows/win32/api/vfw/nf-vfw-avistreamwrite
    [LibraryImport("AVIFIL32")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    public static partial HRESULT AVIStreamWrite([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IAVIStream>))] IAVIStream pavi, int lStart, int lSamples, nint lpBuffer, int cbBuffer, uint dwFlags, nint /* optional int* */ plSampWritten, nint /* optional int* */ plBytesWritten);
    
    // https://learn.microsoft.com/windows/win32/api/vfw/nf-vfw-avistreamwritedata
    [LibraryImport("AVIFIL32")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    public static partial HRESULT AVIStreamWriteData([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IAVIStream>))] IAVIStream pavi, uint fcc, nint lp, int cb);
    
    // https://learn.microsoft.com/windows/win32/api/winuser/nf-winuser-beginpaint
    [LibraryImport("USER32")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial HDC BeginPaint(HWND hWnd, out PAINTSTRUCT lpPaint);
    
    // https://learn.microsoft.com/windows/win32/api/winbase/nf-winbase-beginupdateresourcew
    [LibraryImport("KERNEL32", StringMarshalling = StringMarshalling.Utf16, SetLastError = true)]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial HANDLE BeginUpdateResourceW(PWSTR pFileName, BOOL bDeleteExistingResources);
    
    // https://learn.microsoft.com/windows/win32/api/wingdi/nf-wingdi-bitblt
    [LibraryImport("GDI32", SetLastError = true)]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial BOOL BitBlt(HDC hdc, int x, int y, int cx, int cy, HDC hdcSrc, int x1, int y1, ROP_CODE rop);
    
    // https://learn.microsoft.com/windows/win32/api/winuser/nf-winuser-bringwindowtotop
    [LibraryImport("USER32", SetLastError = true)]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial BOOL BringWindowToTop(HWND hWnd);
    
    // https://learn.microsoft.com/windows/win32/api/winddi/nf-winddi-brushobj_hgetcolortransform
    [LibraryImport("GDI32")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial HANDLE BRUSHOBJ_hGetColorTransform(ref BRUSHOBJ pbo);
    
    // https://learn.microsoft.com/windows/win32/api/winddi/nf-winddi-brushobj_pvallocrbrush
    [LibraryImport("GDI32")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    public static partial nint BRUSHOBJ_pvAllocRbrush(ref BRUSHOBJ pbo, uint cj);
    
    // https://learn.microsoft.com/windows/win32/api/winddi/nf-winddi-brushobj_pvgetrbrush
    [LibraryImport("GDI32")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    public static partial nint BRUSHOBJ_pvGetRbrush(ref BRUSHOBJ pbo);
    
    // https://learn.microsoft.com/windows/win32/api/winddi/nf-winddi-brushobj_ulgetbrushcolor
    [LibraryImport("GDI32")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    public static partial uint BRUSHOBJ_ulGetBrushColor(ref BRUSHOBJ pbo);
    
    // https://learn.microsoft.com/windows/win32/api/winuser/nf-winuser-calculatepopupwindowposition
    [LibraryImport("USER32", SetLastError = true)]
    [SupportedOSPlatform("windows6.1")]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial BOOL CalculatePopupWindowPosition(in POINT anchorPoint, in SIZE windowSize, uint flags, nint /* optional RECT* */ excludeRect, out RECT popupWindowPosition);
    
    // https://learn.microsoft.com/windows/win32/api/winuser/nf-winuser-callwindowprocw
    [LibraryImport("USER32", StringMarshalling = StringMarshalling.Utf16)]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial LRESULT CallWindowProcW(WNDPROC lpPrevWndFunc, HWND hWnd, uint Msg, WPARAM wParam, LPARAM lParam);
    
    // https://learn.microsoft.com/windows/win32/api/lowlevelmonitorconfigurationapi/nf-lowlevelmonitorconfigurationapi-capabilitiesrequestandcapabilitiesreply
    [LibraryImport("dxva2", SetLastError = true)]
    [SupportedOSPlatform("windows6.0.6000")]
    [PreserveSig]
    public static partial int CapabilitiesRequestAndCapabilitiesReply(HANDLE hMonitor, [MarshalUsing(CountElementName = nameof(dwCapabilitiesStringLengthInCharacters))] PSTR pszASCIICapabilitiesString, uint dwCapabilitiesStringLengthInCharacters);
    
    // https://learn.microsoft.com/windows/win32/api/vfw/nf-vfw-capcreatecapturewindowa
    [LibraryImport("AVICAP32")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial HWND capCreateCaptureWindowA(PSTR lpszWindowName, uint dwStyle, int x, int y, int nWidth, int nHeight, HWND hwndParent, int nID);
    
    // https://learn.microsoft.com/windows/win32/api/vfw/nf-vfw-capcreatecapturewindoww
    [LibraryImport("AVICAP32", StringMarshalling = StringMarshalling.Utf16)]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial HWND capCreateCaptureWindowW(PWSTR lpszWindowName, uint dwStyle, int x, int y, int nWidth, int nHeight, HWND hwndParent, int nID);
    
    // https://learn.microsoft.com/windows/win32/api/vfw/nf-vfw-capgetdriverdescriptiona
    [LibraryImport("AVICAP32", SetLastError = true)]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial BOOL capGetDriverDescriptionA(uint wDriverIndex, [MarshalUsing(CountElementName = nameof(cbName))] PSTR lpszName, int cbName, [MarshalUsing(CountElementName = nameof(cbVer))] PSTR lpszVer, int cbVer);
    
    // https://learn.microsoft.com/windows/win32/api/vfw/nf-vfw-capgetdriverdescriptionw
    [LibraryImport("AVICAP32", StringMarshalling = StringMarshalling.Utf16, SetLastError = true)]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial BOOL capGetDriverDescriptionW(uint wDriverIndex, [MarshalUsing(CountElementName = nameof(cbName))] PWSTR lpszName, int cbName, [MarshalUsing(CountElementName = nameof(cbVer))] PWSTR lpszVer, int cbVer);
    
    // https://learn.microsoft.com/windows/win32/api/winuser/nf-winuser-changeclipboardchain
    [LibraryImport("USER32", SetLastError = true)]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial BOOL ChangeClipboardChain(HWND hWndRemove, HWND hWndNewNext);
    
    // https://learn.microsoft.com/windows/win32/api/icm/nf-icm-checkbitmapbits
    [LibraryImport("mscms", SetLastError = true)]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial BOOL CheckBitmapBits(nint hColorTransform, nint pSrcBits, BMFORMAT bmInput, uint dwWidth, uint dwHeight, uint dwStride, nint /* byte array */ paResult, LPBMCALLBACKFN? pfnCallback, LPARAM lpCallbackData);
    
    // https://learn.microsoft.com/windows/win32/api/icm/nf-icm-checkcolors
    [LibraryImport("mscms", SetLastError = true)]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial BOOL CheckColors(nint hColorTransform, [In][MarshalUsing(CountElementName = nameof(nColors))] COLOR[] paInputColors, uint nColors, COLORTYPE ctInput, nint /* byte array */ paResult);
    
    // https://learn.microsoft.com/windows/win32/api/wingdi/nf-wingdi-checkcolorsingamut
    [LibraryImport("GDI32", SetLastError = true)]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial BOOL CheckColorsInGamut(HDC hdc, [In][MarshalUsing(CountElementName = nameof(nCount))] RGBTRIPLE[] lpRGBTriple, nint dlpBuffer, uint nCount);
    
    // https://learn.microsoft.com/windows/win32/api/wingdi/nf-wingdi-choosepixelformat
    [LibraryImport("GDI32", SetLastError = true)]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    public static partial int ChoosePixelFormat(HDC hdc, in PIXELFORMATDESCRIPTOR ppfd);
    
    // https://learn.microsoft.com/windows/win32/api/wingdi/nf-wingdi-chord
    [LibraryImport("GDI32", SetLastError = true)]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial BOOL Chord(HDC hdc, int x1, int y1, int x2, int y2, int x3, int y3, int x4, int y4);
    
    // https://learn.microsoft.com/windows/win32/api/winuser/nf-winuser-clienttoscreen
    [LibraryImport("USER32", SetLastError = true)]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial BOOL ClientToScreen(HWND hWnd, ref POINT lpPoint);
    
    // https://learn.microsoft.com/windows/win32/api/winuser/nf-winuser-clipcursor
    [LibraryImport("USER32", SetLastError = true)]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial BOOL ClipCursor(nint /* optional RECT* */ lpRect);
    
    // https://learn.microsoft.com/windows/win32/api/winddi/nf-winddi-clipobj_benum
    [LibraryImport("GDI32", SetLastError = true)]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial BOOL CLIPOBJ_bEnum(ref CLIPOBJ pco, uint cj, ref uint pul);
    
    // https://learn.microsoft.com/windows/win32/api/winddi/nf-winddi-clipobj_cenumstart
    [LibraryImport("GDI32")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    public static partial uint CLIPOBJ_cEnumStart(ref CLIPOBJ pco, BOOL bAll, uint iType, uint iDirection, uint cLimit);
    
    // https://learn.microsoft.com/windows/win32/api/winddi/nf-winddi-clipobj_ppogetpath
    [LibraryImport("GDI32")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    public static partial nint CLIPOBJ_ppoGetPath(ref CLIPOBJ pco);
    
    // https://learn.microsoft.com/windows/win32/api/winuser/nf-winuser-closeclipboard
    [LibraryImport("USER32", SetLastError = true)]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial BOOL CloseClipboard();
    
    // https://learn.microsoft.com/windows/win32/api/icm/nf-icm-closecolorprofile
    [LibraryImport("mscms", SetLastError = true)]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial BOOL CloseColorProfile(nint hProfile);
    
    // https://learn.microsoft.com/windows/win32/api/mmiscapi/nf-mmiscapi-closedriver
    [LibraryImport("WINMM")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial LRESULT CloseDriver(HDRVR hDriver, LPARAM lParam1, LPARAM lParam2);
    
    // https://learn.microsoft.com/windows/win32/api/wingdi/nf-wingdi-closeenhmetafile
    [LibraryImport("GDI32")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial HENHMETAFILE CloseEnhMetaFile(HDC hdc);
    
    // https://learn.microsoft.com/windows/win32/api/handleapi/nf-handleapi-closehandle
    [LibraryImport("KERNEL32", SetLastError = true)]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial BOOL CloseHandle(HANDLE hObject);
    
    // https://learn.microsoft.com/windows/win32/api/wingdi/nf-wingdi-closemetafile
    [LibraryImport("GDI32")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial HMETAFILE CloseMetaFile(HDC hdc);
    
    // https://learn.microsoft.com/windows/win32/api/uxtheme/nf-uxtheme-closethemedata
    [LibraryImport("UXTHEME")]
    [SupportedOSPlatform("windows6.0.6000")]
    [PreserveSig]
    public static partial HRESULT CloseThemeData(HTHEME hTheme);
    
    [LibraryImport("MSCorEE")]
    [PreserveSig]
    public static partial HRESULT CLRCreateInstance(in Guid clsid, in Guid riid, out nint /* void */ ppInterface);
    
    // https://learn.microsoft.com/windows/win32/api/combaseapi/nf-combaseapi-clsidfromprogid
    [LibraryImport("OLE32")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    public static partial HRESULT CLSIDFromProgID(PWSTR lpszProgID, out Guid lpclsid);
    
    // https://learn.microsoft.com/windows/win32/api/icm/nf-icm-cmcheckcolors
    [LibraryImport("ICM32", SetLastError = true)]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial BOOL CMCheckColors(nint hcmTransform, [In][MarshalUsing(CountElementName = nameof(nColors))] COLOR[] lpaInputColors, uint nColors, COLORTYPE ctInput, nint /* byte array */ lpaResult);
    
    // https://learn.microsoft.com/windows/win32/api/icm/nf-icm-cmcheckcolorsingamut
    [LibraryImport("ICM32", SetLastError = true)]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial BOOL CMCheckColorsInGamut(nint hcmTransform, [In][MarshalUsing(CountElementName = nameof(nCount))] RGBTRIPLE[] lpaRGBTriple, nint /* byte array */ lpaResult, uint nCount);
    
    // https://learn.microsoft.com/windows/win32/api/icm/nf-icm-cmcheckrgbs
    [LibraryImport("ICM32", SetLastError = true)]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial BOOL CMCheckRGBs(nint hcmTransform, nint lpSrcBits, BMFORMAT bmInput, uint dwWidth, uint dwHeight, uint dwStride, nint /* byte array */ lpaResult, LPBMCALLBACKFN pfnCallback, LPARAM ulCallbackData);
    
    // https://learn.microsoft.com/windows/win32/api/icm/nf-icm-cmconvertcolornametoindex
    [LibraryImport("ICM32", SetLastError = true)]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial BOOL CMConvertColorNameToIndex(nint hProfile, [In][MarshalUsing(CountElementName = nameof(dwCount))] sbyte[] paColorName, [In][Out][MarshalUsing(CountElementName = nameof(dwCount))] uint[] paIndex, uint dwCount);
    
    // https://learn.microsoft.com/windows/win32/api/icm/nf-icm-cmconvertindextocolorname
    [LibraryImport("ICM32", SetLastError = true)]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial BOOL CMConvertIndexToColorName(nint hProfile, [In][MarshalUsing(CountElementName = nameof(dwCount))] uint[] paIndex, [In][Out][MarshalUsing(CountElementName = nameof(dwCount))] sbyte[] paColorName, uint dwCount);
    
    // https://learn.microsoft.com/windows/win32/api/icm/nf-icm-cmcreatedevicelinkprofile
    [LibraryImport("ICM32", SetLastError = true)]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial BOOL CMCreateDeviceLinkProfile([In][Out][MarshalUsing(CountElementName = nameof(nProfiles))] nint[] pahProfiles, uint nProfiles, [In][MarshalUsing(CountElementName = nameof(nIntents))] uint[] padwIntents, uint nIntents, uint dwFlags, out nint /* byte array */ lpProfileData);
    
    // https://learn.microsoft.com/windows/win32/api/icm/nf-icm-cmcreatemultiprofiletransform
    [LibraryImport("ICM32", SetLastError = true)]
    [PreserveSig]
    public static partial nint CMCreateMultiProfileTransform([In][Out][MarshalUsing(CountElementName = nameof(nProfiles))] nint[] pahProfiles, uint nProfiles, [In][MarshalUsing(CountElementName = nameof(nIntents))] uint[] padwIntents, uint nIntents, uint dwFlags);
    
    // https://learn.microsoft.com/windows/win32/api/icm/nf-icm-cmcreateprofile
    [LibraryImport("ICM32", SetLastError = true)]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial BOOL CMCreateProfile(ref LOGCOLORSPACEA lpColorSpace, out nint lpProfileData);
    
    // https://learn.microsoft.com/windows/win32/api/icm/nf-icm-cmcreateprofilew
    [LibraryImport("ICM32", StringMarshalling = StringMarshalling.Utf16, SetLastError = true)]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial BOOL CMCreateProfileW(ref LOGCOLORSPACEW lpColorSpace, out nint lpProfileData);
    
    // https://learn.microsoft.com/windows/win32/api/icm/nf-icm-cmcreatetransform
    [LibraryImport("ICM32", SetLastError = true)]
    [PreserveSig]
    public static partial nint CMCreateTransform(in LOGCOLORSPACEA lpColorSpace, nint lpDevCharacter, nint lpTargetDevCharacter);
    
    // https://learn.microsoft.com/windows/win32/api/icm/nf-icm-cmcreatetransformext
    [LibraryImport("ICM32", SetLastError = true)]
    [PreserveSig]
    public static partial nint CMCreateTransformExt(in LOGCOLORSPACEA lpColorSpace, nint lpDevCharacter, nint lpTargetDevCharacter, uint dwFlags);
    
    // https://learn.microsoft.com/windows/win32/api/icm/nf-icm-cmcreatetransformextw
    [LibraryImport("ICM32", StringMarshalling = StringMarshalling.Utf16, SetLastError = true)]
    [PreserveSig]
    public static partial nint CMCreateTransformExtW(in LOGCOLORSPACEW lpColorSpace, nint lpDevCharacter, nint lpTargetDevCharacter, uint dwFlags);
    
    // https://learn.microsoft.com/windows/win32/api/icm/nf-icm-cmcreatetransformw
    [LibraryImport("ICM32", StringMarshalling = StringMarshalling.Utf16, SetLastError = true)]
    [PreserveSig]
    public static partial nint CMCreateTransformW(in LOGCOLORSPACEW lpColorSpace, nint lpDevCharacter, nint lpTargetDevCharacter);
    
    // https://learn.microsoft.com/windows/win32/api/icm/nf-icm-cmdeletetransform
    [LibraryImport("ICM32", SetLastError = true)]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial BOOL CMDeleteTransform(nint hcmTransform);
    
    // https://learn.microsoft.com/windows/win32/api/icm/nf-icm-cmgetinfo
    [LibraryImport("ICM32")]
    [PreserveSig]
    public static partial uint CMGetInfo(uint dwInfo);
    
    // https://learn.microsoft.com/windows/win32/api/icm/nf-icm-cmgetnamedprofileinfo
    [LibraryImport("ICM32", SetLastError = true)]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial BOOL CMGetNamedProfileInfo(nint hProfile, ref NAMED_PROFILE_INFO pNamedProfileInfo);
    
    // https://learn.microsoft.com/windows/win32/api/icm/nf-icm-cmisprofilevalid
    [LibraryImport("ICM32", SetLastError = true)]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial BOOL CMIsProfileValid(nint hProfile, out BOOL lpbValid);
    
    // https://learn.microsoft.com/windows/win32/api/icm/nf-icm-cmtranslatecolors
    [LibraryImport("ICM32", SetLastError = true)]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial BOOL CMTranslateColors(nint hcmTransform, [In][MarshalUsing(CountElementName = nameof(nColors))] COLOR[] lpaInputColors, uint nColors, COLORTYPE ctInput, [In][Out][MarshalUsing(CountElementName = nameof(nColors))] COLOR[] lpaOutputColors, COLORTYPE ctOutput);
    
    // https://learn.microsoft.com/windows/win32/api/icm/nf-icm-cmtranslatergb
    [LibraryImport("ICM32", SetLastError = true)]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial BOOL CMTranslateRGB(nint hcmTransform, COLORREF ColorRef, out uint lpColorRef, uint dwFlags);
    
    // https://learn.microsoft.com/windows/win32/api/icm/nf-icm-cmtranslatergbs
    [LibraryImport("ICM32", SetLastError = true)]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial BOOL CMTranslateRGBs(nint hcmTransform, nint lpSrcBits, BMFORMAT bmInput, uint dwWidth, uint dwHeight, uint dwStride, nint lpDestBits, BMFORMAT bmOutput, uint dwTranslateDirection);
    
    // https://learn.microsoft.com/windows/win32/api/icm/nf-icm-cmtranslatergbsext
    [LibraryImport("ICM32", SetLastError = true)]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial BOOL CMTranslateRGBsExt(nint hcmTransform, nint lpSrcBits, BMFORMAT bmInput, uint dwWidth, uint dwHeight, uint dwInputStride, nint lpDestBits, BMFORMAT bmOutput, uint dwOutputStride, LPBMCALLBACKFN lpfnCallback, LPARAM ulCallbackData);
    
    // https://learn.microsoft.com/windows/win32/api/combaseapi/nf-combaseapi-cocreateinstance
    [LibraryImport("OLE32")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    public static partial HRESULT CoCreateInstance(in Guid rclsid, nint pUnkOuter, CLSCTX dwClsContext, in Guid riid, out nint /* void */ ppv);
    
    // https://learn.microsoft.com/windows/win32/api/combaseapi/nf-combaseapi-codecodeproxy
    [LibraryImport("OLE32")]
    [PreserveSig]
    public static partial HRESULT CoDecodeProxy(uint dwClientPid, ulong ui64ProxyAddress, out ServerInformation pServerInformation);
    
    // https://learn.microsoft.com/windows/win32/api/combaseapi/nf-combaseapi-cogetapartmenttype
    [LibraryImport("OLE32")]
    [SupportedOSPlatform("windows6.1")]
    [PreserveSig]
    public static partial HRESULT CoGetApartmentType(out APTTYPE pAptType, out APTTYPEQUALIFIER pAptQualifier);
    
    // https://learn.microsoft.com/windows/win32/api/combaseapi/nf-combaseapi-cogetcallcontext
    [LibraryImport("OLE32")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    public static partial HRESULT CoGetCallContext(in Guid riid, out nint /* void */ ppInterface);
    
    // https://learn.microsoft.com/windows/win32/api/combaseapi/nf-combaseapi-cogetobjectcontext
    [LibraryImport("OLE32")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    public static partial HRESULT CoGetObjectContext(in Guid riid, out nint /* void */ ppv);
    
    // https://learn.microsoft.com/windows/win32/api/wingdi/nf-wingdi-colorcorrectpalette
    [LibraryImport("GDI32", SetLastError = true)]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial BOOL ColorCorrectPalette(HDC hdc, HPALETTE hPal, uint deFirst, uint num);
    
    // https://learn.microsoft.com/windows/win32/api/wingdi/nf-wingdi-colormatchtotarget
    [LibraryImport("GDI32", SetLastError = true)]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial BOOL ColorMatchToTarget(HDC hdc, HDC hdcTarget, COLOR_MATCH_TO_TARGET_ACTION action);
    
    // https://learn.microsoft.com/windows/win32/api/icm/nf-icm-colorprofileadddisplayassociation
    [LibraryImport("mscms")]
    [PreserveSig]
    public static partial HRESULT ColorProfileAddDisplayAssociation(WCS_PROFILE_MANAGEMENT_SCOPE scope, PWSTR profileName, LUID targetAdapterID, uint sourceID, BOOL setAsDefault, BOOL associateAsAdvancedColor);
    
    [LibraryImport("mscms")]
    [PreserveSig]
    public static partial HRESULT ColorProfileGetDeviceCapabilities(WCS_PROFILE_MANAGEMENT_SCOPE scope, LUID targetAdapterID, uint sourceID, WCS_DEVICE_CAPABILITIES_TYPE capsType, nint outputCapabilities);
    
    // https://learn.microsoft.com/windows/win32/api/icm/nf-icm-colorprofilegetdisplaydefault
    [LibraryImport("mscms")]
    [PreserveSig]
    public static partial HRESULT ColorProfileGetDisplayDefault(WCS_PROFILE_MANAGEMENT_SCOPE scope, LUID targetAdapterID, uint sourceID, COLORPROFILETYPE profileType, COLORPROFILESUBTYPE profileSubType, out PWSTR profileName);
    
    // https://learn.microsoft.com/windows/win32/api/icm/nf-icm-colorprofilegetdisplaylist
    [LibraryImport("mscms")]
    [PreserveSig]
    public static partial HRESULT ColorProfileGetDisplayList(WCS_PROFILE_MANAGEMENT_SCOPE scope, LUID targetAdapterID, uint sourceID, out nint profileList, out uint profileCount);
    
    // https://learn.microsoft.com/windows/win32/api/icm/nf-icm-colorprofilegetdisplayuserscope
    [LibraryImport("mscms")]
    [PreserveSig]
    public static partial HRESULT ColorProfileGetDisplayUserScope(LUID targetAdapterID, uint sourceID, out WCS_PROFILE_MANAGEMENT_SCOPE scope);
    
    // https://learn.microsoft.com/windows/win32/api/icm/nf-icm-colorprofileremovedisplayassociation
    [LibraryImport("mscms")]
    [PreserveSig]
    public static partial HRESULT ColorProfileRemoveDisplayAssociation(WCS_PROFILE_MANAGEMENT_SCOPE scope, PWSTR profileName, LUID targetAdapterID, uint sourceID, BOOL dissociateAdvancedColor);
    
    // https://learn.microsoft.com/windows/win32/api/icm/nf-icm-colorprofilesetdisplaydefaultassociation
    [LibraryImport("mscms")]
    [PreserveSig]
    public static partial HRESULT ColorProfileSetDisplayDefaultAssociation(WCS_PROFILE_MANAGEMENT_SCOPE scope, PWSTR profileName, COLORPROFILETYPE profileType, COLORPROFILESUBTYPE profileSubType, LUID targetAdapterID, uint sourceID);
    
    // https://learn.microsoft.com/windows/win32/api/wingdi/nf-wingdi-combinergn
    [LibraryImport("GDI32")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    public static partial GDI_REGION_TYPE CombineRgn(HRGN hrgnDst, HRGN hrgnSrc1, HRGN hrgnSrc2, RGN_COMBINE_MODE iMode);
    
    // https://learn.microsoft.com/windows/win32/api/icm/nf-icm-convertcolornametoindex
    [LibraryImport("mscms", SetLastError = true)]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial BOOL ConvertColorNameToIndex(nint hProfile, [In][MarshalUsing(CountElementName = nameof(dwCount))] sbyte[] paColorName, [In][Out][MarshalUsing(CountElementName = nameof(dwCount))] uint[] paIndex, uint dwCount);
    
    // https://learn.microsoft.com/windows/win32/api/icm/nf-icm-convertindextocolorname
    [LibraryImport("mscms", SetLastError = true)]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial BOOL ConvertIndexToColorName(nint hProfile, [In][MarshalUsing(CountElementName = nameof(dwCount))] uint[] paIndex, [In][Out][MarshalUsing(CountElementName = nameof(dwCount))] sbyte[] paColorName, uint dwCount);
    
    // https://learn.microsoft.com/windows/win32/api/winuser/nf-winuser-copyacceleratortablew
    [LibraryImport("USER32", StringMarshalling = StringMarshalling.Utf16)]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    public static partial int CopyAcceleratorTableW(HACCEL hAccelSrc, nint /* optional ACCEL* */ lpAccelDst, int cAccelEntries);
    
    // https://learn.microsoft.com/windows/win32/api/wingdi/nf-wingdi-copymetafilew
    [LibraryImport("GDI32", StringMarshalling = StringMarshalling.Utf16)]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial HMETAFILE CopyMetaFileW(HMETAFILE param0, PWSTR param1);
    
    // https://learn.microsoft.com/windows/win32/api/winuser/nf-winuser-copyrect
    [LibraryImport("USER32", SetLastError = true)]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial BOOL CopyRect(out RECT lprcDst, in RECT lprcSrc);
    
    // https://learn.microsoft.com/windows/win32/api/combaseapi/nf-combaseapi-coregisterclassobject
    [LibraryImport("OLE32")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    public static partial HRESULT CoRegisterClassObject(in Guid rclsid, nint pUnk, CLSCTX dwClsContext, uint flags, out uint lpdwRegister);
    
    // https://learn.microsoft.com/windows/win32/api/objbase/nf-objbase-coregistermessagefilter
    [LibraryImport("OLE32")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    public static partial HRESULT CoRegisterMessageFilter([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMessageFilter?>))] IMessageFilter? lpMessageFilter, nint /* optional IMessageFilter* */ lplpMessageFilter);
    
    // https://learn.microsoft.com/windows/win32/api/combaseapi/nf-combaseapi-coresumeclassobjects
    [LibraryImport("OLE32")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    public static partial HRESULT CoResumeClassObjects();
    
    // https://learn.microsoft.com/windows/win32/api/combaseapi/nf-combaseapi-corevokeclassobject
    [LibraryImport("OLE32")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    public static partial HRESULT CoRevokeClassObject(uint dwRegister);
    
    // https://learn.microsoft.com/windows/win32/api/combaseapi/nf-combaseapi-cosuspendclassobjects
    [LibraryImport("OLE32")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    public static partial HRESULT CoSuspendClassObjects();
    
    // https://learn.microsoft.com/windows/win32/api/winuser/nf-winuser-countclipboardformats
    [LibraryImport("USER32", SetLastError = true)]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    public static partial int CountClipboardFormats();
    
    // https://learn.microsoft.com/windows/win32/api/winuser/nf-winuser-createacceleratortablew
    [LibraryImport("USER32", StringMarshalling = StringMarshalling.Utf16, SetLastError = true)]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial HACCEL CreateAcceleratorTableW([In][MarshalUsing(CountElementName = nameof(cAccel))] ACCEL[] paccel, int cAccel);
    
    [LibraryImport("XAudio2_8")]
    [PreserveSig]
    public static partial HRESULT CreateAudioReverb(out nint ppApo);
    
    [LibraryImport("XAudio2_8")]
    [PreserveSig]
    public static partial HRESULT CreateAudioVolumeMeter(out nint ppApo);
    
    // https://learn.microsoft.com/windows/win32/api/objbase/nf-objbase-createbindctx
    [LibraryImport("OLE32")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    public static partial HRESULT CreateBindCtx(uint reserved, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IBindCtx>))] out IBindCtx ppbc);
    
    // https://learn.microsoft.com/windows/win32/api/wingdi/nf-wingdi-createbrushindirect
    [LibraryImport("GDI32")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial HBRUSH CreateBrushIndirect(in LOGBRUSH plbrush);
    
    [LibraryImport("Windows.Media.MediaControl.dll")]
    [PreserveSig]
    public static partial HRESULT CreateCaptureAudioStateMonitor([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IAudioStateMonitor>))] out IAudioStateMonitor audioStateMonitor);
    
    [LibraryImport("Windows.Media.MediaControl.dll")]
    [PreserveSig]
    public static partial HRESULT CreateCaptureAudioStateMonitorForCategory(AUDIO_STREAM_CATEGORY category, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IAudioStateMonitor>))] out IAudioStateMonitor audioStateMonitor);
    
    [LibraryImport("Windows.Media.MediaControl.dll")]
    [PreserveSig]
    public static partial HRESULT CreateCaptureAudioStateMonitorForCategoryAndDeviceId(AUDIO_STREAM_CATEGORY category, PWSTR deviceId, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IAudioStateMonitor>))] out IAudioStateMonitor audioStateMonitor);
    
    [LibraryImport("Windows.Media.MediaControl.dll")]
    [PreserveSig]
    public static partial HRESULT CreateCaptureAudioStateMonitorForCategoryAndDeviceRole(AUDIO_STREAM_CATEGORY category, ERole role, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IAudioStateMonitor>))] out IAudioStateMonitor audioStateMonitor);
    
    // https://learn.microsoft.com/windows/win32/api/winuser/nf-winuser-createcaret
    [LibraryImport("USER32", SetLastError = true)]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial BOOL CreateCaret(HWND hWnd, HBITMAP hBitmap, int nWidth, int nHeight);
    
    // https://learn.microsoft.com/windows/win32/api/wingdi/nf-wingdi-createcolorspacea
    [LibraryImport("GDI32")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial HCOLORSPACE CreateColorSpaceA(in LOGCOLORSPACEA lplcs);
    
    // https://learn.microsoft.com/windows/win32/api/wingdi/nf-wingdi-createcolorspacew
    [LibraryImport("GDI32", StringMarshalling = StringMarshalling.Utf16)]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial HCOLORSPACE CreateColorSpaceW(in LOGCOLORSPACEW lplcs);
    
    // https://learn.microsoft.com/windows/win32/api/icm/nf-icm-createcolortransforma
    [LibraryImport("mscms", SetLastError = true)]
    [PreserveSig]
    public static partial nint CreateColorTransformA(in LOGCOLORSPACEA pLogColorSpace, nint hDestProfile, nint hTargetProfile, uint dwFlags);
    
    // https://learn.microsoft.com/windows/win32/api/icm/nf-icm-createcolortransformw
    [LibraryImport("mscms", StringMarshalling = StringMarshalling.Utf16, SetLastError = true)]
    [PreserveSig]
    public static partial nint CreateColorTransformW(in LOGCOLORSPACEW pLogColorSpace, nint hDestProfile, nint hTargetProfile, uint dwFlags);
    
    // https://learn.microsoft.com/windows/win32/api/wingdi/nf-wingdi-createcompatiblebitmap
    [LibraryImport("GDI32")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial HBITMAP CreateCompatibleBitmap(HDC hdc, int cx, int cy);
    
    // https://learn.microsoft.com/windows/win32/api/wingdi/nf-wingdi-createcompatibledc
    [LibraryImport("GDI32")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial HDC CreateCompatibleDC(HDC hdc);
    
    // https://learn.microsoft.com/windows/win32/api/corewindow/nf-corewindow-createcontrolinput
    [LibraryImport("Windows.UI.dll")]
    [PreserveSig]
    public static partial HRESULT CreateControlInput(in Guid riid, out nint /* void */ ppv);
    
    // https://learn.microsoft.com/windows/win32/api/corewindow/nf-corewindow-createcontrolinputex
    [LibraryImport("Windows.UI.dll")]
    [PreserveSig]
    public static partial HRESULT CreateControlInputEx(nint pCoreWindow, in Guid riid, out nint /* void */ ppv);
    
    // https://learn.microsoft.com/windows/win32/api/ole2/nf-ole2-createdataadviseholder
    [LibraryImport("OLE32")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    public static partial HRESULT CreateDataAdviseHolder([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDataAdviseHolder>))] out IDataAdviseHolder ppDAHolder);
    
    // https://learn.microsoft.com/windows/win32/api/wingdi/nf-wingdi-createdcw
    [LibraryImport("GDI32", StringMarshalling = StringMarshalling.Utf16)]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial HDC CreateDCW(PWSTR pwszDriver, PWSTR pwszDevice, PWSTR pszPort, nint /* optional DEVMODEW* */ pdm);
    
    // https://learn.microsoft.com/windows/win32/api/icm/nf-icm-createdevicelinkprofile
    [LibraryImport("mscms", SetLastError = true)]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial BOOL CreateDeviceLinkProfile([In][Out][MarshalUsing(CountElementName = nameof(nProfiles))] nint[] hProfile, uint nProfiles, [In][MarshalUsing(CountElementName = nameof(nIntents))] uint[] padwIntent, uint nIntents, uint dwFlags, out nint /* byte array */ pProfileData, uint indexPreferredCMM);
    
    // https://learn.microsoft.com/windows/win32/api/windows.graphics.directx.direct3d11.interop/nf-windows-graphics-directx-direct3d11-interop-createdirect3d11devicefromdxgidevice
    [LibraryImport("d3d11")]
    [PreserveSig]
    public static partial HRESULT CreateDirect3D11DeviceFromDXGIDevice([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDXGIDevice>))] IDXGIDevice dxgiDevice, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IInspectable>))] out IInspectable graphicsDevice);
    
    // https://learn.microsoft.com/windows/win32/api/windows.graphics.directx.direct3d11.interop/nf-windows-graphics-directx-direct3d11-interop-createdirect3d11surfacefromdxgisurface
    [LibraryImport("d3d11")]
    [PreserveSig]
    public static partial HRESULT CreateDirect3D11SurfaceFromDXGISurface([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDXGISurface>))] IDXGISurface dgxiSurface, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IInspectable>))] out IInspectable graphicsSurface);
    
    // https://learn.microsoft.com/windows/win32/api/dispatcherqueue/nf-dispatcherqueue-createdispatcherqueuecontroller
    [LibraryImport("CoreMessaging")]
    [PreserveSig]
    public static partial HRESULT CreateDispatcherQueueController(DispatcherQueueOptions options, out nint dispatcherQueueController);
    
    // https://learn.microsoft.com/windows/win32/api/dxgi/nf-dxgi-createdxgifactory
    [LibraryImport("dxgi")]
    [PreserveSig]
    public static partial HRESULT CreateDXGIFactory(in Guid riid, out nint /* void */ ppFactory);
    
    // https://learn.microsoft.com/windows/win32/api/dxgi/nf-dxgi-createdxgifactory1
    [LibraryImport("dxgi")]
    [SupportedOSPlatform("windows6.1")]
    [PreserveSig]
    public static partial HRESULT CreateDXGIFactory1(in Guid riid, out nint /* void */ ppFactory);
    
    // https://learn.microsoft.com/windows/win32/api/dxgi1_3/nf-dxgi1_3-createdxgifactory2
    [LibraryImport("dxgi")]
    [SupportedOSPlatform("windows8.1")]
    [PreserveSig]
    public static partial HRESULT CreateDXGIFactory2(DXGI_CREATE_FACTORY_FLAGS Flags, in Guid riid, out nint /* void */ ppFactory);
    
    // https://learn.microsoft.com/windows/win32/api/vfw/nf-vfw-createeditablestream
    [LibraryImport("AVIFIL32")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    public static partial HRESULT CreateEditableStream([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IAVIStream>))] out IAVIStream ppsEditable, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IAVIStream>))] IAVIStream psSource);
    
    // https://learn.microsoft.com/windows/win32/api/wingdi/nf-wingdi-createellipticrgn
    [LibraryImport("GDI32")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial HRGN CreateEllipticRgn(int x1, int y1, int x2, int y2);
    
    // https://learn.microsoft.com/windows/win32/api/wingdi/nf-wingdi-createellipticrgnindirect
    [LibraryImport("GDI32")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial HRGN CreateEllipticRgnIndirect(in RECT lprect);
    
    // https://learn.microsoft.com/windows/win32/api/wingdi/nf-wingdi-createenhmetafilew
    [LibraryImport("GDI32", StringMarshalling = StringMarshalling.Utf16)]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial HDC CreateEnhMetaFileW(HDC hdc, PWSTR lpFilename, nint /* optional RECT* */ lprc, PWSTR lpDesc);
    
    // https://learn.microsoft.com/windows/win32/api/oleauto/nf-oleauto-createerrorinfo
    [LibraryImport("OLEAUT32")]
    [PreserveSig]
    public static partial HRESULT CreateErrorInfo([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ICreateErrorInfo>))] out ICreateErrorInfo pperrinfo);
    
    // https://learn.microsoft.com/windows/win32/api/wingdi/nf-wingdi-createfontindirectw
    [LibraryImport("GDI32", StringMarshalling = StringMarshalling.Utf16)]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial HFONT CreateFontIndirectW(in LOGFONTW lplf);
    
    // https://learn.microsoft.com/windows/win32/api/xapofx/nf-xapofx-createfx
    [LibraryImport("XAudio2_8")]
    [PreserveSig]
    public static partial HRESULT CreateFX(in Guid clsid, out nint pEffect, nint /* optional void* */ pInitDat, uint InitDataByteSize);
    
    // https://learn.microsoft.com/windows/win32/api/wingdi/nf-wingdi-createhatchbrush
    [LibraryImport("GDI32")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial HBRUSH CreateHatchBrush(HATCH_BRUSH_STYLE iHatch, COLORREF color);
    
    // https://learn.microsoft.com/windows/win32/api/hrtfapoapi/nf-hrtfapoapi-createhrtfapo
    [LibraryImport("HrtfApo")]
    [PreserveSig]
    public static partial HRESULT CreateHrtfApo(in HrtfApoInit init, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IXAPO>))] out IXAPO xApo);
    
    // https://learn.microsoft.com/windows/win32/api/objbase/nf-objbase-createitemmoniker
    [LibraryImport("OLE32")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    public static partial HRESULT CreateItemMoniker(PWSTR lpszDelim, PWSTR lpszItem, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMoniker>))] out IMoniker ppmk);
    
    // https://learn.microsoft.com/windows/win32/api/wingdi/nf-wingdi-createmetafilew
    [LibraryImport("GDI32", StringMarshalling = StringMarshalling.Utf16)]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial HDC CreateMetaFileW(PWSTR pszFile);
    
    // https://learn.microsoft.com/windows/win32/api/icm/nf-icm-createmultiprofiletransform
    [LibraryImport("mscms", SetLastError = true)]
    [PreserveSig]
    public static partial nint CreateMultiProfileTransform([In][Out][MarshalUsing(CountElementName = nameof(nProfiles))] nint[] pahProfiles, uint nProfiles, [In][MarshalUsing(CountElementName = nameof(nIntents))] uint[] padwIntent, uint nIntents, uint dwFlags, uint indexPreferredCMM);
    
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-createnamedpropertystore
    [LibraryImport("MF")]
    [SupportedOSPlatform("windows6.0.6000")]
    [PreserveSig]
    public static partial HRESULT CreateNamedPropertyStore([MarshalUsing(typeof(UniqueComInterfaceMarshaller<INamedPropertyStore>))] out INamedPropertyStore ppStore);
    
    // https://learn.microsoft.com/windows/win32/api/ole2/nf-ole2-createoleadviseholder
    [LibraryImport("OLE32")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    public static partial HRESULT CreateOleAdviseHolder([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IOleAdviseHolder>))] out IOleAdviseHolder ppOAHolder);
    
    // https://learn.microsoft.com/windows/win32/api/wingdi/nf-wingdi-createpatternbrush
    [LibraryImport("GDI32")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial HBRUSH CreatePatternBrush(HBITMAP hbm);
    
    // https://learn.microsoft.com/windows/win32/api/wingdi/nf-wingdi-createpen
    [LibraryImport("GDI32")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial HPEN CreatePen(PEN_STYLE iStyle, int cWidth, COLORREF color);
    
    // https://learn.microsoft.com/windows/win32/api/wingdi/nf-wingdi-createpenindirect
    [LibraryImport("GDI32")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial HPEN CreatePenIndirect(in LOGPEN plpen);
    
    // https://learn.microsoft.com/windows/win32/api/wingdi/nf-wingdi-createpolygonrgn
    [LibraryImport("GDI32")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial HRGN CreatePolygonRgn([In][MarshalUsing(CountElementName = nameof(cPoint))] POINT[] pptl, int cPoint, CREATE_POLYGON_RGN_MODE iMode);
    
    // https://learn.microsoft.com/windows/win32/api/wingdi/nf-wingdi-createpolypolygonrgn
    [LibraryImport("GDI32")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial HRGN CreatePolyPolygonRgn(in POINT pptl, [In][MarshalUsing(CountElementName = nameof(cPoly))] int[] pc, int cPoly, CREATE_POLYGON_RGN_MODE iMode);
    
    // https://learn.microsoft.com/windows/win32/api/presentation/nf-presentation-createpresentationfactory
    [LibraryImport("dcomp")]
    [PreserveSig]
    public static partial HRESULT CreatePresentationFactory(nint d3dDevice, in Guid riid, out nint /* void */ presentationFactory);
    
    // https://learn.microsoft.com/windows/win32/api/icm/nf-icm-createprofilefromlogcolorspacea
    [LibraryImport("mscms", SetLastError = true)]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial BOOL CreateProfileFromLogColorSpaceA(in LOGCOLORSPACEA pLogColorSpace, out nint /* byte array */ pProfile);
    
    // https://learn.microsoft.com/windows/win32/api/icm/nf-icm-createprofilefromlogcolorspacew
    [LibraryImport("mscms", StringMarshalling = StringMarshalling.Utf16, SetLastError = true)]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial BOOL CreateProfileFromLogColorSpaceW(in LOGCOLORSPACEW pLogColorSpace, out nint /* byte array */ pProfile);
    
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-createpropertystore
    [LibraryImport("MFPlat")]
    [SupportedOSPlatform("windows6.0.6000")]
    [PreserveSig]
    public static partial HRESULT CreatePropertyStore([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IPropertyStore>))] out IPropertyStore ppStore);
    
    // https://learn.microsoft.com/windows/win32/api/shcore/nf-shcore-createrandomaccessstreamonfile
    [LibraryImport("api-ms-win-shcore-stream-winrt-l1-1-0")]
    [SupportedOSPlatform("windows8.0")]
    [PreserveSig]
    public static partial HRESULT CreateRandomAccessStreamOnFile(PWSTR filePath, uint accessMode, in Guid riid, out nint /* void */ ppv);
    
    // https://learn.microsoft.com/windows/win32/api/shcore/nf-shcore-createrandomaccessstreamoverstream
    [LibraryImport("api-ms-win-shcore-stream-winrt-l1-1-0")]
    [SupportedOSPlatform("windows8.0")]
    [PreserveSig]
    public static partial HRESULT CreateRandomAccessStreamOverStream([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IStream>))] IStream stream, BSOS_OPTIONS options, in Guid riid, out nint /* void */ ppv);
    
    // https://learn.microsoft.com/windows/win32/api/wingdi/nf-wingdi-createrectrgn
    [LibraryImport("GDI32")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial HRGN CreateRectRgn(int x1, int y1, int x2, int y2);
    
    // https://learn.microsoft.com/windows/win32/api/wingdi/nf-wingdi-createrectrgnindirect
    [LibraryImport("GDI32")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial HRGN CreateRectRgnIndirect(in RECT lprect);
    
    [LibraryImport("Windows.Media.MediaControl.dll")]
    [PreserveSig]
    public static partial HRESULT CreateRenderAudioStateMonitor([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IAudioStateMonitor>))] out IAudioStateMonitor audioStateMonitor);
    
    [LibraryImport("Windows.Media.MediaControl.dll")]
    [PreserveSig]
    public static partial HRESULT CreateRenderAudioStateMonitorForCategory(AUDIO_STREAM_CATEGORY category, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IAudioStateMonitor>))] out IAudioStateMonitor audioStateMonitor);
    
    [LibraryImport("Windows.Media.MediaControl.dll")]
    [PreserveSig]
    public static partial HRESULT CreateRenderAudioStateMonitorForCategoryAndDeviceId(AUDIO_STREAM_CATEGORY category, PWSTR deviceId, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IAudioStateMonitor>))] out IAudioStateMonitor audioStateMonitor);
    
    [LibraryImport("Windows.Media.MediaControl.dll")]
    [PreserveSig]
    public static partial HRESULT CreateRenderAudioStateMonitorForCategoryAndDeviceRole(AUDIO_STREAM_CATEGORY category, ERole role, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IAudioStateMonitor>))] out IAudioStateMonitor audioStateMonitor);
    
    // https://learn.microsoft.com/windows/win32/api/wingdi/nf-wingdi-createroundrectrgn
    [LibraryImport("GDI32")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial HRGN CreateRoundRectRgn(int x1, int y1, int x2, int y2, int w, int h);
    
    // https://learn.microsoft.com/windows/win32/api/wingdi/nf-wingdi-createsolidbrush
    [LibraryImport("GDI32")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial HBRUSH CreateSolidBrush(COLORREF color);
    
    // https://learn.microsoft.com/windows/win32/api/shcore/nf-shcore-createstreamoverrandomaccessstream
    [LibraryImport("api-ms-win-shcore-stream-winrt-l1-1-0")]
    [SupportedOSPlatform("windows8.0")]
    [PreserveSig]
    public static partial HRESULT CreateStreamOverRandomAccessStream(nint randomAccessStream, in Guid riid, out nint /* void */ ppv);
    
    // https://learn.microsoft.com/windows/win32/api/processthreadsapi/nf-processthreadsapi-createthread
    [LibraryImport("KERNEL32", SetLastError = true)]
    [SupportedOSPlatform("windows5.1.2600")]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial HANDLE CreateThread(nint /* optional SECURITY_ATTRIBUTES* */ lpThreadAttributes, nuint dwStackSize, LPTHREAD_START_ROUTINE lpStartAddress, nint /* optional void* */ lpParameter, THREAD_CREATION_FLAGS dwCreationFlags, nint /* optional uint* */ lpThreadId);
    
    // https://learn.microsoft.com/windows/win32/api/winuser/nf-winuser-createwindowexw
    [LibraryImport("USER32", StringMarshalling = StringMarshalling.Utf16, SetLastError = true)]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial HWND CreateWindowExW(WINDOW_EX_STYLE dwExStyle, PWSTR lpClassName, PWSTR lpWindowName, WINDOW_STYLE dwStyle, int X, int Y, int nWidth, int nHeight, HWND hWndParent, HMENU hMenu, HINSTANCE hInstance, nint /* optional void* */ lpParam);
    
    // https://learn.microsoft.com/windows/win32/api/d2d1_2/nf-d2d1_2-d2d1computemaximumscalefactor
    [LibraryImport("d2d1")]
    [SupportedOSPlatform("windows8.1")]
    [PreserveSig]
    public static partial float D2D1ComputeMaximumScaleFactor(in D2D_MATRIX_3X2_F matrix);
    
    // https://learn.microsoft.com/windows/win32/api/d2d1_1/nf-d2d1_1-d2d1convertcolorspace
    [LibraryImport("d2d1")]
    [PreserveSig]
    public static partial D3DCOLORVALUE D2D1ConvertColorSpace(D2D1_COLOR_SPACE sourceColorSpace, D2D1_COLOR_SPACE destinationColorSpace, in D3DCOLORVALUE color);
    
    // https://learn.microsoft.com/windows/win32/api/d2d1_1/nf-d2d1_1-d2d1createdevice
    [LibraryImport("d2d1")]
    [SupportedOSPlatform("windows8.0")]
    [PreserveSig]
    public static partial HRESULT D2D1CreateDevice([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDXGIDevice>))] IDXGIDevice dxgiDevice, nint /* optional D2D1_CREATION_PROPERTIES* */ creationProperties, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<ID2D1Device>))] out ID2D1Device d2dDevice);
    
    // https://learn.microsoft.com/windows/win32/api/d2d1_1/nf-d2d1_1-d2d1createdevicecontext
    [LibraryImport("d2d1")]
    [SupportedOSPlatform("windows8.0")]
    [PreserveSig]
    public static partial HRESULT D2D1CreateDeviceContext([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDXGISurface>))] IDXGISurface dxgiSurface, nint /* optional D2D1_CREATION_PROPERTIES* */ creationProperties, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<ID2D1DeviceContext>))] out ID2D1DeviceContext d2dDeviceContext);
    
    // https://learn.microsoft.com/windows/win32/api/d2d1/nf-d2d1-d2d1createfactory
    [LibraryImport("d2d1")]
    [SupportedOSPlatform("windows6.1")]
    [PreserveSig]
    public static partial HRESULT D2D1CreateFactory(D2D1_FACTORY_TYPE factoryType, in Guid riid, nint /* optional D2D1_FACTORY_OPTIONS* */ pFactoryOptions, out nint /* void */ ppIFactory);
    
    // https://learn.microsoft.com/windows/win32/api/d2d1_3/nf-d2d1_3-d2d1getgradientmeshinteriorpointsfromcoonspatch
    [LibraryImport("d2d1")]
    [SupportedOSPlatform("windows10.0.10240")]
    [PreserveSig]
    public static partial void D2D1GetGradientMeshInteriorPointsFromCoonsPatch(in D2D_POINT_2F pPoint0, in D2D_POINT_2F pPoint1, in D2D_POINT_2F pPoint2, in D2D_POINT_2F pPoint3, in D2D_POINT_2F pPoint4, in D2D_POINT_2F pPoint5, in D2D_POINT_2F pPoint6, in D2D_POINT_2F pPoint7, in D2D_POINT_2F pPoint8, in D2D_POINT_2F pPoint9, in D2D_POINT_2F pPoint10, in D2D_POINT_2F pPoint11, out D2D_POINT_2F pTensorPoint11, out D2D_POINT_2F pTensorPoint12, out D2D_POINT_2F pTensorPoint21, out D2D_POINT_2F pTensorPoint22);
    
    // https://learn.microsoft.com/windows/win32/api/d2d1/nf-d2d1-d2d1invertmatrix
    [LibraryImport("d2d1", SetLastError = true)]
    [SupportedOSPlatform("windows6.1")]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial BOOL D2D1InvertMatrix(ref D2D_MATRIX_3X2_F matrix);
    
    // https://learn.microsoft.com/windows/win32/api/d2d1/nf-d2d1-d2d1ismatrixinvertible
    [LibraryImport("d2d1", SetLastError = true)]
    [SupportedOSPlatform("windows6.1")]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial BOOL D2D1IsMatrixInvertible(in D2D_MATRIX_3X2_F matrix);
    
    // https://learn.microsoft.com/windows/win32/api/d2d1/nf-d2d1-d2d1makerotatematrix
    [LibraryImport("d2d1")]
    [SupportedOSPlatform("windows6.1")]
    [PreserveSig]
    public static partial void D2D1MakeRotateMatrix(float angle, D2D_POINT_2F center, out D2D_MATRIX_3X2_F matrix);
    
    // https://learn.microsoft.com/windows/win32/api/d2d1/nf-d2d1-d2d1makeskewmatrix
    [LibraryImport("d2d1")]
    [SupportedOSPlatform("windows6.1")]
    [PreserveSig]
    public static partial void D2D1MakeSkewMatrix(float angleX, float angleY, D2D_POINT_2F center, out D2D_MATRIX_3X2_F matrix);
    
    // https://learn.microsoft.com/windows/win32/api/d2d1_1/nf-d2d1_1-d2d1sincos
    [LibraryImport("d2d1")]
    [PreserveSig]
    public static partial void D2D1SinCos(float angle, out float s, out float c);
    
    // https://learn.microsoft.com/windows/win32/api/d2d1_1/nf-d2d1_1-d2d1tan
    [LibraryImport("d2d1")]
    [PreserveSig]
    public static partial float D2D1Tan(float angle);
    
    // https://learn.microsoft.com/windows/win32/api/d2d1_1/nf-d2d1_1-d2d1vec3length
    [LibraryImport("d2d1")]
    [PreserveSig]
    public static partial float D2D1Vec3Length(float x, float y, float z);
    
    // https://learn.microsoft.com/windows/win32/api/d3d10effect/nf-d3d10effect-d3d10compileeffectfrommemory
    [LibraryImport("d3d10")]
    [PreserveSig]
    public static partial HRESULT D3D10CompileEffectFromMemory(nint pData, nuint DataLength, PSTR pSrcFileName, nint /* optional D3D_SHADER_MACRO* */ pDefines, ID3DInclude pInclude, uint HLSLFlags, uint FXFlags, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<ID3DBlob>))] out ID3DBlob ppCompiledEffect, nint /* optional ID3DBlob* */ ppErrors);
    
    // https://learn.microsoft.com/windows/win32/api/d3d10shader/nf-d3d10shader-d3d10compileshader
    [LibraryImport("d3d10")]
    [PreserveSig]
    public static partial HRESULT D3D10CompileShader(PSTR pSrcData, nuint SrcDataSize, PSTR pFileName, nint /* optional D3D_SHADER_MACRO* */ pDefines, ID3DInclude pInclude, PSTR pFunctionName, PSTR pProfile, uint Flags, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<ID3DBlob>))] out ID3DBlob ppShader, nint /* optional ID3DBlob* */ ppErrorMsgs);
    
    // https://learn.microsoft.com/windows/win32/api/d3d10misc/nf-d3d10misc-d3d10createblob
    [LibraryImport("d3d10")]
    [PreserveSig]
    public static partial HRESULT D3D10CreateBlob(nuint NumBytes, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<ID3DBlob>))] out ID3DBlob ppBuffer);
    
    // https://learn.microsoft.com/windows/win32/api/d3d10misc/nf-d3d10misc-d3d10createdevice
    [LibraryImport("d3d10")]
    [PreserveSig]
    public static partial HRESULT D3D10CreateDevice([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDXGIAdapter?>))] IDXGIAdapter? pAdapter, D3D10_DRIVER_TYPE DriverType, HMODULE Software, uint Flags, uint SDKVersion, nint /* optional ID3D10Device* */ ppDevice);
    
    // https://learn.microsoft.com/windows/win32/api/d3d10_1/nf-d3d10_1-d3d10createdevice1
    [LibraryImport("d3d10_1")]
    [PreserveSig]
    public static partial HRESULT D3D10CreateDevice1([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDXGIAdapter?>))] IDXGIAdapter? pAdapter, D3D10_DRIVER_TYPE DriverType, HMODULE Software, uint Flags, D3D10_FEATURE_LEVEL1 HardwareLevel, uint SDKVersion, nint /* optional ID3D10Device1* */ ppDevice);
    
    // https://learn.microsoft.com/windows/win32/api/d3d10misc/nf-d3d10misc-d3d10createdeviceandswapchain
    [LibraryImport("d3d10")]
    [PreserveSig]
    public static partial HRESULT D3D10CreateDeviceAndSwapChain([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDXGIAdapter?>))] IDXGIAdapter? pAdapter, D3D10_DRIVER_TYPE DriverType, HMODULE Software, uint Flags, uint SDKVersion, nint /* optional DXGI_SWAP_CHAIN_DESC* */ pSwapChainDesc, nint /* optional IDXGISwapChain* */ ppSwapChain, nint /* optional ID3D10Device* */ ppDevice);
    
    // https://learn.microsoft.com/windows/win32/api/d3d10_1/nf-d3d10_1-d3d10createdeviceandswapchain1
    [LibraryImport("d3d10_1")]
    [PreserveSig]
    public static partial HRESULT D3D10CreateDeviceAndSwapChain1([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDXGIAdapter?>))] IDXGIAdapter? pAdapter, D3D10_DRIVER_TYPE DriverType, HMODULE Software, uint Flags, D3D10_FEATURE_LEVEL1 HardwareLevel, uint SDKVersion, nint /* optional DXGI_SWAP_CHAIN_DESC* */ pSwapChainDesc, nint /* optional IDXGISwapChain* */ ppSwapChain, nint /* optional ID3D10Device1* */ ppDevice);
    
    // https://learn.microsoft.com/windows/win32/api/d3d10effect/nf-d3d10effect-d3d10createeffectfrommemory
    [LibraryImport("d3d10")]
    [PreserveSig]
    public static partial HRESULT D3D10CreateEffectFromMemory(nint pData, nuint DataLength, uint FXFlags, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<ID3D10Device>))] ID3D10Device pDevice, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<ID3D10EffectPool?>))] ID3D10EffectPool? pEffectPool, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<ID3D10Effect>))] out ID3D10Effect ppEffect);
    
    // https://learn.microsoft.com/windows/win32/api/d3d10effect/nf-d3d10effect-d3d10createeffectpoolfrommemory
    [LibraryImport("d3d10")]
    [PreserveSig]
    public static partial HRESULT D3D10CreateEffectPoolFromMemory(nint pData, nuint DataLength, uint FXFlags, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<ID3D10Device>))] ID3D10Device pDevice, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<ID3D10EffectPool>))] out ID3D10EffectPool ppEffectPool);
    
    // https://learn.microsoft.com/windows/win32/api/d3d10effect/nf-d3d10effect-d3d10createstateblock
    [LibraryImport("d3d10")]
    [PreserveSig]
    public static partial HRESULT D3D10CreateStateBlock([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ID3D10Device>))] ID3D10Device pDevice, in D3D10_STATE_BLOCK_MASK pStateBlockMask, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<ID3D10StateBlock>))] out ID3D10StateBlock ppStateBlock);
    
    // https://learn.microsoft.com/windows/win32/api/d3d10effect/nf-d3d10effect-d3d10disassembleeffect
    [LibraryImport("d3d10")]
    [PreserveSig]
    public static partial HRESULT D3D10DisassembleEffect([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ID3D10Effect>))] ID3D10Effect pEffect, BOOL EnableColorCode, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<ID3DBlob>))] out ID3DBlob ppDisassembly);
    
    // https://learn.microsoft.com/windows/win32/api/d3d10shader/nf-d3d10shader-d3d10disassembleshader
    [LibraryImport("d3d10")]
    [PreserveSig]
    public static partial HRESULT D3D10DisassembleShader(nint pShader, nuint BytecodeLength, BOOL EnableColorCode, PSTR pComments, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<ID3DBlob>))] out ID3DBlob ppDisassembly);
    
    // https://learn.microsoft.com/windows/win32/api/d3d10shader/nf-d3d10shader-d3d10getgeometryshaderprofile
    [LibraryImport("d3d10")]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial PSTR D3D10GetGeometryShaderProfile([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ID3D10Device>))] ID3D10Device pDevice);
    
    // https://learn.microsoft.com/windows/win32/api/d3d10shader/nf-d3d10shader-d3d10getinputandoutputsignatureblob
    [LibraryImport("d3d10")]
    [PreserveSig]
    public static partial HRESULT D3D10GetInputAndOutputSignatureBlob(nint pShaderBytecode, nuint BytecodeLength, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<ID3DBlob>))] out ID3DBlob ppSignatureBlob);
    
    // https://learn.microsoft.com/windows/win32/api/d3d10shader/nf-d3d10shader-d3d10getinputsignatureblob
    [LibraryImport("d3d10")]
    [PreserveSig]
    public static partial HRESULT D3D10GetInputSignatureBlob(nint pShaderBytecode, nuint BytecodeLength, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<ID3DBlob>))] out ID3DBlob ppSignatureBlob);
    
    // https://learn.microsoft.com/windows/win32/api/d3d10shader/nf-d3d10shader-d3d10getoutputsignatureblob
    [LibraryImport("d3d10")]
    [PreserveSig]
    public static partial HRESULT D3D10GetOutputSignatureBlob(nint pShaderBytecode, nuint BytecodeLength, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<ID3DBlob>))] out ID3DBlob ppSignatureBlob);
    
    // https://learn.microsoft.com/windows/win32/api/d3d10shader/nf-d3d10shader-d3d10getpixelshaderprofile
    [LibraryImport("d3d10")]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial PSTR D3D10GetPixelShaderProfile([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ID3D10Device>))] ID3D10Device pDevice);
    
    // https://learn.microsoft.com/windows/win32/api/d3d10shader/nf-d3d10shader-d3d10getshaderdebuginfo
    [LibraryImport("d3d10")]
    [PreserveSig]
    public static partial HRESULT D3D10GetShaderDebugInfo(nint pShaderBytecode, nuint BytecodeLength, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<ID3DBlob>))] out ID3DBlob ppDebugInfo);
    
    // https://learn.microsoft.com/windows/win32/api/d3d10shader/nf-d3d10shader-d3d10getvertexshaderprofile
    [LibraryImport("d3d10")]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial PSTR D3D10GetVertexShaderProfile([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ID3D10Device>))] ID3D10Device pDevice);
    
    // https://learn.microsoft.com/windows/win32/api/d3d10shader/nf-d3d10shader-d3d10preprocessshader
    [LibraryImport("d3d10")]
    [PreserveSig]
    public static partial HRESULT D3D10PreprocessShader(PSTR pSrcData, nuint SrcDataSize, PSTR pFileName, nint /* optional D3D_SHADER_MACRO* */ pDefines, ID3DInclude pInclude, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<ID3DBlob>))] out ID3DBlob ppShaderText, nint /* optional ID3DBlob* */ ppErrorMsgs);
    
    // https://learn.microsoft.com/windows/win32/api/d3d10shader/nf-d3d10shader-d3d10reflectshader
    [LibraryImport("d3d10")]
    [PreserveSig]
    public static partial HRESULT D3D10ReflectShader(nint pShaderBytecode, nuint BytecodeLength, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<ID3D10ShaderReflection>))] out ID3D10ShaderReflection ppReflector);
    
    // https://learn.microsoft.com/windows/win32/api/d3d10effect/nf-d3d10effect-d3d10stateblockmaskdifference
    [LibraryImport("d3d10")]
    [PreserveSig]
    public static partial HRESULT D3D10StateBlockMaskDifference(in D3D10_STATE_BLOCK_MASK pA, in D3D10_STATE_BLOCK_MASK pB, out D3D10_STATE_BLOCK_MASK pResult);
    
    // https://learn.microsoft.com/windows/win32/api/d3d10effect/nf-d3d10effect-d3d10stateblockmaskdisableall
    [LibraryImport("d3d10")]
    [PreserveSig]
    public static partial HRESULT D3D10StateBlockMaskDisableAll(out D3D10_STATE_BLOCK_MASK pMask);
    
    // https://learn.microsoft.com/windows/win32/api/d3d10effect/nf-d3d10effect-d3d10stateblockmaskdisablecapture
    [LibraryImport("d3d10")]
    [PreserveSig]
    public static partial HRESULT D3D10StateBlockMaskDisableCapture(ref D3D10_STATE_BLOCK_MASK pMask, D3D10_DEVICE_STATE_TYPES StateType, uint RangeStart, uint RangeLength);
    
    // https://learn.microsoft.com/windows/win32/api/d3d10effect/nf-d3d10effect-d3d10stateblockmaskenableall
    [LibraryImport("d3d10")]
    [PreserveSig]
    public static partial HRESULT D3D10StateBlockMaskEnableAll(out D3D10_STATE_BLOCK_MASK pMask);
    
    // https://learn.microsoft.com/windows/win32/api/d3d10effect/nf-d3d10effect-d3d10stateblockmaskenablecapture
    [LibraryImport("d3d10")]
    [PreserveSig]
    public static partial HRESULT D3D10StateBlockMaskEnableCapture(ref D3D10_STATE_BLOCK_MASK pMask, D3D10_DEVICE_STATE_TYPES StateType, uint RangeStart, uint RangeLength);
    
    // https://learn.microsoft.com/windows/win32/api/d3d10effect/nf-d3d10effect-d3d10stateblockmaskgetsetting
    [LibraryImport("d3d10", SetLastError = true)]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial BOOL D3D10StateBlockMaskGetSetting(in D3D10_STATE_BLOCK_MASK pMask, D3D10_DEVICE_STATE_TYPES StateType, uint Entry);
    
    // https://learn.microsoft.com/windows/win32/api/d3d10effect/nf-d3d10effect-d3d10stateblockmaskintersect
    [LibraryImport("d3d10")]
    [PreserveSig]
    public static partial HRESULT D3D10StateBlockMaskIntersect(in D3D10_STATE_BLOCK_MASK pA, in D3D10_STATE_BLOCK_MASK pB, out D3D10_STATE_BLOCK_MASK pResult);
    
    // https://learn.microsoft.com/windows/win32/api/d3d10effect/nf-d3d10effect-d3d10stateblockmaskunion
    [LibraryImport("d3d10")]
    [PreserveSig]
    public static partial HRESULT D3D10StateBlockMaskUnion(in D3D10_STATE_BLOCK_MASK pA, in D3D10_STATE_BLOCK_MASK pB, out D3D10_STATE_BLOCK_MASK pResult);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-d3d11createdevice
    [LibraryImport("d3d11")]
    [PreserveSig]
    public static partial HRESULT D3D11CreateDevice([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDXGIAdapter?>))] IDXGIAdapter? pAdapter, D3D_DRIVER_TYPE DriverType, HMODULE Software, D3D11_CREATE_DEVICE_FLAG Flags, nint /* optional D3D_FEATURE_LEVEL* */ pFeatureLevels, uint FeatureLevels, uint SDKVersion, nint /* optional ID3D11Device* */ ppDevice, nint /* optional D3D_FEATURE_LEVEL* */ pFeatureLevel, nint /* optional ID3D11DeviceContext* */ ppImmediateContext);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-d3d11createdeviceandswapchain
    [LibraryImport("d3d11")]
    [PreserveSig]
    public static partial HRESULT D3D11CreateDeviceAndSwapChain([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDXGIAdapter?>))] IDXGIAdapter? pAdapter, D3D_DRIVER_TYPE DriverType, HMODULE Software, D3D11_CREATE_DEVICE_FLAG Flags, nint /* optional D3D_FEATURE_LEVEL* */ pFeatureLevels, uint FeatureLevels, uint SDKVersion, nint /* optional DXGI_SWAP_CHAIN_DESC* */ pSwapChainDesc, nint /* optional IDXGISwapChain* */ ppSwapChain, nint /* optional ID3D11Device* */ ppDevice, nint /* optional D3D_FEATURE_LEVEL* */ pFeatureLevel, nint /* optional ID3D11DeviceContext* */ ppImmediateContext);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11on12/nf-d3d11on12-d3d11on12createdevice
    [LibraryImport("d3d11")]
    [PreserveSig]
    public static partial HRESULT D3D11On12CreateDevice(nint pDevice, uint Flags, nint /* optional D3D_FEATURE_LEVEL* */ pFeatureLevels, uint FeatureLevels, nint /* optional nint* */ ppCommandQueues, uint NumQueues, uint NodeMask, nint /* optional ID3D11Device* */ ppDevice, nint /* optional ID3D11DeviceContext* */ ppImmediateContext, nint /* optional D3D_FEATURE_LEVEL* */ pChosenFeatureLevel);
    
    // https://learn.microsoft.com/windows/win32/api/d3d12/nf-d3d12-d3d12createdevice
    [LibraryImport("d3d12")]
    [PreserveSig]
    public static partial HRESULT D3D12CreateDevice(nint pAdapter, D3D_FEATURE_LEVEL MinimumFeatureLevel, in Guid riid, out nint /* void */ ppDevice);
    
    // https://learn.microsoft.com/windows/win32/api/d3d12/nf-d3d12-d3d12createrootsignaturedeserializer
    [LibraryImport("d3d12")]
    [PreserveSig]
    public static partial HRESULT D3D12CreateRootSignatureDeserializer(nint pSrcData, nuint SrcDataSizeInBytes, in Guid pRootSignatureDeserializerInterface, out nint ppRootSignatureDeserializer);
    
    // https://learn.microsoft.com/windows/win32/api/d3d12/nf-d3d12-d3d12createversionedrootsignaturedeserializer
    [LibraryImport("d3d12")]
    [PreserveSig]
    public static partial HRESULT D3D12CreateVersionedRootSignatureDeserializer(nint pSrcData, nuint SrcDataSizeInBytes, in Guid pRootSignatureDeserializerInterface, out nint ppRootSignatureDeserializer);
    
    // https://learn.microsoft.com/windows/win32/api/d3d12/nf-d3d12-d3d12enableexperimentalfeatures
    [LibraryImport("d3d12")]
    [PreserveSig]
    public static partial HRESULT D3D12EnableExperimentalFeatures(uint NumFeatures, [In][MarshalUsing(CountElementName = nameof(NumFeatures))] Guid[] pIIDs, nint /* optional void* */ pConfigurationStructs, nint /* optional uint* */ pConfigurationStructSizes);
    
    // https://learn.microsoft.com/windows/win32/api/d3d12/nf-d3d12-d3d12getdebuginterface
    [LibraryImport("d3d12")]
    [PreserveSig]
    public static partial HRESULT D3D12GetDebugInterface(in Guid riid, out nint /* void */ ppvDebug);
    
    // https://learn.microsoft.com/windows/win32/api/d3d12/nf-d3d12-d3d12getinterface
    [LibraryImport("d3d12")]
    [PreserveSig]
    public static partial HRESULT D3D12GetInterface(in Guid rclsid, in Guid riid, out nint /* void */ ppvDebug);
    
    // https://learn.microsoft.com/windows/win32/api/d3d12/nf-d3d12-d3d12serializerootsignature
    [LibraryImport("d3d12")]
    [PreserveSig]
    public static partial HRESULT D3D12SerializeRootSignature(in D3D12_ROOT_SIGNATURE_DESC pRootSignature, D3D_ROOT_SIGNATURE_VERSION Version, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<ID3DBlob>))] out ID3DBlob ppBlob, nint /* optional ID3DBlob* */ ppErrorBlob);
    
    // https://learn.microsoft.com/windows/win32/api/d3d12/nf-d3d12-d3d12serializeversionedrootsignature
    [LibraryImport("d3d12")]
    [PreserveSig]
    public static partial HRESULT D3D12SerializeVersionedRootSignature(in D3D12_VERSIONED_ROOT_SIGNATURE_DESC pRootSignature, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<ID3DBlob>))] out ID3DBlob ppBlob, nint /* optional ID3DBlob* */ ppErrorBlob);
    
    // https://learn.microsoft.com/windows/win32/api/d3dcompiler/nf-d3dcompiler-d3dcompile
    [LibraryImport("D3DCOMPILER_47")]
    [PreserveSig]
    public static partial HRESULT D3DCompile(nint pSrcData, nuint SrcDataSize, PSTR pSourceName, nint /* optional D3D_SHADER_MACRO* */ pDefines, ID3DInclude pInclude, PSTR pEntrypoint, PSTR pTarget, uint Flags1, uint Flags2, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<ID3DBlob>))] out ID3DBlob ppCode, nint /* optional ID3DBlob* */ ppErrorMsgs);
    
    // https://learn.microsoft.com/windows/win32/api/d3dcompiler/nf-d3dcompiler-d3dcompile2
    [LibraryImport("D3DCOMPILER_47")]
    [PreserveSig]
    public static partial HRESULT D3DCompile2(nint pSrcData, nuint SrcDataSize, PSTR pSourceName, nint /* optional D3D_SHADER_MACRO* */ pDefines, ID3DInclude pInclude, PSTR pEntrypoint, PSTR pTarget, uint Flags1, uint Flags2, uint SecondaryDataFlags, nint /* optional void* */ pSecondaryData, nuint SecondaryDataSize, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<ID3DBlob>))] out ID3DBlob ppCode, nint /* optional ID3DBlob* */ ppErrorMsgs);
    
    // https://learn.microsoft.com/windows/win32/api/d3dcompiler/nf-d3dcompiler-d3dcompilefromfile
    [LibraryImport("D3DCOMPILER_47")]
    [PreserveSig]
    public static partial HRESULT D3DCompileFromFile(PWSTR pFileName, nint /* optional D3D_SHADER_MACRO* */ pDefines, ID3DInclude pInclude, PSTR pEntrypoint, PSTR pTarget, uint Flags1, uint Flags2, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<ID3DBlob>))] out ID3DBlob ppCode, nint /* optional ID3DBlob* */ ppErrorMsgs);
    
    // https://learn.microsoft.com/windows/win32/api/d3dcompiler/nf-d3dcompiler-d3dcompressshaders
    [LibraryImport("D3DCOMPILER_47")]
    [PreserveSig]
    public static partial HRESULT D3DCompressShaders(uint uNumShaders, [In][MarshalUsing(CountElementName = nameof(uNumShaders))] D3D_SHADER_DATA[] pShaderData, uint uFlags, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<ID3DBlob>))] out ID3DBlob ppCompressedData);
    
    // https://learn.microsoft.com/windows/win32/api/d3dcompiler/nf-d3dcompiler-d3dcreateblob
    [LibraryImport("D3DCOMPILER_47")]
    [PreserveSig]
    public static partial HRESULT D3DCreateBlob(nuint Size, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<ID3DBlob>))] out ID3DBlob ppBlob);
    
    // https://learn.microsoft.com/windows/win32/api/d3dcompiler/nf-d3dcompiler-d3dcreatefunctionlinkinggraph
    [LibraryImport("D3DCOMPILER_47")]
    [PreserveSig]
    public static partial HRESULT D3DCreateFunctionLinkingGraph(uint uFlags, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<ID3D11FunctionLinkingGraph>))] out ID3D11FunctionLinkingGraph ppFunctionLinkingGraph);
    
    // https://learn.microsoft.com/windows/win32/api/d3dcompiler/nf-d3dcompiler-d3dcreatelinker
    [LibraryImport("D3DCOMPILER_47")]
    [PreserveSig]
    public static partial HRESULT D3DCreateLinker([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ID3D11Linker>))] out ID3D11Linker ppLinker);
    
    // https://learn.microsoft.com/windows/win32/api/d3dcompiler/nf-d3dcompiler-d3ddecompressshaders
    [LibraryImport("D3DCOMPILER_47")]
    [PreserveSig]
    public static partial HRESULT D3DDecompressShaders(nint pSrcData, nuint SrcDataSize, uint uNumShaders, uint uStartIndex, nint /* optional uint* */ pIndices, uint uFlags, [In][Out][MarshalUsing(CountElementName = nameof(uNumShaders))] nint[] ppShaders, nint /* optional uint* */ pTotalShaders);
    
    // https://learn.microsoft.com/windows/win32/api/d3dcompiler/nf-d3dcompiler-d3ddisassemble
    [LibraryImport("D3DCOMPILER_47")]
    [PreserveSig]
    public static partial HRESULT D3DDisassemble(nint pSrcData, nuint SrcDataSize, uint Flags, PSTR szComments, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<ID3DBlob>))] out ID3DBlob ppDisassembly);
    
    // https://learn.microsoft.com/windows/win32/api/d3dcompiler/nf-d3dcompiler-d3ddisassemble10effect
    [LibraryImport("D3DCOMPILER_47")]
    [PreserveSig]
    public static partial HRESULT D3DDisassemble10Effect([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ID3D10Effect>))] ID3D10Effect pEffect, uint Flags, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<ID3DBlob>))] out ID3DBlob ppDisassembly);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11shadertracing/nf-d3d11shadertracing-d3ddisassemble11trace
    [LibraryImport("D3DCOMPILER_47")]
    [SupportedOSPlatform("windows8.0")]
    [PreserveSig]
    public static partial HRESULT D3DDisassemble11Trace(nint pSrcData, nuint SrcDataSize, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<ID3D11ShaderTrace>))] ID3D11ShaderTrace pTrace, uint StartStep, uint NumSteps, uint Flags, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<ID3DBlob>))] out ID3DBlob ppDisassembly);
    
    // https://learn.microsoft.com/windows/win32/api/d3dcompiler/nf-d3dcompiler-d3ddisassembleregion
    [LibraryImport("D3DCOMPILER_47")]
    [PreserveSig]
    public static partial HRESULT D3DDisassembleRegion(nint pSrcData, nuint SrcDataSize, uint Flags, PSTR szComments, nuint StartByteOffset, nuint NumInsts, nint /* optional nuint* */ pFinishByteOffset, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<ID3DBlob>))] out ID3DBlob ppDisassembly);
    
    // https://learn.microsoft.com/windows/win32/api/d3dcompiler/nf-d3dcompiler-d3dgetblobpart
    [LibraryImport("D3DCOMPILER_47")]
    [PreserveSig]
    public static partial HRESULT D3DGetBlobPart(nint pSrcData, nuint SrcDataSize, D3D_BLOB_PART Part, uint Flags, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<ID3DBlob>))] out ID3DBlob ppPart);
    
    // https://learn.microsoft.com/windows/win32/api/d3dcompiler/nf-d3dcompiler-d3dgetdebuginfo
    [LibraryImport("D3DCOMPILER_47")]
    [PreserveSig]
    public static partial HRESULT D3DGetDebugInfo(nint pSrcData, nuint SrcDataSize, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<ID3DBlob>))] out ID3DBlob ppDebugInfo);
    
    // https://learn.microsoft.com/windows/win32/api/d3dcompiler/nf-d3dcompiler-d3dgetinputandoutputsignatureblob
    [LibraryImport("D3DCOMPILER_47")]
    [PreserveSig]
    public static partial HRESULT D3DGetInputAndOutputSignatureBlob(nint pSrcData, nuint SrcDataSize, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<ID3DBlob>))] out ID3DBlob ppSignatureBlob);
    
    // https://learn.microsoft.com/windows/win32/api/d3dcompiler/nf-d3dcompiler-d3dgetinputsignatureblob
    [LibraryImport("D3DCOMPILER_47")]
    [PreserveSig]
    public static partial HRESULT D3DGetInputSignatureBlob(nint pSrcData, nuint SrcDataSize, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<ID3DBlob>))] out ID3DBlob ppSignatureBlob);
    
    // https://learn.microsoft.com/windows/win32/api/d3dcompiler/nf-d3dcompiler-d3dgetoutputsignatureblob
    [LibraryImport("D3DCOMPILER_47")]
    [PreserveSig]
    public static partial HRESULT D3DGetOutputSignatureBlob(nint pSrcData, nuint SrcDataSize, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<ID3DBlob>))] out ID3DBlob ppSignatureBlob);
    
    // https://learn.microsoft.com/windows/win32/api/d3dcompiler/nf-d3dcompiler-d3dgettraceinstructionoffsets
    [LibraryImport("D3DCOMPILER_47")]
    [PreserveSig]
    public static partial HRESULT D3DGetTraceInstructionOffsets(nint pSrcData, nuint SrcDataSize, uint Flags, nuint StartInstIndex, nuint NumInsts, nint /* optional nuint* */ pOffsets, nint /* optional nuint* */ pTotalInsts);
    
    // https://learn.microsoft.com/windows/win32/api/d3dcompiler/nf-d3dcompiler-d3dloadmodule
    [LibraryImport("D3DCOMPILER_47")]
    [PreserveSig]
    public static partial HRESULT D3DLoadModule(nint pSrcData, nuint cbSrcDataSize, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<ID3D11Module>))] out ID3D11Module ppModule);
    
    // https://learn.microsoft.com/windows/win32/direct3d9/d3d9/nf-d3d9-d3dperf_beginevent
    [LibraryImport("d3d9")]
    [PreserveSig]
    public static partial int D3DPERF_BeginEvent(uint col, PWSTR wszName);
    
    // https://learn.microsoft.com/windows/win32/direct3d9/d3d9/nf-d3d9-d3dperf_endevent
    [LibraryImport("d3d9")]
    [PreserveSig]
    public static partial int D3DPERF_EndEvent();
    
    // https://learn.microsoft.com/windows/win32/direct3d9/d3d9/nf-d3d9-d3dperf_getstatus
    [LibraryImport("d3d9")]
    [PreserveSig]
    public static partial uint D3DPERF_GetStatus();
    
    // https://learn.microsoft.com/windows/win32/direct3d9/d3d9/nf-d3d9-d3dperf_queryrepeatframe
    [LibraryImport("d3d9", SetLastError = true)]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial BOOL D3DPERF_QueryRepeatFrame();
    
    // https://learn.microsoft.com/windows/win32/direct3d9/d3d9/nf-d3d9-d3dperf_setmarker
    [LibraryImport("d3d9")]
    [PreserveSig]
    public static partial void D3DPERF_SetMarker(uint col, PWSTR wszName);
    
    // https://learn.microsoft.com/windows/win32/direct3d9/d3d9/nf-d3d9-d3dperf_setoptions
    [LibraryImport("d3d9")]
    [PreserveSig]
    public static partial void D3DPERF_SetOptions(uint dwOptions);
    
    // https://learn.microsoft.com/windows/win32/direct3d9/d3d9/nf-d3d9-d3dperf_setregion
    [LibraryImport("d3d9")]
    [PreserveSig]
    public static partial void D3DPERF_SetRegion(uint col, PWSTR wszName);
    
    // https://learn.microsoft.com/windows/win32/api/d3dcompiler/nf-d3dcompiler-d3dpreprocess
    [LibraryImport("D3DCOMPILER_47")]
    [PreserveSig]
    public static partial HRESULT D3DPreprocess(nint pSrcData, nuint SrcDataSize, PSTR pSourceName, nint /* optional D3D_SHADER_MACRO* */ pDefines, ID3DInclude pInclude, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<ID3DBlob>))] out ID3DBlob ppCodeText, nint /* optional ID3DBlob* */ ppErrorMsgs);
    
    // https://learn.microsoft.com/windows/win32/api/d3dcompiler/nf-d3dcompiler-d3dreadfiletoblob
    [LibraryImport("D3DCOMPILER_47")]
    [PreserveSig]
    public static partial HRESULT D3DReadFileToBlob(PWSTR pFileName, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<ID3DBlob>))] out ID3DBlob ppContents);
    
    // https://learn.microsoft.com/windows/win32/api/d3dcompiler/nf-d3dcompiler-d3dreflect
    [LibraryImport("D3DCOMPILER_47")]
    [PreserveSig]
    public static partial HRESULT D3DReflect(nint pSrcData, nuint SrcDataSize, in Guid pInterface, out nint ppReflector);
    
    // https://learn.microsoft.com/windows/win32/api/d3dcompiler/nf-d3dcompiler-d3dreflectlibrary
    [LibraryImport("D3DCOMPILER_47")]
    [PreserveSig]
    public static partial HRESULT D3DReflectLibrary(nint pSrcData, nuint SrcDataSize, in Guid riid, out nint ppReflector);
    
    // https://learn.microsoft.com/windows/win32/api/d3dcompiler/nf-d3dcompiler-d3dsetblobpart
    [LibraryImport("D3DCOMPILER_47")]
    [PreserveSig]
    public static partial HRESULT D3DSetBlobPart(nint pSrcData, nuint SrcDataSize, D3D_BLOB_PART Part, uint Flags, nint pPart, nuint PartSize, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<ID3DBlob>))] out ID3DBlob ppNewShader);
    
    // https://learn.microsoft.com/windows/win32/api/d3dcompiler/nf-d3dcompiler-d3dstripshader
    [LibraryImport("D3DCOMPILER_47")]
    [PreserveSig]
    public static partial HRESULT D3DStripShader(nint pShaderBytecode, nuint BytecodeLength, uint uStripFlags, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<ID3DBlob>))] out ID3DBlob ppStrippedBlob);
    
    // https://learn.microsoft.com/windows/win32/api/d3dcompiler/nf-d3dcompiler-d3dwriteblobtofile
    [LibraryImport("D3DCOMPILER_47")]
    [PreserveSig]
    public static partial HRESULT D3DWriteBlobToFile([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ID3DBlob>))] ID3DBlob pBlob, PWSTR pFileName, BOOL bOverwrite);
    
    // https://learn.microsoft.com/windows/win32/api/d3dcsx/nf-d3dcsx-d3dx11createfft
    [LibraryImport("d3dcsx")]
    [PreserveSig]
    public static partial HRESULT D3DX11CreateFFT([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ID3D11DeviceContext>))] ID3D11DeviceContext pDeviceContext, in D3DX11_FFT_DESC pDesc, uint Flags, out D3DX11_FFT_BUFFER_INFO pBufferInfo, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<ID3DX11FFT>))] out ID3DX11FFT ppFFT);
    
    // https://learn.microsoft.com/windows/win32/api/d3dcsx/nf-d3dcsx-d3dx11createfft1dcomplex
    [LibraryImport("d3dcsx")]
    [PreserveSig]
    public static partial HRESULT D3DX11CreateFFT1DComplex([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ID3D11DeviceContext>))] ID3D11DeviceContext pDeviceContext, uint X, uint Flags, out D3DX11_FFT_BUFFER_INFO pBufferInfo, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<ID3DX11FFT>))] out ID3DX11FFT ppFFT);
    
    // https://learn.microsoft.com/windows/win32/api/d3dcsx/nf-d3dcsx-d3dx11createfft1dreal
    [LibraryImport("d3dcsx")]
    [PreserveSig]
    public static partial HRESULT D3DX11CreateFFT1DReal([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ID3D11DeviceContext>))] ID3D11DeviceContext pDeviceContext, uint X, uint Flags, out D3DX11_FFT_BUFFER_INFO pBufferInfo, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<ID3DX11FFT>))] out ID3DX11FFT ppFFT);
    
    // https://learn.microsoft.com/windows/win32/api/d3dcsx/nf-d3dcsx-d3dx11createfft2dcomplex
    [LibraryImport("d3dcsx")]
    [PreserveSig]
    public static partial HRESULT D3DX11CreateFFT2DComplex([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ID3D11DeviceContext>))] ID3D11DeviceContext pDeviceContext, uint X, uint Y, uint Flags, out D3DX11_FFT_BUFFER_INFO pBufferInfo, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<ID3DX11FFT>))] out ID3DX11FFT ppFFT);
    
    // https://learn.microsoft.com/windows/win32/api/d3dcsx/nf-d3dcsx-d3dx11createfft2dreal
    [LibraryImport("d3dcsx")]
    [PreserveSig]
    public static partial HRESULT D3DX11CreateFFT2DReal([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ID3D11DeviceContext>))] ID3D11DeviceContext pDeviceContext, uint X, uint Y, uint Flags, out D3DX11_FFT_BUFFER_INFO pBufferInfo, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<ID3DX11FFT>))] out ID3DX11FFT ppFFT);
    
    // https://learn.microsoft.com/windows/win32/api/d3dcsx/nf-d3dcsx-d3dx11createfft3dcomplex
    [LibraryImport("d3dcsx")]
    [PreserveSig]
    public static partial HRESULT D3DX11CreateFFT3DComplex([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ID3D11DeviceContext>))] ID3D11DeviceContext pDeviceContext, uint X, uint Y, uint Z, uint Flags, out D3DX11_FFT_BUFFER_INFO pBufferInfo, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<ID3DX11FFT>))] out ID3DX11FFT ppFFT);
    
    // https://learn.microsoft.com/windows/win32/api/d3dcsx/nf-d3dcsx-d3dx11createfft3dreal
    [LibraryImport("d3dcsx")]
    [PreserveSig]
    public static partial HRESULT D3DX11CreateFFT3DReal([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ID3D11DeviceContext>))] ID3D11DeviceContext pDeviceContext, uint X, uint Y, uint Z, uint Flags, out D3DX11_FFT_BUFFER_INFO pBufferInfo, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<ID3DX11FFT>))] out ID3DX11FFT ppFFT);
    
    // https://learn.microsoft.com/windows/win32/api/d3dcsx/nf-d3dcsx-d3dx11createscan
    [LibraryImport("d3dcsx")]
    [PreserveSig]
    public static partial HRESULT D3DX11CreateScan([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ID3D11DeviceContext>))] ID3D11DeviceContext pDeviceContext, uint MaxElementScanSize, uint MaxScanCount, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<ID3DX11Scan>))] out ID3DX11Scan ppScan);
    
    // https://learn.microsoft.com/windows/win32/api/d3dcsx/nf-d3dcsx-d3dx11createsegmentedscan
    [LibraryImport("d3dcsx")]
    [PreserveSig]
    public static partial HRESULT D3DX11CreateSegmentedScan([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ID3D11DeviceContext>))] ID3D11DeviceContext pDeviceContext, uint MaxElementScanSize, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<ID3DX11SegmentedScan>))] out ID3DX11SegmentedScan ppScan);
    
    // https://learn.microsoft.com/windows/win32/api/dcomp/nf-dcomp-dcompositionattachmousedragtohwnd
    [LibraryImport("dcomp")]
    [PreserveSig]
    public static partial HRESULT DCompositionAttachMouseDragToHwnd([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDCompositionVisual>))] IDCompositionVisual visual, HWND hwnd, BOOL enable);
    
    // https://learn.microsoft.com/windows/win32/api/dcomp/nf-dcomp-dcompositionattachmousewheeltohwnd
    [LibraryImport("dcomp")]
    [PreserveSig]
    public static partial HRESULT DCompositionAttachMouseWheelToHwnd([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDCompositionVisual>))] IDCompositionVisual visual, HWND hwnd, BOOL enable);
    
    // https://learn.microsoft.com/windows/win32/api/dcomp/nf-dcomp-dcompositionboostcompositorclock
    [LibraryImport("dcomp")]
    [PreserveSig]
    public static partial HRESULT DCompositionBoostCompositorClock(BOOL enable);
    
    // https://learn.microsoft.com/windows/win32/api/dcomp/nf-dcomp-dcompositioncreatedevice
    [LibraryImport("dcomp")]
    [SupportedOSPlatform("windows8.0")]
    [PreserveSig]
    public static partial HRESULT DCompositionCreateDevice([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDXGIDevice?>))] IDXGIDevice? dxgiDevice, in Guid iid, out nint /* void */ dcompositionDevice);
    
    // https://learn.microsoft.com/windows/win32/api/dcomp/nf-dcomp-dcompositioncreatedevice2
    [LibraryImport("dcomp")]
    [SupportedOSPlatform("windows8.1")]
    [PreserveSig]
    public static partial HRESULT DCompositionCreateDevice2(nint renderingDevice, in Guid iid, out nint /* void */ dcompositionDevice);
    
    // https://learn.microsoft.com/windows/win32/api/dcomp/nf-dcomp-dcompositioncreatedevice3
    [LibraryImport("dcomp")]
    [PreserveSig]
    public static partial HRESULT DCompositionCreateDevice3(nint renderingDevice, in Guid iid, out nint /* void */ dcompositionDevice);
    
    // https://learn.microsoft.com/windows/win32/api/dcomp/nf-dcomp-dcompositioncreatesurfacehandle
    [LibraryImport("dcomp")]
    [SupportedOSPlatform("windows8.0")]
    [PreserveSig]
    public static partial HRESULT DCompositionCreateSurfaceHandle(uint desiredAccess, nint /* optional SECURITY_ATTRIBUTES* */ securityAttributes, out HANDLE surfaceHandle);
    
    // https://learn.microsoft.com/windows/win32/api/dcomp/nf-dcomp-dcompositiongetframeid
    [LibraryImport("dcomp")]
    [PreserveSig]
    public static partial HRESULT DCompositionGetFrameId(COMPOSITION_FRAME_ID_TYPE frameIdType, out ulong frameId);
    
    // https://learn.microsoft.com/windows/win32/api/dcomp/nf-dcomp-dcompositiongetstatistics
    [LibraryImport("dcomp")]
    [PreserveSig]
    public static partial HRESULT DCompositionGetStatistics(ulong frameId, out COMPOSITION_FRAME_STATS frameStats, uint targetIdCount, nint /* optional COMPOSITION_TARGET_ID* */ targetIds, nint /* optional uint* */ actualTargetIdCount);
    
    [LibraryImport("dcomp")]
    [PreserveSig]
    public static partial HRESULT DCompositionGetTargetStatistics(ulong frameId, in COMPOSITION_TARGET_ID targetId, out COMPOSITION_TARGET_STATS targetStats);
    
    // https://learn.microsoft.com/windows/win32/api/dcomp/nf-dcomp-dcompositionwaitforcompositorclock
    [LibraryImport("dcomp")]
    [PreserveSig]
    public static partial uint DCompositionWaitForCompositorClock(uint count, nint /* optional HANDLE* */ handles, uint timeoutInMs);
    
    // https://learn.microsoft.com/windows/win32/api/mmiscapi/nf-mmiscapi-defdriverproc
    [LibraryImport("WINMM")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial LRESULT DefDriverProc(nuint dwDriverIdentifier, HDRVR hdrvr, uint uMsg, LPARAM lParam1, LPARAM lParam2);
    
    // https://learn.microsoft.com/windows/win32/api/highlevelmonitorconfigurationapi/nf-highlevelmonitorconfigurationapi-degaussmonitor
    [LibraryImport("dxva2", SetLastError = true)]
    [SupportedOSPlatform("windows6.0.6000")]
    [PreserveSig]
    public static partial int DegaussMonitor(HANDLE hMonitor);
    
    // https://learn.microsoft.com/windows/win32/api/wingdi/nf-wingdi-deletecolorspace
    [LibraryImport("GDI32", SetLastError = true)]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial BOOL DeleteColorSpace(HCOLORSPACE hcs);
    
    // https://learn.microsoft.com/windows/win32/api/icm/nf-icm-deletecolortransform
    [LibraryImport("mscms", SetLastError = true)]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial BOOL DeleteColorTransform(nint hxform);
    
    // https://learn.microsoft.com/windows/win32/api/wingdi/nf-wingdi-deletedc
    [LibraryImport("GDI32", SetLastError = true)]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial BOOL DeleteDC(HDC hdc);
    
    // https://learn.microsoft.com/windows/win32/api/wingdi/nf-wingdi-deleteenhmetafile
    [LibraryImport("GDI32", SetLastError = true)]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial BOOL DeleteEnhMetaFile(HENHMETAFILE hmf);
    
    // https://learn.microsoft.com/windows/win32/api/wingdi/nf-wingdi-deletemetafile
    [LibraryImport("GDI32", SetLastError = true)]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial BOOL DeleteMetaFile(HMETAFILE hmf);
    
    // https://learn.microsoft.com/windows/win32/api/wingdi/nf-wingdi-deleteobject
    [LibraryImport("GDI32", SetLastError = true)]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial BOOL DeleteObject(HGDIOBJ ho);
    
    // https://learn.microsoft.com/windows/win32/api/wingdi/nf-wingdi-describepixelformat
    [LibraryImport("GDI32", SetLastError = true)]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    public static partial int DescribePixelFormat(HDC hdc, int iPixelFormat, uint nBytes, nint /* optional PIXELFORMATDESCRIPTOR* */ ppfd);
    
    // https://learn.microsoft.com/windows/win32/api/winuser/nf-winuser-destroyacceleratortable
    [LibraryImport("USER32", SetLastError = true)]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial BOOL DestroyAcceleratorTable(HACCEL hAccel);
    
    // https://learn.microsoft.com/windows/win32/api/winuser/nf-winuser-destroycaret
    [LibraryImport("USER32", SetLastError = true)]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial BOOL DestroyCaret();
    
    // https://learn.microsoft.com/windows/win32/api/winuser/nf-winuser-destroyicon
    [LibraryImport("USER32", SetLastError = true)]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial BOOL DestroyIcon(HICON hIcon);
    
    // https://learn.microsoft.com/windows/win32/api/physicalmonitorenumerationapi/nf-physicalmonitorenumerationapi-destroyphysicalmonitor
    [LibraryImport("dxva2", SetLastError = true)]
    [SupportedOSPlatform("windows6.0.6000")]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial BOOL DestroyPhysicalMonitor(HANDLE hMonitor);
    
    // https://learn.microsoft.com/windows/win32/api/physicalmonitorenumerationapi/nf-physicalmonitorenumerationapi-destroyphysicalmonitors
    [LibraryImport("dxva2", SetLastError = true)]
    [SupportedOSPlatform("windows6.0.6000")]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial BOOL DestroyPhysicalMonitors(uint dwPhysicalMonitorArraySize, [In][MarshalUsing(CountElementName = nameof(dwPhysicalMonitorArraySize))] PHYSICAL_MONITOR[] pPhysicalMonitorArray);
    
    // https://learn.microsoft.com/windows/win32/api/winuser/nf-winuser-destroywindow
    [LibraryImport("USER32", SetLastError = true)]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial BOOL DestroyWindow(HWND hWnd);
    
    // https://learn.microsoft.com/windows/win32/api/wingdi/nf-wingdi-devicecapabilitiesa
    [LibraryImport("winspool.drv")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    public static partial int DeviceCapabilitiesA(PSTR pDevice, PSTR pPort, PRINTER_DEVICE_CAPABILITIES fwCapability, PSTR pOutput, nint /* optional DEVMODEA* */ pDevMode);
    
    // https://learn.microsoft.com/windows/win32/api/wingdi/nf-wingdi-devicecapabilitiesw
    [LibraryImport("winspool.drv", StringMarshalling = StringMarshalling.Utf16)]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    public static partial int DeviceCapabilitiesW(PWSTR pDevice, PWSTR pPort, PRINTER_DEVICE_CAPABILITIES fwCapability, PWSTR pOutput, nint /* optional DEVMODEW* */ pDevMode);
    
    // https://learn.microsoft.com/windows/win32/api/d3d9/nf-d3d9-direct3dcreate9
    [LibraryImport("d3d9")]
    [PreserveSig]
    [return: MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDirect3D9>))]
    public static partial IDirect3D9 Direct3DCreate9(uint SDKVersion);
    
    // https://learn.microsoft.com/windows/win32/api/d3d9/nf-d3d9-direct3dcreate9ex
    [LibraryImport("d3d9")]
    [PreserveSig]
    public static partial HRESULT Direct3DCreate9Ex(uint SDKVersion, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDirect3D9Ex>))] out IDirect3D9Ex param1);
    
    [LibraryImport("d3d9")]
    [PreserveSig]
    [return: MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDirect3D9>))]
    public static partial IDirect3D9 Direct3DCreate9On12(uint SDKVersion, ref D3D9ON12_ARGS pOverrideList, uint NumOverrideEntries);
    
    [LibraryImport("d3d9")]
    [PreserveSig]
    public static partial HRESULT Direct3DCreate9On12Ex(uint SDKVersion, ref D3D9ON12_ARGS pOverrideList, uint NumOverrideEntries, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDirect3D9Ex>))] out IDirect3D9Ex ppOutputInterface);
    
    // https://learn.microsoft.com/windows/win32/api/ddraw/nf-ddraw-directdrawcreate
    [LibraryImport("DDRAW")]
    [PreserveSig]
    public static partial HRESULT DirectDrawCreate(ref Guid lpGUID, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDirectDraw>))] out IDirectDraw lplpDD, nint pUnkOuter);
    
    // https://learn.microsoft.com/windows/win32/api/ddraw/nf-ddraw-directdrawcreateclipper
    [LibraryImport("DDRAW")]
    [PreserveSig]
    public static partial HRESULT DirectDrawCreateClipper(uint dwFlags, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDirectDrawClipper>))] out IDirectDrawClipper lplpDDClipper, nint pUnkOuter);
    
    // https://learn.microsoft.com/windows/win32/api/ddraw/nf-ddraw-directdrawcreateex
    [LibraryImport("DDRAW")]
    [PreserveSig]
    public static partial HRESULT DirectDrawCreateEx(ref Guid lpGuid, out nint lplpDD, in Guid iid, nint pUnkOuter);
    
    // https://learn.microsoft.com/windows/win32/api/ddraw/nf-ddraw-directdrawenumeratea
    [LibraryImport("DDRAW")]
    [PreserveSig]
    public static partial HRESULT DirectDrawEnumerateA(LPDDENUMCALLBACKA lpCallback, nint lpContext);
    
    // https://learn.microsoft.com/windows/win32/api/ddraw/nf-ddraw-directdrawenumerateexa
    [LibraryImport("DDRAW")]
    [PreserveSig]
    public static partial HRESULT DirectDrawEnumerateExA(LPDDENUMCALLBACKEXA lpCallback, nint lpContext, uint dwFlags);
    
    // https://learn.microsoft.com/windows/win32/api/ddraw/nf-ddraw-directdrawenumerateexw
    [LibraryImport("DDRAW", StringMarshalling = StringMarshalling.Utf16)]
    [PreserveSig]
    public static partial HRESULT DirectDrawEnumerateExW(LPDDENUMCALLBACKEXW lpCallback, nint lpContext, uint dwFlags);
    
    // https://learn.microsoft.com/windows/win32/api/ddraw/nf-ddraw-directdrawenumeratew
    [LibraryImport("DDRAW", StringMarshalling = StringMarshalling.Utf16)]
    [PreserveSig]
    public static partial HRESULT DirectDrawEnumerateW(LPDDENUMCALLBACKW lpCallback, nint lpContext);
    
    [LibraryImport("DSOUND")]
    [PreserveSig]
    public static partial HRESULT DirectSoundCaptureCreate(nint /* optional Guid* */ pcGuidDevice, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDirectSoundCapture>))] out IDirectSoundCapture ppDSC, nint pUnkOuter);
    
    [LibraryImport("DSOUND")]
    [PreserveSig]
    public static partial HRESULT DirectSoundCaptureCreate8(nint /* optional Guid* */ pcGuidDevice, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDirectSoundCapture>))] out IDirectSoundCapture ppDSC8, nint pUnkOuter);
    
    [LibraryImport("DSOUND")]
    [PreserveSig]
    public static partial HRESULT DirectSoundCaptureEnumerateA(LPDSENUMCALLBACKA pDSEnumCallback, nint /* optional void* */ pContext);
    
    [LibraryImport("DSOUND", StringMarshalling = StringMarshalling.Utf16)]
    [PreserveSig]
    public static partial HRESULT DirectSoundCaptureEnumerateW(LPDSENUMCALLBACKW pDSEnumCallback, nint /* optional void* */ pContext);
    
    [LibraryImport("DSOUND")]
    [PreserveSig]
    public static partial HRESULT DirectSoundCreate(nint /* optional Guid* */ pcGuidDevice, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDirectSound>))] out IDirectSound ppDS, nint pUnkOuter);
    
    [LibraryImport("DSOUND")]
    [PreserveSig]
    public static partial HRESULT DirectSoundCreate8(nint /* optional Guid* */ pcGuidDevice, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDirectSound8>))] out IDirectSound8 ppDS8, nint pUnkOuter);
    
    [LibraryImport("DSOUND")]
    [PreserveSig]
    public static partial HRESULT DirectSoundEnumerateA(LPDSENUMCALLBACKA pDSEnumCallback, nint /* optional void* */ pContext);
    
    [LibraryImport("DSOUND", StringMarshalling = StringMarshalling.Utf16)]
    [PreserveSig]
    public static partial HRESULT DirectSoundEnumerateW(LPDSENUMCALLBACKW pDSEnumCallback, nint /* optional void* */ pContext);
    
    // https://learn.microsoft.com/windows/win32/DevNotes/directsoundfullduplexcreate
    [LibraryImport("DSOUND")]
    [PreserveSig]
    public static partial HRESULT DirectSoundFullDuplexCreate(nint /* optional Guid* */ pcGuidCaptureDevice, nint /* optional Guid* */ pcGuidRenderDevice, in DSCBUFFERDESC pcDSCBufferDesc, in DSBUFFERDESC pcDSBufferDesc, HWND hWnd, uint dwLevel, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDirectSoundFullDuplex>))] out IDirectSoundFullDuplex ppDSFD, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDirectSoundCaptureBuffer8>))] out IDirectSoundCaptureBuffer8 ppDSCBuffer8, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDirectSoundBuffer8>))] out IDirectSoundBuffer8 ppDSBuffer8, nint pUnkOuter);
    
    // https://learn.microsoft.com/windows/win32/api/icm/nf-icm-disassociatecolorprofilefromdevicea
    [LibraryImport("mscms", SetLastError = true)]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial BOOL DisassociateColorProfileFromDeviceA(PSTR pMachineName, PSTR pProfileName, PSTR pDeviceName);
    
    // https://learn.microsoft.com/windows/win32/api/icm/nf-icm-disassociatecolorprofilefromdevicew
    [LibraryImport("mscms", StringMarshalling = StringMarshalling.Utf16, SetLastError = true)]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial BOOL DisassociateColorProfileFromDeviceW(PWSTR pMachineName, PWSTR pProfileName, PWSTR pDeviceName);
    
    // https://learn.microsoft.com/windows/win32/api/winuser/nf-winuser-dispatchmessagew
    [LibraryImport("USER32", StringMarshalling = StringMarshalling.Utf16)]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial LRESULT DispatchMessageW(in MSG lpMsg);
    
    // https://learn.microsoft.com/windows/win32/api/winuser/nf-winuser-displayconfiggetdeviceinfo
    [LibraryImport("USER32")]
    [SupportedOSPlatform("windows6.0.6000")]
    [PreserveSig]
    public static partial int DisplayConfigGetDeviceInfo(ref DISPLAYCONFIG_DEVICE_INFO_HEADER requestPacket);
    
    // https://learn.microsoft.com/windows/win32/api/winuser/nf-winuser-displayconfigsetdeviceinfo
    [LibraryImport("USER32")]
    [SupportedOSPlatform("windows6.0.6000")]
    [PreserveSig]
    public static partial int DisplayConfigSetDeviceInfo(in DISPLAYCONFIG_DEVICE_INFO_HEADER setPacket);
    
    // https://learn.microsoft.com/windows/win32/api/dmoreg/nf-dmoreg-dmoenum
    [LibraryImport("msdmo")]
    [PreserveSig]
    public static partial HRESULT DMOEnum(in Guid guidCategory, uint dwFlags, uint cInTypes, in DMO_PARTIAL_MEDIATYPE pInTypes, uint cOutTypes, in DMO_PARTIAL_MEDIATYPE pOutTypes, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IEnumDMO>))] out IEnumDMO ppEnum);
    
    // https://learn.microsoft.com/windows/win32/api/dmoreg/nf-dmoreg-dmogetname
    [LibraryImport("msdmo")]
    [PreserveSig]
    public static partial HRESULT DMOGetName(in Guid clsidDMO, [MarshalUsing(ConstantElementCount = 80)] PWSTR szName);
    
    // https://learn.microsoft.com/windows/win32/api/dmoreg/nf-dmoreg-dmogettypes
    [LibraryImport("msdmo")]
    [PreserveSig]
    public static partial HRESULT DMOGetTypes(in Guid clsidDMO, uint ulInputTypesRequested, ref uint pulInputTypesSupplied, ref DMO_PARTIAL_MEDIATYPE pInputTypes, uint ulOutputTypesRequested, ref uint pulOutputTypesSupplied, ref DMO_PARTIAL_MEDIATYPE pOutputTypes);
    
    // https://learn.microsoft.com/windows/win32/api/dmoreg/nf-dmoreg-dmoregister
    [LibraryImport("msdmo")]
    [PreserveSig]
    public static partial HRESULT DMORegister(PWSTR szName, in Guid clsidDMO, in Guid guidCategory, uint dwFlags, uint cInTypes, in DMO_PARTIAL_MEDIATYPE pInTypes, uint cOutTypes, in DMO_PARTIAL_MEDIATYPE pOutTypes);
    
    // https://learn.microsoft.com/windows/win32/api/dmoreg/nf-dmoreg-dmounregister
    [LibraryImport("msdmo")]
    [PreserveSig]
    public static partial HRESULT DMOUnregister(in Guid clsidDMO, in Guid guidCategory);
    
    // https://learn.microsoft.com/windows/win32/api/ole2/nf-ole2-dodragdrop
    [LibraryImport("OLE32")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    public static partial HRESULT DoDragDrop([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDataObject>))] IDataObject pDataObj, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDropSource>))] IDropSource pDropSource, DROPEFFECT dwOKEffects, out DROPEFFECT pdwEffect);
    
    // https://learn.microsoft.com/windows/win32/api/shellapi/nf-shellapi-dragacceptfiles
    [LibraryImport("SHELL32")]
    [SupportedOSPlatform("windows5.1.2600")]
    [PreserveSig]
    public static partial void DragAcceptFiles(HWND hWnd, BOOL fAccept);
    
    // https://learn.microsoft.com/windows/win32/api/shellapi/nf-shellapi-dragfinish
    [LibraryImport("SHELL32")]
    [SupportedOSPlatform("windows5.1.2600")]
    [PreserveSig]
    public static partial void DragFinish(HDROP hDrop);
    
    // https://learn.microsoft.com/windows/win32/api/shellapi/nf-shellapi-dragqueryfilew
    [LibraryImport("SHELL32", StringMarshalling = StringMarshalling.Utf16)]
    [SupportedOSPlatform("windows5.1.2600")]
    [PreserveSig]
    public static partial uint DragQueryFileW(HDROP hDrop, uint iFile, [MarshalUsing(CountElementName = nameof(cch))] PWSTR lpszFile, uint cch);
    
    // https://learn.microsoft.com/windows/win32/api/shellapi/nf-shellapi-dragquerypoint
    [LibraryImport("SHELL32", SetLastError = true)]
    [SupportedOSPlatform("windows5.1.2600")]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial BOOL DragQueryPoint(HDROP hDrop, out POINT ppt);
    
    // https://learn.microsoft.com/windows/win32/api/winuser/nf-winuser-drawanimatedrects
    [LibraryImport("USER32", SetLastError = true)]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial BOOL DrawAnimatedRects(HWND hwnd, int idAni, in RECT lprcFrom, in RECT lprcTo);
    
    // https://learn.microsoft.com/windows/win32/api/winuser/nf-winuser-drawcaption
    [LibraryImport("USER32", SetLastError = true)]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial BOOL DrawCaption(HWND hwnd, HDC hdc, in RECT lprect, DRAW_CAPTION_FLAGS flags);
    
    // https://learn.microsoft.com/windows/win32/api/vfw/nf-vfw-drawdibbegin
    [LibraryImport("MSVFW32", SetLastError = true)]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial BOOL DrawDibBegin(nint hdd, HDC hdc, int dxDst, int dyDst, in BITMAPINFOHEADER lpbi, int dxSrc, int dySrc, uint wFlags);
    
    // https://learn.microsoft.com/windows/win32/api/vfw/nf-vfw-drawdibchangepalette
    [LibraryImport("MSVFW32", SetLastError = true)]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial BOOL DrawDibChangePalette(nint hdd, int iStart, int iLen, [In][MarshalUsing(CountElementName = nameof(iLen))] PALETTEENTRY[] lppe);
    
    // https://learn.microsoft.com/windows/win32/api/vfw/nf-vfw-drawdibclose
    [LibraryImport("MSVFW32", SetLastError = true)]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial BOOL DrawDibClose(nint hdd);
    
    // https://learn.microsoft.com/windows/win32/api/vfw/nf-vfw-drawdibdraw
    [LibraryImport("MSVFW32", SetLastError = true)]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial BOOL DrawDibDraw(nint hdd, HDC hdc, int xDst, int yDst, int dxDst, int dyDst, nint /* optional BITMAPINFOHEADER* */ lpbi, nint /* optional void* */ lpBits, int xSrc, int ySrc, int dxSrc, int dySrc, uint wFlags);
    
    // https://learn.microsoft.com/windows/win32/api/vfw/nf-vfw-drawdibend
    [LibraryImport("MSVFW32", SetLastError = true)]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial BOOL DrawDibEnd(nint hdd);
    
    // https://learn.microsoft.com/windows/win32/api/vfw/nf-vfw-drawdibgetbuffer
    [LibraryImport("MSVFW32")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    public static partial nint DrawDibGetBuffer(nint hdd, out BITMAPINFOHEADER lpbi, uint dwSize, uint dwFlags);
    
    // https://learn.microsoft.com/windows/win32/api/vfw/nf-vfw-drawdibgetpalette
    [LibraryImport("MSVFW32")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial HPALETTE DrawDibGetPalette(nint hdd);
    
    // https://learn.microsoft.com/windows/win32/api/vfw/nf-vfw-drawdibopen
    [LibraryImport("MSVFW32", SetLastError = true)]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    public static partial nint DrawDibOpen();
    
    // https://learn.microsoft.com/windows/win32/api/vfw/nf-vfw-drawdibprofiledisplay
    [LibraryImport("MSVFW32")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial LRESULT DrawDibProfileDisplay(in BITMAPINFOHEADER lpbi);
    
    // https://learn.microsoft.com/windows/win32/api/vfw/nf-vfw-drawdibrealize
    [LibraryImport("MSVFW32")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    public static partial uint DrawDibRealize(nint hdd, HDC hdc, BOOL fBackground);
    
    // https://learn.microsoft.com/windows/win32/api/vfw/nf-vfw-drawdibsetpalette
    [LibraryImport("MSVFW32", SetLastError = true)]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial BOOL DrawDibSetPalette(nint hdd, HPALETTE hpal);
    
    // https://learn.microsoft.com/windows/win32/api/vfw/nf-vfw-drawdibstart
    [LibraryImport("MSVFW32", SetLastError = true)]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial BOOL DrawDibStart(nint hdd, uint rate);
    
    // https://learn.microsoft.com/windows/win32/api/vfw/nf-vfw-drawdibstop
    [LibraryImport("MSVFW32", SetLastError = true)]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial BOOL DrawDibStop(nint hdd);
    
    // https://learn.microsoft.com/windows/win32/api/vfw/nf-vfw-drawdibtime
    [LibraryImport("MSVFW32", SetLastError = true)]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial BOOL DrawDibTime(nint hdd, out DRAWDIBTIME lpddtime);
    
    // https://learn.microsoft.com/windows/win32/api/winuser/nf-winuser-drawedge
    [LibraryImport("USER32", SetLastError = true)]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial BOOL DrawEdge(HDC hdc, ref RECT qrc, DRAWEDGE_FLAGS edge, DRAW_EDGE_FLAGS grfFlags);
    
    // https://learn.microsoft.com/windows/win32/api/winuser/nf-winuser-drawfocusrect
    [LibraryImport("USER32", SetLastError = true)]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial BOOL DrawFocusRect(HDC hDC, in RECT lprc);
    
    // https://learn.microsoft.com/windows/win32/api/winuser/nf-winuser-drawiconex
    [LibraryImport("USER32", SetLastError = true)]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial BOOL DrawIconEx(HDC hdc, int xLeft, int yTop, HICON hIcon, int cxWidth, int cyWidth, uint istepIfAniCur, HBRUSH hbrFlickerFreeDraw, DI_FLAGS diFlags);
    
    // https://learn.microsoft.com/windows/win32/api/mmiscapi/nf-mmiscapi-drivercallback
    [LibraryImport("WINMM", SetLastError = true)]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial BOOL DriverCallback(nuint dwCallback, uint dwFlags, HDRVR hDevice, uint dwMsg, nuint dwUser, nuint dwParam1, nuint dwParam2);
    
    // https://learn.microsoft.com/windows/win32/api/mmiscapi/nf-mmiscapi-drvgetmodulehandle
    [LibraryImport("WINMM")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial HMODULE DrvGetModuleHandle(HDRVR hDriver);
    
    // https://learn.microsoft.com/windows/win32/api/handleapi/nf-handleapi-duplicatehandle
    [LibraryImport("KERNEL32", SetLastError = true)]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial BOOL DuplicateHandle(HANDLE hSourceProcessHandle, HANDLE hSourceHandle, HANDLE hTargetProcessHandle, out HANDLE lpTargetHandle, uint dwDesiredAccess, BOOL bInheritHandle, DUPLICATE_HANDLE_OPTIONS dwOptions);
    
    // https://learn.microsoft.com/windows/win32/api/dwmapi/nf-dwmapi-dwmattachmilcontent
    [LibraryImport("dwmapi")]
    [SupportedOSPlatform("windows6.0.6000")]
    [PreserveSig]
    public static partial HRESULT DwmAttachMilContent(HWND hwnd);
    
    // https://learn.microsoft.com/windows/win32/api/dwmapi/nf-dwmapi-dwmdefwindowproc
    [LibraryImport("dwmapi", SetLastError = true)]
    [SupportedOSPlatform("windows6.0.6000")]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial BOOL DwmDefWindowProc(HWND hWnd, uint msg, WPARAM wParam, LPARAM lParam, out LRESULT plResult);
    
    // https://learn.microsoft.com/windows/win32/api/dwmapi/nf-dwmapi-dwmdetachmilcontent
    [LibraryImport("dwmapi")]
    [SupportedOSPlatform("windows6.0.6000")]
    [PreserveSig]
    public static partial HRESULT DwmDetachMilContent(HWND hwnd);
    
    // https://learn.microsoft.com/windows/win32/api/dwmapi/nf-dwmapi-dwmenableblurbehindwindow
    [LibraryImport("dwmapi")]
    [SupportedOSPlatform("windows6.0.6000")]
    [PreserveSig]
    public static partial HRESULT DwmEnableBlurBehindWindow(HWND hWnd, in DWM_BLURBEHIND pBlurBehind);
    
    // https://learn.microsoft.com/windows/win32/api/dwmapi/nf-dwmapi-dwmenablecomposition
    [LibraryImport("dwmapi")]
    [SupportedOSPlatform("windows6.0.6000")]
    [PreserveSig]
    public static partial HRESULT DwmEnableComposition(uint uCompositionAction);
    
    // https://learn.microsoft.com/windows/win32/api/dwmapi/nf-dwmapi-dwmenablemmcss
    [LibraryImport("dwmapi")]
    [SupportedOSPlatform("windows6.0.6000")]
    [PreserveSig]
    public static partial HRESULT DwmEnableMMCSS(BOOL fEnableMMCSS);
    
    // https://learn.microsoft.com/windows/win32/api/dwmapi/nf-dwmapi-dwmextendframeintoclientarea
    [LibraryImport("dwmapi")]
    [SupportedOSPlatform("windows6.0.6000")]
    [PreserveSig]
    public static partial HRESULT DwmExtendFrameIntoClientArea(HWND hWnd, in MARGINS pMarInset);
    
    // https://learn.microsoft.com/windows/win32/api/dwmapi/nf-dwmapi-dwmflush
    [LibraryImport("dwmapi")]
    [SupportedOSPlatform("windows6.0.6000")]
    [PreserveSig]
    public static partial HRESULT DwmFlush();
    
    // https://learn.microsoft.com/windows/win32/api/dwmapi/nf-dwmapi-dwmgetcolorizationcolor
    [LibraryImport("dwmapi")]
    [SupportedOSPlatform("windows6.0.6000")]
    [PreserveSig]
    public static partial HRESULT DwmGetColorizationColor(out uint pcrColorization, out BOOL pfOpaqueBlend);
    
    // https://learn.microsoft.com/windows/win32/api/dwmapi/nf-dwmapi-dwmgetcompositiontiminginfo
    [LibraryImport("dwmapi")]
    [SupportedOSPlatform("windows6.0.6000")]
    [PreserveSig]
    public static partial HRESULT DwmGetCompositionTimingInfo(HWND hwnd, out DWM_TIMING_INFO pTimingInfo);
    
    // https://learn.microsoft.com/windows/win32/api/dwmapi/nf-dwmapi-dwmgetgraphicsstreamclient
    [LibraryImport("dwmapi")]
    [SupportedOSPlatform("windows6.0.6000")]
    [PreserveSig]
    public static partial HRESULT DwmGetGraphicsStreamClient(uint uIndex, out Guid pClientUuid);
    
    // https://learn.microsoft.com/windows/win32/api/dwmapi/nf-dwmapi-dwmgetgraphicsstreamtransformhint
    [LibraryImport("dwmapi")]
    [SupportedOSPlatform("windows6.0.6000")]
    [PreserveSig]
    public static partial HRESULT DwmGetGraphicsStreamTransformHint(uint uIndex, out MilMatrix3x2D pTransform);
    
    // https://learn.microsoft.com/windows/win32/api/dwmapi/nf-dwmapi-dwmgettransportattributes
    [LibraryImport("dwmapi")]
    [SupportedOSPlatform("windows6.0.6000")]
    [PreserveSig]
    public static partial HRESULT DwmGetTransportAttributes(out BOOL pfIsRemoting, out BOOL pfIsConnected, out uint pDwGeneration);
    
    // https://learn.microsoft.com/windows/win32/api/dwmapi/nf-dwmapi-dwmgetunmettabrequirements
    [LibraryImport("dwmapi")]
    [SupportedOSPlatform("windows10.0.17134")]
    [PreserveSig]
    public static partial HRESULT DwmGetUnmetTabRequirements(HWND appWindow, out DWM_TAB_WINDOW_REQUIREMENTS value);
    
    // https://learn.microsoft.com/windows/win32/api/dwmapi/nf-dwmapi-dwmgetwindowattribute
    [LibraryImport("dwmapi")]
    [SupportedOSPlatform("windows6.0.6000")]
    [PreserveSig]
    public static partial HRESULT DwmGetWindowAttribute(HWND hwnd, uint dwAttribute, nint pvAttribute, uint cbAttribute);
    
    // https://learn.microsoft.com/windows/win32/api/dwmapi/nf-dwmapi-dwminvalidateiconicbitmaps
    [LibraryImport("dwmapi")]
    [SupportedOSPlatform("windows6.1")]
    [PreserveSig]
    public static partial HRESULT DwmInvalidateIconicBitmaps(HWND hwnd);
    
    // https://learn.microsoft.com/windows/win32/api/dwmapi/nf-dwmapi-dwmiscompositionenabled
    [LibraryImport("dwmapi")]
    [SupportedOSPlatform("windows6.0.6000")]
    [PreserveSig]
    public static partial HRESULT DwmIsCompositionEnabled(out BOOL pfEnabled);
    
    // https://learn.microsoft.com/windows/win32/api/dwmapi/nf-dwmapi-dwmmodifypreviousdxframeduration
    [LibraryImport("dwmapi")]
    [SupportedOSPlatform("windows6.0.6000")]
    [PreserveSig]
    public static partial HRESULT DwmModifyPreviousDxFrameDuration(HWND hwnd, int cRefreshes, BOOL fRelative);
    
    // https://learn.microsoft.com/windows/win32/api/dwmapi/nf-dwmapi-dwmquerythumbnailsourcesize
    [LibraryImport("dwmapi")]
    [SupportedOSPlatform("windows6.0.6000")]
    [PreserveSig]
    public static partial HRESULT DwmQueryThumbnailSourceSize(nint hThumbnail, out SIZE pSize);
    
    // https://learn.microsoft.com/windows/win32/api/dwmapi/nf-dwmapi-dwmregisterthumbnail
    [LibraryImport("dwmapi")]
    [SupportedOSPlatform("windows6.0.6000")]
    [PreserveSig]
    public static partial HRESULT DwmRegisterThumbnail(HWND hwndDestination, HWND hwndSource, out nint phThumbnailId);
    
    // https://learn.microsoft.com/windows/win32/api/dwmapi/nf-dwmapi-dwmrendergesture
    [LibraryImport("dwmapi")]
    [SupportedOSPlatform("windows8.0")]
    [PreserveSig]
    public static partial HRESULT DwmRenderGesture(GESTURE_TYPE gt, uint cContacts, [In][MarshalUsing(CountElementName = nameof(cContacts))] uint[] pdwPointerID, [In][MarshalUsing(CountElementName = nameof(cContacts))] POINT[] pPoints);
    
    // https://learn.microsoft.com/windows/win32/api/dwmapi/nf-dwmapi-dwmsetdxframeduration
    [LibraryImport("dwmapi")]
    [SupportedOSPlatform("windows6.0.6000")]
    [PreserveSig]
    public static partial HRESULT DwmSetDxFrameDuration(HWND hwnd, int cRefreshes);
    
    // https://learn.microsoft.com/windows/win32/api/dwmapi/nf-dwmapi-dwmseticoniclivepreviewbitmap
    [LibraryImport("dwmapi")]
    [SupportedOSPlatform("windows6.1")]
    [PreserveSig]
    public static partial HRESULT DwmSetIconicLivePreviewBitmap(HWND hwnd, HBITMAP hbmp, nint /* optional POINT* */ pptClient, uint dwSITFlags);
    
    // https://learn.microsoft.com/windows/win32/api/dwmapi/nf-dwmapi-dwmseticonicthumbnail
    [LibraryImport("dwmapi")]
    [SupportedOSPlatform("windows6.1")]
    [PreserveSig]
    public static partial HRESULT DwmSetIconicThumbnail(HWND hwnd, HBITMAP hbmp, uint dwSITFlags);
    
    // https://learn.microsoft.com/windows/win32/api/dwmapi/nf-dwmapi-dwmsetpresentparameters
    [LibraryImport("dwmapi")]
    [SupportedOSPlatform("windows6.0.6000")]
    [PreserveSig]
    public static partial HRESULT DwmSetPresentParameters(HWND hwnd, ref DWM_PRESENT_PARAMETERS pPresentParams);
    
    // https://learn.microsoft.com/windows/win32/api/dwmapi/nf-dwmapi-dwmsetwindowattribute
    [LibraryImport("dwmapi")]
    [SupportedOSPlatform("windows6.0.6000")]
    [PreserveSig]
    public static partial HRESULT DwmSetWindowAttribute(HWND hwnd, uint dwAttribute, nint pvAttribute, uint cbAttribute);
    
    // https://learn.microsoft.com/windows/win32/api/dwmapi/nf-dwmapi-dwmshowcontact
    [LibraryImport("dwmapi")]
    [SupportedOSPlatform("windows8.0")]
    [PreserveSig]
    public static partial HRESULT DwmShowContact(uint dwPointerID, DWM_SHOWCONTACT eShowContact);
    
    // https://learn.microsoft.com/windows/win32/api/dwmapi/nf-dwmapi-dwmtethercontact
    [LibraryImport("dwmapi")]
    [SupportedOSPlatform("windows8.0")]
    [PreserveSig]
    public static partial HRESULT DwmTetherContact(uint dwPointerID, BOOL fEnable, POINT ptTether);
    
    // https://learn.microsoft.com/windows/win32/api/dwmapi/nf-dwmapi-dwmtransitionownedwindow
    [LibraryImport("dwmapi")]
    [SupportedOSPlatform("windows8.0")]
    [PreserveSig]
    public static partial HRESULT DwmTransitionOwnedWindow(HWND hwnd, DWMTRANSITION_OWNEDWINDOW_TARGET target);
    
    // https://learn.microsoft.com/windows/win32/api/dwmapi/nf-dwmapi-dwmunregisterthumbnail
    [LibraryImport("dwmapi")]
    [SupportedOSPlatform("windows6.0.6000")]
    [PreserveSig]
    public static partial HRESULT DwmUnregisterThumbnail(nint hThumbnailId);
    
    // https://learn.microsoft.com/windows/win32/api/dwmapi/nf-dwmapi-dwmupdatethumbnailproperties
    [LibraryImport("dwmapi")]
    [SupportedOSPlatform("windows6.0.6000")]
    [PreserveSig]
    public static partial HRESULT DwmUpdateThumbnailProperties(nint hThumbnailId, in DWM_THUMBNAIL_PROPERTIES ptnProperties);
    
    // https://learn.microsoft.com/windows/win32/api/dwrite/nf-dwrite-dwritecreatefactory
    [LibraryImport("DWrite")]
    [SupportedOSPlatform("windows6.1")]
    [PreserveSig]
    public static partial HRESULT DWriteCreateFactory(DWRITE_FACTORY_TYPE factoryType, in Guid iid, out nint /* void */ factory);
    
    [LibraryImport("dxcompiler")]
    [PreserveSig]
    public static partial HRESULT DxcCreateInstance(in Guid rclsid, in Guid riid, out nint /* void */ ppv);
    
    [LibraryImport("dxcompiler")]
    [PreserveSig]
    public static partial HRESULT DxcCreateInstance2([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMalloc>))] IMalloc pMalloc, in Guid rclsid, in Guid riid, out nint /* void */ ppv);
    
    // https://learn.microsoft.com/windows/win32/dxcore/dxcore/nf-dxcore-dxcorecreateadapterfactory
    [LibraryImport("DXCORE")]
    [PreserveSig]
    public static partial HRESULT DXCoreCreateAdapterFactory(in Guid riid, out nint /* void */ ppvFactory);
    
    // https://learn.microsoft.com/windows/win32/api/dxgi1_6/nf-dxgi1_6-dxgideclareadapterremovalsupport
    [LibraryImport("dxgi")]
    [SupportedOSPlatform("windows10.0.17134")]
    [PreserveSig]
    public static partial HRESULT DXGIDeclareAdapterRemovalSupport();
    
    // https://learn.microsoft.com/windows/win32/api/dxgi1_6/nf-dxgi1_6-dxgidisablevblankvirtualization
    [LibraryImport("dxgi")]
    [PreserveSig]
    public static partial HRESULT DXGIDisableVBlankVirtualization();
    
    // https://learn.microsoft.com/windows/win32/api/dxgi1_3/nf-dxgi1_3-dxgigetdebuginterface1
    [LibraryImport("dxgi")]
    [SupportedOSPlatform("windows8.1")]
    [PreserveSig]
    public static partial HRESULT DXGIGetDebugInterface1(uint Flags, in Guid riid, out nint /* void */ pDebug);
    
    // https://learn.microsoft.com/windows/win32/api/dxva2api/nf-dxva2api-dxva2createdirect3ddevicemanager9
    [LibraryImport("dxva2")]
    [SupportedOSPlatform("windows6.0.6000")]
    [PreserveSig]
    public static partial HRESULT DXVA2CreateDirect3DDeviceManager9(out uint pResetToken, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDirect3DDeviceManager9>))] out IDirect3DDeviceManager9 ppDeviceManager);
    
    // https://learn.microsoft.com/windows/win32/api/dxva2api/nf-dxva2api-dxva2createvideoservice
    [LibraryImport("dxva2")]
    [SupportedOSPlatform("windows6.0.6000")]
    [PreserveSig]
    public static partial HRESULT DXVA2CreateVideoService([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDirect3DDevice9>))] IDirect3DDevice9 pDD, in Guid riid, out nint ppService);
    
    // https://learn.microsoft.com/windows/win32/api/dxvahd/nf-dxvahd-dxvahd_createdevice
    [LibraryImport("dxva2")]
    [SupportedOSPlatform("windows6.1")]
    [PreserveSig]
    public static partial HRESULT DXVAHD_CreateDevice([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDirect3DDevice9Ex>))] IDirect3DDevice9Ex pD3DDevice, in DXVAHD_CONTENT_DESC pContentDesc, DXVAHD_DEVICE_USAGE Usage, PDXVAHDSW_Plugin? pPlugin, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDXVAHD_Device>))] out IDXVAHD_Device ppDevice);
    
    // https://learn.microsoft.com/windows/win32/api/vfw/nf-vfw-editstreamclone
    [LibraryImport("AVIFIL32")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    public static partial HRESULT EditStreamClone([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IAVIStream>))] IAVIStream pavi, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IAVIStream>))] out IAVIStream ppResult);
    
    // https://learn.microsoft.com/windows/win32/api/vfw/nf-vfw-editstreamcopy
    [LibraryImport("AVIFIL32")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    public static partial HRESULT EditStreamCopy([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IAVIStream>))] IAVIStream pavi, ref int plStart, ref int plLength, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IAVIStream>))] out IAVIStream ppResult);
    
    // https://learn.microsoft.com/windows/win32/api/vfw/nf-vfw-editstreamcut
    [LibraryImport("AVIFIL32")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    public static partial HRESULT EditStreamCut([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IAVIStream>))] IAVIStream pavi, ref int plStart, ref int plLength, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IAVIStream>))] out IAVIStream ppResult);
    
    // https://learn.microsoft.com/windows/win32/api/vfw/nf-vfw-editstreampaste
    [LibraryImport("AVIFIL32")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    public static partial HRESULT EditStreamPaste([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IAVIStream>))] IAVIStream pavi, ref int plPos, ref int plLength, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IAVIStream>))] IAVIStream pstream, int lStart, int lEnd);
    
    // https://learn.microsoft.com/windows/win32/api/vfw/nf-vfw-editstreamsetinfoa
    [LibraryImport("AVIFIL32")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    public static partial HRESULT EditStreamSetInfoA([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IAVIStream>))] IAVIStream pavi, in AVISTREAMINFOA lpInfo, int cbInfo);
    
    // https://learn.microsoft.com/windows/win32/api/vfw/nf-vfw-editstreamsetinfow
    [LibraryImport("AVIFIL32", StringMarshalling = StringMarshalling.Utf16)]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    public static partial HRESULT EditStreamSetInfoW([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IAVIStream>))] IAVIStream pavi, in AVISTREAMINFOW lpInfo, int cbInfo);
    
    // https://learn.microsoft.com/windows/win32/api/vfw/nf-vfw-editstreamsetnamea
    [LibraryImport("AVIFIL32")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    public static partial HRESULT EditStreamSetNameA([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IAVIStream>))] IAVIStream pavi, PSTR lpszName);
    
    // https://learn.microsoft.com/windows/win32/api/vfw/nf-vfw-editstreamsetnamew
    [LibraryImport("AVIFIL32", StringMarshalling = StringMarshalling.Utf16)]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    public static partial HRESULT EditStreamSetNameW([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IAVIStream>))] IAVIStream pavi, PWSTR lpszName);
    
    // https://learn.microsoft.com/windows/win32/api/d2d1helper/nf-d2d1helper-ellipse
    [LibraryImport("GDI32", SetLastError = true)]
    [SupportedOSPlatform("windows6.1")]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial BOOL Ellipse(HDC hdc, int left, int top, int right, int bottom);
    
    // https://learn.microsoft.com/windows/win32/api/winuser/nf-winuser-emptyclipboard
    [LibraryImport("USER32", SetLastError = true)]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial BOOL EmptyClipboard();
    
    // https://learn.microsoft.com/windows/win32/api/winuser/nf-winuser-enablemouseinpointer
    [LibraryImport("USER32", SetLastError = true)]
    [SupportedOSPlatform("windows8.0")]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial BOOL EnableMouseInPointer(BOOL fEnable);
    
    // https://learn.microsoft.com/windows/win32/api/winuser/nf-winuser-enablenonclientdpiscaling
    [LibraryImport("USER32", SetLastError = true)]
    [SupportedOSPlatform("windows10.0.14393")]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial BOOL EnableNonClientDpiScaling(HWND hwnd);
    
    // https://learn.microsoft.com/windows/win32/api/winuser/nf-winuser-enablewindow
    [LibraryImport("USER32", SetLastError = true)]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial BOOL EnableWindow(HWND hWnd, BOOL bEnable);
    
    // https://learn.microsoft.com/windows/win32/api/wingdi/nf-wingdi-enddoc
    [LibraryImport("GDI32")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    public static partial int EndDoc(HDC hdc);
    
    // https://learn.microsoft.com/windows/win32/api/wingdi/nf-wingdi-endpage
    [LibraryImport("GDI32")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    public static partial int EndPage(HDC hdc);
    
    // https://learn.microsoft.com/windows/win32/api/winuser/nf-winuser-endpaint
    [LibraryImport("USER32", SetLastError = true)]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial BOOL EndPaint(HWND hWnd, in PAINTSTRUCT lpPaint);
    
    // https://learn.microsoft.com/windows/win32/api/winbase/nf-winbase-endupdateresourcew
    [LibraryImport("KERNEL32", StringMarshalling = StringMarshalling.Utf16, SetLastError = true)]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial BOOL EndUpdateResourceW(HANDLE hUpdate, BOOL fDiscard);
    
    // https://learn.microsoft.com/windows/win32/api/winddi/nf-winddi-engacquiresemaphore
    [LibraryImport("GDI32")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    public static partial void EngAcquireSemaphore(HSEMAPHORE hsem);
    
    // https://learn.microsoft.com/windows/win32/api/winddi/nf-winddi-engalphablend
    [LibraryImport("GDI32", SetLastError = true)]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial BOOL EngAlphaBlend(ref SURFOBJ psoDest, ref SURFOBJ psoSrc, ref CLIPOBJ pco, ref XLATEOBJ pxlo, ref RECTL prclDest, ref RECTL prclSrc, ref BLENDOBJ pBlendObj);
    
    // https://learn.microsoft.com/windows/win32/api/winddi/nf-winddi-engassociatesurface
    [LibraryImport("GDI32", SetLastError = true)]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial BOOL EngAssociateSurface(HSURF hsurf, HDEV hdev, uint flHooks);
    
    // https://learn.microsoft.com/windows/win32/api/winddi/nf-winddi-engbitblt
    [LibraryImport("GDI32", SetLastError = true)]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial BOOL EngBitBlt(in SURFOBJ psoTrg, in SURFOBJ psoSrc, in SURFOBJ psoMask, in CLIPOBJ pco, in XLATEOBJ pxlo, in RECTL prclTrg, in POINTL pptlSrc, in POINTL pptlMask, in BRUSHOBJ pbo, in POINTL pptlBrush, uint rop4);
    
    // https://learn.microsoft.com/windows/win32/api/winddi/nf-winddi-engcheckabort
    [LibraryImport("GDI32", SetLastError = true)]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial BOOL EngCheckAbort(ref SURFOBJ pso);
    
    // https://learn.microsoft.com/windows/win32/api/winddi/nf-winddi-engcomputeglyphset
    [LibraryImport("GDI32")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    public static partial nint EngComputeGlyphSet(int nCodePage, int nFirstChar, int cChars);
    
    // https://learn.microsoft.com/windows/win32/api/winddi/nf-winddi-engcopybits
    [LibraryImport("GDI32", SetLastError = true)]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial BOOL EngCopyBits(ref SURFOBJ psoDest, ref SURFOBJ psoSrc, ref CLIPOBJ pco, ref XLATEOBJ pxlo, ref RECTL prclDest, ref POINTL pptlSrc);
    
    // https://learn.microsoft.com/windows/win32/api/winddi/nf-winddi-engcreatebitmap
    [LibraryImport("GDI32")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial HBITMAP EngCreateBitmap(SIZE sizl, int lWidth, uint iFormat, uint fl, nint pvBits);
    
    // https://learn.microsoft.com/windows/win32/api/winddi/nf-winddi-engcreateclip
    [LibraryImport("GDI32")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    public static partial nint EngCreateClip();
    
    // https://learn.microsoft.com/windows/win32/api/winddi/nf-winddi-engcreatedevicebitmap
    [LibraryImport("GDI32")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial HBITMAP EngCreateDeviceBitmap(DHSURF dhsurf, SIZE sizl, uint iFormatCompat);
    
    // https://learn.microsoft.com/windows/win32/api/winddi/nf-winddi-engcreatedevicesurface
    [LibraryImport("GDI32")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial HSURF EngCreateDeviceSurface(DHSURF dhsurf, SIZE sizl, uint iFormatCompat);
    
    // https://learn.microsoft.com/windows/win32/api/winddi/nf-winddi-engcreatepalette
    [LibraryImport("GDI32")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial HPALETTE EngCreatePalette(uint iMode, uint cColors, ref uint pulColors, uint flRed, uint flGreen, uint flBlue);
    
    // https://learn.microsoft.com/windows/win32/api/winddi/nf-winddi-engcreatesemaphore
    [LibraryImport("GDI32")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial HSEMAPHORE EngCreateSemaphore();
    
    // https://learn.microsoft.com/windows/win32/api/winddi/nf-winddi-engdeleteclip
    [LibraryImport("GDI32")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    public static partial void EngDeleteClip(nint /* optional CLIPOBJ* */ pco);
    
    // https://learn.microsoft.com/windows/win32/api/winddi/nf-winddi-engdeletepalette
    [LibraryImport("GDI32", SetLastError = true)]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial BOOL EngDeletePalette(HPALETTE hpal);
    
    // https://learn.microsoft.com/windows/win32/api/winddi/nf-winddi-engdeletepath
    [LibraryImport("GDI32")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    public static partial void EngDeletePath(ref PATHOBJ ppo);
    
    // https://learn.microsoft.com/windows/win32/api/winddi/nf-winddi-engdeletesemaphore
    [LibraryImport("GDI32")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    public static partial void EngDeleteSemaphore(HSEMAPHORE hsem);
    
    // https://learn.microsoft.com/windows/win32/api/winddi/nf-winddi-engdeletesurface
    [LibraryImport("GDI32", SetLastError = true)]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial BOOL EngDeleteSurface(HSURF hsurf);
    
    // https://learn.microsoft.com/windows/win32/api/winddi/nf-winddi-engerasesurface
    [LibraryImport("GDI32", SetLastError = true)]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial BOOL EngEraseSurface(ref SURFOBJ pso, ref RECTL prcl, uint iColor);
    
    // https://learn.microsoft.com/windows/win32/api/winddi/nf-winddi-engfillpath
    [LibraryImport("GDI32", SetLastError = true)]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial BOOL EngFillPath(ref SURFOBJ pso, ref PATHOBJ ppo, ref CLIPOBJ pco, ref BRUSHOBJ pbo, ref POINTL pptlBrushOrg, uint mix, uint flOptions);
    
    // https://learn.microsoft.com/windows/win32/api/winddi/nf-winddi-engfindresource
    [LibraryImport("GDI32")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    public static partial nint EngFindResource(HANDLE h, int iName, int iType, out uint pulSize);
    
    // https://learn.microsoft.com/windows/win32/api/winddi/nf-winddi-engfreemodule
    [LibraryImport("GDI32")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    public static partial void EngFreeModule(HANDLE h);
    
    // https://learn.microsoft.com/windows/win32/api/winddi/nf-winddi-enggetcurrentcodepage
    [LibraryImport("GDI32")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    public static partial void EngGetCurrentCodePage(out ushort OemCodePage, out ushort AnsiCodePage);
    
    // https://learn.microsoft.com/windows/win32/api/winddi/nf-winddi-enggetdrivername
    [LibraryImport("GDI32")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial PWSTR EngGetDriverName(HDEV hdev);
    
    // https://learn.microsoft.com/windows/win32/api/winddi/nf-winddi-enggetprinterdatafilename
    [LibraryImport("GDI32")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial PWSTR EngGetPrinterDataFileName(HDEV hdev);
    
    // https://learn.microsoft.com/windows/win32/api/winddi/nf-winddi-enggradientfill
    [LibraryImport("GDI32", SetLastError = true)]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial BOOL EngGradientFill(ref SURFOBJ psoDest, ref CLIPOBJ pco, ref XLATEOBJ pxlo, ref TRIVERTEX pVertex, uint nVertex, nint pMesh, uint nMesh, ref RECTL prclExtents, ref POINTL pptlDitherOrg, uint ulMode);
    
    // https://learn.microsoft.com/windows/win32/api/winddi/nf-winddi-englineto
    [LibraryImport("GDI32", SetLastError = true)]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial BOOL EngLineTo(ref SURFOBJ pso, ref CLIPOBJ pco, ref BRUSHOBJ pbo, int x1, int y1, int x2, int y2, ref RECTL prclBounds, uint mix);
    
    // https://learn.microsoft.com/windows/win32/api/winddi/nf-winddi-engloadmodule
    [LibraryImport("GDI32")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial HANDLE EngLoadModule(PWSTR pwsz);
    
    // https://learn.microsoft.com/windows/win32/api/winddi/nf-winddi-englocksurface
    [LibraryImport("GDI32")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    public static partial nint EngLockSurface(HSURF hsurf);
    
    // https://learn.microsoft.com/windows/win32/api/winddi/nf-winddi-engmarkbandingsurface
    [LibraryImport("GDI32", SetLastError = true)]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial BOOL EngMarkBandingSurface(HSURF hsurf);
    
    // https://learn.microsoft.com/windows/win32/api/winddi/nf-winddi-engmultibytetounicoden
    [LibraryImport("GDI32")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    public static partial void EngMultiByteToUnicodeN(PWSTR UnicodeString, uint MaxBytesInUnicodeString, nint /* optional uint* */ BytesInUnicodeString, PSTR MultiByteString, uint BytesInMultiByteString);
    
    // https://learn.microsoft.com/windows/win32/api/winddi/nf-winddi-engmultibytetowidechar
    [LibraryImport("GDI32")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    public static partial int EngMultiByteToWideChar(uint CodePage, PWSTR WideCharString, int BytesInWideCharString, PSTR MultiByteString, int BytesInMultiByteString);
    
    // https://learn.microsoft.com/windows/win32/api/winddi/nf-winddi-engpaint
    [LibraryImport("GDI32", SetLastError = true)]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial BOOL EngPaint(ref SURFOBJ pso, ref CLIPOBJ pco, ref BRUSHOBJ pbo, ref POINTL pptlBrushOrg, uint mix);
    
    // https://learn.microsoft.com/windows/win32/api/winddi/nf-winddi-engplgblt
    [LibraryImport("GDI32", SetLastError = true)]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial BOOL EngPlgBlt(ref SURFOBJ psoTrg, ref SURFOBJ psoSrc, ref SURFOBJ psoMsk, ref CLIPOBJ pco, ref XLATEOBJ pxlo, ref COLORADJUSTMENT pca, ref POINTL pptlBrushOrg, ref POINTFIX pptfx, ref RECTL prcl, ref POINTL pptl, uint iMode);
    
    [LibraryImport("GDI32", SetLastError = true)]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial BOOL EngQueryEMFInfo(HDEV hdev, out EMFINFO pEMFInfo);
    
    // https://learn.microsoft.com/windows/win32/api/winddi/nf-winddi-engquerylocaltime
    [LibraryImport("GDI32")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    public static partial void EngQueryLocalTime(out ENG_TIME_FIELDS param0);
    
    // https://learn.microsoft.com/windows/win32/api/winddi/nf-winddi-engreleasesemaphore
    [LibraryImport("GDI32")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    public static partial void EngReleaseSemaphore(HSEMAPHORE hsem);
    
    // https://learn.microsoft.com/windows/win32/api/winddi/nf-winddi-engstretchblt
    [LibraryImport("GDI32", SetLastError = true)]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial BOOL EngStretchBlt(ref SURFOBJ psoDest, ref SURFOBJ psoSrc, ref SURFOBJ psoMask, ref CLIPOBJ pco, ref XLATEOBJ pxlo, ref COLORADJUSTMENT pca, ref POINTL pptlHTOrg, ref RECTL prclDest, ref RECTL prclSrc, ref POINTL pptlMask, uint iMode);
    
    // https://learn.microsoft.com/windows/win32/api/winddi/nf-winddi-engstretchbltrop
    [LibraryImport("GDI32", SetLastError = true)]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial BOOL EngStretchBltROP(ref SURFOBJ psoDest, ref SURFOBJ psoSrc, ref SURFOBJ psoMask, ref CLIPOBJ pco, ref XLATEOBJ pxlo, ref COLORADJUSTMENT pca, ref POINTL pptlHTOrg, ref RECTL prclDest, ref RECTL prclSrc, ref POINTL pptlMask, uint iMode, ref BRUSHOBJ pbo, uint rop4);
    
    // https://learn.microsoft.com/windows/win32/api/winddi/nf-winddi-engstrokeandfillpath
    [LibraryImport("GDI32", SetLastError = true)]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial BOOL EngStrokeAndFillPath(ref SURFOBJ pso, ref PATHOBJ ppo, ref CLIPOBJ pco, ref XFORMOBJ pxo, ref BRUSHOBJ pboStroke, ref LINEATTRS plineattrs, ref BRUSHOBJ pboFill, ref POINTL pptlBrushOrg, uint mixFill, uint flOptions);
    
    // https://learn.microsoft.com/windows/win32/api/winddi/nf-winddi-engstrokepath
    [LibraryImport("GDI32", SetLastError = true)]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial BOOL EngStrokePath(ref SURFOBJ pso, ref PATHOBJ ppo, ref CLIPOBJ pco, ref XFORMOBJ pxo, ref BRUSHOBJ pbo, ref POINTL pptlBrushOrg, ref LINEATTRS plineattrs, uint mix);
    
    // https://learn.microsoft.com/windows/win32/api/winddi/nf-winddi-engtextout
    [LibraryImport("GDI32", SetLastError = true)]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial BOOL EngTextOut(ref SURFOBJ pso, ref STROBJ pstro, ref FONTOBJ pfo, ref CLIPOBJ pco, ref RECTL prclExtra, ref RECTL prclOpaque, ref BRUSHOBJ pboFore, ref BRUSHOBJ pboOpaque, ref POINTL pptlOrg, uint mix);
    
    // https://learn.microsoft.com/windows/win32/api/winddi/nf-winddi-engtransparentblt
    [LibraryImport("GDI32", SetLastError = true)]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial BOOL EngTransparentBlt(in SURFOBJ psoDst, in SURFOBJ psoSrc, nint /* optional CLIPOBJ* */ pco, nint /* optional XLATEOBJ* */ pxlo, in RECTL prclDst, in RECTL prclSrc, uint TransColor, uint bCalledFromBitBlt);
    
    // https://learn.microsoft.com/windows/win32/api/winddi/nf-winddi-engunicodetomultibyten
    [LibraryImport("GDI32")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    public static partial void EngUnicodeToMultiByteN(PSTR MultiByteString, uint MaxBytesInMultiByteString, nint /* optional uint* */ BytesInMultiByteString, PWSTR UnicodeString, uint BytesInUnicodeString);
    
    // https://learn.microsoft.com/windows/win32/api/winddi/nf-winddi-engunlocksurface
    [LibraryImport("GDI32")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    public static partial void EngUnlockSurface(ref SURFOBJ pso);
    
    // https://learn.microsoft.com/windows/win32/api/winddi/nf-winddi-engwidechartomultibyte
    [LibraryImport("GDI32")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    public static partial int EngWideCharToMultiByte(uint CodePage, PWSTR WideCharString, int BytesInWideCharString, PSTR MultiByteString, int BytesInMultiByteString);
    
    // https://learn.microsoft.com/windows/win32/api/winuser/nf-winuser-enumchildwindows
    [LibraryImport("USER32", SetLastError = true)]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial BOOL EnumChildWindows(HWND hWndParent, WNDENUMPROC lpEnumFunc, LPARAM lParam);
    
    // https://learn.microsoft.com/windows/win32/api/winuser/nf-winuser-enumclipboardformats
    [LibraryImport("USER32", SetLastError = true)]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    public static partial uint EnumClipboardFormats(uint format);
    
    // https://learn.microsoft.com/windows/win32/api/icm/nf-icm-enumcolorprofilesa
    [LibraryImport("mscms", SetLastError = true)]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial BOOL EnumColorProfilesA(PSTR pMachineName, in ENUMTYPEA pEnumRecord, nint /* optional byte* */ pEnumerationBuffer, ref uint pdwSizeOfEnumerationBuffer, nint /* optional uint* */ pnProfiles);
    
    // https://learn.microsoft.com/windows/win32/api/icm/nf-icm-enumcolorprofilesw
    [LibraryImport("mscms", StringMarshalling = StringMarshalling.Utf16, SetLastError = true)]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial BOOL EnumColorProfilesW(PWSTR pMachineName, in ENUMTYPEW pEnumRecord, nint /* optional byte* */ pEnumerationBuffer, ref uint pdwSizeOfEnumerationBuffer, nint /* optional uint* */ pnProfiles);
    
    // https://learn.microsoft.com/windows/win32/api/winuser/nf-winuser-enumdisplaydevicesw
    [LibraryImport("USER32", StringMarshalling = StringMarshalling.Utf16, SetLastError = true)]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial BOOL EnumDisplayDevicesW(PWSTR lpDevice, uint iDevNum, ref DISPLAY_DEVICEW lpDisplayDevice, uint dwFlags);
    
    // https://learn.microsoft.com/windows/win32/api/winuser/nf-winuser-enumdisplaymonitors
    [LibraryImport("USER32", SetLastError = true)]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial BOOL EnumDisplayMonitors(HDC hdc, nint /* optional RECT* */ lprcClip, MONITORENUMPROC lpfnEnum, LPARAM dwData);
    
    // https://learn.microsoft.com/windows/win32/api/winuser/nf-winuser-enumdisplaysettingsexw
    [LibraryImport("USER32", StringMarshalling = StringMarshalling.Utf16, SetLastError = true)]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial BOOL EnumDisplaySettingsExW(PWSTR lpszDeviceName, ENUM_DISPLAY_SETTINGS_MODE iModeNum, ref DEVMODEW lpDevMode, ENUM_DISPLAY_SETTINGS_FLAGS dwFlags);
    
    // https://learn.microsoft.com/windows/win32/api/winuser/nf-winuser-enumdisplaysettingsw
    [LibraryImport("USER32", StringMarshalling = StringMarshalling.Utf16, SetLastError = true)]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial BOOL EnumDisplaySettingsW(PWSTR lpszDeviceName, ENUM_DISPLAY_SETTINGS_MODE iModeNum, ref DEVMODEW lpDevMode);
    
    // https://learn.microsoft.com/windows/win32/api/wingdi/nf-wingdi-enumicmprofilesa
    [LibraryImport("GDI32")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    public static partial int EnumICMProfilesA(HDC hdc, ICMENUMPROCA proc, LPARAM param2);
    
    // https://learn.microsoft.com/windows/win32/api/wingdi/nf-wingdi-enumicmprofilesw
    [LibraryImport("GDI32", StringMarshalling = StringMarshalling.Utf16)]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    public static partial int EnumICMProfilesW(HDC hdc, ICMENUMPROCW proc, LPARAM param2);
    
    // https://learn.microsoft.com/windows/win32/api/winuser/nf-winuser-enumpropsw
    [LibraryImport("USER32", StringMarshalling = StringMarshalling.Utf16)]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    public static partial int EnumPropsW(HWND hWnd, PROPENUMPROCW lpEnumFunc);
    
    // https://learn.microsoft.com/windows/win32/api/libloaderapi/nf-libloaderapi-enumresourcelanguagesexw
    [LibraryImport("KERNEL32", StringMarshalling = StringMarshalling.Utf16, SetLastError = true)]
    [SupportedOSPlatform("windows6.0.6000")]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial BOOL EnumResourceLanguagesExW(HMODULE hModule, PWSTR lpType, PWSTR lpName, ENUMRESLANGPROCW lpEnumFunc, nint lParam, uint dwFlags, ushort LangId);
    
    // https://learn.microsoft.com/windows/win32/api/libloaderapi/nf-libloaderapi-enumresourcenamesexw
    [LibraryImport("KERNEL32", StringMarshalling = StringMarshalling.Utf16, SetLastError = true)]
    [SupportedOSPlatform("windows6.0.6000")]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial BOOL EnumResourceNamesExW(HMODULE hModule, PWSTR lpType, ENUMRESNAMEPROCW lpEnumFunc, nint lParam, uint dwFlags, ushort LangId);
    
    // https://learn.microsoft.com/windows/win32/api/winbase/nf-winbase-enumresourcetypesw
    [LibraryImport("KERNEL32", StringMarshalling = StringMarshalling.Utf16, SetLastError = true)]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial BOOL EnumResourceTypesW(HMODULE hModule, ENUMRESTYPEPROCW lpEnumFunc, nint lParam);
    
    // https://learn.microsoft.com/windows/win32/api/winuser/nf-winuser-enumthreadwindows
    [LibraryImport("USER32", SetLastError = true)]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial BOOL EnumThreadWindows(uint dwThreadId, WNDENUMPROC lpfn, LPARAM lParam);
    
    // https://learn.microsoft.com/windows/win32/api/winuser/nf-winuser-enumwindows
    [LibraryImport("USER32", SetLastError = true)]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial BOOL EnumWindows(WNDENUMPROC lpEnumFunc, LPARAM lParam);
    
    // https://learn.microsoft.com/windows/win32/api/winuser/nf-winuser-equalrect
    [LibraryImport("USER32", SetLastError = true)]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial BOOL EqualRect(in RECT lprc1, in RECT lprc2);
    
    // https://learn.microsoft.com/windows/win32/api/wingdi/nf-wingdi-equalrgn
    [LibraryImport("GDI32", SetLastError = true)]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial BOOL EqualRgn(HRGN hrgn1, HRGN hrgn2);
    
    // https://learn.microsoft.com/windows/win32/api/wingdi/nf-wingdi-escape
    [LibraryImport("GDI32")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    public static partial int Escape(HDC hdc, int iEscape, int cjIn, PSTR pvIn, nint /* optional void* */ pvOut);
    
    // https://learn.microsoft.com/windows/win32/api/winuser/nf-winuser-excludeupdatergn
    [LibraryImport("USER32")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    public static partial int ExcludeUpdateRgn(HDC hDC, HWND hWnd);
    
    // https://learn.microsoft.com/windows/win32/api/wingdi/nf-wingdi-extcreateregion
    [LibraryImport("GDI32")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial HRGN ExtCreateRegion(nint /* optional XFORM* */ lpx, uint nCount, in RGNDATA lpData);
    
    // https://learn.microsoft.com/windows/win32/api/wingdi/nf-wingdi-extescape
    [LibraryImport("GDI32")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    public static partial int ExtEscape(HDC hdc, int iEscape, int cjInput, PSTR lpInData, int cjOutput, PSTR lpOutData);
    
    // https://learn.microsoft.com/windows/win32/api/wingdi/nf-wingdi-extfloodfill
    [LibraryImport("GDI32", SetLastError = true)]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial BOOL ExtFloodFill(HDC hdc, int x, int y, COLORREF color, EXT_FLOOD_FILL_TYPE type);
    
    // https://learn.microsoft.com/windows/win32/api/shellapi/nf-shellapi-extractassociatediconw
    [LibraryImport("SHELL32", StringMarshalling = StringMarshalling.Utf16)]
    [SupportedOSPlatform("windows5.1.2600")]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial HICON ExtractAssociatedIconW(HINSTANCE hInst, [MarshalUsing(ConstantElementCount = 128)] PWSTR pszIconPath, ref ushort piIcon);
    
    // https://learn.microsoft.com/windows/win32/api/shellapi/nf-shellapi-extracticonw
    [LibraryImport("SHELL32", StringMarshalling = StringMarshalling.Utf16)]
    [SupportedOSPlatform("windows5.1.2600")]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial HICON ExtractIconW(HINSTANCE hInst, PWSTR pszExeFileName, uint nIconIndex);
    
    // https://learn.microsoft.com/windows/win32/api/winuser/nf-winuser-fillrect
    [LibraryImport("USER32")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    public static partial int FillRect(HDC hDC, in RECT lprc, HBRUSH hbr);
    
    // https://learn.microsoft.com/windows/win32/api/wingdi/nf-wingdi-fillrgn
    [LibraryImport("GDI32", SetLastError = true)]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial BOOL FillRgn(HDC hdc, HRGN hrgn, HBRUSH hbr);
    
    // https://learn.microsoft.com/windows/win32/api/libloaderapi/nf-libloaderapi-findresourceexw
    [LibraryImport("KERNEL32", StringMarshalling = StringMarshalling.Utf16)]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial HRSRC FindResourceExW(HMODULE hModule, PWSTR lpType, PWSTR lpName, ushort wLanguage);
    
    // https://learn.microsoft.com/windows/win32/api/libloaderapi/nf-libloaderapi-findresourcew
    [LibraryImport("KERNEL32", StringMarshalling = StringMarshalling.Utf16)]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial HRSRC FindResourceW(HMODULE hModule, PWSTR lpName, PWSTR lpType);
    
    // https://learn.microsoft.com/windows/win32/api/winuser/nf-winuser-findwindoww
    [LibraryImport("USER32", StringMarshalling = StringMarshalling.Utf16, SetLastError = true)]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial HWND FindWindowW(PWSTR lpClassName, PWSTR lpWindowName);
    
    // https://learn.microsoft.com/windows/win32/api/winddi/nf-winddi-fontobj_cgetallglyphhandles
    [LibraryImport("GDI32")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    public static partial uint FONTOBJ_cGetAllGlyphHandles(ref FONTOBJ pfo, ref uint phg);
    
    // https://learn.microsoft.com/windows/win32/api/winddi/nf-winddi-fontobj_cgetglyphs
    [LibraryImport("GDI32")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    public static partial uint FONTOBJ_cGetGlyphs(ref FONTOBJ pfo, uint iMode, uint cGlyph, ref uint phg, out nint ppvGlyph);
    
    // https://learn.microsoft.com/windows/win32/api/winddi/nf-winddi-fontobj_pfdg
    [LibraryImport("GDI32")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    public static partial nint FONTOBJ_pfdg(ref FONTOBJ pfo);
    
    // https://learn.microsoft.com/windows/win32/api/winddi/nf-winddi-fontobj_pifi
    [LibraryImport("GDI32")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    public static partial nint FONTOBJ_pifi(in FONTOBJ pfo);
    
    // https://learn.microsoft.com/windows/win32/api/winddi/nf-winddi-fontobj_pqueryglyphattrs
    [LibraryImport("GDI32")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    public static partial nint FONTOBJ_pQueryGlyphAttrs(ref FONTOBJ pfo, uint iMode);
    
    // https://learn.microsoft.com/windows/win32/api/winddi/nf-winddi-fontobj_pvtruetypefontfile
    [LibraryImport("GDI32")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    public static partial nint FONTOBJ_pvTrueTypeFontFile(ref FONTOBJ pfo, ref uint pcjFile);
    
    // https://learn.microsoft.com/windows/win32/api/winddi/nf-winddi-fontobj_pxogetxform
    [LibraryImport("GDI32")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    public static partial nint FONTOBJ_pxoGetXform(in FONTOBJ pfo);
    
    // https://learn.microsoft.com/windows/win32/api/winddi/nf-winddi-fontobj_vgetinfo
    [LibraryImport("GDI32")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    public static partial void FONTOBJ_vGetInfo(ref FONTOBJ pfo, uint cjSize, ref FONTINFO pfi);
    
    // https://learn.microsoft.com/windows/win32/api/winbase/nf-winbase-formatmessagew
    [LibraryImport("KERNEL32", StringMarshalling = StringMarshalling.Utf16, SetLastError = true)]
    [SupportedOSPlatform("windows5.1.2600")]
    [PreserveSig]
    public static partial uint FormatMessageW(FORMAT_MESSAGE_OPTIONS dwFlags, nint /* optional void* */ lpSource, uint dwMessageId, uint dwLanguageId, PWSTR lpBuffer, uint nSize, nint /* optional sbyte** */ Arguments);
    
    // https://learn.microsoft.com/windows/win32/api/winuser/nf-winuser-framerect
    [LibraryImport("USER32")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    public static partial int FrameRect(HDC hDC, in RECT lprc, HBRUSH hbr);
    
    // https://learn.microsoft.com/windows/win32/api/wingdi/nf-wingdi-framergn
    [LibraryImport("GDI32", SetLastError = true)]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial BOOL FrameRgn(HDC hdc, HRGN hrgn, HBRUSH hbr, int w, int h);
    
    // https://learn.microsoft.com/windows/console/freeconsole
    [LibraryImport("KERNEL32", SetLastError = true)]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial BOOL FreeConsole();
    
    // https://learn.microsoft.com/windows/win32/api/libloaderapi/nf-libloaderapi-freelibrary
    [LibraryImport("KERNEL32", SetLastError = true)]
    [SupportedOSPlatform("windows5.1.2600")]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial BOOL FreeLibrary(HMODULE hLibModule);
    
    // https://learn.microsoft.com/windows/win32/api/libloaderapi/nf-libloaderapi-freeresource
    [LibraryImport("KERNEL32", SetLastError = true)]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial BOOL FreeResource(HGLOBAL hResData);
    
    // https://learn.microsoft.com/windows/win32/api/winuser/nf-winuser-getactivewindow
    [LibraryImport("USER32")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial HWND GetActiveWindow();
    
    // https://learn.microsoft.com/windows/win32/api/winuser/nf-winuser-getancestor
    [LibraryImport("USER32")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial HWND GetAncestor(HWND hwnd, GET_ANCESTOR_FLAGS gaFlags);
    
    // https://learn.microsoft.com/windows/win32/api/winuser/nf-winuser-getasynckeystate
    [LibraryImport("USER32")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    public static partial short GetAsyncKeyState(int vKey);
    
    // https://learn.microsoft.com/windows/win32/api/winuser/nf-winuser-getautorotationstate
    [LibraryImport("USER32", SetLastError = true)]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial BOOL GetAutoRotationState(out AR_STATE pState);
    
    // https://learn.microsoft.com/windows/win32/api/winuser/nf-winuser-getawarenessfromdpiawarenesscontext
    [LibraryImport("USER32")]
    [SupportedOSPlatform("windows10.0.14393")]
    [PreserveSig]
    public static partial DPI_AWARENESS GetAwarenessFromDpiAwarenessContext(DPI_AWARENESS_CONTEXT value);
    
    // https://learn.microsoft.com/windows/win32/api/wingdi/nf-wingdi-getbitmapbits
    [LibraryImport("GDI32")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    public static partial int GetBitmapBits(HBITMAP hbit, int cb, nint lpvBits);
    
    // https://learn.microsoft.com/windows/win32/api/lowlevelmonitorconfigurationapi/nf-lowlevelmonitorconfigurationapi-getcapabilitiesstringlength
    [LibraryImport("dxva2", SetLastError = true)]
    [SupportedOSPlatform("windows6.0.6000")]
    [PreserveSig]
    public static partial int GetCapabilitiesStringLength(HANDLE hMonitor, out uint pdwCapabilitiesStringLengthInCharacters);
    
    // https://learn.microsoft.com/windows/win32/api/winuser/nf-winuser-getcaretblinktime
    [LibraryImport("USER32", SetLastError = true)]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    public static partial uint GetCaretBlinkTime();
    
    // https://learn.microsoft.com/windows/win32/api/winuser/nf-winuser-getclassinfow
    [LibraryImport("USER32", StringMarshalling = StringMarshalling.Utf16, SetLastError = true)]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial BOOL GetClassInfoW(HINSTANCE hInstance, PWSTR lpClassName, out WNDCLASSW lpWndClass);
    
    // https://learn.microsoft.com/windows/win32/api/winuser/nf-winuser-getclasslongptrw
    [LibraryImport("USER32", StringMarshalling = StringMarshalling.Utf16, SetLastError = true)]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    public static partial nuint GetClassLongPtrW(HWND hWnd, GET_CLASS_LONG_INDEX nIndex);
    
    // https://learn.microsoft.com/windows/win32/api/winuser/nf-winuser-getclasslongw
    [LibraryImport("USER32", StringMarshalling = StringMarshalling.Utf16, SetLastError = true)]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    public static partial uint GetClassLongW(HWND hWnd, GET_CLASS_LONG_INDEX nIndex);
    
    // https://learn.microsoft.com/windows/win32/api/winuser/nf-winuser-getclassnamew
    [LibraryImport("USER32", StringMarshalling = StringMarshalling.Utf16, SetLastError = true)]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    public static partial int GetClassNameW(HWND hWnd, [MarshalUsing(CountElementName = nameof(nMaxCount))] PWSTR lpClassName, int nMaxCount);
    
    // https://learn.microsoft.com/windows/win32/api/winuser/nf-winuser-getclientrect
    [LibraryImport("USER32", SetLastError = true)]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial BOOL GetClientRect(HWND hWnd, out RECT lpRect);
    
    // https://learn.microsoft.com/windows/win32/api/winuser/nf-winuser-getclipboarddata
    [LibraryImport("USER32", SetLastError = true)]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial HANDLE GetClipboardData(uint uFormat);
    
    // https://learn.microsoft.com/windows/win32/api/winuser/nf-winuser-getclipboardformatnamew
    [LibraryImport("USER32", StringMarshalling = StringMarshalling.Utf16, SetLastError = true)]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    public static partial int GetClipboardFormatNameW(uint format, [MarshalUsing(CountElementName = nameof(cchMaxCount))] PWSTR lpszFormatName, int cchMaxCount);
    
    // https://learn.microsoft.com/windows/win32/api/winuser/nf-winuser-getclipboardowner
    [LibraryImport("USER32", SetLastError = true)]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial HWND GetClipboardOwner();
    
    // https://learn.microsoft.com/windows/win32/api/winuser/nf-winuser-getclipboardsequencenumber
    [LibraryImport("USER32")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    public static partial uint GetClipboardSequenceNumber();
    
    // https://learn.microsoft.com/windows/win32/api/winuser/nf-winuser-getclipboardviewer
    [LibraryImport("USER32", SetLastError = true)]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial HWND GetClipboardViewer();
    
    // https://learn.microsoft.com/windows/win32/api/wingdi/nf-wingdi-getcliprgn
    [LibraryImport("GDI32")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    public static partial int GetClipRgn(HDC hdc, HRGN hrgn);
    
    // https://learn.microsoft.com/windows/win32/api/icm/nf-icm-getcmminfo
    [LibraryImport("mscms")]
    [PreserveSig]
    public static partial uint GetCMMInfo(nint hColorTransform, uint param1);
    
    // https://learn.microsoft.com/windows/win32/api/icm/nf-icm-getcolordirectorya
    [LibraryImport("mscms", SetLastError = true)]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial BOOL GetColorDirectoryA(PSTR pMachineName, PSTR pBuffer, ref uint pdwSize);
    
    // https://learn.microsoft.com/windows/win32/api/icm/nf-icm-getcolordirectoryw
    [LibraryImport("mscms", StringMarshalling = StringMarshalling.Utf16, SetLastError = true)]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial BOOL GetColorDirectoryW(PWSTR pMachineName, PWSTR pBuffer, ref uint pdwSize);
    
    // https://learn.microsoft.com/windows/win32/api/icm/nf-icm-getcolorprofileelement
    [LibraryImport("mscms", SetLastError = true)]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial BOOL GetColorProfileElement(nint hProfile, uint tag, uint dwOffset, ref uint pcbElement, nint /* optional void* */ pElement, out BOOL pbReference);
    
    // https://learn.microsoft.com/windows/win32/api/icm/nf-icm-getcolorprofileelementtag
    [LibraryImport("mscms", SetLastError = true)]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial BOOL GetColorProfileElementTag(nint hProfile, uint dwIndex, out uint pTag);
    
    // https://learn.microsoft.com/windows/win32/api/icm/nf-icm-getcolorprofilefromhandle
    [LibraryImport("mscms", SetLastError = true)]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial BOOL GetColorProfileFromHandle(nint hProfile, nint /* optional byte* */ pProfile, ref uint pcbProfile);
    
    // https://learn.microsoft.com/windows/win32/api/icm/nf-icm-getcolorprofileheader
    [LibraryImport("mscms", SetLastError = true)]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial BOOL GetColorProfileHeader(nint hProfile, out PROFILEHEADER pHeader);
    
    // https://learn.microsoft.com/windows/win32/api/wingdi/nf-wingdi-getcolorspace
    [LibraryImport("GDI32")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial HCOLORSPACE GetColorSpace(HDC hdc);
    
    // https://learn.microsoft.com/windows/console/getconsolewindow
    [LibraryImport("KERNEL32")]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial HWND GetConsoleWindow();
    
    // https://learn.microsoft.com/windows/win32/api/icm/nf-icm-getcountcolorprofileelements
    [LibraryImport("mscms", SetLastError = true)]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial BOOL GetCountColorProfileElements(nint hProfile, out uint pnElementCount);
    
    // https://learn.microsoft.com/windows/win32/api/processthreadsapi/nf-processthreadsapi-getcurrentprocess
    [LibraryImport("KERNEL32")]
    [SupportedOSPlatform("windows5.1.2600")]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial HANDLE GetCurrentProcess();
    
    // https://learn.microsoft.com/windows/win32/api/processthreadsapi/nf-processthreadsapi-getcurrentthreadid
    [LibraryImport("KERNEL32")]
    [SupportedOSPlatform("windows5.1.2600")]
    [PreserveSig]
    public static partial uint GetCurrentThreadId();
    
    // https://learn.microsoft.com/windows/win32/api/winuser/nf-winuser-getcursor
    [LibraryImport("USER32")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial HCURSOR GetCursor();
    
    // https://learn.microsoft.com/windows/win32/api/winuser/nf-winuser-getcursorpos
    [LibraryImport("USER32", SetLastError = true)]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial BOOL GetCursorPos(out POINT lpPoint);
    
    // https://learn.microsoft.com/windows/win32/api/winuser/nf-winuser-getdc
    [LibraryImport("USER32")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial HDC GetDC(HWND hWnd);
    
    // https://learn.microsoft.com/windows/win32/api/winuser/nf-winuser-getdcex
    [LibraryImport("USER32")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial HDC GetDCEx(HWND hWnd, HRGN hrgnClip, GET_DCX_FLAGS flags);
    
    // https://learn.microsoft.com/windows/win32/api/winuser/nf-winuser-getdesktopwindow
    [LibraryImport("USER32")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial HWND GetDesktopWindow();
    
    // https://learn.microsoft.com/windows/win32/api/wingdi/nf-wingdi-getdevicecaps
    [LibraryImport("GDI32")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    public static partial int GetDeviceCaps(HDC hdc, int index);
    
    // https://learn.microsoft.com/windows/win32/api/wingdi/nf-wingdi-getdevicegammaramp
    [LibraryImport("GDI32", SetLastError = true)]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial BOOL GetDeviceGammaRamp(HDC hdc, nint lpRamp);
    
    [LibraryImport("DSOUND")]
    [PreserveSig]
    public static partial HRESULT GetDeviceID(nint /* optional Guid* */ pGuidSrc, out Guid pGuidDest);
    
    // https://learn.microsoft.com/windows/win32/api/winuser/nf-winuser-getdialogcontroldpichangebehavior
    [LibraryImport("USER32", SetLastError = true)]
    [SupportedOSPlatform("windows10.0.15063")]
    [PreserveSig]
    public static partial DIALOG_CONTROL_DPI_CHANGE_BEHAVIORS GetDialogControlDpiChangeBehavior(HWND hWnd);
    
    // https://learn.microsoft.com/windows/win32/api/winuser/nf-winuser-getdialogdpichangebehavior
    [LibraryImport("USER32", SetLastError = true)]
    [SupportedOSPlatform("windows10.0.15063")]
    [PreserveSig]
    public static partial DIALOG_DPI_CHANGE_BEHAVIORS GetDialogDpiChangeBehavior(HWND hDlg);
    
    // https://learn.microsoft.com/windows/win32/api/winuser/nf-winuser-getdisplayautorotationpreferences
    [LibraryImport("USER32", SetLastError = true)]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial BOOL GetDisplayAutoRotationPreferences(out ORIENTATION_PREFERENCE pOrientation);
    
    // https://learn.microsoft.com/windows/win32/api/winuser/nf-winuser-getdisplayconfigbuffersizes
    [LibraryImport("USER32")]
    [SupportedOSPlatform("windows6.0.6000")]
    [PreserveSig]
    public static partial WIN32_ERROR GetDisplayConfigBufferSizes(QUERY_DISPLAY_CONFIG_FLAGS flags, out uint numPathArrayElements, out uint numModeInfoArrayElements);
    
    // https://learn.microsoft.com/windows/win32/api/winuser/nf-winuser-getdoubleclicktime
    [LibraryImport("USER32")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    public static partial uint GetDoubleClickTime();
    
    [LibraryImport("USER32")]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial DPI_AWARENESS_CONTEXT GetDpiAwarenessContextForProcess(HANDLE hProcess);
    
    // https://learn.microsoft.com/windows/win32/api/shellscalingapi/nf-shellscalingapi-getdpiformonitor
    [LibraryImport("api-ms-win-shcore-scaling-l1-1-1")]
    [SupportedOSPlatform("windows8.1")]
    [PreserveSig]
    public static partial HRESULT GetDpiForMonitor(HMONITOR hmonitor, MONITOR_DPI_TYPE dpiType, out uint dpiX, out uint dpiY);
    
    // https://learn.microsoft.com/windows/win32/api/winuser/nf-winuser-getdpiforsystem
    [LibraryImport("USER32")]
    [SupportedOSPlatform("windows10.0.14393")]
    [PreserveSig]
    public static partial uint GetDpiForSystem();
    
    // https://learn.microsoft.com/windows/win32/api/winuser/nf-winuser-getdpiforwindow
    [LibraryImport("USER32")]
    [SupportedOSPlatform("windows10.0.14393")]
    [PreserveSig]
    public static partial uint GetDpiForWindow(HWND hwnd);
    
    // https://learn.microsoft.com/windows/win32/api/winuser/nf-winuser-getdpifromdpiawarenesscontext
    [LibraryImport("USER32")]
    [SupportedOSPlatform("windows10.0.17134")]
    [PreserveSig]
    public static partial uint GetDpiFromDpiAwarenessContext(DPI_AWARENESS_CONTEXT value);
    
    // https://learn.microsoft.com/windows/win32/api/mmiscapi/nf-mmiscapi-getdrivermodulehandle
    [LibraryImport("WINMM")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial HMODULE GetDriverModuleHandle(HDRVR hDriver);
    
    // https://learn.microsoft.com/windows/win32/api/wingdi/nf-wingdi-getenhmetafilepixelformat
    [LibraryImport("GDI32", SetLastError = true)]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    public static partial uint GetEnhMetaFilePixelFormat(HENHMETAFILE hemf, uint cbBuffer, nint /* optional PIXELFORMATDESCRIPTOR* */ ppfd);
    
    // https://learn.microsoft.com/windows/win32/api/oleauto/nf-oleauto-geterrorinfo
    [LibraryImport("OLEAUT32")]
    [PreserveSig]
    public static partial HRESULT GetErrorInfo(uint dwReserved, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IErrorInfo>))] out IErrorInfo pperrinfo);
    
    // https://learn.microsoft.com/windows/win32/api/errhandlingapi/nf-errhandlingapi-geterrormode
    [LibraryImport("KERNEL32")]
    [SupportedOSPlatform("windows6.0.6000")]
    [PreserveSig]
    public static partial uint GetErrorMode();
    
    // https://learn.microsoft.com/windows/win32/api/fileapi/nf-fileapi-getfileattributesexw
    [LibraryImport("KERNEL32", StringMarshalling = StringMarshalling.Utf16, SetLastError = true)]
    [SupportedOSPlatform("windows5.1.2600")]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial BOOL GetFileAttributesExW(PWSTR lpFileName, GET_FILEEX_INFO_LEVELS fInfoLevelId, nint lpFileInformation);
    
    // https://learn.microsoft.com/windows/win32/api/winuser/nf-winuser-getfocus
    [LibraryImport("USER32")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial HWND GetFocus();
    
    // https://learn.microsoft.com/windows/win32/api/winuser/nf-winuser-getforegroundwindow
    [LibraryImport("USER32")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial HWND GetForegroundWindow();
    
    // https://learn.microsoft.com/windows/win32/api/wingdi/nf-wingdi-geticmprofilea
    [LibraryImport("GDI32", SetLastError = true)]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial BOOL GetICMProfileA(HDC hdc, ref uint pBufSize, [MarshalUsing(CountElementName = nameof(pBufSize))] PSTR pszFilename);
    
    // https://learn.microsoft.com/windows/win32/api/wingdi/nf-wingdi-geticmprofilew
    [LibraryImport("GDI32", StringMarshalling = StringMarshalling.Utf16, SetLastError = true)]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial BOOL GetICMProfileW(HDC hdc, ref uint pBufSize, [MarshalUsing(CountElementName = nameof(pBufSize))] PWSTR pszFilename);
    
    // https://learn.microsoft.com/windows/win32/api/winuser/nf-winuser-geticoninfo
    [LibraryImport("USER32", SetLastError = true)]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial BOOL GetIconInfo(HICON hIcon, out ICONINFO piconinfo);
    
    // https://learn.microsoft.com/windows/win32/api/winuser/nf-winuser-getkeyboardlayout
    [LibraryImport("USER32")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial HKL GetKeyboardLayout(uint idThread);
    
    // https://learn.microsoft.com/windows/win32/api/winuser/nf-winuser-getkeyboardlayoutlist
    [LibraryImport("USER32", SetLastError = true)]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    public static partial int GetKeyboardLayoutList(int nBuff, nint /* optional HKL* */ lpList);
    
    // https://learn.microsoft.com/windows/win32/api/winuser/nf-winuser-getkeyboardlayoutnamew
    [LibraryImport("USER32", StringMarshalling = StringMarshalling.Utf16, SetLastError = true)]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial BOOL GetKeyboardLayoutNameW([MarshalUsing(ConstantElementCount = 9)] PWSTR pwszKLID);
    
    // https://learn.microsoft.com/windows/win32/api/winuser/nf-winuser-getkeyboardstate
    [LibraryImport("USER32", SetLastError = true)]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial BOOL GetKeyboardState(nint /* byte array */ lpKeyState);
    
    // https://learn.microsoft.com/windows/win32/api/winuser/nf-winuser-getkeyboardtype
    [LibraryImport("USER32", SetLastError = true)]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    public static partial int GetKeyboardType(int nTypeFlag);
    
    // https://learn.microsoft.com/windows/win32/api/winuser/nf-winuser-getkeynametextw
    [LibraryImport("USER32", StringMarshalling = StringMarshalling.Utf16, SetLastError = true)]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    public static partial int GetKeyNameTextW(int lParam, [MarshalUsing(CountElementName = nameof(cchSize))] PWSTR lpString, int cchSize);
    
    // https://learn.microsoft.com/windows/win32/api/winuser/nf-winuser-getkeystate
    [LibraryImport("USER32")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    public static partial short GetKeyState(int nVirtKey);
    
    // https://learn.microsoft.com/windows/win32/api/wingdi/nf-wingdi-getlogcolorspacea
    [LibraryImport("GDI32", SetLastError = true)]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial BOOL GetLogColorSpaceA(HCOLORSPACE hColorSpace, nint lpBuffer, uint nSize);
    
    // https://learn.microsoft.com/windows/win32/api/wingdi/nf-wingdi-getlogcolorspacew
    [LibraryImport("GDI32", StringMarshalling = StringMarshalling.Utf16, SetLastError = true)]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial BOOL GetLogColorSpaceW(HCOLORSPACE hColorSpace, nint lpBuffer, uint nSize);
    
    // https://learn.microsoft.com/windows/win32/api/winuser/nf-winuser-getmessagepos
    [LibraryImport("USER32")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    public static partial uint GetMessagePos();
    
    // https://learn.microsoft.com/windows/win32/api/winuser/nf-winuser-getmessagew
    [LibraryImport("USER32", StringMarshalling = StringMarshalling.Utf16, SetLastError = true)]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial BOOL GetMessageW(out MSG lpMsg, HWND hWnd, uint wMsgFilterMin, uint wMsgFilterMax);
    
    // https://learn.microsoft.com/windows/win32/api/libloaderapi/nf-libloaderapi-getmodulefilenamew
    [LibraryImport("KERNEL32", StringMarshalling = StringMarshalling.Utf16, SetLastError = true)]
    [SupportedOSPlatform("windows5.1.2600")]
    [PreserveSig]
    public static partial uint GetModuleFileNameW(HMODULE hModule, [MarshalUsing(CountElementName = nameof(nSize))] PWSTR lpFilename, uint nSize);
    
    // https://learn.microsoft.com/windows/win32/api/libloaderapi/nf-libloaderapi-getmodulehandleexw
    [LibraryImport("KERNEL32", StringMarshalling = StringMarshalling.Utf16, SetLastError = true)]
    [SupportedOSPlatform("windows5.1.2600")]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial BOOL GetModuleHandleExW(uint dwFlags, PWSTR lpModuleName, out HMODULE phModule);
    
    // https://learn.microsoft.com/windows/win32/api/libloaderapi/nf-libloaderapi-getmodulehandlew
    [LibraryImport("KERNEL32", StringMarshalling = StringMarshalling.Utf16, SetLastError = true)]
    [SupportedOSPlatform("windows5.1.2600")]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial HMODULE GetModuleHandleW(PWSTR lpModuleName);
    
    // https://learn.microsoft.com/windows/win32/api/highlevelmonitorconfigurationapi/nf-highlevelmonitorconfigurationapi-getmonitorbrightness
    [LibraryImport("dxva2", SetLastError = true)]
    [SupportedOSPlatform("windows6.0.6000")]
    [PreserveSig]
    public static partial int GetMonitorBrightness(HANDLE hMonitor, out uint pdwMinimumBrightness, out uint pdwCurrentBrightness, out uint pdwMaximumBrightness);
    
    // https://learn.microsoft.com/windows/win32/api/highlevelmonitorconfigurationapi/nf-highlevelmonitorconfigurationapi-getmonitorcapabilities
    [LibraryImport("dxva2")]
    [SupportedOSPlatform("windows6.0.6000")]
    [PreserveSig]
    public static partial int GetMonitorCapabilities(HANDLE hMonitor, out uint pdwMonitorCapabilities, out uint pdwSupportedColorTemperatures);
    
    // https://learn.microsoft.com/windows/win32/api/highlevelmonitorconfigurationapi/nf-highlevelmonitorconfigurationapi-getmonitorcolortemperature
    [LibraryImport("dxva2", SetLastError = true)]
    [SupportedOSPlatform("windows6.0.6000")]
    [PreserveSig]
    public static partial int GetMonitorColorTemperature(HANDLE hMonitor, out MC_COLOR_TEMPERATURE pctCurrentColorTemperature);
    
    // https://learn.microsoft.com/windows/win32/api/highlevelmonitorconfigurationapi/nf-highlevelmonitorconfigurationapi-getmonitorcontrast
    [LibraryImport("dxva2", SetLastError = true)]
    [SupportedOSPlatform("windows6.0.6000")]
    [PreserveSig]
    public static partial int GetMonitorContrast(HANDLE hMonitor, out uint pdwMinimumContrast, out uint pdwCurrentContrast, out uint pdwMaximumContrast);
    
    // https://learn.microsoft.com/windows/win32/api/highlevelmonitorconfigurationapi/nf-highlevelmonitorconfigurationapi-getmonitordisplayareaposition
    [LibraryImport("dxva2", SetLastError = true)]
    [SupportedOSPlatform("windows6.0.6000")]
    [PreserveSig]
    public static partial int GetMonitorDisplayAreaPosition(HANDLE hMonitor, MC_POSITION_TYPE ptPositionType, out uint pdwMinimumPosition, out uint pdwCurrentPosition, out uint pdwMaximumPosition);
    
    // https://learn.microsoft.com/windows/win32/api/highlevelmonitorconfigurationapi/nf-highlevelmonitorconfigurationapi-getmonitordisplayareasize
    [LibraryImport("dxva2", SetLastError = true)]
    [SupportedOSPlatform("windows6.0.6000")]
    [PreserveSig]
    public static partial int GetMonitorDisplayAreaSize(HANDLE hMonitor, MC_SIZE_TYPE stSizeType, out uint pdwMinimumWidthOrHeight, out uint pdwCurrentWidthOrHeight, out uint pdwMaximumWidthOrHeight);
    
    // https://learn.microsoft.com/windows/win32/api/winuser/nf-winuser-getmonitorinfow
    [LibraryImport("USER32", StringMarshalling = StringMarshalling.Utf16, SetLastError = true)]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial BOOL GetMonitorInfoW(HMONITOR hMonitor, ref MONITORINFO lpmi);
    
    // https://learn.microsoft.com/windows/win32/api/highlevelmonitorconfigurationapi/nf-highlevelmonitorconfigurationapi-getmonitorredgreenorbluedrive
    [LibraryImport("dxva2", SetLastError = true)]
    [SupportedOSPlatform("windows6.0.6000")]
    [PreserveSig]
    public static partial int GetMonitorRedGreenOrBlueDrive(HANDLE hMonitor, MC_DRIVE_TYPE dtDriveType, out uint pdwMinimumDrive, out uint pdwCurrentDrive, out uint pdwMaximumDrive);
    
    // https://learn.microsoft.com/windows/win32/api/highlevelmonitorconfigurationapi/nf-highlevelmonitorconfigurationapi-getmonitorredgreenorbluegain
    [LibraryImport("dxva2", SetLastError = true)]
    [SupportedOSPlatform("windows6.0.6000")]
    [PreserveSig]
    public static partial int GetMonitorRedGreenOrBlueGain(HANDLE hMonitor, MC_GAIN_TYPE gtGainType, out uint pdwMinimumGain, out uint pdwCurrentGain, out uint pdwMaximumGain);
    
    // https://learn.microsoft.com/windows/win32/api/highlevelmonitorconfigurationapi/nf-highlevelmonitorconfigurationapi-getmonitortechnologytype
    [LibraryImport("dxva2", SetLastError = true)]
    [SupportedOSPlatform("windows6.0.6000")]
    [PreserveSig]
    public static partial int GetMonitorTechnologyType(HANDLE hMonitor, ref MC_DISPLAY_TECHNOLOGY_TYPE pdtyDisplayTechnologyType);
    
    // https://learn.microsoft.com/windows/win32/api/icm/nf-icm-getnamedprofileinfo
    [LibraryImport("mscms", SetLastError = true)]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial BOOL GetNamedProfileInfo(nint hProfile, ref NAMED_PROFILE_INFO pNamedProfileInfo);
    
    // https://learn.microsoft.com/windows/win32/api/sysinfoapi/nf-sysinfoapi-getnativesysteminfo
    [LibraryImport("KERNEL32")]
    [SupportedOSPlatform("windows5.1.2600")]
    [PreserveSig]
    public static partial void GetNativeSystemInfo(out SYSTEM_INFO lpSystemInfo);
    
    // https://learn.microsoft.com/windows/win32/api/physicalmonitorenumerationapi/nf-physicalmonitorenumerationapi-getnumberofphysicalmonitorsfromhmonitor
    [LibraryImport("dxva2", SetLastError = true)]
    [SupportedOSPlatform("windows6.0.6000")]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial BOOL GetNumberOfPhysicalMonitorsFromHMONITOR(HMONITOR hMonitor, out uint pdwNumberOfPhysicalMonitors);
    
    // https://learn.microsoft.com/windows/win32/api/physicalmonitorenumerationapi/nf-physicalmonitorenumerationapi-getnumberofphysicalmonitorsfromidirect3ddevice9
    [LibraryImport("dxva2")]
    [SupportedOSPlatform("windows6.0.6000")]
    [PreserveSig]
    public static partial HRESULT GetNumberOfPhysicalMonitorsFromIDirect3DDevice9([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDirect3DDevice9>))] IDirect3DDevice9 pDirect3DDevice9, out uint pdwNumberOfPhysicalMonitors);
    
    // https://learn.microsoft.com/windows/win32/api/wingdi/nf-wingdi-getobjecttype
    [LibraryImport("GDI32")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    public static partial uint GetObjectType(HGDIOBJ h);
    
    // https://learn.microsoft.com/windows/win32/api/wingdi/nf-wingdi-getobjectw
    [LibraryImport("GDI32", StringMarshalling = StringMarshalling.Utf16)]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    public static partial int GetObjectW(HGDIOBJ h, int c, nint /* optional void* */ pv);
    
    // https://learn.microsoft.com/windows/win32/api/winuser/nf-winuser-getopenclipboardwindow
    [LibraryImport("USER32", SetLastError = true)]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial HWND GetOpenClipboardWindow();
    
    // https://learn.microsoft.com/windows/win32/api/vfw/nf-vfw-getopenfilenamepreviewa
    [LibraryImport("MSVFW32", SetLastError = true)]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial BOOL GetOpenFileNamePreviewA(ref OPENFILENAMEA lpofn);
    
    // https://learn.microsoft.com/windows/win32/api/vfw/nf-vfw-getopenfilenameprevieww
    [LibraryImport("MSVFW32", StringMarshalling = StringMarshalling.Utf16, SetLastError = true)]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial BOOL GetOpenFileNamePreviewW(ref OPENFILENAMEW lpofn);
    
    // https://learn.microsoft.com/windows/win32/api/winuser/nf-winuser-getparent
    [LibraryImport("USER32", SetLastError = true)]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial HWND GetParent(HWND hWnd);
    
    // https://learn.microsoft.com/windows/win32/api/sysinfoapi/nf-sysinfoapi-getphysicallyinstalledsystemmemory
    [LibraryImport("KERNEL32", SetLastError = true)]
    [SupportedOSPlatform("windows6.0.6000")]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial BOOL GetPhysicallyInstalledSystemMemory(out ulong TotalMemoryInKilobytes);
    
    // https://learn.microsoft.com/windows/win32/api/physicalmonitorenumerationapi/nf-physicalmonitorenumerationapi-getphysicalmonitorsfromhmonitor
    [LibraryImport("dxva2", SetLastError = true)]
    [SupportedOSPlatform("windows6.0.6000")]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial BOOL GetPhysicalMonitorsFromHMONITOR(HMONITOR hMonitor, uint dwPhysicalMonitorArraySize, [In][Out][MarshalUsing(CountElementName = nameof(dwPhysicalMonitorArraySize))] PHYSICAL_MONITOR[] pPhysicalMonitorArray);
    
    // https://learn.microsoft.com/windows/win32/api/physicalmonitorenumerationapi/nf-physicalmonitorenumerationapi-getphysicalmonitorsfromidirect3ddevice9
    [LibraryImport("dxva2")]
    [SupportedOSPlatform("windows6.0.6000")]
    [PreserveSig]
    public static partial HRESULT GetPhysicalMonitorsFromIDirect3DDevice9([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDirect3DDevice9>))] IDirect3DDevice9 pDirect3DDevice9, uint dwPhysicalMonitorArraySize, [In][Out][MarshalUsing(CountElementName = nameof(dwPhysicalMonitorArraySize))] PHYSICAL_MONITOR[] pPhysicalMonitorArray);
    
    // https://learn.microsoft.com/windows/win32/api/wingdi/nf-wingdi-getpixelformat
    [LibraryImport("GDI32", SetLastError = true)]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    public static partial int GetPixelFormat(HDC hdc);
    
    // https://learn.microsoft.com/windows/win32/api/winuser/nf-winuser-getpointerinfo
    [LibraryImport("USER32", SetLastError = true)]
    [SupportedOSPlatform("windows8.0")]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial BOOL GetPointerInfo(uint pointerId, out POINTER_INFO pointerInfo);
    
    // https://learn.microsoft.com/windows/win32/api/winuser/nf-winuser-getpointerpeninfo
    [LibraryImport("USER32", SetLastError = true)]
    [SupportedOSPlatform("windows8.0")]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial BOOL GetPointerPenInfo(uint pointerId, out POINTER_PEN_INFO penInfo);
    
    // https://learn.microsoft.com/windows/win32/api/winuser/nf-winuser-getpointertouchinfo
    [LibraryImport("USER32", SetLastError = true)]
    [SupportedOSPlatform("windows8.0")]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial BOOL GetPointerTouchInfo(uint pointerId, out POINTER_TOUCH_INFO touchInfo);
    
    // https://learn.microsoft.com/windows/win32/api/winuser/nf-winuser-getpointertype
    [LibraryImport("USER32", SetLastError = true)]
    [SupportedOSPlatform("windows8.0")]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial BOOL GetPointerType(uint pointerId, out POINTER_INPUT_TYPE pointerType);
    
    // https://learn.microsoft.com/windows/win32/api/wingdi/nf-wingdi-getpolyfillmode
    [LibraryImport("GDI32")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    public static partial int GetPolyFillMode(HDC hdc);
    
    // https://learn.microsoft.com/windows/win32/api/winuser/nf-winuser-getpriorityclipboardformat
    [LibraryImport("USER32", SetLastError = true)]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    public static partial int GetPriorityClipboardFormat([In][MarshalUsing(CountElementName = nameof(cFormats))] uint[] paFormatPriorityList, int cFormats);
    
    // https://learn.microsoft.com/windows/win32/api/libloaderapi/nf-libloaderapi-getprocaddress
    [LibraryImport("KERNEL32", SetLastError = true)]
    [SupportedOSPlatform("windows5.1.2600")]
    [PreserveSig]
    public static partial nint GetProcAddress(HMODULE hModule, PSTR lpProcName);
    
    // https://learn.microsoft.com/windows/win32/api/shellscalingapi/nf-shellscalingapi-getprocessdpiawareness
    [LibraryImport("api-ms-win-shcore-scaling-l1-1-1")]
    [SupportedOSPlatform("windows8.1")]
    [PreserveSig]
    public static partial HRESULT GetProcessDpiAwareness(HANDLE hprocess, out PROCESS_DPI_AWARENESS value);
    
    // https://learn.microsoft.com/windows/win32/api/processthreadsapi/nf-processthreadsapi-getprocessid
    [LibraryImport("KERNEL32", SetLastError = true)]
    [SupportedOSPlatform("windows6.0.6000")]
    [PreserveSig]
    public static partial uint GetProcessId(HANDLE Process);
    
    // https://learn.microsoft.com/windows/win32/api/winuser/nf-winuser-getpropw
    [LibraryImport("USER32", StringMarshalling = StringMarshalling.Utf16)]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial HANDLE GetPropW(HWND hWnd, PWSTR lpString);
    
    // https://learn.microsoft.com/windows/win32/api/icm/nf-icm-getps2colorrenderingdictionary
    [LibraryImport("mscms", SetLastError = true)]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial BOOL GetPS2ColorRenderingDictionary(nint hProfile, uint dwIntent, nint /* optional byte* */ pPS2ColorRenderingDictionary, ref uint pcbPS2ColorRenderingDictionary, ref BOOL pbBinary);
    
    // https://learn.microsoft.com/windows/win32/api/icm/nf-icm-getps2colorrenderingintent
    [LibraryImport("mscms", SetLastError = true)]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial BOOL GetPS2ColorRenderingIntent(nint hProfile, uint dwIntent, nint /* optional byte* */ pBuffer, ref uint pcbPS2ColorRenderingIntent);
    
    // https://learn.microsoft.com/windows/win32/api/icm/nf-icm-getps2colorspacearray
    [LibraryImport("mscms", SetLastError = true)]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial BOOL GetPS2ColorSpaceArray(nint hProfile, uint dwIntent, uint dwCSAType, nint /* optional byte* */ pPS2ColorSpaceArray, ref uint pcbPS2ColorSpaceArray, out BOOL pbBinary);
    
    // https://learn.microsoft.com/windows/win32/api/wingdi/nf-wingdi-getregiondata
    [LibraryImport("GDI32")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    public static partial uint GetRegionData(HRGN hrgn, uint nCount, nint /* optional RGNDATA* */ lpRgnData);
    
    // https://learn.microsoft.com/windows/win32/api/roerrorapi/nf-roerrorapi-getrestrictederrorinfo
    [LibraryImport("api-ms-win-core-winrt-error-l1-1-0")]
    [SupportedOSPlatform("windows8.0")]
    [PreserveSig]
    public static partial HRESULT GetRestrictedErrorInfo([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IRestrictedErrorInfo>))] out IRestrictedErrorInfo ppRestrictedErrorInfo);
    
    // https://learn.microsoft.com/windows/win32/api/wingdi/nf-wingdi-getrgnbox
    [LibraryImport("GDI32")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    public static partial GDI_REGION_TYPE GetRgnBox(HRGN hrgn, out RECT lprc);
    
    // https://learn.microsoft.com/windows/win32/api/objbase/nf-objbase-getrunningobjecttable
    [LibraryImport("OLE32")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    public static partial HRESULT GetRunningObjectTable(uint reserved, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IRunningObjectTable>))] out IRunningObjectTable pprot);
    
    // https://learn.microsoft.com/windows/win32/api/vfw/nf-vfw-getsavefilenamepreviewa
    [LibraryImport("MSVFW32", SetLastError = true)]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial BOOL GetSaveFileNamePreviewA(ref OPENFILENAMEA lpofn);
    
    // https://learn.microsoft.com/windows/win32/api/vfw/nf-vfw-getsavefilenameprevieww
    [LibraryImport("MSVFW32", StringMarshalling = StringMarshalling.Utf16, SetLastError = true)]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial BOOL GetSaveFileNamePreviewW(ref OPENFILENAMEW lpofn);
    
    // https://learn.microsoft.com/windows/win32/api/shellscalingapi/nf-shellscalingapi-getscalefactorformonitor
    [LibraryImport("api-ms-win-shcore-scaling-l1-1-1")]
    [SupportedOSPlatform("windows8.1")]
    [PreserveSig]
    public static partial HRESULT GetScaleFactorForMonitor(HMONITOR hMon, out DEVICE_SCALE_FACTOR pScale);
    
    // https://learn.microsoft.com/windows/win32/api/winuser/nf-winuser-getshellwindow
    [LibraryImport("USER32")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial HWND GetShellWindow();
    
    // https://learn.microsoft.com/windows/win32/api/icm/nf-icm-getstandardcolorspaceprofilea
    [LibraryImport("mscms", SetLastError = true)]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial BOOL GetStandardColorSpaceProfileA(PSTR pMachineName, uint dwSCS, PSTR pBuffer, ref uint pcbSize);
    
    // https://learn.microsoft.com/windows/win32/api/icm/nf-icm-getstandardcolorspaceprofilew
    [LibraryImport("mscms", StringMarshalling = StringMarshalling.Utf16, SetLastError = true)]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial BOOL GetStandardColorSpaceProfileW(PWSTR pMachineName, uint dwSCS, PWSTR pBuffer, ref uint pcbSize);
    
    // https://learn.microsoft.com/windows/win32/api/wingdi/nf-wingdi-getstockobject
    [LibraryImport("GDI32")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial HGDIOBJ GetStockObject(GET_STOCK_OBJECT_FLAGS i);
    
    // https://learn.microsoft.com/windows/win32/api/winuser/nf-winuser-getsyscolor
    [LibraryImport("USER32")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    public static partial uint GetSysColor(SYS_COLOR_INDEX nIndex);
    
    // https://learn.microsoft.com/windows/win32/api/winuser/nf-winuser-getsyscolorbrush
    [LibraryImport("USER32")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial HBRUSH GetSysColorBrush(SYS_COLOR_INDEX nIndex);
    
    // https://learn.microsoft.com/windows/win32/api/winuser/nf-winuser-getsystemdpiforprocess
    [LibraryImport("USER32")]
    [SupportedOSPlatform("windows10.0.17134")]
    [PreserveSig]
    public static partial uint GetSystemDpiForProcess(HANDLE hProcess);
    
    // https://learn.microsoft.com/windows/win32/api/winuser/nf-winuser-getsystemmenu
    [LibraryImport("USER32")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial HMENU GetSystemMenu(HWND hWnd, BOOL bRevert);
    
    // https://learn.microsoft.com/windows/win32/api/winuser/nf-winuser-getsystemmetrics
    [LibraryImport("USER32")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    public static partial int GetSystemMetrics(SYSTEM_METRICS_INDEX nIndex);
    
    // https://learn.microsoft.com/windows/win32/api/winuser/nf-winuser-getsystemmetricsfordpi
    [LibraryImport("USER32", SetLastError = true)]
    [SupportedOSPlatform("windows10.0.14393")]
    [PreserveSig]
    public static partial int GetSystemMetricsForDpi(SYSTEM_METRICS_INDEX nIndex, uint dpi);
    
    // https://learn.microsoft.com/windows/win32/api/wingdi/nf-wingdi-gettextcolor
    [LibraryImport("GDI32")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial COLORREF GetTextColor(HDC hdc);
    
    // https://learn.microsoft.com/windows/win32/api/uxtheme/nf-uxtheme-getthemecolor
    [LibraryImport("UXTHEME")]
    [SupportedOSPlatform("windows6.0.6000")]
    [PreserveSig]
    public static partial HRESULT GetThemeColor(HTHEME hTheme, int iPartId, int iStateId, int iPropId, out COLORREF pColor);
    
    // https://learn.microsoft.com/windows/win32/api/uxtheme/nf-uxtheme-getthemesyscolor
    [LibraryImport("UxTheme")]
    [SupportedOSPlatform("windows6.0.6000")]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial COLORREF GetThemeSysColor(HTHEME hTheme, int iColorId);
    
    // https://learn.microsoft.com/windows/win32/api/winuser/nf-winuser-getthreaddpiawarenesscontext
    [LibraryImport("USER32")]
    [SupportedOSPlatform("windows10.0.14393")]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial DPI_AWARENESS_CONTEXT GetThreadDpiAwarenessContext();
    
    // https://learn.microsoft.com/windows/win32/api/winuser/nf-winuser-getthreaddpihostingbehavior
    [LibraryImport("USER32")]
    [SupportedOSPlatform("windows10.0.17134")]
    [PreserveSig]
    public static partial DPI_HOSTING_BEHAVIOR GetThreadDpiHostingBehavior();
    
    // https://learn.microsoft.com/windows/win32/api/errhandlingapi/nf-errhandlingapi-getthreaderrormode
    [LibraryImport("KERNEL32")]
    [SupportedOSPlatform("windows6.1")]
    [PreserveSig]
    public static partial uint GetThreadErrorMode();
    
    // https://learn.microsoft.com/windows/win32/api/processthreadsapi/nf-processthreadsapi-getthreadid
    [LibraryImport("KERNEL32", SetLastError = true)]
    [SupportedOSPlatform("windows6.0.6000")]
    [PreserveSig]
    public static partial uint GetThreadId(HANDLE Thread);
    
    // https://learn.microsoft.com/windows/win32/api/winnls/nf-winnls-getthreaduilanguage
    [LibraryImport("KERNEL32")]
    [SupportedOSPlatform("windows6.0.6000")]
    [PreserveSig]
    public static partial ushort GetThreadUILanguage();
    
    // https://learn.microsoft.com/windows/win32/api/lowlevelmonitorconfigurationapi/nf-lowlevelmonitorconfigurationapi-gettimingreport
    [LibraryImport("dxva2", SetLastError = true)]
    [SupportedOSPlatform("windows6.0.6000")]
    [PreserveSig]
    public static partial int GetTimingReport(HANDLE hMonitor, out MC_TIMING_REPORT pmtrMonitorTimingReport);
    
    // https://learn.microsoft.com/windows/win32/api/securitybaseapi/nf-securitybaseapi-gettokeninformation
    [LibraryImport("ADVAPI32", SetLastError = true)]
    [SupportedOSPlatform("windows5.1.2600")]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial BOOL GetTokenInformation(HANDLE TokenHandle, TOKEN_INFORMATION_CLASS TokenInformationClass, nint /* optional void* */ TokenInformation, uint TokenInformationLength, out uint ReturnLength);
    
    // https://learn.microsoft.com/windows/win32/api/winuser/nf-winuser-gettopwindow
    [LibraryImport("USER32", SetLastError = true)]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial HWND GetTopWindow(HWND hWnd);
    
    // https://learn.microsoft.com/windows/win32/api/winnls/nf-winnls-getuilanguageinfo
    [LibraryImport("KERNEL32", SetLastError = true)]
    [SupportedOSPlatform("windows6.0.6000")]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial BOOL GetUILanguageInfo(uint dwFlags, PWSTR pwmszLanguage, [MarshalUsing(CountElementName = nameof(pcchFallbackLanguages))] PWSTR pwszFallbackLanguages, nint /* optional uint* */ pcchFallbackLanguages, out uint pAttributes);
    
    // https://learn.microsoft.com/windows/win32/api/winuser/nf-winuser-getupdatedclipboardformats
    [LibraryImport("USER32", SetLastError = true)]
    [SupportedOSPlatform("windows6.0.6000")]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial BOOL GetUpdatedClipboardFormats([In][Out][MarshalUsing(CountElementName = nameof(cFormats))] uint[] lpuiFormats, uint cFormats, out uint pcFormatsOut);
    
    // https://learn.microsoft.com/windows/win32/api/winuser/nf-winuser-getupdaterect
    [LibraryImport("USER32", SetLastError = true)]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial BOOL GetUpdateRect(HWND hWnd, nint /* optional RECT* */ lpRect, BOOL bErase);
    
    // https://learn.microsoft.com/windows/win32/api/winuser/nf-winuser-getupdatergn
    [LibraryImport("USER32")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    public static partial GDI_REGION_TYPE GetUpdateRgn(HWND hWnd, HRGN hRgn, BOOL bErase);
    
    // https://learn.microsoft.com/windows/win32/api/winnls/nf-winnls-getuserdefaultlocalename
    [LibraryImport("KERNEL32", SetLastError = true)]
    [SupportedOSPlatform("windows6.0.6000")]
    [PreserveSig]
    public static partial int GetUserDefaultLocaleName([MarshalUsing(CountElementName = nameof(cchLocaleName))] PWSTR lpLocaleName, int cchLocaleName);
    
    // https://learn.microsoft.com/windows/win32/api/winnls/nf-winnls-getuserdefaultuilanguage
    [LibraryImport("KERNEL32")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    public static partial ushort GetUserDefaultUILanguage();
    
    // https://learn.microsoft.com/windows/win32/api/winnls/nf-winnls-getuserpreferreduilanguages
    [LibraryImport("KERNEL32", SetLastError = true)]
    [SupportedOSPlatform("windows6.0.6000")]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial BOOL GetUserPreferredUILanguages(uint dwFlags, out uint pulNumLanguages, [MarshalUsing(CountElementName = nameof(pcchLanguagesBuffer))] PWSTR pwszLanguagesBuffer, ref uint pcchLanguagesBuffer);
    
    // https://learn.microsoft.com/windows/win32/api/lowlevelmonitorconfigurationapi/nf-lowlevelmonitorconfigurationapi-getvcpfeatureandvcpfeaturereply
    [LibraryImport("dxva2", SetLastError = true)]
    [SupportedOSPlatform("windows6.0.6000")]
    [PreserveSig]
    public static partial int GetVCPFeatureAndVCPFeatureReply(HANDLE hMonitor, byte bVCPCode, nint /* optional MC_VCP_CODE_TYPE* */ pvct, out uint pdwCurrentValue, nint /* optional uint* */ pdwMaximumValue);
    
    // https://learn.microsoft.com/windows/win32/api/winuser/nf-winuser-getwindow
    [LibraryImport("USER32", SetLastError = true)]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial HWND GetWindow(HWND hWnd, GET_WINDOW_CMD uCmd);
    
    // https://learn.microsoft.com/windows/win32/api/winuser/nf-winuser-getwindowdc
    [LibraryImport("USER32")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial HDC GetWindowDC(HWND hWnd);
    
    // https://learn.microsoft.com/windows/win32/api/winuser/nf-winuser-getwindowdisplayaffinity
    [LibraryImport("USER32", SetLastError = true)]
    [SupportedOSPlatform("windows6.1")]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial BOOL GetWindowDisplayAffinity(HWND hWnd, out uint pdwAffinity);
    
    // https://learn.microsoft.com/windows/win32/api/winuser/nf-winuser-getwindowdpiawarenesscontext
    [LibraryImport("USER32")]
    [SupportedOSPlatform("windows10.0.14393")]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial DPI_AWARENESS_CONTEXT GetWindowDpiAwarenessContext(HWND hwnd);
    
    // https://learn.microsoft.com/windows/win32/api/winuser/nf-winuser-getwindowdpihostingbehavior
    [LibraryImport("USER32")]
    [SupportedOSPlatform("windows10.0.17134")]
    [PreserveSig]
    public static partial DPI_HOSTING_BEHAVIOR GetWindowDpiHostingBehavior(HWND hwnd);
    
    // https://learn.microsoft.com/windows/win32/api/winuser/nf-winuser-getwindowlongptrw
    [LibraryImport("USER32", StringMarshalling = StringMarshalling.Utf16, SetLastError = true)]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    public static partial nint GetWindowLongPtrW(HWND hWnd, WINDOW_LONG_PTR_INDEX nIndex);
    
    // https://learn.microsoft.com/windows/win32/api/winuser/nf-winuser-getwindowlongw
    [LibraryImport("USER32", StringMarshalling = StringMarshalling.Utf16, SetLastError = true)]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    public static partial int GetWindowLongW(HWND hWnd, WINDOW_LONG_PTR_INDEX nIndex);
    
    // https://learn.microsoft.com/windows/win32/api/winuser/nf-winuser-getwindowmodulefilenamew
    [LibraryImport("USER32", StringMarshalling = StringMarshalling.Utf16)]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    public static partial uint GetWindowModuleFileNameW(HWND hwnd, [MarshalUsing(CountElementName = nameof(cchFileNameMax))] PWSTR pszFileName, uint cchFileNameMax);
    
    // https://learn.microsoft.com/windows/win32/api/winuser/nf-winuser-getwindowplacement
    [LibraryImport("USER32", SetLastError = true)]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial BOOL GetWindowPlacement(HWND hWnd, ref WINDOWPLACEMENT lpwndpl);
    
    // https://learn.microsoft.com/windows/win32/api/winuser/nf-winuser-getwindowrect
    [LibraryImport("USER32", SetLastError = true)]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial BOOL GetWindowRect(HWND hWnd, out RECT lpRect);
    
    // https://learn.microsoft.com/windows/win32/api/winuser/nf-winuser-getwindowrgn
    [LibraryImport("USER32")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    public static partial GDI_REGION_TYPE GetWindowRgn(HWND hWnd, HRGN hRgn);
    
    // https://learn.microsoft.com/windows/win32/api/winuser/nf-winuser-getwindowtextw
    [LibraryImport("USER32", StringMarshalling = StringMarshalling.Utf16, SetLastError = true)]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    public static partial int GetWindowTextW(HWND hWnd, [MarshalUsing(CountElementName = nameof(nMaxCount))] PWSTR lpString, int nMaxCount);
    
    // https://learn.microsoft.com/windows/win32/api/winuser/nf-winuser-getwindowthreadprocessid
    [LibraryImport("USER32")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    public static partial uint GetWindowThreadProcessId(HWND hWnd, nint /* optional uint* */ lpdwProcessId);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glaccum
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glAccum(uint op, float value);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glalphafunc
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glAlphaFunc(uint func, float @ref);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glaretexturesresident
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial byte glAreTexturesResident(int n, in uint textures, nint /* byte array */ residences);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glarrayelement
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glArrayElement(int i);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glbegin
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glBegin(uint mode);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glbindtexture
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glBindTexture(uint target, uint texture);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glbitmap
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glBitmap(int width, int height, float xorig, float yorig, float xmove, float ymove, nint /* byte array */ bitmap);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glblendfunc
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glBlendFunc(uint sfactor, uint dfactor);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glcalllist
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glCallList(uint list);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glcalllists
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glCallLists(int n, uint type, nint lists);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glclear
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glClear(uint mask);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glclearaccum
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glClearAccum(float red, float green, float blue, float alpha);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glclearcolor
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glClearColor(float red, float green, float blue, float alpha);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glcleardepth
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glClearDepth(double depth);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glclearindex
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glClearIndex(float c);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glclearstencil
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glClearStencil(int s);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glclipplane
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glClipPlane(uint plane, in double equation);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glcolor3b
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glColor3b(sbyte red, sbyte green, sbyte blue);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glcolor3bv
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glColor3bv(in sbyte v);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glcolor3d
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glColor3d(double red, double green, double blue);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glcolor3dv
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glColor3dv(in double v);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glcolor3f
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glColor3f(float red, float green, float blue);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glcolor3fv
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glColor3fv(in float v);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glcolor3i
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glColor3i(int red, int green, int blue);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glcolor3iv
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glColor3iv(in int v);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glcolor3s
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glColor3s(short red, short green, short blue);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glcolor3sv
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glColor3sv(in short v);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glcolor3ub
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glColor3ub(byte red, byte green, byte blue);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glcolor3ubv
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glColor3ubv(nint /* byte array */ v);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glcolor3ui
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glColor3ui(uint red, uint green, uint blue);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glcolor3uiv
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glColor3uiv(in uint v);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glcolor3us
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glColor3us(ushort red, ushort green, ushort blue);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glcolor3usv
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glColor3usv(in ushort v);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glcolor4b
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glColor4b(sbyte red, sbyte green, sbyte blue, sbyte alpha);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glcolor4bv
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glColor4bv(in sbyte v);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glcolor4d
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glColor4d(double red, double green, double blue, double alpha);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glcolor4dv
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glColor4dv(in double v);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glcolor4f
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glColor4f(float red, float green, float blue, float alpha);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glcolor4fv
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glColor4fv(in float v);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glcolor4i
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glColor4i(int red, int green, int blue, int alpha);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glcolor4iv
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glColor4iv(in int v);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glcolor4s
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glColor4s(short red, short green, short blue, short alpha);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glcolor4sv
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glColor4sv(in short v);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glcolor4ub
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glColor4ub(byte red, byte green, byte blue, byte alpha);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glcolor4ubv
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glColor4ubv(nint /* byte array */ v);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glcolor4ui
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glColor4ui(uint red, uint green, uint blue, uint alpha);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glcolor4uiv
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glColor4uiv(in uint v);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glcolor4us
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glColor4us(ushort red, ushort green, ushort blue, ushort alpha);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glcolor4usv
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glColor4usv(in ushort v);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glcolormask
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glColorMask(byte red, byte green, byte blue, byte alpha);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glcolormaterial
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glColorMaterial(uint face, uint mode);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glcolorpointer
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glColorPointer(int size, uint type, int stride, nint pointer);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glcopypixels
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glCopyPixels(int x, int y, int width, int height, uint type);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glcopyteximage1d
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glCopyTexImage1D(uint target, int level, uint internalFormat, int x, int y, int width, int border);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glcopyteximage2d
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glCopyTexImage2D(uint target, int level, uint internalFormat, int x, int y, int width, int height, int border);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glcopytexsubimage1d
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glCopyTexSubImage1D(uint target, int level, int xoffset, int x, int y, int width);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glcopytexsubimage2d
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glCopyTexSubImage2D(uint target, int level, int xoffset, int yoffset, int x, int y, int width, int height);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glcullface
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glCullFace(uint mode);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/gldeletelists
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glDeleteLists(uint list, int range);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/gldeletetextures
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glDeleteTextures(int n, in uint textures);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/gldepthfunc
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glDepthFunc(uint func);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/gldepthmask
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glDepthMask(byte flag);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/gldepthrange
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glDepthRange(double zNear, double zFar);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/gldisable
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glDisable(uint cap);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/gldisableclientstate
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glDisableClientState(uint array);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/gldrawarrays
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glDrawArrays(uint mode, int first, int count);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/gldrawbuffer
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glDrawBuffer(uint mode);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/gldrawelements
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glDrawElements(uint mode, int count, uint type, nint indices);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/gldrawpixels
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glDrawPixels(int width, int height, uint format, uint type, nint pixels);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/gledgeflag
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glEdgeFlag(byte flag);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/gledgeflagpointer
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glEdgeFlagPointer(int stride, nint pointer);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/gledgeflagv
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glEdgeFlagv(nint /* byte array */ flag);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glenable
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glEnable(uint cap);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glenableclientstate
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glEnableClientState(uint array);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glend
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glEnd();
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glendlist
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glEndList();
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glevalcoord1d
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glEvalCoord1d(double u);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glevalcoord1dv
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glEvalCoord1dv(in double u);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glevalcoord1f
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glEvalCoord1f(float u);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glevalcoord1fv
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glEvalCoord1fv(in float u);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glevalcoord2d
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glEvalCoord2d(double u, double v);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glevalcoord2dv
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glEvalCoord2dv(in double u);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glevalcoord2f
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glEvalCoord2f(float u, float v);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glevalcoord2fv
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glEvalCoord2fv(in float u);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glevalmesh1
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glEvalMesh1(uint mode, int i1, int i2);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glevalmesh2
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glEvalMesh2(uint mode, int i1, int i2, int j1, int j2);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glevalpoint1
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glEvalPoint1(int i);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glevalpoint2
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glEvalPoint2(int i, int j);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glfeedbackbuffer
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glFeedbackBuffer(int size, uint type, ref float buffer);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glfinish
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glFinish();
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glflush
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glFlush();
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glfogf
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glFogf(uint pname, float param1);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glfogfv
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glFogfv(uint pname, in float @params);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glfogi
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glFogi(uint pname, int param1);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glfogiv
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glFogiv(uint pname, in int @params);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glfrontface
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glFrontFace(uint mode);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glfrustum
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glFrustum(double left, double right, double bottom, double top, double zNear, double zFar);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glgenlists
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial uint glGenLists(int range);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glgentextures
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glGenTextures(int n, ref uint textures);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glgetbooleanv
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glGetBooleanv(uint pname, nint /* byte array */ @params);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glgetclipplane
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glGetClipPlane(uint plane, ref double equation);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glgetdoublev
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glGetDoublev(uint pname, ref double @params);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glgeterror
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial uint glGetError();
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glgetfloatv
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glGetFloatv(uint pname, ref float @params);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glgetintegerv
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glGetIntegerv(uint pname, ref int @params);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glgetlightfv
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glGetLightfv(uint light, uint pname, ref float @params);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glgetlightiv
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glGetLightiv(uint light, uint pname, ref int @params);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glgetmapdv
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glGetMapdv(uint target, uint query, ref double v);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glgetmapfv
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glGetMapfv(uint target, uint query, ref float v);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glgetmapiv
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glGetMapiv(uint target, uint query, ref int v);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glgetmaterialfv
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glGetMaterialfv(uint face, uint pname, ref float @params);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glgetmaterialiv
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glGetMaterialiv(uint face, uint pname, ref int @params);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glgetpixelmapfv
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glGetPixelMapfv(uint map, ref float values);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glgetpixelmapuiv
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glGetPixelMapuiv(uint map, ref uint values);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glgetpixelmapusv
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glGetPixelMapusv(uint map, ref ushort values);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glgetpointerv
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glGetPointerv(uint pname, out nint @params);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glgetpolygonstipple
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glGetPolygonStipple(nint /* byte array */ mask);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glgetstring
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial nint glGetString(uint name);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glgettexenvfv
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glGetTexEnvfv(uint target, uint pname, ref float @params);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glgettexenviv
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glGetTexEnviv(uint target, uint pname, ref int @params);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glgettexgendv
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glGetTexGendv(uint coord, uint pname, ref double @params);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glgettexgenfv
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glGetTexGenfv(uint coord, uint pname, ref float @params);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glgettexgeniv
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glGetTexGeniv(uint coord, uint pname, ref int @params);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glgetteximage
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glGetTexImage(uint target, int level, uint format, uint type, nint pixels);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glgettexlevelparameterfv
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glGetTexLevelParameterfv(uint target, int level, uint pname, ref float @params);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glgettexlevelparameteriv
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glGetTexLevelParameteriv(uint target, int level, uint pname, ref int @params);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glgettexparameterfv
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glGetTexParameterfv(uint target, uint pname, ref float @params);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glgettexparameteriv
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glGetTexParameteriv(uint target, uint pname, ref int @params);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glhint
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glHint(uint target, uint mode);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glindexd
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glIndexd(double c);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glindexdv
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glIndexdv(in double c);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glindexf
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glIndexf(float c);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glindexfv
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glIndexfv(in float c);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glindexi
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glIndexi(int c);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glindexiv
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glIndexiv(in int c);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glindexmask
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glIndexMask(uint mask);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glindexpointer
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glIndexPointer(uint type, int stride, nint pointer);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glindexs
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glIndexs(short c);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glindexsv
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glIndexsv(in short c);
    
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glIndexub(byte c);
    
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glIndexubv(nint /* byte array */ c);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glinitnames
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glInitNames();
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glinterleavedarrays
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glInterleavedArrays(uint format, int stride, nint pointer);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glisenabled
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial byte glIsEnabled(uint cap);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glislist
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial byte glIsList(uint list);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glistexture
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial byte glIsTexture(uint texture);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/gllightf
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glLightf(uint light, uint pname, float param2);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/gllightfv
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glLightfv(uint light, uint pname, in float @params);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/gllighti
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glLighti(uint light, uint pname, int param2);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/gllightiv
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glLightiv(uint light, uint pname, in int @params);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/gllightmodelf
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glLightModelf(uint pname, float param1);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/gllightmodelfv
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glLightModelfv(uint pname, in float @params);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/gllightmodeli
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glLightModeli(uint pname, int param1);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/gllightmodeliv
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glLightModeliv(uint pname, in int @params);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/gllinestipple
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glLineStipple(int factor, ushort pattern);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/gllinewidth
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glLineWidth(float width);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/gllistbase
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glListBase(uint @base);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glloadidentity
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glLoadIdentity();
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glloadmatrixd
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glLoadMatrixd(in double m);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glloadmatrixf
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glLoadMatrixf(in float m);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glloadname
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glLoadName(uint name);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/gllogicop
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glLogicOp(uint opcode);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glmap1d
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glMap1d(uint target, double u1, double u2, int stride, int order, in double points);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glmap1f
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glMap1f(uint target, float u1, float u2, int stride, int order, in float points);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glmap2d
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glMap2d(uint target, double u1, double u2, int ustride, int uorder, double v1, double v2, int vstride, int vorder, in double points);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glmap2f
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glMap2f(uint target, float u1, float u2, int ustride, int uorder, float v1, float v2, int vstride, int vorder, in float points);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glmapgrid1d
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glMapGrid1d(int un, double u1, double u2);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glmapgrid1f
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glMapGrid1f(int un, float u1, float u2);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glmapgrid2d
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glMapGrid2d(int un, double u1, double u2, int vn, double v1, double v2);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glmapgrid2f
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glMapGrid2f(int un, float u1, float u2, int vn, float v1, float v2);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glmaterialf
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glMaterialf(uint face, uint pname, float param2);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glmaterialfv
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glMaterialfv(uint face, uint pname, in float @params);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glmateriali
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glMateriali(uint face, uint pname, int param2);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glmaterialiv
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glMaterialiv(uint face, uint pname, in int @params);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glmatrixmode
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glMatrixMode(uint mode);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glmultmatrixd
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glMultMatrixd(in double m);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glmultmatrixf
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glMultMatrixf(in float m);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glnewlist
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glNewList(uint list, uint mode);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glnormal3b
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glNormal3b(sbyte nx, sbyte ny, sbyte nz);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glnormal3bv
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glNormal3bv(in sbyte v);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glnormal3d
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glNormal3d(double nx, double ny, double nz);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glnormal3dv
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glNormal3dv(in double v);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glnormal3f
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glNormal3f(float nx, float ny, float nz);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glnormal3fv
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glNormal3fv(in float v);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glnormal3i
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glNormal3i(int nx, int ny, int nz);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glnormal3iv
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glNormal3iv(in int v);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glnormal3s
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glNormal3s(short nx, short ny, short nz);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glnormal3sv
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glNormal3sv(in short v);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glnormalpointer
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glNormalPointer(uint type, int stride, nint pointer);
    
    // https://learn.microsoft.com/windows/win32/api/winbase/nf-winbase-globallock
    [LibraryImport("KERNEL32", SetLastError = true)]
    [SupportedOSPlatform("windows5.1.2600")]
    [PreserveSig]
    public static partial nint GlobalLock(HGLOBAL hMem);
    
    // https://learn.microsoft.com/windows/win32/api/sysinfoapi/nf-sysinfoapi-globalmemorystatusex
    [LibraryImport("KERNEL32", SetLastError = true)]
    [SupportedOSPlatform("windows5.1.2600")]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial BOOL GlobalMemoryStatusEx(ref MEMORYSTATUSEX lpBuffer);
    
    // https://learn.microsoft.com/windows/win32/api/winbase/nf-winbase-globalsize
    [LibraryImport("KERNEL32", SetLastError = true)]
    [SupportedOSPlatform("windows5.1.2600")]
    [PreserveSig]
    public static partial nuint GlobalSize(HGLOBAL hMem);
    
    // https://learn.microsoft.com/windows/win32/api/winbase/nf-winbase-globalunlock
    [LibraryImport("KERNEL32", SetLastError = true)]
    [SupportedOSPlatform("windows5.1.2600")]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial BOOL GlobalUnlock(HGLOBAL hMem);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glortho
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glOrtho(double left, double right, double bottom, double top, double zNear, double zFar);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glpassthrough
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glPassThrough(float token);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glpixelmapfv
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glPixelMapfv(uint map, int mapsize, in float values);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glpixelmapuiv
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glPixelMapuiv(uint map, int mapsize, in uint values);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glpixelmapusv
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glPixelMapusv(uint map, int mapsize, in ushort values);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glpixelstoref
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glPixelStoref(uint pname, float param1);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glpixelstorei
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glPixelStorei(uint pname, int param1);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glpixeltransferf
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glPixelTransferf(uint pname, float param1);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glpixeltransferi
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glPixelTransferi(uint pname, int param1);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glpixelzoom
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glPixelZoom(float xfactor, float yfactor);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glpointsize
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glPointSize(float size);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glpolygonmode
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glPolygonMode(uint face, uint mode);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glpolygonoffset
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glPolygonOffset(float factor, float units);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glpolygonstipple
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glPolygonStipple(nint /* byte array */ mask);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glpopattrib
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glPopAttrib();
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glpopclientattrib
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glPopClientAttrib();
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glpopmatrix
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glPopMatrix();
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glpopname
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glPopName();
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glprioritizetextures
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glPrioritizeTextures(int n, in uint textures, in float priorities);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glpushattrib
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glPushAttrib(uint mask);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glpushclientattrib
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glPushClientAttrib(uint mask);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glpushmatrix
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glPushMatrix();
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glpushname
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glPushName(uint name);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glrasterpos2d
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glRasterPos2d(double x, double y);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glrasterpos2dv
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glRasterPos2dv(in double v);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glrasterpos2f
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glRasterPos2f(float x, float y);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glrasterpos2fv
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glRasterPos2fv(in float v);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glrasterpos2i
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glRasterPos2i(int x, int y);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glrasterpos2iv
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glRasterPos2iv(in int v);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glrasterpos2s
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glRasterPos2s(short x, short y);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glrasterpos2sv
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glRasterPos2sv(in short v);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glrasterpos3d
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glRasterPos3d(double x, double y, double z);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glrasterpos3dv
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glRasterPos3dv(in double v);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glrasterpos3f
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glRasterPos3f(float x, float y, float z);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glrasterpos3fv
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glRasterPos3fv(in float v);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glrasterpos3i
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glRasterPos3i(int x, int y, int z);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glrasterpos3iv
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glRasterPos3iv(in int v);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glrasterpos3s
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glRasterPos3s(short x, short y, short z);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glrasterpos3sv
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glRasterPos3sv(in short v);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glrasterpos4d
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glRasterPos4d(double x, double y, double z, double w);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glrasterpos4dv
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glRasterPos4dv(in double v);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glrasterpos4f
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glRasterPos4f(float x, float y, float z, float w);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glrasterpos4fv
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glRasterPos4fv(in float v);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glrasterpos4i
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glRasterPos4i(int x, int y, int z, int w);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glrasterpos4iv
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glRasterPos4iv(in int v);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glrasterpos4s
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glRasterPos4s(short x, short y, short z, short w);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glrasterpos4sv
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glRasterPos4sv(in short v);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glreadbuffer
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glReadBuffer(uint mode);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glreadpixels
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glReadPixels(int x, int y, int width, int height, uint format, uint type, nint pixels);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glrectd
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glRectd(double x1, double y1, double x2, double y2);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glrectdv
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glRectdv(in double v1, in double v2);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glrectf
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glRectf(float x1, float y1, float x2, float y2);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glrectfv
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glRectfv(in float v1, in float v2);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glrecti
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glRecti(int x1, int y1, int x2, int y2);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glrectiv
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glRectiv(in int v1, in int v2);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glrects
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glRects(short x1, short y1, short x2, short y2);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glrectsv
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glRectsv(in short v1, in short v2);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glrendermode
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial int glRenderMode(uint mode);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glrotated
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glRotated(double angle, double x, double y, double z);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glrotatef
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glRotatef(float angle, float x, float y, float z);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glscaled
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glScaled(double x, double y, double z);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glscalef
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glScalef(float x, float y, float z);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glscissor
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glScissor(int x, int y, int width, int height);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glselectbuffer
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glSelectBuffer(int size, ref uint buffer);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glshademodel
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glShadeModel(uint mode);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glstencilfunc
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glStencilFunc(uint func, int @ref, uint mask);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glstencilmask
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glStencilMask(uint mask);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glstencilop
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glStencilOp(uint fail, uint zfail, uint zpass);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/gltexcoord1d
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glTexCoord1d(double s);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/gltexcoord1dv
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glTexCoord1dv(in double v);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/gltexcoord1f
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glTexCoord1f(float s);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/gltexcoord1fv
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glTexCoord1fv(in float v);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/gltexcoord1i
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glTexCoord1i(int s);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/gltexcoord1iv
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glTexCoord1iv(in int v);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/gltexcoord1s
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glTexCoord1s(short s);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/gltexcoord1sv
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glTexCoord1sv(in short v);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/gltexcoord2d
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glTexCoord2d(double s, double t);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/gltexcoord2dv
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glTexCoord2dv(in double v);
    
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glTexCoord2f(float s, float t);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/gltexcoord2fv
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glTexCoord2fv(in float v);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/gltexcoord2i
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glTexCoord2i(int s, int t);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/gltexcoord2iv
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glTexCoord2iv(in int v);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/gltexcoord2s
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glTexCoord2s(short s, short t);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/gltexcoord2sv
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glTexCoord2sv(in short v);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/gltexcoord3d
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glTexCoord3d(double s, double t, double r);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/gltexcoord3dv
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glTexCoord3dv(in double v);
    
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glTexCoord3f(float s, float t, float r);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/gltexcoord3fv
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glTexCoord3fv(in float v);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/gltexcoord3i
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glTexCoord3i(int s, int t, int r);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/gltexcoord3iv
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glTexCoord3iv(in int v);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/gltexcoord3s
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glTexCoord3s(short s, short t, short r);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/gltexcoord3sv
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glTexCoord3sv(in short v);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/gltexcoord4d
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glTexCoord4d(double s, double t, double r, double q);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/gltexcoord4dv
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glTexCoord4dv(in double v);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/gltexcoord4f
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glTexCoord4f(float s, float t, float r, float q);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/gltexcoord4fv
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glTexCoord4fv(in float v);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/gltexcoord4i
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glTexCoord4i(int s, int t, int r, int q);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/gltexcoord4iv
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glTexCoord4iv(in int v);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/gltexcoord4s
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glTexCoord4s(short s, short t, short r, short q);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/gltexcoord4sv
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glTexCoord4sv(in short v);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/gltexcoordpointer
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glTexCoordPointer(int size, uint type, int stride, nint pointer);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/gltexenvf
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glTexEnvf(uint target, uint pname, float param2);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/gltexenvfv
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glTexEnvfv(uint target, uint pname, in float @params);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/gltexenvi
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glTexEnvi(uint target, uint pname, int param2);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/gltexenviv
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glTexEnviv(uint target, uint pname, in int @params);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/gltexgend
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glTexGend(uint coord, uint pname, double param2);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/gltexgendv
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glTexGendv(uint coord, uint pname, in double @params);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/gltexgenf
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glTexGenf(uint coord, uint pname, float param2);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/gltexgenfv
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glTexGenfv(uint coord, uint pname, in float @params);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/gltexgeni
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glTexGeni(uint coord, uint pname, int param2);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/gltexgeniv
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glTexGeniv(uint coord, uint pname, in int @params);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glteximage1d
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glTexImage1D(uint target, int level, int internalformat, int width, int border, uint format, uint type, nint pixels);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glteximage2d
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glTexImage2D(uint target, int level, int internalformat, int width, int height, int border, uint format, uint type, nint pixels);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/gltexparameterf
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glTexParameterf(uint target, uint pname, float param2);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/gltexparameterfv
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glTexParameterfv(uint target, uint pname, in float @params);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/gltexparameteri
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glTexParameteri(uint target, uint pname, int param2);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/gltexparameteriv
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glTexParameteriv(uint target, uint pname, in int @params);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/gltexsubimage1d
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glTexSubImage1D(uint target, int level, int xoffset, int width, uint format, uint type, nint pixels);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/gltexsubimage2d
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glTexSubImage2D(uint target, int level, int xoffset, int yoffset, int width, int height, uint format, uint type, nint pixels);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/gltranslated
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glTranslated(double x, double y, double z);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/gltranslatef
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glTranslatef(float x, float y, float z);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glubegincurve
    [LibraryImport("GLU32")]
    [PreserveSig]
    public static partial void gluBeginCurve(ref GLUnurbs nobj);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glubeginpolygon
    [LibraryImport("GLU32")]
    [PreserveSig]
    public static partial void gluBeginPolygon(ref GLUtesselator tess);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glubeginsurface
    [LibraryImport("GLU32")]
    [PreserveSig]
    public static partial void gluBeginSurface(ref GLUnurbs nobj);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glubegintrim
    [LibraryImport("GLU32")]
    [PreserveSig]
    public static partial void gluBeginTrim(ref GLUnurbs nobj);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glubuild1dmipmaps
    [LibraryImport("GLU32")]
    [PreserveSig]
    public static partial int gluBuild1DMipmaps(uint target, int components, int width, uint format, uint type, nint data);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glubuild2dmipmaps
    [LibraryImport("GLU32")]
    [PreserveSig]
    public static partial int gluBuild2DMipmaps(uint target, int components, int width, int height, uint format, uint type, nint data);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glucylinder
    [LibraryImport("GLU32")]
    [PreserveSig]
    public static partial void gluCylinder(ref GLUquadric qobj, double baseRadius, double topRadius, double height, int slices, int stacks);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/gludeletenurbsrenderer
    [LibraryImport("GLU32")]
    [PreserveSig]
    public static partial void gluDeleteNurbsRenderer(ref GLUnurbs nobj);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/gludeletequadric
    [LibraryImport("GLU32")]
    [PreserveSig]
    public static partial void gluDeleteQuadric(ref GLUquadric state);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/gludeletetess
    [LibraryImport("GLU32")]
    [PreserveSig]
    public static partial void gluDeleteTess(ref GLUtesselator tess);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/gludisk
    [LibraryImport("GLU32")]
    [PreserveSig]
    public static partial void gluDisk(ref GLUquadric qobj, double innerRadius, double outerRadius, int slices, int loops);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/gluendcurve
    [LibraryImport("GLU32")]
    [PreserveSig]
    public static partial void gluEndCurve(ref GLUnurbs nobj);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/gluendpolygon
    [LibraryImport("GLU32")]
    [PreserveSig]
    public static partial void gluEndPolygon(ref GLUtesselator tess);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/gluendsurface
    [LibraryImport("GLU32")]
    [PreserveSig]
    public static partial void gluEndSurface(ref GLUnurbs nobj);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/gluendtrim
    [LibraryImport("GLU32")]
    [PreserveSig]
    public static partial void gluEndTrim(ref GLUnurbs nobj);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/gluerrorstring
    [LibraryImport("GLU32")]
    [PreserveSig]
    public static partial nint gluErrorString(uint errCode);
    
    [LibraryImport("GLU32")]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial PWSTR gluErrorUnicodeStringEXT(uint errCode);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glugetnurbsproperty
    [LibraryImport("GLU32")]
    [PreserveSig]
    public static partial void gluGetNurbsProperty(ref GLUnurbs nobj, uint property, ref float value);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glugetstring
    [LibraryImport("GLU32")]
    [PreserveSig]
    public static partial nint gluGetString(uint name);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glugettessproperty
    [LibraryImport("GLU32")]
    [PreserveSig]
    public static partial void gluGetTessProperty(ref GLUtesselator tess, uint which, ref double value);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/gluloadsamplingmatrices
    [LibraryImport("GLU32")]
    [PreserveSig]
    public static partial void gluLoadSamplingMatrices(ref GLUnurbs nobj, in float modelMatrix, in float projMatrix, in int viewport);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glulookat
    [LibraryImport("GLU32")]
    [PreserveSig]
    public static partial void gluLookAt(double eyex, double eyey, double eyez, double centerx, double centery, double centerz, double upx, double upy, double upz);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glunewnurbsrenderer
    [LibraryImport("GLU32")]
    [PreserveSig]
    public static partial nint gluNewNurbsRenderer();
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glunewquadric
    [LibraryImport("GLU32")]
    [PreserveSig]
    public static partial nint gluNewQuadric();
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glunewtess
    [LibraryImport("GLU32")]
    [PreserveSig]
    public static partial nint gluNewTess();
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glunextcontour
    [LibraryImport("GLU32")]
    [PreserveSig]
    public static partial void gluNextContour(ref GLUtesselator tess, uint type);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glunurbs
    [LibraryImport("GLU32")]
    [PreserveSig]
    public static partial void gluNurbsCallback(ref GLUnurbs nobj, uint which, nint fn);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glunurbscurve
    [LibraryImport("GLU32")]
    [PreserveSig]
    public static partial void gluNurbsCurve(ref GLUnurbs nobj, int nknots, ref float knot, int stride, ref float ctlarray, int order, uint type);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glunurbsproperty
    [LibraryImport("GLU32")]
    [PreserveSig]
    public static partial void gluNurbsProperty(ref GLUnurbs nobj, uint property, float value);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glunurbssurface
    [LibraryImport("GLU32")]
    [PreserveSig]
    public static partial void gluNurbsSurface(ref GLUnurbs nobj, int sknot_count, ref float sknot, int tknot_count, ref float tknot, int s_stride, int t_stride, ref float ctlarray, int sorder, int torder, uint type);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/gluortho2d
    [LibraryImport("GLU32")]
    [PreserveSig]
    public static partial void gluOrtho2D(double left, double right, double bottom, double top);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glupartialdisk
    [LibraryImport("GLU32")]
    [PreserveSig]
    public static partial void gluPartialDisk(ref GLUquadric qobj, double innerRadius, double outerRadius, int slices, int loops, double startAngle, double sweepAngle);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/gluperspective
    [LibraryImport("GLU32")]
    [PreserveSig]
    public static partial void gluPerspective(double fovy, double aspect, double zNear, double zFar);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glupickmatrix
    [LibraryImport("GLU32")]
    [PreserveSig]
    public static partial void gluPickMatrix(double x, double y, double width, double height, ref int viewport);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/gluproject
    [LibraryImport("GLU32")]
    [PreserveSig]
    public static partial int gluProject(double objx, double objy, double objz, in double modelMatrix, in double projMatrix, in int viewport, ref double winx, ref double winy, ref double winz);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glupwlcurve
    [LibraryImport("GLU32")]
    [PreserveSig]
    public static partial void gluPwlCurve(ref GLUnurbs nobj, int count, ref float array, int stride, uint type);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/gluquadric
    [LibraryImport("GLU32")]
    [PreserveSig]
    public static partial void gluQuadricCallback(ref GLUquadric qobj, uint which, nint fn);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/gluquadricdrawstyle
    [LibraryImport("GLU32")]
    [PreserveSig]
    public static partial void gluQuadricDrawStyle(ref GLUquadric quadObject, uint drawStyle);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/gluquadricnormals
    [LibraryImport("GLU32")]
    [PreserveSig]
    public static partial void gluQuadricNormals(ref GLUquadric quadObject, uint normals);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/gluquadricorientation
    [LibraryImport("GLU32")]
    [PreserveSig]
    public static partial void gluQuadricOrientation(ref GLUquadric quadObject, uint orientation);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/gluquadrictexture
    [LibraryImport("GLU32")]
    [PreserveSig]
    public static partial void gluQuadricTexture(ref GLUquadric quadObject, byte textureCoords);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/gluscaleimage
    [LibraryImport("GLU32")]
    [PreserveSig]
    public static partial int gluScaleImage(uint format, int widthin, int heightin, uint typein, nint datain, int widthout, int heightout, uint typeout, nint dataout);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glusphere
    [LibraryImport("GLU32")]
    [PreserveSig]
    public static partial void gluSphere(ref GLUquadric qobj, double radius, int slices, int stacks);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glutessbegincontour
    [LibraryImport("GLU32")]
    [PreserveSig]
    public static partial void gluTessBeginContour(ref GLUtesselator tess);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glutessbeginpolygon
    [LibraryImport("GLU32")]
    [PreserveSig]
    public static partial void gluTessBeginPolygon(ref GLUtesselator tess, nint polygon_data);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glutess
    [LibraryImport("GLU32")]
    [PreserveSig]
    public static partial void gluTessCallback(ref GLUtesselator tess, uint which, nint fn);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glutessendcontour
    [LibraryImport("GLU32")]
    [PreserveSig]
    public static partial void gluTessEndContour(ref GLUtesselator tess);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glutessendpolygon
    [LibraryImport("GLU32")]
    [PreserveSig]
    public static partial void gluTessEndPolygon(ref GLUtesselator tess);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glutessnormal
    [LibraryImport("GLU32")]
    [PreserveSig]
    public static partial void gluTessNormal(ref GLUtesselator tess, double x, double y, double z);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glutessproperty
    [LibraryImport("GLU32")]
    [PreserveSig]
    public static partial void gluTessProperty(ref GLUtesselator tess, uint which, double value);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glutessvertex
    [LibraryImport("GLU32")]
    [PreserveSig]
    public static partial void gluTessVertex(ref GLUtesselator tess, ref double coords, nint data);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/gluunproject
    [LibraryImport("GLU32")]
    [PreserveSig]
    public static partial int gluUnProject(double winx, double winy, double winz, in double modelMatrix, in double projMatrix, in int viewport, ref double objx, ref double objy, ref double objz);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glvertex2d
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glVertex2d(double x, double y);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glvertex2dv
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glVertex2dv(in double v);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glvertex2f
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glVertex2f(float x, float y);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glvertex2fv
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glVertex2fv(in float v);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glvertex2i
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glVertex2i(int x, int y);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glvertex2iv
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glVertex2iv(in int v);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glvertex2s
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glVertex2s(short x, short y);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glvertex2sv
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glVertex2sv(in short v);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glvertex3d
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glVertex3d(double x, double y, double z);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glvertex3dv
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glVertex3dv(in double v);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glvertex3f
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glVertex3f(float x, float y, float z);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glvertex3fv
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glVertex3fv(in float v);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glvertex3i
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glVertex3i(int x, int y, int z);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glvertex3iv
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glVertex3iv(in int v);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glvertex3s
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glVertex3s(short x, short y, short z);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glvertex3sv
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glVertex3sv(in short v);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glvertex4d
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glVertex4d(double x, double y, double z, double w);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glvertex4dv
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glVertex4dv(in double v);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glvertex4f
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glVertex4f(float x, float y, float z, float w);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glvertex4fv
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glVertex4fv(in float v);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glvertex4i
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glVertex4i(int x, int y, int z, int w);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glvertex4iv
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glVertex4iv(in int v);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glvertex4s
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glVertex4s(short x, short y, short z, short w);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glvertex4sv
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glVertex4sv(in short v);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glvertexpointer
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glVertexPointer(int size, uint type, int stride, nint pointer);
    
    // https://learn.microsoft.com/windows/win32/OpenGL/glviewport
    [LibraryImport("OPENGL32")]
    [PreserveSig]
    public static partial void glViewport(int x, int y, int width, int height);
    
    // https://learn.microsoft.com/windows/win32/api/remotesystemadditionalinfo/nf-remotesystemadditionalinfo-hstring_userfree
    [LibraryImport("api-ms-win-core-winrt-string-l1-1-0")]
    [SupportedOSPlatform("windows8.0")]
    [PreserveSig]
    public static partial void HSTRING_UserFree(in uint param0, in HSTRING param1);
    
    // https://learn.microsoft.com/windows/win32/api/remotesystemadditionalinfo/nf-remotesystemadditionalinfo-hstring_userfree64
    [LibraryImport("api-ms-win-core-winrt-string-l1-1-0")]
    [SupportedOSPlatform("windows8.0")]
    [PreserveSig]
    public static partial void HSTRING_UserFree64(in uint param0, in HSTRING param1);
    
    // https://learn.microsoft.com/windows/win32/api/remotesystemadditionalinfo/nf-remotesystemadditionalinfo-hstring_usermarshal
    [LibraryImport("api-ms-win-core-winrt-string-l1-1-0")]
    [SupportedOSPlatform("windows8.0")]
    [PreserveSig]
    public static partial nint HSTRING_UserMarshal(in uint param0, nint /* byte array */ param1, in HSTRING param2);
    
    // https://learn.microsoft.com/windows/win32/api/remotesystemadditionalinfo/nf-remotesystemadditionalinfo-hstring_usermarshal64
    [LibraryImport("api-ms-win-core-winrt-string-l1-1-0")]
    [SupportedOSPlatform("windows8.0")]
    [PreserveSig]
    public static partial nint HSTRING_UserMarshal64(in uint param0, nint /* byte array */ param1, in HSTRING param2);
    
    // https://learn.microsoft.com/windows/win32/api/remotesystemadditionalinfo/nf-remotesystemadditionalinfo-hstring_usersize
    [LibraryImport("api-ms-win-core-winrt-string-l1-1-0")]
    [SupportedOSPlatform("windows8.0")]
    [PreserveSig]
    public static partial uint HSTRING_UserSize(in uint param0, uint param1, in HSTRING param2);
    
    // https://learn.microsoft.com/windows/win32/api/remotesystemadditionalinfo/nf-remotesystemadditionalinfo-hstring_usersize64
    [LibraryImport("api-ms-win-core-winrt-string-l1-1-0")]
    [SupportedOSPlatform("windows8.0")]
    [PreserveSig]
    public static partial uint HSTRING_UserSize64(in uint param0, uint param1, in HSTRING param2);
    
    // https://learn.microsoft.com/windows/win32/api/remotesystemadditionalinfo/nf-remotesystemadditionalinfo-hstring_userunmarshal
    [LibraryImport("api-ms-win-core-winrt-string-l1-1-0")]
    [SupportedOSPlatform("windows8.0")]
    [PreserveSig]
    public static partial nint HSTRING_UserUnmarshal(in uint param0, nint /* byte array */ param1, out HSTRING param2);
    
    // https://learn.microsoft.com/windows/win32/api/remotesystemadditionalinfo/nf-remotesystemadditionalinfo-hstring_userunmarshal64
    [LibraryImport("api-ms-win-core-winrt-string-l1-1-0")]
    [SupportedOSPlatform("windows8.0")]
    [PreserveSig]
    public static partial nint HSTRING_UserUnmarshal64(in uint param0, nint /* byte array */ param1, out HSTRING param2);
    
    // https://learn.microsoft.com/windows/win32/api/winddi/nf-winddi-ht_get8bppformatpalette
    [LibraryImport("GDI32")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    public static partial int HT_Get8BPPFormatPalette(nint /* optional PALETTEENTRY* */ pPaletteEntry, ushort RedGamma, ushort GreenGamma, ushort BlueGamma);
    
    // https://learn.microsoft.com/windows/win32/api/winddi/nf-winddi-ht_get8bppmaskpalette
    [LibraryImport("GDI32")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    public static partial int HT_Get8BPPMaskPalette(nint /* optional PALETTEENTRY* */ pPaletteEntry, BOOL Use8BPPMaskPal, byte CMYMask, ushort RedGamma, ushort GreenGamma, ushort BlueGamma);
    
    // https://learn.microsoft.com/windows/win32/api/vfw/nf-vfw-icclose
    [LibraryImport("MSVFW32")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial LRESULT ICClose(HIC hic);
    
    // https://learn.microsoft.com/windows/win32/api/vfw/nf-vfw-iccompress
    [LibraryImport("MSVFW32")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    public static partial uint ICCompress(HIC hic, uint dwFlags, in BITMAPINFOHEADER lpbiOutput, nint lpData, in BITMAPINFOHEADER lpbiInput, nint lpBits, nint /* optional uint* */ lpckid, nint /* optional uint* */ lpdwFlags, int lFrameNum, uint dwFrameSize, uint dwQuality, nint /* optional BITMAPINFOHEADER* */ lpbiPrev, nint /* optional void* */ lpPrev);
    
    // https://learn.microsoft.com/windows/win32/api/vfw/nf-vfw-iccompressorchoose
    [LibraryImport("MSVFW32", SetLastError = true)]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial BOOL ICCompressorChoose(HWND hwnd, uint uiFlags, nint /* optional void* */ pvIn, nint /* optional void* */ lpData, ref COMPVARS pc, PSTR lpszTitle);
    
    // https://learn.microsoft.com/windows/win32/api/vfw/nf-vfw-iccompressorfree
    [LibraryImport("MSVFW32")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    public static partial void ICCompressorFree(in COMPVARS pc);
    
    // https://learn.microsoft.com/windows/win32/api/vfw/nf-vfw-icdecompress
    [LibraryImport("MSVFW32")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    public static partial uint ICDecompress(HIC hic, uint dwFlags, in BITMAPINFOHEADER lpbiFormat, nint lpData, in BITMAPINFOHEADER lpbi, nint lpBits);
    
    // https://learn.microsoft.com/windows/win32/api/vfw/nf-vfw-icdraw
    [LibraryImport("MSVFW32")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    public static partial uint ICDraw(HIC hic, uint dwFlags, nint lpFormat, nint /* optional void* */ lpData, uint cbData, int lTime);
    
    // https://learn.microsoft.com/windows/win32/api/vfw/nf-vfw-icdrawbegin
    [LibraryImport("MSVFW32")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    public static partial uint ICDrawBegin(HIC hic, uint dwFlags, HPALETTE hpal, HWND hwnd, HDC hdc, int xDst, int yDst, int dxDst, int dyDst, in BITMAPINFOHEADER lpbi, int xSrc, int ySrc, int dxSrc, int dySrc, uint dwRate, uint dwScale);
    
    // https://learn.microsoft.com/windows/win32/api/vfw/nf-vfw-icgetdisplayformat
    [LibraryImport("MSVFW32")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial HIC ICGetDisplayFormat(HIC hic, in BITMAPINFOHEADER lpbiIn, out BITMAPINFOHEADER lpbiOut, int BitDepth, int dx, int dy);
    
    // https://learn.microsoft.com/windows/win32/api/vfw/nf-vfw-icgetinfo
    [LibraryImport("MSVFW32")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial LRESULT ICGetInfo(HIC hic, nint picinfo, uint cb);
    
    // https://learn.microsoft.com/windows/win32/api/vfw/nf-vfw-icimagecompress
    [LibraryImport("MSVFW32")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial HANDLE ICImageCompress(HIC hic, uint uiFlags, in BITMAPINFO lpbiIn, nint lpBits, nint /* optional BITMAPINFO* */ lpbiOut, int lQuality, nint /* optional int* */ plSize);
    
    // https://learn.microsoft.com/windows/win32/api/vfw/nf-vfw-icimagedecompress
    [LibraryImport("MSVFW32")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial HANDLE ICImageDecompress(HIC hic, uint uiFlags, in BITMAPINFO lpbiIn, nint lpBits, nint /* optional BITMAPINFO* */ lpbiOut);
    
    // https://learn.microsoft.com/windows/win32/api/vfw/nf-vfw-icinfo
    [LibraryImport("MSVFW32", SetLastError = true)]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial BOOL ICInfo(uint fccType, uint fccHandler, out ICINFO lpicinfo);
    
    // https://learn.microsoft.com/windows/win32/api/vfw/nf-vfw-icinstall
    [LibraryImport("MSVFW32", SetLastError = true)]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial BOOL ICInstall(uint fccType, uint fccHandler, LPARAM lParam, PSTR szDesc, uint wFlags);
    
    // https://learn.microsoft.com/windows/win32/api/vfw/nf-vfw-iclocate
    [LibraryImport("MSVFW32")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial HIC ICLocate(uint fccType, uint fccHandler, in BITMAPINFOHEADER lpbiIn, nint /* optional BITMAPINFOHEADER* */ lpbiOut, ushort wFlags);
    
    // https://learn.microsoft.com/windows/win32/api/vfw/nf-vfw-icopen
    [LibraryImport("MSVFW32")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial HIC ICOpen(uint fccType, uint fccHandler, uint wMode);
    
    // https://learn.microsoft.com/windows/win32/api/vfw/nf-vfw-icopenfunction
    [LibraryImport("MSVFW32")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial HIC ICOpenFunction(uint fccType, uint fccHandler, uint wMode, nint lpfnHandler);
    
    // https://learn.microsoft.com/windows/win32/api/vfw/nf-vfw-icremove
    [LibraryImport("MSVFW32", SetLastError = true)]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial BOOL ICRemove(uint fccType, uint fccHandler, uint wFlags);
    
    // https://learn.microsoft.com/windows/win32/api/vfw/nf-vfw-icsendmessage
    [LibraryImport("MSVFW32")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial LRESULT ICSendMessage(HIC hic, uint msg, nuint dw1, nuint dw2);
    
    // https://learn.microsoft.com/windows/win32/api/vfw/nf-vfw-icseqcompressframe
    [LibraryImport("MSVFW32")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    public static partial nint ICSeqCompressFrame(in COMPVARS pc, uint uiFlags, nint lpBits, out BOOL pfKey, nint /* optional int* */ plSize);
    
    // https://learn.microsoft.com/windows/win32/api/vfw/nf-vfw-icseqcompressframeend
    [LibraryImport("MSVFW32")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    public static partial void ICSeqCompressFrameEnd(in COMPVARS pc);
    
    // https://learn.microsoft.com/windows/win32/api/vfw/nf-vfw-icseqcompressframestart
    [LibraryImport("MSVFW32", SetLastError = true)]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial BOOL ICSeqCompressFrameStart(in COMPVARS pc, in BITMAPINFO lpbiIn);
    
    // https://learn.microsoft.com/windows/win32/api/winuser/nf-winuser-inflaterect
    [LibraryImport("USER32", SetLastError = true)]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial BOOL InflateRect(ref RECT lprc, int dx, int dy);
    
    // https://learn.microsoft.com/windows/win32/api/commctrl/nf-commctrl-initcommoncontrolsex
    [LibraryImport("COMCTL32", SetLastError = true)]
    [SupportedOSPlatform("windows6.0.6000")]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial BOOL InitCommonControlsEx(in INITCOMMONCONTROLSEX picce);
    
    // https://learn.microsoft.com/windows/win32/api/propvarutil/nf-propvarutil-initpropvariantfromfiletime
    [LibraryImport("PROPSYS")]
    [SupportedOSPlatform("windows5.1.2600")]
    [PreserveSig]
    public static partial HRESULT InitPropVariantFromFileTime(in FILETIME pftIn, out PROPVARIANT ppropvar);
    
    // https://learn.microsoft.com/windows/win32/api/propvarutil/nf-propvarutil-initvariantfromfiletime
    [LibraryImport("PROPSYS")]
    [SupportedOSPlatform("windows5.1.2600")]
    [PreserveSig]
    public static partial HRESULT InitVariantFromFileTime(in FILETIME pft, out VARIANT pvar);
    
    // https://learn.microsoft.com/windows/win32/api/icm/nf-icm-installcolorprofilea
    [LibraryImport("mscms", SetLastError = true)]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial BOOL InstallColorProfileA(PSTR pMachineName, PSTR pProfileName);
    
    // https://learn.microsoft.com/windows/win32/api/icm/nf-icm-installcolorprofilew
    [LibraryImport("mscms", StringMarshalling = StringMarshalling.Utf16, SetLastError = true)]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial BOOL InstallColorProfileW(PWSTR pMachineName, PWSTR pProfileName);
    
    // https://learn.microsoft.com/windows/win32/api/winuser/nf-winuser-intersectrect
    [LibraryImport("USER32", SetLastError = true)]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial BOOL IntersectRect(out RECT lprcDst, in RECT lprcSrc1, in RECT lprcSrc2);
    
    // https://learn.microsoft.com/windows/win32/api/winuser/nf-winuser-invalidaterect
    [LibraryImport("USER32", SetLastError = true)]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial BOOL InvalidateRect(HWND hWnd, nint /* optional RECT* */ lpRect, BOOL bErase);
    
    // https://learn.microsoft.com/windows/win32/api/winuser/nf-winuser-invertrect
    [LibraryImport("USER32", SetLastError = true)]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial BOOL InvertRect(HDC hDC, in RECT lprc);
    
    // https://learn.microsoft.com/windows/win32/api/wingdi/nf-wingdi-invertrgn
    [LibraryImport("GDI32", SetLastError = true)]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial BOOL InvertRgn(HDC hdc, HRGN hrgn);
    
    // https://learn.microsoft.com/windows/win32/api/winuser/nf-winuser-ischild
    [LibraryImport("USER32", SetLastError = true)]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial BOOL IsChild(HWND hWndParent, HWND hWnd);
    
    // https://learn.microsoft.com/windows/win32/api/winuser/nf-winuser-isclipboardformatavailable
    [LibraryImport("USER32", SetLastError = true)]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial BOOL IsClipboardFormatAvailable(uint format);
    
    // https://learn.microsoft.com/windows/win32/api/icm/nf-icm-iscolorprofiletagpresent
    [LibraryImport("mscms", SetLastError = true)]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial BOOL IsColorProfileTagPresent(nint hProfile, uint tag, out BOOL pbPresent);
    
    // https://learn.microsoft.com/windows/win32/api/icm/nf-icm-iscolorprofilevalid
    [LibraryImport("mscms", SetLastError = true)]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial BOOL IsColorProfileValid(nint hProfile, out BOOL pbValid);
    
    // https://learn.microsoft.com/windows/win32/api/winuser/nf-winuser-isdialogmessagew
    [LibraryImport("USER32", StringMarshalling = StringMarshalling.Utf16, SetLastError = true)]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial BOOL IsDialogMessageW(HWND hDlg, in MSG lpMsg);
    
    // https://learn.microsoft.com/windows/win32/api/roerrorapi/nf-roerrorapi-iserrorpropagationenabled
    [LibraryImport("api-ms-win-core-winrt-error-l1-1-1", SetLastError = true)]
    [SupportedOSPlatform("windows8.0")]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial BOOL IsErrorPropagationEnabled();
    
    // https://learn.microsoft.com/windows/win32/api/winuser/nf-winuser-ishungappwindow
    [LibraryImport("USER32", SetLastError = true)]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial BOOL IsHungAppWindow(HWND hwnd);
    
    // https://learn.microsoft.com/windows/win32/api/winuser/nf-winuser-isiconic
    [LibraryImport("USER32", SetLastError = true)]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial BOOL IsIconic(HWND hWnd);
    
    // https://learn.microsoft.com/windows/win32/api/winuser/nf-winuser-ismouseinpointerenabled
    [LibraryImport("USER32", SetLastError = true)]
    [SupportedOSPlatform("windows8.0")]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial BOOL IsMouseInPointerEnabled();
    
    // https://learn.microsoft.com/windows/win32/api/winuser/nf-winuser-isvaliddpiawarenesscontext
    [LibraryImport("USER32", SetLastError = true)]
    [SupportedOSPlatform("windows10.0.14393")]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial BOOL IsValidDpiAwarenessContext(DPI_AWARENESS_CONTEXT value);
    
    // https://learn.microsoft.com/windows/win32/api/winuser/nf-winuser-iswindow
    [LibraryImport("USER32", SetLastError = true)]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial BOOL IsWindow(HWND hWnd);
    
    // https://learn.microsoft.com/windows/win32/api/winuser/nf-winuser-iswindowenabled
    [LibraryImport("USER32", SetLastError = true)]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial BOOL IsWindowEnabled(HWND hWnd);
    
    // https://learn.microsoft.com/windows/win32/api/winuser/nf-winuser-iswindowvisible
    [LibraryImport("USER32", SetLastError = true)]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial BOOL IsWindowVisible(HWND hWnd);
    
    // https://learn.microsoft.com/windows/win32/api/wow64apiset/nf-wow64apiset-iswow64guestmachinesupported
    [LibraryImport("KERNEL32", SetLastError = true)]
    [SupportedOSPlatform("windows10.0.16299")]
    [PreserveSig]
    public static partial HRESULT IsWow64GuestMachineSupported(IMAGE_FILE_MACHINE WowGuestMachine, out BOOL MachineIsSupported);
    
    // https://learn.microsoft.com/windows/win32/api/wow64apiset/nf-wow64apiset-iswow64process
    [LibraryImport("KERNEL32", SetLastError = true)]
    [SupportedOSPlatform("windows6.0.6000")]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial BOOL IsWow64Process(HANDLE hProcess, out BOOL Wow64Process);
    
    // https://learn.microsoft.com/windows/win32/api/wow64apiset/nf-wow64apiset-iswow64process2
    [LibraryImport("KERNEL32", SetLastError = true)]
    [SupportedOSPlatform("windows10.0.10586")]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial BOOL IsWow64Process2(HANDLE hProcess, out IMAGE_FILE_MACHINE pProcessMachine, nint /* optional IMAGE_FILE_MACHINE* */ pNativeMachine);
    
    // https://learn.microsoft.com/windows/win32/api/winuser/nf-winuser-iszoomed
    [LibraryImport("USER32", SetLastError = true)]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial BOOL IsZoomed(HWND hWnd);
    
    // https://learn.microsoft.com/windows/win32/api/joystickapi/nf-joystickapi-joygetdevcapsa
    [LibraryImport("WINMM")]
    [PreserveSig]
    public static partial uint joyGetDevCapsA(nuint uJoyID, nint pjc, uint cbjc);
    
    // https://learn.microsoft.com/windows/win32/api/joystickapi/nf-joystickapi-joygetdevcapsw
    [LibraryImport("WINMM", StringMarshalling = StringMarshalling.Utf16)]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    public static partial uint joyGetDevCapsW(nuint uJoyID, nint pjc, uint cbjc);
    
    // https://learn.microsoft.com/windows/win32/api/joystickapi/nf-joystickapi-joygetnumdevs
    [LibraryImport("WINMM")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    public static partial uint joyGetNumDevs();
    
    // https://learn.microsoft.com/windows/win32/api/joystickapi/nf-joystickapi-joygetpos
    [LibraryImport("WINMM")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    public static partial uint joyGetPos(uint uJoyID, out JOYINFO pji);
    
    // https://learn.microsoft.com/windows/win32/api/joystickapi/nf-joystickapi-joygetposex
    [LibraryImport("WINMM")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    public static partial uint joyGetPosEx(uint uJoyID, out JOYINFOEX pji);
    
    // https://learn.microsoft.com/windows/win32/api/joystickapi/nf-joystickapi-joygetthreshold
    [LibraryImport("WINMM")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    public static partial uint joyGetThreshold(uint uJoyID, out uint puThreshold);
    
    // https://learn.microsoft.com/windows/win32/api/joystickapi/nf-joystickapi-joyreleasecapture
    [LibraryImport("WINMM")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    public static partial uint joyReleaseCapture(uint uJoyID);
    
    // https://learn.microsoft.com/windows/win32/api/joystickapi/nf-joystickapi-joysetcapture
    [LibraryImport("WINMM")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    public static partial uint joySetCapture(HWND hwnd, uint uJoyID, uint uPeriod, BOOL fChanged);
    
    // https://learn.microsoft.com/windows/win32/api/joystickapi/nf-joystickapi-joysetthreshold
    [LibraryImport("WINMM")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    public static partial uint joySetThreshold(uint uJoyID, uint uThreshold);
    
    // https://learn.microsoft.com/windows/win32/api/winuser/nf-winuser-killtimer
    [LibraryImport("USER32", SetLastError = true)]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial BOOL KillTimer(HWND hWnd, nuint uIDEvent);
    
    [LibraryImport("ksuser")]
    [PreserveSig]
    public static partial uint KsCreateAllocator(HANDLE ConnectionHandle, in KSALLOCATOR_FRAMING AllocatorFraming, out HANDLE AllocatorHandle);
    
    [LibraryImport("ksuser")]
    [PreserveSig]
    public static partial HRESULT KsCreateAllocator2(HANDLE ConnectionHandle, in KSALLOCATOR_FRAMING AllocatorFraming, out HANDLE AllocatorHandle);
    
    [LibraryImport("ksuser")]
    [PreserveSig]
    public static partial uint KsCreateClock(HANDLE ConnectionHandle, in KSCLOCK_CREATE ClockCreate, out HANDLE ClockHandle);
    
    [LibraryImport("ksuser")]
    [PreserveSig]
    public static partial HRESULT KsCreateClock2(HANDLE ConnectionHandle, in KSCLOCK_CREATE ClockCreate, out HANDLE ClockHandle);
    
    [LibraryImport("ksuser")]
    [PreserveSig]
    public static partial uint KsCreatePin(HANDLE FilterHandle, in KSPIN_CONNECT Connect, uint DesiredAccess, out HANDLE ConnectionHandle);
    
    [LibraryImport("ksuser")]
    [PreserveSig]
    public static partial HRESULT KsCreatePin2(HANDLE FilterHandle, in KSPIN_CONNECT Connect, uint DesiredAccess, out HANDLE ConnectionHandle);
    
    [LibraryImport("ksuser")]
    [PreserveSig]
    public static partial uint KsCreateTopologyNode(HANDLE ParentHandle, in KSNODE_CREATE NodeCreate, uint DesiredAccess, out HANDLE NodeHandle);
    
    [LibraryImport("ksuser")]
    [PreserveSig]
    public static partial HRESULT KsCreateTopologyNode2(HANDLE ParentHandle, in KSNODE_CREATE NodeCreate, uint DesiredAccess, out HANDLE NodeHandle);
    
    [LibraryImport("ksproxy.ax")]
    [PreserveSig]
    public static partial HRESULT KsGetMediaType(int Position, out AM_MEDIA_TYPE AmMediaType, HANDLE FilterHandle, uint PinFactoryId);
    
    [LibraryImport("ksproxy.ax")]
    [PreserveSig]
    public static partial HRESULT KsGetMediaTypeCount(HANDLE FilterHandle, uint PinFactoryId, out uint MediaTypeCount);
    
    [LibraryImport("ksproxy.ax")]
    [PreserveSig]
    public static partial HRESULT KsGetMultiplePinFactoryItems(HANDLE FilterHandle, uint PinFactoryId, uint PropertyId, out nint Items);
    
    [LibraryImport("ksproxy.ax")]
    [PreserveSig]
    public static partial HRESULT KsOpenDefaultDevice(in Guid Category, uint Access, out HANDLE DeviceHandle);
    
    [LibraryImport("ksproxy.ax")]
    [PreserveSig]
    public static partial HRESULT KsResolveRequiredAttributes(in KSDATAFORMAT DataRange, nint /* optional KSMULTIPLE_ITEM* */ Attributes);
    
    [LibraryImport("ksproxy.ax")]
    [PreserveSig]
    public static partial HRESULT KsSynchronousDeviceControl(HANDLE Handle, uint IoControl, nint /* optional void* */ InBuffer, uint InLength, nint /* optional void* */ OutBuffer, uint OutLength, nint /* optional uint* */ BytesReturned);
    
    // https://learn.microsoft.com/windows/win32/api/wingdi/nf-wingdi-lineto
    [LibraryImport("GDI32", SetLastError = true)]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial BOOL LineTo(HDC hdc, int x, int y);
    
    // https://learn.microsoft.com/windows/win32/api/winuser/nf-winuser-loadacceleratorsw
    [LibraryImport("USER32", StringMarshalling = StringMarshalling.Utf16, SetLastError = true)]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial HACCEL LoadAcceleratorsW(HINSTANCE hInstance, PWSTR lpTableName);
    
    // https://learn.microsoft.com/windows/win32/api/winuser/nf-winuser-loadcursorw
    [LibraryImport("USER32", StringMarshalling = StringMarshalling.Utf16, SetLastError = true)]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial HCURSOR LoadCursorW(HINSTANCE hInstance, PWSTR lpCursorName);
    
    // https://learn.microsoft.com/windows/win32/api/winuser/nf-winuser-loadimagew
    [LibraryImport("USER32", StringMarshalling = StringMarshalling.Utf16, SetLastError = true)]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial HANDLE LoadImageW(HINSTANCE hInst, PWSTR name, GDI_IMAGE_TYPE type, int cx, int cy, IMAGE_FLAGS fuLoad);
    
    // https://learn.microsoft.com/windows/win32/api/winuser/nf-winuser-loadkeyboardlayoutw
    [LibraryImport("USER32", StringMarshalling = StringMarshalling.Utf16, SetLastError = true)]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial HKL LoadKeyboardLayoutW(PWSTR pwszKLID, ACTIVATE_KEYBOARD_LAYOUT_FLAGS Flags);
    
    // https://learn.microsoft.com/windows/win32/api/libloaderapi/nf-libloaderapi-loadlibraryexw
    [LibraryImport("KERNEL32", StringMarshalling = StringMarshalling.Utf16, SetLastError = true)]
    [SupportedOSPlatform("windows5.1.2600")]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial HMODULE LoadLibraryExW(PWSTR lpLibFileName, HANDLE hFile, LOAD_LIBRARY_FLAGS dwFlags);
    
    // https://learn.microsoft.com/windows/win32/api/libloaderapi/nf-libloaderapi-loadlibraryw
    [LibraryImport("KERNEL32", StringMarshalling = StringMarshalling.Utf16, SetLastError = true)]
    [SupportedOSPlatform("windows5.1.2600")]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial HMODULE LoadLibraryW(PWSTR lpLibFileName);
    
    // https://learn.microsoft.com/windows/win32/api/oleauto/nf-oleauto-loadregtypelib
    [LibraryImport("OLEAUT32")]
    [PreserveSig]
    public static partial HRESULT LoadRegTypeLib(in Guid rguid, ushort wVerMajor, ushort wVerMinor, uint lcid, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<ITypeLib>))] out ITypeLib pptlib);
    
    // https://learn.microsoft.com/windows/win32/api/libloaderapi/nf-libloaderapi-loadresource
    [LibraryImport("KERNEL32", SetLastError = true)]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial HGLOBAL LoadResource(HMODULE hModule, HRSRC hResInfo);
    
    // https://learn.microsoft.com/windows/win32/api/winuser/nf-winuser-loadstringw
    [LibraryImport("USER32", StringMarshalling = StringMarshalling.Utf16, SetLastError = true)]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    public static partial int LoadStringW(HINSTANCE hInstance, uint uID, PWSTR lpBuffer, int cchBufferMax);
    
    // https://learn.microsoft.com/windows/win32/api/oleauto/nf-oleauto-loadtypelib
    [LibraryImport("OLEAUT32")]
    [PreserveSig]
    public static partial HRESULT LoadTypeLib(PWSTR szFile, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<ITypeLib>))] out ITypeLib pptlib);
    
    // https://learn.microsoft.com/windows/win32/api/oleauto/nf-oleauto-loadtypelibex
    [LibraryImport("OLEAUT32")]
    [PreserveSig]
    public static partial HRESULT LoadTypeLibEx(PWSTR szFile, REGKIND regkind, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<ITypeLib>))] out ITypeLib pptlib);
    
    // https://learn.microsoft.com/windows/win32/api/libloaderapi/nf-libloaderapi-lockresource
    [LibraryImport("KERNEL32")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    public static partial nint LockResource(HGLOBAL hResData);
    
    // https://learn.microsoft.com/windows/win32/api/winuser/nf-winuser-logicaltophysicalpointforpermonitordpi
    [LibraryImport("USER32", SetLastError = true)]
    [SupportedOSPlatform("windows8.1")]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial BOOL LogicalToPhysicalPointForPerMonitorDPI(HWND hWnd, ref POINT lpPoint);
    
    // https://learn.microsoft.com/windows/win32/api/winuser/nf-winuser-mapvirtualkeyexw
    [LibraryImport("USER32", StringMarshalling = StringMarshalling.Utf16)]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    public static partial uint MapVirtualKeyExW(uint uCode, MAP_VIRTUAL_KEY_TYPE uMapType, HKL dwhkl);
    
    // https://learn.microsoft.com/windows/win32/api/winuser/nf-winuser-mapvirtualkeyw
    [LibraryImport("USER32", StringMarshalling = StringMarshalling.Utf16)]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    public static partial uint MapVirtualKeyW(uint uCode, MAP_VIRTUAL_KEY_TYPE uMapType);
    
    // https://learn.microsoft.com/windows/win32/api/winuser/nf-winuser-mapwindowpoints
    [LibraryImport("USER32")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    public static partial int MapWindowPoints(HWND hWndFrom, HWND hWndTo, [In][Out][MarshalUsing(CountElementName = nameof(cPoints))] POINT[] lpPoints, uint cPoints);
    
    [LibraryImport("WINMM", SetLastError = true)]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial BOOL mciDriverNotify(HANDLE hwndCallback, uint wDeviceID, uint uStatus);
    
    [LibraryImport("WINMM")]
    [PreserveSig]
    public static partial uint mciDriverYield(uint wDeviceID);
    
    [LibraryImport("WINMM", SetLastError = true)]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial BOOL mciFreeCommandResource(uint wTable);
    
    [LibraryImport("WINMM")]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial HTASK mciGetCreatorTask(uint mciId);
    
    [LibraryImport("WINMM")]
    [PreserveSig]
    public static partial uint mciGetDeviceIDA(PSTR pszDevice);
    
    [LibraryImport("WINMM")]
    [PreserveSig]
    public static partial uint mciGetDeviceIDFromElementIDA(uint dwElementID, PSTR lpstrType);
    
    [LibraryImport("WINMM", StringMarshalling = StringMarshalling.Utf16)]
    [PreserveSig]
    public static partial uint mciGetDeviceIDFromElementIDW(uint dwElementID, PWSTR lpstrType);
    
    [LibraryImport("WINMM", StringMarshalling = StringMarshalling.Utf16)]
    [PreserveSig]
    public static partial uint mciGetDeviceIDW(PWSTR pszDevice);
    
    [LibraryImport("WINMM", SetLastError = true)]
    [PreserveSig]
    public static partial nuint mciGetDriverData(uint wDeviceID);
    
    [LibraryImport("WINMM", SetLastError = true)]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial BOOL mciGetErrorStringA(uint mcierr, [MarshalUsing(CountElementName = nameof(cchText))] PSTR pszText, uint cchText);
    
    [LibraryImport("WINMM", StringMarshalling = StringMarshalling.Utf16, SetLastError = true)]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial BOOL mciGetErrorStringW(uint mcierr, [MarshalUsing(CountElementName = nameof(cchText))] PWSTR pszText, uint cchText);
    
    [LibraryImport("WINMM")]
    [PreserveSig]
    public static partial YIELDPROC mciGetYieldProc(uint mciId, in uint pdwYieldData);
    
    [LibraryImport("WINMM")]
    [PreserveSig]
    public static partial uint mciLoadCommandResource(HANDLE hInstance, PWSTR lpResName, uint wType);
    
    [LibraryImport("WINMM")]
    [PreserveSig]
    public static partial uint mciSendCommandA(uint mciId, uint uMsg, nuint dwParam1, nuint dwParam2);
    
    [LibraryImport("WINMM", StringMarshalling = StringMarshalling.Utf16)]
    [PreserveSig]
    public static partial uint mciSendCommandW(uint mciId, uint uMsg, nuint dwParam1, nuint dwParam2);
    
    [LibraryImport("WINMM")]
    [PreserveSig]
    public static partial uint mciSendStringA(PSTR lpstrCommand, [MarshalUsing(CountElementName = nameof(uReturnLength))] PSTR lpstrReturnString, uint uReturnLength, HWND hwndCallback);
    
    [LibraryImport("WINMM", StringMarshalling = StringMarshalling.Utf16)]
    [PreserveSig]
    public static partial uint mciSendStringW(PWSTR lpstrCommand, [MarshalUsing(CountElementName = nameof(uReturnLength))] PWSTR lpstrReturnString, uint uReturnLength, HWND hwndCallback);
    
    [LibraryImport("WINMM", SetLastError = true)]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial BOOL mciSetDriverData(uint wDeviceID, nuint dwData);
    
    [LibraryImport("WINMM", SetLastError = true)]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial BOOL mciSetYieldProc(uint mciId, YIELDPROC? fpYieldProc, uint dwYieldData);
    
    // https://learn.microsoft.com/windows/win32/api/vfw/nf-vfw-mciwndcreatea
    [LibraryImport("MSVFW32")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial HWND MCIWndCreateA(HWND hwndParent, HINSTANCE hInstance, uint dwStyle, PSTR szFile);
    
    // https://learn.microsoft.com/windows/win32/api/vfw/nf-vfw-mciwndcreatew
    [LibraryImport("MSVFW32", StringMarshalling = StringMarshalling.Utf16)]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial HWND MCIWndCreateW(HWND hwndParent, HINSTANCE hInstance, uint dwStyle, PWSTR szFile);
    
    // https://learn.microsoft.com/windows/win32/api/vfw/nf-vfw-mciwndregisterclass
    [LibraryImport("MSVFW32", SetLastError = true)]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial BOOL MCIWndRegisterClass();
    
    // https://learn.microsoft.com/windows/win32/api/winuser/nf-winuser-messageboxw
    [LibraryImport("USER32", StringMarshalling = StringMarshalling.Utf16, SetLastError = true)]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    public static partial MESSAGEBOX_RESULT MessageBoxW(HWND hWnd, PWSTR lpText, PWSTR lpCaption, MESSAGEBOX_STYLE uType);
    
    // https://learn.microsoft.com/windows/win32/api/mfapi/nf-mfapi-mfaddperiodiccallback
    [LibraryImport("MFPlat")]
    [SupportedOSPlatform("windows6.0.6000")]
    [PreserveSig]
    public static partial HRESULT MFAddPeriodicCallback(MFPERIODICCALLBACK Callback, nint pContext, nint /* optional uint* */ pdwKey);
    
    // https://learn.microsoft.com/windows/win32/api/mfapi/nf-mfapi-mfallocateserialworkqueue
    [LibraryImport("MFPlat")]
    [SupportedOSPlatform("windows8.0")]
    [PreserveSig]
    public static partial HRESULT MFAllocateSerialWorkQueue(uint dwWorkQueue, out uint pdwWorkQueue);
    
    // https://learn.microsoft.com/windows/win32/api/mfapi/nf-mfapi-mfallocateworkqueue
    [LibraryImport("MFPlat")]
    [SupportedOSPlatform("windows6.0.6000")]
    [PreserveSig]
    public static partial HRESULT MFAllocateWorkQueue(out uint pdwWorkQueue);
    
    // https://learn.microsoft.com/windows/win32/api/mfapi/nf-mfapi-mfallocateworkqueueex
    [LibraryImport("MFPlat")]
    [SupportedOSPlatform("windows6.1")]
    [PreserveSig]
    public static partial HRESULT MFAllocateWorkQueueEx(MFASYNC_WORKQUEUE_TYPE WorkQueueType, out uint pdwWorkQueue);
    
    // https://learn.microsoft.com/windows/win32/api/mfapi/nf-mfapi-mfaveragetimeperframetoframerate
    [LibraryImport("MFPlat")]
    [SupportedOSPlatform("windows6.0.6000")]
    [PreserveSig]
    public static partial HRESULT MFAverageTimePerFrameToFrameRate(ulong unAverageTimePerFrame, out uint punNumerator, out uint punDenominator);
    
    // https://learn.microsoft.com/windows/win32/api/mfapi/nf-mfapi-mfbegincreatefile
    [LibraryImport("MFPlat")]
    [SupportedOSPlatform("windows6.0.6000")]
    [PreserveSig]
    public static partial HRESULT MFBeginCreateFile(MF_FILE_ACCESSMODE AccessMode, MF_FILE_OPENMODE OpenMode, MF_FILE_FLAGS fFlags, PWSTR pwszFilePath, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMFAsyncCallback>))] IMFAsyncCallback pCallback, nint pState, out nint ppCancelCookie);
    
    // https://learn.microsoft.com/windows/win32/api/mfapi/nf-mfapi-mfbeginregisterworkqueuewithmmcss
    [LibraryImport("MFPlat")]
    [SupportedOSPlatform("windows6.0.6000")]
    [PreserveSig]
    public static partial HRESULT MFBeginRegisterWorkQueueWithMMCSS(uint dwWorkQueueId, PWSTR wszClass, uint dwTaskId, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMFAsyncCallback>))] IMFAsyncCallback pDoneCallback, nint pDoneState);
    
    // https://learn.microsoft.com/windows/win32/api/mfapi/nf-mfapi-mfbeginregisterworkqueuewithmmcssex
    [LibraryImport("MFPlat")]
    [SupportedOSPlatform("windows8.0")]
    [PreserveSig]
    public static partial HRESULT MFBeginRegisterWorkQueueWithMMCSSEx(uint dwWorkQueueId, PWSTR wszClass, uint dwTaskId, int lPriority, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMFAsyncCallback>))] IMFAsyncCallback pDoneCallback, nint pDoneState);
    
    // https://learn.microsoft.com/windows/win32/api/mfapi/nf-mfapi-mfbeginunregisterworkqueuewithmmcss
    [LibraryImport("MFPlat")]
    [SupportedOSPlatform("windows6.0.6000")]
    [PreserveSig]
    public static partial HRESULT MFBeginUnregisterWorkQueueWithMMCSS(uint dwWorkQueueId, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMFAsyncCallback>))] IMFAsyncCallback pDoneCallback, nint pDoneState);
    
    // https://learn.microsoft.com/windows/win32/api/mfapi/nf-mfapi-mfcalculatebitmapimagesize
    [LibraryImport("MFPlat")]
    [SupportedOSPlatform("windows6.0.6000")]
    [PreserveSig]
    public static partial HRESULT MFCalculateBitmapImageSize(in BITMAPINFOHEADER pBMIH, uint cbBufSize, out uint pcbImageSize, nint /* optional BOOL* */ pbKnown);
    
    // https://learn.microsoft.com/windows/win32/api/mfapi/nf-mfapi-mfcalculateimagesize
    [LibraryImport("MFPlat")]
    [SupportedOSPlatform("windows6.0.6000")]
    [PreserveSig]
    public static partial HRESULT MFCalculateImageSize(in Guid guidSubtype, uint unWidth, uint unHeight, out uint pcbImageSize);
    
    // https://learn.microsoft.com/windows/win32/api/mfapi/nf-mfapi-mfcancelcreatefile
    [LibraryImport("MFPlat")]
    [SupportedOSPlatform("windows6.0.6000")]
    [PreserveSig]
    public static partial HRESULT MFCancelCreateFile(nint pCancelCookie);
    
    // https://learn.microsoft.com/windows/win32/api/mfapi/nf-mfapi-mfcancelworkitem
    [LibraryImport("MFPlat")]
    [SupportedOSPlatform("windows6.0.6000")]
    [PreserveSig]
    public static partial HRESULT MFCancelWorkItem(ulong Key);
    
    // https://learn.microsoft.com/windows/win32/api/mfapi/nf-mfapi-mfcombinesamples
    [LibraryImport("MFPlat")]
    [SupportedOSPlatform("windows10.0.19041")]
    [PreserveSig]
    public static partial HRESULT MFCombineSamples([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMFSample>))] IMFSample pSample, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMFSample>))] IMFSample pSampleToAdd, uint dwMaxMergedDurationInMS, out BOOL pMerged);
    
    // https://learn.microsoft.com/windows/win32/api/mfapi/nf-mfapi-mfcomparefulltopartialmediatype
    [LibraryImport("MFPlat", SetLastError = true)]
    [SupportedOSPlatform("windows6.0.6000")]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial BOOL MFCompareFullToPartialMediaType([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMFMediaType>))] IMFMediaType pMFTypeFull, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMFMediaType>))] IMFMediaType pMFTypePartial);
    
    // https://learn.microsoft.com/windows/win32/api/mfapi/nf-mfapi-mfconvertcolorinfofromdxva
    [LibraryImport("MFPlat")]
    [SupportedOSPlatform("windows6.0.6000")]
    [PreserveSig]
    public static partial HRESULT MFConvertColorInfoFromDXVA(ref MFVIDEOFORMAT pToFormat, uint dwFromDXVA);
    
    // https://learn.microsoft.com/windows/win32/api/mfapi/nf-mfapi-mfconvertcolorinfotodxva
    [LibraryImport("MFPlat")]
    [SupportedOSPlatform("windows6.0.6000")]
    [PreserveSig]
    public static partial HRESULT MFConvertColorInfoToDXVA(out uint pdwToDXVA, in MFVIDEOFORMAT pFromFormat);
    
    // https://learn.microsoft.com/windows/win32/api/mfapi/nf-mfapi-mfconvertfromfp16array
    [LibraryImport("MFPlat")]
    [SupportedOSPlatform("windows6.0.6000")]
    [PreserveSig]
    public static partial HRESULT MFConvertFromFP16Array([In][Out][MarshalUsing(CountElementName = nameof(dwCount))] float[] pDest, [In][MarshalUsing(CountElementName = nameof(dwCount))] ushort[] pSrc, uint dwCount);
    
    // https://learn.microsoft.com/windows/win32/api/mfapi/nf-mfapi-mfconverttofp16array
    [LibraryImport("MFPlat")]
    [SupportedOSPlatform("windows6.0.6000")]
    [PreserveSig]
    public static partial HRESULT MFConvertToFP16Array([In][Out][MarshalUsing(CountElementName = nameof(dwCount))] ushort[] pDest, [In][MarshalUsing(CountElementName = nameof(dwCount))] float[] pSrc, uint dwCount);
    
    // https://learn.microsoft.com/windows/win32/api/mfapi/nf-mfapi-mfcopyimage
    [LibraryImport("MFPlat")]
    [SupportedOSPlatform("windows6.0.6000")]
    [PreserveSig]
    public static partial HRESULT MFCopyImage(nint /* byte array */ pDest, int lDestStride, nint /* byte array */ pSrc, int lSrcStride, uint dwWidthInBytes, uint dwLines);
    
    // https://learn.microsoft.com/windows/win32/api/mfapi/nf-mfapi-mfcreate2dmediabuffer
    [LibraryImport("MFPlat")]
    [SupportedOSPlatform("windows8.0")]
    [PreserveSig]
    public static partial HRESULT MFCreate2DMediaBuffer(uint dwWidth, uint dwHeight, uint dwFourCC, BOOL fBottomUp, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMFMediaBuffer>))] out IMFMediaBuffer ppBuffer);
    
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-mfcreate3gpmediasink
    [LibraryImport("MF")]
    [SupportedOSPlatform("windows6.1")]
    [PreserveSig]
    public static partial HRESULT MFCreate3GPMediaSink([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMFByteStream>))] IMFByteStream pIByteStream, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMFMediaType?>))] IMFMediaType? pVideoMediaType, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMFMediaType?>))] IMFMediaType? pAudioMediaType, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMFMediaSink>))] out IMFMediaSink ppIMediaSink);
    
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-mfcreateac3mediasink
    [LibraryImport("MF")]
    [SupportedOSPlatform("windows8.0")]
    [PreserveSig]
    public static partial HRESULT MFCreateAC3MediaSink([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMFByteStream>))] IMFByteStream pTargetByteStream, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMFMediaType>))] IMFMediaType pAudioMediaType, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMFMediaSink>))] out IMFMediaSink ppMediaSink);
    
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-mfcreateadtsmediasink
    [LibraryImport("MF")]
    [SupportedOSPlatform("windows8.0")]
    [PreserveSig]
    public static partial HRESULT MFCreateADTSMediaSink([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMFByteStream>))] IMFByteStream pTargetByteStream, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMFMediaType>))] IMFMediaType pAudioMediaType, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMFMediaSink>))] out IMFMediaSink ppMediaSink);
    
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-mfcreateaggregatesource
    [LibraryImport("MF")]
    [SupportedOSPlatform("windows6.1")]
    [PreserveSig]
    public static partial HRESULT MFCreateAggregateSource([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMFCollection>))] IMFCollection pSourceCollection, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMFMediaSource>))] out IMFMediaSource ppAggSource);
    
    // https://learn.microsoft.com/windows/win32/api/mfapi/nf-mfapi-mfcreatealignedmemorybuffer
    [LibraryImport("MFPlat")]
    [SupportedOSPlatform("windows6.0.6000")]
    [PreserveSig]
    public static partial HRESULT MFCreateAlignedMemoryBuffer(uint cbMaxLength, uint cbAligment, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMFMediaBuffer>))] out IMFMediaBuffer ppBuffer);
    
    // https://learn.microsoft.com/windows/win32/api/mfapi/nf-mfapi-mfcreateammediatypefrommfmediatype
    [LibraryImport("MFPlat")]
    [SupportedOSPlatform("windows6.0.6000")]
    [PreserveSig]
    public static partial HRESULT MFCreateAMMediaTypeFromMFMediaType([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMFMediaType>))] IMFMediaType pMFType, Guid guidFormatBlockType, ref AM_MEDIA_TYPE ppAMType);
    
    // https://learn.microsoft.com/windows/win32/api/wmcontainer/nf-wmcontainer-mfcreateasfcontentinfo
    [LibraryImport("MF")]
    [SupportedOSPlatform("windows6.0.6000")]
    [PreserveSig]
    public static partial HRESULT MFCreateASFContentInfo([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMFASFContentInfo>))] out IMFASFContentInfo ppIContentInfo);
    
    // https://learn.microsoft.com/windows/win32/api/wmcontainer/nf-wmcontainer-mfcreateasfindexer
    [LibraryImport("MF")]
    [SupportedOSPlatform("windows6.0.6000")]
    [PreserveSig]
    public static partial HRESULT MFCreateASFIndexer([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMFASFIndexer>))] out IMFASFIndexer ppIIndexer);
    
    // https://learn.microsoft.com/windows/win32/api/wmcontainer/nf-wmcontainer-mfcreateasfindexerbytestream
    [LibraryImport("MF")]
    [SupportedOSPlatform("windows6.0.6000")]
    [PreserveSig]
    public static partial HRESULT MFCreateASFIndexerByteStream([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMFByteStream>))] IMFByteStream pIContentByteStream, ulong cbIndexStartOffset, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMFByteStream>))] out IMFByteStream pIIndexByteStream);
    
    // https://learn.microsoft.com/windows/win32/api/wmcontainer/nf-wmcontainer-mfcreateasfmediasink
    [LibraryImport("MF")]
    [SupportedOSPlatform("windows6.0.6000")]
    [PreserveSig]
    public static partial HRESULT MFCreateASFMediaSink([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMFByteStream>))] IMFByteStream pIByteStream, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMFMediaSink>))] out IMFMediaSink ppIMediaSink);
    
    // https://learn.microsoft.com/windows/win32/api/wmcontainer/nf-wmcontainer-mfcreateasfmediasinkactivate
    [LibraryImport("MF")]
    [SupportedOSPlatform("windows6.0.6000")]
    [PreserveSig]
    public static partial HRESULT MFCreateASFMediaSinkActivate(PWSTR pwszFileName, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMFASFContentInfo>))] IMFASFContentInfo pContentInfo, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMFActivate>))] out IMFActivate ppIActivate);
    
    // https://learn.microsoft.com/windows/win32/api/wmcontainer/nf-wmcontainer-mfcreateasfmultiplexer
    [LibraryImport("MF")]
    [SupportedOSPlatform("windows6.0.6000")]
    [PreserveSig]
    public static partial HRESULT MFCreateASFMultiplexer([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMFASFMultiplexer>))] out IMFASFMultiplexer ppIMultiplexer);
    
    // https://learn.microsoft.com/windows/win32/api/wmcontainer/nf-wmcontainer-mfcreateasfprofile
    [LibraryImport("MF")]
    [SupportedOSPlatform("windows6.0.6000")]
    [PreserveSig]
    public static partial HRESULT MFCreateASFProfile([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMFASFProfile>))] out IMFASFProfile ppIProfile);
    
    // https://learn.microsoft.com/windows/win32/api/wmcontainer/nf-wmcontainer-mfcreateasfprofilefrompresentationdescriptor
    [LibraryImport("MF")]
    [SupportedOSPlatform("windows6.0.6000")]
    [PreserveSig]
    public static partial HRESULT MFCreateASFProfileFromPresentationDescriptor([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMFPresentationDescriptor>))] IMFPresentationDescriptor pIPD, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMFASFProfile>))] out IMFASFProfile ppIProfile);
    
    // https://learn.microsoft.com/windows/win32/api/wmcontainer/nf-wmcontainer-mfcreateasfsplitter
    [LibraryImport("MF")]
    [SupportedOSPlatform("windows6.0.6000")]
    [PreserveSig]
    public static partial HRESULT MFCreateASFSplitter([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMFASFSplitter>))] out IMFASFSplitter ppISplitter);
    
    // https://learn.microsoft.com/windows/win32/api/wmcontainer/nf-wmcontainer-mfcreateasfstreamingmediasink
    [LibraryImport("MF")]
    [SupportedOSPlatform("windows6.1")]
    [PreserveSig]
    public static partial HRESULT MFCreateASFStreamingMediaSink([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMFByteStream>))] IMFByteStream pIByteStream, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMFMediaSink>))] out IMFMediaSink ppIMediaSink);
    
    // https://learn.microsoft.com/windows/win32/api/wmcontainer/nf-wmcontainer-mfcreateasfstreamingmediasinkactivate
    [LibraryImport("MF")]
    [SupportedOSPlatform("windows6.1")]
    [PreserveSig]
    public static partial HRESULT MFCreateASFStreamingMediaSinkActivate([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMFActivate>))] IMFActivate pByteStreamActivate, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMFASFContentInfo>))] IMFASFContentInfo pContentInfo, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMFActivate>))] out IMFActivate ppIActivate);
    
    // https://learn.microsoft.com/windows/win32/api/wmcontainer/nf-wmcontainer-mfcreateasfstreamselector
    [LibraryImport("MF")]
    [SupportedOSPlatform("windows6.0.6000")]
    [PreserveSig]
    public static partial HRESULT MFCreateASFStreamSelector([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMFASFProfile>))] IMFASFProfile pIASFProfile, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMFASFStreamSelector>))] out IMFASFStreamSelector ppSelector);
    
    // https://learn.microsoft.com/windows/win32/api/mfapi/nf-mfapi-mfcreateasyncresult
    [LibraryImport("MFPlat")]
    [SupportedOSPlatform("windows6.0.6000")]
    [PreserveSig]
    public static partial HRESULT MFCreateAsyncResult(nint punkObject, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMFAsyncCallback>))] IMFAsyncCallback pCallback, nint punkState, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMFAsyncResult>))] out IMFAsyncResult ppAsyncResult);
    
    // https://learn.microsoft.com/windows/win32/api/mfapi/nf-mfapi-mfcreateattributes
    [LibraryImport("MFPlat")]
    [SupportedOSPlatform("windows6.0.6000")]
    [PreserveSig]
    public static partial HRESULT MFCreateAttributes([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMFAttributes>))] out IMFAttributes ppMFAttributes, uint cInitialSize);
    
    // https://learn.microsoft.com/windows/win32/api/mfapi/nf-mfapi-mfcreateaudiomediatype
    [LibraryImport("MFPlat")]
    [SupportedOSPlatform("windows6.0.6000")]
    [PreserveSig]
    public static partial HRESULT MFCreateAudioMediaType(in WAVEFORMATEX pAudioFormat, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMFAudioMediaType>))] out IMFAudioMediaType ppIAudioMediaType);
    
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-mfcreateaudiorenderer
    [LibraryImport("MF")]
    [SupportedOSPlatform("windows6.0.6000")]
    [PreserveSig]
    public static partial HRESULT MFCreateAudioRenderer([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMFAttributes>))] IMFAttributes pAudioAttributes, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMFMediaSink>))] out IMFMediaSink ppSink);
    
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-mfcreateaudiorendereractivate
    [LibraryImport("MF")]
    [SupportedOSPlatform("windows6.0.6000")]
    [PreserveSig]
    public static partial HRESULT MFCreateAudioRendererActivate([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMFActivate>))] out IMFActivate ppActivate);
    
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-mfcreateavimediasink
    [LibraryImport("mfsrcsnk")]
    [SupportedOSPlatform("windows8.1")]
    [PreserveSig]
    public static partial HRESULT MFCreateAVIMediaSink([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMFByteStream>))] IMFByteStream pIByteStream, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMFMediaType>))] IMFMediaType pVideoMediaType, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMFMediaType?>))] IMFMediaType? pAudioMediaType, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMFMediaSink>))] out IMFMediaSink ppIMediaSink);
    
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-mfcreatecameracontrolmonitor
    [LibraryImport("MFSENSORGROUP")]
    [PreserveSig]
    public static partial HRESULT MFCreateCameraControlMonitor(PWSTR symbolicLink, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMFCameraControlNotify>))] IMFCameraControlNotify callback, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMFCameraControlMonitor>))] out IMFCameraControlMonitor ppCameraControlMonitor);
    
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-mfcreatecameraocclusionstatemonitor
    [LibraryImport("MFSENSORGROUP")]
    [PreserveSig]
    public static partial HRESULT MFCreateCameraOcclusionStateMonitor(PWSTR symbolicLink, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMFCameraOcclusionStateReportCallback>))] IMFCameraOcclusionStateReportCallback callback, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMFCameraOcclusionStateMonitor>))] out IMFCameraOcclusionStateMonitor occlusionStateMonitor);
    
    // https://learn.microsoft.com/windows/win32/api/mfapi/nf-mfapi-mfcreatecollection
    [LibraryImport("MFPlat")]
    [SupportedOSPlatform("windows6.0.6000")]
    [PreserveSig]
    public static partial HRESULT MFCreateCollection([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMFCollection>))] out IMFCollection ppIMFCollection);
    
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-mfcreatecontentdecryptorcontext
    [LibraryImport("MFPlat")]
    [SupportedOSPlatform("windows10.0.10240")]
    [PreserveSig]
    public static partial HRESULT MFCreateContentDecryptorContext(in Guid guidMediaProtectionSystemId, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMFDXGIDeviceManager?>))] IMFDXGIDeviceManager? pD3DManager, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMFContentProtectionDevice>))] IMFContentProtectionDevice pContentProtectionDevice, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMFContentDecryptorContext>))] out IMFContentDecryptorContext ppContentDecryptorContext);
    
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-mfcreatecontentprotectiondevice
    [LibraryImport("MFPlat")]
    [SupportedOSPlatform("windows10.0.10240")]
    [PreserveSig]
    public static partial HRESULT MFCreateContentProtectionDevice(in Guid ProtectionSystemId, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMFContentProtectionDevice>))] out IMFContentProtectionDevice ContentProtectionDevice);
    
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-mfcreatecredentialcache
    [LibraryImport("MF")]
    [SupportedOSPlatform("windows6.0.6000")]
    [PreserveSig]
    public static partial HRESULT MFCreateCredentialCache([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMFNetCredentialCache>))] out IMFNetCredentialCache ppCache);
    
    // https://learn.microsoft.com/windows/win32/api/mfd3d12/nf-mfd3d12-mfcreated3d12synchronizationobject
    [LibraryImport("MFPlat")]
    [PreserveSig]
    public static partial HRESULT MFCreateD3D12SynchronizationObject([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ID3D12Device>))] ID3D12Device pDevice, in Guid riid, out nint ppvSyncObject);
    
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-mfcreatedevicesource
    [LibraryImport("MF")]
    [SupportedOSPlatform("windows6.1")]
    [PreserveSig]
    public static partial HRESULT MFCreateDeviceSource([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMFAttributes>))] IMFAttributes pAttributes, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMFMediaSource>))] out IMFMediaSource ppSource);
    
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-mfcreatedevicesourceactivate
    [LibraryImport("MF")]
    [SupportedOSPlatform("windows6.1")]
    [PreserveSig]
    public static partial HRESULT MFCreateDeviceSourceActivate([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMFAttributes>))] IMFAttributes pAttributes, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMFActivate>))] out IMFActivate ppActivate);
    
    [LibraryImport("MFPlat")]
    [PreserveSig]
    public static partial HRESULT MFCreateDXGICrossAdapterBuffer(in Guid riid, nint punkDevice, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMFMediaType>))] IMFMediaType pMediaType, uint uSubresource, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMFMediaBuffer>))] out IMFMediaBuffer ppBuffer);
    
    // https://learn.microsoft.com/windows/win32/api/mfapi/nf-mfapi-mfcreatedxgidevicemanager
    [LibraryImport("MFPlat")]
    [SupportedOSPlatform("windows8.0")]
    [PreserveSig]
    public static partial HRESULT MFCreateDXGIDeviceManager(out uint resetToken, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMFDXGIDeviceManager>))] out IMFDXGIDeviceManager ppDeviceManager);
    
    // https://learn.microsoft.com/windows/win32/api/mfapi/nf-mfapi-mfcreatedxgisurfacebuffer
    [LibraryImport("MFPlat")]
    [SupportedOSPlatform("windows8.0")]
    [PreserveSig]
    public static partial HRESULT MFCreateDXGISurfaceBuffer(in Guid riid, nint punkSurface, uint uSubresourceIndex, BOOL fBottomUpWhenLinear, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMFMediaBuffer>))] out IMFMediaBuffer ppBuffer);
    
    // https://learn.microsoft.com/windows/win32/api/mfapi/nf-mfapi-mfcreatedxsurfacebuffer
    [LibraryImport("MFPlat")]
    [SupportedOSPlatform("windows6.0.6000")]
    [PreserveSig]
    public static partial HRESULT MFCreateDXSurfaceBuffer(in Guid riid, nint punkSurface, BOOL fBottomUpWhenLinear, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMFMediaBuffer>))] out IMFMediaBuffer ppBuffer);
    
    // https://learn.microsoft.com/windows/win32/api/mfcontentdecryptionmodule/nf-mfcontentdecryptionmodule-mfcreateencryptedmediaextensionsstoreactivate
    [LibraryImport("MF")]
    [SupportedOSPlatform("windows10.0.19041")]
    [PreserveSig]
    public static partial HRESULT MFCreateEncryptedMediaExtensionsStoreActivate([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMFPMPHostApp>))] IMFPMPHostApp pmpHost, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IStream>))] IStream objectStream, PWSTR classId, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMFActivate>))] out IMFActivate activate);
    
    // https://learn.microsoft.com/windows/win32/api/mfapi/nf-mfapi-mfcreateeventqueue
    [LibraryImport("MFPlat")]
    [SupportedOSPlatform("windows6.0.6000")]
    [PreserveSig]
    public static partial HRESULT MFCreateEventQueue([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMFMediaEventQueue>))] out IMFMediaEventQueue ppMediaEventQueue);
    
    [LibraryImport("MFCORE")]
    [PreserveSig]
    public static partial HRESULT MFCreateExtendedCameraIntrinsicModel(MFCameraIntrinsic_DistortionModelType distortionModelType, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMFExtendedCameraIntrinsicModel>))] out IMFExtendedCameraIntrinsicModel ppExtendedCameraIntrinsicModel);
    
    [LibraryImport("MFCORE")]
    [PreserveSig]
    public static partial HRESULT MFCreateExtendedCameraIntrinsics([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMFExtendedCameraIntrinsics>))] out IMFExtendedCameraIntrinsics ppExtendedCameraIntrinsics);
    
    // https://learn.microsoft.com/windows/win32/api/mfapi/nf-mfapi-mfcreatefile
    [LibraryImport("MFPlat")]
    [SupportedOSPlatform("windows6.0.6000")]
    [PreserveSig]
    public static partial HRESULT MFCreateFile(MF_FILE_ACCESSMODE AccessMode, MF_FILE_OPENMODE OpenMode, MF_FILE_FLAGS fFlags, PWSTR pwszFileURL, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMFByteStream>))] out IMFByteStream ppIByteStream);
    
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-mfcreatefmpeg4mediasink
    [LibraryImport("MF")]
    [SupportedOSPlatform("windows8.0")]
    [PreserveSig]
    public static partial HRESULT MFCreateFMPEG4MediaSink([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMFByteStream>))] IMFByteStream pIByteStream, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMFMediaType?>))] IMFMediaType? pVideoMediaType, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMFMediaType?>))] IMFMediaType? pAudioMediaType, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMFMediaSink>))] out IMFMediaSink ppIMediaSink);
    
    // https://learn.microsoft.com/windows/win32/api/mfapi/nf-mfapi-mfcreatelegacymediabufferonmfmediabuffer
    [LibraryImport("MFPlat")]
    [SupportedOSPlatform("windows6.0.6000")]
    [PreserveSig]
    public static partial HRESULT MFCreateLegacyMediaBufferOnMFMediaBuffer([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMFSample?>))] IMFSample? pSample, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMFMediaBuffer>))] IMFMediaBuffer pMFMediaBuffer, uint cbOffset, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMediaBuffer>))] out IMediaBuffer ppMediaBuffer);
    
    // https://learn.microsoft.com/windows/win32/api/mfapi/nf-mfapi-mfcreatemediabufferfrommediatype
    [LibraryImport("MFPlat")]
    [SupportedOSPlatform("windows8.0")]
    [PreserveSig]
    public static partial HRESULT MFCreateMediaBufferFromMediaType([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMFMediaType>))] IMFMediaType pMediaType, long llDuration, uint dwMinLength, uint dwMinAlignment, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMFMediaBuffer>))] out IMFMediaBuffer ppBuffer);
    
    // https://learn.microsoft.com/windows/win32/api/mfapi/nf-mfapi-mfcreatemediabufferwrapper
    [LibraryImport("MFPlat")]
    [SupportedOSPlatform("windows6.0.6000")]
    [PreserveSig]
    public static partial HRESULT MFCreateMediaBufferWrapper([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMFMediaBuffer>))] IMFMediaBuffer pBuffer, uint cbOffset, uint dwLength, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMFMediaBuffer>))] out IMFMediaBuffer ppBuffer);
    
    // https://learn.microsoft.com/windows/win32/api/mfapi/nf-mfapi-mfcreatemediaevent
    [LibraryImport("MFPlat")]
    [SupportedOSPlatform("windows6.0.6000")]
    [PreserveSig]
    public static partial HRESULT MFCreateMediaEvent(uint met, in Guid guidExtendedType, HRESULT hrStatus, nint /* optional PROPVARIANT* */ pvValue, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMFMediaEvent>))] out IMFMediaEvent ppEvent);
    
    // https://learn.microsoft.com/windows/win32/api/mfapi/nf-mfapi-mfcreatemediaextensionactivate
    [LibraryImport("MFPlat")]
    [SupportedOSPlatform("windows8.0")]
    [PreserveSig]
    public static partial HRESULT MFCreateMediaExtensionActivate(PWSTR szActivatableClassId, nint pConfiguration, in Guid riid, out nint ppvObject);
    
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-mfcreatemediasession
    [LibraryImport("MF")]
    [SupportedOSPlatform("windows6.0.6000")]
    [PreserveSig]
    public static partial HRESULT MFCreateMediaSession([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMFAttributes>))] IMFAttributes pConfiguration, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMFMediaSession>))] out IMFMediaSession ppMediaSession);
    
    // https://learn.microsoft.com/windows/win32/api/mfapi/nf-mfapi-mfcreatemediatype
    [LibraryImport("MFPlat")]
    [SupportedOSPlatform("windows6.0.6000")]
    [PreserveSig]
    public static partial HRESULT MFCreateMediaType([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMFMediaType>))] out IMFMediaType ppMFType);
    
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-mfcreatemediatypefromproperties
    [LibraryImport("MFPlat")]
    [SupportedOSPlatform("windows8.0")]
    [PreserveSig]
    public static partial HRESULT MFCreateMediaTypeFromProperties(nint punkStream, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMFMediaType>))] out IMFMediaType ppMediaType);
    
    // https://learn.microsoft.com/windows/win32/api/mfapi/nf-mfapi-mfcreatemediatypefromrepresentation
    [LibraryImport("MFPlat")]
    [SupportedOSPlatform("windows6.0.6000")]
    [PreserveSig]
    public static partial HRESULT MFCreateMediaTypeFromRepresentation(Guid guidRepresentation, nint pvRepresentation, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMFMediaType>))] out IMFMediaType ppIMediaType);
    
    // https://learn.microsoft.com/windows/win32/api/mfapi/nf-mfapi-mfcreatememorybuffer
    [LibraryImport("MFPlat")]
    [SupportedOSPlatform("windows6.0.6000")]
    [PreserveSig]
    public static partial HRESULT MFCreateMemoryBuffer(uint cbMaxLength, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMFMediaBuffer>))] out IMFMediaBuffer ppBuffer);
    
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-mfcreatemfbytestreamonstream
    [LibraryImport("MFPlat")]
    [SupportedOSPlatform("windows6.1")]
    [PreserveSig]
    public static partial HRESULT MFCreateMFByteStreamOnStream([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IStream>))] IStream pStream, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMFByteStream>))] out IMFByteStream ppByteStream);
    
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-mfcreatemfbytestreamonstreamex
    [LibraryImport("MFPlat")]
    [SupportedOSPlatform("windows8.0")]
    [PreserveSig]
    public static partial HRESULT MFCreateMFByteStreamOnStreamEx(nint punkStream, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMFByteStream>))] out IMFByteStream ppByteStream);
    
    // https://learn.microsoft.com/windows/win32/api/mfapi/nf-mfapi-mfcreatemfbytestreamwrapper
    [LibraryImport("MFPlat")]
    [SupportedOSPlatform("windows8.0")]
    [PreserveSig]
    public static partial HRESULT MFCreateMFByteStreamWrapper([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMFByteStream>))] IMFByteStream pStream, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMFByteStream>))] out IMFByteStream ppStreamWrapper);
    
    // https://learn.microsoft.com/windows/win32/api/mfapi/nf-mfapi-mfcreatemfvideoformatfrommfmediatype
    [LibraryImport("MFPlat")]
    [SupportedOSPlatform("windows6.0.6000")]
    [PreserveSig]
    public static partial HRESULT MFCreateMFVideoFormatFromMFMediaType([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMFMediaType>))] IMFMediaType pMFType, out nint ppMFVF, nint /* optional uint* */ pcbSize);
    
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-mfcreatemp3mediasink
    [LibraryImport("MF")]
    [SupportedOSPlatform("windows6.1")]
    [PreserveSig]
    public static partial HRESULT MFCreateMP3MediaSink([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMFByteStream>))] IMFByteStream pTargetByteStream, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMFMediaSink>))] out IMFMediaSink ppMediaSink);
    
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-mfcreatempeg4mediasink
    [LibraryImport("MF")]
    [SupportedOSPlatform("windows6.1")]
    [PreserveSig]
    public static partial HRESULT MFCreateMPEG4MediaSink([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMFByteStream>))] IMFByteStream pIByteStream, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMFMediaType?>))] IMFMediaType? pVideoMediaType, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMFMediaType?>))] IMFMediaType? pAudioMediaType, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMFMediaSink>))] out IMFMediaSink ppIMediaSink);
    
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-mfcreatemuxsink
    [LibraryImport("MF")]
    [SupportedOSPlatform("windows8.0")]
    [PreserveSig]
    public static partial HRESULT MFCreateMuxSink(Guid guidOutputSubType, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMFAttributes?>))] IMFAttributes? pOutputAttributes, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMFByteStream?>))] IMFByteStream? pOutputByteStream, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMFMediaSink>))] out IMFMediaSink ppMuxSink);
    
    // https://learn.microsoft.com/windows/win32/api/mfapi/nf-mfapi-mfcreatemuxstreamattributes
    [LibraryImport("MFPlat")]
    [SupportedOSPlatform("windows10.0.15063")]
    [PreserveSig]
    public static partial HRESULT MFCreateMuxStreamAttributes([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMFCollection>))] IMFCollection pAttributesToMux, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMFAttributes>))] out IMFAttributes ppMuxAttribs);
    
    // https://learn.microsoft.com/windows/win32/api/mfapi/nf-mfapi-mfcreatemuxstreammediatype
    [LibraryImport("MFPlat")]
    [SupportedOSPlatform("windows10.0.15063")]
    [PreserveSig]
    public static partial HRESULT MFCreateMuxStreamMediaType([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMFCollection>))] IMFCollection pMediaTypesToMux, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMFMediaType>))] out IMFMediaType ppMuxMediaType);
    
    // https://learn.microsoft.com/windows/win32/api/mfapi/nf-mfapi-mfcreatemuxstreamsample
    [LibraryImport("MFPlat")]
    [SupportedOSPlatform("windows10.0.15063")]
    [PreserveSig]
    public static partial HRESULT MFCreateMuxStreamSample([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMFCollection>))] IMFCollection pSamplesToMux, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMFSample>))] out IMFSample ppMuxSample);
    
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-mfcreatenetschemeplugin
    [LibraryImport("MF")]
    [SupportedOSPlatform("windows6.0.6000")]
    [PreserveSig]
    public static partial HRESULT MFCreateNetSchemePlugin(in Guid riid, out nint ppvHandler);
    
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-mfcreatepmpmediasession
    [LibraryImport("MF")]
    [SupportedOSPlatform("windows6.0.6000")]
    [PreserveSig]
    public static partial HRESULT MFCreatePMPMediaSession(uint dwCreationFlags, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMFAttributes>))] IMFAttributes pConfiguration, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMFMediaSession>))] out IMFMediaSession ppMediaSession, nint /* optional IMFActivate* */ ppEnablerActivate);
    
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-mfcreatepmpserver
    [LibraryImport("MF")]
    [SupportedOSPlatform("windows6.0.6000")]
    [PreserveSig]
    public static partial HRESULT MFCreatePMPServer(uint dwCreationFlags, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMFPMPServer>))] out IMFPMPServer ppPMPServer);
    
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-mfcreatepresentationclock
    [LibraryImport("MF")]
    [SupportedOSPlatform("windows6.0.6000")]
    [PreserveSig]
    public static partial HRESULT MFCreatePresentationClock([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMFPresentationClock>))] out IMFPresentationClock ppPresentationClock);
    
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-mfcreatepresentationdescriptor
    [LibraryImport("MFPlat")]
    [SupportedOSPlatform("windows6.0.6000")]
    [PreserveSig]
    public static partial HRESULT MFCreatePresentationDescriptor(uint cStreamDescriptors, nint /* optional IMFStreamDescriptor* */ apStreamDescriptors, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMFPresentationDescriptor>))] out IMFPresentationDescriptor ppPresentationDescriptor);
    
    // https://learn.microsoft.com/windows/win32/api/wmcontainer/nf-wmcontainer-mfcreatepresentationdescriptorfromasfprofile
    [LibraryImport("MF")]
    [SupportedOSPlatform("windows6.0.6000")]
    [PreserveSig]
    public static partial HRESULT MFCreatePresentationDescriptorFromASFProfile([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMFASFProfile>))] IMFASFProfile pIProfile, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMFPresentationDescriptor>))] out IMFPresentationDescriptor ppIPD);
    
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-mfcreatepropertiesfrommediatype
    [LibraryImport("MFPlat")]
    [SupportedOSPlatform("windows8.0")]
    [PreserveSig]
    public static partial HRESULT MFCreatePropertiesFromMediaType([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMFMediaType>))] IMFMediaType pMediaType, in Guid riid, out nint ppv);
    
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-mfcreateprotectedenvironmentaccess
    [LibraryImport("MF")]
    [SupportedOSPlatform("windows8.0")]
    [PreserveSig]
    public static partial HRESULT MFCreateProtectedEnvironmentAccess([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMFProtectedEnvironmentAccess>))] out IMFProtectedEnvironmentAccess ppAccess);
    
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-mfcreateproxylocator
    [LibraryImport("MF")]
    [SupportedOSPlatform("windows6.0.6000")]
    [PreserveSig]
    public static partial HRESULT MFCreateProxyLocator(PWSTR pszProtocol, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IPropertyStore>))] IPropertyStore pProxyConfig, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMFNetProxyLocator>))] out IMFNetProxyLocator ppProxyLocator);
    
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-mfcreaterelativepanelwatcher
    [LibraryImport("MFSENSORGROUP")]
    [SupportedOSPlatform("windows10.0.19041")]
    [PreserveSig]
    public static partial HRESULT MFCreateRelativePanelWatcher(PWSTR videoDeviceId, PWSTR displayMonitorDeviceId, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMFRelativePanelWatcher>))] out IMFRelativePanelWatcher ppRelativePanelWatcher);
    
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-mfcreateremotedesktopplugin
    [LibraryImport("MF")]
    [SupportedOSPlatform("windows6.0.6000")]
    [PreserveSig]
    public static partial HRESULT MFCreateRemoteDesktopPlugin([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMFRemoteDesktopPlugin>))] out IMFRemoteDesktopPlugin ppPlugin);
    
    // https://learn.microsoft.com/windows/win32/api/mfapi/nf-mfapi-mfcreatesample
    [LibraryImport("MFPlat")]
    [SupportedOSPlatform("windows6.0.6000")]
    [PreserveSig]
    public static partial HRESULT MFCreateSample([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMFSample>))] out IMFSample ppIMFSample);
    
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-mfcreatesamplecopiermft
    [LibraryImport("MF")]
    [SupportedOSPlatform("windows6.1")]
    [PreserveSig]
    public static partial HRESULT MFCreateSampleCopierMFT([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMFTransform>))] out IMFTransform ppCopierMFT);
    
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-mfcreatesamplegrabbersinkactivate
    [LibraryImport("MF")]
    [SupportedOSPlatform("windows6.0.6000")]
    [PreserveSig]
    public static partial HRESULT MFCreateSampleGrabberSinkActivate([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMFMediaType>))] IMFMediaType pIMFMediaType, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMFSampleGrabberSinkCallback>))] IMFSampleGrabberSinkCallback pIMFSampleGrabberSinkCallback, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMFActivate>))] out IMFActivate ppIActivate);
    
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-mfcreatesensoractivitymonitor
    [LibraryImport("MFSENSORGROUP")]
    [PreserveSig]
    public static partial HRESULT MFCreateSensorActivityMonitor([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMFSensorActivitiesReportCallback>))] IMFSensorActivitiesReportCallback pCallback, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMFSensorActivityMonitor>))] out IMFSensorActivityMonitor ppActivityMonitor);
    
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-mfcreatesensorgroup
    [LibraryImport("MFSENSORGROUP")]
    [SupportedOSPlatform("windows10.0.14393")]
    [PreserveSig]
    public static partial HRESULT MFCreateSensorGroup(PWSTR SensorGroupSymbolicLink, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMFSensorGroup>))] out IMFSensorGroup ppSensorGroup);
    
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-mfcreatesensorprofile
    [LibraryImport("MFSENSORGROUP")]
    [SupportedOSPlatform("windows10.0.17134")]
    [PreserveSig]
    public static partial HRESULT MFCreateSensorProfile(in Guid ProfileType, uint ProfileIndex, PWSTR Constraints, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMFSensorProfile>))] out IMFSensorProfile ppProfile);
    
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-mfcreatesensorprofilecollection
    [LibraryImport("MFSENSORGROUP")]
    [SupportedOSPlatform("windows10.0.15063")]
    [PreserveSig]
    public static partial HRESULT MFCreateSensorProfileCollection([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMFSensorProfileCollection>))] out IMFSensorProfileCollection ppSensorProfile);
    
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-mfcreatesensorstream
    [LibraryImport("MFSENSORGROUP")]
    [SupportedOSPlatform("windows10.0.15063")]
    [PreserveSig]
    public static partial HRESULT MFCreateSensorStream(uint StreamId, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMFAttributes?>))] IMFAttributes? pAttributes, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMFCollection>))] IMFCollection pMediaTypeCollection, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMFSensorStream>))] out IMFSensorStream ppStream);
    
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-mfcreatesequencersegmentoffset
    [LibraryImport("MF")]
    [SupportedOSPlatform("windows6.0.6000")]
    [PreserveSig]
    public static partial HRESULT MFCreateSequencerSegmentOffset(uint dwId, long hnsOffset, out PROPVARIANT pvarSegmentOffset);
    
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-mfcreatesequencersource
    [LibraryImport("MF")]
    [SupportedOSPlatform("windows6.0.6000")]
    [PreserveSig]
    public static partial HRESULT MFCreateSequencerSource(nint pReserved, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMFSequencerSource>))] out IMFSequencerSource ppSequencerSource);
    
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-mfcreatesimpletypehandler
    [LibraryImport("MF")]
    [SupportedOSPlatform("windows6.0.6000")]
    [PreserveSig]
    public static partial HRESULT MFCreateSimpleTypeHandler([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMFMediaTypeHandler>))] out IMFMediaTypeHandler ppHandler);
    
    // https://learn.microsoft.com/windows/win32/api/mfreadwrite/nf-mfreadwrite-mfcreatesinkwriterfrommediasink
    [LibraryImport("MFReadWrite")]
    [SupportedOSPlatform("windows6.1")]
    [PreserveSig]
    public static partial HRESULT MFCreateSinkWriterFromMediaSink([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMFMediaSink>))] IMFMediaSink pMediaSink, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMFAttributes?>))] IMFAttributes? pAttributes, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMFSinkWriter>))] out IMFSinkWriter ppSinkWriter);
    
    // https://learn.microsoft.com/windows/win32/api/mfreadwrite/nf-mfreadwrite-mfcreatesinkwriterfromurl
    [LibraryImport("MFReadWrite")]
    [SupportedOSPlatform("windows6.1")]
    [PreserveSig]
    public static partial HRESULT MFCreateSinkWriterFromURL(PWSTR pwszOutputURL, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMFByteStream?>))] IMFByteStream? pByteStream, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMFAttributes?>))] IMFAttributes? pAttributes, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMFSinkWriter>))] out IMFSinkWriter ppSinkWriter);
    
    // https://learn.microsoft.com/windows/win32/api/mfreadwrite/nf-mfreadwrite-mfcreatesourcereaderfrombytestream
    [LibraryImport("MFReadWrite")]
    [SupportedOSPlatform("windows6.1")]
    [PreserveSig]
    public static partial HRESULT MFCreateSourceReaderFromByteStream([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMFByteStream>))] IMFByteStream pByteStream, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMFAttributes?>))] IMFAttributes? pAttributes, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMFSourceReader>))] out IMFSourceReader ppSourceReader);
    
    // https://learn.microsoft.com/windows/win32/api/mfreadwrite/nf-mfreadwrite-mfcreatesourcereaderfrommediasource
    [LibraryImport("MFReadWrite")]
    [SupportedOSPlatform("windows6.1")]
    [PreserveSig]
    public static partial HRESULT MFCreateSourceReaderFromMediaSource([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMFMediaSource>))] IMFMediaSource pMediaSource, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMFAttributes?>))] IMFAttributes? pAttributes, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMFSourceReader>))] out IMFSourceReader ppSourceReader);
    
    // https://learn.microsoft.com/windows/win32/api/mfreadwrite/nf-mfreadwrite-mfcreatesourcereaderfromurl
    [LibraryImport("MFReadWrite")]
    [SupportedOSPlatform("windows6.1")]
    [PreserveSig]
    public static partial HRESULT MFCreateSourceReaderFromURL(PWSTR pwszURL, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMFAttributes?>))] IMFAttributes? pAttributes, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMFSourceReader>))] out IMFSourceReader ppSourceReader);
    
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-mfcreatesourceresolver
    [LibraryImport("MFPlat")]
    [SupportedOSPlatform("windows6.0.6000")]
    [PreserveSig]
    public static partial HRESULT MFCreateSourceResolver([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMFSourceResolver>))] out IMFSourceResolver ppISourceResolver);
    
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-mfcreatestandardqualitymanager
    [LibraryImport("MF")]
    [SupportedOSPlatform("windows6.0.6000")]
    [PreserveSig]
    public static partial HRESULT MFCreateStandardQualityManager([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMFQualityManager>))] out IMFQualityManager ppQualityManager);
    
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-mfcreatestreamdescriptor
    [LibraryImport("MFPlat")]
    [SupportedOSPlatform("windows6.0.6000")]
    [PreserveSig]
    public static partial HRESULT MFCreateStreamDescriptor(uint dwStreamIdentifier, uint cMediaTypes, [In][MarshalUsing(CountElementName = nameof(cMediaTypes))] IMFMediaType[] apMediaTypes, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMFStreamDescriptor>))] out IMFStreamDescriptor ppDescriptor);
    
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-mfcreatestreamonmfbytestream
    [LibraryImport("MFPlat")]
    [SupportedOSPlatform("windows8.0")]
    [PreserveSig]
    public static partial HRESULT MFCreateStreamOnMFByteStream([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMFByteStream>))] IMFByteStream pByteStream, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IStream>))] out IStream ppStream);
    
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-mfcreatestreamonmfbytestreamex
    [LibraryImport("MFPlat")]
    [SupportedOSPlatform("windows8.0")]
    [PreserveSig]
    public static partial HRESULT MFCreateStreamOnMFByteStreamEx([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMFByteStream>))] IMFByteStream pByteStream, in Guid riid, out nint ppv);
    
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-mfcreatesystemtimesource
    [LibraryImport("MFPlat")]
    [SupportedOSPlatform("windows6.0.6000")]
    [PreserveSig]
    public static partial HRESULT MFCreateSystemTimeSource([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMFPresentationTimeSource>))] out IMFPresentationTimeSource ppSystemTimeSource);
    
    // https://learn.microsoft.com/windows/win32/api/mfapi/nf-mfapi-mfcreatetempfile
    [LibraryImport("MFPlat")]
    [SupportedOSPlatform("windows6.0.6000")]
    [PreserveSig]
    public static partial HRESULT MFCreateTempFile(MF_FILE_ACCESSMODE AccessMode, MF_FILE_OPENMODE OpenMode, MF_FILE_FLAGS fFlags, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMFByteStream>))] out IMFByteStream ppIByteStream);
    
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-mfcreatetopoloader
    [LibraryImport("MF")]
    [SupportedOSPlatform("windows6.0.6000")]
    [PreserveSig]
    public static partial HRESULT MFCreateTopoLoader([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMFTopoLoader>))] out IMFTopoLoader ppObj);
    
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-mfcreatetopology
    [LibraryImport("MF")]
    [SupportedOSPlatform("windows6.0.6000")]
    [PreserveSig]
    public static partial HRESULT MFCreateTopology([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMFTopology>))] out IMFTopology ppTopo);
    
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-mfcreatetopologynode
    [LibraryImport("MF")]
    [SupportedOSPlatform("windows6.0.6000")]
    [PreserveSig]
    public static partial HRESULT MFCreateTopologyNode(MF_TOPOLOGY_TYPE NodeType, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMFTopologyNode>))] out IMFTopologyNode ppNode);
    
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-mfcreatetrackedsample
    [LibraryImport("MFPlat")]
    [SupportedOSPlatform("windows8.0")]
    [PreserveSig]
    public static partial HRESULT MFCreateTrackedSample([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMFTrackedSample>))] out IMFTrackedSample ppMFSample);
    
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-mfcreatetranscodeprofile
    [LibraryImport("MF")]
    [SupportedOSPlatform("windows6.1")]
    [PreserveSig]
    public static partial HRESULT MFCreateTranscodeProfile([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMFTranscodeProfile>))] out IMFTranscodeProfile ppTranscodeProfile);
    
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-mfcreatetranscodesinkactivate
    [LibraryImport("MF")]
    [SupportedOSPlatform("windows6.1")]
    [PreserveSig]
    public static partial HRESULT MFCreateTranscodeSinkActivate([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMFActivate>))] out IMFActivate ppActivate);
    
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-mfcreatetranscodetopology
    [LibraryImport("MF")]
    [SupportedOSPlatform("windows6.1")]
    [PreserveSig]
    public static partial HRESULT MFCreateTranscodeTopology([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMFMediaSource>))] IMFMediaSource pSrc, PWSTR pwszOutputFilePath, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMFTranscodeProfile>))] IMFTranscodeProfile pProfile, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMFTopology>))] out IMFTopology ppTranscodeTopo);
    
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-mfcreatetranscodetopologyfrombytestream
    [LibraryImport("MF")]
    [SupportedOSPlatform("windows8.0")]
    [PreserveSig]
    public static partial HRESULT MFCreateTranscodeTopologyFromByteStream([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMFMediaSource>))] IMFMediaSource pSrc, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMFByteStream>))] IMFByteStream pOutputStream, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMFTranscodeProfile>))] IMFTranscodeProfile pProfile, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMFTopology>))] out IMFTopology ppTranscodeTopo);
    
    // https://learn.microsoft.com/windows/win32/api/mftransform/nf-mftransform-mfcreatetransformactivate
    [LibraryImport("MFPlat")]
    [SupportedOSPlatform("windows6.1")]
    [PreserveSig]
    public static partial HRESULT MFCreateTransformActivate([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMFActivate>))] out IMFActivate ppActivate);
    
    // https://learn.microsoft.com/windows/win32/api/mfapi/nf-mfapi-mfcreatevideomediatype
    [LibraryImport("MFPlat")]
    [SupportedOSPlatform("windows6.0.6000")]
    [PreserveSig]
    public static partial HRESULT MFCreateVideoMediaType(in MFVIDEOFORMAT pVideoFormat, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMFVideoMediaType>))] out IMFVideoMediaType ppIVideoMediaType);
    
    // https://learn.microsoft.com/windows/win32/api/mfapi/nf-mfapi-mfcreatevideomediatypefrombitmapinfoheader
    [LibraryImport("MFPlat")]
    [SupportedOSPlatform("windows6.0.6000")]
    [PreserveSig]
    public static partial HRESULT MFCreateVideoMediaTypeFromBitMapInfoHeader(in BITMAPINFOHEADER pbmihBitMapInfoHeader, uint dwPixelAspectRatioX, uint dwPixelAspectRatioY, MFVideoInterlaceMode InterlaceMode, ulong VideoFlags, ulong qwFramesPerSecondNumerator, ulong qwFramesPerSecondDenominator, uint dwMaxBitRate, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMFVideoMediaType>))] out IMFVideoMediaType ppIVideoMediaType);
    
    // https://learn.microsoft.com/windows/win32/api/mfapi/nf-mfapi-mfcreatevideomediatypefrombitmapinfoheaderex
    [LibraryImport("MFPlat")]
    [SupportedOSPlatform("windows6.1")]
    [PreserveSig]
    public static partial HRESULT MFCreateVideoMediaTypeFromBitMapInfoHeaderEx(in BITMAPINFOHEADER pbmihBitMapInfoHeader, uint cbBitMapInfoHeader, uint dwPixelAspectRatioX, uint dwPixelAspectRatioY, MFVideoInterlaceMode InterlaceMode, ulong VideoFlags, uint dwFramesPerSecondNumerator, uint dwFramesPerSecondDenominator, uint dwMaxBitRate, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMFVideoMediaType>))] out IMFVideoMediaType ppIVideoMediaType);
    
    // https://learn.microsoft.com/windows/win32/api/mfapi/nf-mfapi-mfcreatevideomediatypefromsubtype
    [LibraryImport("MFPlat")]
    [SupportedOSPlatform("windows6.0.6000")]
    [PreserveSig]
    public static partial HRESULT MFCreateVideoMediaTypeFromSubtype(in Guid pAMSubtype, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMFVideoMediaType>))] out IMFVideoMediaType ppIVideoMediaType);
    
    // https://learn.microsoft.com/windows/win32/api/evr/nc-evr-mfcreatevideomixer
    [LibraryImport("EVR")]
    [PreserveSig]
    public static partial HRESULT MFCreateVideoMixer(nint pOwner, in Guid riidDevice, in Guid riid, out nint ppv);
    
    // https://learn.microsoft.com/windows/win32/api/evr/nc-evr-mfcreatevideomixerandpresenter
    [LibraryImport("EVR")]
    [PreserveSig]
    public static partial HRESULT MFCreateVideoMixerAndPresenter(nint pMixerOwner, nint pPresenterOwner, in Guid riidMixer, out nint ppvVideoMixer, in Guid riidPresenter, out nint ppvVideoPresenter);
    
    // https://learn.microsoft.com/windows/win32/api/evr/nc-evr-mfcreatevideopresenter
    [LibraryImport("EVR")]
    [PreserveSig]
    public static partial HRESULT MFCreateVideoPresenter(nint pOwner, in Guid riidDevice, in Guid riid, out nint ppVideoPresenter);
    
    // https://learn.microsoft.com/windows/win32/api/evr/nc-evr-mfcreatevideorenderer
    [LibraryImport("MF")]
    [PreserveSig]
    public static partial HRESULT MFCreateVideoRenderer(in Guid riidRenderer, out nint ppVideoRenderer);
    
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-mfcreatevideorendereractivate
    [LibraryImport("MF")]
    [SupportedOSPlatform("windows6.0.6000")]
    [PreserveSig]
    public static partial HRESULT MFCreateVideoRendererActivate(HWND hwndVideo, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMFActivate>))] out IMFActivate ppActivate);
    
    // https://learn.microsoft.com/windows/win32/api/evr/nc-evr-mfcreatevideosampleallocator
    [LibraryImport("EVR")]
    [PreserveSig]
    public static partial HRESULT MFCreateVideoSampleAllocator(in Guid riid, out nint ppSampleAllocator);
    
    // https://learn.microsoft.com/windows/win32/api/mfapi/nf-mfapi-mfcreatevideosampleallocatorex
    [LibraryImport("MFPlat")]
    [SupportedOSPlatform("windows8.0")]
    [PreserveSig]
    public static partial HRESULT MFCreateVideoSampleAllocatorEx(in Guid riid, out nint ppSampleAllocator);
    
    // https://learn.microsoft.com/windows/win32/api/evr/nc-evr-mfcreatevideosamplefromsurface
    [LibraryImport("EVR")]
    [PreserveSig]
    public static partial HRESULT MFCreateVideoSampleFromSurface(nint pUnkSurface, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMFSample>))] out IMFSample ppSample);
    
    // https://learn.microsoft.com/windows/win32/api/mfvirtualcamera/nf-mfvirtualcamera-mfcreatevirtualcamera
    [LibraryImport("MFSENSORGROUP")]
    [PreserveSig]
    public static partial HRESULT MFCreateVirtualCamera(MFVirtualCameraType type, MFVirtualCameraLifetime lifetime, MFVirtualCameraAccess access, PWSTR friendlyName, PWSTR sourceId, nint /* optional Guid* */ categories, uint categoryCount, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMFVirtualCamera>))] out IMFVirtualCamera virtualCamera);
    
    // https://learn.microsoft.com/windows/win32/api/mfapi/nf-mfapi-mfcreatewaveformatexfrommfmediatype
    [LibraryImport("MFPlat")]
    [SupportedOSPlatform("windows6.0.6000")]
    [PreserveSig]
    public static partial HRESULT MFCreateWaveFormatExFromMFMediaType([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMFMediaType>))] IMFMediaType pMFType, out nint ppWF, nint /* optional uint* */ pcbSize, uint Flags);
    
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-mfcreatewavemediasink
    [LibraryImport("mfsrcsnk")]
    [SupportedOSPlatform("windows8.1")]
    [PreserveSig]
    public static partial HRESULT MFCreateWAVEMediaSink([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMFByteStream>))] IMFByteStream pTargetByteStream, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMFMediaType>))] IMFMediaType pAudioMediaType, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMFMediaSink>))] out IMFMediaSink ppMediaSink);
    
    // https://learn.microsoft.com/windows/win32/api/mfapi/nf-mfapi-mfcreatewicbitmapbuffer
    [LibraryImport("MFPlat")]
    [SupportedOSPlatform("windows8.0")]
    [PreserveSig]
    public static partial HRESULT MFCreateWICBitmapBuffer(in Guid riid, nint punkSurface, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMFMediaBuffer>))] out IMFMediaBuffer ppBuffer);
    
    // https://learn.microsoft.com/windows/win32/api/wmcontainer/nf-wmcontainer-mfcreatewmaencoderactivate
    [LibraryImport("MF")]
    [SupportedOSPlatform("windows6.0.6000")]
    [PreserveSig]
    public static partial HRESULT MFCreateWMAEncoderActivate([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMFMediaType>))] IMFMediaType pMediaType, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IPropertyStore>))] IPropertyStore pEncodingConfigurationProperties, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMFActivate>))] out IMFActivate ppActivate);
    
    // https://learn.microsoft.com/windows/win32/api/wmcontainer/nf-wmcontainer-mfcreatewmvencoderactivate
    [LibraryImport("MF")]
    [SupportedOSPlatform("windows6.0.6000")]
    [PreserveSig]
    public static partial HRESULT MFCreateWMVEncoderActivate([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMFMediaType>))] IMFMediaType pMediaType, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IPropertyStore>))] IPropertyStore pEncodingConfigurationProperties, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMFActivate>))] out IMFActivate ppActivate);
    
    // https://learn.microsoft.com/windows/win32/api/mfobjects/nf-mfobjects-mfdeserializeattributesfromstream
    [LibraryImport("MFPlat")]
    [SupportedOSPlatform("windows6.0.6000")]
    [PreserveSig]
    public static partial HRESULT MFDeserializeAttributesFromStream([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMFAttributes>))] IMFAttributes pAttr, uint dwOptions, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IStream>))] IStream pStm);
    
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-mfdeserializepresentationdescriptor
    [LibraryImport("MFPlat")]
    [SupportedOSPlatform("windows6.0.6000")]
    [PreserveSig]
    public static partial HRESULT MFDeserializePresentationDescriptor(uint cbData, nint /* byte array */ pbData, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMFPresentationDescriptor>))] out IMFPresentationDescriptor ppPD);
    
    // https://learn.microsoft.com/windows/win32/api/mfapi/nf-mfapi-mfendcreatefile
    [LibraryImport("MFPlat")]
    [SupportedOSPlatform("windows6.0.6000")]
    [PreserveSig]
    public static partial HRESULT MFEndCreateFile([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMFAsyncResult>))] IMFAsyncResult pResult, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMFByteStream>))] out IMFByteStream ppFile);
    
    // https://learn.microsoft.com/windows/win32/api/mfapi/nf-mfapi-mfendregisterworkqueuewithmmcss
    [LibraryImport("MFPlat")]
    [SupportedOSPlatform("windows6.0.6000")]
    [PreserveSig]
    public static partial HRESULT MFEndRegisterWorkQueueWithMMCSS([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMFAsyncResult>))] IMFAsyncResult pResult, out uint pdwTaskId);
    
    // https://learn.microsoft.com/windows/win32/api/mfapi/nf-mfapi-mfendunregisterworkqueuewithmmcss
    [LibraryImport("MFPlat")]
    [SupportedOSPlatform("windows6.0.6000")]
    [PreserveSig]
    public static partial HRESULT MFEndUnregisterWorkQueueWithMMCSS([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMFAsyncResult>))] IMFAsyncResult pResult);
    
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-mfenumdevicesources
    [LibraryImport("MF")]
    [SupportedOSPlatform("windows6.1")]
    [PreserveSig]
    public static partial HRESULT MFEnumDeviceSources([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMFAttributes>))] IMFAttributes pAttributes, out nint pppSourceActivate, out uint pcSourceActivate);
    
    // https://learn.microsoft.com/windows/win32/api/mfapi/nf-mfapi-mfframeratetoaveragetimeperframe
    [LibraryImport("MFPlat")]
    [SupportedOSPlatform("windows6.0.6000")]
    [PreserveSig]
    public static partial HRESULT MFFrameRateToAverageTimePerFrame(uint unNumerator, uint unDenominator, out ulong punAverageTimePerFrame);
    
    // https://learn.microsoft.com/windows/win32/api/mfapi/nf-mfapi-mfgetattributesasblob
    [LibraryImport("MFPlat")]
    [SupportedOSPlatform("windows6.0.6000")]
    [PreserveSig]
    public static partial HRESULT MFGetAttributesAsBlob([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMFAttributes>))] IMFAttributes pAttributes, nint /* byte array */ pBuf, uint cbBufSize);
    
    // https://learn.microsoft.com/windows/win32/api/mfapi/nf-mfapi-mfgetattributesasblobsize
    [LibraryImport("MFPlat")]
    [SupportedOSPlatform("windows6.0.6000")]
    [PreserveSig]
    public static partial HRESULT MFGetAttributesAsBlobSize([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMFAttributes>))] IMFAttributes pAttributes, out uint pcbBufSize);
    
    // https://learn.microsoft.com/windows/win32/api/mfapi/nf-mfapi-mfgetcontentprotectionsystemclsid
    [LibraryImport("MFPlat")]
    [SupportedOSPlatform("windows8.0")]
    [PreserveSig]
    public static partial HRESULT MFGetContentProtectionSystemCLSID(in Guid guidProtectionSystemID, out Guid pclsid);
    
    [LibraryImport("MFPlat")]
    [PreserveSig]
    public static partial HRESULT MFGetDXGIDeviceManageMode(nint pDeviceManager, out MF_DXGI_DEVICE_MANAGER_MODE mode);
    
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-mfgetlocalid
    [LibraryImport("MF")]
    [SupportedOSPlatform("windows8.0")]
    [PreserveSig]
    public static partial HRESULT MFGetLocalId(nint /* byte array */ verifier, uint size, out PWSTR id);
    
    // https://learn.microsoft.com/windows/win32/api/mfapi/nf-mfapi-mfgetmftmerit
    [LibraryImport("MFPlat")]
    [SupportedOSPlatform("windows6.1")]
    [PreserveSig]
    public static partial HRESULT MFGetMFTMerit(nint pMFT, uint cbVerifier, nint /* byte array */ verifier, out uint merit);
    
    // https://learn.microsoft.com/windows/win32/api/mfapi/nf-mfapi-mfgetplanesize
    [LibraryImport("EVR")]
    [SupportedOSPlatform("windows6.0.6000")]
    [PreserveSig]
    public static partial HRESULT MFGetPlaneSize(uint format, uint dwWidth, uint dwHeight, out uint pdwPlaneSize);
    
    // https://learn.microsoft.com/windows/win32/api/mfapi/nf-mfapi-mfgetplugincontrol
    [LibraryImport("MFPlat")]
    [SupportedOSPlatform("windows6.1")]
    [PreserveSig]
    public static partial HRESULT MFGetPluginControl([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMFPluginControl>))] out IMFPluginControl ppPluginControl);
    
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-mfgetservice
    [LibraryImport("MF")]
    [SupportedOSPlatform("windows6.0.6000")]
    [PreserveSig]
    public static partial HRESULT MFGetService(nint punkObject, in Guid guidService, in Guid riid, out nint ppvObject);
    
    // https://learn.microsoft.com/windows/win32/api/mfapi/nf-mfapi-mfgetstrideforbitmapinfoheader
    [LibraryImport("MFPlat")]
    [SupportedOSPlatform("windows6.0.6000")]
    [PreserveSig]
    public static partial HRESULT MFGetStrideForBitmapInfoHeader(uint format, uint dwWidth, out int pStride);
    
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-mfgetsupportedmimetypes
    [LibraryImport("MFPlat")]
    [SupportedOSPlatform("windows6.0.6000")]
    [PreserveSig]
    public static partial HRESULT MFGetSupportedMimeTypes(out PROPVARIANT pPropVarMimeTypeArray);
    
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-mfgetsupportedschemes
    [LibraryImport("MFPlat")]
    [SupportedOSPlatform("windows6.0.6000")]
    [PreserveSig]
    public static partial HRESULT MFGetSupportedSchemes(out PROPVARIANT pPropVarSchemeArray);
    
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-mfgetsystemid
    [LibraryImport("MF")]
    [SupportedOSPlatform("windows8.0")]
    [PreserveSig]
    public static partial HRESULT MFGetSystemId([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMFSystemId>))] out IMFSystemId ppId);
    
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-mfgetsystemtime
    [LibraryImport("MFPlat")]
    [SupportedOSPlatform("windows6.0.6000")]
    [PreserveSig]
    public static partial long MFGetSystemTime();
    
    // https://learn.microsoft.com/windows/win32/api/mfapi/nf-mfapi-mfgettimerperiodicity
    [LibraryImport("MFPlat")]
    [SupportedOSPlatform("windows6.0.6000")]
    [PreserveSig]
    public static partial HRESULT MFGetTimerPeriodicity(out uint Periodicity);
    
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-mfgettoponodecurrenttype
    [LibraryImport("MF")]
    [SupportedOSPlatform("windows6.1")]
    [PreserveSig]
    public static partial HRESULT MFGetTopoNodeCurrentType([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMFTopologyNode>))] IMFTopologyNode pNode, uint dwStreamIndex, BOOL fOutput, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMFMediaType>))] out IMFMediaType ppType);
    
    // https://learn.microsoft.com/windows/win32/api/mfapi/nf-mfapi-mfgetuncompressedvideoformat
    [LibraryImport("MFPlat")]
    [SupportedOSPlatform("windows6.0.6000")]
    [PreserveSig]
    public static partial uint MFGetUncompressedVideoFormat(in MFVIDEOFORMAT pVideoFormat);
    
    // https://learn.microsoft.com/windows/win32/api/mfapi/nf-mfapi-mfgetworkqueuemmcssclass
    [LibraryImport("MFPlat")]
    [SupportedOSPlatform("windows6.0.6000")]
    [PreserveSig]
    public static partial HRESULT MFGetWorkQueueMMCSSClass(uint dwWorkQueueId, [MarshalUsing(CountElementName = nameof(pcchClass))] PWSTR pwszClass, ref uint pcchClass);
    
    // https://learn.microsoft.com/windows/win32/api/mfapi/nf-mfapi-mfgetworkqueuemmcsspriority
    [LibraryImport("MFPlat")]
    [SupportedOSPlatform("windows8.0")]
    [PreserveSig]
    public static partial HRESULT MFGetWorkQueueMMCSSPriority(uint dwWorkQueueId, out int lPriority);
    
    // https://learn.microsoft.com/windows/win32/api/mfapi/nf-mfapi-mfgetworkqueuemmcsstaskid
    [LibraryImport("MFPlat")]
    [SupportedOSPlatform("windows6.0.6000")]
    [PreserveSig]
    public static partial HRESULT MFGetWorkQueueMMCSSTaskId(uint dwWorkQueueId, out uint pdwTaskId);
    
    // https://learn.microsoft.com/windows/win32/api/mfapi/nf-mfapi-mfheapalloc
    [LibraryImport("MFPlat")]
    [SupportedOSPlatform("windows6.0.6000")]
    [PreserveSig]
    public static partial nint MFHeapAlloc(nuint nSize, uint dwFlags, PSTR pszFile, int line, EAllocationType eat);
    
    // https://learn.microsoft.com/windows/win32/api/mfapi/nf-mfapi-mfheapfree
    [LibraryImport("MFPlat")]
    [SupportedOSPlatform("windows6.0.6000")]
    [PreserveSig]
    public static partial void MFHeapFree(nint pv);
    
    // https://learn.microsoft.com/windows/win32/api/mfapi/nf-mfapi-mfinitammediatypefrommfmediatype
    [LibraryImport("MFPlat")]
    [SupportedOSPlatform("windows6.0.6000")]
    [PreserveSig]
    public static partial HRESULT MFInitAMMediaTypeFromMFMediaType([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMFMediaType>))] IMFMediaType pMFType, Guid guidFormatBlockType, ref AM_MEDIA_TYPE pAMType);
    
    // https://learn.microsoft.com/windows/win32/api/mfapi/nf-mfapi-mfinitattributesfromblob
    [LibraryImport("MFPlat")]
    [SupportedOSPlatform("windows6.0.6000")]
    [PreserveSig]
    public static partial HRESULT MFInitAttributesFromBlob([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMFAttributes>))] IMFAttributes pAttributes, nint /* byte array */ pBuf, uint cbBufSize);
    
    // https://learn.microsoft.com/windows/win32/api/mfapi/nf-mfapi-mfinitmediatypefromammediatype
    [LibraryImport("MFPlat")]
    [SupportedOSPlatform("windows6.0.6000")]
    [PreserveSig]
    public static partial HRESULT MFInitMediaTypeFromAMMediaType([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMFMediaType>))] IMFMediaType pMFType, in AM_MEDIA_TYPE pAMType);
    
    // https://learn.microsoft.com/windows/win32/api/mfapi/nf-mfapi-mfinitmediatypefrommfvideoformat
    [LibraryImport("MFPlat")]
    [SupportedOSPlatform("windows6.0.6000")]
    [PreserveSig]
    public static partial HRESULT MFInitMediaTypeFromMFVideoFormat([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMFMediaType>))] IMFMediaType pMFType, in MFVIDEOFORMAT pMFVF, uint cbBufSize);
    
    // https://learn.microsoft.com/windows/win32/api/mfapi/nf-mfapi-mfinitmediatypefrommpeg1videoinfo
    [LibraryImport("MFPlat")]
    [SupportedOSPlatform("windows6.0.6000")]
    [PreserveSig]
    public static partial HRESULT MFInitMediaTypeFromMPEG1VideoInfo([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMFMediaType>))] IMFMediaType pMFType, in MPEG1VIDEOINFO pMP1VI, uint cbBufSize, nint /* optional Guid* */ pSubtype);
    
    // https://learn.microsoft.com/windows/win32/api/mfapi/nf-mfapi-mfinitmediatypefrommpeg2videoinfo
    [LibraryImport("MFPlat")]
    [SupportedOSPlatform("windows6.0.6000")]
    [PreserveSig]
    public static partial HRESULT MFInitMediaTypeFromMPEG2VideoInfo([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMFMediaType>))] IMFMediaType pMFType, in MPEG2VIDEOINFO pMP2VI, uint cbBufSize, nint /* optional Guid* */ pSubtype);
    
    // https://learn.microsoft.com/windows/win32/api/mfapi/nf-mfapi-mfinitmediatypefromvideoinfoheader
    [LibraryImport("MFPlat")]
    [SupportedOSPlatform("windows6.0.6000")]
    [PreserveSig]
    public static partial HRESULT MFInitMediaTypeFromVideoInfoHeader([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMFMediaType>))] IMFMediaType pMFType, in VIDEOINFOHEADER pVIH, uint cbBufSize, nint /* optional Guid* */ pSubtype);
    
    // https://learn.microsoft.com/windows/win32/api/mfapi/nf-mfapi-mfinitmediatypefromvideoinfoheader2
    [LibraryImport("MFPlat")]
    [SupportedOSPlatform("windows6.0.6000")]
    [PreserveSig]
    public static partial HRESULT MFInitMediaTypeFromVideoInfoHeader2([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMFMediaType>))] IMFMediaType pMFType, in VIDEOINFOHEADER2 pVIH2, uint cbBufSize, nint /* optional Guid* */ pSubtype);
    
    // https://learn.microsoft.com/windows/win32/api/mfapi/nf-mfapi-mfinitmediatypefromwaveformatex
    [LibraryImport("MFPlat")]
    [SupportedOSPlatform("windows6.0.6000")]
    [PreserveSig]
    public static partial HRESULT MFInitMediaTypeFromWaveFormatEx([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMFMediaType>))] IMFMediaType pMFType, in WAVEFORMATEX pWaveFormat, uint cbBufSize);
    
    // https://learn.microsoft.com/windows/win32/api/mfapi/nf-mfapi-mfinitvideoformat
    [LibraryImport("MFPlat")]
    [SupportedOSPlatform("windows6.0.6000")]
    [PreserveSig]
    public static partial HRESULT MFInitVideoFormat(in MFVIDEOFORMAT pVideoFormat, MFStandardVideoFormat type);
    
    // https://learn.microsoft.com/windows/win32/api/mfapi/nf-mfapi-mfinitvideoformat_rgb
    [LibraryImport("MFPlat")]
    [SupportedOSPlatform("windows6.0.6000")]
    [PreserveSig]
    public static partial HRESULT MFInitVideoFormat_RGB(in MFVIDEOFORMAT pVideoFormat, uint dwWidth, uint dwHeight, uint D3Dfmt);
    
    // https://learn.microsoft.com/windows/win32/api/mfapi/nf-mfapi-mfinvokecallback
    [LibraryImport("MFPlat")]
    [SupportedOSPlatform("windows6.0.6000")]
    [PreserveSig]
    public static partial HRESULT MFInvokeCallback([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMFAsyncResult>))] IMFAsyncResult pAsyncResult);
    
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-mfiscontentprotectiondevicesupported
    [LibraryImport("MFPlat")]
    [SupportedOSPlatform("windows10.0.10240")]
    [PreserveSig]
    public static partial HRESULT MFIsContentProtectionDeviceSupported(in Guid ProtectionSystemId, out BOOL isSupported);
    
    // https://learn.microsoft.com/windows/win32/api/mfapi/nf-mfapi-mfisformatyuv
    [LibraryImport("EVR", SetLastError = true)]
    [SupportedOSPlatform("windows6.0.6000")]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial BOOL MFIsFormatYUV(uint Format);
    
    // https://learn.microsoft.com/windows/win32/api/mfvirtualcamera/nf-mfvirtualcamera-mfisvirtualcameratypesupported
    [LibraryImport("MFSENSORGROUP")]
    [PreserveSig]
    public static partial HRESULT MFIsVirtualCameraTypeSupported(MFVirtualCameraType type, out BOOL supported);
    
    // https://learn.microsoft.com/windows/win32/api/mfapi/nf-mfapi-mfllmuldiv
    [LibraryImport("MFPlat")]
    [SupportedOSPlatform("windows6.1")]
    [PreserveSig]
    public static partial long MFllMulDiv(long a, long b, long c, long d);
    
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-mfloadsignedlibrary
    [LibraryImport("MF")]
    [SupportedOSPlatform("windows8.0")]
    [PreserveSig]
    public static partial HRESULT MFLoadSignedLibrary(PWSTR pszName, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMFSignedLibrary>))] out IMFSignedLibrary ppLib);
    
    // https://learn.microsoft.com/windows/win32/api/mfapi/nf-mfapi-mflockdxgidevicemanager
    [LibraryImport("MFPlat")]
    [SupportedOSPlatform("windows8.0")]
    [PreserveSig]
    public static partial HRESULT MFLockDXGIDeviceManager(nint /* optional uint* */ pResetToken, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMFDXGIDeviceManager>))] out IMFDXGIDeviceManager ppManager);
    
    // https://learn.microsoft.com/windows/win32/api/mfapi/nf-mfapi-mflockplatform
    [LibraryImport("MFPlat")]
    [SupportedOSPlatform("windows6.0.6000")]
    [PreserveSig]
    public static partial HRESULT MFLockPlatform();
    
    // https://learn.microsoft.com/windows/win32/api/mfapi/nf-mfapi-mflocksharedworkqueue
    [LibraryImport("MFPlat")]
    [SupportedOSPlatform("windows8.0")]
    [PreserveSig]
    public static partial HRESULT MFLockSharedWorkQueue(PWSTR wszClass, int BasePriority, ref uint pdwTaskId, out uint pID);
    
    // https://learn.microsoft.com/windows/win32/api/mfapi/nf-mfapi-mflockworkqueue
    [LibraryImport("MFPlat")]
    [SupportedOSPlatform("windows6.0.6000")]
    [PreserveSig]
    public static partial HRESULT MFLockWorkQueue(uint dwWorkQueue);
    
    // https://learn.microsoft.com/windows/win32/api/mfapi/nf-mfapi-mfmapdx9formattodxgiformat
    [LibraryImport("MFPlat")]
    [SupportedOSPlatform("windows8.0")]
    [PreserveSig]
    public static partial DXGI_FORMAT MFMapDX9FormatToDXGIFormat(uint dx9);
    
    // https://learn.microsoft.com/windows/win32/api/mfapi/nf-mfapi-mfmapdxgiformattodx9format
    [LibraryImport("MFPlat")]
    [SupportedOSPlatform("windows8.0")]
    [PreserveSig]
    public static partial uint MFMapDXGIFormatToDX9Format(DXGI_FORMAT dx11);
    
    // https://learn.microsoft.com/windows/win32/api/mfplay/nf-mfplay-mfpcreatemediaplayer
    [LibraryImport("MFPlay")]
    [SupportedOSPlatform("windows6.1")]
    [PreserveSig]
    public static partial HRESULT MFPCreateMediaPlayer(PWSTR pwszURL, BOOL fStartPlayback, MFP_CREATION_OPTIONS creationOptions, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMFPMediaPlayerCallback?>))] IMFPMediaPlayerCallback? pCallback, HWND hWnd, nint /* optional IMFPMediaPlayer* */ ppMediaPlayer);
    
    // https://learn.microsoft.com/windows/win32/api/mfapi/nf-mfapi-mfputwaitingworkitem
    [LibraryImport("MFPlat")]
    [SupportedOSPlatform("windows8.0")]
    [PreserveSig]
    public static partial HRESULT MFPutWaitingWorkItem(HANDLE hEvent, int Priority, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMFAsyncResult>))] IMFAsyncResult pResult, nint /* optional ulong* */ pKey);
    
    // https://learn.microsoft.com/windows/win32/api/mfapi/nf-mfapi-mfputworkitem
    [LibraryImport("MFPlat")]
    [SupportedOSPlatform("windows6.0.6000")]
    [PreserveSig]
    public static partial HRESULT MFPutWorkItem(uint dwQueue, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMFAsyncCallback>))] IMFAsyncCallback pCallback, nint pState);
    
    // https://learn.microsoft.com/windows/win32/api/mfapi/nf-mfapi-mfputworkitem2
    [LibraryImport("MFPlat")]
    [SupportedOSPlatform("windows8.0")]
    [PreserveSig]
    public static partial HRESULT MFPutWorkItem2(uint dwQueue, int Priority, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMFAsyncCallback>))] IMFAsyncCallback pCallback, nint pState);
    
    // https://learn.microsoft.com/windows/win32/api/mfapi/nf-mfapi-mfputworkitemex
    [LibraryImport("MFPlat")]
    [SupportedOSPlatform("windows6.0.6000")]
    [PreserveSig]
    public static partial HRESULT MFPutWorkItemEx(uint dwQueue, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMFAsyncResult>))] IMFAsyncResult pResult);
    
    // https://learn.microsoft.com/windows/win32/api/mfapi/nf-mfapi-mfputworkitemex2
    [LibraryImport("MFPlat")]
    [SupportedOSPlatform("windows8.0")]
    [PreserveSig]
    public static partial HRESULT MFPutWorkItemEx2(uint dwQueue, int Priority, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMFAsyncResult>))] IMFAsyncResult pResult);
    
    // https://learn.microsoft.com/windows/win32/api/mfapi/nf-mfapi-mfregisterlocalbytestreamhandler
    [LibraryImport("MFPlat")]
    [SupportedOSPlatform("windows8.0")]
    [PreserveSig]
    public static partial HRESULT MFRegisterLocalByteStreamHandler(PWSTR szFileExtension, PWSTR szMimeType, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMFActivate>))] IMFActivate pActivate);
    
    // https://learn.microsoft.com/windows/win32/api/mfapi/nf-mfapi-mfregisterlocalschemehandler
    [LibraryImport("MFPlat")]
    [SupportedOSPlatform("windows8.0")]
    [PreserveSig]
    public static partial HRESULT MFRegisterLocalSchemeHandler(PWSTR szScheme, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMFActivate>))] IMFActivate pActivate);
    
    // https://learn.microsoft.com/windows/win32/api/mfapi/nf-mfapi-mfregisterplatformwithmmcss
    [LibraryImport("MFPlat")]
    [SupportedOSPlatform("windows8.0")]
    [PreserveSig]
    public static partial HRESULT MFRegisterPlatformWithMMCSS(PWSTR wszClass, ref uint pdwTaskId, int lPriority);
    
    // https://learn.microsoft.com/windows/win32/api/mfapi/nf-mfapi-mfremoveperiodiccallback
    [LibraryImport("MFPlat")]
    [SupportedOSPlatform("windows6.0.6000")]
    [PreserveSig]
    public static partial HRESULT MFRemovePeriodicCallback(uint dwKey);
    
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-mfrequireprotectedenvironment
    [LibraryImport("MF")]
    [SupportedOSPlatform("windows6.0.6000")]
    [PreserveSig]
    public static partial HRESULT MFRequireProtectedEnvironment([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMFPresentationDescriptor>))] IMFPresentationDescriptor pPresentationDescriptor);
    
    // https://learn.microsoft.com/windows/win32/api/mfapi/nf-mfapi-mfscheduleworkitem
    [LibraryImport("MFPlat")]
    [SupportedOSPlatform("windows6.0.6000")]
    [PreserveSig]
    public static partial HRESULT MFScheduleWorkItem([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMFAsyncCallback>))] IMFAsyncCallback pCallback, nint pState, long Timeout, nint /* optional ulong* */ pKey);
    
    // https://learn.microsoft.com/windows/win32/api/mfapi/nf-mfapi-mfscheduleworkitemex
    [LibraryImport("MFPlat")]
    [SupportedOSPlatform("windows6.0.6000")]
    [PreserveSig]
    public static partial HRESULT MFScheduleWorkItemEx([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMFAsyncResult>))] IMFAsyncResult pResult, long Timeout, nint /* optional ulong* */ pKey);
    
    // https://learn.microsoft.com/windows/win32/api/mfobjects/nf-mfobjects-mfserializeattributestostream
    [LibraryImport("MFPlat")]
    [SupportedOSPlatform("windows6.0.6000")]
    [PreserveSig]
    public static partial HRESULT MFSerializeAttributesToStream([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMFAttributes>))] IMFAttributes pAttr, uint dwOptions, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IStream>))] IStream pStm);
    
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-mfserializepresentationdescriptor
    [LibraryImport("MFPlat")]
    [SupportedOSPlatform("windows6.0.6000")]
    [PreserveSig]
    public static partial HRESULT MFSerializePresentationDescriptor([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMFPresentationDescriptor>))] IMFPresentationDescriptor pPD, out uint pcbData, out nint /* byte array */ ppbData);
    
    // https://learn.microsoft.com/windows/win32/api/mfapi/nf-mfapi-mfshutdown
    [LibraryImport("MFPlat")]
    [SupportedOSPlatform("windows6.0.6000")]
    [PreserveSig]
    public static partial HRESULT MFShutdown();
    
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-mfshutdownobject
    [LibraryImport("MF")]
    [SupportedOSPlatform("windows6.0.6000")]
    [PreserveSig]
    public static partial HRESULT MFShutdownObject(nint pUnk);
    
    // https://learn.microsoft.com/windows/win32/api/mfapi/nf-mfapi-mfsplitsample
    [LibraryImport("MFPlat")]
    [SupportedOSPlatform("windows10.0.19041")]
    [PreserveSig]
    public static partial HRESULT MFSplitSample([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMFSample>))] IMFSample pSample, [In][Out][MarshalUsing(CountElementName = nameof(dwOutputSampleMaxCount))] nint[] pOutputSamples, uint dwOutputSampleMaxCount, out uint pdwOutputSampleCount);
    
    // https://learn.microsoft.com/windows/win32/api/mfapi/nf-mfapi-mfstartup
    [LibraryImport("MFPlat")]
    [SupportedOSPlatform("windows6.0.6000")]
    [PreserveSig]
    public static partial HRESULT MFStartup(uint Version, uint dwFlags);
    
    // https://learn.microsoft.com/windows/win32/api/mfapi/nf-mfapi-mftenum
    [LibraryImport("MFPlat")]
    [SupportedOSPlatform("windows6.0.6000")]
    [PreserveSig]
    public static partial HRESULT MFTEnum(Guid guidCategory, uint Flags, nint /* optional MFT_REGISTER_TYPE_INFO* */ pInputType, nint /* optional MFT_REGISTER_TYPE_INFO* */ pOutputType, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMFAttributes?>))] IMFAttributes? pAttributes, out nint ppclsidMFT, out uint pcMFTs);
    
    // https://learn.microsoft.com/windows/win32/api/mfapi/nf-mfapi-mftenum2
    [LibraryImport("MFPlat")]
    [SupportedOSPlatform("windows10.0.10240")]
    [PreserveSig]
    public static partial HRESULT MFTEnum2(Guid guidCategory, uint Flags, nint /* optional MFT_REGISTER_TYPE_INFO* */ pInputType, nint /* optional MFT_REGISTER_TYPE_INFO* */ pOutputType, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMFAttributes?>))] IMFAttributes? pAttributes, out nint pppMFTActivate, out uint pnumMFTActivate);
    
    // https://learn.microsoft.com/windows/win32/api/mfapi/nf-mfapi-mftenumex
    [LibraryImport("MFPlat")]
    [SupportedOSPlatform("windows6.1")]
    [PreserveSig]
    public static partial HRESULT MFTEnumEx(Guid guidCategory, uint Flags, nint /* optional MFT_REGISTER_TYPE_INFO* */ pInputType, nint /* optional MFT_REGISTER_TYPE_INFO* */ pOutputType, out nint pppMFTActivate, out uint pnumMFTActivate);
    
    // https://learn.microsoft.com/windows/win32/api/mfapi/nf-mfapi-mftgetinfo
    [LibraryImport("MFPlat")]
    [SupportedOSPlatform("windows6.0.6000")]
    [PreserveSig]
    public static partial HRESULT MFTGetInfo(Guid clsidMFT, nint /* optional PWSTR* */ pszName, nint /* optional MFT_REGISTER_TYPE_INFO** */ ppInputTypes, nint /* optional uint* */ pcInputTypes, nint /* optional MFT_REGISTER_TYPE_INFO** */ ppOutputTypes, nint /* optional uint* */ pcOutputTypes, nint /* optional IMFAttributes* */ ppAttributes);
    
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-mftranscodegetaudiooutputavailabletypes
    [LibraryImport("MF")]
    [SupportedOSPlatform("windows6.1")]
    [PreserveSig]
    public static partial HRESULT MFTranscodeGetAudioOutputAvailableTypes(in Guid guidSubType, uint dwMFTFlags, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMFAttributes?>))] IMFAttributes? pCodecConfig, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMFCollection>))] out IMFCollection ppAvailableTypes);
    
    // https://learn.microsoft.com/windows/win32/api/mfapi/nf-mfapi-mftregister
    [LibraryImport("MFPlat")]
    [SupportedOSPlatform("windows6.0.6000")]
    [PreserveSig]
    public static partial HRESULT MFTRegister(Guid clsidMFT, Guid guidCategory, PWSTR pszName, uint Flags, uint cInputTypes, nint /* optional MFT_REGISTER_TYPE_INFO* */ pInputTypes, uint cOutputTypes, nint /* optional MFT_REGISTER_TYPE_INFO* */ pOutputTypes, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMFAttributes?>))] IMFAttributes? pAttributes);
    
    // https://learn.microsoft.com/windows/win32/api/mfapi/nf-mfapi-mftregisterlocal
    [LibraryImport("MFPlat")]
    [SupportedOSPlatform("windows6.1")]
    [PreserveSig]
    public static partial HRESULT MFTRegisterLocal([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IClassFactory>))] IClassFactory pClassFactory, in Guid guidCategory, PWSTR pszName, uint Flags, uint cInputTypes, nint /* optional MFT_REGISTER_TYPE_INFO* */ pInputTypes, uint cOutputTypes, nint /* optional MFT_REGISTER_TYPE_INFO* */ pOutputTypes);
    
    // https://learn.microsoft.com/windows/win32/api/mfapi/nf-mfapi-mftregisterlocalbyclsid
    [LibraryImport("MFPlat")]
    [SupportedOSPlatform("windows6.1")]
    [PreserveSig]
    public static partial HRESULT MFTRegisterLocalByCLSID(in Guid clisdMFT, in Guid guidCategory, PWSTR pszName, uint Flags, uint cInputTypes, nint /* optional MFT_REGISTER_TYPE_INFO* */ pInputTypes, uint cOutputTypes, nint /* optional MFT_REGISTER_TYPE_INFO* */ pOutputTypes);
    
    // https://learn.microsoft.com/windows/win32/api/mfapi/nf-mfapi-mftunregister
    [LibraryImport("MFPlat")]
    [SupportedOSPlatform("windows6.0.6000")]
    [PreserveSig]
    public static partial HRESULT MFTUnregister(Guid clsidMFT);
    
    // https://learn.microsoft.com/windows/win32/api/mfapi/nf-mfapi-mftunregisterlocal
    [LibraryImport("MFPlat")]
    [SupportedOSPlatform("windows6.1")]
    [PreserveSig]
    public static partial HRESULT MFTUnregisterLocal([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IClassFactory?>))] IClassFactory? pClassFactory);
    
    // https://learn.microsoft.com/windows/win32/api/mfapi/nf-mfapi-mftunregisterlocalbyclsid
    [LibraryImport("MFPlat")]
    [SupportedOSPlatform("windows6.1")]
    [PreserveSig]
    public static partial HRESULT MFTUnregisterLocalByCLSID(Guid clsidMFT);
    
    // https://learn.microsoft.com/windows/win32/api/mfapi/nf-mfapi-mfunlockdxgidevicemanager
    [LibraryImport("MFPlat")]
    [SupportedOSPlatform("windows8.0")]
    [PreserveSig]
    public static partial HRESULT MFUnlockDXGIDeviceManager();
    
    // https://learn.microsoft.com/windows/win32/api/mfapi/nf-mfapi-mfunlockplatform
    [LibraryImport("MFPlat")]
    [SupportedOSPlatform("windows6.0.6000")]
    [PreserveSig]
    public static partial HRESULT MFUnlockPlatform();
    
    // https://learn.microsoft.com/windows/win32/api/mfapi/nf-mfapi-mfunlockworkqueue
    [LibraryImport("MFPlat")]
    [SupportedOSPlatform("windows6.0.6000")]
    [PreserveSig]
    public static partial HRESULT MFUnlockWorkQueue(uint dwWorkQueue);
    
    // https://learn.microsoft.com/windows/win32/api/mfapi/nf-mfapi-mfunregisterplatformfrommmcss
    [LibraryImport("MFPlat")]
    [SupportedOSPlatform("windows8.0")]
    [PreserveSig]
    public static partial HRESULT MFUnregisterPlatformFromMMCSS();
    
    // https://learn.microsoft.com/windows/win32/api/mfapi/nf-mfapi-mfunwrapmediatype
    [LibraryImport("MFPlat")]
    [SupportedOSPlatform("windows6.0.6000")]
    [PreserveSig]
    public static partial HRESULT MFUnwrapMediaType([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMFMediaType>))] IMFMediaType pWrap, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMFMediaType>))] out IMFMediaType ppOrig);
    
    // https://learn.microsoft.com/windows/win32/api/mfapi/nf-mfapi-mfvalidatemediatypesize
    [LibraryImport("MFPlat")]
    [SupportedOSPlatform("windows6.0.6000")]
    [PreserveSig]
    public static partial HRESULT MFValidateMediaTypeSize(Guid FormatType, nint /* optional byte* */ pBlock, uint cbSize);
    
    // https://learn.microsoft.com/windows/win32/api/mfapi/nf-mfapi-mfwrapmediatype
    [LibraryImport("MFPlat")]
    [SupportedOSPlatform("windows6.0.6000")]
    [PreserveSig]
    public static partial HRESULT MFWrapMediaType([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMFMediaType>))] IMFMediaType pOrig, in Guid MajorType, in Guid SubType, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMFMediaType>))] out IMFMediaType ppWrap);
    
    // https://learn.microsoft.com/windows/win32/api/mmeapi/nf-mmeapi-midiconnect
    [LibraryImport("WINMM")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    public static partial uint midiConnect(HMIDI hmi, HMIDIOUT hmo, nint /* optional void* */ pReserved);
    
    // https://learn.microsoft.com/windows/win32/api/mmeapi/nf-mmeapi-mididisconnect
    [LibraryImport("WINMM")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    public static partial uint midiDisconnect(HMIDI hmi, HMIDIOUT hmo, nint /* optional void* */ pReserved);
    
    // https://learn.microsoft.com/windows/win32/api/mmeapi/nf-mmeapi-midiinaddbuffer
    [LibraryImport("WINMM")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    public static partial uint midiInAddBuffer(HMIDIIN hmi, nint pmh, uint cbmh);
    
    // https://learn.microsoft.com/windows/win32/api/mmeapi/nf-mmeapi-midiinclose
    [LibraryImport("WINMM")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    public static partial uint midiInClose(HMIDIIN hmi);
    
    // https://learn.microsoft.com/windows/win32/api/mmeapi/nf-mmeapi-midiingetdevcapsa
    [LibraryImport("WINMM")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    public static partial uint midiInGetDevCapsA(nuint uDeviceID, nint pmic, uint cbmic);
    
    // https://learn.microsoft.com/windows/win32/api/mmeapi/nf-mmeapi-midiingetdevcapsw
    [LibraryImport("WINMM", StringMarshalling = StringMarshalling.Utf16)]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    public static partial uint midiInGetDevCapsW(nuint uDeviceID, nint pmic, uint cbmic);
    
    // https://learn.microsoft.com/windows/win32/api/mmeapi/nf-mmeapi-midiingeterrortexta
    [LibraryImport("WINMM")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    public static partial uint midiInGetErrorTextA(uint mmrError, [MarshalUsing(CountElementName = nameof(cchText))] PSTR pszText, uint cchText);
    
    // https://learn.microsoft.com/windows/win32/api/mmeapi/nf-mmeapi-midiingeterrortextw
    [LibraryImport("WINMM", StringMarshalling = StringMarshalling.Utf16)]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    public static partial uint midiInGetErrorTextW(uint mmrError, [MarshalUsing(CountElementName = nameof(cchText))] PWSTR pszText, uint cchText);
    
    // https://learn.microsoft.com/windows/win32/api/mmeapi/nf-mmeapi-midiingetid
    [LibraryImport("WINMM")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    public static partial uint midiInGetID(HMIDIIN hmi, out uint puDeviceID);
    
    // https://learn.microsoft.com/windows/win32/api/mmeapi/nf-mmeapi-midiingetnumdevs
    [LibraryImport("WINMM")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    public static partial uint midiInGetNumDevs();
    
    // https://learn.microsoft.com/windows/win32/api/mmeapi/nf-mmeapi-midiinmessage
    [LibraryImport("WINMM")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    public static partial uint midiInMessage(HMIDIIN hmi, uint uMsg, nuint dw1, nuint dw2);
    
    // https://learn.microsoft.com/windows/win32/api/mmeapi/nf-mmeapi-midiinopen
    [LibraryImport("WINMM")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    public static partial uint midiInOpen(out HMIDIIN phmi, uint uDeviceID, nuint dwCallback, nuint dwInstance, MIDI_WAVE_OPEN_TYPE fdwOpen);
    
    // https://learn.microsoft.com/windows/win32/api/mmeapi/nf-mmeapi-midiinprepareheader
    [LibraryImport("WINMM")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    public static partial uint midiInPrepareHeader(HMIDIIN hmi, ref MIDIHDR pmh, uint cbmh);
    
    // https://learn.microsoft.com/windows/win32/api/mmeapi/nf-mmeapi-midiinreset
    [LibraryImport("WINMM")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    public static partial uint midiInReset(HMIDIIN hmi);
    
    // https://learn.microsoft.com/windows/win32/api/mmeapi/nf-mmeapi-midiinstart
    [LibraryImport("WINMM")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    public static partial uint midiInStart(HMIDIIN hmi);
    
    // https://learn.microsoft.com/windows/win32/api/mmeapi/nf-mmeapi-midiinstop
    [LibraryImport("WINMM")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    public static partial uint midiInStop(HMIDIIN hmi);
    
    // https://learn.microsoft.com/windows/win32/api/mmeapi/nf-mmeapi-midiinunprepareheader
    [LibraryImport("WINMM")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    public static partial uint midiInUnprepareHeader(HMIDIIN hmi, ref MIDIHDR pmh, uint cbmh);
    
    // https://learn.microsoft.com/windows/win32/api/mmeapi/nf-mmeapi-midioutcachedrumpatches
    [LibraryImport("WINMM")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    public static partial uint midiOutCacheDrumPatches(HMIDIOUT hmo, uint uPatch, [In][MarshalUsing(ConstantElementCount = 128)] ushort[] pwkya, uint fuCache);
    
    // https://learn.microsoft.com/windows/win32/api/mmeapi/nf-mmeapi-midioutcachepatches
    [LibraryImport("WINMM")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    public static partial uint midiOutCachePatches(HMIDIOUT hmo, uint uBank, [In][MarshalUsing(ConstantElementCount = 128)] ushort[] pwpa, uint fuCache);
    
    // https://learn.microsoft.com/windows/win32/api/mmeapi/nf-mmeapi-midioutclose
    [LibraryImport("WINMM")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    public static partial uint midiOutClose(HMIDIOUT hmo);
    
    // https://learn.microsoft.com/windows/win32/api/mmeapi/nf-mmeapi-midioutgetdevcapsa
    [LibraryImport("WINMM")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    public static partial uint midiOutGetDevCapsA(nuint uDeviceID, nint pmoc, uint cbmoc);
    
    // https://learn.microsoft.com/windows/win32/api/mmeapi/nf-mmeapi-midioutgetdevcapsw
    [LibraryImport("WINMM", StringMarshalling = StringMarshalling.Utf16)]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    public static partial uint midiOutGetDevCapsW(nuint uDeviceID, nint pmoc, uint cbmoc);
    
    // https://learn.microsoft.com/windows/win32/api/mmeapi/nf-mmeapi-midioutgeterrortexta
    [LibraryImport("WINMM")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    public static partial uint midiOutGetErrorTextA(uint mmrError, [MarshalUsing(CountElementName = nameof(cchText))] PSTR pszText, uint cchText);
    
    // https://learn.microsoft.com/windows/win32/api/mmeapi/nf-mmeapi-midioutgeterrortextw
    [LibraryImport("WINMM", StringMarshalling = StringMarshalling.Utf16)]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    public static partial uint midiOutGetErrorTextW(uint mmrError, [MarshalUsing(CountElementName = nameof(cchText))] PWSTR pszText, uint cchText);
    
    // https://learn.microsoft.com/windows/win32/api/mmeapi/nf-mmeapi-midioutgetid
    [LibraryImport("WINMM")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    public static partial uint midiOutGetID(HMIDIOUT hmo, out uint puDeviceID);
    
    // https://learn.microsoft.com/windows/win32/api/mmeapi/nf-mmeapi-midioutgetnumdevs
    [LibraryImport("WINMM")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    public static partial uint midiOutGetNumDevs();
    
    // https://learn.microsoft.com/windows/win32/api/mmeapi/nf-mmeapi-midioutgetvolume
    [LibraryImport("WINMM")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    public static partial uint midiOutGetVolume(HMIDIOUT hmo, out uint pdwVolume);
    
    // https://learn.microsoft.com/windows/win32/api/mmeapi/nf-mmeapi-midioutlongmsg
    [LibraryImport("WINMM")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    public static partial uint midiOutLongMsg(HMIDIOUT hmo, in MIDIHDR pmh, uint cbmh);
    
    // https://learn.microsoft.com/windows/win32/api/mmeapi/nf-mmeapi-midioutmessage
    [LibraryImport("WINMM")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    public static partial uint midiOutMessage(HMIDIOUT hmo, uint uMsg, nuint dw1, nuint dw2);
    
    // https://learn.microsoft.com/windows/win32/api/mmeapi/nf-mmeapi-midioutopen
    [LibraryImport("WINMM")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    public static partial uint midiOutOpen(out HMIDIOUT phmo, uint uDeviceID, nuint dwCallback, nuint dwInstance, MIDI_WAVE_OPEN_TYPE fdwOpen);
    
    // https://learn.microsoft.com/windows/win32/api/mmeapi/nf-mmeapi-midioutprepareheader
    [LibraryImport("WINMM")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    public static partial uint midiOutPrepareHeader(HMIDIOUT hmo, ref MIDIHDR pmh, uint cbmh);
    
    // https://learn.microsoft.com/windows/win32/api/mmeapi/nf-mmeapi-midioutreset
    [LibraryImport("WINMM")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    public static partial uint midiOutReset(HMIDIOUT hmo);
    
    // https://learn.microsoft.com/windows/win32/api/mmeapi/nf-mmeapi-midioutsetvolume
    [LibraryImport("WINMM")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    public static partial uint midiOutSetVolume(HMIDIOUT hmo, uint dwVolume);
    
    // https://learn.microsoft.com/windows/win32/api/mmeapi/nf-mmeapi-midioutshortmsg
    [LibraryImport("WINMM")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    public static partial uint midiOutShortMsg(HMIDIOUT hmo, uint dwMsg);
    
    // https://learn.microsoft.com/windows/win32/api/mmeapi/nf-mmeapi-midioutunprepareheader
    [LibraryImport("WINMM")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    public static partial uint midiOutUnprepareHeader(HMIDIOUT hmo, ref MIDIHDR pmh, uint cbmh);
    
    // https://learn.microsoft.com/windows/win32/api/mmeapi/nf-mmeapi-midistreamclose
    [LibraryImport("WINMM")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    public static partial uint midiStreamClose(HMIDISTRM hms);
    
    // https://learn.microsoft.com/windows/win32/api/mmeapi/nf-mmeapi-midistreamopen
    [LibraryImport("WINMM")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    public static partial uint midiStreamOpen(out HMIDISTRM phms, [In][Out][MarshalUsing(CountElementName = nameof(cMidi))] uint[] puDeviceID, uint cMidi, nuint dwCallback, nuint dwInstance, uint fdwOpen);
    
    // https://learn.microsoft.com/windows/win32/api/mmeapi/nf-mmeapi-midistreamout
    [LibraryImport("WINMM")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    public static partial uint midiStreamOut(HMIDISTRM hms, nint pmh, uint cbmh);
    
    // https://learn.microsoft.com/windows/win32/api/mmeapi/nf-mmeapi-midistreampause
    [LibraryImport("WINMM")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    public static partial uint midiStreamPause(HMIDISTRM hms);
    
    // https://learn.microsoft.com/windows/win32/api/mmeapi/nf-mmeapi-midistreamposition
    [LibraryImport("WINMM")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    public static partial uint midiStreamPosition(HMIDISTRM hms, nint lpmmt, uint cbmmt);
    
    // https://learn.microsoft.com/windows/win32/api/mmeapi/nf-mmeapi-midistreamproperty
    [LibraryImport("WINMM")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    public static partial uint midiStreamProperty(HMIDISTRM hms, nint /* byte array */ lppropdata, uint dwProperty);
    
    // https://learn.microsoft.com/windows/win32/api/mmeapi/nf-mmeapi-midistreamrestart
    [LibraryImport("WINMM")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    public static partial uint midiStreamRestart(HMIDISTRM hms);
    
    // https://learn.microsoft.com/windows/win32/api/mmeapi/nf-mmeapi-midistreamstop
    [LibraryImport("WINMM")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    public static partial uint midiStreamStop(HMIDISTRM hms);
    
    // https://learn.microsoft.com/windows/win32/api/mmeapi/nf-mmeapi-mixerclose
    [LibraryImport("WINMM")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    public static partial uint mixerClose(HMIXER hmx);
    
    // https://learn.microsoft.com/windows/win32/api/mmeapi/nf-mmeapi-mixergetcontroldetailsa
    [LibraryImport("WINMM")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    public static partial uint mixerGetControlDetailsA(HMIXEROBJ hmxobj, ref MIXERCONTROLDETAILS pmxcd, uint fdwDetails);
    
    // https://learn.microsoft.com/windows/win32/api/mmeapi/nf-mmeapi-mixergetcontroldetailsw
    [LibraryImport("WINMM", StringMarshalling = StringMarshalling.Utf16)]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    public static partial uint mixerGetControlDetailsW(HMIXEROBJ hmxobj, ref MIXERCONTROLDETAILS pmxcd, uint fdwDetails);
    
    // https://learn.microsoft.com/windows/win32/api/mmeapi/nf-mmeapi-mixergetdevcapsa
    [LibraryImport("WINMM")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    public static partial uint mixerGetDevCapsA(nuint uMxId, nint pmxcaps, uint cbmxcaps);
    
    // https://learn.microsoft.com/windows/win32/api/mmeapi/nf-mmeapi-mixergetdevcapsw
    [LibraryImport("WINMM", StringMarshalling = StringMarshalling.Utf16)]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    public static partial uint mixerGetDevCapsW(nuint uMxId, nint pmxcaps, uint cbmxcaps);
    
    // https://learn.microsoft.com/windows/win32/api/mmeapi/nf-mmeapi-mixergetid
    [LibraryImport("WINMM")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    public static partial uint mixerGetID(HMIXEROBJ hmxobj, out uint puMxId, uint fdwId);
    
    // https://learn.microsoft.com/windows/win32/api/mmeapi/nf-mmeapi-mixergetlinecontrolsa
    [LibraryImport("WINMM")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    public static partial uint mixerGetLineControlsA(HMIXEROBJ hmxobj, ref MIXERLINECONTROLSA pmxlc, uint fdwControls);
    
    // https://learn.microsoft.com/windows/win32/api/mmeapi/nf-mmeapi-mixergetlinecontrolsw
    [LibraryImport("WINMM", StringMarshalling = StringMarshalling.Utf16)]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    public static partial uint mixerGetLineControlsW(HMIXEROBJ hmxobj, ref MIXERLINECONTROLSW pmxlc, uint fdwControls);
    
    // https://learn.microsoft.com/windows/win32/api/mmeapi/nf-mmeapi-mixergetlineinfoa
    [LibraryImport("WINMM")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    public static partial uint mixerGetLineInfoA(HMIXEROBJ hmxobj, ref MIXERLINEA pmxl, uint fdwInfo);
    
    // https://learn.microsoft.com/windows/win32/api/mmeapi/nf-mmeapi-mixergetlineinfow
    [LibraryImport("WINMM", StringMarshalling = StringMarshalling.Utf16)]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    public static partial uint mixerGetLineInfoW(HMIXEROBJ hmxobj, ref MIXERLINEW pmxl, uint fdwInfo);
    
    // https://learn.microsoft.com/windows/win32/api/mmeapi/nf-mmeapi-mixergetnumdevs
    [LibraryImport("WINMM")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    public static partial uint mixerGetNumDevs();
    
    // https://learn.microsoft.com/windows/win32/api/mmeapi/nf-mmeapi-mixermessage
    [LibraryImport("WINMM")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    public static partial uint mixerMessage(HMIXER hmx, uint uMsg, nuint dwParam1, nuint dwParam2);
    
    // https://learn.microsoft.com/windows/win32/api/mmeapi/nf-mmeapi-mixeropen
    [LibraryImport("WINMM")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    public static partial uint mixerOpen(nint /* optional HMIXER* */ phmx, uint uMxId, nuint dwCallback, nuint dwInstance, uint fdwOpen);
    
    // https://learn.microsoft.com/windows/win32/api/mmeapi/nf-mmeapi-mixersetcontroldetails
    [LibraryImport("WINMM")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    public static partial uint mixerSetControlDetails(HMIXEROBJ hmxobj, in MIXERCONTROLDETAILS pmxcd, uint fdwDetails);
    
    [LibraryImport("WINMM")]
    [PreserveSig]
    public static partial uint mmDrvInstall(HDRVR hDriver, PWSTR wszDrvEntry, DRIVERMSGPROC drvMessage, uint wFlags);
    
    // https://learn.microsoft.com/windows/win32/api/mmddk/nf-mmddk-mmgetcurrenttask
    [LibraryImport("WINMM")]
    [PreserveSig]
    public static partial uint mmGetCurrentTask();
    
    // https://learn.microsoft.com/windows/win32/api/mmiscapi/nf-mmiscapi-mmioadvance
    [LibraryImport("WINMM")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    public static partial uint mmioAdvance(HMMIO hmmio, nint /* optional MMIOINFO* */ pmmioinfo, uint fuAdvance);
    
    // https://learn.microsoft.com/windows/win32/api/mmiscapi/nf-mmiscapi-mmioascend
    [LibraryImport("WINMM")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    public static partial uint mmioAscend(HMMIO hmmio, in MMCKINFO pmmcki, uint fuAscend);
    
    // https://learn.microsoft.com/windows/win32/api/mmiscapi/nf-mmiscapi-mmioclose
    [LibraryImport("WINMM")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    public static partial uint mmioClose(HMMIO hmmio, uint fuClose);
    
    // https://learn.microsoft.com/windows/win32/api/mmiscapi/nf-mmiscapi-mmiocreatechunk
    [LibraryImport("WINMM")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    public static partial uint mmioCreateChunk(HMMIO hmmio, in MMCKINFO pmmcki, uint fuCreate);
    
    // https://learn.microsoft.com/windows/win32/api/mmiscapi/nf-mmiscapi-mmiodescend
    [LibraryImport("WINMM")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    public static partial uint mmioDescend(HMMIO hmmio, ref MMCKINFO pmmcki, nint /* optional MMCKINFO* */ pmmckiParent, uint fuDescend);
    
    // https://learn.microsoft.com/windows/win32/api/mmiscapi/nf-mmiscapi-mmioflush
    [LibraryImport("WINMM")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    public static partial uint mmioFlush(HMMIO hmmio, uint fuFlush);
    
    // https://learn.microsoft.com/windows/win32/api/mmiscapi/nf-mmiscapi-mmiogetinfo
    [LibraryImport("WINMM")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    public static partial uint mmioGetInfo(HMMIO hmmio, out MMIOINFO pmmioinfo, uint fuInfo);
    
    // https://learn.microsoft.com/windows/win32/api/mmiscapi/nf-mmiscapi-mmioinstallioproca
    [LibraryImport("WINMM")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    public static partial LPMMIOPROC mmioInstallIOProcA(uint fccIOProc, LPMMIOPROC? pIOProc, uint dwFlags);
    
    // https://learn.microsoft.com/windows/win32/api/mmiscapi/nf-mmiscapi-mmioinstallioprocw
    [LibraryImport("WINMM", StringMarshalling = StringMarshalling.Utf16)]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    public static partial LPMMIOPROC mmioInstallIOProcW(uint fccIOProc, LPMMIOPROC? pIOProc, uint dwFlags);
    
    // https://learn.microsoft.com/windows/win32/api/mmiscapi/nf-mmiscapi-mmioopena
    [LibraryImport("WINMM")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial HMMIO mmioOpenA([MarshalUsing(ConstantElementCount = 128)] PSTR pszFileName, nint /* optional MMIOINFO* */ pmmioinfo, uint fdwOpen);
    
    // https://learn.microsoft.com/windows/win32/api/mmiscapi/nf-mmiscapi-mmioopenw
    [LibraryImport("WINMM", StringMarshalling = StringMarshalling.Utf16)]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial HMMIO mmioOpenW([MarshalUsing(ConstantElementCount = 128)] PWSTR pszFileName, nint /* optional MMIOINFO* */ pmmioinfo, uint fdwOpen);
    
    // https://learn.microsoft.com/windows/win32/api/mmiscapi/nf-mmiscapi-mmioread
    [LibraryImport("WINMM")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    public static partial int mmioRead(HMMIO hmmio, nint pch, int cch);
    
    // https://learn.microsoft.com/windows/win32/api/mmiscapi/nf-mmiscapi-mmiorenamea
    [LibraryImport("WINMM")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    public static partial uint mmioRenameA(PSTR pszFileName, PSTR pszNewFileName, nint /* optional MMIOINFO* */ pmmioinfo, uint fdwRename);
    
    // https://learn.microsoft.com/windows/win32/api/mmiscapi/nf-mmiscapi-mmiorenamew
    [LibraryImport("WINMM", StringMarshalling = StringMarshalling.Utf16)]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    public static partial uint mmioRenameW(PWSTR pszFileName, PWSTR pszNewFileName, nint /* optional MMIOINFO* */ pmmioinfo, uint fdwRename);
    
    // https://learn.microsoft.com/windows/win32/api/mmiscapi/nf-mmiscapi-mmioseek
    [LibraryImport("WINMM")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    public static partial int mmioSeek(HMMIO hmmio, int lOffset, int iOrigin);
    
    // https://learn.microsoft.com/windows/win32/api/mmiscapi/nf-mmiscapi-mmiosendmessage
    [LibraryImport("WINMM")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial LRESULT mmioSendMessage(HMMIO hmmio, uint uMsg, LPARAM lParam1, LPARAM lParam2);
    
    // https://learn.microsoft.com/windows/win32/api/mmiscapi/nf-mmiscapi-mmiosetbuffer
    [LibraryImport("WINMM")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    public static partial uint mmioSetBuffer(HMMIO hmmio, [MarshalUsing(CountElementName = nameof(cchBuffer))] PSTR pchBuffer, int cchBuffer, uint fuBuffer);
    
    // https://learn.microsoft.com/windows/win32/api/mmiscapi/nf-mmiscapi-mmiosetinfo
    [LibraryImport("WINMM")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    public static partial uint mmioSetInfo(HMMIO hmmio, in MMIOINFO pmmioinfo, uint fuInfo);
    
    // https://learn.microsoft.com/windows/win32/api/mmiscapi/nf-mmiscapi-mmiostringtofourcca
    [LibraryImport("WINMM")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    public static partial uint mmioStringToFOURCCA(PSTR sz, uint uFlags);
    
    // https://learn.microsoft.com/windows/win32/api/mmiscapi/nf-mmiscapi-mmiostringtofourccw
    [LibraryImport("WINMM", StringMarshalling = StringMarshalling.Utf16)]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    public static partial uint mmioStringToFOURCCW(PWSTR sz, uint uFlags);
    
    // https://learn.microsoft.com/windows/win32/api/mmiscapi/nf-mmiscapi-mmiowrite
    [LibraryImport("WINMM")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    public static partial int mmioWrite(HMMIO hmmio, PSTR pch, int cch);
    
    // https://learn.microsoft.com/windows/win32/api/mmddk/nf-mmddk-mmtaskblock
    [LibraryImport("WINMM")]
    [PreserveSig]
    public static partial void mmTaskBlock(uint h);
    
    // https://learn.microsoft.com/windows/win32/api/mmddk/nf-mmddk-mmtaskcreate
    [LibraryImport("WINMM")]
    [PreserveSig]
    public static partial uint mmTaskCreate(LPTASKCALLBACK lpfn, ref HANDLE lph, nuint dwInst);
    
    // https://learn.microsoft.com/windows/win32/api/mmddk/nf-mmddk-mmtasksignal
    [LibraryImport("WINMM", SetLastError = true)]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial BOOL mmTaskSignal(uint h);
    
    // https://learn.microsoft.com/windows/win32/api/mmddk/nf-mmddk-mmtaskyield
    [LibraryImport("WINMM")]
    [PreserveSig]
    public static partial void mmTaskYield();
    
    // https://learn.microsoft.com/windows/win32/api/dmort/nf-dmort-mocopymediatype
    [LibraryImport("msdmo")]
    [PreserveSig]
    public static partial HRESULT MoCopyMediaType(ref DMO_MEDIA_TYPE pmtDest, in DMO_MEDIA_TYPE pmtSrc);
    
    // https://learn.microsoft.com/windows/win32/api/dmort/nf-dmort-mocreatemediatype
    [LibraryImport("msdmo")]
    [PreserveSig]
    public static partial HRESULT MoCreateMediaType(ref DMO_MEDIA_TYPE ppmt, uint cbFormat);
    
    // https://learn.microsoft.com/windows/win32/api/dmort/nf-dmort-modeletemediatype
    [LibraryImport("msdmo")]
    [PreserveSig]
    public static partial HRESULT MoDeleteMediaType(ref DMO_MEDIA_TYPE pmt);
    
    // https://learn.microsoft.com/windows/win32/api/dmort/nf-dmort-moduplicatemediatype
    [LibraryImport("msdmo")]
    [PreserveSig]
    public static partial HRESULT MoDuplicateMediaType(ref DMO_MEDIA_TYPE ppmtDest, in DMO_MEDIA_TYPE pmtSrc);
    
    // https://learn.microsoft.com/windows/win32/api/dmort/nf-dmort-mofreemediatype
    [LibraryImport("msdmo")]
    [PreserveSig]
    public static partial HRESULT MoFreeMediaType(ref DMO_MEDIA_TYPE pmt);
    
    // https://learn.microsoft.com/windows/win32/api/dmort/nf-dmort-moinitmediatype
    [LibraryImport("msdmo")]
    [PreserveSig]
    public static partial HRESULT MoInitMediaType(ref DMO_MEDIA_TYPE pmt, uint cbFormat);
    
    // https://learn.microsoft.com/windows/win32/api/winuser/nf-winuser-monitorfrompoint
    [LibraryImport("USER32")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial HMONITOR MonitorFromPoint(POINT pt, MONITOR_FROM_FLAGS dwFlags);
    
    // https://learn.microsoft.com/windows/win32/api/winuser/nf-winuser-monitorfromrect
    [LibraryImport("USER32")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial HMONITOR MonitorFromRect(in RECT lprc, MONITOR_FROM_FLAGS dwFlags);
    
    // https://learn.microsoft.com/windows/win32/api/winuser/nf-winuser-monitorfromwindow
    [LibraryImport("USER32")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial HMONITOR MonitorFromWindow(HWND hwnd, MONITOR_FROM_FLAGS dwFlags);
    
    // https://learn.microsoft.com/windows/win32/api/winuser/nf-winuser-msgwaitformultipleobjects
    [LibraryImport("USER32", SetLastError = true)]
    [SupportedOSPlatform("windows5.1.2600")]
    [PreserveSig]
    public static partial WAIT_EVENT MsgWaitForMultipleObjects(uint nCount, nint /* optional HANDLE* */ pHandles, BOOL fWaitAll, uint dwMilliseconds, QUEUE_STATUS_FLAGS dwWakeMask);
    
    // https://learn.microsoft.com/windows/win32/api/winuser/nf-winuser-msgwaitformultipleobjectsex
    [LibraryImport("USER32", SetLastError = true)]
    [SupportedOSPlatform("windows5.1.2600")]
    [PreserveSig]
    public static partial WAIT_EVENT MsgWaitForMultipleObjectsEx(uint nCount, nint /* optional HANDLE* */ pHandles, uint dwMilliseconds, QUEUE_STATUS_FLAGS dwWakeMask, MSG_WAIT_FOR_MULTIPLE_OBJECTS_EX_FLAGS dwFlags);
    
    // https://learn.microsoft.com/windows/win32/api/winuser/nf-winuser-notifywinevent
    [LibraryImport("USER32")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    public static partial void NotifyWinEvent(uint @event, HWND hwnd, int idObject, int idChild);
    
    // https://learn.microsoft.com/windows/win32/api/oleauto/nf-oleauto-oaenableperusertlibregistration
    [LibraryImport("OLEAUT32")]
    [PreserveSig]
    public static partial void OaEnablePerUserTLibRegistration();
    
    // https://learn.microsoft.com/windows/win32/api/winuser/nf-winuser-offsetrect
    [LibraryImport("USER32", SetLastError = true)]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial BOOL OffsetRect(ref RECT lprc, int dx, int dy);
    
    // https://learn.microsoft.com/windows/win32/api/wingdi/nf-wingdi-offsetrgn
    [LibraryImport("GDI32")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    public static partial GDI_REGION_TYPE OffsetRgn(HRGN hrgn, int x, int y);
    
    // https://learn.microsoft.com/windows/win32/api/ole2/nf-ole2-olecreatedefaulthandler
    [LibraryImport("ole32")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    public static partial HRESULT OleCreateDefaultHandler(in Guid clsid, nint pUnkOuter, in Guid riid, out nint lplpObj);
    
    // https://learn.microsoft.com/windows/win32/api/olectl/nf-olectl-olecreatepropertyframe
    [LibraryImport("OLEAUT32")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    public static partial HRESULT OleCreatePropertyFrame(HWND hwndOwner, uint x, uint y, PWSTR lpszCaption, uint cObjects, nint ppUnk, uint cPages, in Guid pPageClsID, uint lcid, uint dwReserved, nint pvReserved);
    
    // https://learn.microsoft.com/windows/win32/api/olectl/nf-olectl-olecreatepropertyframeindirect
    [LibraryImport("OLEAUT32")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    public static partial HRESULT OleCreatePropertyFrameIndirect(in OCPFIPARAMS lpParams);
    
    // https://learn.microsoft.com/windows/win32/api/ole2/nf-ole2-oleflushclipboard
    [LibraryImport("OLE32")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    public static partial HRESULT OleFlushClipboard();
    
    // https://learn.microsoft.com/windows/win32/api/ole2/nf-ole2-olegetclipboard
    [LibraryImport("OLE32")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    public static partial HRESULT OleGetClipboard([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDataObject>))] out IDataObject ppDataObj);
    
    // https://learn.microsoft.com/windows/win32/api/ole2/nf-ole2-oleinitialize
    [LibraryImport("OLE32")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    public static partial HRESULT OleInitialize(nint pvReserved);
    
    // https://learn.microsoft.com/windows/win32/api/ole2/nf-ole2-oleiscurrentclipboard
    [LibraryImport("OLE32")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    public static partial HRESULT OleIsCurrentClipboard([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDataObject>))] IDataObject pDataObj);
    
    // https://learn.microsoft.com/windows/win32/api/olectl/nf-olectl-oleloadpicturepath
    [LibraryImport("OLEAUT32")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    public static partial HRESULT OleLoadPicturePath(PWSTR szURLorPath, nint punkCaller, uint dwReserved, uint clrReserved, in Guid riid, out nint ppvRet);
    
    // https://learn.microsoft.com/windows/win32/api/ole2/nf-ole2-oleregenumformatetc
    [LibraryImport("ole32")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    public static partial HRESULT OleRegEnumFormatEtc(in Guid clsid, uint dwDirection, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IEnumFORMATETC>))] out IEnumFORMATETC ppenum);
    
    // https://learn.microsoft.com/windows/win32/api/ole2/nf-ole2-oleregenumverbs
    [LibraryImport("OLE32")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    public static partial HRESULT OleRegEnumVerbs(in Guid clsid, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IEnumOLEVERB>))] out IEnumOLEVERB ppenum);
    
    // https://learn.microsoft.com/windows/win32/api/ole2/nf-ole2-olereggetmiscstatus
    [LibraryImport("OLE32")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    public static partial HRESULT OleRegGetMiscStatus(in Guid clsid, uint dwAspect, out uint pdwStatus);
    
    // https://learn.microsoft.com/windows/win32/api/ole2/nf-ole2-olereggetusertype
    [LibraryImport("OLE32")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    public static partial HRESULT OleRegGetUserType(in Guid clsid, uint dwFormOfType, out PWSTR pszUserType);
    
    // https://learn.microsoft.com/windows/win32/api/ole2/nf-ole2-olesetclipboard
    [LibraryImport("OLE32")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    public static partial HRESULT OleSetClipboard([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDataObject>))] IDataObject pDataObj);
    
    // https://learn.microsoft.com/windows/win32/api/olectl/nf-olectl-oletranslatecolor
    [LibraryImport("OLEAUT32")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    public static partial HRESULT OleTranslateColor(uint clr, HPALETTE hpal, out COLORREF lpcolorref);
    
    // https://learn.microsoft.com/windows/win32/api/ole2/nf-ole2-oleuninitialize
    [LibraryImport("OLE32")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    public static partial void OleUninitialize();
    
    // https://learn.microsoft.com/windows/win32/api/winuser/nf-winuser-openclipboard
    [LibraryImport("USER32", SetLastError = true)]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial BOOL OpenClipboard(HWND hWndNewOwner);
    
    // https://learn.microsoft.com/windows/win32/api/icm/nf-icm-opencolorprofilea
    [LibraryImport("mscms", SetLastError = true)]
    [PreserveSig]
    public static partial nint OpenColorProfileA(in PROFILE pProfile, uint dwDesiredAccess, uint dwShareMode, uint dwCreationMode);
    
    // https://learn.microsoft.com/windows/win32/api/icm/nf-icm-opencolorprofilew
    [LibraryImport("mscms", StringMarshalling = StringMarshalling.Utf16, SetLastError = true)]
    [PreserveSig]
    public static partial nint OpenColorProfileW(in PROFILE pProfile, uint dwDesiredAccess, uint dwShareMode, uint dwCreationMode);
    
    // https://learn.microsoft.com/windows/win32/api/mmiscapi/nf-mmiscapi-opendriver
    [LibraryImport("WINMM")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial HDRVR OpenDriver(PWSTR szDriverName, PWSTR szSectionName, LPARAM lParam2);
    
    // https://learn.microsoft.com/windows/win32/api/processthreadsapi/nf-processthreadsapi-openprocess
    [LibraryImport("KERNEL32", SetLastError = true)]
    [SupportedOSPlatform("windows5.1.2600")]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial HANDLE OpenProcess(PROCESS_ACCESS_RIGHTS dwDesiredAccess, BOOL bInheritHandle, uint dwProcessId);
    
    // https://learn.microsoft.com/windows/win32/api/processthreadsapi/nf-processthreadsapi-openprocesstoken
    [LibraryImport("ADVAPI32", SetLastError = true)]
    [SupportedOSPlatform("windows5.1.2600")]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial BOOL OpenProcessToken(HANDLE ProcessHandle, TOKEN_ACCESS_MASK DesiredAccess, out HANDLE TokenHandle);
    
    // https://learn.microsoft.com/windows/win32/api/uxtheme/nf-uxtheme-openthemedata
    [LibraryImport("UXTHEME", SetLastError = true)]
    [SupportedOSPlatform("windows6.0.6000")]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial HTHEME OpenThemeData(HWND hwnd, PWSTR pszClassList);
    
    // https://learn.microsoft.com/windows/win32/api/uxtheme/nf-uxtheme-openthemedatafordpi
    [LibraryImport("UxTheme", SetLastError = true)]
    [SupportedOSPlatform("windows10.0.15063")]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial HTHEME OpenThemeDataForDpi(HWND hwnd, PWSTR pszClassList, uint dpi);
    
    // https://learn.microsoft.com/windows/win32/api/opmapi/nf-opmapi-opmgetvideooutputfortarget
    [LibraryImport("dxva2")]
    [SupportedOSPlatform("windows6.0.6000")]
    [PreserveSig]
    public static partial HRESULT OPMGetVideoOutputForTarget(in LUID pAdapterLuid, uint VidPnTarget, OPM_VIDEO_OUTPUT_SEMANTICS vos, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IOPMVideoOutput>))] out IOPMVideoOutput ppOPMVideoOutput);
    
    // https://learn.microsoft.com/windows/win32/api/opmapi/nf-opmapi-opmgetvideooutputsfromhmonitor
    [LibraryImport("dxva2")]
    [SupportedOSPlatform("windows6.0.6000")]
    [PreserveSig]
    public static partial HRESULT OPMGetVideoOutputsFromHMONITOR(HMONITOR hMonitor, OPM_VIDEO_OUTPUT_SEMANTICS vos, out uint pulNumVideoOutputs, out nint pppOPMVideoOutputArray);
    
    // https://learn.microsoft.com/windows/win32/api/opmapi/nf-opmapi-opmgetvideooutputsfromidirect3ddevice9object
    [LibraryImport("dxva2")]
    [SupportedOSPlatform("windows6.0.6000")]
    [PreserveSig]
    public static partial HRESULT OPMGetVideoOutputsFromIDirect3DDevice9Object([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDirect3DDevice9>))] IDirect3DDevice9 pDirect3DDevice9, OPM_VIDEO_OUTPUT_SEMANTICS vos, out uint pulNumVideoOutputs, out nint pppOPMVideoOutputArray);
    
    [LibraryImport("OPMXbox")]
    [PreserveSig]
    public static partial HRESULT OPMXboxEnableHDCP(OPM_HDCP_TYPE HDCPType);
    
    [LibraryImport("OPMXbox")]
    [PreserveSig]
    public static partial HRESULT OPMXboxGetHDCPStatus(ref OPM_HDCP_STATUS pHDCPStatus);
    
    [LibraryImport("OPMXbox")]
    [PreserveSig]
    public static partial HRESULT OPMXboxGetHDCPStatusAndType(ref OPM_HDCP_STATUS pHDCPStatus, ref OPM_HDCP_TYPE pHDCPType);
    
    // https://learn.microsoft.com/windows/win32/api/wingdi/nf-wingdi-paintrgn
    [LibraryImport("GDI32", SetLastError = true)]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial BOOL PaintRgn(HDC hdc, HRGN hrgn);
    
    // https://learn.microsoft.com/windows/win32/api/wingdi/nf-wingdi-patblt
    [LibraryImport("GDI32", SetLastError = true)]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial BOOL PatBlt(HDC hdc, int x, int y, int w, int h, ROP_CODE rop);
    
    // https://learn.microsoft.com/windows/win32/api/winddi/nf-winddi-pathobj_benum
    [LibraryImport("GDI32", SetLastError = true)]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial BOOL PATHOBJ_bEnum(ref PATHOBJ ppo, ref PATHDATA ppd);
    
    // https://learn.microsoft.com/windows/win32/api/winddi/nf-winddi-pathobj_benumcliplines
    [LibraryImport("GDI32", SetLastError = true)]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial BOOL PATHOBJ_bEnumClipLines(ref PATHOBJ ppo, uint cb, ref CLIPLINE pcl);
    
    // https://learn.microsoft.com/windows/win32/api/winddi/nf-winddi-pathobj_venumstart
    [LibraryImport("GDI32")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    public static partial void PATHOBJ_vEnumStart(ref PATHOBJ ppo);
    
    // https://learn.microsoft.com/windows/win32/api/winddi/nf-winddi-pathobj_venumstartcliplines
    [LibraryImport("GDI32")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    public static partial void PATHOBJ_vEnumStartClipLines(ref PATHOBJ ppo, ref CLIPOBJ pco, ref SURFOBJ pso, ref LINEATTRS pla);
    
    // https://learn.microsoft.com/windows/win32/api/winddi/nf-winddi-pathobj_vgetbounds
    [LibraryImport("GDI32")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    public static partial void PATHOBJ_vGetBounds(ref PATHOBJ ppo, ref RECTFX prectfx);
    
    // https://learn.microsoft.com/windows/win32/api/shlwapi/nf-shlwapi-pathparseiconlocationw
    [LibraryImport("SHLWAPI", StringMarshalling = StringMarshalling.Utf16)]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    public static partial int PathParseIconLocationW(PWSTR pszIconFile);
    
    // https://learn.microsoft.com/windows/win32/api/windows.data.pdf.interop/nf-windows-data-pdf-interop-pdfcreaterenderer
    [LibraryImport("Windows.Data.Pdf.dll")]
    [PreserveSig]
    public static partial HRESULT PdfCreateRenderer([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDXGIDevice>))] IDXGIDevice pDevice, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IPdfRendererNative>))] out IPdfRendererNative ppRenderer);
    
    // https://learn.microsoft.com/windows/win32/api/winuser/nf-winuser-peekmessagew
    [LibraryImport("USER32", StringMarshalling = StringMarshalling.Utf16, SetLastError = true)]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial BOOL PeekMessageW(out MSG lpMsg, HWND hWnd, uint wMsgFilterMin, uint wMsgFilterMax, PEEK_MESSAGE_REMOVE_TYPE wRemoveMsg);
    
    // https://learn.microsoft.com/windows/win32/api/winuser/nf-winuser-physicaltologicalpointforpermonitordpi
    [LibraryImport("USER32", SetLastError = true)]
    [SupportedOSPlatform("windows8.1")]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial BOOL PhysicalToLogicalPointForPerMonitorDPI(HWND hWnd, ref POINT lpPoint);
    
    // https://learn.microsoft.com/windows/win32/api/wingdi/nf-wingdi-pie
    [LibraryImport("GDI32", SetLastError = true)]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial BOOL Pie(HDC hdc, int left, int top, int right, int bottom, int xr1, int yr1, int xr2, int yr2);
    
    // https://learn.microsoft.com/windows/win32/api/wingdi/nf-wingdi-playenhmetafile
    [LibraryImport("GDI32", SetLastError = true)]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial BOOL PlayEnhMetaFile(HDC hdc, HENHMETAFILE hmf, in RECT lprect);
    
    // https://learn.microsoft.com/windows/win32/api/wingdi/nf-wingdi-playmetafile
    [LibraryImport("GDI32", SetLastError = true)]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial BOOL PlayMetaFile(HDC hdc, HMETAFILE hmf);
    
    [LibraryImport("WINMM", SetLastError = true)]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial BOOL PlaySoundA(PSTR pszSound, HMODULE hmod, SND_FLAGS fdwSound);
    
    [LibraryImport("WINMM", StringMarshalling = StringMarshalling.Utf16, SetLastError = true)]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial BOOL PlaySoundW(PWSTR pszSound, HMODULE hmod, SND_FLAGS fdwSound);
    
    // https://learn.microsoft.com/windows/win32/api/wingdi/nf-wingdi-polygon
    [LibraryImport("GDI32", SetLastError = true)]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial BOOL Polygon(HDC hdc, [In][MarshalUsing(CountElementName = nameof(cpt))] POINT[] apt, int cpt);
    
    // https://learn.microsoft.com/windows/win32/api/wingdi/nf-wingdi-polyline
    [LibraryImport("GDI32", SetLastError = true)]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial BOOL Polyline(HDC hdc, [In][MarshalUsing(CountElementName = nameof(cpt))] POINT[] apt, int cpt);
    
    // https://learn.microsoft.com/windows/win32/api/wingdi/nf-wingdi-polylineto
    [LibraryImport("GDI32", SetLastError = true)]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial BOOL PolylineTo(HDC hdc, [In][MarshalUsing(CountElementName = nameof(cpt))] POINT[] apt, uint cpt);
    
    // https://learn.microsoft.com/windows/win32/api/wingdi/nf-wingdi-polypolygon
    [LibraryImport("GDI32", SetLastError = true)]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial BOOL PolyPolygon(HDC hdc, in POINT apt, [In][MarshalUsing(CountElementName = nameof(csz))] int[] asz, int csz);
    
    // https://learn.microsoft.com/windows/win32/api/wingdi/nf-wingdi-polypolyline
    [LibraryImport("GDI32", SetLastError = true)]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial BOOL PolyPolyline(HDC hdc, in POINT apt, [In][MarshalUsing(CountElementName = nameof(csz))] uint[] asz, uint csz);
    
    // https://learn.microsoft.com/windows/win32/api/winuser/nf-winuser-postmessagew
    [LibraryImport("USER32", StringMarshalling = StringMarshalling.Utf16, SetLastError = true)]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial BOOL PostMessageW(HWND hWnd, uint Msg, WPARAM wParam, LPARAM lParam);
    
    // https://learn.microsoft.com/windows/win32/api/winuser/nf-winuser-postquitmessage
    [LibraryImport("USER32")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    public static partial void PostQuitMessage(int nExitCode);
    
    // https://learn.microsoft.com/windows/win32/api/winuser/nf-winuser-postthreadmessagew
    [LibraryImport("USER32", StringMarshalling = StringMarshalling.Utf16, SetLastError = true)]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial BOOL PostThreadMessageW(uint idThread, uint Msg, WPARAM wParam, LPARAM lParam);
    
    // https://learn.microsoft.com/windows/win32/api/winuser/nf-winuser-printwindow
    [LibraryImport("USER32", SetLastError = true)]
    [SupportedOSPlatform("windows5.1.2600")]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial BOOL PrintWindow(HWND hwnd, HDC hdcBlt, PRINT_WINDOW_FLAGS nFlags);
    
    // https://learn.microsoft.com/windows/win32/api/processthreadsapi/nf-processthreadsapi-processidtosessionid
    [LibraryImport("KERNEL32", SetLastError = true)]
    [SupportedOSPlatform("windows6.0.6000")]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial BOOL ProcessIdToSessionId(uint dwProcessId, out uint pSessionId);
    
    // https://learn.microsoft.com/windows/win32/api/propvarutil/nf-propvarutil-propvariantchangetype
    [LibraryImport("PROPSYS")]
    [SupportedOSPlatform("windows5.1.2600")]
    [PreserveSig]
    public static partial HRESULT PropVariantChangeType(out PROPVARIANT ppropvarDest, in PROPVARIANT propvarSrc, PROPVAR_CHANGE_FLAGS flags, VARENUM vt);
    
    // https://learn.microsoft.com/windows/win32/api/combaseapi/nf-combaseapi-propvariantclear
    [LibraryImport("OLE32")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    public static partial HRESULT PropVariantClear(ref PROPVARIANT pvar);
    
    // https://learn.microsoft.com/windows/win32/api/combaseapi/nf-combaseapi-propvariantcopy
    [LibraryImport("OLE32")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    public static partial HRESULT PropVariantCopy(out PROPVARIANT pvarDest, in PROPVARIANT pvarSrc);
    
    // https://learn.microsoft.com/windows/win32/api/propvarutil/nf-propvarutil-propvarianttovariant
    [LibraryImport("PROPSYS")]
    [SupportedOSPlatform("windows6.0.6000")]
    [PreserveSig]
    public static partial HRESULT PropVariantToVariant(in PROPVARIANT pPropVar, out VARIANT pVar);
    
    // https://learn.microsoft.com/windows/win32/api/propsys/nf-propsys-propvarianttowinrtpropertyvalue
    [LibraryImport("PROPSYS")]
    [SupportedOSPlatform("windows8.0")]
    [PreserveSig]
    public static partial HRESULT PropVariantToWinRTPropertyValue(in PROPVARIANT propvar, in Guid riid, out nint /* void */ ppv);
    
    // https://learn.microsoft.com/windows/win32/api/propsys/nf-propsys-pscreatememorypropertystore
    [LibraryImport("PROPSYS")]
    [SupportedOSPlatform("windows5.1.2600")]
    [PreserveSig]
    public static partial HRESULT PSCreateMemoryPropertyStore(in Guid riid, out nint ppv);
    
    // https://learn.microsoft.com/windows/win32/api/propsys/nf-propsys-psenumeratepropertydescriptions
    [LibraryImport("PROPSYS")]
    [SupportedOSPlatform("windows5.1.2600")]
    [PreserveSig]
    public static partial HRESULT PSEnumeratePropertyDescriptions(PROPDESC_ENUMFILTER filterOn, in Guid riid, out nint ppv);
    
    // https://learn.microsoft.com/windows/win32/api/propsys/nf-propsys-psgetpropertydescription
    [LibraryImport("PROPSYS")]
    [SupportedOSPlatform("windows5.1.2600")]
    [PreserveSig]
    public static partial HRESULT PSGetPropertyDescription(in PROPERTYKEY propkey, in Guid riid, out nint ppv);
    
    // https://learn.microsoft.com/windows/win32/api/propsys/nf-propsys-psgetpropertydescriptionbyname
    [LibraryImport("PROPSYS")]
    [SupportedOSPlatform("windows5.1.2600")]
    [PreserveSig]
    public static partial HRESULT PSGetPropertyDescriptionByName(PWSTR pszCanonicalName, in Guid riid, out nint ppv);
    
    // https://learn.microsoft.com/windows/win32/api/propsys/nf-propsys-psgetpropertydescriptionlistfromstring
    [LibraryImport("PROPSYS")]
    [SupportedOSPlatform("windows5.1.2600")]
    [PreserveSig]
    public static partial HRESULT PSGetPropertyDescriptionListFromString(PWSTR pszPropList, in Guid riid, out nint ppv);
    
    // https://learn.microsoft.com/windows/win32/api/propsys/nf-propsys-pspropertykeyfromstring
    [LibraryImport("PROPSYS")]
    [SupportedOSPlatform("windows5.1.2600")]
    [PreserveSig]
    public static partial HRESULT PSPropertyKeyFromString(PWSTR pszString, out PROPERTYKEY pkey);
    
    // https://learn.microsoft.com/windows/win32/api/winuser/nf-winuser-ptinrect
    [LibraryImport("USER32", SetLastError = true)]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial BOOL PtInRect(in RECT lprc, POINT pt);
    
    // https://learn.microsoft.com/windows/win32/api/wingdi/nf-wingdi-ptinregion
    [LibraryImport("GDI32", SetLastError = true)]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial BOOL PtInRegion(HRGN hrgn, int x, int y);
    
    // https://learn.microsoft.com/windows/win32/api/winuser/nf-winuser-querydisplayconfig
    [LibraryImport("USER32")]
    [SupportedOSPlatform("windows6.1")]
    [PreserveSig]
    public static partial WIN32_ERROR QueryDisplayConfig(QUERY_DISPLAY_CONFIG_FLAGS flags, ref uint numPathArrayElements, [In][Out][MarshalUsing(CountElementName = nameof(numPathArrayElements))] DISPLAYCONFIG_PATH_INFO[] pathArray, ref uint numModeInfoArrayElements, [In][Out][MarshalUsing(CountElementName = nameof(numModeInfoArrayElements))] DISPLAYCONFIG_MODE_INFO[] modeInfoArray, nint /* optional DISPLAYCONFIG_TOPOLOGY_ID* */ currentTopologyId);
    
    // https://learn.microsoft.com/windows/win32/api/oleauto/nf-oleauto-querypathofregtypelib
    [LibraryImport("OLEAUT32")]
    [PreserveSig]
    public static partial HRESULT QueryPathOfRegTypeLib(in Guid guid, ushort wMaj, ushort wMin, uint lcid, out BSTR lpbstrPathName);
    
    // https://learn.microsoft.com/windows/win32/api/winuser/nf-winuser-realgetwindowclassw
    [LibraryImport("USER32", StringMarshalling = StringMarshalling.Utf16, SetLastError = true)]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    public static partial uint RealGetWindowClassW(HWND hwnd, [MarshalUsing(CountElementName = nameof(cchClassNameMax))] PWSTR ptszClassName, uint cchClassNameMax);
    
    // https://learn.microsoft.com/windows/win32/api/wingdi/nf-wingdi-rectangle
    [LibraryImport("GDI32", SetLastError = true)]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial BOOL Rectangle(HDC hdc, int left, int top, int right, int bottom);
    
    // https://learn.microsoft.com/windows/win32/api/wingdi/nf-wingdi-rectinregion
    [LibraryImport("GDI32", SetLastError = true)]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial BOOL RectInRegion(HRGN hrgn, in RECT lprect);
    
    // https://learn.microsoft.com/windows/win32/api/wingdi/nf-wingdi-rectvisible
    [LibraryImport("GDI32", SetLastError = true)]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial BOOL RectVisible(HDC hdc, in RECT lprect);
    
    // https://learn.microsoft.com/windows/win32/api/winuser/nf-winuser-redrawwindow
    [LibraryImport("USER32", SetLastError = true)]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial BOOL RedrawWindow(HWND hWnd, nint /* optional RECT* */ lprcUpdate, HRGN hrgnUpdate, REDRAW_WINDOW_FLAGS flags);
    
    // https://learn.microsoft.com/windows/win32/api/winuser/nf-winuser-registerclassw
    [LibraryImport("USER32", StringMarshalling = StringMarshalling.Utf16, SetLastError = true)]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    public static partial ushort RegisterClassW(in WNDCLASSW lpWndClass);
    
    // https://learn.microsoft.com/windows/win32/api/winuser/nf-winuser-registerclipboardformatw
    [LibraryImport("USER32", StringMarshalling = StringMarshalling.Utf16, SetLastError = true)]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    public static partial uint RegisterClipboardFormatW(PWSTR lpszFormat);
    
    // https://learn.microsoft.com/windows/win32/api/icm/nf-icm-registercmma
    [LibraryImport("mscms", SetLastError = true)]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial BOOL RegisterCMMA(PSTR pMachineName, uint cmmID, PSTR pCMMdll);
    
    // https://learn.microsoft.com/windows/win32/api/icm/nf-icm-registercmmw
    [LibraryImport("mscms", StringMarshalling = StringMarshalling.Utf16, SetLastError = true)]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial BOOL RegisterCMMW(PWSTR pMachineName, uint cmmID, PWSTR pCMMdll);
    
    // https://learn.microsoft.com/windows/win32/api/ole2/nf-ole2-registerdragdrop
    [LibraryImport("OLE32")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    public static partial HRESULT RegisterDragDrop(HWND hwnd, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDropTarget>))] IDropTarget pDropTarget);
    
    // https://learn.microsoft.com/windows/win32/api/winuser/nf-winuser-registerhotkey
    [LibraryImport("USER32", SetLastError = true)]
    [SupportedOSPlatform("windows6.0.6000")]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial BOOL RegisterHotKey(HWND hWnd, int id, HOT_KEY_MODIFIERS fsModifiers, uint vk);
    
    // https://learn.microsoft.com/windows/win32/api/oleauto/nf-oleauto-registertypelib
    [LibraryImport("OLEAUT32")]
    [PreserveSig]
    public static partial HRESULT RegisterTypeLib([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ITypeLib>))] ITypeLib ptlib, PWSTR szFullPath, PWSTR szHelpDir);
    
    // https://learn.microsoft.com/windows/win32/api/oleauto/nf-oleauto-registertypelibforuser
    [LibraryImport("OLEAUT32")]
    [PreserveSig]
    public static partial HRESULT RegisterTypeLibForUser([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ITypeLib>))] ITypeLib ptlib, PWSTR szFullPath, PWSTR szHelpDir);
    
    // https://learn.microsoft.com/windows/win32/api/winuser/nf-winuser-registerwindowmessagew
    [LibraryImport("USER32", StringMarshalling = StringMarshalling.Utf16, SetLastError = true)]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    public static partial uint RegisterWindowMessageW(PWSTR lpString);
    
    // https://learn.microsoft.com/windows/win32/api/winuser/nf-winuser-releasecapture
    [LibraryImport("USER32", SetLastError = true)]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial BOOL ReleaseCapture();
    
    // https://learn.microsoft.com/windows/win32/api/winuser/nf-winuser-releasedc
    [LibraryImport("USER32")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    public static partial int ReleaseDC(HWND hWnd, HDC hDC);
    
    // https://learn.microsoft.com/windows/win32/api/ole2/nf-ole2-releasestgmedium
    [LibraryImport("OLE32")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    public static partial void ReleaseStgMedium(ref STGMEDIUM param0);
    
    // https://learn.microsoft.com/windows/win32/api/winuser/nf-winuser-removeclipboardformatlistener
    [LibraryImport("USER32", SetLastError = true)]
    [SupportedOSPlatform("windows6.0.6000")]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial BOOL RemoveClipboardFormatListener(HWND hwnd);
    
    // https://learn.microsoft.com/windows/win32/api/libloaderapi/nf-libloaderapi-removedlldirectory
    [LibraryImport("KERNEL32", SetLastError = true)]
    [SupportedOSPlatform("windows8.0")]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial BOOL RemoveDllDirectory(nint Cookie);
    
    // https://learn.microsoft.com/windows/win32/api/winuser/nf-winuser-removepropw
    [LibraryImport("USER32", StringMarshalling = StringMarshalling.Utf16, SetLastError = true)]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial HANDLE RemovePropW(HWND hWnd, PWSTR lpString);
    
    // https://learn.microsoft.com/windows/win32/api/wingdi/nf-wingdi-restoredc
    [LibraryImport("GDI32", SetLastError = true)]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial BOOL RestoreDC(HDC hdc, int nSavedDC);
    
    // https://learn.microsoft.com/windows/win32/api/highlevelmonitorconfigurationapi/nf-highlevelmonitorconfigurationapi-restoremonitorfactorycolordefaults
    [LibraryImport("dxva2", SetLastError = true)]
    [SupportedOSPlatform("windows6.0.6000")]
    [PreserveSig]
    public static partial int RestoreMonitorFactoryColorDefaults(HANDLE hMonitor);
    
    // https://learn.microsoft.com/windows/win32/api/highlevelmonitorconfigurationapi/nf-highlevelmonitorconfigurationapi-restoremonitorfactorydefaults
    [LibraryImport("dxva2", SetLastError = true)]
    [SupportedOSPlatform("windows6.0.6000")]
    [PreserveSig]
    public static partial int RestoreMonitorFactoryDefaults(HANDLE hMonitor);
    
    // https://learn.microsoft.com/windows/win32/api/ole2/nf-ole2-revokedragdrop
    [LibraryImport("OLE32")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    public static partial HRESULT RevokeDragDrop(HWND hwnd);
    
    // https://learn.microsoft.com/windows/win32/api/roapi/nf-roapi-roactivateinstance
    [LibraryImport("api-ms-win-core-winrt-l1-1-0")]
    [SupportedOSPlatform("windows8.0")]
    [PreserveSig]
    public static partial HRESULT RoActivateInstance(HSTRING activatableClassId, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IInspectable>))] out IInspectable instance);
    
    // https://learn.microsoft.com/windows/win32/api/roerrorapi/nf-roerrorapi-rocaptureerrorcontext
    [LibraryImport("api-ms-win-core-winrt-error-l1-1-0")]
    [SupportedOSPlatform("windows8.0")]
    [PreserveSig]
    public static partial HRESULT RoCaptureErrorContext(HRESULT hr);
    
    // https://learn.microsoft.com/windows/win32/api/roerrorapi/nf-roerrorapi-roclearerror
    [LibraryImport("api-ms-win-core-winrt-error-l1-1-1")]
    [SupportedOSPlatform("windows8.1")]
    [PreserveSig]
    public static partial void RoClearError();
    
    // https://learn.microsoft.com/windows/win32/api/roerrorapi/nf-roerrorapi-rofailfastwitherrorcontext
    [LibraryImport("api-ms-win-core-winrt-error-l1-1-0")]
    [SupportedOSPlatform("windows8.0")]
    [PreserveSig]
    public static partial void RoFailFastWithErrorContext(HRESULT hrError);
    
    // https://learn.microsoft.com/windows/win32/api/roapi/nf-roapi-rogetactivationfactory
    [LibraryImport("api-ms-win-core-winrt-l1-1-0")]
    [SupportedOSPlatform("windows8.0")]
    [PreserveSig]
    public static partial HRESULT RoGetActivationFactory(HSTRING activatableClassId, in Guid iid, out nint /* void */ factory);
    
    // https://learn.microsoft.com/windows/win32/api/combaseapi/nf-combaseapi-rogetagilereference
    [LibraryImport("OLE32")]
    [SupportedOSPlatform("windows8.1")]
    [PreserveSig]
    public static partial HRESULT RoGetAgileReference(AgileReferenceOptions options, in Guid riid, nint pUnk, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IAgileReference>))] out IAgileReference ppAgileReference);
    
    // https://learn.microsoft.com/windows/win32/api/roapi/nf-roapi-rogetapartmentidentifier
    [LibraryImport("api-ms-win-core-winrt-l1-1-0")]
    [SupportedOSPlatform("windows8.0")]
    [PreserveSig]
    public static partial HRESULT RoGetApartmentIdentifier(out ulong apartmentIdentifier);
    
    // https://learn.microsoft.com/windows/win32/api/robuffer/nf-robuffer-rogetbuffermarshaler
    [LibraryImport("api-ms-win-core-winrt-robuffer-l1-1-0")]
    [SupportedOSPlatform("windows8.0")]
    [PreserveSig]
    public static partial HRESULT RoGetBufferMarshaler([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMarshal>))] out IMarshal bufferMarshaler);
    
    // https://learn.microsoft.com/windows/win32/api/roerrorapi/nf-roerrorapi-rogeterrorreportingflags
    [LibraryImport("api-ms-win-core-winrt-error-l1-1-0")]
    [SupportedOSPlatform("windows8.0")]
    [PreserveSig]
    public static partial HRESULT RoGetErrorReportingFlags(out uint pflags);
    
    // https://learn.microsoft.com/windows/win32/api/roerrorapi/nf-roerrorapi-rogetmatchingrestrictederrorinfo
    [LibraryImport("api-ms-win-core-winrt-error-l1-1-1")]
    [PreserveSig]
    public static partial HRESULT RoGetMatchingRestrictedErrorInfo(HRESULT hrIn, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IRestrictedErrorInfo>))] out IRestrictedErrorInfo ppRestrictedErrorInfo);
    
    // https://learn.microsoft.com/windows/win32/api/roregistrationapi/nf-roregistrationapi-rogetserveractivatableclasses
    [LibraryImport("api-ms-win-core-winrt-registration-l1-1-0")]
    [SupportedOSPlatform("windows8.0")]
    [PreserveSig]
    public static partial HRESULT RoGetServerActivatableClasses(HSTRING serverName, out nint activatableClassIds, out uint count);
    
    // https://learn.microsoft.com/windows/win32/api/roapi/nf-roapi-roinitialize
    [LibraryImport("api-ms-win-core-winrt-l1-1-0")]
    [SupportedOSPlatform("windows8.0")]
    [PreserveSig]
    public static partial HRESULT RoInitialize(RO_INIT_TYPE initType);
    
    // https://learn.microsoft.com/windows/win32/api/roerrorapi/nf-roerrorapi-roinspectcapturedstackbacktrace
    [LibraryImport("api-ms-win-core-winrt-error-l1-1-1")]
    [SupportedOSPlatform("windows8.1")]
    [PreserveSig]
    public static partial HRESULT RoInspectCapturedStackBackTrace(nuint targetErrorInfoAddress, ushort machine, PINSPECT_MEMORY_CALLBACK readMemoryCallback, nint /* optional void* */ context, out uint frameCount, out nuint targetBackTraceAddress);
    
    // https://learn.microsoft.com/windows/win32/api/roerrorapi/nf-roerrorapi-roinspectthreaderrorinfo
    [LibraryImport("api-ms-win-core-winrt-error-l1-1-1")]
    [SupportedOSPlatform("windows8.1")]
    [PreserveSig]
    public static partial HRESULT RoInspectThreadErrorInfo(nuint targetTebAddress, ushort machine, PINSPECT_MEMORY_CALLBACK readMemoryCallback, nint /* optional void* */ context, out nuint targetErrorInfoAddress);
    
    // https://learn.microsoft.com/windows/win32/api/roerrorapi/nf-roerrorapi-rooriginateerror
    [LibraryImport("api-ms-win-core-winrt-error-l1-1-0", SetLastError = true)]
    [SupportedOSPlatform("windows8.0")]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial BOOL RoOriginateError(HRESULT error, HSTRING message);
    
    // https://learn.microsoft.com/windows/win32/api/roerrorapi/nf-roerrorapi-rooriginateerrorw
    [LibraryImport("api-ms-win-core-winrt-error-l1-1-0", StringMarshalling = StringMarshalling.Utf16, SetLastError = true)]
    [SupportedOSPlatform("windows8.0")]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial BOOL RoOriginateErrorW(HRESULT error, uint cchMax, [MarshalUsing(ConstantElementCount = 512)] PWSTR message);
    
    // https://learn.microsoft.com/windows/win32/api/roerrorapi/nf-roerrorapi-rooriginatelanguageexception
    [LibraryImport("api-ms-win-core-winrt-error-l1-1-1", SetLastError = true)]
    [SupportedOSPlatform("windows8.1")]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial BOOL RoOriginateLanguageException(HRESULT error, HSTRING message, nint languageException);
    
    // https://learn.microsoft.com/windows/win32/api/roapi/nf-roapi-roregisteractivationfactories
    [LibraryImport("api-ms-win-core-winrt-l1-1-0")]
    [SupportedOSPlatform("windows8.0")]
    [PreserveSig]
    public static partial HRESULT RoRegisterActivationFactories([In][MarshalUsing(CountElementName = nameof(count))] HSTRING[] activatableClassIds, [In][MarshalUsing(CountElementName = nameof(count))] PFNGETACTIVATIONFACTORY[] activationFactoryCallbacks, uint count, out RO_REGISTRATION_COOKIE cookie);
    
    // https://learn.microsoft.com/windows/win32/api/roapi/nf-roapi-roregisterforapartmentshutdown
    [LibraryImport("api-ms-win-core-winrt-l1-1-0")]
    [SupportedOSPlatform("windows8.0")]
    [PreserveSig]
    public static partial HRESULT RoRegisterForApartmentShutdown([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IApartmentShutdown>))] IApartmentShutdown callbackObject, out ulong apartmentIdentifier, out APARTMENT_SHUTDOWN_REGISTRATION_COOKIE regCookie);
    
    // https://learn.microsoft.com/windows/win32/api/roerrorapi/nf-roerrorapi-roreportfaileddelegate
    [LibraryImport("api-ms-win-core-winrt-error-l1-1-1")]
    [PreserveSig]
    public static partial HRESULT RoReportFailedDelegate(nint punkDelegate, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IRestrictedErrorInfo>))] IRestrictedErrorInfo pRestrictedErrorInfo);
    
    // https://learn.microsoft.com/windows/win32/api/roerrorapi/nf-roerrorapi-roreportunhandlederror
    [LibraryImport("api-ms-win-core-winrt-error-l1-1-1")]
    [PreserveSig]
    public static partial HRESULT RoReportUnhandledError([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IRestrictedErrorInfo>))] IRestrictedErrorInfo pRestrictedErrorInfo);
    
    // https://learn.microsoft.com/windows/win32/api/roerrorapi/nf-roerrorapi-roresolverestrictederrorinforeference
    [LibraryImport("api-ms-win-core-winrt-error-l1-1-0")]
    [SupportedOSPlatform("windows8.0")]
    [PreserveSig]
    public static partial HRESULT RoResolveRestrictedErrorInfoReference(PWSTR reference, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IRestrictedErrorInfo>))] out IRestrictedErrorInfo ppRestrictedErrorInfo);
    
    // https://learn.microsoft.com/windows/win32/api/roapi/nf-roapi-rorevokeactivationfactories
    [LibraryImport("api-ms-win-core-winrt-l1-1-0")]
    [SupportedOSPlatform("windows8.0")]
    [PreserveSig]
    public static partial void RoRevokeActivationFactories(RO_REGISTRATION_COOKIE cookie);
    
    // https://learn.microsoft.com/windows/win32/api/roerrorapi/nf-roerrorapi-roseterrorreportingflags
    [LibraryImport("api-ms-win-core-winrt-error-l1-1-0")]
    [SupportedOSPlatform("windows8.0")]
    [PreserveSig]
    public static partial HRESULT RoSetErrorReportingFlags(uint flags);
    
    // https://learn.microsoft.com/windows/win32/api/roerrorapi/nf-roerrorapi-rotransformerror
    [LibraryImport("api-ms-win-core-winrt-error-l1-1-0", SetLastError = true)]
    [SupportedOSPlatform("windows8.0")]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial BOOL RoTransformError(HRESULT oldError, HRESULT newError, HSTRING message);
    
    // https://learn.microsoft.com/windows/win32/api/roerrorapi/nf-roerrorapi-rotransformerrorw
    [LibraryImport("api-ms-win-core-winrt-error-l1-1-0", StringMarshalling = StringMarshalling.Utf16, SetLastError = true)]
    [SupportedOSPlatform("windows8.0")]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial BOOL RoTransformErrorW(HRESULT oldError, HRESULT newError, uint cchMax, [MarshalUsing(ConstantElementCount = 512)] PWSTR message);
    
    // https://learn.microsoft.com/windows/win32/api/wingdi/nf-wingdi-roundrect
    [LibraryImport("GDI32", SetLastError = true)]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial BOOL RoundRect(HDC hdc, int left, int top, int right, int bottom, int width, int height);
    
    // https://learn.microsoft.com/windows/win32/api/roapi/nf-roapi-rouninitialize
    [LibraryImport("api-ms-win-core-winrt-l1-1-0")]
    [SupportedOSPlatform("windows8.0")]
    [PreserveSig]
    public static partial void RoUninitialize();
    
    // https://learn.microsoft.com/windows/win32/api/roapi/nf-roapi-rounregisterforapartmentshutdown
    [LibraryImport("api-ms-win-core-winrt-l1-1-0")]
    [SupportedOSPlatform("windows8.0")]
    [PreserveSig]
    public static partial HRESULT RoUnregisterForApartmentShutdown(APARTMENT_SHUTDOWN_REGISTRATION_COOKIE regCookie);
    
    // https://learn.microsoft.com/windows/win32/api/oleauto/nf-oleauto-safearrayaccessdata
    [LibraryImport("OLEAUT32")]
    [PreserveSig]
    public static partial HRESULT SafeArrayAccessData(in SAFEARRAY psa, out nint ppvData);
    
    // https://learn.microsoft.com/windows/win32/api/oleauto/nf-oleauto-safearraycreate
    [LibraryImport("OLEAUT32")]
    [PreserveSig]
    public static partial nint SafeArrayCreate(VARENUM vt, uint cDims, in SAFEARRAYBOUND rgsabound);
    
    // https://learn.microsoft.com/windows/win32/api/oleauto/nf-oleauto-safearraydestroy
    [LibraryImport("OLEAUT32")]
    [PreserveSig]
    public static partial HRESULT SafeArrayDestroy(in SAFEARRAY psa);
    
    // https://learn.microsoft.com/windows/win32/api/oleauto/nf-oleauto-safearraygetlbound
    [LibraryImport("OLEAUT32")]
    [PreserveSig]
    public static partial HRESULT SafeArrayGetLBound(in SAFEARRAY psa, uint nDim, out int plLbound);
    
    // https://learn.microsoft.com/windows/win32/api/oleauto/nf-oleauto-safearraygetubound
    [LibraryImport("OLEAUT32")]
    [PreserveSig]
    public static partial HRESULT SafeArrayGetUBound(in SAFEARRAY psa, uint nDim, out int plUbound);
    
    // https://learn.microsoft.com/windows/win32/api/oleauto/nf-oleauto-safearrayunaccessdata
    [LibraryImport("OLEAUT32")]
    [PreserveSig]
    public static partial HRESULT SafeArrayUnaccessData(in SAFEARRAY psa);
    
    // https://learn.microsoft.com/windows/win32/api/highlevelmonitorconfigurationapi/nf-highlevelmonitorconfigurationapi-savecurrentmonitorsettings
    [LibraryImport("dxva2", SetLastError = true)]
    [SupportedOSPlatform("windows6.0.6000")]
    [PreserveSig]
    public static partial int SaveCurrentMonitorSettings(HANDLE hMonitor);
    
    // https://learn.microsoft.com/windows/win32/api/lowlevelmonitorconfigurationapi/nf-lowlevelmonitorconfigurationapi-savecurrentsettings
    [LibraryImport("dxva2", SetLastError = true)]
    [SupportedOSPlatform("windows6.0.6000")]
    [PreserveSig]
    public static partial int SaveCurrentSettings(HANDLE hMonitor);
    
    // https://learn.microsoft.com/windows/win32/api/wingdi/nf-wingdi-savedc
    [LibraryImport("GDI32")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    public static partial int SaveDC(HDC hdc);
    
    // https://learn.microsoft.com/windows/win32/api/winuser/nf-winuser-screentoclient
    [LibraryImport("USER32", SetLastError = true)]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial BOOL ScreenToClient(HWND hWnd, ref POINT lpPoint);
    
    // https://learn.microsoft.com/windows/win32/api/wingdi/nf-wingdi-selectcliprgn
    [LibraryImport("GDI32")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    public static partial GDI_REGION_TYPE SelectClipRgn(HDC hdc, HRGN hrgn);
    
    // https://learn.microsoft.com/windows/win32/api/icm/nf-icm-selectcmm
    [LibraryImport("mscms", SetLastError = true)]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial BOOL SelectCMM(uint dwCMMType);
    
    // https://learn.microsoft.com/windows/win32/api/wingdi/nf-wingdi-selectobject
    [LibraryImport("GDI32")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial HGDIOBJ SelectObject(HDC hdc, HGDIOBJ h);
    
    // https://learn.microsoft.com/windows/win32/api/mmiscapi/nf-mmiscapi-senddrivermessage
    [LibraryImport("WINMM")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial LRESULT SendDriverMessage(HDRVR hDriver, uint message, LPARAM lParam1, LPARAM lParam2);
    
    // https://learn.microsoft.com/windows/win32/api/winuser/nf-winuser-sendmessagew
    [LibraryImport("USER32", StringMarshalling = StringMarshalling.Utf16, SetLastError = true)]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial LRESULT SendMessageW(HWND hWnd, uint Msg, WPARAM wParam, LPARAM lParam);
    
    // https://learn.microsoft.com/windows/win32/api/wingdi/nf-wingdi-setabortproc
    [LibraryImport("GDI32")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    public static partial int SetAbortProc(HDC hdc, ABORTPROC proc);
    
    // https://learn.microsoft.com/windows/win32/api/winuser/nf-winuser-setactivewindow
    [LibraryImport("USER32", SetLastError = true)]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial HWND SetActiveWindow(HWND hWnd);
    
    // https://learn.microsoft.com/windows/win32/api/wingdi/nf-wingdi-setbkcolor
    [LibraryImport("GDI32")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial COLORREF SetBkColor(HDC hdc, COLORREF color);
    
    // https://learn.microsoft.com/windows/win32/api/winuser/nf-winuser-setcapture
    [LibraryImport("USER32")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial HWND SetCapture(HWND hWnd);
    
    // https://learn.microsoft.com/windows/win32/api/winuser/nf-winuser-setcaretpos
    [LibraryImport("USER32", SetLastError = true)]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial BOOL SetCaretPos(int X, int Y);
    
    // https://learn.microsoft.com/windows/win32/api/winuser/nf-winuser-setclasslongptrw
    [LibraryImport("USER32", StringMarshalling = StringMarshalling.Utf16, SetLastError = true)]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    public static partial nuint SetClassLongPtrW(HWND hWnd, GET_CLASS_LONG_INDEX nIndex, nint dwNewLong);
    
    // https://learn.microsoft.com/windows/win32/api/winuser/nf-winuser-setclasslongw
    [LibraryImport("USER32", StringMarshalling = StringMarshalling.Utf16, SetLastError = true)]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    public static partial uint SetClassLongW(HWND hWnd, GET_CLASS_LONG_INDEX nIndex, int dwNewLong);
    
    // https://learn.microsoft.com/windows/win32/api/winuser/nf-winuser-setclipboarddata
    [LibraryImport("USER32", SetLastError = true)]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial HANDLE SetClipboardData(uint uFormat, HANDLE hMem);
    
    // https://learn.microsoft.com/windows/win32/api/winuser/nf-winuser-setclipboardviewer
    [LibraryImport("USER32", SetLastError = true)]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial HWND SetClipboardViewer(HWND hWndNewViewer);
    
    // https://learn.microsoft.com/windows/win32/api/icm/nf-icm-setcolorprofileelement
    [LibraryImport("mscms", SetLastError = true)]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial BOOL SetColorProfileElement(nint hProfile, uint tag, uint dwOffset, in uint pcbElement, nint pElement);
    
    // https://learn.microsoft.com/windows/win32/api/icm/nf-icm-setcolorprofileelementreference
    [LibraryImport("mscms", SetLastError = true)]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial BOOL SetColorProfileElementReference(nint hProfile, uint newTag, uint refTag);
    
    // https://learn.microsoft.com/windows/win32/api/icm/nf-icm-setcolorprofileelementsize
    [LibraryImport("mscms", SetLastError = true)]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial BOOL SetColorProfileElementSize(nint hProfile, uint tagType, uint pcbElement);
    
    // https://learn.microsoft.com/windows/win32/api/icm/nf-icm-setcolorprofileheader
    [LibraryImport("mscms", SetLastError = true)]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial BOOL SetColorProfileHeader(nint hProfile, in PROFILEHEADER pHeader);
    
    // https://learn.microsoft.com/windows/win32/api/wingdi/nf-wingdi-setcolorspace
    [LibraryImport("GDI32")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial HCOLORSPACE SetColorSpace(HDC hdc, HCOLORSPACE hcs);
    
    // https://learn.microsoft.com/windows/win32/api/winuser/nf-winuser-setcursor
    [LibraryImport("USER32")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial HCURSOR SetCursor(HCURSOR hCursor);
    
    // https://learn.microsoft.com/windows/win32/api/wingdi/nf-wingdi-setdcbrushcolor
    [LibraryImport("GDI32")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial COLORREF SetDCBrushColor(HDC hdc, COLORREF color);
    
    // https://learn.microsoft.com/windows/win32/api/wingdi/nf-wingdi-setdcpencolor
    [LibraryImport("GDI32")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial COLORREF SetDCPenColor(HDC hdc, COLORREF color);
    
    // https://learn.microsoft.com/windows/win32/api/libloaderapi/nf-libloaderapi-setdefaultdlldirectories
    [LibraryImport("KERNEL32", SetLastError = true)]
    [SupportedOSPlatform("windows8.0")]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial BOOL SetDefaultDllDirectories(LOAD_LIBRARY_FLAGS DirectoryFlags);
    
    // https://learn.microsoft.com/windows/win32/api/wingdi/nf-wingdi-setdevicegammaramp
    [LibraryImport("GDI32", SetLastError = true)]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial BOOL SetDeviceGammaRamp(HDC hdc, nint lpRamp);
    
    // https://learn.microsoft.com/windows/win32/api/winuser/nf-winuser-setdialogcontroldpichangebehavior
    [LibraryImport("USER32", SetLastError = true)]
    [SupportedOSPlatform("windows10.0.15063")]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial BOOL SetDialogControlDpiChangeBehavior(HWND hWnd, DIALOG_CONTROL_DPI_CHANGE_BEHAVIORS mask, DIALOG_CONTROL_DPI_CHANGE_BEHAVIORS values);
    
    // https://learn.microsoft.com/windows/win32/api/winuser/nf-winuser-setdialogdpichangebehavior
    [LibraryImport("USER32", SetLastError = true)]
    [SupportedOSPlatform("windows10.0.15063")]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial BOOL SetDialogDpiChangeBehavior(HWND hDlg, DIALOG_DPI_CHANGE_BEHAVIORS mask, DIALOG_DPI_CHANGE_BEHAVIORS values);
    
    // https://learn.microsoft.com/windows/win32/api/winuser/nf-winuser-setdisplayautorotationpreferences
    [LibraryImport("USER32", SetLastError = true)]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial BOOL SetDisplayAutoRotationPreferences(ORIENTATION_PREFERENCE orientation);
    
    // https://learn.microsoft.com/windows/win32/api/winuser/nf-winuser-setdisplayconfig
    [LibraryImport("USER32")]
    [SupportedOSPlatform("windows6.1")]
    [PreserveSig]
    public static partial int SetDisplayConfig(uint numPathArrayElements, nint /* optional DISPLAYCONFIG_PATH_INFO* */ pathArray, uint numModeInfoArrayElements, nint /* optional DISPLAYCONFIG_MODE_INFO* */ modeInfoArray, SET_DISPLAY_CONFIG_FLAGS flags);
    
    // https://learn.microsoft.com/windows/win32/api/oleauto/nf-oleauto-seterrorinfo
    [LibraryImport("OLEAUT32")]
    [PreserveSig]
    public static partial HRESULT SetErrorInfo(uint dwReserved, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IErrorInfo?>))] IErrorInfo? perrinfo);
    
    // https://learn.microsoft.com/windows/win32/api/errhandlingapi/nf-errhandlingapi-seterrormode
    [LibraryImport("KERNEL32")]
    [SupportedOSPlatform("windows5.1.2600")]
    [PreserveSig]
    public static partial THREAD_ERROR_MODE SetErrorMode(THREAD_ERROR_MODE uMode);
    
    // https://learn.microsoft.com/windows/win32/api/winuser/nf-winuser-setfocus
    [LibraryImport("USER32", SetLastError = true)]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial HWND SetFocus(HWND hWnd);
    
    // https://learn.microsoft.com/windows/win32/api/winuser/nf-winuser-setforegroundwindow
    [LibraryImport("USER32", SetLastError = true)]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial BOOL SetForegroundWindow(HWND hWnd);
    
    // https://learn.microsoft.com/windows/win32/api/wingdi/nf-wingdi-seticmmode
    [LibraryImport("GDI32")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    public static partial int SetICMMode(HDC hdc, ICM_MODE mode);
    
    // https://learn.microsoft.com/windows/win32/api/wingdi/nf-wingdi-seticmprofilea
    [LibraryImport("GDI32", SetLastError = true)]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial BOOL SetICMProfileA(HDC hdc, PSTR lpFileName);
    
    // https://learn.microsoft.com/windows/win32/api/wingdi/nf-wingdi-seticmprofilew
    [LibraryImport("GDI32", StringMarshalling = StringMarshalling.Utf16, SetLastError = true)]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial BOOL SetICMProfileW(HDC hdc, PWSTR lpFileName);
    
    // https://learn.microsoft.com/windows/win32/api/winuser/nf-winuser-setlayeredwindowattributes
    [LibraryImport("USER32", SetLastError = true)]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial BOOL SetLayeredWindowAttributes(HWND hwnd, COLORREF crKey, byte bAlpha, LAYERED_WINDOW_ATTRIBUTES_FLAGS dwFlags);
    
    // https://learn.microsoft.com/windows/win32/api/wingdi/nf-wingdi-setmapmode
    [LibraryImport("GDI32")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    public static partial int SetMapMode(HDC hdc, HDC_MAP_MODE iMode);
    
    // https://learn.microsoft.com/windows/win32/api/highlevelmonitorconfigurationapi/nf-highlevelmonitorconfigurationapi-setmonitorbrightness
    [LibraryImport("dxva2", SetLastError = true)]
    [SupportedOSPlatform("windows6.0.6000")]
    [PreserveSig]
    public static partial int SetMonitorBrightness(HANDLE hMonitor, uint dwNewBrightness);
    
    // https://learn.microsoft.com/windows/win32/api/highlevelmonitorconfigurationapi/nf-highlevelmonitorconfigurationapi-setmonitorcolortemperature
    [LibraryImport("dxva2", SetLastError = true)]
    [SupportedOSPlatform("windows6.0.6000")]
    [PreserveSig]
    public static partial int SetMonitorColorTemperature(HANDLE hMonitor, MC_COLOR_TEMPERATURE ctCurrentColorTemperature);
    
    // https://learn.microsoft.com/windows/win32/api/highlevelmonitorconfigurationapi/nf-highlevelmonitorconfigurationapi-setmonitorcontrast
    [LibraryImport("dxva2", SetLastError = true)]
    [SupportedOSPlatform("windows6.0.6000")]
    [PreserveSig]
    public static partial int SetMonitorContrast(HANDLE hMonitor, uint dwNewContrast);
    
    // https://learn.microsoft.com/windows/win32/api/highlevelmonitorconfigurationapi/nf-highlevelmonitorconfigurationapi-setmonitordisplayareaposition
    [LibraryImport("dxva2", SetLastError = true)]
    [SupportedOSPlatform("windows6.0.6000")]
    [PreserveSig]
    public static partial int SetMonitorDisplayAreaPosition(HANDLE hMonitor, MC_POSITION_TYPE ptPositionType, uint dwNewPosition);
    
    // https://learn.microsoft.com/windows/win32/api/highlevelmonitorconfigurationapi/nf-highlevelmonitorconfigurationapi-setmonitordisplayareasize
    [LibraryImport("dxva2", SetLastError = true)]
    [SupportedOSPlatform("windows6.0.6000")]
    [PreserveSig]
    public static partial int SetMonitorDisplayAreaSize(HANDLE hMonitor, MC_SIZE_TYPE stSizeType, uint dwNewDisplayAreaWidthOrHeight);
    
    // https://learn.microsoft.com/windows/win32/api/highlevelmonitorconfigurationapi/nf-highlevelmonitorconfigurationapi-setmonitorredgreenorbluedrive
    [LibraryImport("dxva2")]
    [SupportedOSPlatform("windows6.0.6000")]
    [PreserveSig]
    public static partial int SetMonitorRedGreenOrBlueDrive(HANDLE hMonitor, MC_DRIVE_TYPE dtDriveType, uint dwNewDrive);
    
    // https://learn.microsoft.com/windows/win32/api/highlevelmonitorconfigurationapi/nf-highlevelmonitorconfigurationapi-setmonitorredgreenorbluegain
    [LibraryImport("dxva2")]
    [SupportedOSPlatform("windows6.0.6000")]
    [PreserveSig]
    public static partial int SetMonitorRedGreenOrBlueGain(HANDLE hMonitor, MC_GAIN_TYPE gtGainType, uint dwNewGain);
    
    // https://learn.microsoft.com/windows/win32/api/winuser/nf-winuser-setparent
    [LibraryImport("USER32", SetLastError = true)]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial HWND SetParent(HWND hWndChild, HWND hWndNewParent);
    
    // https://learn.microsoft.com/windows/win32/api/wingdi/nf-wingdi-setpixel
    [LibraryImport("GDI32")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial COLORREF SetPixel(HDC hdc, int x, int y, COLORREF color);
    
    // https://learn.microsoft.com/windows/win32/api/wingdi/nf-wingdi-setpixelformat
    [LibraryImport("GDI32", SetLastError = true)]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial BOOL SetPixelFormat(HDC hdc, int format, in PIXELFORMATDESCRIPTOR ppfd);
    
    // https://learn.microsoft.com/windows/win32/api/wingdi/nf-wingdi-setpolyfillmode
    [LibraryImport("GDI32")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    public static partial int SetPolyFillMode(HDC hdc, CREATE_POLYGON_RGN_MODE mode);
    
    // https://learn.microsoft.com/windows/win32/api/shellscalingapi/nf-shellscalingapi-setprocessdpiawareness
    [LibraryImport("api-ms-win-shcore-scaling-l1-1-1")]
    [SupportedOSPlatform("windows8.1")]
    [PreserveSig]
    public static partial HRESULT SetProcessDpiAwareness(PROCESS_DPI_AWARENESS value);
    
    // https://learn.microsoft.com/windows/win32/api/winuser/nf-winuser-setprocessdpiawarenesscontext
    [LibraryImport("USER32", SetLastError = true)]
    [SupportedOSPlatform("windows10.0.15063")]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial BOOL SetProcessDpiAwarenessContext(DPI_AWARENESS_CONTEXT value);
    
    // https://learn.microsoft.com/windows/win32/api/winuser/nf-winuser-setpropw
    [LibraryImport("USER32", StringMarshalling = StringMarshalling.Utf16, SetLastError = true)]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial BOOL SetPropW(HWND hWnd, PWSTR lpString, HANDLE hData);
    
    // https://learn.microsoft.com/windows/win32/api/wingdi/nf-wingdi-setrectrgn
    [LibraryImport("GDI32", SetLastError = true)]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial BOOL SetRectRgn(HRGN hrgn, int left, int top, int right, int bottom);
    
    // https://learn.microsoft.com/windows/win32/api/roerrorapi/nf-roerrorapi-setrestrictederrorinfo
    [LibraryImport("api-ms-win-core-winrt-error-l1-1-0")]
    [SupportedOSPlatform("windows8.0")]
    [PreserveSig]
    public static partial HRESULT SetRestrictedErrorInfo([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IRestrictedErrorInfo?>))] IRestrictedErrorInfo? pRestrictedErrorInfo);
    
    // https://learn.microsoft.com/windows/win32/api/wingdi/nf-wingdi-setrop2
    [LibraryImport("GDI32")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    public static partial int SetROP2(HDC hdc, R2_MODE rop2);
    
    // https://learn.microsoft.com/windows/win32/api/icm/nf-icm-setstandardcolorspaceprofilea
    [LibraryImport("mscms", SetLastError = true)]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial BOOL SetStandardColorSpaceProfileA(PSTR pMachineName, uint dwProfileID, PSTR pProfilename);
    
    // https://learn.microsoft.com/windows/win32/api/icm/nf-icm-setstandardcolorspaceprofilew
    [LibraryImport("mscms", StringMarshalling = StringMarshalling.Utf16, SetLastError = true)]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial BOOL SetStandardColorSpaceProfileW(PWSTR pMachineName, uint dwProfileID, PWSTR pProfileName);
    
    // https://learn.microsoft.com/windows/win32/api/wingdi/nf-wingdi-settextalign
    [LibraryImport("GDI32")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    public static partial uint SetTextAlign(HDC hdc, TEXT_ALIGN_OPTIONS align);
    
    // https://learn.microsoft.com/windows/win32/api/wingdi/nf-wingdi-settextcolor
    [LibraryImport("GDI32")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial COLORREF SetTextColor(HDC hdc, COLORREF color);
    
    // https://learn.microsoft.com/windows/win32/api/winuser/nf-winuser-setthreaddpiawarenesscontext
    [LibraryImport("USER32")]
    [SupportedOSPlatform("windows10.0.14393")]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial DPI_AWARENESS_CONTEXT SetThreadDpiAwarenessContext(DPI_AWARENESS_CONTEXT dpiContext);
    
    // https://learn.microsoft.com/windows/win32/api/winuser/nf-winuser-setthreaddpihostingbehavior
    [LibraryImport("USER32")]
    [SupportedOSPlatform("windows10.0.17134")]
    [PreserveSig]
    public static partial DPI_HOSTING_BEHAVIOR SetThreadDpiHostingBehavior(DPI_HOSTING_BEHAVIOR value);
    
    // https://learn.microsoft.com/windows/win32/api/errhandlingapi/nf-errhandlingapi-setthreaderrormode
    [LibraryImport("KERNEL32", SetLastError = true)]
    [SupportedOSPlatform("windows6.1")]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial BOOL SetThreadErrorMode(THREAD_ERROR_MODE dwNewMode, nint /* optional THREAD_ERROR_MODE* */ lpOldMode);
    
    // https://learn.microsoft.com/windows/win32/api/winnls/nf-winnls-setthreaduilanguage
    [LibraryImport("KERNEL32", SetLastError = true)]
    [SupportedOSPlatform("windows5.1.2600")]
    [PreserveSig]
    public static partial ushort SetThreadUILanguage(ushort LangId);
    
    // https://learn.microsoft.com/windows/win32/api/winuser/nf-winuser-settimer
    [LibraryImport("USER32", SetLastError = true)]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    public static partial nuint SetTimer(HWND hWnd, nuint nIDEvent, uint uElapse, TIMERPROC? lpTimerFunc);
    
    // https://learn.microsoft.com/windows/win32/api/icm/nf-icm-setupcolormatchinga
    [LibraryImport("ICMUI", SetLastError = true)]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial BOOL SetupColorMatchingA(ref COLORMATCHSETUPA pcms);
    
    // https://learn.microsoft.com/windows/win32/api/icm/nf-icm-setupcolormatchingw
    [LibraryImport("ICMUI", StringMarshalling = StringMarshalling.Utf16, SetLastError = true)]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial BOOL SetupColorMatchingW(ref COLORMATCHSETUPW pcms);
    
    // https://learn.microsoft.com/windows/win32/api/lowlevelmonitorconfigurationapi/nf-lowlevelmonitorconfigurationapi-setvcpfeature
    [LibraryImport("dxva2")]
    [SupportedOSPlatform("windows6.0.6000")]
    [PreserveSig]
    public static partial int SetVCPFeature(HANDLE hMonitor, byte bVCPCode, uint dwNewValue);
    
    // https://learn.microsoft.com/windows/win32/api/wingdi/nf-wingdi-setviewportextex
    [LibraryImport("GDI32", SetLastError = true)]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial BOOL SetViewportExtEx(HDC hdc, int x, int y, nint /* optional SIZE* */ lpsz);
    
    // https://learn.microsoft.com/windows/win32/api/wingdi/nf-wingdi-setviewportorgex
    [LibraryImport("GDI32", SetLastError = true)]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial BOOL SetViewportOrgEx(HDC hdc, int x, int y, nint /* optional POINT* */ lppt);
    
    // https://learn.microsoft.com/windows/win32/api/winuser/nf-winuser-setwindowdisplayaffinity
    [LibraryImport("USER32", SetLastError = true)]
    [SupportedOSPlatform("windows6.1")]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial BOOL SetWindowDisplayAffinity(HWND hWnd, WINDOW_DISPLAY_AFFINITY dwAffinity);
    
    // https://learn.microsoft.com/windows/win32/api/wingdi/nf-wingdi-setwindowextex
    [LibraryImport("GDI32", SetLastError = true)]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial BOOL SetWindowExtEx(HDC hdc, int x, int y, nint /* optional SIZE* */ lpsz);
    
    // https://learn.microsoft.com/windows/win32/api/winuser/nf-winuser-setwindowlongptrw
    [LibraryImport("USER32", StringMarshalling = StringMarshalling.Utf16, SetLastError = true)]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    public static partial nint SetWindowLongPtrW(HWND hWnd, WINDOW_LONG_PTR_INDEX nIndex, nint dwNewLong);
    
    // https://learn.microsoft.com/windows/win32/api/winuser/nf-winuser-setwindowlongw
    [LibraryImport("USER32", StringMarshalling = StringMarshalling.Utf16, SetLastError = true)]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    public static partial int SetWindowLongW(HWND hWnd, WINDOW_LONG_PTR_INDEX nIndex, int dwNewLong);
    
    // https://learn.microsoft.com/windows/win32/api/wingdi/nf-wingdi-setwindoworgex
    [LibraryImport("GDI32", SetLastError = true)]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial BOOL SetWindowOrgEx(HDC hdc, int x, int y, nint /* optional POINT* */ lppt);
    
    // https://learn.microsoft.com/windows/win32/api/winuser/nf-winuser-setwindowplacement
    [LibraryImport("USER32", SetLastError = true)]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial BOOL SetWindowPlacement(HWND hWnd, in WINDOWPLACEMENT lpwndpl);
    
    // https://learn.microsoft.com/windows/win32/api/winuser/nf-winuser-setwindowpos
    [LibraryImport("USER32", SetLastError = true)]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial BOOL SetWindowPos(HWND hWnd, HWND hWndInsertAfter, int X, int Y, int cx, int cy, SET_WINDOW_POS_FLAGS uFlags);
    
    // https://learn.microsoft.com/windows/win32/api/winuser/nf-winuser-setwindowrgn
    [LibraryImport("USER32")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    public static partial int SetWindowRgn(HWND hWnd, HRGN hRgn, BOOL bRedraw);
    
    // https://learn.microsoft.com/windows/win32/api/winuser/nf-winuser-setwindowtextw
    [LibraryImport("USER32", StringMarshalling = StringMarshalling.Utf16, SetLastError = true)]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial BOOL SetWindowTextW(HWND hWnd, PWSTR lpString);
    
    // https://learn.microsoft.com/windows/win32/api/uxtheme/nf-uxtheme-setwindowtheme
    [LibraryImport("UXTHEME")]
    [SupportedOSPlatform("windows6.0.6000")]
    [PreserveSig]
    public static partial HRESULT SetWindowTheme(HWND hwnd, PWSTR pszSubAppName, PWSTR pszSubIdList);
    
    // https://learn.microsoft.com/windows/win32/api/shlobj_core/nf-shlobj_core-shcreatedataobject
    [LibraryImport("SHELL32")]
    [SupportedOSPlatform("windows6.0.6000")]
    [PreserveSig]
    public static partial HRESULT SHCreateDataObject(nint /* optional ITEMIDLIST* */ pidlFolder, uint cidl, nint /* optional ITEMIDLIST** */ apidl, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDataObject?>))] IDataObject? pdtInner, in Guid riid, out nint /* void */ ppv);
    
    // https://learn.microsoft.com/windows/win32/api/shlwapi/nf-shlwapi-shcreatememstream
    [LibraryImport("SHLWAPI")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    [return: MarshalUsing(typeof(UniqueComInterfaceMarshaller<IStream>))]
    public static partial IStream SHCreateMemStream(nint /* optional byte* */ pInit, uint cbInit);
    
    // https://learn.microsoft.com/windows/win32/api/shlwapi/nf-shlwapi-shcreatestreamonfilew
    [LibraryImport("SHLWAPI", StringMarshalling = StringMarshalling.Utf16)]
    [SupportedOSPlatform("windows5.1.2600")]
    [PreserveSig]
    public static partial HRESULT SHCreateStreamOnFileW(PWSTR pszFile, uint grfMode, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IStream>))] out IStream ppstm);
    
    // https://learn.microsoft.com/windows/win32/api/shlobj_core/nf-shlobj_core-shdefextracticonw
    [LibraryImport("SHELL32", StringMarshalling = StringMarshalling.Utf16)]
    [SupportedOSPlatform("windows5.1.2600")]
    [PreserveSig]
    public static partial HRESULT SHDefExtractIconW(PWSTR pszIconFile, int iIndex, uint uFlags, nint /* optional HICON* */ phiconLarge, nint /* optional HICON* */ phiconSmall, uint nIconSize);
    
    // https://learn.microsoft.com/windows/win32/api/shlobj_core/nf-shlobj_core-shdodragdrop
    [LibraryImport("SHELL32")]
    [SupportedOSPlatform("windows5.1.2600")]
    [PreserveSig]
    public static partial HRESULT SHDoDragDrop(HWND hwnd, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDataObject>))] IDataObject pdata, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDropSource?>))] IDropSource? pdsrc, DROPEFFECT dwEffect, out DROPEFFECT pdwEffect);
    
    // https://learn.microsoft.com/windows/win32/api/shellapi/nf-shellapi-shell_notifyicongetrect
    [LibraryImport("SHELL32")]
    [SupportedOSPlatform("windows6.1")]
    [PreserveSig]
    public static partial HRESULT Shell_NotifyIconGetRect(in NOTIFYICONIDENTIFIER identifier, out RECT iconLocation);
    
    // https://learn.microsoft.com/windows/win32/api/shellapi/nf-shellapi-shell_notifyiconw
    [LibraryImport("SHELL32", StringMarshalling = StringMarshalling.Utf16, SetLastError = true)]
    [SupportedOSPlatform("windows5.1.2600")]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial BOOL Shell_NotifyIconW(NOTIFY_ICON_MESSAGE dwMessage, in NOTIFYICONDATAW lpData);
    
    // https://learn.microsoft.com/windows/win32/api/shellapi/nf-shellapi-shellaboutw
    [LibraryImport("SHELL32", StringMarshalling = StringMarshalling.Utf16)]
    [SupportedOSPlatform("windows5.1.2600")]
    [PreserveSig]
    public static partial int ShellAboutW(HWND hWnd, PWSTR szApp, PWSTR szOtherStuff, HICON hIcon);
    
    // https://learn.microsoft.com/windows/win32/api/shellapi/nf-shellapi-shgetpropertystoreforwindow
    [LibraryImport("SHELL32")]
    [SupportedOSPlatform("windows6.1")]
    [PreserveSig]
    public static partial HRESULT SHGetPropertyStoreForWindow(HWND hwnd, in Guid riid, out nint /* void */ ppv);
    
    // https://learn.microsoft.com/windows/win32/api/shlwapi/nf-shlwapi-shloadindirectstring
    [LibraryImport("SHLWAPI")]
    [SupportedOSPlatform("windows5.1.2600")]
    [PreserveSig]
    public static partial HRESULT SHLoadIndirectString(PWSTR pszSource, [MarshalUsing(CountElementName = nameof(cchOutBuf))] PWSTR pszOutBuf, uint cchOutBuf, nint /* optional void** */ ppvReserved);
    
    // https://learn.microsoft.com/windows/win32/api/winuser/nf-winuser-showwindow
    [LibraryImport("USER32", SetLastError = true)]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial BOOL ShowWindow(HWND hWnd, SHOW_WINDOW_CMD nCmdShow);
    
    // https://learn.microsoft.com/windows/win32/api/libloaderapi/nf-libloaderapi-sizeofresource
    [LibraryImport("KERNEL32", SetLastError = true)]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    public static partial uint SizeofResource(HMODULE hModule, HRSRC hResInfo);
    
    // https://learn.microsoft.com/windows/win32/api/winuser/nf-winuser-skippointerframemessages
    [LibraryImport("USER32", SetLastError = true)]
    [SupportedOSPlatform("windows8.0")]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial BOOL SkipPointerFrameMessages(uint pointerId);
    
    // https://learn.microsoft.com/windows/win32/api/mmiscapi/nf-mmiscapi-sndopensound
    [LibraryImport("api-ms-win-mm-misc-l1-1-1")]
    [SupportedOSPlatform("windows8.1")]
    [PreserveSig]
    public static partial int sndOpenSound(PWSTR EventName, PWSTR AppName, int Flags, out HANDLE FileHandle);
    
    [LibraryImport("WINMM", SetLastError = true)]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial BOOL sndPlaySoundA(PSTR pszSound, uint fuSound);
    
    [LibraryImport("WINMM", StringMarshalling = StringMarshalling.Utf16, SetLastError = true)]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial BOOL sndPlaySoundW(PWSTR pszSound, uint fuSound);
    
    // https://learn.microsoft.com/windows/win32/api/wingdi/nf-wingdi-startdoca
    [LibraryImport("GDI32")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    public static partial int StartDocA(HDC hdc, in DOCINFOA lpdi);
    
    // https://learn.microsoft.com/windows/win32/api/wingdi/nf-wingdi-startdocw
    [LibraryImport("GDI32", StringMarshalling = StringMarshalling.Utf16)]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    public static partial int StartDocW(HDC hdc, in DOCINFOW lpdi);
    
    // https://learn.microsoft.com/windows/win32/api/wingdi/nf-wingdi-startpage
    [LibraryImport("GDI32")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    public static partial int StartPage(HDC hdc);
    
    // https://learn.microsoft.com/windows/win32/api/xpsprint/nf-xpsprint-startxpsprintjob
    [LibraryImport("XPSPRINT")]
    [SupportedOSPlatform("windows6.1")]
    [PreserveSig]
    public static partial HRESULT StartXpsPrintJob(PWSTR printerName, PWSTR jobName, PWSTR outputFileName, HANDLE progressEvent, HANDLE completionEvent, nint /* byte array */ printablePagesOn, uint printablePagesOnCount, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IXpsPrintJob>))] out IXpsPrintJob xpsPrintJob, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IXpsPrintJobStream>))] out IXpsPrintJobStream documentStream, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IXpsPrintJobStream>))] out IXpsPrintJobStream printTicketStream);
    
    // https://learn.microsoft.com/windows/win32/api/xpsprint/nf-xpsprint-startxpsprintjob1
    [LibraryImport("XPSPRINT")]
    [SupportedOSPlatform("windows6.1")]
    [PreserveSig]
    public static partial HRESULT StartXpsPrintJob1(PWSTR printerName, PWSTR jobName, PWSTR outputFileName, HANDLE progressEvent, HANDLE completionEvent, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IXpsPrintJob>))] out IXpsPrintJob xpsPrintJob, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IXpsOMPackageTarget>))] out IXpsOMPackageTarget printContentReceiver);
    
    // https://learn.microsoft.com/windows/win32/api/propvarutil/nf-propvarutil-stgdeserializepropvariant
    [LibraryImport("PROPSYS")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    public static partial HRESULT StgDeserializePropVariant(in SERIALIZEDPROPERTYVALUE pprop, uint cbMax, out PROPVARIANT ppropvar);
    
    // https://learn.microsoft.com/windows/win32/api/propvarutil/nf-propvarutil-stgserializepropvariant
    [LibraryImport("PROPSYS")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    public static partial HRESULT StgSerializePropVariant(in PROPVARIANT ppropvar, out nint ppProp, out uint pcb);
    
    // https://learn.microsoft.com/windows/win32/api/shlwapi/nf-shlwapi-strformatbytesizew
    [LibraryImport("SHLWAPI", StringMarshalling = StringMarshalling.Utf16)]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial PWSTR StrFormatByteSizeW(long qdw, [MarshalUsing(CountElementName = nameof(cchBuf))] PWSTR pszBuf, uint cchBuf);
    
    // https://learn.microsoft.com/windows/win32/api/winddi/nf-winddi-strobj_benum
    [LibraryImport("GDI32", SetLastError = true)]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial BOOL STROBJ_bEnum(ref STROBJ pstro, ref uint pc, ref GLYPHPOS ppgpos);
    
    // https://learn.microsoft.com/windows/win32/api/winddi/nf-winddi-strobj_benumpositionsonly
    [LibraryImport("GDI32", SetLastError = true)]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial BOOL STROBJ_bEnumPositionsOnly(ref STROBJ pstro, ref uint pc, ref GLYPHPOS ppgpos);
    
    // https://learn.microsoft.com/windows/win32/api/winddi/nf-winddi-strobj_bgetadvancewidths
    [LibraryImport("GDI32", SetLastError = true)]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial BOOL STROBJ_bGetAdvanceWidths(ref STROBJ pso, uint iFirst, uint c, ref POINTQF pptqD);
    
    // https://learn.microsoft.com/windows/win32/api/winddi/nf-winddi-strobj_dwgetcodepage
    [LibraryImport("GDI32")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    public static partial uint STROBJ_dwGetCodePage(ref STROBJ pstro);
    
    // https://learn.microsoft.com/windows/win32/api/winddi/nf-winddi-strobj_venumstart
    [LibraryImport("GDI32")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    public static partial void STROBJ_vEnumStart(ref STROBJ pstro);
    
    // https://learn.microsoft.com/windows/win32/api/winuser/nf-winuser-subtractrect
    [LibraryImport("USER32", SetLastError = true)]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial BOOL SubtractRect(out RECT lprcDst, in RECT lprcSrc1, in RECT lprcSrc2);
    
    // https://learn.microsoft.com/windows/win32/api/wingdi/nf-wingdi-swapbuffers
    [LibraryImport("GDI32", SetLastError = true)]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial BOOL SwapBuffers(HDC param0);
    
    // https://learn.microsoft.com/windows/win32/api/winuser/nf-winuser-switchtothiswindow
    [LibraryImport("USER32")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    public static partial void SwitchToThisWindow(HWND hwnd, BOOL fUnknown);
    
    // https://learn.microsoft.com/windows/win32/api/winuser/nf-winuser-systemparametersinfofordpi
    [LibraryImport("USER32", SetLastError = true)]
    [SupportedOSPlatform("windows10.0.14393")]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial BOOL SystemParametersInfoForDpi(uint uiAction, uint uiParam, nint /* optional void* */ pvParam, uint fWinIni, uint dpi);
    
    // https://learn.microsoft.com/windows/win32/api/winuser/nf-winuser-systemparametersinfow
    [LibraryImport("USER32", StringMarshalling = StringMarshalling.Utf16, SetLastError = true)]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial BOOL SystemParametersInfoW(SYSTEM_PARAMETERS_INFO_ACTION uiAction, uint uiParam, nint /* optional void* */ pvParam, SYSTEM_PARAMETERS_INFO_UPDATE_FLAGS fWinIni);
    
    // https://learn.microsoft.com/windows/win32/api/commctrl/nf-commctrl-taskdialogindirect
    [LibraryImport("COMCTL32")]
    [SupportedOSPlatform("windows6.0.6000")]
    [PreserveSig]
    public static partial HRESULT TaskDialogIndirect(in TASKDIALOGCONFIG pTaskConfig, nint /* optional int* */ pnButton, nint /* optional int* */ pnRadioButton, nint /* optional BOOL* */ pfVerificationFlagChecked);
    
    // https://learn.microsoft.com/windows/win32/api/processthreadsapi/nf-processthreadsapi-terminatethread
    [LibraryImport("KERNEL32", SetLastError = true)]
    [SupportedOSPlatform("windows5.1.2600")]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial BOOL TerminateThread(HANDLE hThread, uint dwExitCode);
    
    // https://learn.microsoft.com/windows/win32/api/wingdi/nf-wingdi-textoutw
    [LibraryImport("GDI32", StringMarshalling = StringMarshalling.Utf16, SetLastError = true)]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial BOOL TextOutW(HDC hdc, int x, int y, [MarshalUsing(CountElementName = nameof(c))] PWSTR lpString, int c);
    
    // https://learn.microsoft.com/windows/win32/api/timeapi/nf-timeapi-timebeginperiod
    [LibraryImport("WINMM")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    public static partial uint timeBeginPeriod(uint uPeriod);
    
    // https://learn.microsoft.com/windows/win32/api/timeapi/nf-timeapi-timeendperiod
    [LibraryImport("WINMM")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    public static partial uint timeEndPeriod(uint uPeriod);
    
    // https://learn.microsoft.com/windows/win32/api/timeapi/nf-timeapi-timegetdevcaps
    [LibraryImport("WINMM")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    public static partial uint timeGetDevCaps(nint ptc, uint cbtc);
    
    // https://learn.microsoft.com/windows/win32/api/timeapi/nf-timeapi-timegetsystemtime
    [LibraryImport("WINMM")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    public static partial uint timeGetSystemTime(nint pmmt, uint cbmmt);
    
    // https://learn.microsoft.com/windows/win32/api/timeapi/nf-timeapi-timegettime
    [LibraryImport("WINMM")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    public static partial uint timeGetTime();
    
    [LibraryImport("WINMM")]
    [PreserveSig]
    public static partial uint timeKillEvent(uint uTimerID);
    
    [LibraryImport("WINMM")]
    [PreserveSig]
    public static partial uint timeSetEvent(uint uDelay, uint uResolution, LPTIMECALLBACK fptc, nuint dwUser, uint fuEvent);
    
    // https://learn.microsoft.com/windows/win32/api/winuser/nf-winuser-tounicode
    [LibraryImport("USER32")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    public static partial int ToUnicode(uint wVirtKey, uint wScanCode, nint /* optional byte* */ lpKeyState, [MarshalUsing(CountElementName = nameof(cchBuff))] PWSTR pwszBuff, int cchBuff, uint wFlags);
    
    // https://learn.microsoft.com/windows/win32/api/winuser/nf-winuser-tounicodeex
    [LibraryImport("USER32")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    public static partial int ToUnicodeEx(uint wVirtKey, uint wScanCode, nint /* byte array */ lpKeyState, [MarshalUsing(CountElementName = nameof(cchBuff))] PWSTR pwszBuff, int cchBuff, uint wFlags, HKL dwhkl);
    
    // https://learn.microsoft.com/windows/win32/api/winuser/nf-winuser-trackmouseevent
    [LibraryImport("USER32", SetLastError = true)]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial BOOL TrackMouseEvent(ref TRACKMOUSEEVENT lpEventTrack);
    
    // https://learn.microsoft.com/windows/win32/api/winuser/nf-winuser-translateacceleratorw
    [LibraryImport("USER32", StringMarshalling = StringMarshalling.Utf16, SetLastError = true)]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    public static partial int TranslateAcceleratorW(HWND hWnd, HACCEL hAccTable, in MSG lpMsg);
    
    // https://learn.microsoft.com/windows/win32/api/icm/nf-icm-translatebitmapbits
    [LibraryImport("mscms", SetLastError = true)]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial BOOL TranslateBitmapBits(nint hColorTransform, nint pSrcBits, BMFORMAT bmInput, uint dwWidth, uint dwHeight, uint dwInputStride, nint pDestBits, BMFORMAT bmOutput, uint dwOutputStride, LPBMCALLBACKFN? pfnCallBack, LPARAM ulCallbackData);
    
    // https://learn.microsoft.com/windows/win32/api/icm/nf-icm-translatecolors
    [LibraryImport("mscms", SetLastError = true)]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial BOOL TranslateColors(nint hColorTransform, [In][MarshalUsing(CountElementName = nameof(nColors))] COLOR[] paInputColors, uint nColors, COLORTYPE ctInput, [In][Out][MarshalUsing(CountElementName = nameof(nColors))] COLOR[] paOutputColors, COLORTYPE ctOutput);
    
    // https://learn.microsoft.com/windows/win32/api/winuser/nf-winuser-translatemessage
    [LibraryImport("USER32", SetLastError = true)]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial BOOL TranslateMessage(in MSG lpMsg);
    
    // https://learn.microsoft.com/windows/win32/api/icm/nf-icm-uninstallcolorprofilea
    [LibraryImport("mscms", SetLastError = true)]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial BOOL UninstallColorProfileA(PSTR pMachineName, PSTR pProfileName, BOOL bDelete);
    
    // https://learn.microsoft.com/windows/win32/api/icm/nf-icm-uninstallcolorprofilew
    [LibraryImport("mscms", StringMarshalling = StringMarshalling.Utf16, SetLastError = true)]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial BOOL UninstallColorProfileW(PWSTR pMachineName, PWSTR pProfileName, BOOL bDelete);
    
    // https://learn.microsoft.com/windows/win32/api/winuser/nf-winuser-unionrect
    [LibraryImport("USER32", SetLastError = true)]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial BOOL UnionRect(out RECT lprcDst, in RECT lprcSrc1, in RECT lprcSrc2);
    
    // https://learn.microsoft.com/windows/win32/api/winuser/nf-winuser-unregisterclassw
    [LibraryImport("USER32", StringMarshalling = StringMarshalling.Utf16, SetLastError = true)]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial BOOL UnregisterClassW(PWSTR lpClassName, HINSTANCE hInstance);
    
    // https://learn.microsoft.com/windows/win32/api/icm/nf-icm-unregistercmma
    [LibraryImport("mscms", SetLastError = true)]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial BOOL UnregisterCMMA(PSTR pMachineName, uint cmmID);
    
    // https://learn.microsoft.com/windows/win32/api/icm/nf-icm-unregistercmmw
    [LibraryImport("mscms", StringMarshalling = StringMarshalling.Utf16, SetLastError = true)]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial BOOL UnregisterCMMW(PWSTR pMachineName, uint cmmID);
    
    // https://learn.microsoft.com/windows/win32/api/winuser/nf-winuser-unregisterhotkey
    [LibraryImport("USER32", SetLastError = true)]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial BOOL UnregisterHotKey(HWND hWnd, int id);
    
    // https://learn.microsoft.com/windows/win32/api/oleauto/nf-oleauto-unregistertypelib
    [LibraryImport("OLEAUT32")]
    [PreserveSig]
    public static partial HRESULT UnRegisterTypeLib(in Guid libID, ushort wVerMajor, ushort wVerMinor, uint lcid, SYSKIND syskind);
    
    // https://learn.microsoft.com/windows/win32/api/oleauto/nf-oleauto-unregistertypelibforuser
    [LibraryImport("OLEAUT32")]
    [PreserveSig]
    public static partial HRESULT UnRegisterTypeLibForUser(in Guid libID, ushort wMajorVerNum, ushort wMinorVerNum, uint lcid, SYSKIND syskind);
    
    // https://learn.microsoft.com/windows/win32/api/wingdi/nf-wingdi-updateicmregkeya
    [LibraryImport("GDI32", SetLastError = true)]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial BOOL UpdateICMRegKeyA(uint reserved, PSTR lpszCMID, PSTR lpszFileName, ICM_COMMAND command);
    
    // https://learn.microsoft.com/windows/win32/api/wingdi/nf-wingdi-updateicmregkeyw
    [LibraryImport("GDI32", StringMarshalling = StringMarshalling.Utf16, SetLastError = true)]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial BOOL UpdateICMRegKeyW(uint reserved, PWSTR lpszCMID, PWSTR lpszFileName, ICM_COMMAND command);
    
    // https://learn.microsoft.com/windows/win32/api/winuser/nf-winuser-updatelayeredwindow
    [LibraryImport("USER32", SetLastError = true)]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial BOOL UpdateLayeredWindow(HWND hWnd, HDC hdcDst, nint /* optional POINT* */ pptDst, nint /* optional SIZE* */ psize, HDC hdcSrc, nint /* optional POINT* */ pptSrc, COLORREF crKey, nint /* optional BLENDFUNCTION* */ pblend, UPDATE_LAYERED_WINDOW_FLAGS dwFlags);
    
    [LibraryImport("USER32", SetLastError = true)]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial BOOL UpdateLayeredWindowIndirect(HWND hWnd, in UPDATELAYEREDWINDOWINFO pULWInfo);
    
    // https://learn.microsoft.com/windows/win32/api/winbase/nf-winbase-updateresourcew
    [LibraryImport("KERNEL32", StringMarshalling = StringMarshalling.Utf16, SetLastError = true)]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial BOOL UpdateResourceW(HANDLE hUpdate, PWSTR lpType, PWSTR lpName, ushort wLanguage, nint /* optional void* */ lpData, uint cb);
    
    // https://learn.microsoft.com/windows/win32/api/winuser/nf-winuser-updatewindow
    [LibraryImport("USER32", SetLastError = true)]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial BOOL UpdateWindow(HWND hWnd);
    
    // https://learn.microsoft.com/windows/win32/api/winuser/nf-winuser-validaterect
    [LibraryImport("USER32", SetLastError = true)]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial BOOL ValidateRect(HWND hWnd, nint /* optional RECT* */ lpRect);
    
    // https://learn.microsoft.com/windows/win32/api/winuser/nf-winuser-validatergn
    [LibraryImport("USER32", SetLastError = true)]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial BOOL ValidateRgn(HWND hWnd, HRGN hRgn);
    
    // https://learn.microsoft.com/windows/win32/api/oleauto/nf-oleauto-variantchangetype
    [LibraryImport("OLEAUT32")]
    [PreserveSig]
    public static partial HRESULT VariantChangeType(ref VARIANT pvargDest, in VARIANT pvarSrc, VAR_CHANGE_FLAGS wFlags, VARENUM vt);
    
    // https://learn.microsoft.com/windows/win32/api/oleauto/nf-oleauto-variantchangetypeex
    [LibraryImport("OLEAUT32")]
    [PreserveSig]
    public static partial HRESULT VariantChangeTypeEx(ref VARIANT pvargDest, in VARIANT pvarSrc, uint lcid, VAR_CHANGE_FLAGS wFlags, VARENUM vt);
    
    // https://learn.microsoft.com/windows/win32/api/oleauto/nf-oleauto-variantclear
    [LibraryImport("OLEAUT32")]
    [PreserveSig]
    public static partial HRESULT VariantClear(ref VARIANT pvarg);
    
    // https://learn.microsoft.com/windows/win32/api/oleauto/nf-oleauto-variantcopy
    [LibraryImport("OLEAUT32")]
    [PreserveSig]
    public static partial HRESULT VariantCopy(ref VARIANT pvargDest, in VARIANT pvargSrc);
    
    // https://learn.microsoft.com/windows/win32/api/oleauto/nf-oleauto-variantcopyind
    [LibraryImport("OLEAUT32")]
    [PreserveSig]
    public static partial HRESULT VariantCopyInd(ref VARIANT pvarDest, in VARIANT pvargSrc);
    
    // https://learn.microsoft.com/windows/win32/api/oleauto/nf-oleauto-variantinit
    [LibraryImport("OLEAUT32")]
    [PreserveSig]
    public static partial void VariantInit(out VARIANT pvarg);
    
    // https://learn.microsoft.com/windows/win32/api/propvarutil/nf-propvarutil-varianttopropvariant
    [LibraryImport("PROPSYS")]
    [SupportedOSPlatform("windows6.0.6000")]
    [PreserveSig]
    public static partial HRESULT VariantToPropVariant(in VARIANT pVar, out PROPVARIANT pPropVar);
    
    [LibraryImport("MSVFW32")]
    [PreserveSig]
    public static partial uint VideoForWindowsVersion();
    
    // https://learn.microsoft.com/windows/win32/api/winuser/nf-winuser-vkkeyscanexw
    [LibraryImport("USER32", StringMarshalling = StringMarshalling.Utf16)]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    public static partial short VkKeyScanExW(char ch, HKL dwhkl);
    
    // https://learn.microsoft.com/windows/win32/api/winuser/nf-winuser-vkkeyscanw
    [LibraryImport("USER32", StringMarshalling = StringMarshalling.Utf16)]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    public static partial short VkKeyScanW(char ch);
    
    // https://learn.microsoft.com/windows/win32/api/synchapi/nf-synchapi-waitformultipleobjects
    [LibraryImport("KERNEL32", SetLastError = true)]
    [SupportedOSPlatform("windows5.1.2600")]
    [PreserveSig]
    public static partial WAIT_EVENT WaitForMultipleObjects(uint nCount, [In][MarshalUsing(CountElementName = nameof(nCount))] HANDLE[] lpHandles, BOOL bWaitAll, uint dwMilliseconds);
    
    // https://learn.microsoft.com/windows/win32/api/synchapi/nf-synchapi-waitformultipleobjectsex
    [LibraryImport("KERNEL32", SetLastError = true)]
    [SupportedOSPlatform("windows5.1.2600")]
    [PreserveSig]
    public static partial WAIT_EVENT WaitForMultipleObjectsEx(uint nCount, [In][MarshalUsing(CountElementName = nameof(nCount))] HANDLE[] lpHandles, BOOL bWaitAll, uint dwMilliseconds, BOOL bAlertable);
    
    // https://learn.microsoft.com/windows/win32/api/synchapi/nf-synchapi-waitforsingleobject
    [LibraryImport("KERNEL32", SetLastError = true)]
    [SupportedOSPlatform("windows5.1.2600")]
    [PreserveSig]
    public static partial WAIT_EVENT WaitForSingleObject(HANDLE hHandle, uint dwMilliseconds);
    
    // https://learn.microsoft.com/windows/win32/api/synchapi/nf-synchapi-waitforsingleobjectex
    [LibraryImport("KERNEL32", SetLastError = true)]
    [SupportedOSPlatform("windows5.1.2600")]
    [PreserveSig]
    public static partial WAIT_EVENT WaitForSingleObjectEx(HANDLE hHandle, uint dwMilliseconds, BOOL bAlertable);
    
    // https://learn.microsoft.com/windows/win32/api/mmeapi/nf-mmeapi-waveinaddbuffer
    [LibraryImport("WINMM")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    public static partial uint waveInAddBuffer(HWAVEIN hwi, ref WAVEHDR pwh, uint cbwh);
    
    // https://learn.microsoft.com/windows/win32/api/mmeapi/nf-mmeapi-waveinclose
    [LibraryImport("WINMM")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    public static partial uint waveInClose(HWAVEIN hwi);
    
    [LibraryImport("WINMM")]
    [PreserveSig]
    public static partial uint waveInGetDevCapsA(nuint uDeviceID, nint pwic, uint cbwic);
    
    [LibraryImport("WINMM", StringMarshalling = StringMarshalling.Utf16)]
    [PreserveSig]
    public static partial uint waveInGetDevCapsW(nuint uDeviceID, nint pwic, uint cbwic);
    
    [LibraryImport("WINMM")]
    [PreserveSig]
    public static partial uint waveInGetErrorTextA(uint mmrError, [MarshalUsing(CountElementName = nameof(cchText))] PSTR pszText, uint cchText);
    
    [LibraryImport("WINMM", StringMarshalling = StringMarshalling.Utf16)]
    [PreserveSig]
    public static partial uint waveInGetErrorTextW(uint mmrError, [MarshalUsing(CountElementName = nameof(cchText))] PWSTR pszText, uint cchText);
    
    // https://learn.microsoft.com/windows/win32/api/mmeapi/nf-mmeapi-waveingetid
    [LibraryImport("WINMM")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    public static partial uint waveInGetID(HWAVEIN hwi, in uint puDeviceID);
    
    // https://learn.microsoft.com/windows/win32/api/mmeapi/nf-mmeapi-waveingetnumdevs
    [LibraryImport("WINMM")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    public static partial uint waveInGetNumDevs();
    
    // https://learn.microsoft.com/windows/win32/api/mmeapi/nf-mmeapi-waveingetposition
    [LibraryImport("WINMM")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    public static partial uint waveInGetPosition(HWAVEIN hwi, ref MMTIME pmmt, uint cbmmt);
    
    // https://learn.microsoft.com/windows/win32/api/mmeapi/nf-mmeapi-waveinmessage
    [LibraryImport("WINMM")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    public static partial uint waveInMessage(HWAVEIN hwi, uint uMsg, nuint dw1, nuint dw2);
    
    // https://learn.microsoft.com/windows/win32/api/mmeapi/nf-mmeapi-waveinopen
    [LibraryImport("WINMM")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    public static partial uint waveInOpen(nint /* optional HWAVEIN* */ phwi, uint uDeviceID, in WAVEFORMATEX pwfx, nuint dwCallback, nuint dwInstance, MIDI_WAVE_OPEN_TYPE fdwOpen);
    
    // https://learn.microsoft.com/windows/win32/api/mmeapi/nf-mmeapi-waveinprepareheader
    [LibraryImport("WINMM")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    public static partial uint waveInPrepareHeader(HWAVEIN hwi, ref WAVEHDR pwh, uint cbwh);
    
    // https://learn.microsoft.com/windows/win32/api/mmeapi/nf-mmeapi-waveinreset
    [LibraryImport("WINMM")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    public static partial uint waveInReset(HWAVEIN hwi);
    
    // https://learn.microsoft.com/windows/win32/api/mmeapi/nf-mmeapi-waveinstart
    [LibraryImport("WINMM")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    public static partial uint waveInStart(HWAVEIN hwi);
    
    // https://learn.microsoft.com/windows/win32/api/mmeapi/nf-mmeapi-waveinstop
    [LibraryImport("WINMM")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    public static partial uint waveInStop(HWAVEIN hwi);
    
    // https://learn.microsoft.com/windows/win32/api/mmeapi/nf-mmeapi-waveinunprepareheader
    [LibraryImport("WINMM")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    public static partial uint waveInUnprepareHeader(HWAVEIN hwi, ref WAVEHDR pwh, uint cbwh);
    
    // https://learn.microsoft.com/windows/win32/api/mmeapi/nf-mmeapi-waveoutbreakloop
    [LibraryImport("WINMM")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    public static partial uint waveOutBreakLoop(HWAVEOUT hwo);
    
    // https://learn.microsoft.com/windows/win32/api/mmeapi/nf-mmeapi-waveoutclose
    [LibraryImport("WINMM")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    public static partial uint waveOutClose(HWAVEOUT hwo);
    
    [LibraryImport("WINMM")]
    [PreserveSig]
    public static partial uint waveOutGetDevCapsA(nuint uDeviceID, out WAVEOUTCAPSA pwoc, uint cbwoc);
    
    [LibraryImport("WINMM", StringMarshalling = StringMarshalling.Utf16)]
    [PreserveSig]
    public static partial uint waveOutGetDevCapsW(nuint uDeviceID, out WAVEOUTCAPSW pwoc, uint cbwoc);
    
    [LibraryImport("WINMM")]
    [PreserveSig]
    public static partial uint waveOutGetErrorTextA(uint mmrError, [MarshalUsing(CountElementName = nameof(cchText))] PSTR pszText, uint cchText);
    
    [LibraryImport("WINMM", StringMarshalling = StringMarshalling.Utf16)]
    [PreserveSig]
    public static partial uint waveOutGetErrorTextW(uint mmrError, [MarshalUsing(CountElementName = nameof(cchText))] PWSTR pszText, uint cchText);
    
    // https://learn.microsoft.com/windows/win32/api/mmeapi/nf-mmeapi-waveoutgetid
    [LibraryImport("WINMM")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    public static partial uint waveOutGetID(HWAVEOUT hwo, out uint puDeviceID);
    
    // https://learn.microsoft.com/windows/win32/api/mmeapi/nf-mmeapi-waveoutgetnumdevs
    [LibraryImport("WINMM")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    public static partial uint waveOutGetNumDevs();
    
    // https://learn.microsoft.com/windows/win32/api/mmeapi/nf-mmeapi-waveoutgetpitch
    [LibraryImport("WINMM")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    public static partial uint waveOutGetPitch(HWAVEOUT hwo, out uint pdwPitch);
    
    // https://learn.microsoft.com/windows/win32/api/mmeapi/nf-mmeapi-waveoutgetplaybackrate
    [LibraryImport("WINMM")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    public static partial uint waveOutGetPlaybackRate(HWAVEOUT hwo, out uint pdwRate);
    
    // https://learn.microsoft.com/windows/win32/api/mmeapi/nf-mmeapi-waveoutgetposition
    [LibraryImport("WINMM")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    public static partial uint waveOutGetPosition(HWAVEOUT hwo, ref MMTIME pmmt, uint cbmmt);
    
    // https://learn.microsoft.com/windows/win32/api/mmeapi/nf-mmeapi-waveoutgetvolume
    [LibraryImport("WINMM")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    public static partial uint waveOutGetVolume(HWAVEOUT hwo, out uint pdwVolume);
    
    // https://learn.microsoft.com/windows/win32/api/mmeapi/nf-mmeapi-waveoutmessage
    [LibraryImport("WINMM")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    public static partial uint waveOutMessage(HWAVEOUT hwo, uint uMsg, nuint dw1, nuint dw2);
    
    // https://learn.microsoft.com/windows/win32/api/mmeapi/nf-mmeapi-waveoutopen
    [LibraryImport("WINMM")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    public static partial uint waveOutOpen(nint /* optional HWAVEOUT* */ phwo, uint uDeviceID, in WAVEFORMATEX pwfx, nuint dwCallback, nuint dwInstance, MIDI_WAVE_OPEN_TYPE fdwOpen);
    
    // https://learn.microsoft.com/windows/win32/api/mmeapi/nf-mmeapi-waveoutpause
    [LibraryImport("WINMM")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    public static partial uint waveOutPause(HWAVEOUT hwo);
    
    // https://learn.microsoft.com/windows/win32/api/mmeapi/nf-mmeapi-waveoutprepareheader
    [LibraryImport("WINMM")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    public static partial uint waveOutPrepareHeader(HWAVEOUT hwo, ref WAVEHDR pwh, uint cbwh);
    
    // https://learn.microsoft.com/windows/win32/api/mmeapi/nf-mmeapi-waveoutreset
    [LibraryImport("WINMM")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    public static partial uint waveOutReset(HWAVEOUT hwo);
    
    // https://learn.microsoft.com/windows/win32/api/mmeapi/nf-mmeapi-waveoutrestart
    [LibraryImport("WINMM")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    public static partial uint waveOutRestart(HWAVEOUT hwo);
    
    // https://learn.microsoft.com/windows/win32/api/mmeapi/nf-mmeapi-waveoutsetpitch
    [LibraryImport("WINMM")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    public static partial uint waveOutSetPitch(HWAVEOUT hwo, uint dwPitch);
    
    // https://learn.microsoft.com/windows/win32/api/mmeapi/nf-mmeapi-waveoutsetplaybackrate
    [LibraryImport("WINMM")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    public static partial uint waveOutSetPlaybackRate(HWAVEOUT hwo, uint dwRate);
    
    // https://learn.microsoft.com/windows/win32/api/mmeapi/nf-mmeapi-waveoutsetvolume
    [LibraryImport("WINMM")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    public static partial uint waveOutSetVolume(HWAVEOUT hwo, uint dwVolume);
    
    // https://learn.microsoft.com/windows/win32/api/mmeapi/nf-mmeapi-waveoutunprepareheader
    [LibraryImport("WINMM")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    public static partial uint waveOutUnprepareHeader(HWAVEOUT hwo, ref WAVEHDR pwh, uint cbwh);
    
    // https://learn.microsoft.com/windows/win32/api/mmeapi/nf-mmeapi-waveoutwrite
    [LibraryImport("WINMM")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    public static partial uint waveOutWrite(HWAVEOUT hwo, ref WAVEHDR pwh, uint cbwh);
    
    // https://learn.microsoft.com/windows/win32/api/icm/nf-icm-wcsassociatecolorprofilewithdevice
    [LibraryImport("mscms", SetLastError = true)]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial BOOL WcsAssociateColorProfileWithDevice(WCS_PROFILE_MANAGEMENT_SCOPE scope, PWSTR pProfileName, PWSTR pDeviceName);
    
    // https://learn.microsoft.com/windows/win32/api/icm/nf-icm-wcscheckcolors
    [LibraryImport("mscms", SetLastError = true)]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial BOOL WcsCheckColors(nint hColorTransform, uint nColors, uint nInputChannels, COLORDATATYPE cdtInput, uint cbInput, nint pInputData, nint /* byte array */ paResult);
    
    // https://learn.microsoft.com/windows/win32/api/icm/nf-icm-wcscreateiccprofile
    [LibraryImport("mscms", SetLastError = true)]
    [PreserveSig]
    public static partial nint WcsCreateIccProfile(nint hWcsProfile, uint dwOptions);
    
    // https://learn.microsoft.com/windows/win32/api/icm/nf-icm-wcsdisassociatecolorprofilefromdevice
    [LibraryImport("mscms", SetLastError = true)]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial BOOL WcsDisassociateColorProfileFromDevice(WCS_PROFILE_MANAGEMENT_SCOPE scope, PWSTR pProfileName, PWSTR pDeviceName);
    
    // https://learn.microsoft.com/windows/win32/api/icm/nf-icm-wcsenumcolorprofiles
    [LibraryImport("mscms", SetLastError = true)]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial BOOL WcsEnumColorProfiles(WCS_PROFILE_MANAGEMENT_SCOPE scope, in ENUMTYPEW pEnumRecord, nint /* byte array */ pBuffer, uint dwSize, nint /* optional uint* */ pnProfiles);
    
    // https://learn.microsoft.com/windows/win32/api/icm/nf-icm-wcsenumcolorprofilessize
    [LibraryImport("mscms", SetLastError = true)]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial BOOL WcsEnumColorProfilesSize(WCS_PROFILE_MANAGEMENT_SCOPE scope, in ENUMTYPEW pEnumRecord, out uint pdwSize);
    
    // https://learn.microsoft.com/windows/win32/api/icm/nf-icm-wcsgetcalibrationmanagementstate
    [LibraryImport("mscms", SetLastError = true)]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial BOOL WcsGetCalibrationManagementState(out BOOL pbIsEnabled);
    
    // https://learn.microsoft.com/windows/win32/api/icm/nf-icm-wcsgetdefaultcolorprofile
    [LibraryImport("mscms", SetLastError = true)]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial BOOL WcsGetDefaultColorProfile(WCS_PROFILE_MANAGEMENT_SCOPE scope, PWSTR pDeviceName, COLORPROFILETYPE cptColorProfileType, COLORPROFILESUBTYPE cpstColorProfileSubType, uint dwProfileID, uint cbProfileName, PWSTR pProfileName);
    
    // https://learn.microsoft.com/windows/win32/api/icm/nf-icm-wcsgetdefaultcolorprofilesize
    [LibraryImport("mscms", SetLastError = true)]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial BOOL WcsGetDefaultColorProfileSize(WCS_PROFILE_MANAGEMENT_SCOPE scope, PWSTR pDeviceName, COLORPROFILETYPE cptColorProfileType, COLORPROFILESUBTYPE cpstColorProfileSubType, uint dwProfileID, out uint pcbProfileName);
    
    // https://learn.microsoft.com/windows/win32/api/icm/nf-icm-wcsgetdefaultrenderingintent
    [LibraryImport("mscms", SetLastError = true)]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial BOOL WcsGetDefaultRenderingIntent(WCS_PROFILE_MANAGEMENT_SCOPE scope, out uint pdwRenderingIntent);
    
    // https://learn.microsoft.com/windows/win32/api/icm/nf-icm-wcsgetuseperuserprofiles
    [LibraryImport("mscms", SetLastError = true)]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial BOOL WcsGetUsePerUserProfiles(PWSTR pDeviceName, uint dwDeviceClass, out BOOL pUsePerUserProfiles);
    
    // https://learn.microsoft.com/windows/win32/api/icm/nf-icm-wcsopencolorprofilea
    [LibraryImport("mscms", SetLastError = true)]
    [PreserveSig]
    public static partial nint WcsOpenColorProfileA(in PROFILE pCDMPProfile, nint /* optional PROFILE* */ pCAMPProfile, nint /* optional PROFILE* */ pGMMPProfile, uint dwDesireAccess, uint dwShareMode, uint dwCreationMode, uint dwFlags);
    
    // https://learn.microsoft.com/windows/win32/api/icm/nf-icm-wcsopencolorprofilew
    [LibraryImport("mscms", StringMarshalling = StringMarshalling.Utf16, SetLastError = true)]
    [PreserveSig]
    public static partial nint WcsOpenColorProfileW(in PROFILE pCDMPProfile, nint /* optional PROFILE* */ pCAMPProfile, nint /* optional PROFILE* */ pGMMPProfile, uint dwDesireAccess, uint dwShareMode, uint dwCreationMode, uint dwFlags);
    
    // https://learn.microsoft.com/windows/win32/api/icm/nf-icm-wcssetcalibrationmanagementstate
    [LibraryImport("mscms", SetLastError = true)]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial BOOL WcsSetCalibrationManagementState(BOOL bIsEnabled);
    
    // https://learn.microsoft.com/windows/win32/api/icm/nf-icm-wcssetdefaultcolorprofile
    [LibraryImport("mscms", SetLastError = true)]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial BOOL WcsSetDefaultColorProfile(WCS_PROFILE_MANAGEMENT_SCOPE scope, PWSTR pDeviceName, COLORPROFILETYPE cptColorProfileType, COLORPROFILESUBTYPE cpstColorProfileSubType, uint dwProfileID, PWSTR pProfileName);
    
    // https://learn.microsoft.com/windows/win32/api/icm/nf-icm-wcssetdefaultrenderingintent
    [LibraryImport("mscms", SetLastError = true)]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial BOOL WcsSetDefaultRenderingIntent(WCS_PROFILE_MANAGEMENT_SCOPE scope, uint dwRenderingIntent);
    
    // https://learn.microsoft.com/windows/win32/api/icm/nf-icm-wcssetuseperuserprofiles
    [LibraryImport("mscms", SetLastError = true)]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial BOOL WcsSetUsePerUserProfiles(PWSTR pDeviceName, uint dwDeviceClass, BOOL usePerUserProfiles);
    
    // https://learn.microsoft.com/windows/win32/api/icm/nf-icm-wcstranslatecolors
    [LibraryImport("mscms", SetLastError = true)]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial BOOL WcsTranslateColors(nint hColorTransform, uint nColors, uint nInputChannels, COLORDATATYPE cdtInput, uint cbInput, nint pInputData, uint nOutputChannels, COLORDATATYPE cdtOutput, uint cbOutput, nint pOutputData);
    
    // https://learn.microsoft.com/windows/win32/api/wingdi/nf-wingdi-wglcopycontext
    [LibraryImport("OPENGL32", SetLastError = true)]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial BOOL wglCopyContext(HGLRC param0, HGLRC param1, uint param2);
    
    // https://learn.microsoft.com/windows/win32/api/wingdi/nf-wingdi-wglcreatecontext
    [LibraryImport("OPENGL32", SetLastError = true)]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial HGLRC wglCreateContext(HDC param0);
    
    // https://learn.microsoft.com/windows/win32/api/wingdi/nf-wingdi-wglcreatelayercontext
    [LibraryImport("OPENGL32", SetLastError = true)]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial HGLRC wglCreateLayerContext(HDC param0, int param1);
    
    // https://learn.microsoft.com/windows/win32/api/wingdi/nf-wingdi-wgldeletecontext
    [LibraryImport("OPENGL32", SetLastError = true)]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial BOOL wglDeleteContext(HGLRC param0);
    
    // https://learn.microsoft.com/windows/win32/api/wingdi/nf-wingdi-wgldescribelayerplane
    [LibraryImport("OPENGL32", SetLastError = true)]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial BOOL wglDescribeLayerPlane(HDC param0, int param1, int param2, uint param3, ref LAYERPLANEDESCRIPTOR param4);
    
    // https://learn.microsoft.com/windows/win32/api/wingdi/nf-wingdi-wglgetcurrentcontext
    [LibraryImport("OPENGL32")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial HGLRC wglGetCurrentContext();
    
    // https://learn.microsoft.com/windows/win32/api/wingdi/nf-wingdi-wglgetcurrentdc
    [LibraryImport("OPENGL32")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial HDC wglGetCurrentDC();
    
    // https://learn.microsoft.com/windows/win32/api/wingdi/nf-wingdi-wglgetlayerpaletteentries
    [LibraryImport("OPENGL32", SetLastError = true)]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    public static partial int wglGetLayerPaletteEntries(HDC param0, int param1, int param2, int param3, ref COLORREF param4);
    
    // https://learn.microsoft.com/windows/win32/api/wingdi/nf-wingdi-wglgetprocaddress
    [LibraryImport("OPENGL32", SetLastError = true)]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    public static partial PROC wglGetProcAddress(PSTR param0);
    
    // https://learn.microsoft.com/windows/win32/api/wingdi/nf-wingdi-wglmakecurrent
    [LibraryImport("OPENGL32", SetLastError = true)]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial BOOL wglMakeCurrent(HDC param0, HGLRC param1);
    
    // https://learn.microsoft.com/windows/win32/api/wingdi/nf-wingdi-wglrealizelayerpalette
    [LibraryImport("OPENGL32", SetLastError = true)]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial BOOL wglRealizeLayerPalette(HDC param0, int param1, BOOL param2);
    
    // https://learn.microsoft.com/windows/win32/api/wingdi/nf-wingdi-wglsetlayerpaletteentries
    [LibraryImport("OPENGL32", SetLastError = true)]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    public static partial int wglSetLayerPaletteEntries(HDC param0, int param1, int param2, int param3, in COLORREF param4);
    
    // https://learn.microsoft.com/windows/win32/api/wingdi/nf-wingdi-wglsharelists
    [LibraryImport("OPENGL32", SetLastError = true)]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial BOOL wglShareLists(HGLRC param0, HGLRC param1);
    
    // https://learn.microsoft.com/windows/win32/api/wingdi/nf-wingdi-wglswaplayerbuffers
    [LibraryImport("OPENGL32", SetLastError = true)]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial BOOL wglSwapLayerBuffers(HDC param0, uint param1);
    
    // https://learn.microsoft.com/windows/win32/api/wingdi/nf-wingdi-wglusefontbitmapsa
    [LibraryImport("OPENGL32", SetLastError = true)]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial BOOL wglUseFontBitmapsA(HDC param0, uint param1, uint param2, uint param3);
    
    // https://learn.microsoft.com/windows/win32/api/wingdi/nf-wingdi-wglusefontbitmapsw
    [LibraryImport("OPENGL32", StringMarshalling = StringMarshalling.Utf16, SetLastError = true)]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial BOOL wglUseFontBitmapsW(HDC param0, uint param1, uint param2, uint param3);
    
    // https://learn.microsoft.com/windows/win32/api/wingdi/nf-wingdi-wglusefontoutlinesa
    [LibraryImport("OPENGL32", SetLastError = true)]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial BOOL wglUseFontOutlinesA(HDC param0, uint param1, uint param2, uint param3, float param4, float param5, int param6, ref GLYPHMETRICSFLOAT param7);
    
    // https://learn.microsoft.com/windows/win32/api/wingdi/nf-wingdi-wglusefontoutlinesw
    [LibraryImport("OPENGL32", StringMarshalling = StringMarshalling.Utf16, SetLastError = true)]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial BOOL wglUseFontOutlinesW(HDC param0, uint param1, uint param2, uint param3, float param4, float param5, int param6, ref GLYPHMETRICSFLOAT param7);
    
    // https://learn.microsoft.com/windows/win32/api/wincodec/nf-wincodec-wicconvertbitmapsource
    [LibraryImport("WindowsCodecs")]
    [SupportedOSPlatform("windows5.1.2600")]
    [PreserveSig]
    public static partial HRESULT WICConvertBitmapSource(in Guid dstFormat, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IWICBitmapSource>))] IWICBitmapSource pISrc, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IWICBitmapSource>))] out IWICBitmapSource ppIDst);
    
    // https://learn.microsoft.com/windows/win32/api/wincodec/nf-wincodec-wiccreatebitmapfromsection
    [LibraryImport("WindowsCodecs")]
    [SupportedOSPlatform("windows5.1.2600")]
    [PreserveSig]
    public static partial HRESULT WICCreateBitmapFromSection(uint width, uint height, in Guid pixelFormat, HANDLE hSection, uint stride, uint offset, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IWICBitmap>))] out IWICBitmap ppIBitmap);
    
    // https://learn.microsoft.com/windows/win32/api/wincodec/nf-wincodec-wiccreatebitmapfromsectionex
    [LibraryImport("WindowsCodecs")]
    [SupportedOSPlatform("windows6.1")]
    [PreserveSig]
    public static partial HRESULT WICCreateBitmapFromSectionEx(uint width, uint height, in Guid pixelFormat, HANDLE hSection, uint stride, uint offset, WICSectionAccessLevel desiredAccessLevel, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IWICBitmap>))] out IWICBitmap ppIBitmap);
    
    // https://learn.microsoft.com/windows/win32/api/wincodecsdk/nf-wincodecsdk-wicgetmetadatacontentsize
    [LibraryImport("WindowsCodecs")]
    [SupportedOSPlatform("windows5.1.2600")]
    [PreserveSig]
    public static partial HRESULT WICGetMetadataContentSize(in Guid guidContainerFormat, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IWICMetadataWriter>))] IWICMetadataWriter pIWriter, out ulong pcbSize);
    
    // https://learn.microsoft.com/windows/win32/api/wincodec/nf-wincodec-wicmapguidtoshortname
    [LibraryImport("WindowsCodecs")]
    [SupportedOSPlatform("windows5.1.2600")]
    [PreserveSig]
    public static partial HRESULT WICMapGuidToShortName(in Guid guid, uint cchName, [MarshalUsing(CountElementName = nameof(cchName))] PWSTR wzName, out uint pcchActual);
    
    // https://learn.microsoft.com/windows/win32/api/wincodec/nf-wincodec-wicmapschematoname
    [LibraryImport("WindowsCodecs")]
    [SupportedOSPlatform("windows5.1.2600")]
    [PreserveSig]
    public static partial HRESULT WICMapSchemaToName(in Guid guidMetadataFormat, PWSTR pwzSchema, uint cchName, [MarshalUsing(CountElementName = nameof(cchName))] PWSTR wzName, out uint pcchActual);
    
    // https://learn.microsoft.com/windows/win32/api/wincodec/nf-wincodec-wicmapshortnametoguid
    [LibraryImport("WindowsCodecs")]
    [SupportedOSPlatform("windows5.1.2600")]
    [PreserveSig]
    public static partial HRESULT WICMapShortNameToGuid(PWSTR wzName, out Guid pguid);
    
    // https://learn.microsoft.com/windows/win32/api/wincodecsdk/nf-wincodecsdk-wicmatchmetadatacontent
    [LibraryImport("WindowsCodecs")]
    [SupportedOSPlatform("windows5.1.2600")]
    [PreserveSig]
    public static partial HRESULT WICMatchMetadataContent(in Guid guidContainerFormat, nint /* optional Guid* */ pguidVendor, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IStream>))] IStream pIStream, out Guid pguidMetadataFormat);
    
    // https://learn.microsoft.com/windows/win32/api/wincodecsdk/nf-wincodecsdk-wicserializemetadatacontent
    [LibraryImport("WindowsCodecs")]
    [SupportedOSPlatform("windows5.1.2600")]
    [PreserveSig]
    public static partial HRESULT WICSerializeMetadataContent(in Guid guidContainerFormat, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IWICMetadataWriter>))] IWICMetadataWriter pIWriter, uint dwPersistOptions, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IStream>))] IStream pIStream);
    
    // https://learn.microsoft.com/windows/win32/api/winuser/nf-winuser-windowfromdc
    [LibraryImport("USER32")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial HWND WindowFromDC(HDC hDC);
    
    // https://learn.microsoft.com/windows/win32/api/winuser/nf-winuser-windowfromphysicalpoint
    [LibraryImport("USER32")]
    [SupportedOSPlatform("windows6.0.6000")]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial HWND WindowFromPhysicalPoint(POINT Point);
    
    // https://learn.microsoft.com/windows/win32/api/winuser/nf-winuser-windowfrompoint
    [LibraryImport("USER32")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial HWND WindowFromPoint(POINT Point);
    
    // https://learn.microsoft.com/windows/win32/api/winstring/nf-winstring-windowscomparestringordinal
    [LibraryImport("api-ms-win-core-winrt-string-l1-1-0")]
    [SupportedOSPlatform("windows8.0")]
    [PreserveSig]
    public static partial HRESULT WindowsCompareStringOrdinal(HSTRING string1, HSTRING string2, out int result);
    
    // https://learn.microsoft.com/windows/win32/api/winstring/nf-winstring-windowsconcatstring
    [LibraryImport("api-ms-win-core-winrt-string-l1-1-0")]
    [SupportedOSPlatform("windows8.0")]
    [PreserveSig]
    public static partial HRESULT WindowsConcatString(HSTRING string1, HSTRING string2, out HSTRING newString);
    
    // https://learn.microsoft.com/windows/win32/api/winstring/nf-winstring-windowscreatestring
    [LibraryImport("api-ms-win-core-winrt-string-l1-1-0")]
    [SupportedOSPlatform("windows8.0")]
    [PreserveSig]
    public static partial HRESULT WindowsCreateString([MarshalUsing(CountElementName = nameof(length))] PWSTR sourceString, uint length, out HSTRING @string);
    
    // https://learn.microsoft.com/windows/win32/api/winstring/nf-winstring-windowscreatestringreference
    [LibraryImport("api-ms-win-core-winrt-string-l1-1-0")]
    [SupportedOSPlatform("windows8.0")]
    [PreserveSig]
    public static partial HRESULT WindowsCreateStringReference(PWSTR sourceString, uint length, out HSTRING_HEADER hstringHeader, out HSTRING @string);
    
    // https://learn.microsoft.com/windows/win32/api/winstring/nf-winstring-windowsdeletestring
    [LibraryImport("api-ms-win-core-winrt-string-l1-1-0")]
    [SupportedOSPlatform("windows8.0")]
    [PreserveSig]
    public static partial HRESULT WindowsDeleteString(HSTRING @string);
    
    // https://learn.microsoft.com/windows/win32/api/winstring/nf-winstring-windowsdeletestringbuffer
    [LibraryImport("api-ms-win-core-winrt-string-l1-1-0")]
    [SupportedOSPlatform("windows8.0")]
    [PreserveSig]
    public static partial HRESULT WindowsDeleteStringBuffer(HSTRING_BUFFER bufferHandle);
    
    // https://learn.microsoft.com/windows/win32/api/winstring/nf-winstring-windowsduplicatestring
    [LibraryImport("api-ms-win-core-winrt-string-l1-1-0")]
    [SupportedOSPlatform("windows8.0")]
    [PreserveSig]
    public static partial HRESULT WindowsDuplicateString(HSTRING @string, out HSTRING newString);
    
    // https://learn.microsoft.com/windows/win32/api/winstring/nf-winstring-windowsgetstringlen
    [LibraryImport("api-ms-win-core-winrt-string-l1-1-0")]
    [SupportedOSPlatform("windows8.0")]
    [PreserveSig]
    public static partial uint WindowsGetStringLen(HSTRING @string);
    
    // https://learn.microsoft.com/windows/win32/api/winstring/nf-winstring-windowsgetstringrawbuffer
    [LibraryImport("api-ms-win-core-winrt-string-l1-1-0")]
    [SupportedOSPlatform("windows8.0")]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial PWSTR WindowsGetStringRawBuffer(HSTRING @string, nint /* optional uint* */ length);
    
    // https://learn.microsoft.com/windows/win32/api/winstring/nf-winstring-windowsinspectstring
    [LibraryImport("api-ms-win-core-winrt-string-l1-1-0")]
    [SupportedOSPlatform("windows8.0")]
    [PreserveSig]
    public static partial HRESULT WindowsInspectString(nuint targetHString, ushort machine, PINSPECT_HSTRING_CALLBACK callback, nint /* optional void* */ context, out uint length, out nuint targetStringAddress);
    
    // https://learn.microsoft.com/windows/win32/api/winstring/nf-winstring-windowsinspectstring2
    [LibraryImport("api-ms-win-core-winrt-string-l1-1-1")]
    [SupportedOSPlatform("windows8.0")]
    [PreserveSig]
    public static partial HRESULT WindowsInspectString2(ulong targetHString, ushort machine, PINSPECT_HSTRING_CALLBACK2 callback, nint /* optional void* */ context, out uint length, out ulong targetStringAddress);
    
    // https://learn.microsoft.com/windows/win32/api/winstring/nf-winstring-windowsisstringempty
    [LibraryImport("api-ms-win-core-winrt-string-l1-1-0", SetLastError = true)]
    [SupportedOSPlatform("windows8.0")]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial BOOL WindowsIsStringEmpty(HSTRING @string);
    
    // https://learn.microsoft.com/windows/win32/api/winstring/nf-winstring-windowspreallocatestringbuffer
    [LibraryImport("api-ms-win-core-winrt-string-l1-1-0")]
    [SupportedOSPlatform("windows8.0")]
    [PreserveSig]
    public static partial HRESULT WindowsPreallocateStringBuffer(uint length, out nint charBuffer, out HSTRING_BUFFER bufferHandle);
    
    // https://learn.microsoft.com/windows/win32/api/winstring/nf-winstring-windowspromotestringbuffer
    [LibraryImport("api-ms-win-core-winrt-string-l1-1-0")]
    [SupportedOSPlatform("windows8.0")]
    [PreserveSig]
    public static partial HRESULT WindowsPromoteStringBuffer(HSTRING_BUFFER bufferHandle, out HSTRING @string);
    
    // https://learn.microsoft.com/windows/win32/api/winstring/nf-winstring-windowsreplacestring
    [LibraryImport("api-ms-win-core-winrt-string-l1-1-0")]
    [SupportedOSPlatform("windows8.0")]
    [PreserveSig]
    public static partial HRESULT WindowsReplaceString(HSTRING @string, HSTRING stringReplaced, HSTRING stringReplaceWith, out HSTRING newString);
    
    // https://learn.microsoft.com/windows/win32/api/winstring/nf-winstring-windowsstringhasembeddednull
    [LibraryImport("api-ms-win-core-winrt-string-l1-1-0")]
    [SupportedOSPlatform("windows8.0")]
    [PreserveSig]
    public static partial HRESULT WindowsStringHasEmbeddedNull(HSTRING @string, out BOOL hasEmbedNull);
    
    // https://learn.microsoft.com/windows/win32/api/winstring/nf-winstring-windowssubstring
    [LibraryImport("api-ms-win-core-winrt-string-l1-1-0")]
    [SupportedOSPlatform("windows8.0")]
    [PreserveSig]
    public static partial HRESULT WindowsSubstring(HSTRING @string, uint startIndex, out HSTRING newString);
    
    // https://learn.microsoft.com/windows/win32/api/winstring/nf-winstring-windowssubstringwithspecifiedlength
    [LibraryImport("api-ms-win-core-winrt-string-l1-1-0")]
    [SupportedOSPlatform("windows8.0")]
    [PreserveSig]
    public static partial HRESULT WindowsSubstringWithSpecifiedLength(HSTRING @string, uint startIndex, uint length, out HSTRING newString);
    
    // https://learn.microsoft.com/windows/win32/api/winstring/nf-winstring-windowstrimstringend
    [LibraryImport("api-ms-win-core-winrt-string-l1-1-0")]
    [SupportedOSPlatform("windows8.0")]
    [PreserveSig]
    public static partial HRESULT WindowsTrimStringEnd(HSTRING @string, HSTRING trimString, out HSTRING newString);
    
    // https://learn.microsoft.com/windows/win32/api/winstring/nf-winstring-windowstrimstringstart
    [LibraryImport("api-ms-win-core-winrt-string-l1-1-0")]
    [SupportedOSPlatform("windows8.0")]
    [PreserveSig]
    public static partial HRESULT WindowsTrimStringStart(HSTRING @string, HSTRING trimString, out HSTRING newString);
    
    // https://learn.microsoft.com/windows/win32/api/propsys/nf-propsys-winrtpropertyvaluetopropvariant
    [LibraryImport("PROPSYS")]
    [SupportedOSPlatform("windows8.0")]
    [PreserveSig]
    public static partial HRESULT WinRTPropertyValueToPropVariant(nint punkPropertyValue, out PROPVARIANT ppropvar);
    
    // https://learn.microsoft.com/windows/win32/api/wmsdkidl/nf-wmsdkidl-wmcreatebackuprestorer
    [LibraryImport("WMVCore")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    public static partial HRESULT WMCreateBackupRestorer(nint pCallback, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IWMLicenseBackup>))] out IWMLicenseBackup ppBackup);
    
    // https://learn.microsoft.com/windows/win32/api/wmsdkidl/nf-wmsdkidl-wmcreateeditor
    [LibraryImport("WMVCore")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    public static partial HRESULT WMCreateEditor([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IWMMetadataEditor>))] out IWMMetadataEditor ppEditor);
    
    // https://learn.microsoft.com/windows/win32/api/wmsdkidl/nf-wmsdkidl-wmcreateindexer
    [LibraryImport("WMVCore")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    public static partial HRESULT WMCreateIndexer([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IWMIndexer>))] out IWMIndexer ppIndexer);
    
    // https://learn.microsoft.com/windows/win32/api/wmsdkidl/nf-wmsdkidl-wmcreateprofilemanager
    [LibraryImport("WMVCore")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    public static partial HRESULT WMCreateProfileManager([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IWMProfileManager>))] out IWMProfileManager ppProfileManager);
    
    // https://learn.microsoft.com/windows/win32/api/wmsdkidl/nf-wmsdkidl-wmcreatereader
    [LibraryImport("WMVCore")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    public static partial HRESULT WMCreateReader(nint pUnkCert, uint dwRights, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IWMReader>))] out IWMReader ppReader);
    
    // https://learn.microsoft.com/windows/win32/api/wmsdkidl/nf-wmsdkidl-wmcreatesyncreader
    [LibraryImport("WMVCore")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    public static partial HRESULT WMCreateSyncReader(nint pUnkCert, uint dwRights, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IWMSyncReader>))] out IWMSyncReader ppSyncReader);
    
    // https://learn.microsoft.com/windows/win32/api/wmsdkidl/nf-wmsdkidl-wmcreatewriter
    [LibraryImport("WMVCore")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    public static partial HRESULT WMCreateWriter(nint pUnkCert, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IWMWriter>))] out IWMWriter ppWriter);
    
    // https://learn.microsoft.com/windows/win32/api/wmsdkidl/nf-wmsdkidl-wmcreatewriterfilesink
    [LibraryImport("WMVCore")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    public static partial HRESULT WMCreateWriterFileSink([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IWMWriterFileSink>))] out IWMWriterFileSink ppSink);
    
    // https://learn.microsoft.com/windows/win32/api/wmsdkidl/nf-wmsdkidl-wmcreatewriternetworksink
    [LibraryImport("WMVCore")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    public static partial HRESULT WMCreateWriterNetworkSink([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IWMWriterNetworkSink>))] out IWMWriterNetworkSink ppSink);
    
    // https://learn.microsoft.com/windows/win32/api/wmsdkidl/nf-wmsdkidl-wmcreatewriterpushsink
    [LibraryImport("WMVCore")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    public static partial HRESULT WMCreateWriterPushSink([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IWMWriterPushSink>))] out IWMWriterPushSink ppSink);
    
    // https://learn.microsoft.com/windows/win32/api/wmsdkidl/nf-wmsdkidl-wmiscontentprotected
    [LibraryImport("WMVCore")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    public static partial HRESULT WMIsContentProtected(PWSTR pwszFileName, ref BOOL pfIsProtected);
    
    [LibraryImport("XAudio2_8")]
    [PreserveSig]
    public static partial HRESULT XAudio2CreateWithVersionInfo([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IXAudio2>))] out IXAudio2 ppXAudio2, uint Flags, uint XAudio2Processor, uint ntddiVersion);
    
    // https://learn.microsoft.com/windows/win32/api/winddi/nf-winddi-xformobj_bapplyxform
    [LibraryImport("GDI32", SetLastError = true)]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial BOOL XFORMOBJ_bApplyXform(ref XFORMOBJ pxo, uint iMode, uint cPoints, nint pvIn, nint pvOut);
    
    // https://learn.microsoft.com/windows/win32/api/winddi/nf-winddi-xformobj_igetxform
    [LibraryImport("GDI32")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    public static partial uint XFORMOBJ_iGetXform(in XFORMOBJ pxo, nint /* optional XFORML* */ pxform);
    
    // https://learn.microsoft.com/windows/win32/api/winddi/nf-winddi-xlateobj_cgetpalette
    [LibraryImport("GDI32")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    public static partial uint XLATEOBJ_cGetPalette(ref XLATEOBJ pxlo, uint iPal, uint cPal, ref uint pPal);
    
    // https://learn.microsoft.com/windows/win32/api/winddi/nf-winddi-xlateobj_hgetcolortransform
    [LibraryImport("GDI32")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial HANDLE XLATEOBJ_hGetColorTransform(ref XLATEOBJ pxlo);
    
    // https://learn.microsoft.com/windows/win32/api/winddi/nf-winddi-xlateobj_ixlate
    [LibraryImport("GDI32")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    public static partial uint XLATEOBJ_iXlate(ref XLATEOBJ pxlo, uint iColor);
    
    // https://learn.microsoft.com/windows/win32/api/winddi/nf-winddi-xlateobj_pivector
    [LibraryImport("GDI32")]
    [SupportedOSPlatform("windows5.0")]
    [PreserveSig]
    public static partial nint XLATEOBJ_piVector(ref XLATEOBJ pxlo);
}
