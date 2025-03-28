﻿using System;
using modul6_103022330150;

class Program
{
    public static void Main()
    {
        try
        {
            SayaTubeUser user = new SayaTubeUser("Ihsan");

            string[] judulFilm =
            {
                "Review Film Avengers oleh Muhammad Ihsan Romdhon",
                "Review Film Code Lyoko oleh Muhammad Ihsan Romdhon",
                "Review Film Ultraman oleh Muhammad Ihsan Romdhon",
                "Review Film Power Rangers oleh Muhammad Ihsan Romdhon",
                "Review Film Batman oleh Muhammad Ihsan Romdhon",
                "Review Film Avengers 2 oleh Muhammad Ihsan Romdhon",
                "Review Film Code Lyoko 2 oleh Muhammad Ihsan Romdhon",
                "Review Film Ultraman Zero oleh Muhammad Ihsan Romdhon",
                "Review Film Kamen Rider oleh Muhammad Ihsan Romdhon",
                "Review Film Joker oleh Muhammad Ihsan Romdhon"
            };

            foreach (var judul in judulFilm)
            {
                SayaTubeVideo video = new SayaTubeVideo(judul);
                user.AddVideo(video);
                video.IncreasePlayCount(100);
            }

            SayaTubeVideo tes = new SayaTubeVideo("Tes Overflow Video");
            try
            {
                for (int i = 0; i < 100; i++)
                {
                    tes.IncreasePlayCount(25000000);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("ERROR: " + ex.Message);
            }

            Console.WriteLine("\nDaftar video pengguna:");
            user.PrintAllVideoPlaycount();
        }
        catch (Exception ex)
        {
            Console.WriteLine("ERROR: " + ex.Message);
        }
    }
}