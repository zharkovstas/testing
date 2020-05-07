using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;

namespace Samples.Antipatterns
{
	[TestFixture, Explicit]
	public class Stack4_Tests_Fixed
	{
		[Test]
		public void Pop_ReturnsLastPushedItem()
		{
			var stack = new Stack<int>(new[] {1, 2, 3, 4, 5});
			var result = stack.Pop();
			Assert.AreEqual(5, result);
		}

		[Test]
		public void Pop_DoesNotClearStack()
		{
			var stack = new Stack<int>(new[] {1, 2, 3, 4, 5});
			stack.Pop();
			Assert.IsTrue(stack.Any());
		}

		[Test]
		public void Pop_DecreasesCount()
		{
			var stack = new Stack<int>(new[] {1, 2, 3, 4, 5});
			stack.Pop();
			Assert.AreEqual(4, stack.Count);
		}

		[Test]
		public void Pop_LeavesSecondToLastItemOnTheTop()
		{
			var stack = new Stack<int>(new[] {1, 2, 3, 4, 5});
			stack.Pop();
			Assert.AreEqual(4, stack.Peek());
		}

		[Test]
		public void Pop_LeavesOtherItemsInPlace()
		{
			var stack = new Stack<int>(new[] {1, 2, 3, 4, 5});
			stack.Pop();
			Assert.AreEqual(new[] {4, 3, 2, 1}, stack.ToArray());
		}
	}
}