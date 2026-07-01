namespace AssetMonitor.Application.Common.Exceptions;

public sealed class EquipmentNotFoundException : Exception
{
    public EquipmentNotFoundException(Guid id)
        : base($"Equipment '{id}' was not found.")
    {
    }
}