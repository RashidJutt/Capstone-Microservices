namespace Infrastructure;

public class UnitOfWorkConfig
{
    public int OptimisticConcurrencyConflictRetryCount { get; set; } = 10;
}