namespace DirectN.Extensions.Utilities;

public sealed class ColorProfile
{
    private static readonly Lazy<IReadOnlyList<ColorProfile>> _localProfiles = new(() => GetColorProfiles(null, false), true);
    public static IReadOnlyList<ColorProfile> LocalProfiles => _localProfiles.Value;

    private static readonly Lazy<string?> _colorDirectoryPath = new(() => GetColorDirectoryPath(null), true);
    public static string? LocalColorDirectoryPath => _colorDirectoryPath.Value;

    private ColorProfile(nint handle)
    {
        if (!Functions.GetColorProfileHeader(handle, out var header))
            throw new Win32Exception(Marshal.GetLastWin32Error());

        Size = header.phSize;
        CmmType = header.phCMMType;
        VersionMajor = (header.phVersion >> 24) & 0xFF;
        VersionMinor = (header.phVersion >> 20) & 0x0F;
        VersionBugfix = (header.phVersion >> 16) & 0x0F;
        Class = header.phClass;
        DataColorSpace = header.phDataColorSpace;
        ConnectionSpace = header.phConnectionSpace;
        Signature = header.phSignature;
        Platform = header.phPlatform;
        Flags = (ColorProfileFlags)header.phProfileFlags;
        Manufacturer = header.phManufacturer;
        Model = header.phModel;
        var span = ((ReadOnlySpan<uint>)header.phAttributes);
        var atts = new List<ColorProfileAttribute>();
        for (var i = 0; i < InlineArrayUInt32_2.Length; i++)
        {
            atts.Add((ColorProfileAttribute)span[i]);
        }

        Attributes = [.. atts];
        Creator = header.phCreator;
        RenderingIntent = header.phRenderingIntent;
        Illuminant = header.phIlluminant;

        uint size = 0;
        if (!Functions.GetColorProfileFromHandle(handle, 0, ref size))
        {
            var gle = Marshal.GetLastWin32Error();
            if (gle != (int)WIN32_ERROR.ERROR_INSUFFICIENT_BUFFER)
                throw new Win32Exception(gle);
        }

        Profile = new byte[size];
        using var pinnedProfile = new PinnedArray<byte>(Profile);
        unsafe
        {
            if (!Functions.GetColorProfileFromHandle(handle, pinnedProfile.Pointer, ref size))
                throw new Win32Exception(Marshal.GetLastWin32Error());
        }

        var elements = new List<ColorProfileElement>();
        var localizedStrings = new Dictionary<string, List<string>>(StringComparer.OrdinalIgnoreCase);
        Functions.GetCountColorProfileElements(handle, out var count);
        for (uint i = 0; i < count; i++)
        {
            if (Functions.GetColorProfileElementTag(handle, i + 1, out var tag))
            {
                size = 0;
                Functions.GetColorProfileElement(handle, tag, 0, ref size, 0, out _);
                if (size > 0)
                {
                    var bytes = new byte[size];
                    using var pinnedBytes = new PinnedArray<byte>(bytes);
                    if (Functions.GetColorProfileElement(handle, tag, 0, ref size, pinnedBytes.Pointer, out _))
                    {
                        elements.Add(new ColorProfileElement(tag, bytes));

                        int offset;
                        // https://www.color.org/specification/ICC.1-2022-05.pdf
                        var type = Get4BytesString(BitConverter.ToInt32(bytes, 0));
                        switch (type)
                        {
                            case "text":
                                offset = 8;
                                switch (tag)
                                {
                                    case 0x63707274: // cprt
                                        Copyright = getAscii(bytes.Length - 8);
                                        break;

                                    case 0x74617267: // targ
                                        RegisteredCharacterization = getAscii(bytes.Length - 8);
                                        break;
                                }
                                break;

                            case "desc":
                                // textDescriptionType, search the old ICC doc for "textDescriptionType" at https://www.color.org/icc32.pdf.
                                offset = 8;
                                var n = getInt32();

                                // always consume the ascii invariant description so the unicode fields that follow stay aligned, even for a tag that is not one of the ones we surface.
                                var descAscii = n > 0 ? getAscii(n) : null;

                                UnicodeLanguageCode = getInt32();
                                var m = getInt32();
                                var descUnicode = m > 0 ? getUnicode(m) : null;

                                // the unicode part is the localizable description, fall back to the ascii invariant.
                                var descText = descUnicode ?? descAscii;
                                switch (tag)
                                {
                                    case 0x64657363: // desc
                                        Description = descText;
                                        break;

                                    case 0x646d6e64: // dmnd
                                        ManufacturerDescription = descText;
                                        break;

                                    case 0x646d6464: // dmdd
                                        ModelDescription = descText;
                                        break;

                                    case 0x76756564: // vued
                                        ViewingCondition = descText;
                                        break;
                                }
                                break;

                            case "mluc": // multiLocalizedUnicodeType
                                offset = 8;
                                var records = getInt32();
                                var recordSize = getInt32(); // record size
                                if (recordSize != 12 || records == 0)
                                    break;

                                // among the localized records, prefer en-US, then any English, then the first one, instead of letting the last record in the file win.
                                string? best = null;
                                var bestRank = int.MaxValue;
                                for (var ir = 0; ir < records; ir++)
                                {
                                    var languageCode = Get2BytesString(BitConverter.ToInt16(bytes, offset));
                                    offset += 2;
                                    var countryCode = Get2BytesString(BitConverter.ToInt16(bytes, offset));
                                    offset += 2;
                                    var lcid = languageCode + "-" + countryCode;

                                    var sl = getInt32();
                                    var stringOffset = getInt32();
                                    var s = getBEUnicode(stringOffset, sl / 2);
                                    if (s == null)
                                        break;

                                    if (!localizedStrings.TryGetValue(lcid, out var list))
                                    {
                                        list = [];
                                        localizedStrings.Add(lcid, list);
                                    }

                                    list.Add(s);

                                    var rank = string.Equals(lcid, "en-US", StringComparison.OrdinalIgnoreCase) ? 0
                                        : languageCode != null && languageCode.StartsWith("en", StringComparison.OrdinalIgnoreCase) ? 1
                                        : 2;
                                    if (best == null || rank < bestRank)
                                    {
                                        best = s;
                                        bestRank = rank;
                                    }
                                }

                                if (best != null)
                                {
                                    switch (tag)
                                    {
                                        case 0x63707274: // cprt
                                            Copyright = best;
                                            break;

                                        case 0x74617267: // targ
                                            RegisteredCharacterization = best;
                                            break;

                                        case 0x64657363: // desc
                                            Description = best;
                                            break;

                                        case 0x646d6e64: // dmnd
                                            ManufacturerDescription = best;
                                            break;

                                        case 0x646d6464: // dmdd
                                            ModelDescription = best;
                                            break;

                                        case 0x76756564: // vued
                                            ViewingCondition = best;
                                            break;
                                    }
                                }
                                break;

                            default:
                                break;
                        }

                        int getInt32() => (bytes[offset++] << 24) | (bytes[offset++] << 16) | (bytes[offset++] << 8) | bytes[offset++];
                        string? getAscii(int len)
                        {
                            var s = TrimTerminatingZeros(Encoding.ASCII.GetString(bytes, offset, len));
                            offset += len;
                            return s;
                        }

                        string? getBEUnicode(int offset, int len)
                        {
                            var s = TrimTerminatingZeros(Encoding.BigEndianUnicode.GetString(bytes, offset, len * 2));
                            return s;
                        }

                        string? getUnicode(int len)
                        {
                            var byteLen = len * 2;
                            if (byteLen <= 0 || offset + byteLen > bytes.Length)
                                return null;

                            var start = offset;
                            offset += byteLen;

                            // some encoders prepend a UTF-16BE byte order mark (FE FF), skip it so it does not leak into the string as a leading U+FEFF.
                            if (byteLen >= 2 && bytes[start] == 0xFE && bytes[start + 1] == 0xFF)
                            {
                                start += 2;
                                byteLen -= 2;
                            }

                            return TrimTerminatingZeros(Encoding.BigEndianUnicode.GetString(bytes, start, byteLen));
                        }
                    }
                }
            }
        }

        Elements = elements.AsReadOnly();
        LocalizedStrings = localizedStrings.ToDictionary(kv => kv.Key, kv => (IReadOnlyList<string>)kv.Value.AsReadOnly());
    }

    private ColorProfile(nint handle, string filePath)
        : this(handle)
    {
        FilePath = filePath;
    }

    public string? FilePath { get; } // null if loaded from memory
    public byte[] Profile { get; }
    public uint Size { get; }
    public uint VersionMajor { get; }
    public uint VersionMinor { get; }
    public uint VersionBugfix { get; }
    public string VersionString => $"{VersionMajor}.{VersionMinor}.{VersionBugfix}";
    public uint CmmType { get; }
    public uint Class { get; }
    public uint DataColorSpace { get; }
    public uint ConnectionSpace { get; }
    public uint Signature { get; }
    public uint Platform { get; }
    public uint Manufacturer { get; }
    public uint Model { get; }
    public uint Creator { get; }
    public ColorProfileAttribute[] Attributes { get; }
    public uint RenderingIntent { get; }
    public CIEXYZ Illuminant { get; }
    public ColorProfileFlags Flags { get; }
    public string? CmmTypeString => Get4BytesStringBE(CmmType);
    public string? ClassString => Get4BytesStringBE(Class);
    public string? DataColorSpaceString => Get4BytesStringBE(DataColorSpace);
    public string? ConnectionSpaceString => Get4BytesStringBE(ConnectionSpace);
    public string? SignatureString => Get4BytesStringBE(Signature);
    public string? PlatformString => Get4BytesStringBE(Platform);
    public string? ManufacturerString => Get4BytesStringBE(Manufacturer);
    public string? ModelString => Get4BytesStringBE(Model);
    public string? CreatorString => Get4BytesStringBE(Creator);

    public int UnicodeLanguageCode { get; }
    public string? Description { get; }
    public string? ManufacturerDescription { get; }
    public string? ModelDescription { get; }
    public string? ViewingCondition { get; }
    public string? Copyright { get; }
    public string? RegisteredCharacterization { get; }

    public IReadOnlyList<ColorProfileElement> Elements { get; }
    public IReadOnlyDictionary<string, IReadOnlyList<string>> LocalizedStrings { get; }

    public string DisplayName
    {
        get
        {
            if (!string.IsNullOrWhiteSpace(Description))
                return Description;

            if (FilePath != null)
                return Path.GetFileNameWithoutExtension(FilePath);

            return string.Empty;
        }
    }

    public override string ToString() => DisplayName;

    private static string? TrimTerminatingZeros(string str)
    {
        if (str == null || str.Length == 0)
            return null;

        var i = str.Length - 1;
        for (; i >= 0; i--)
        {
            if (str[i] != 0 && !char.IsWhiteSpace(str[i]))
                break;
        }
        if (i == str.Length - 1)
            return str;

        return str[..(i + 1)];
    }

    public static string? Get4BytesString(int value)
    {
        try
        {
            return TrimTerminatingZeros(Encoding.ASCII.GetString(BitConverter.GetBytes(value)));
        }
        catch
        {
            return null;
        }
    }

    public static string? Get4BytesStringBE(uint value)
    {
        try
        {
            return TrimTerminatingZeros(Encoding.ASCII.GetString([.. BitConverter.GetBytes(value).Reverse()]));
        }
        catch
        {
            return null;
        }
    }


    public static string? Get2BytesString(short value)
    {
        try
        {
            return TrimTerminatingZeros(Encoding.ASCII.GetString(BitConverter.GetBytes(value)));
        }
        catch
        {
            return null;
        }
    }

    public static string? Get2BytesStringBE(short value)
    {
        try
        {
            return TrimTerminatingZeros(Encoding.ASCII.GetString([.. BitConverter.GetBytes(value).Reverse()]));
        }
        catch
        {
            return null;
        }
    }

    public static ColorProfile? FromStream(Stream stream, bool throwOnError = true)
    {
        ArgumentNullException.ThrowIfNull(stream);
        using var bytes = new MemoryStream();
        stream.CopyTo(bytes);
        return FromMemory(bytes.ToArray(), throwOnError);
    }

    public static ColorProfile? FromMemory(byte[]? buffer, bool throwOnError = true)
    {
        if (buffer == null)
            return null;

        using var pinnedBuffer = new PinnedArray<byte>(buffer);
        var prof = new PROFILE
        {
            dwType = PROFILE_MEMBUFFER,
            pProfileData = pinnedBuffer.Pointer,
            cbDataSize = buffer.Length()
        };

        var handle = Functions.OpenColorProfileA(prof, PROFILE_READ, FILE_SHARE_READ, OPEN_EXISTING);
        if (handle == 0)
        {
            if (throwOnError)
                throw new Win32Exception(Marshal.GetLastWin32Error());

            return null;
        }

        try
        {
            return new ColorProfile(handle);
        }
        catch when (!throwOnError)
        {
            return null;
        }
        finally
        {
            Functions.CloseColorProfile(handle);
        }
    }

    public static ColorProfile? FromFileName(string fileName, string? machineName = null, bool throwOnError = true)
    {
        ArgumentNullException.ThrowIfNull(fileName);
        string path;
        if (fileName.IndexOfAny([Path.DirectorySeparatorChar, Path.AltDirectorySeparatorChar]) < 0)
        {
            var dirPath = GetColorDirectoryPath(machineName);
            if (dirPath == null)
                return null;

            path = Path.Combine(dirPath, fileName);
        }
        else
        {
            if (machineName != null)
                throw new ArgumentException(null, nameof(machineName));

            path = Path.GetFullPath(fileName);
        }

        var name = Path.GetFileName(path);

        // note this is ANSI only
        var ptr = Marshal.StringToCoTaskMemAnsi(name);
        try
        {
            var prof = new PROFILE
            {
                dwType = PROFILE_FILENAME,
                pProfileData = ptr,
                cbDataSize = (uint)(name.Length + 1)
            };
            var handle = Functions.OpenColorProfileA(prof, PROFILE_READ, FILE_SHARE_READ, OPEN_EXISTING);
            if (handle == 0)
            {
                if (throwOnError)
                    throw new Win32Exception(Marshal.GetLastWin32Error());

                return null;
            }

            try
            {
                return new ColorProfile(handle, path);
            }
            catch when (!throwOnError)
            {
                return null;
            }
            finally
            {
                Functions.CloseColorProfile(handle);
            }
        }
        finally
        {
            Marshal.FreeCoTaskMem(ptr);
        }
    }

    public static string? GetColorDirectoryPath(string? machineName = null)
    {
        uint size = 0;
        Functions.GetColorDirectoryW(PWSTR.From(machineName), PWSTR.Null, ref size);
        if (size == 0)
            return null;

        using var buffer = new AllocPwstr(size);
        Functions.GetColorDirectoryW(PWSTR.From(machineName), buffer, ref size);
        return buffer.ToString();
    }

    public static string GetStandardColorSpaceProfile()
    {
        const int sRGB = 0x73524742; //  'sRGB'
        uint size = 0;
        Functions.GetStandardColorSpaceProfileW(PWSTR.Null, sRGB, PWSTR.Null, ref size);
        using var buffer = new AllocPwstr(size);
        Functions.GetStandardColorSpaceProfileW(PWSTR.Null, sRGB, buffer, ref size);
        var s = buffer.ToString();
        if (string.IsNullOrWhiteSpace(s))
            return string.Empty;

        if (Path.IsPathRooted(s))
            return s;

        var dir = GetColorDirectoryPath();
        if (string.IsNullOrEmpty(dir))
            return string.Empty;

        return Path.Combine(dir, s);
    }

    public static IReadOnlyList<ColorProfile> GetColorProfiles(string? machineName = null, bool throwOnProfileError = true)
    {
        var list = new List<ColorProfile>();
        uint size = 0;
        unsafe
        {
            var enumType = new ENUMTYPEW
            {
                dwSize = (uint)sizeof(ENUMTYPEW),
                dwVersion = ENUM_TYPE_VERSION
            };

            var count = 0;
            var pc = &count;
            if (!Functions.EnumColorProfilesW(PWSTR.From(machineName), enumType, 0, ref size, (nint)pc))
            {
                var gle = Marshal.GetLastWin32Error();
                if (gle != (int)WIN32_ERROR.ERROR_INSUFFICIENT_BUFFER)
                    throw new Win32Exception(gle);
            }

            if (count > 0)
            {
                var bytes = new byte[size];
                using var pinnedBytes = new PinnedArray<byte>(bytes);
                var ptr = pinnedBytes.Pointer;
                if (!Functions.EnumColorProfilesW(PWSTR.From(machineName), enumType, ptr, ref size, (nint)pc))
                    throw new Win32Exception(Marshal.GetLastWin32Error());

                do
                {
                    var str = Marshal.PtrToStringUni(ptr);
                    if (string.IsNullOrEmpty(str))
                        break;

                    var profile = FromFileName(str, machineName, throwOnProfileError);
                    if (profile != null)
                    {
                        list.Add(profile);
                    }
                    ptr += (str.Length + 1) * 2;
                }
                while (true);
            }
        }
        return list;
    }

    private const int ENUM_TYPE_VERSION = 0x300;
    private const int PROFILE_FILENAME = 1;
    private const int PROFILE_MEMBUFFER = 2;
    private const int PROFILE_READ = 1;
    private const int FILE_SHARE_READ = 1;
    private const int OPEN_EXISTING = 3;
}
