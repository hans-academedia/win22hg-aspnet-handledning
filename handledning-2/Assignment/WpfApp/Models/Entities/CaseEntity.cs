using System.Collections.Generic;
using System;

namespace WpfApp.Models.Entities;

internal class CaseEntity
{
    public int Id { get; set; }
    public string Description { get; set; } = null!;
    public DateTime Created { get; set; } = DateTime.Now;
    public DateTime Modified { get; set; } = DateTime.Now;

    public int StatusId { get; set; } = 1;
    public StatusEntity Status { get; set; } = null!;

    public int CustomerId { get; set; }
    public CustomerEntity Customer { get; set; } = null!;

    public ICollection<CommentEntity> Comments { get; set; } = new HashSet<CommentEntity>();
}
