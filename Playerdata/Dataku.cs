using System;
using System.Collections.Generic;
using System.Text;

namespace Playerdata
{
    [Serializable]
    public class Dataku
    {
        public string playername;
        public int coin, level, score;

        public Dataku() { }

        public Dataku(string name, int coin, int level, int score)
        {
            this.playername = name;
            this.coin = coin;
            this.level = level;
            this.score = score;
        }

        public void InputData()
        {
            Console.Write("Masukkan nama pemain: ");
            playername = Console.ReadLine();

            Console.Write("Masukkan koin pemain: ");
            coin = int.Parse(Console.ReadLine());

            Console.Write("Masukkan level pemain: ");
            level = int.Parse(Console.ReadLine());

            Console.Write("Masukkan skor pemain: ");
            score = int.Parse(Console.ReadLine());
     
        }

        public void ShowData()
        {
            Console.WriteLine(playername);
            Console.WriteLine(coin);
            Console.WriteLine(level);
            Console.WriteLine(score);
        }

        static void Main() { }
    }
}