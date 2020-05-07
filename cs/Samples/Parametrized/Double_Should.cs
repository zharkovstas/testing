using System;
using System.Collections.Generic;
using System.Globalization;
using NUnit.Framework;

namespace Samples.Parametrized
{
	[TestFixture]
	public class Double_Should
	{
		[TestCase("123", ExpectedResult = 123, TestName = "integer")]
		[TestCase("1.1", ExpectedResult = 1.1, TestName = "fraction")]
		[TestCase("1.1e1", ExpectedResult = 1.1e1, TestName = "scientific with positive exp")]
		[TestCase("1.1e-1", ExpectedResult = 1.1e-1, TestName = "scientific with negative exp")]
		[TestCase("-0.1", ExpectedResult = -0.1, TestName = "negative fraction")]
		public double Parse_WithInvariantCulture(string input)
		{
			return double.Parse(input, CultureInfo.InvariantCulture);
		}
	}

	[TestFixture]
	public class DateTime_Should
	{
		[Test, TestCaseSource(nameof(DayOfWeekTestCases))]
		public DayOfWeek ReturnDayOfWeek(DateTime dateTime)
		{
			return dateTime.DayOfWeek;
		}

		public static IEnumerable<TestCaseData> DayOfWeekTestCases()
		{
			return new[]
			{
				new TestCaseData(new DateTime(2020, 05, 08))
					.Returns(DayOfWeek.Friday)
					.SetName("when 08.05.20 returns friday"),

				new TestCaseData(new DateTime(2020, 05, 05))
					.Returns(DayOfWeek.Tuesday)
					.SetName("when 05.05.20 returns tuesday")
			};
		}
	}
}