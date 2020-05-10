using System;

public class Class1
{
	public Class1()
	{
		var numbers = new List<int>() { 1, 2, 2, 1, 2, 3 };
		numbers.Sort();

		var result = new Dictionary<int, int>();
		for (int i = 1; i < numbers.Count; i++)
		{
			if (numbers[i] == numbers[i - 1])
			{
				if (!result.Keys.Contains(numbers[i]))
					result.Add(numbers[i], 1);
				else result[numbers[i]]++;

			}
		}
		foreach (var x in result.Keys)
			if (result[x] > 1) Console.WriteLine("Число {0} встречается {1} раз.", x, result[x]);
	}
}
