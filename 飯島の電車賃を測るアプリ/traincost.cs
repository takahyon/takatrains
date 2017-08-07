using System;


namespace 飯島の電車賃を測るアプリ
{
    public class traincost
    {
		int weekday;
		int offday;
        int weekdayto;
        int offdayto;
        const int train = 280;
        const int bikePark = 100;
        int total;
        public traincost(String w, String o)
        {
            weekday = Int32.Parse(w);
            offday = Int32.Parse(o);
			weekdayto = weekday * train;
			offdayto = offday * train + bikePark;
			total = weekdayto + offdayto;
        }

        public void getResult(){
            Console.Write($"今月の電車賃は平日"+ weekday +"日で"+weekdayto+"円.("+$"{weekday}x{ train}+{ weekday}x{ bikePark})");
            Console.WriteLine($"休日" + offday + "日で" + offdayto+"円, ("+$"{offday}x{train}+{offday}x{bikePark})" );
			Console.WriteLine("合計は" + total + "円です！");

		}
    }
}
