using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieOfRatings
{
    class Program
    {
        private static List<Review> _ratingCollection;

        static void Main(string[] args)
        {

            public void GetReviewsFromFile(string _path)
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
                        _ratingCollection = ratingList;
                    }
                }
            
        }
    }
}
