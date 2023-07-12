namespace Fuse8_ByteMinds.SummerSchool.Domain;

public class AccountProcessor
{
	// ToDo Реализовать без копирования и боксинга
	public decimal Calculate(BankAccount bankAccount)
	{
		return CalculateOperation(bankAccount.LastOperation) +
		       CalculateOperation(bankAccount.PreviousOperation) +
		       CalculateOperation1(bankAccount.LastOperation) +
		       CalculateOperation1(bankAccount.PreviousOperation) +
		       CalculateOperation2(bankAccount.LastOperation) +
		       CalculateOperation2(bankAccount.PreviousOperation) +
		       CalculateOperation3(bankAccount.LastOperation) +
		       CalculateOperation3(bankAccount.PreviousOperation) +
		       CalculateOperation3(bankAccount)
		       +
		       CalculateOperation(bankAccount.LastOperation) +
		       CalculateOperation(bankAccount.PreviousOperation) +
		       CalculateOperation1(bankAccount.LastOperation) +
		       CalculateOperation1(bankAccount.PreviousOperation) +
		       CalculateOperation2(bankAccount.LastOperation) +
		       CalculateOperation2(bankAccount.PreviousOperation) +
		       CalculateOperation3(bankAccount.LastOperation) +
		       CalculateOperation3(bankAccount.PreviousOperation) +
		       CalculateOperation3(bankAccount)
		       +
		       CalculateOperation(bankAccount.LastOperation) +
		       CalculateOperation(bankAccount.PreviousOperation) +
		       CalculateOperation1(bankAccount.LastOperation) +
		       CalculateOperation1(bankAccount.PreviousOperation) +
		       CalculateOperation2(bankAccount.LastOperation) +
		       CalculateOperation2(bankAccount.PreviousOperation) +
		       CalculateOperation3(bankAccount.LastOperation) +
		       CalculateOperation3(bankAccount.PreviousOperation) +
		       CalculateOperation3(bankAccount);
	}

	private decimal CalculateOperation(BankOperation bankOperation)
	{
		// Some calculation code
		return bankOperation.OperationInfo0;
	}

	private decimal CalculateOperation1(BankOperation bankOperation)
	{
		// Some calculation code
		return bankOperation.OperationInfo1;
	}

	private decimal CalculateOperation2(BankOperation bankOperation)
	{
		// Some calculation code
		return bankOperation.OperationInfo2;
	}

	private decimal CalculateOperation3(ITotalAmount bankOperation)
	{
		// Some calculation code
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

	public long Rubles { get; set; }

	public short Kopeks { get; set; }

	public long RublesBeforeOperation { get; set; }

	public short KopeksBeforeOperation { get; set; }

	public long RublesAfterOperation { get; set; }

	public short KopeksAfterOperation { get; set; }

	public long OperationInfo0 { get; set; }
	public long OperationInfo1 { get; set; }
	public long OperationInfo2 { get; set; }
	public long OperationInfo3 { get; set; }
	public long OperationInfo4 { get; set; }
	public long OperationInfo5 { get; set; }
	public long OperationInfo6 { get; set; }
	public long OperationInfo7 { get; set; }
	public long OperationInfo8 { get; set; }
	public long OperationInfo9 { get; set; }
	public long OperationInfo10 { get; set; }
	public long OperationInfo11 { get; set; }
	public long OperationInfo12 { get; set; }
	public long OperationInfo13 { get; set; }
	public long OperationInfo14 { get; set; }
	public long OperationInfo15 { get; set; }
	public long OperationInfo16 { get; set; }
	public long OperationInfo17 { get; set; }
	public long OperationInfo18 { get; set; }
	public long OperationInfo19 { get; set; }
	public long OperationInfo20 { get; set; }
	public long OperationInfo21 { get; set; }
	public long OperationInfo22 { get; set; }
	public long OperationInfo23 { get; set; }
	public long OperationInfo24 { get; set; }
	public long OperationInfo25 { get; set; }
	public long OperationInfo26 { get; set; }
	public long OperationInfo27 { get; set; }
	public long OperationInfo28 { get; set; }
	public long OperationInfo29 { get; set; }
	public long OperationInfo30 { get; set; }
	public long OperationInfo31 { get; set; }
	public long OperationInfo32 { get; set; }
	public long OperationInfo33 { get; set; }
	public long OperationInfo34 { get; set; }
	public long OperationInfo35 { get; set; }
	public long OperationInfo36 { get; set; }
	public long OperationInfo37 { get; set; }
	public long OperationInfo38 { get; set; }
	public long OperationInfo39 { get; set; }
	public long OperationInfo40 { get; set; }
	public long OperationInfo41 { get; set; }
	public long OperationInfo42 { get; set; }
	public long OperationInfo43 { get; set; }
	public long OperationInfo44 { get; set; }
	public long OperationInfo45 { get; set; }
	public long OperationInfo46 { get; set; }
	public long OperationInfo47 { get; set; }
	public long OperationInfo48 { get; set; }
	public long OperationInfo49 { get; set; }
	public long OperationInfo50 { get; set; }
	public long OperationInfo51 { get; set; }
	public long OperationInfo52 { get; set; }
	public long OperationInfo53 { get; set; }
	public long OperationInfo54 { get; set; }
	public long OperationInfo55 { get; set; }
	public long OperationInfo56 { get; set; }
	public long OperationInfo57 { get; set; }
	public long OperationInfo58 { get; set; }
	public long OperationInfo59 { get; set; }
}