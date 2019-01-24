using System;
using System.Text;
using StandardLib;

namespace NETCoreApp
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.OutputEncoding = Encoding.UTF8;

			Console.WriteLine($"Hello World! {EmojiText.SMILEY}");

			Console.WriteLine("Press <Enter> to exit");
			Console.ReadLine();
		}
	}
}
