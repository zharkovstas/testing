using System.Collections.Generic;
using NUnit.Framework;

namespace Samples.Antipatterns
{
	[TestFixture, Explicit]
	public class Stack1_Tests_Fixed
	{
		[Test]
		public void Test()
		{
			var lines = new[]
			{
				new {command = "push", value = "1"},
				new {command = "pop", value = "1"},
				new {command = "push", value = "2"},
				new {command = "push", value = "3"},
				new {command = "pop", value = "3"},
				new {command = "pop", value = "2"}
			};

			//var lines = File.ReadAllLines(@"data.txt")
			//var lines = Resources.data.Split(new[] {"\r\n"}, StringSplitOptions.RemoveEmptyEntries);

			var stack = new Stack<string>();
			foreach (var line in lines)
			{
				if (line.command == "push")
					stack.Push(line.value);
				else
					Assert.AreEqual(line.value, stack.Pop());
			}
		}
	}
}