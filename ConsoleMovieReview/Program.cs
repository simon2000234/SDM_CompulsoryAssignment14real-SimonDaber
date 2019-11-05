using System;
using System.Collections.Generic;
using System.Text.Json;
using MovieRatingLibrary;
using MovieRatingLibrary.Entities;

namespace ConsoleMovieReview
{
    public class Program
    {
        static void Main(string[] args)
        {
            JsonReader js = new JsonReader();
            List<MovieReview> list = js.Readthejson("C:/Users/Melchertsen/Downloads/fuck.json");
            foreach (var dab in list)
            {
                Console.WriteLine(dab.Date);
            }
            Console.WriteLine("hello world");
        }
    }
}
