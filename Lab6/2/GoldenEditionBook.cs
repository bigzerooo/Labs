using System;
class GoldenEditionBook:Book
{
    public override decimal Price
    {
        get
        {
            return base.Price* (decimal)1.3;
        }
    }
    public GoldenEditionBook(string title, string author, decimal price) : base(title, author, price)
    {

    }
}