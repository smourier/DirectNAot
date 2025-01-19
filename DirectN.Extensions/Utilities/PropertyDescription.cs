namespace DirectN.Extensions.Utilities;

[SupportedOSPlatform("windows6.0.6000")]
public sealed class PropertyDescription : InterlockedComObject<IPropertyDescription>, IComparable, IComparable<PropertyDescription>, IEquatable<PropertyDescription>
{
    private IComObject<IPropertyDescriptionSearchInfo>? _searchInfo;
    private readonly Lazy<IReadOnlyList<PropertyEnumType>> _enumTypes;

    public PropertyDescription(IComObject<IPropertyDescription> description)
        : base(description)
    {
        ArgumentNullException.ThrowIfNull(description);
        _searchInfo = ComObject.As<IPropertyDescriptionSearchInfo>();
        CanonicalName = GetString(NativeObject.GetCanonicalName);
        DisplayName = GetString(NativeObject.GetDisplayName);
        EditInvitation = GetString(NativeObject.GetEditInvitation);
        var pos = CanonicalName?.LastIndexOf('.');
        if (!pos.HasValue || pos < 0)
        {
            Namespace = null;
            Name = CanonicalName;
        }
        else
        {
            Name = CanonicalName![(pos.Value + 1)..];
            Namespace = CanonicalName[..pos.Value];
        }

        if (_searchInfo != null)
        {
            SearchProjectionString = GetString(_searchInfo.Object.GetProjectionString);
        }

        _enumTypes = new(GetEnumTypes);
    }

    public string? CanonicalName { get; }
    public string? Namespace { get; }
    public string? Name { get; }
    public string? DisplayName { get; }
    public string? EditInvitation { get; }
    public string? SearchProjectionString { get; }
    public uint DefaultColumnWidth { get { NativeObject.GetDefaultColumnWidth(out var width); return width; } }
    public bool HasSearchInfo => _searchInfo != null;
    public uint? SearchMaxSize { get { if (_searchInfo == null) return null; _searchInfo.Object.GetMaxSize(out var size); return size; } }
    public PROPDESC_SEARCHINFO_FLAGS? SearchInfoFlags { get { if (_searchInfo == null) return null; _searchInfo.Object.GetSearchInfoFlags(out var flags); return flags; } }
    public PROPDESC_COLUMNINDEX_TYPE? SearchColumnIndexType { get { if (_searchInfo == null) return null; _searchInfo.Object.GetColumnIndexType(out var type); return type; } }
    public PROPERTYKEY PropertyKey { get { NativeObject.GetPropertyKey(out var pk); return pk; } }
    public VARENUM PropertyType { get { NativeObject.GetPropertyType(out var pt); return (VARENUM)pt; } }
    public SHCOLSTATE ColumnState { get { NativeObject.GetColumnState(out var state); return (SHCOLSTATE)state; } }
    public PROPDESC_AGGREGATION_TYPE AggregationType { get { NativeObject.GetAggregationType(out var type); return type; } }
    public PROPDESC_DISPLAYTYPE DisplayType { get { NativeObject.GetDisplayType(out var type); return type; } }
    public PROPDESC_GROUPING_RANGE GroupingRange { get { NativeObject.GetGroupingRange(out var range); return range; } }
    public PROPDESC_RELATIVEDESCRIPTION_TYPE RelativeDescriptionType { get { NativeObject.GetRelativeDescriptionType(out var type); return type; } }
    public PROPDESC_SORTDESCRIPTION SortDescription { get { NativeObject.GetSortDescription(out var description); return description; } }
    public PROPDESC_VIEW_FLAGS ViewFlags { get { NativeObject.GetViewFlags(out var flags); return flags; } }
    public PROPDESC_TYPE_FLAGS TypeFlags { get { NativeObject.GetTypeFlags(PROPDESC_TYPE_FLAGS.PDTF_MASK_ALL, out var flags); return flags; } }
    public PROPDESC_CONDITION_TYPE ConditionType { get { NativeObject.GetConditionType(out var type, out _); return type; } }
    public CONDITION_OPERATION ConditionOperation { get { NativeObject.GetConditionType(out _, out var op); return op; } }
    [UnconditionalSuppressMessage("AOT", "IL3050:Calling members annotated with 'RequiresDynamicCodeAttribute' may break functionality when AOT compiling.")]
    public Type ClrPropertyType => GetClrPropertyType(PropertyType);
    public IReadOnlyList<PropertyEnumType> EnumTypes => _enumTypes.Value;
    private ReadOnlyCollection<PropertyEnumType> GetEnumTypes()
    {
        var enumTypes = new List<PropertyEnumType>();
        NativeObject.GetEnumTypeList(typeof(IPropertyEnumTypeList).GUID, out var listUnk);
        using var list = Com.ComObject.FromPointer<IPropertyEnumTypeList>(listUnk);
        if (list != null)
        {
            list.Object.GetCount(out var count);
            for (uint i = 0; i < count; i++)
            {
                list.Object.GetAt(i, typeof(IPropertyEnumType).GUID, out var eUnk);
                using var type = Com.ComObject.FromPointer<IPropertyEnumType>(eUnk); // note we dispose what we send
                if (type != null)
                {
                    enumTypes.Add(new PropertyEnumType(type));
                }
            }
        }
        return enumTypes.AsReadOnly();
    }

    [SupportedOSPlatform("windows6.1")]
    public string? GetImageReferenceForValue(PROPVARIANT value)
    {
        ArgumentNullException.ThrowIfNull(value);
        if (NativeObject is not IPropertyDescription2 pd2)
            return null;

        pd2.GetImageReferenceForValue(value, out var ptr);
        if (ptr.Value == 0)
            return null;

        return ptr.Value == 0 ? null : ptr.ToString();
    }

    [SupportedOSPlatform("windows6.1")]
    public PropertyDescription? GetRelatedProperty(string relation)
    {
        ArgumentNullException.ThrowIfNull(relation);
        if (NativeObject is not IPropertyDescriptionRelatedPropertyInfo rp)
            return null;

        rp.GetRelatedProperty(PWSTR.From(relation), typeof(IPropertyDescription).GUID, out var unk);
        var pd = Com.ComObject.FromPointer<IPropertyDescription>(unk);
        return pd == null ? null : new PropertyDescription(pd);
    }

    public PropertyDescription? GetSortByAlias()
    {
        if (NativeObject is not IPropertyDescriptionAliasInfo ai)
            return null;

        ai.GetSortByAlias(typeof(IPropertyDescription).GUID, out var unk);
        var pd = Com.ComObject.FromPointer<IPropertyDescription>(unk);
        return pd == null ? null : new PropertyDescription(pd);
    }

    public IEnumerable<PropertyDescription> GetAdditionalSortByAliases()
    {
        if (NativeObject is not IPropertyDescriptionAliasInfo ai)
            yield break;

        ai.GetAdditionalSortByAliases(typeof(IPropertyDescriptionList).GUID, out var listUnk);
        using var list = Com.ComObject.FromPointer<IPropertyDescriptionList>(listUnk);
        if (list == null)
            yield break;

        list.Object.GetCount(out var count);
        for (uint i = 0; i < count; i++)
        {
            list.Object.GetAt(i, typeof(IPropertyDescription).GUID, out var pdUnk);
            var pd = Com.ComObject.FromPointer<IPropertyDescription>(pdUnk);
            if (pd != null)
            {
                var prop = new PropertyDescription(pd);
                yield return prop;
            }
        }
    }

    public string? GetSortDescriptionLabel(bool descending)
    {
        NativeObject.GetSortDescriptionLabel(descending, out var ptr);
        return ptr.Value == 0 ? null : ptr.ToString();
    }

    public bool TryCoerceToCanonicalValue(object? value, out object? canonicalValue)
    {
        using var pv = new PropVariant(value);
        var detached = pv.Detached;
        var hr = NativeObject.CoerceToCanonicalValue(ref detached);
        if (hr != 0)
        {
            canonicalValue = null;
            return false;
        }

        canonicalValue = pv.Value;
        return true;
    }

    public string? FormatForDisplay(object? value, PROPDESC_FORMAT_FLAGS flags)
    {
        using var pv = new PropVariant(value);
        NativeObject.FormatForDisplay(pv.Detached, flags, out var ptr);
        return ptr.Value == 0 ? null : ptr.ToString();
    }

    protected override void Dispose(bool disposing)
    {
        _searchInfo = null;
    }

    public override string ToString() => CanonicalName ?? string.Empty;
    public override int GetHashCode() => StringComparer.Ordinal.GetHashCode(CanonicalName ?? string.Empty);
    int IComparable.CompareTo(object? obj) => CompareTo(obj as PropertyDescription);
    public int CompareTo(PropertyDescription? other)
    {
        ArgumentNullException.ThrowIfNull(other);
        return (CanonicalName ?? string.Empty).CompareTo(other.CanonicalName);
    }

    public override bool Equals(object? obj) => Equals(obj as PropertyDescription);
    public bool Equals(PropertyDescription? other) => string.Equals(CanonicalName, other?.CanonicalName, StringComparison.Ordinal);

    public static bool operator ==(PropertyDescription item1, PropertyDescription item2)
    {
        if (item1 is null)
            return item2 is null;

        return item1.Equals(item2);
    }

    public static bool operator !=(PropertyDescription item1, PropertyDescription item2)
    {
        if (item1 is null)
            return item2 is not null;

        return !item1.Equals(item2);
    }

    public static IEnumerable<PropertyDescription> EnumeratePropertyDescriptions(PROPDESC_ENUMFILTER filter = PROPDESC_ENUMFILTER.PDEF_ALL)
    {
        Functions.PSEnumeratePropertyDescriptions(filter, typeof(IPropertyDescriptionList).GUID, out var listUnk);
        using var list = Com.ComObject.FromPointer<IPropertyDescriptionList>(listUnk);
        if (list == null)
            yield break;

        list.Object.GetCount(out var count);
        for (uint i = 0; i < count; i++)
        {
            list.Object.GetAt(i, typeof(IPropertyDescription).GUID, out var pdUnk);
            var pd = Com.ComObject.FromPointer<IPropertyDescription>(pdUnk);
            if (pd != null)
            {
                var prop = new PropertyDescription(pd);
                yield return prop;
            }
        }
    }

    public static PropertyDescription? FromCanonicalName(string canonicalName)
    {
        ArgumentNullException.ThrowIfNull(canonicalName);
        var hr = Functions.PSGetPropertyDescriptionByName(PWSTR.From(canonicalName), typeof(IPropertyDescription).GUID, out var unk);
        var pd = Com.ComObject.FromPointer<IPropertyDescription>(unk);
        return pd != null ? new PropertyDescription(pd) : null;
    }

    public static PropertyDescription? FromPropertyKey(PROPERTYKEY propertyKey)
    {
        Functions.PSGetPropertyDescription(propertyKey, typeof(IPropertyDescription).GUID, out var unk);
        var pd = Com.ComObject.FromPointer<IPropertyDescription>(unk);
        return pd != null ? new PropertyDescription(pd) : null;
    }

    [RequiresDynamicCode("Dynamic is required if type is a VT_VECTOR")]
    public static Type GetClrPropertyType(VARENUM type)
    {
        if ((type & VARENUM.VT_VECTOR) == VARENUM.VT_VECTOR)
            return Array.CreateInstance(GetClrPropertyType(type & ~VARENUM.VT_VECTOR), 0).GetType();

        switch (type)
        {
            case VARENUM.VT_BLOB:
                return typeof(byte[]);

            case VARENUM.VT_LPSTR:
            case VARENUM.VT_LPWSTR:
            case VARENUM.VT_BSTR:
                return typeof(string);

            case VARENUM.VT_BOOL:
                return typeof(bool);

            case VARENUM.VT_UI1:
                return typeof(byte);

            case VARENUM.VT_UI2:
                return typeof(ushort);

            case VARENUM.VT_UINT:
            case VARENUM.VT_HRESULT:
            case VARENUM.VT_ERROR:
            case VARENUM.VT_UI4:
                return typeof(uint);

            case VARENUM.VT_UI8:
                return typeof(ulong);

            case VARENUM.VT_I1:
                return typeof(sbyte);

            case VARENUM.VT_I2:
                return typeof(short);

            case VARENUM.VT_INT:
            case VARENUM.VT_I4:
                return typeof(int);

            case VARENUM.VT_CY:
            case VARENUM.VT_I8:
                return typeof(long);

            case VARENUM.VT_DATE:
                return typeof(DateTime);

            case VARENUM.VT_DECIMAL:
                return typeof(decimal);

            case VARENUM.VT_CLSID:
                return typeof(Guid);

            case VARENUM.VT_FILETIME:
                return typeof(System.Runtime.InteropServices.ComTypes.FILETIME);

            case VARENUM.VT_INT_PTR:
                return typeof(IntPtr);

            case VARENUM.VT_UINT_PTR:
                return typeof(UIntPtr);

            case VARENUM.VT_R4:
                return typeof(float);

            case VARENUM.VT_R8:
                return typeof(double);

            case VARENUM.VT_STREAM:
                return typeof(Stream);

            default:
                return typeof(object);
        }
    }

    private delegate HRESULT GetStringFn(out PWSTR ptr);
    private static string? GetString(GetStringFn func)
    {
        func(out var ptr);
        return ptr.Value == 0 ? null : ptr.ToString();
    }
}
