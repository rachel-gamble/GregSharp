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

    internal House Create(House houseData)
    {
        House house = _repo.Create(houseData);
        return house;
    }

    internal House Update(House houseUpdate, int id)
    {
        House original = Get(id);
        original.Title = houseUpdate.Title ?? original.Title;
        original.Price = houseUpdate.Price ?? original.Price;
        original.Address = houseUpdate.Address ?? original.Address;
        original.Bedrooms = houseUpdate.Bedrooms ?? original.Bedrooms;
        original.Bathrooms = houseUpdate.Bathrooms ?? original.Bathrooms;
        original.Levels = houseUpdate.Levels ?? original.Levels;
        original.Year = houseUpdate.Year ?? original.Year;
        original.imgUrl = houseUpdate.imgUrl ?? original.imgUrl;
        original.Description = houseUpdate.Description ?? original.Description;

        bool edited = _repo.Update(original);
        if (edited == false)
        {
            throw new Exception("House was not edited");
        }
        return original;
    }

}
