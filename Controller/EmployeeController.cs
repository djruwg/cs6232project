using RentMe.DAL;
using RentMe.Model;

namespace RentMe.Controller
{
    internal class EmployeeController
    {
        /// <summary>
        /// The employee DAL
        /// </summary>
        private EmployeeDAL _employeeDAL;

        /// <summary>
        /// Initializes a new instance of the <see cref="EmployeeController"/> class.
        /// </summary>
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
