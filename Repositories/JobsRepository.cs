using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GregSharp.Repositories;

public class JobsRepository
{
    private readonly IDbConnection _db;

    public JobsRepository(IDbConnection db)
    {
        _db = db;
    }

    internal List<Job> Get()
    {
        string sql = @"
        SELECT
        *
        FROM jobs;
        ";
        List<Job> jobs = _db.Query<Job>(sql).ToList();
        return jobs;
    }

    internal Job Get(int id)
    {
        string sql = @"
        SELECT
        *
        FROM jobs
        WHERE id = @id;
        ";
        Job job = _db.Query<Job>(sql, new { id }).FirstOrDefault();
        return job;
    }

    internal Job Create(Job jobData)
    {
        string sql = @"
        INSERT INTO jobs
        (company, jobTitle, salary, hours, prerequisites, imgUrl, description)
        VALUES
        (@company, @jobTitle, @salary, @hours, @prerequisites, @imgUrl, @description);

        SELECT LAST_INSERT_ID();
        ";
        int id = _db.ExecuteScalar<int>(sql, jobData);
        jobData.Id = id;
        return jobData;
    }

    internal bool Update(Job original)
    {
        string sql = @"
        UPDATE jobs
        SET
        company = @company,
        jobTitle = @jobTitle,
        salary = @salary,
        hours = @hours,
        prerequisites = @prerequisites,
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
        DELETE FROM jobs
        WHERE id = @id;
        ";
        int rows = _db.Execute(sql, new { id });
        return rows > 0;
    }
}
