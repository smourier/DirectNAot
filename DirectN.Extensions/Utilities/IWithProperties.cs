namespace DirectN.Utilities
{
    public interface IWithProperties
    {
        ConcurrentDictionary<string, object?> Properties { get; }
        void OnPropertyChanged(string propertyName);
    }
}
