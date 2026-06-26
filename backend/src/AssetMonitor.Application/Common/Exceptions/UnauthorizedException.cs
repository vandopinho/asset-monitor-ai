namespace AssetMonitor.Application.Common.Exceptions;

public sealed class UnauthorizedException : Exception
{
    public UnauthorizedException()
        : base("Invalid credentials.")
    {
    }
}