using EmployeeWageComputationProblem;
using NonStaticEmpWageProblem;

namespace EmployeeWageComutationProblem
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to employee wage computation problem");
            ComputeEmpWageUsingClassMethod_UC7 Classmethod = new ComputeEmpWageUsingClassMethod_UC7();
            Classmethod.ComputeEmpWage();
    
        }
    }
}