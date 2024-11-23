namespace ProjectEuler;

public readonly struct Fraction
{
	public readonly int Num;
	public readonly int Den;

	public Fraction(int num, int den)
	{
		if (den == 0) throw new DivideByZeroException();
		Num = num;
		Den = den;
	}

	public Fraction(int num) : this(num, 1) { }
	public static implicit operator Fraction(int num) => new(num);

	public static Fraction operator +(Fraction a)
		=> a;

	public static Fraction operator -(Fraction a)
		=> new(-a.Num, a.Den);

	public static Fraction operator +(Fraction a, Fraction b)
		=> new(a.Num * b.Den + b.Num * a.Den, a.Den * b.Den);

	public static Fraction operator -(Fraction a, Fraction b)
		=> a + (-b);

	public static Fraction operator *(Fraction a, Fraction b)
		=> new(a.Num * b.Num, a.Den * b.Den);

	public static Fraction operator /(Fraction a, Fraction b)
	{
		if (b.Num == 0) throw new DivideByZeroException();
		return new(a.Num * b.Den, a.Den * b.Num);
	}

	public override string ToString()
		=> $"{Num}/{Den}";
}
