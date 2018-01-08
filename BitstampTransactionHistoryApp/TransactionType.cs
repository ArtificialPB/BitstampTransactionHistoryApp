using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitstampTransactionHistoryApp
{
    enum TransactionType
    {
        Deposit = 0,
        Withdrawal = 1,
        MarketTrade = 2,
        SubAccountTransfer = 14
    }
}
