namespace TDDSample.Rentals
{
    public sealed class Movie
    {
        public string Name { get; private set; }
        public MovieRentalType RentalType { get; private set; }

        public Movie(string name, MovieRentalType rentalType)
        {
            Name = name;
            RentalType = rentalType;
        }
    }
}