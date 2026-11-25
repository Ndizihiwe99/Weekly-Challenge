using Xunit;

public class TransactionValidatorTests
{
    [Fact]
    public void Validate_ValidDeposit_ShouldReturnTrue()
    {
        var result = TransactionValidator.Validate(
            TransactionType.Deposit,
            100m,
            200m
        );

        Assert.True(result);
    }

    [Fact]
    public void Validate_ValidWithdrawal_ShouldReturnTrue()
    {
        var result = TransactionValidator.Validate(
            TransactionType.Withdrawal,
            100m,
            200m
        );

        Assert.True(result);
    }

    [Fact]
    public void Validate_WithdrawalExceedingBalance_ShouldReturnFalse()
    {
        var result = TransactionValidator.Validate(
            TransactionType.Withdrawal,
            250m,
            200m
        );

        Assert.False(result);
    }

    [Theory]
    [InlineData(0)]
    [InlineData(-50)]
    public void Validate_NonPositiveAmount_ShouldReturnFalse(decimal amount)
    {
        var result = TransactionValidator.Validate(
            TransactionType.Deposit,
            amount,
            200m
        );

        Assert.False(result);
    }

    [Fact]
    public void Validate_InvalidType_ShouldReturnFalse()
    {
        var result = TransactionValidator.Validate(
            (TransactionType)99,
            100m,
            200m
        );

        Assert.False(result);
    }
}