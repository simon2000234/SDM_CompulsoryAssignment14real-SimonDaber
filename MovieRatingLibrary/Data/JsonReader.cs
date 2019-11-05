using System;
using System.Collections.Generic;
using System.IO;
using MovieRatingLibrary.Entities;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace MovieRatingLibrary
{
    public class JsonReader
    {
        public List<MovieReview> Readthejson(string filepath)
        {
            string result = string.Empty;
            using (StreamReader r = new StreamReader(filepath))
            {
                var json = r.ReadToEnd();
                List<MovieReview> items = JsonConvert.DeserializeObject<List<MovieReview>>(json);
                return items;
            }
        }
    }
}