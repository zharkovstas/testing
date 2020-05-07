using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;

namespace Samples.Antipatterns
{
	[TestFixture, Explicit]
	public class Stack3_Tests_Fixed
	{
		[Test]
		public void IsEmpty_AfterCreation()
		{
			var stack = new Stack<int>();
			Assert.IsFalse(stack.Any());
		}

		[Test]
		public void IsEmpty_AfterPushAndPop()
		{
			var stack = new Stack<int>();
			stack.Push(1);
			stack.Pop();
			Assert.IsFalse(stack.Any());
		}

		[Test]
		public void Count_ReturnsItemCount()
		{
			var stack = new Stack<int>();
			stack.Push(1);
			stack.Push(2);
			stack.Push(3);
			Assert.AreEqual(3, stack.Count);
		}

		[Test]
		public void Pop_ReturnsItemsInReverseOrder()
		{
			var stack = new Stack<int>();
			for (var i = 0; i < 1000; i++)
				stack.Push(i);
			for (var i = 1000; i > 0; i--)
				Assert.AreEqual(i - 1, stack.Pop());
		}
	}
}