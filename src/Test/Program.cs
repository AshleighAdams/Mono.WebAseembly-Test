using System;
using System.Collections.Concurrent;

namespace Test
{
	internal class TestClass
	{
	}

	internal static class Program
	{
		private static void Main()
		{
			var bag = new ConcurrentBag<TestClass>();
			bool got = bag.TryTake(out var value);

			Console.WriteLine($"got: {got} value: {value}");
		}
	}
}
