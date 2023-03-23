﻿using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using System;
using WpfApp.Contexts;
using WpfApp.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace WpfApp.Services
{
    internal class UserService
    {
        private readonly DataContext _context = new();

        public async Task<UserEntity> CreateAsync(UserEntity entity)
        {
            var _entity = await _context.Users.FirstOrDefaultAsync(x => x.Email == entity.Email);
            if (_entity == null)
            {
                await _context.AddAsync(entity);
                await _context.SaveChangesAsync();
                return entity;
            }

            return _entity;
        }

        public async Task<UserEntity> GetAsync(Expression<Func<UserEntity, bool>> predicate)
        {
            var _entity = await _context.Users.FirstOrDefaultAsync(predicate);
            return _entity!;
        }

        public async Task<IEnumerable<UserEntity>> GetAllAsync()
        {
            return await _context.Users.ToListAsync();
        }
    }
}
