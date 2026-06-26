namespace AssetMonitor.Application.Common.Exceptions;

public sealed class UserAlreadyExistsException : Exception
{
    public UserAlreadyExistsException(string email)
        : base($"User '{email}' already exists.")
    {
    }
}