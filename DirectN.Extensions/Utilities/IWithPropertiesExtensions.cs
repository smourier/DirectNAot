namespace DirectN.Extensions.Utilities;

public static class IWithPropertiesExtensions
{
    public static T? GetProperty<T>(this IWithProperties? instance, string propertyName, T? defaultValue = default)
    {
        ArgumentNullException.ThrowIfNull(propertyName);
        if (instance == null)
            return defaultValue;

        if (!instance.Properties.TryGetValue(propertyName, out var value))
            return default;

        return Conversions.ChangeType(value, defaultValue, CultureInfo.InvariantCulture);
    }

    public static void SetProperty<T>(this IWithProperties? instance, string propertyName, T? value)
    {
        ArgumentNullException.ThrowIfNull(propertyName);
        if (instance == null)
            return;

        var changed = true;
        instance.Properties.AddOrUpdate(propertyName, value, (key, old) =>
        {
            if (!Equals(old, value))
                return value;

            changed = false;
            return old;
        });

        if (changed)
        {
            instance.OnPropertyChanged(propertyName);
        }
    }
}
