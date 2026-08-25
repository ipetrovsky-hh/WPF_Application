using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPFApplication24082026.Models;

namespace WPFApplication24082026.Interfaces
{
   public interface IWorkingData
   {
        public List<Employees> getListEmployees(string jsonVals);

        public List<Employees> FullSortDataGrid();

        public List<Employees> FullDataDataBase(string RowValue);

        public List<Employees> FullDataSpecification(string RowValue);
    }
}
