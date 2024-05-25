namespace DirectN;

public static partial class TextServicesFunctions
{
    public static IComObject<ITextServices>? Create(this ITextHost host, TextServicesGenerator generator = TextServicesGenerator.Default) => Create<ITextServices>(host, generator);
    public static IComObject<T>? Create<T>(this ITextHost host, TextServicesGenerator generator = TextServicesGenerator.Default) where T : ITextServices
    {
        ArgumentNullException.ThrowIfNull(host);
        if (generator == TextServicesGenerator.Office || generator == TextServicesGenerator.OfficeOrDefault)
        {
            var services = CreateOffice<T>(host);
            if (services != null)
                return services;

            if (generator == TextServicesGenerator.Office)
                throw new NotSupportedException("Microsoft Office's RichEdit cannot be found.");
        }

        return CreateTextServices<T>(host, TextServicesGenerator.Default);
    }

    public static IComObject<ITextServices>? CreateOffice(this ITextHost host) => CreateOffice<ITextServices>(host);
    public static IComObject<T>? CreateOffice<T>(this ITextHost host) where T : ITextServices
    {
        ArgumentNullException.ThrowIfNull(host);
        var rootPath = GetOfficeInstallRoot(out var version);
        if (rootPath == null)
            return default;

        string path;
        if (nint.Size == 4)
        {
            path = Path.GetFullPath(Path.Combine(rootPath, @"..\vfs\ProgramFilesCommonX86\Microsoft Shared\OFFICE" + version, "RICHED20.DLL"));
        }
        else
        {
            path = Path.GetFullPath(Path.Combine(rootPath, @"..\vfs\ProgramFilesCommonX64\Microsoft Shared\OFFICE" + version, "RICHED20.DLL"));
        }

        var h = Functions.LoadLibraryW(PWSTR.From(path));
        if (h.Value == 0)
            return default;

        return CreateTextServices<T>(host, TextServicesGenerator.Office);
    }

    private static IComObject<T>? CreateTextServices<T>(ITextHost host, TextServicesGenerator generator)
    {
        nint unk = 0;
        // for some reason (internal to riched?), we can't pass the object itself, we must use a pointer
        ComObject.WithComInstanceOfType<ITextHost2>(host, pp =>
        {
            if (generator == TextServicesGenerator.Office)
            {
                // don't check error
                CreateOfficeTextServices(0, pp, out unk);
            }
            else
            {
                CreateTextServices(0, pp, out unk).ThrowOnError();
            }
        });
        return ComObject.FromPointer<T>(unk);
    }

    public static TextServicesGenerator GetGenerator(object? services)
    {
        if (services == null)
            return TextServicesGenerator.Default;

        try
        {
            return ComObject.WithComInstance(services, ptr =>
            {

                var firstMethodPointer = Marshal.ReadIntPtr(ptr);
                if (firstMethodPointer == 0)
                    return TextServicesGenerator.Default;

                const uint GET_MODULE_HANDLE_EX_FLAG_FROM_ADDRESS = 4;
                Functions.GetModuleHandleExW(GET_MODULE_HANDLE_EX_FLAG_FROM_ADDRESS, new PWSTR { Value = firstMethodPointer }, out var hmodule);
                if (hmodule.Value == 0)
                    return TextServicesGenerator.Default;

                using var p = new AllocPwstr(1024 * 2);
                Functions.GetModuleFileNameW(hmodule, p, p.SizeInChars);
                var path = p.ToString();
                if (path == null)
                    return TextServicesGenerator.Default;

                var fileName = Path.GetFileNameWithoutExtension(path);
                return fileName.EqualsIgnoreCase("riched20") ? TextServicesGenerator.Office : TextServicesGenerator.Default;
            });
        }
        catch
        {
            return TextServicesGenerator.Default;
        }
    }

    // note this will fail if not called on the same thread as creation thread (because of underlying COM object, which is probably STA-aware only ...)
    public static void Shutdown(ITextServices? services, bool throwOnError = true)
    {
        if (services == null)
            return;

        ComObject.WithComInstance(services, unk =>
        {
            var generator = GetGenerator(services);
            if (generator == TextServicesGenerator.Office)
            {
                ShutdownOfficeTextServices(unk).ThrowOnError(throwOnError);
                return;
            }
            ShutdownTextServices(unk).ThrowOnError(throwOnError);
        });
    }

    private static string? GetOfficeInstallRoot(out string version)
    {
        // we currently support only v15 & 16
        version = "16";
        var path = GetOfficeInstallRoot(version + ".0");
        if (path != null)
            return path;

        version = "15";
        return GetOfficeInstallRoot(version + ".0");
    }

    private static string? GetOfficeInstallRoot(string version)
    {
        using var key = Registry.LocalMachine.OpenSubKey(Path.Combine(@"SOFTWARE\Microsoft\Office", version, @"Access\InstallRoot"));
        if (key == null)
            return null;

        return (key.GetValue("Path", null) as string).Nullify();
    }

    [LibraryImport("riched20", EntryPoint = nameof(CreateTextServices))]
    private static partial HRESULT CreateOfficeTextServices(nint punkOuter, nint pITextHost, out nint ppUnk);

    [LibraryImport("riched20", EntryPoint = nameof(ShutdownTextServices))]
    private static partial HRESULT ShutdownOfficeTextServices(nint pTextServices);

    [LibraryImport("msftedit")]
    private static partial HRESULT CreateTextServices(nint punkOuter, nint pITextHost, out nint ppUnk);

    [LibraryImport("msftedit")]
    private static partial HRESULT ShutdownTextServices(nint pTextServices);
}
