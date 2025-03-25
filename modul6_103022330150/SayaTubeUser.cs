using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul6_103022330150
{
    public class SayaTubeUser
    {
        private int id;
        private string username;
        private List<SayaTubeVideo> uploadedVideos;

        public SayaTubeUser(string username)
        {
            if (string.IsNullOrEmpty(username))
                throw new ArgumentException("Username tidak boleh kosong!");
            if (username.Length > 100)
                throw new ArgumentException("Username tidak boleh lebih dari 100 karakter!");

            Random random = new Random();
            this.id = random.Next(10000, 99999);
            this.username = username;
            this.uploadedVideos = new List<SayaTubeVideo>();
        }

        public void AddVideo(SayaTubeVideo video)
        {
            if (video == null)
                throw new ArgumentException("Video tidak boleh kosong!");
            if (video.GetPlayCount() >= int.MaxValue)
                throw new ArgumentException("Play Count Video tidak boleh lebih dari nilai integer maksimum!");

            uploadedVideos.Add(video);
        }

        public int GetTotalVideoPlayCount()
        {
            int totalPlayCount = 0;
            foreach (var video in uploadedVideos)
            {
                totalPlayCount += video.GetPlayCount();
            }
            return totalPlayCount;
        }

        public void PrintAllVideoPlaycount()
        {
            Console.WriteLine($"ID: {id}");
            Console.WriteLine($"User: {username}");
            for (int i = 0; i < Math.Min(uploadedVideos.Count, 8); i++)
            {
                Console.WriteLine($"Video { i+ 1} judul: {uploadedVideos[i].GetTitle()}");
            }
        }
    }
}
