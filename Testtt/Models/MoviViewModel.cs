namespace Testtt.Models
{
    public class MoviViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Iddescription { get; set; }
        public float Rating { get; set; }
        public string RatingDescription { get; set; } // Bad, Average, Good

        public MoviViewModel( Movies movie)
        {
            Id = movie.Id;
            Name = movie.name;
            Iddescription = movie.description;
            Rating = movie.rating;
            SetRatingDescription();
        }

        private void SetRatingDescription()
        {
            if (Rating >= 1 && Rating < 3)
            {
                RatingDescription = "Bad";
            }
            else if (Rating >= 3 && Rating < 4)
            {
                RatingDescription = "Average";
            }
            else if (Rating >= 4 && Rating <= 5)
            {
                RatingDescription = "Good";
            }
            else
            {
                RatingDescription = "Unknown";
            }
        }
    }
}
