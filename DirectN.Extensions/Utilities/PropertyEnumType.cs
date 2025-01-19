namespace DirectN.Extensions.Utilities;

[SupportedOSPlatform("windows6.0.6000")]
public sealed class PropertyEnumType : InterlockedComObject<IPropertyEnumType>
{
    public PropertyEnumType(IComObject<IPropertyEnumType> type)
        : base(type)
    {
        ArgumentNullException.ThrowIfNull(type);
        NativeObject.GetDisplayText(out var ptr);
        DisplayText = ptr.ToString();
        NativeObject.GetEnumType(out var etype);
        EnumType = etype;

        NativeObject.GetValue(out var pvar);
        using var pv = PropVariant.Attach(ref pvar);
        {
            Value = pv.Value;
        }

        NativeObject.GetRangeMinValue(out pvar);
        using var pv2 = PropVariant.Attach(ref pvar);
        {
            RangeMinValue = pv2.Value;
        }

        NativeObject.GetRangeSetValue(out pvar);
        using var pv3 = PropVariant.Attach(ref pvar);
        {
            RangeSetValue = pv3.Value;
        }

        if (OperatingSystem.IsWindowsVersionAtLeast(6, 1))
        {
            var type2 = type.As<IPropertyEnumType2>();
            if (type2 != null)
            {
                type2.Object.GetImageReference(out var ptr2);
                ImageReference = ptr2.ToString();
                if (ImageReference != null)
                {
                    ImageReferencePath = Icon.PathParseIconLocation(ImageReference, out var index);
                    ImageReferenceIndex = index;
                }
            }
        }
    }

    public string? DisplayText { get; }
    public PROPENUMTYPE EnumType { get; }
    public object? RangeMinValue { get; }
    public object? RangeSetValue { get; }
    public object? Value { get; }
    public string? ImageReference { get; }
    public string? ImageReferencePath { get; }
    public int? ImageReferenceIndex { get; }
    public override string ToString() => DisplayText ?? string.Empty;
}
