using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using WPFApplication24082026.Interfaces;
using WPFApplication24082026.Models;

namespace WPFApplication24082026.Data
{
    public class WorkingData:IWorkingData
    {
        private string jsonEmployees {  get; set; }

        public WorkingData(string paramsJson) 
        {
            this.jsonEmployees = paramsJson;
        }

        public List<Employees> getListEmployees(string jsonVals)
        {
            return JsonConvert.DeserializeObject<List<Employees>>(jsonVals);
        }

        public List<Employees> FullSortDataGrid()
        {
            List<Employees> Employees = getListEmployees(jsonEmployees);

            Employees.Sort((a, b) => a.Name.CompareTo(b.Name));

            return Employees;
        }

        public List<Employees> FullDataDataBase(string RowValue)
        {
            List<Employees> Employees = getListEmployees(jsonEmployees);

            var selectedEmployees = from p in Employees
                                  where p.Database == RowValue
                                 select p;

            return selectedEmployees.ToList();
        }
        public List<Employees> FullDataSpecification(string RowValue)
        {
            List<Employees> Employees = getListEmployees(jsonEmployees);

            var selectedEmployees = from p in Employees
                                   where p.Specification == RowValue
                                   select p;

            return selectedEmployees.ToList();
        }
    }
}