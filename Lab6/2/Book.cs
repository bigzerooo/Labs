using System;
class Book
{
    string title;
    string author;
    decimal price;
    string Title
    {
        get
        {
            return title;
        }
        set
        {
            if (value.Length >= 3)
                title = value;
            else
                throw new Exception("Title not valid!");
        }
    }
    string Author
    {
        get
        {
            return author;
        }
        set
        {
            string[] tokens = value.Split(" ", StringSplitOptions.RemoveEmptyEntries);
            if (tokens[1][0] < '0' || tokens[1][0] > '9')
                author = value;
            else
                throw new Exception("Author not valid!");
        }
    }
    public virtual decimal Price
    {
        get
        {
            return price;
        }
        set
        {
            if (value > 0)
                price = value;  //price=decimal.Parse(value.ToString("0.00"));//?
            else
                throw new Exception("Title not valid!");
        }
    }
    public Book(string title,string author,decimal price)
    {
        Title = title;
        Author = author;
        Price = price;
    }
    public override string ToString()
    {
        return $"Type: {GetType().Name} \nTitle: {Title} \nAuthor: {Author} \nPrice: {Price:f2}";
    }
}
