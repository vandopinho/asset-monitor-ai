namespace AssetMonitor.Application.Common.Exceptions;

public sealed class EquipmentAlreadyExistsException : Exception
{
    public EquipmentAlreadyExistsException(string serial)
        : base($"Equipment with serial '{serial}' already exists.")
    {
    }
}