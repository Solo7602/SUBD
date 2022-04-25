using DATABASE.TABLES;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATABASE.Implements
{
    public class ClientStorage
    {
        public List<Client> GetFullList()
        {
            using var context = new ApplicationContext();
            return context.Clients
            .ToList();
        }
        public List<Client> GetFiltredList(string str)
        {
            using var context = new ApplicationContext();
            return context.Clients.Where(r => r.Surname.Contains(str))
            .ToList();
        }
        public void Insert(Client model)
        {
            using var context = new ApplicationContext();
            context.Clients.Add(model);
            context.SaveChanges();
        }
        public Client GetElement(int id)
        {
            using var context = new ApplicationContext();
            var element = context.Clients
            .FirstOrDefault(rec => rec.Id == id);
            if (element == null)
            {
                throw new Exception("Элемент не найден");
            }
            return element;
        }
        public void Update(Client model)
        {
            using var context = new ApplicationContext();
            var element = context.Clients.FirstOrDefault(rec => rec.Id == model.Id);
            if (element == null)
            {
                throw new Exception("Элемент не найден");
            }
            element.Name = model.Name;
            element.Surname = model.Surname;
            element.idHotel = model.idHotel;
            context.SaveChanges();
        }
        public void Delete(Client model)
        {
            using var context = new ApplicationContext();
            Client element = context.Clients.FirstOrDefault(rec => rec.Id ==
           model.Id);
            if (element != null)
            {
                context.Clients.Remove(element);
                context.SaveChanges();
            }
            else
            {
                throw new Exception("Элемент не найден");
            }
        }
    }
}
