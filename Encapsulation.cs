using System;

public class Class1
{	
	public static void Main(string[] args) {

		//John john = new John();
		//john.Name = "Test";
		//john.Id = 1;

		//Console.WriteLine($"Name is: {john.Name} and Id is: {john.Id}");
		BankSystem bankSystem = new BankSystem(2000);
		bankSystem.GetBalance();
		bankSystem.Deposit(4000);
		bankSystem.GetBalance();
		bankSystem.Withdraw(10000);
	}		
}

class John{
	private string myName;
	private int myId;

	//below are called accessors and are defined public so other class can access it.

	public string Name
	{
		get { return myName; }
		set { myName = value; }
	}

	public int Id
	{
		get { return myId; }
		set { myId = value; }
	}
} 

//
//Let's try a banking system
class BankSystem{ 
	private decimal balance;

	public BankSystem(decimal initialBalance)
	{
		balance= initialBalance;
	}
	//Deposit
	public void Deposit(int amount)
	{
        Console.WriteLine($"Before Deposit: {balance}\n");
        balance += amount;
        Console.WriteLine($"After Deposit: {balance}\n");

    }
    //Withdraw
    public void Withdraw(int amount)
    {
		if (amount > balance) {
			Console.WriteLine("Insufficient Funds\n");
		}
		else
		{
			balance -= amount;
		}
			
    }

    //Get Balance
    public void GetBalance()
	{
		Console.WriteLine($"Balance: {balance}\n");
	}
}

//Encapsulation
1. We can make the variables of the class as read-only or write-only depending on our requirement.
2. read-only eg:- get { return myName; }
3. write only eg:- 	set { myName = value; }


