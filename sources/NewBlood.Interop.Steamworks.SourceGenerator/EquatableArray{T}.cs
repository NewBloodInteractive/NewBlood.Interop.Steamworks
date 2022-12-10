using System.Collections.Immutable;
using System.Diagnostics.CodeAnalysis;

namespace NewBlood.Interop.Steamworks.SourceGenerator;

internal readonly struct EquatableArray<T> : IEquatable<EquatableArray<T>>
    where T : IEquatable<T>
{
    public EquatableArray(ImmutableArray<T> array)
    {
        Array = array;
    }

    public ImmutableArray<T> Array { get; }

    public int Length => Array.Length;

    public ref readonly T this[int index] => ref Array.ItemRef(index);

    public bool IsEmpty => Array.IsEmpty;

    public bool Equals(EquatableArray<T> array)
    {
        return AsSpan().SequenceEqual(array.AsSpan());
    }

    public ReadOnlySpan<T> AsSpan()
    {
        return Array.AsSpan();
    }

    public override bool Equals([NotNullWhen(true)] object? obj)
    {
        return obj is EquatableArray<T> array && Equals(this, array);
    }

    public override int GetHashCode()
    {
        HashCode hashCode = default;

        foreach (T item in Array)
            hashCode.Add(item);

        return hashCode.ToHashCode();
    }

    public static implicit operator ImmutableArray<T>(EquatableArray<T> array) => array.Array;

    public static implicit operator EquatableArray<T>(ImmutableArray<T> array) => new(array);
}
