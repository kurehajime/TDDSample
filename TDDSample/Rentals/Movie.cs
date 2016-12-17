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

        public int CalcFee(int days)
        {
            var price = 0;
            var total = 0;
            switch (this.RentalType)
            {
                case MovieRentalType.NewRelease:
                    price = 300;
                    total += days * price;
                    break;
                case MovieRentalType.Childrens:
                    price = 150;
                    if (days <= 3)
                    {
                        total += price;
                    }
                    else
                    {
                        total += price + (days - 3) * price;
                    }
                    break;
                case MovieRentalType.Regular:
                    price = 200;
                    if (days <= 2)
                    {
                        total += price;
                    }
                    else
                    {
                        total += price + (days - 2) * price;
                    }
                    break;
            }
            return total;
        }
    }
}