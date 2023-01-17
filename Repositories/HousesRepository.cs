namespace GregSharp.Services;

public class HousesRepository
{
    private readonly IDbConnection _db;

    public HousesRepository(IDbConnection db)
    {
        _db = db;
    }

    internal List<House> Get()
    {
        string sql = @"
        SELECT 
        *
        FROM houses;
        ";
        List<House> houses = _db.Query<House>(sql).ToList();
        return houses;
    }

    internal House Get(int id)
    {
        string sql = @"
        SELECT
        *
        FROM houses
        WHERE id = @id;
        ";
        House house = _db.Query<House>(sql, new { id }).FirstOrDefault();
        return house;
    }
}
