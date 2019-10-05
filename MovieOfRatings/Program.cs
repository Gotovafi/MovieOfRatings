using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieOfRatings
{
    public class Program
    {
        private static List<Review> _ratingCollection;
        private static string _path = @"D:\Ratings\ratings.json";

        static void Main(string[] args)
        {
                    
        }
        public List<Review> GetReviewsFromFile(string _path)
        {
            using (StreamReader streamReader = File.OpenText(_path))
            using (JsonTextReader reader = new JsonTextReader(streamReader))
            {
                reader.CloseInput = true;
                var serializer = new JsonSerializer();
                var ratingList = new List<Review>();

                while (reader.Read())
                {
                    if (reader.TokenType == JsonToken.StartObject)
                    {
                        Review review = serializer.Deserialize<Review>(reader);
                        ratingList.Add(review);
                    }

                }
                return ratingList;
            }
            using (StreamReader sr = File.OpenText(_path))
            {
                string s = "";
                while ((s = sr.ReadLine()) != null)
                {
                    Console.WriteLine(s);
                }
            }
        }

        public static List<Review> getListFromJSON()
        {
            List<Review> listen = _ratingCollection;
            return _ratingCollection;
        }
    }
}
