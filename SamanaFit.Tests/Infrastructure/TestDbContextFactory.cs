using Microsoft.EntityFrameworkCore;
using SamanaFit.Data.Context;

namespace SamanaFit.Ui.Tests.Infrastructure;

public static class TestDbContextFactory
{
    public static string NewDatabaseName() => $"SamanaFitTests_{Guid.NewGuid()}";

    public static SamanaFitContext CreateContext(string databaseName)
    {
        var options = new DbContextOptionsBuilder<SamanaFitContext>()
            .UseInMemoryDatabase(databaseName)
            .Options;

        return new InMemorySamanaFitContext(options);
    }

    private sealed class InMemorySamanaFitContext(DbContextOptions<SamanaFitContext> options)
        : SamanaFitContext(options)
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Intentionally empty: tests provide InMemory provider through options.
        }
    }
}
