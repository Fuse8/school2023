namespace Fuse8_ByteMinds.SummerSchool.Domain;

public class AccountProcessor
{

    public decimal Calculate(in BankAccount bankAccount)
    {
        decimal totalAmount = CalculateOperation(in bankAccount.LastOperation) +
                             CalculateOperation(in bankAccount.PreviousOperation) +
                             CalculateOperation1(in bankAccount.LastOperation) +
                             CalculateOperation1(in bankAccount.PreviousOperation) +
                             CalculateOperation2(in bankAccount.LastOperation) +
                             CalculateOperation2(in bankAccount.PreviousOperation) +
                             CalculateOperation3(in bankAccount.LastOperation) +
                             CalculateOperation3(in bankAccount.PreviousOperation) +
                             CalculateOperation3(in bankAccount)
                             +
                             CalculateOperation(in bankAccount.LastOperation) +
                             CalculateOperation(in bankAccount.PreviousOperation) +
                             CalculateOperation1(in bankAccount.LastOperation) +
                             CalculateOperation1(in bankAccount.PreviousOperation) +
                             CalculateOperation2(in bankAccount.LastOperation) +
                             CalculateOperation2(in bankAccount.PreviousOperation) +
                             CalculateOperation3(in bankAccount.LastOperation) +
                             CalculateOperation3(in bankAccount.PreviousOperation) +
                             CalculateOperation3(in bankAccount)
                             +
                             CalculateOperation(in bankAccount.LastOperation) +
                             CalculateOperation(in bankAccount.PreviousOperation) +
                             CalculateOperation1(in bankAccount.LastOperation) +
                             CalculateOperation1(in bankAccount.PreviousOperation) +
                             CalculateOperation2(in bankAccount.LastOperation) +
                             CalculateOperation2(in bankAccount.PreviousOperation) +
                             CalculateOperation3(in bankAccount.LastOperation) +
                             CalculateOperation3(in bankAccount.PreviousOperation) +
                             CalculateOperation3(in bankAccount);

        return totalAmount;
    }

    private decimal CalculateOperation(in BankOperation bankOperation)
    {
    
        return bankOperation.OperationInfo0;
    }

    private decimal CalculateOperation1(in BankOperation bankOperation)
    {
      
        return bankOperation.OperationInfo1;
    }

    private decimal CalculateOperation2(in BankOperation bankOperation)
    {
     
        return bankOperation.OperationInfo2;
    }

 
    private decimal CalculateOperation3(in BankOperation bankOperation)
    {
      
        return bankOperation.TotalAmount;
    }
}

public struct BankAccount : ITotalAmount
{
    public decimal TotalAmount { get; set; }
    public BankOperation LastOperation { get; set; }
    public BankOperation PreviousOperation { get; set; }
}

public interface ITotalAmount
{
    decimal TotalAmount { get; set; }
}

public struct BankOperation : ITotalAmount
{
    public decimal TotalAmount { get; set; }

}
