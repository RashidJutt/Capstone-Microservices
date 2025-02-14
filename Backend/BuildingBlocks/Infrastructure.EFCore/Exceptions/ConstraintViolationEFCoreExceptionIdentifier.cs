﻿using Infrastructure.EFCore.Utilities;
using Microsoft.EntityFrameworkCore;
using SharedKernel.Exceptions;
using System.Data.Common;

namespace Infrastructure.EFCore.Exceptions;

public class ConstraintViolationEFCoreExceptionIdentifier : IExceptionIdentifier
{
    public bool Identify(Exception ex, params object?[] entities)
    {
        if (entities.Length == 0)
        {
            if (ex is DbException dbEx)
            {
                return dbEx.IsSqlState(SqlState.ConstraintViolation);
            }
        }
        else if (ex is DbUpdateException updateEx)
        {
            if (!updateEx.Entries.Select(x => x.Entity).Intersect(entities.Where(x => x != null)).Any())
            {
                return false;
            }
            else
            {
                var dbException = updateEx.FindInnerException<DbException>();

                if (dbException != null)
                {
                    return dbException.IsSqlState(SqlState.ConstraintViolation);
                }
                else
                {
                    return false;
                }
            }
        }

        return false;
    }
}