
#region Q1
double[] prices = { 25.5, 40.0, 33.75 };
Console.WriteLine(prices[1]);
#endregion

#region Q2
int[,] shelfCopies =
{
     {3,5},
     {1,4}
};
Console.WriteLine(shelfCopies[1, 0]);
#endregion

#region Q3
void PrintWelcomeMessage()
{
    Console.WriteLine("Welcome to the Library!");
}
PrintWelcomeMessage();
#endregion

#region Q4
void printBook(string title)
{
    Console.WriteLine($"Book Title: {title}");
}
printBook("Clean Code");
#endregion

#region Q5
int AddBonusPages(int pages)
{
    return pages + 50;
}
int pages = 400;
AddBonusPages(pages);
Console.WriteLine(pages);// The method changes a copy of pages, so the original variable stays unchanged.
#endregion

#region Q6
void ApplyDiscount(double[] prices6)
{
    prices[0] -= 5;
}
double[] prices6 = { 25.5, 40.0 };
ApplyDiscount(prices6);
Console.WriteLine(prices6[0]);
#endregion

#region Q7
void AddBonusPagesByRef(ref int pages)
{
   pages += 50;
}
int pages7 = 400;
AddBonusPagesByRef(ref pages7);
Console.WriteLine(pages7);
#endregion

#region Q8
void ReplaceArray(ref double[] prices)
{
    prices = new double[] { 10.0, 12.5, 15.0};
}
double[] prices8 = { 8.0, 9.5 };
ReplaceArray(ref prices8);
Console.WriteLine(prices8.Length);
#endregion

#region Q9
bool TryGetPrice(string title, out double price)
{
    if (title == "Clean Code")
    {
        price = 25.5;
        return true;
    }
        price = 0.0;
        return false;
}
if (TryGetPrice("Clean Code",out double price))
{
    Console.WriteLine(price); 
}
#endregion

#region Q10,Q11
void PrintBookInfo(string title, int pages = 300)
 {
    Console.WriteLine($"{title} = {pages} pages");
 }
PrintBookInfo("Clean Code");
PrintBookInfo("Refactoring", 448);
PrintBookInfo(pages:500, title: "Hamlet");
#endregion

#region Q12
void PrintAllTitles(params string[] titles)
{
    foreach (string title in titles)
    {
        Console.WriteLine(title);
    }
}
PrintAllTitles("Clean Code", "Refactoring", "The Pragmatic Programmer");
#endregion