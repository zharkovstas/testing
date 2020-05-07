using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;

namespace Samples.Antipatterns
{
	[TestFixture, Explicit]
	public class Stack2_Tests_Fixed
	{
		[Test]
		public void TestPushPop()
		{
			var stack = new Stack<int>();
			stack.Push(10);
			stack.Push(20);
			stack.Push(30);

			var values = new List<int>();
			while (stack.Any())
				values.Add(stack.Pop());
			Assert.That(values, Is.EqualTo(new[] {30, 20, 10}));
		}
	}
}