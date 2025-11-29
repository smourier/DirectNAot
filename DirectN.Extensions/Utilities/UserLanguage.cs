namespace DirectN.Extensions.Utilities;

public sealed class UserLanguage
{
    public string Name { get; internal set; } = null!;
    public IReadOnlyList<string> InputMethodTips { get; internal set; } = null!;
    public KeyboardLayout? KeyboardLayout { get; internal set; }

    public override string ToString() => Name;
}
