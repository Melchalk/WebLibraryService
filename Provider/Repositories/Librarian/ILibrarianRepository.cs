﻿using DbModels;

namespace Provider.Repositories.Librarian;

public interface ILibrarianRepository : IRepository<DbLibrarian, Guid>
{
    Task AddAsync(DbLibrarian librarian);
}
