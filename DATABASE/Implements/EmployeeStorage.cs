using DATABASE.TABLES;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATABASE.Implements
{
    public class EmployeeStorage
    {
        public List<Employee> GetFullList()
        {
            using var context = new ApplicationContext();
            return context.Employees
            .ToList();
        }
        public List<Employee> GetFiltredList(string str)
        {
            using var context = new ApplicationContext();
            return context.Employees.Where(r => r.Surname.Contains(str))
            .ToList();
        }
        public void Insert(Employee model)
        {
            using var context = new ApplicationContext();
            context.Employees.Add(model);
            context.SaveChanges();
        }
        public Employee GetElement(int id)
        {
            using var context = new ApplicationContext();
            var element = context.Employees
            .FirstOrDefault(rec => rec.Id == id);
            if (element == null)
            {
                throw new Exception("Элемент не найден");
            }
            return element;
        }
        public void Update(Employee model)
        {
            using var context = new ApplicationContext();
            var element = context.Employees.FirstOrDefault(rec => rec.Id == model.Id);
            if (element == null)
            {
                throw new Exception("Элемент не найден");
            }
            element.Name = model.Name;
            element.Surname = model.Surname;
            element.Payment = model.Payment;
            element.Staff = model.Staff;
            element.idHotel = model.idHotel;
            context.SaveChanges();
        }
        public void Delete(Employee model)
        {
            using var context = new ApplicationContext();
            Employee element = context.Employees.FirstOrDefault(rec => rec.Id ==
           model.Id);
            if (element != null)
            {
                context.Employees.Remove(element);
                context.SaveChanges();
            }
            else
            {
                throw new Exception("Элемент не найден");
            }
        }
    }
}
