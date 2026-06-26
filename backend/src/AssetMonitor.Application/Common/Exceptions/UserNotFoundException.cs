namespace AssetMonitor.Application.Common.Exceptions;

public sealed class UserNotFoundException : Exception
{
    public UserNotFoundException(Guid id)
        : base($"User '{id}' not found.")
    {
    }
}