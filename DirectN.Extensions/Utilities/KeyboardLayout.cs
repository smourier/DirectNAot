namespace DirectN.Extensions.Utilities;

public sealed class KeyboardLayout
{
    public string Tip { get; private set; } = null!;
    public string? EnglishName { get; private set; }
    public string? LocalizedName { get; private set; }
    public string? File { get; private set; } = null!;
    public string? Id { get; private set; }

    public override string ToString() => EnglishName ?? Tip;

    // https://archives.miloush.net/michkap/archive/2004/12/05/275231.html
    public static KeyboardLayout GetKeyboardLayout(string tip) // like "0000040c"
    {
        ArgumentNullException.ThrowIfNull(tip);
        var layout = new KeyboardLayout { Tip = tip, };
        using var key = Registry.LocalMachine.OpenSubKey($@"SYSTEM\CurrentControlSet\Control\Keyboard Layouts\{tip}", false);
        if (key != null)
        {
            layout.EnglishName = (key.GetValue("Layout Text") as string).Nullify();
            layout.File = (key.GetValue("Layout File") as string).Nullify();
            layout.Id = (key.GetValue("Layout Id") as string).Nullify();
            var dn = (key.GetValue("Layout Display Name") as string).Nullify();
            if (dn != null)
            {
                using var pwstr = new AllocPwstr(512);
                Functions.SHLoadIndirectString(PWSTR.From(dn), pwstr, pwstr.SizeInChars, 0);
                layout.LocalizedName = pwstr.ToString();
            }
        }
        return layout;
    }
}
