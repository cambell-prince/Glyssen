﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using ProtoScript;

namespace ProtoScriptTests
{
	[TestFixture]
	class BookScriptTests
	{
		private int m_curSetupChapter = 1;

		[Test]
		public void GetVerseText_NoBlocks_ReturnsEmptyString()
		{
			var bookScript = new BookScript("MRK", new List<Block>());
			Assert.AreEqual(String.Empty, bookScript.GetVerseText(1, 1));
		}

		[Test]
		public void GetVerseText_BlocksConsistEntirelyOfRequestedVerse_ReturnsBlockContentsWithoutVerseNumber()
		{
			var mrkBlocks = new List<Block>();
			mrkBlocks.Add(NewChapterBlock(1));
			mrkBlocks.Add(NewSingleVersePara(1));
			mrkBlocks.Add(NewSingleVersePara(2));
			mrkBlocks.Add(NewSingleVersePara(3, "This is it!"));
			mrkBlocks.Add(NewSingleVersePara(4));
			mrkBlocks.Add(NewSingleVersePara(5));
			var bookScript = new BookScript("MRK", mrkBlocks);
			Assert.AreEqual("This is it!", bookScript.GetVerseText(1, 3));
		}

		[Test]
		public void GetVerseText_FirstVerseInBlockIsRequestedVerse_ReturnsVerseContents()
		{
			var mrkBlocks = new List<Block>();
			mrkBlocks.Add(NewChapterBlock(1));
			mrkBlocks.Add(NewSingleVersePara(1));
			mrkBlocks.Add(NewSingleVersePara(2, "This is it!").AddVerse(3).AddVerse(4).AddVerse(5));
			mrkBlocks.Add(NewSingleVersePara(6));
			var bookScript = new BookScript("MRK", mrkBlocks);
			Assert.AreEqual("This is it!", bookScript.GetVerseText(1, 2));
		}

		[Test]
		public void GetVerseText_SubsequentVerseInBlockIsRequestedVerse_ReturnsVerseContents()
		{
			var mrkBlocks = new List<Block>();
			mrkBlocks.Add(NewChapterBlock(1));
			mrkBlocks.Add(NewSingleVersePara(1));
			mrkBlocks.Add(NewSingleVersePara(2).AddVerse(3).AddVerse(4, "This is it!").AddVerse(5));
			mrkBlocks.Add(NewSingleVersePara(6));
			var bookScript = new BookScript("MRK", mrkBlocks);
			Assert.AreEqual("This is it!", bookScript.GetVerseText(1, 4));
		}

		[Test]
		public void GetVerseText_VerseInLastBlockInChapterIsRequested_ReturnsVerseContents()
		{
			var mrkBlocks = new List<Block>();
			mrkBlocks.Add(NewChapterBlock(1));
			mrkBlocks.Add(NewSingleVersePara(1));
			mrkBlocks.Add(NewSingleVersePara(2).AddVerse(3).AddVerse(4, "This is it!").AddVerse(5));
			var bookScript = new BookScript("MRK", mrkBlocks);
			Assert.AreEqual("This is it!", bookScript.GetVerseText(1, 4));
		}

		[Test]
		public void GetVerseText_RequestedVerseInChapterTwo_ReturnsVerseContents()
		{
			var mrkBlocks = new List<Block>();
			mrkBlocks.Add(NewChapterBlock(1));
			mrkBlocks.Add(NewSingleVersePara(1).AddVerse(2).AddVerse(3).AddVerse(4));
			mrkBlocks.Add(NewSingleVersePara(5).AddVerse(6).AddVerse(7));
			mrkBlocks.Add(NewChapterBlock(2));
			mrkBlocks.Add(NewSingleVersePara(1));
			mrkBlocks.Add(NewSingleVersePara(2).AddVerse(3));
			mrkBlocks.Add(NewSingleVersePara(4).AddVerse(5, "This is it!").AddVerse(6));
			mrkBlocks.Add(NewSingleVersePara(7).AddVerse(8));
			var bookScript = new BookScript("MRK", mrkBlocks);
			Assert.AreEqual("This is it!", bookScript.GetVerseText(2, 5));
		}

		[Test]
		public void GetVerseText_RequestedVerseIsPartOfVerseBridge_ReturnsVerseBridgeContents()
		{
			var mrkBlocks = new List<Block>();
			mrkBlocks.Add(NewChapterBlock(1));
			mrkBlocks.Add(NewSingleVersePara(1));
			mrkBlocks.Add(NewSingleVersePara(2).AddVerse(3).AddVerse("4-6", "This is it!"));
			mrkBlocks.Add(NewSingleVersePara(7));
			var bookScript = new BookScript("MRK", mrkBlocks);
			Assert.AreEqual("This is it!", bookScript.GetVerseText(1, 5));
		}

		[Test]
		public void GetVerseText_RequestedVerseSpansBlocks_ContentsJoinedToGetAllVerseText()
		{
			var mrkBlocks = new List<Block>();
			mrkBlocks.Add(NewChapterBlock(1));
			mrkBlocks.Add(NewSingleVersePara(1));
			mrkBlocks.Add(NewSingleVersePara(2).AddVerse(3, "This is it!"));
			var block = new Block("q1", m_curSetupChapter, 3);
			block.BlockElements.Add(new ScriptText("This is more of it."));
			mrkBlocks.Add(block);
			block = new Block("q2", m_curSetupChapter, 3);
			block.BlockElements.Add(new ScriptText("This is the rest of it."));
			mrkBlocks.Add(block);
			mrkBlocks.Add(NewSingleVersePara(4));
			var bookScript = new BookScript("MRK", mrkBlocks);
			Assert.AreEqual("This is it!" + Environment.NewLine + "This is more of it." + Environment.NewLine + "This is the rest of it.", bookScript.GetVerseText(1, 3));
		}

		private Block NewChapterBlock(int chapterNum)
		{
			var block = new Block("c", chapterNum);
			block.BlockElements.Add(new ScriptText(chapterNum.ToString()));
			m_curSetupChapter = chapterNum;
			return block;
		}

		private Block NewSingleVersePara(int verseNum, string text = null)
		{
			return new Block("p", m_curSetupChapter, verseNum).AddVerse(verseNum, text);
		}
	}

	internal static class BlockTestExtensions
	{
		internal static Block AddVerse(this Block block, int verseNum, string text = null)
		{
			return block.AddVerse(verseNum.ToString(), text);
		}

		internal static Block AddVerse(this Block block, string verse, string text = null)
		{
			if (text == null)
				text = RandomString();
			block.BlockElements.Add(new Verse(verse));
			block.BlockElements.Add(new ScriptText(text));
			return block;
		}

		// ENHANCE: Consider moving this to Palaso test utilities
		internal static string RandomString()
		{
			var chars = " ABCDEF GHIJK LMNOP QRSTU VWXYZ abcdef ghijk lmnop qrstu vwxyz ,.!?";
			var randomString = new StringBuilder();
			var random = new Random();
			var length = random.Next(80);

			for (int i = 0; i < length; i++)
				randomString.Append(chars[random.Next(chars.Length)]);

			return randomString.ToString();
		}
	}
}