using DATABASE.TABLES;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATABASE.Implements
{
    public class HotelStorage
    {
        public List<Hotel> GetFullList()
        {
            using var context = new ApplicationContext();
            return context.Hotels
            .ToList();
        }
        public List<Hotel> GetFiltredList(string str)
        {
            using var context = new ApplicationContext();
            return context.Hotels.Where(r => r.Name.Contains(str))
            .ToList();
        }
        public void Insert(Hotel model)
        {
            using var context = new ApplicationContext();
            context.Hotels.Add(model);
            context.SaveChanges();
        }
        public Hotel GetElement(int id)
        {
            using var context = new ApplicationContext();
            var element = context.Hotels
            .FirstOrDefault(rec => rec.Id == id);
            if (element == null)
            {
                throw new Exception("Элемент не найден");
            }
            return element;
        }
        public void Update(Hotel model)
        {
            using var context = new ApplicationContext();
            var element = context.Hotels.FirstOrDefault(rec => rec.Id == model.Id);
            if (element == null)
            {
                throw new Exception("Элемент не найден");
            }
            element.Name = model.Name;
            element.Stars = model.Stars;
            element.Places = model.Places;
            context.SaveChanges();
        }
        public void Delete(Hotel model)
        {
            using var context = new ApplicationContext();
            Hotel element = context.Hotels.FirstOrDefault(rec => rec.Id ==
           model.Id);
            if (element != null)
            {
                context.Hotels.Remove(element);
                context.SaveChanges();
            }
            else
            {
                throw new Exception("Элемент не найден");
            }
        }
    }
}
