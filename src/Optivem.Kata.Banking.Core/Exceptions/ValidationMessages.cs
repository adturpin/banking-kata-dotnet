﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Optivem.Kata.Banking.Core.Exceptions
{
    public static class ValidationMessages
    {
        public const string FirstNameEmpty = "First name is empty";
        public const string LastNameEmpty = "Last name is empty";
        public const string BalanceNegative = "Balance is negative";
        public const string AccountNumberEmpty = "Account number is empty";
        public const string AmountNotPositive = "Amount is not positive";
        public const string AccountNumberNotExist = "Account number does not exist";
        public const string InsufficientFunds = "Insufficient funds";
    }
}
