
using CTWMasterClass_WebAppActivities.Models;
using CTWMasterClass_WebAppActivities.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CTWMasterClass_WebAppActivities.Service
{
    public class BarrelService
    {
        private BarrelRepository repository;

        public BarrelService()
        {
            repository = new BarrelRepository();
        }

        public List<Barrel> GetAllBarrels()
        {
            return repository.GetAllBarrels();
        }
        public void AddBarrel(Barrel toAdd)
        {
            repository.AddBarrel(toAdd);
        }
        public List<Barrel> SortWeightLH()
        {
            List<Barrel> list = repository.GetAllBarrels();
            return list.OrderBy(o => o.Weight).ToList();
        }
        public List<Barrel> SortWeightHL()
        {
            List<Barrel> list = repository.GetAllBarrels();
            return list.OrderByDescending(o => o.Weight).ToList();
        }

        public Barrel GetBarrelById(int id)
        {
            return repository.GetBarrelById(id);
        }

        public void EditBarrel(Barrel toSave)
        {
            repository.EditBarrel(toSave);
        }
    }
}

