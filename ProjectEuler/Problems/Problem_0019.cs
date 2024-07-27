namespace ProjectEuler.Problems;

public class Problem_0019 : Problem
{
	public DateOnly Start = DateOnly.Parse("01/01/1901");
	public DateOnly End = DateOnly.Parse("12/31/2000");

	/// <returns>The number of Sundays which fell on the 1st of the month in the 20th century.</returns>
	public override object Solve()
	{
		return Range(Start, End)
			.Where(d => d.Day == 1)
			.Count(d => d.DayOfWeek == DayOfWeek.Sunday);
	}

	public static IEnumerable<DateOnly> Range(DateOnly start, DateOnly end)
	{
		for (var d = start; d <= end; d = d.AddDays(1))
		{
			yield return d;
		}
	}
}