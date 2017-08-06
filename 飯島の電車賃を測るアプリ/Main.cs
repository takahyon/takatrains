using AppKit;
using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace 飯島の電車賃を測るアプリ
{
    static class MainClass
    {
        internal static readonly object w;

        static void Main(string[] args)
        {
            NSApplication.Init();
            NSApplication.Main(args);
			String week;
			String off;
			Console.WriteLine("お疲れ様です！今月の電車賃を計算しますね！");
			Console.WriteLine("今月の出勤日数を(平日,休日)のように入力してください！");
			week = Console.ReadLine();
			Console.WriteLine("平日" + week);
			off = Console.ReadLine();
			Console.WriteLine("休日" + off);
			Console.WriteLine("計算します");
			traincost w = new traincost(week, off);

			w.getResult();
			Console.WriteLine("お疲れ様でした!");
			Console.ReadKey();

		}
    }
}
