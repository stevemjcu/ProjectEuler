using System.Numerics;

namespace ProjectEuler;

public readonly struct Fraction<T>
	where T : IBinaryInteger<T>
{
	private readonly T Num => Numerator;
	private readonly T Den => Denominator;

	public readonly T Numerator;
	public readonly T Denominator;

	public Fraction(T numerator, T denominator)
	{
		if (denominator == T.Zero) throw new DivideByZeroException();
		Numerator = numerator;
		Denominator = denominator;
	}

	public Fraction(T numerator) : this(numerator, T.One) { }

	public static implicit operator Fraction<T>(T numerator) => new(numerator);
	public static implicit operator Fraction<T>(int i) => new(T.CreateChecked(i));

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

	public override string ToString() => $"{Num}/{Den}";

	public Fraction<T> Simplify()
	{
		var gcd = Utils.GCD(Num, Den);
		return new(Num / gcd, Den / gcd);
	}
}
