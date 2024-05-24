namespace DirectN;

public static class ComError
{
    public static void SetError(string description, [CallerMemberName] string? source = null)
    {
        ArgumentNullException.ThrowIfNull(description);
        Functions.CreateErrorInfo(out var info).ThrowOnError();
        info.SetDescription(PWSTR.From(description)).ThrowOnError();
        if (source != null)
        {
            info.SetSource(PWSTR.From(source)).ThrowOnError();
        }

        var ei = (IErrorInfo)info;
        Functions.SetErrorInfo(0, ei).ThrowOnError();
    }

    public static Exception? GetError()
    {
        Functions.GetErrorInfo(0, out var info);
        if (info == null)
            return null;

        info.GetDescription(out var description);
        var descString = description.ToString();
        BSTR.Dispose(ref description);

        info.GetSource(out var source);
        var sourceString = source.ToString();
        BSTR.Dispose(ref source);

        info.GetHelpFile(out var help);
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
            error = new COMException();
        }
        else
        {
            error = new COMException(descString);
        }

        if (!string.IsNullOrWhiteSpace(helpString))
        {
            error.HelpLink = helpString;
        }

        return error;
    }
}
