namespace DirectN.Extensions.Utilities;

public sealed class DWriteFontStreamFile : DWriteFontFile, IDisposable
{
    public DWriteFontStreamFile(string filePath)
    {
        LastWriteTime = File.GetLastWriteTime(filePath);
        FilePath = filePath;
        Owned = true;
    }

    public DWriteFontStreamFile(Stream stream, bool owned = true)
    {
        ArgumentNullException.ThrowIfNull(stream);
        Stream = stream;
        Owned = owned;
    }

    public bool Owned { get; }
    public Stream? Stream { get; private set; }
    public string? FilePath { get; } // may be null if pure stream

    public override long? Length
    {
        get
        {
            if (FilePath != null)
                return new FileInfo(FilePath).Length;

            return Stream?.Length;
        }
    }

    public override string ToString() => FilePath ?? base.ToString() ?? string.Empty;

    public void Dispose()
    {
        if (Owned)
        {
            Stream?.Dispose();
        }
    }

    public override byte[] ReadFileFragment(long offset, int length, out int read)
    {
        if (FilePath == null)
            throw new InvalidOperationException();

        Stream ??= File.OpenRead(FilePath);
        Stream.Seek(offset, SeekOrigin.Begin);
        var buffer = new byte[length];
        read = Stream.Read(buffer, 0, buffer.Length);
        return buffer;
    }
}
