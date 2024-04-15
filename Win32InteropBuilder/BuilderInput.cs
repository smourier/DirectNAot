using System;

namespace Win32InteropBuilder
{
    public abstract class BuilderInput<T>
    {
        public BuilderInput(string input)
        {
            ArgumentNullException.ThrowIfNull(input);
            if (input.StartsWith('!'))
            {
                IsReverse = true;
                input = input[1..];
            }
            else if (input.EndsWith('*'))
            {
                IsWildcard = true;
                input = input[..^1];
            }

            Input = input;
        }

        public string Input { get; }
        public bool IsWildcard { get; }
        public bool IsReverse { get; }

        public override string ToString() => Input;

        public abstract bool Matches(T type);
    }
}
