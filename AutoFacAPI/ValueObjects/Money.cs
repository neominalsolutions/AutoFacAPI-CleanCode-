namespace AutoFacAPI.ValueObjects
{
  public class  MoneyClass
  {
    public int Amount { get; init; }
    public string Currency { get; init; }

    public MoneyClass(int amount,string curreny)
    {
      Amount = amount;
      Currency = curreny;
    }
  }
  public record Money(int amount,string curreny);
 
}
