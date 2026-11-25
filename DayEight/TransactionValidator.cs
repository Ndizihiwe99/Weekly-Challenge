//                            Bank Transaction Validator


// Today's challenge focuses on **enums, conditional logic, decimal arithmetic, and unit testing**. 


//                                 Scenario

// A banking application processes deposits and withdrawals. 
// Before accepting a transaction, it must validate the transaction amount and type.

// the task is to implement `TransactionValidator.Validate()` so that all supplied tests pass.

//                               Requirements

// 1. A transaction amount must be greater than zero.
// 2. A deposit is valid when its amount is positive.
// 3. A withdrawal is valid only when its amount is positive and does not exceed the current balance.
// 4. A negative balance must make every transaction invalid.
// 5. An unsupported transaction type must return `false`.


using System;

public enum TransactionType
{
    Deposit,
    Withdrawal
}

public static class TransactionValidator
{
    public static bool Validate(
        TransactionType type,
        decimal amount,
        decimal balance)
    {
        if(amount <= 0 || balance < 0)
        return false;

        switch (type)
        {
            case TransactionType.Deposit:
            return amount > 0;
            
            case TransactionType.Withdrawal:
            return amount > 0 && amount <= balance;

        }
        



        return false;
    }
}