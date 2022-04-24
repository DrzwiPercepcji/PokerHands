using PokerHands.Helpers;
using NUnit.Framework;
using System.Collections.Generic;

namespace PokerHands.Tests.Helpers
{
	public class ShuffleHelperTest
	{
		private IList<int> list1;
		private IList<string> list2;

		[SetUp]
		public void SetUp()
		{
			list1 = new List<int> { 1, 2, 3, 4, 5 };
			list2 = new List<string> { "one", "two", "three", "four", "five" };
		}

		[Test]
		[Retry(3)]
		public void ShouldComplexShuffleList()
		{
			var newList1 = new List<int>(list1);
			var newList2 = new List<string>(list2);

			ShuffleHelper.ComplexShuffle(newList1);
			ShuffleHelper.ComplexShuffle(newList2);

			Assert.That(list1.Count == newList1.Count);
			Assert.That(list2.Count == newList2.Count);

			Assert.That(list1[0] != newList1[0] || list1[1] != newList1[1] || list1[2] != newList1[2] || list1[3] != newList1[3] || list1[4] != newList1[4]);
			Assert.That(list2[0] != newList2[0] || list2[1] != newList2[1] || list2[2] != newList2[2] || list2[3] != newList2[3] || list2[4] != newList2[4]);
		}

		[Test]
		[Retry(3)]
		public void ShouldSingleShuffleList()
		{
			var newList1 = new List<int>(list1);
			var newList2 = new List<string>(list2);

			ShuffleHelper.SingleShuffle(newList1);
			ShuffleHelper.SingleShuffle(newList2);

			Assert.That(list1.Count == newList1.Count);
			Assert.That(list2.Count == newList2.Count);

			Assert.That(list1[0] != newList1[0] || list1[1] != newList1[1] || list1[2] != newList1[2] || list1[3] != newList1[3] || list1[4] != newList1[4]);
			Assert.That(list2[0] != newList2[0] || list2[1] != newList2[1] || list2[2] != newList2[2] || list2[3] != newList2[3] || list2[4] != newList2[4]);
		}
	}
}
