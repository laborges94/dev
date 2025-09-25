namespace Core;

public abstract class Entity
{
    // Identifiers
    public Guid Id { get; protected set; } = Guid.NewGuid();

    // Audit info
    public DateTime CreatedAt { get; private set; } = DateTime.UtcNow;
    public int? CreatedBy { get; private set; }
    public DateTime? UpdatedAt { get; private set; }
    public int? UpdatedBy { get; private set; }
    public DateTime? DeletedAt { get; private set; }
    public int? DeletedBy { get; private set; }

    // State
    public bool IsActive { get; private set; } = true;

    // Constructors
    protected BaseEntity() { }

    protected BaseEntity(int createdBy) => 
        CreatedBy = createdBy;

    // Methods
    public void MarkAsUpdated(int userId)
    {
        UpdatedAt = DateTime.UtcNow;
        UpdatedBy = userId;
    }

    public void MarkAsDeleted(int userId)
    {
        if (!IsActive) return;

        IsActive = false;
        DeletedAt = DateTime.UtcNow;
        DeletedBy = userId;
    }

    public void Reactivate(int userId)
    {
        if (IsActive) return;

        IsActive = true;
        UpdatedAt = DateTime.UtcNow;
        UpdatedBy = userId;
        DeletedAt = null;
        DeletedBy = null;
    }
}
