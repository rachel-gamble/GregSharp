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

    internal House Create(House houseData)
    {
        string sql = @"
        INSERT INTO houses
        (title, price, address, bedrooms, bathrooms, levels, year, imgUrl, description)
        VALUES
        (@title, @price, @address, @bedrooms, @bathrooms, @levels, @year, @imgUrl, @description);

        SELECT LAST_INSERT_ID();
        ";

        int id = _db.ExecuteScalar<int>(sql, houseData);
        houseData.Id = id;
        return houseData;
    }

    internal bool Update(House original)
    {
        string sql = @"
        UPDATE houses
        SET
        title = @title,
        price = @price,
        address = @address,
        bedrooms = @bedrooms,
        bathrooms = @bathrooms,
        levels = @levels,
        year = @year,
        imgUrl = @imgUrl,
        description = @description
        WHERE id = @id;
        ";
        int rows = _db.Execute(sql, original);
        return rows > 0;
    }

    internal bool Remove(int id)
    {
        string sql = @"
        DELETE FROM houses
        WHERE id = @id;
        ";
        int rows = _db.Execute(sql, new { id });
        return rows > 0;
    }
}
