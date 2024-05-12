using DirectNAot.Extensions.Com;
using DirectNAot.Extensions.Utilities;

namespace DirectNAot.Extensions;

public static class IPropertyBag2Extensions
{
    public static void Write(this IComObject<IPropertyBag2> bag, IEnumerable<KeyValuePair<string, object>> properties) => Write(bag?.Object!, properties);
    public static void Write(this IPropertyBag2 bag, IEnumerable<KeyValuePair<string, object>> properties)
    {
        ArgumentNullException.ThrowIfNull(bag);
        if (properties == null)
            return;

        foreach (var kv in properties)
        {
            var i = GetIndex(bag, kv.Key);
            if (i < 0) // ?
                continue;

            // read info
            var values = new VARIANT[1];
            var props = new PROPBAG2[1];
            using var name = new Pwstr(kv.Key);
            props[0].pstrName = name;
            bag.GetPropertyInfo((uint)i, 1, props, out _).ThrowOnError();

            var value = props[0].vt.ChangeType(kv.Value);
            using var v = new Variant(value);
            values[0] = v.Detached;
            bag.Write(1, props, values).ThrowOnError();
        }
    }

    private static int GetIndex(IPropertyBag2 bag, string name)
    {
        if (bag == null || name == null)
            return -1;

        bag.CountProperties(out var count);
        for (var i = 0; i < count; i++)
        {
            var props = new PROPBAG2[1];
            using var p = new Pwstr(name);
            props[0].pstrName = p;
            bag.GetPropertyInfo((uint)i, 1, props, out _).ThrowOnError();
            if (props[0].pstrName.ToString().EqualsIgnoreCase(name))
                return i;
        }
        return -1;
    }
}
