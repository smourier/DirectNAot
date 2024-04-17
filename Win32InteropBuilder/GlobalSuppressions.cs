using System.Diagnostics.CodeAnalysis;

[assembly: SuppressMessage("Style", "IDE0066:Convert switch statement to expression", Justification = "I don't like it")]
[assembly: SuppressMessage("Interoperability", "SYSLIB1054:Use 'LibraryImportAttribute' instead of 'DllImportAttribute' to generate P/Invoke marshalling code at compile time", Justification = "Not needed here")]
[assembly: SuppressMessage("Usage", "CA2219:Do not raise exceptions in finally clauses", Justification = "It's ok")]
