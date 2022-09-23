using bank;

       BankAccount ba = new BankAccount();

        Console.WriteLine("How much $$$ do you want to deposit?");
        double amountToDeposit = double.Parse(Console.ReadLine());

        ba.deposit(amountToDeposit);

        double userBalance = ba.GetBalance();

        Console.WriteLine($"your current balance is:{userBalance,0:c}");
        


      

 




