using System.Numerics;

namespace ProjectEuler;

public readonly struct Fraction<T>
	where T : IBinaryInteger<T>
{
	public readonly T Num;
	public readonly T Den;

	public Fraction(T num, T den)
	{
		if (den == T.Zero) throw new DivideByZeroException();
		Num = num;
		Den = den;
	}

	public Fraction(T num) : this(num, T.One) { }

	public static implicit operator Fraction<T>(T num) => new(num);
	public static implicit operator Fraction<T>(int i) => new(T.CreateChecked(i));

	public override string ToString() => $"{Num}/{Den}";

	public static Fraction<T> operator +(Fraction<T> a) => a;
	public static Fraction<T> operator -(Fraction<T> a) => new(-a.Num, a.Den);

	public static Fraction<T> operator +(Fraction<T> a, Fraction<T> b)
		=> new(a.Num * b.Den + b.Num * a.Den, a.Den * b.Den);

	public static Fraction<T> operator -(Fraction<T> a, Fraction<T> b)
		=> a + (-b);

	public static Fraction<T> operator *(Fraction<T> a, Fraction<T> b)
		=> new(a.Num * b.Num, a.Den * b.Den);

	public static Fraction<T> operator /(Fraction<T> a, Fraction<T> b)
	{
		if (b.Num == T.Zero) throw new DivideByZeroException();
		return new(a.Num * b.Den, a.Den * b.Num);
	}
}
