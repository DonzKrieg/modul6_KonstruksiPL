using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul6_103022330150
{
    public class SayaTubeVideo
    {
        private int id;
        private string title;
        private int playCount;

        public SayaTubeVideo(string title)
        {
            if (string.IsNullOrEmpty(title))
                throw new ArgumentException("Judul tidak boleh kosong!");
            if (title.Length > 200)
                throw new ArgumentException("Judul video tidak boleh lebih dari 200 karakter!");

            Random random = new Random();
            this.id = random.Next(10000, 99999);
            this.title = title;
            this.playCount = 0;
        }

        public void IncreasePlayCount(int count)
        {
            if (count < 0)
                throw new ArgumentException("Play count tidak boleh negatif!");
            if (count > 25000000)
                throw new ArgumentException("Play count maksimal 25000000 per panggilan!");

            try
            {
                checked
                {
                    playCount += count;
                }
            }
            catch (OverflowException)
            {
                Console.WriteLine("ERROR: Terjadi OverFlow karena penambahan paly count!");
            }
        }

        public void PrintVideoDetails()
        {
            Console.WriteLine($"ID: {id}");
            Console.WriteLine($"Title: {title}");
            Console.WriteLine($"Play Count: {playCount}");
        }

        public int GetPlayCount()
        {
            return playCount;
        }

        public string GetTitle()
        {
            return title;
        }
    }
}
