namespace DirectN.Extensions.Utilities;

[TypeConverter(typeof(CursorConverter))]
public class Cursor : IEquatable<Cursor>
{
    public Cursor(int id)
    {
        Handle = Functions.LoadCursorW(HINSTANCE.Null, new PWSTR { Value = id });
        Id = id;
    }

    public int Id { get; }
    public HCURSOR Handle { get; }

    public static readonly Cursor AppStarting = new(32650);
    public static readonly Cursor Arrow = new(32512);
    public static readonly Cursor Cross = new(32515);
    public static readonly Cursor Hand = new(32649);
    public static readonly Cursor Help = new(32651);
    public static readonly Cursor IBeam = new(32513);
    public static readonly Cursor No = new(32648);
    public static readonly Cursor Size = new(32640);
    public static readonly Cursor SizeAll = new(32646);
    public static readonly Cursor SizeNESW = new(32643);
    public static readonly Cursor SizeNS = new(32645);
    public static readonly Cursor SizeNWSE = new(32642);
    public static readonly Cursor SizeWE = new(32644);
    public static readonly Cursor UpArrow = new(32516);
    public static readonly Cursor Wait = new(32514);

    private static void Set(HCURSOR handle) => Functions.SetCursor(handle);
    public static void Set(Cursor? cursor)
    {
        if (cursor == null || cursor.Handle.Value == 0)
        {
            Functions.SetCursor(Arrow.Handle);
        }
        else
        {
            Set(cursor.Handle);
        }
    }

    public override int GetHashCode() => Handle.GetHashCode();
    public override string ToString() => Id + " " + Handle;
    public override bool Equals(object? obj) => Equals(obj as Cursor);
    public bool Equals(Cursor? other) => other != null && (Id == other.Id || Handle == other.Handle);
}

public class CursorConverter : TypeConverter
{
    public override bool CanConvertFrom(ITypeDescriptorContext? context, Type type) => type == typeof(string);
    public override object? ConvertFrom(ITypeDescriptorContext? context, CultureInfo? culture, object? value)
    {
        if (value is string s && s != null && int.TryParse(s, out var i))
            return new Cursor(i);

        return null;
    }

    public override object? ConvertTo(ITypeDescriptorContext? context, CultureInfo? culture, object? value, Type destinationType)
    {
        if (destinationType == typeof(string))
        {
            if (value is Cursor cursor)
                return cursor.Id.ToString();

            return null;
        }

        return base.ConvertTo(context, culture, value, destinationType);
    }
}
