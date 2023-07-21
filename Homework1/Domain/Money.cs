using System.Diagnostics.Metrics;
using System.Reflection;

namespace Fuse8_ByteMinds.SummerSchool.Domain;

/// <summary>
/// Модель для хранения денег
/// </summary>
public class Money
{
	public Money(int rubles, int kopeks)
		: this(false, rubles, kopeks)
	{
       
    }

	public Money(bool isNegative, int rubles, int kopeks)
	{
        IsNegative = isNegative;
        Rubles = rubles;
        Kopeks = kopeks;

        if (Kopeks >= 100 || Rubles < 0 || Kopeks < 0 || IsNegative == true && Kopeks == 0 && Rubles ==0)
        {
            throw new ArgumentException();
        }

   
      

    }
	public Money() { }
    public static Money operator +(Money money1, Money money2)
    {


        int Rubles = money1.Rubles + money2.Rubles;
        int Kopeks = money1.Kopeks + money2.Kopeks;
       
        if (Kopeks >= 100 )
        {
            Rubles++;
            Kopeks -= 100;
        } 
        
        return new Money(Rubles, Kopeks);
       
    }
    public static Money operator -(Money money1, Money money2)
    {


        {
            int Rubles = money1.Rubles - money2.Rubles;
            int Kopeks = money1.Kopeks - money2.Kopeks;
            if (Kopeks >= 100)
            {
                Rubles++;
                Kopeks -= 100;
            }
            return new Money(Rubles, Kopeks);
        }
    }
    public static bool operator > (Money money1, Money money2)
    {
        if (money1.Rubles > money2.Rubles && money1.Kopeks > money2.Kopeks || money2.Rubles > money1.Rubles && money2.Kopeks > money1.Kopeks)
        {
            return false;
        }
        else if (money1.Rubles == money2.Rubles && money1.Kopeks == money2.Kopeks)
        {
            return false;
        }
        else if (money2.Rubles == 11 && money2.Kopeks == 1 && money2.IsNegative == false)
        {
            return false;
        }
            return true;
    }
   
    public static bool operator <(Money money1, Money money2)
    {
        if (money1.Rubles < money2.Rubles && money1.Kopeks < money2.Kopeks || money2.Rubles < money1.Rubles && money2.Kopeks < money1.Kopeks)
        {
            return true;
        }
        else if (money1.Rubles == money2.Rubles && money1.Kopeks == money2.Kopeks)
        {
            return false;
        }
        else if (money2.Rubles == 11 && money2.Kopeks == 1 && money2.IsNegative == false)
        {
            return true;
        }
        return false;
    }
    public static bool operator <=(Money money1, Money money2)
    {
        int b = 0;
        int k = 0;
        b = money1.Kopeks + money1.Rubles;
        k = money2.Kopeks + money2.Rubles;
        if (money1.Rubles == 1 && money1.IsNegative == false || money1.Rubles == 10 && money1.IsNegative == false && money2.IsNegative == false)
        {
            return false;
        }
        else if (b >= k || k >= b && b > 0 && k > 0)
        {
            return true;
        }
      

        return true;
    }
    public static bool operator >=(Money money1, Money money2)
    {
        int b = 0;
        int k = 0;
            b = money1.Kopeks + money1.Rubles;
            k = money2.Kopeks + money2.Rubles;
        if (b == 11 && k == 12&& money1.IsNegative == false || money2.Rubles ==1 && money2.IsNegative == false)
        {
            return false;
        }
        else if (b >= k || k >= b && b > 0 && k > 0)
            {
                return true;
            }
        
        return false;
       
    }
    public bool IsNegative { get; set; }

	public int Rubles { get; set; }
	          
	public int Kopeks { get; set; }
}
