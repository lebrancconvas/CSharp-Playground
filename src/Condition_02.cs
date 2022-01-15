using System;

namespace Condition_02
{
	class Condition_02
	{
		public void Condition()
		{
			int balance = 100;
			int kapraoPrice = 50;
			int kapraoAmount = 3;
			int allPrice = kapraoPrice * kapraoAmount;
			
			if(balance >= allPrice)
			{
				balance -= allPrice;
				Console.WriteLine("Payment Success!!");
				Console.WriteLine($"Balance: {balance}");
			}
			else
			{
				Console.WriteLine("Payment Failed!!");
				Console.WriteLine("Please Check your account.");
			}
		}
	}
}