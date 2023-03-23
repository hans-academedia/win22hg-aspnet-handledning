﻿using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using WpfApp.Contexts;
using WpfApp.Models.Entities;

namespace WpfApp.Services;

internal class CommentService
{
    private readonly DataContext _context = new();

    public async Task CreateAsync(CommentEntity commentEntity)
    {
        if (await _context.Cases.AnyAsync(x => x.Id == commentEntity.CaseId))
        {
            _context.Add(commentEntity);
            await _context.SaveChangesAsync();
        }
    }

    public async Task<IEnumerable<CommentEntity>> GetAllAsync()
    {
        return await _context.Comments.ToListAsync();
    }
}
