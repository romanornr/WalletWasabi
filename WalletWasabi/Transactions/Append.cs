using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WalletWasabi.Models;

namespace WalletWasabi.Transactions
{
	public class Append : ITxStoreOperation
	{
		public IEnumerable<SmartTransaction> Transactions { get; }

		public bool IsEmpty => Transactions is null || !Transactions.Any();

		public Append(params SmartTransaction[] transactions) : this(transactions as IEnumerable<SmartTransaction>)
		{
		}

		public Append(IEnumerable<SmartTransaction> transactions)
		{
			Transactions = transactions;
		}
	}
}
