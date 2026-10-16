class Category
{
    public string Name { get; set; }
    public int Survivals { get; set; }
    public int Missing { get; set; }
    public int Passangers => Survivals + Missing;

    public override string ToString()
        => $"{Name} ({Passangers} ppl.)";

    public Category(string row)
    {
        var tmp = row.Split(';');
        Name = tmp[0];
        Survivals = int.Parse(tmp[1]);
        Missing = int.Parse(tmp[2]);
    }
}