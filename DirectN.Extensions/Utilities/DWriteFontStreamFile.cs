namespace DirectN.Extensions.Utilities;

public sealed class DWriteFontStreamFile : DWriteFontFile, IDisposable
{
    private object? _sync = new();
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
        var sync = Volatile.Read(ref _sync);
        if (sync == null)
            return;

        lock (sync)
        {
            if (Interlocked.Exchange(ref _sync, null) == null)
                return;

            if (Owned)
            {
                Stream?.Dispose();
            }
        }
    }

    public override byte[] ReadFileFragment(long offset, int length, out int read)
    {
        ArgumentOutOfRangeException.ThrowIfNegative(offset);
        ArgumentOutOfRangeException.ThrowIfNegative(length);
        read = 0;
        var sync = Volatile.Read(ref _sync);
        ObjectDisposedException.ThrowIf(sync == null, this);
        lock (sync)
        {
            ObjectDisposedException.ThrowIf(_sync == null, this);
            Stream ??= File.OpenRead(FilePath ?? throw new InvalidOperationException());
            if (offset > Stream.Length || length > Stream.Length - offset)
                throw new ArgumentOutOfRangeException(nameof(length));

            Stream.Seek(offset, SeekOrigin.Begin);
            var buffer = new byte[length];
            Stream.ReadExactly(buffer);
            read = length;
            return buffer;
        }
    }
}