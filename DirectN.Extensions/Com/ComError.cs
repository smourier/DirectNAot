namespace DirectN.Extensions.Com;

public static class ComError
{
    public static void SetError(string description, [CallerMemberName] string? source = null)
    {
        ArgumentNullException.ThrowIfNull(description);
        Functions.CreateErrorInfo(out var infoObj).ThrowOnError();
        using var info = new ComObject<ICreateErrorInfo>(infoObj);
        info.Object.SetDescription(PWSTR.From(description)).ThrowOnError();
        if (source != null)
        {
            info.Object.SetSource(PWSTR.From(source)).ThrowOnError();
        }

        var ei = info.As<IErrorInfo>()!;
        Functions.SetErrorInfo(0, ei.Object).ThrowOnError();
    }

    public static Exception? GetError(HRESULT errorCode) => GetError((uint)errorCode.Value);
    public static Exception? GetError(uint errorCode = 0x80004005)
    {
        Functions.GetErrorInfo(0, out var infoObj);
        if (infoObj == null)
            return null;

        using var info = new ComObject<IErrorInfo>(infoObj);
        info.Object.GetDescription(out var description);
        var descString = description.ToString();
        BSTR.Dispose(ref description);

        info.Object.GetSource(out var source);
        var sourceString = source.ToString();
        BSTR.Dispose(ref source);

        info.Object.GetHelpFile(out var help);
        var helpString = help.ToString();
        BSTR.Dispose(ref help);

        if (!string.IsNullOrWhiteSpace(sourceString))
        {
            if (string.IsNullOrWhiteSpace(descString))
            {
                descString = sourceString;
            }
            else
            {
                descString = sourceString + ": " + descString;
            }
        }

        COMException error;
        if (string.IsNullOrWhiteSpace(descString))
        {
            error = new COMException(null, (int)errorCode);
        }
        else
        {
            error = new COMException(descString, (int)errorCode);
        }

        if (!string.IsNullOrWhiteSpace(helpString))
        {
            error.HelpLink = helpString;
        }

        return error;
    }
}
