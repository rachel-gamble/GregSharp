using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GregSharp.Services;

public class HousesService
{
    private readonly HousesRepository _repo;

    public HousesService(HousesRepository repo)
    {
        _repo = repo;
    }

    // internal House Create(House houseData)

    internal List<House> Get()
    {
        List<House> houses = _repo.Get();
        return houses;
    }
    internal House Get(int id)
    {
        House house = _repo.Get(id);
        if (house == null)
        {
            throw new Exception("no house by that id");
        }
        return house;
    }

}
