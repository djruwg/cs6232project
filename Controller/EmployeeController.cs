using RentMe.DAL;
using RentMe.Model;

namespace RentMe.Controller
{
    internal class EmployeeController
    {
        private EmployeeDAL _employeeDAL;

        public EmployeeController()
        {
            this._employeeDAL = new EmployeeDAL();
        }

        /// <summary>
        /// Gets the employee by employee ID.
        /// </summary>
        /// <param name="id">A employee ID.</param>
        /// <returns>A Employee object</returns>
        public Employee GetEmployeeByID(int id)
        {
            return this._employeeDAL.GetEmployeeByID(id);
        }
    }
}
