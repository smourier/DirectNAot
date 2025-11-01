#nullable enable
namespace DirectN;

public partial struct KSMIDILOOPED_EVENT : IValueGet<HANDLE>
{
    public HANDLE WriteEvent;
    
    readonly HANDLE IValueGet<HANDLE>.GetValue() => WriteEvent;
    readonly object? IValueGet.GetValue() => WriteEvent;
}
