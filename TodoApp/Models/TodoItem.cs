using System.ComponentModel.DataAnnotations;

namespace TodoApp.Models;

public class TodoItem
{
    public int Id { get; set; }

    [Required(ErrorMessage = "標題為必填欄位")]
    [StringLength(200, ErrorMessage = "標題長度不可超過 200 個字元")]
    public string Title { get; set; } = string.Empty;

    [StringLength(1000, ErrorMessage = "描述長度不可超過 1000 個字元")]
    public string? Description { get; set; }

    public bool IsCompleted { get; set; }

    public DateTime CreatedAt { get; set; } = DateTime.Now;

    public DateTime? CompletedAt { get; set; }
}
