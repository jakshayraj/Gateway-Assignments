using BusinessEntities;
using Data.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repository
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly AppDBContext _context;

        public EmployeeRepository(AppDBContext context)
        {
            _context = context;
        }
        public string CreateEmployee(EmployeeViewModel model)
        {
            if (model != null)
            {
                Employee entity = new Employee();
                entity.Name = model.Name;
                _context.Add(entity);
                _context.SaveChanges();
                return "Employee added";
            }

            return "Model is null";
        }

        public string DeleteEmployee(int? Id)
        {
            Employee entity = _context.Employee.Find(Id);
            _context.Employee.Remove(entity);
            _context.SaveChanges();
            return "Deleted";
        }

        public IList<EmployeeViewModel> GetAllEmployees()
        {
            IList<EmployeeViewModel> EmployeeList = new List<EmployeeViewModel>();
            var result = _context.Employee.ToList();

            for (int i = 0; i < result.Count; i++)
            {
                EmployeeViewModel student = new EmployeeViewModel();
                student.Id = result[i].Id;
                student.Name = result[i].Name;
                EmployeeList.Add(student);
            }
            return EmployeeList;
        }

        public EmployeeViewModel GetEmployee(int? Id)
        {
            EmployeeViewModel serviceEntities = new EmployeeViewModel();
            Employee entity = _context.Employee.Find(Id);
            serviceEntities.Id = entity.Id;
            serviceEntities.Name = entity.Name;
            return serviceEntities;
        }

        public string UpdateEmployee(EmployeeViewModel model)
        {
            if (model != null)
            {
                Employee entity = _context.Employee.Find(model.Id);
                entity.Name = model.Name;
                _context.Update(entity);
                _context.SaveChanges();
                return "Employee added";
            }

            return "Model is null";
        }
    }
}
