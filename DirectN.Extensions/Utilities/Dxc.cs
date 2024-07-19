namespace DirectN.Extensions.Utilities;

public class Dxc
{
    public static IComObject<IDxcCompiler3> CreateCompiler() => CreateCompiler<IDxcCompiler3>();
    public static IComObject<T> CreateCompiler<T>() where T : IDxcCompiler3
    {
        Functions.DxcCreateInstance(Constants.CLSID_DxcCompiler, typeof(T).GUID, out var ppv).ThrowOnError();
        return ComObject.FromPointer<T>(ppv)!;
    }

    public static IComObject<IDxcUtils> CreateUtils() => CreateUtils<IDxcUtils>();
    public static IComObject<T> CreateUtils<T>() where T : IDxcUtils
    {
        Functions.DxcCreateInstance(Constants.CLSID_DxcUtils, typeof(T).GUID, out var ppv).ThrowOnError();
        return ComObject.FromPointer<T>(ppv)!;
    }

    public static IComObject<IDxcCompilerArgs> CreateCompilerArguments(IReadOnlyList<string>? arguments = null) => CreateCompilerArguments<IDxcCompilerArgs>(arguments);
    public static IComObject<T> CreateCompilerArguments<T>(IReadOnlyList<string>? arguments = null) where T : IDxcCompilerArgs
    {
        Functions.DxcCreateInstance(Constants.CLSID_DxcCompilerArgs, typeof(IDxcCompilerArgs).GUID, out var ppv).ThrowOnError();
        var args = ComObject.FromPointer<T>(ppv)!;
        if (arguments != null)
        {
            unsafe
            {
                foreach (var arg in arguments)
                {
                    var value = PWSTR.From(arg).Value;
                    args.Object.AddArguments((nint)(&value), 1);
                }
            }
        }
        return args;
    }

    private static IComObject<IDxcCompilerArgs> CreateArguments(string entrypoint, string target, string? sourceName = null, params string[] arguments)
    {
        var args = new List<string>();
        if (!string.IsNullOrWhiteSpace(sourceName))
        {
            args.Add(sourceName);
        }

        args.Add("-E");
        args.Add(entrypoint);
        args.Add("-T");
        args.Add(target);

        if (arguments != null)
        {
            args.AddRange(arguments);
        }

        return CreateCompilerArguments(args);
    }

    public static DxcResult Compile(string source, string entrypoint, string target, string? sourceName = null, params string[] arguments) => new(Compile<IDxcResult>(source, entrypoint, target, sourceName, arguments));
    public static DxcResult<T> Compile<T>(string source, string entrypoint, string target, string? sourceName = null, params string[] arguments) where T : IDxcResult
    {
        ArgumentNullException.ThrowIfNull(source);
        ArgumentNullException.ThrowIfNull(entrypoint);
        ArgumentNullException.ThrowIfNull(target);

        using var args = CreateArguments(entrypoint, target, sourceName, arguments);
        var bytes = Encoding.UTF8.GetBytes(source);
        return Compile<T>(bytes, Encoding.UTF8, args.Object);
    }

    public static DxcResult Compile(byte[] bytes, Encoding encoding, string entrypoint, string target, string? sourceName = null, params string[] arguments) => new(Compile<IDxcResult>(bytes, encoding, entrypoint, target, sourceName, arguments));
    public static DxcResult<T> Compile<T>(byte[] bytes, Encoding encoding, string entrypoint, string target, string? sourceName = null, params string[] arguments) where T : IDxcResult
    {
        ArgumentNullException.ThrowIfNull(bytes);
        ArgumentNullException.ThrowIfNull(encoding);
        ArgumentNullException.ThrowIfNull(entrypoint);
        ArgumentNullException.ThrowIfNull(target);

        using var args = CreateArguments(entrypoint, target, sourceName, arguments);
        return Compile<T>(bytes, encoding, args.Object);
    }

    private static DxcResult<T> Compile<T>(byte[] bytes, Encoding encoding, IDxcCompilerArgs args) where T : IDxcResult
    {
        using var compiler = CreateCompiler();
        var src = new DxcBuffer
        {
            Ptr = bytes.AsPointer(),
            Size = bytes.Length(),
            Encoding = (uint)encoding.CodePage
        };
        compiler.Object.Compile(src, args.GetArguments(), args.GetCount(), null, typeof(T).GUID, out var ppv).ThrowOnError();
        return new DxcResult<T>(ComObject.FromPointer<T>(ppv)!);
    }

    public static DxcResult CompileFromResource(string resourceName, string entrypoint, string target, Assembly? assembly = null, params string[] arguments) => new(CompileFromResource<IDxcResult>(resourceName, entrypoint, target, assembly, arguments));
    public static DxcResult<T> CompileFromResource<T>(string resourceName, string entrypoint, string target, Assembly? assembly = null, params string[] arguments) where T : IDxcResult
    {
        ArgumentNullException.ThrowIfNull(resourceName);
        ArgumentNullException.ThrowIfNull(entrypoint);
        ArgumentNullException.ThrowIfNull(target);

        assembly ??= Assembly.GetEntryAssembly()!;
        using var stream = assembly.GetManifestResourceStream(resourceName) ?? throw new ArgumentException($"Cannot find resource named '{resourceName}' in assembly '{assembly.FullName}'.", nameof(resourceName));
        using var reader = new StreamReader(stream, Encoding.UTF8, true);
        reader.Peek();
        var encoding = reader.CurrentEncoding;
        var str = reader.ReadToEnd();
        var bytes = encoding.GetBytes(str);
        using var args = CreateArguments(entrypoint, target, resourceName, arguments);
        return Compile<T>(bytes, encoding, args.Object);
    }
}
