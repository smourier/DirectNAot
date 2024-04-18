namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct PrintNamedProperty
{
    public PWSTR propertyName;
    public PrintPropertyValue propertyValue;
}
