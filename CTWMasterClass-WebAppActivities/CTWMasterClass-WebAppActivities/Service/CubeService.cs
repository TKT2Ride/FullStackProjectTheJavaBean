using CTWMasterClass_WebAppActivities.Models;
using CTWMasterClass_WebAppActivities.Repositories;
using CTWMasterClass_WebAppActivities.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CTWMasterClass_WebAppActivities.Service
{
    public class CubeService
    {
        private CubeRepository repository;

        public CubeService()
        {
            repository = new CubeRepository();
        }

        public List<Cube> GetAllCubes()
        {
            return repository.GetAllCubes();
        }
        public void AddCube(Cube toAdd)
        {
            repository.AddCube(toAdd);
        }
        public List<Cube> SortWeightLH()
        {
            List<Cube> list = repository.GetAllCubes();
            return list.OrderBy(o => o.Weight).ToList();
        }
        public List<Cube> SortWeightHL()
        {
            List<Cube> list = repository.GetAllCubes();
            return list.OrderByDescending(o => o.Weight).ToList();
        }

        public Cube GetCubeById(int id)
        {
            return repository.GetCubeById(id);
        }

        public void EditBarrel(Cube toSave)
        {
            repository.EditCube(toSave);
        }

        public void DeleteCube(Cube toDelete)
        {
            repository.DeleteCube(toDelete);
        }

    }
}
