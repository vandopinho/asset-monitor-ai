namespace AssetMonitor.Application.Common.Exceptions;

public sealed class UserInactiveException : Exception
{
    public UserInactiveException()
        : base("User is inactive.")
    {
    }
}