﻿namespace MovieModel // Namespace should start with a capital letter
{
    public class Movie // Class name should start with a capital letter
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Author { get; set; }
        public string Genre { get; set; }
        public double Rating { get; set; }
        public int Duration { get; set; }
        public string Comments { get; set; }

        // Constructor with parameter initialization
        public Movie(int id, string title, string description, string author, string genre, double rating, int duration, string comments)
        {
            Id = id;
            Title = title;
            Description = description;
            Author = author;
            Genre = genre;
            Rating = rating;
            Duration = duration;
            Comments = comments;
        }
    }
}
