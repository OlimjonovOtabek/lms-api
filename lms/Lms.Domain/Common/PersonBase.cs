


using Lms.Domain.Enums.Entities;

namespace Lms.Domain.Common;


/// <summary>
/// Базовый класс для людей
/// </summary>
public class PersonBase : Entity
{
    /// <summary>
    /// Имя
    /// </summary>
    public string FirstName { get; set; } = default!;

    /// <summary>
    /// Фамилия
    /// </summary>
    public string LastName { get; set; } = default!;

    /// <summary>
    /// Отчество
    /// </summary>
    public string? MiddleName { get; set; }

    /// <summary>
    /// Полное имя
    /// </summary>
    public string? FullName { get; set; }

    /// <summary>
    /// Пол
    /// </summary>
    public Gender Gender { get; set; }

    /// <summary>
    /// Дата рождение
    /// </summary>
    public DateTimeOffset? BirthDate { get; set; }
}
