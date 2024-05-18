namespace DirectNAot.Extensions.Utilities;

public static class AssemblyUtilities
{
    public static string? GetCompany() => GetCompany(null);
    public static string? GetCompany(this Assembly? assembly) => (assembly ?? Assembly.GetEntryAssembly())?.GetCustomAttribute<AssemblyCompanyAttribute>()?.Company;

    public static string? GetDescription() => GetDescription(null);
    public static string? GetDescription(this Assembly? assembly) => (assembly ?? Assembly.GetEntryAssembly())?.GetCustomAttribute<AssemblyDescriptionAttribute>()?.Description;

    public static string? GetProduct() => GetProduct(null);
    public static string? GetProduct(this Assembly? assembly) => (assembly ?? Assembly.GetEntryAssembly())?.GetCustomAttribute<AssemblyProductAttribute>()?.Product;

    public static string? GetConfiguration() => GetConfiguration(null);
    public static string? GetConfiguration(this Assembly? assembly) => (assembly ?? Assembly.GetEntryAssembly())?.GetCustomAttribute<AssemblyConfigurationAttribute>()?.Configuration;

    public static string? GetTitle() => GetTitle(null);
    public static string? GetTitle(this Assembly? assembly) => (assembly ?? Assembly.GetEntryAssembly())?.GetCustomAttribute<AssemblyTitleAttribute>()?.Title;

    public static string? GetInformationalVersion() => GetInformationalVersion(null);
    public static string? GetInformationalVersion(this Assembly? assembly) => (assembly ?? Assembly.GetEntryAssembly())?.GetCustomAttribute<AssemblyInformationalVersionAttribute>()?.InformationalVersion;

    public static string? GetFileVersion() => GetFileVersion(null);
    public static string? GetFileVersion(this Assembly? assembly) => (assembly ?? Assembly.GetEntryAssembly())?.GetCustomAttribute<AssemblyFileVersionAttribute>()?.Version;

    public static string? GetCopyright() => GetCopyright(null);
    public static string? GetCopyright(this Assembly? assembly) => (assembly ?? Assembly.GetEntryAssembly())?.GetCustomAttribute<AssemblyCopyrightAttribute>()?.Copyright;

    public static Guid? GetGuid() => GetGuid(null); // note we use executing assembly here
    public static Guid? GetGuid(this Assembly? assembly)
    {
        var sguid = (assembly ?? Assembly.GetExecutingAssembly())?.GetCustomAttribute<GuidAttribute>()?.Value;
        if (sguid == null || !Guid.TryParse(sguid, out var guid))
            return null;

        return guid;
    }

    public static string? GetMetatadaAttribute(string key) => GetMetatadaAttribute(null, key);
    public static string? GetMetatadaAttribute(this Assembly? assembly, string key)
    {
        ArgumentNullException.ThrowIfNull(key);
        return (assembly ?? Assembly.GetEntryAssembly())?.GetCustomAttributes<AssemblyMetadataAttribute>()?.FirstOrDefault(a => a.Key.EqualsIgnoreCase(key))?.Value;
    }
}
