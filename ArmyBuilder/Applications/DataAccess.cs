using ArmyBuilder.DAL;
using ArmyBuilder.Models;
using System.Collections.Generic;
using System.Linq;

namespace ArmyBuilder.Applications
{
    public class DataAccess
    {
        public List<Unit> GetUnits()
        {
            using (var db = new UnitsContext())
            {
                return db.Units.ToList();
            }
        }

        public void Add(Unit unit)
        {
            using (var context = new UnitsContext())
            {
                context.Units.Add(unit);
                context.SaveChanges();
            }
        }

        public void Update(Unit unit)
        {
            using (var context = new UnitsContext())
            {
                var currUnit = context.Units.Where(u => u.Id == unit.Id).First();
                currUnit.Name = unit.Name;
                currUnit.Movement = unit.Movement;
                currUnit.Range = unit.Range;
                currUnit.Strength = unit.Strength;
                currUnit.Armor = unit.Armor;
                currUnit.Points = unit.Points;

                context.SaveChanges();
            }
        }

        public void Delete(Unit unit)
        {
            using (var context = new UnitsContext())
            {
                var currUnit = context.Units.Where(u => u.Id == unit.Id).FirstOrDefault();
                context.Units.Remove(currUnit);
                context.SaveChanges();
            }
        }
    }
}