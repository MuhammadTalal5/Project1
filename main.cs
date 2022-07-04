using System;

public class SalarySystem
{
    public class SalarySlip {
        private int baseSalary;
        private int grossSalary;

        public SalarySlip(int bSalary){
            baseSalary = bSalary;
        }

        public void calculateSalary(string designation){
            if (designation == "engineer")
            {
                grossSalary = baseSalary + 100 + 500;
            } else if (designation == "analyst"){
                grossSalary = baseSalary + 150 + 800;
            }else if(designation == "manager"){
                grossSalary = baseSalary + 250 + 1000;
            }else{
                grossSalary = 0;
            }
        }

        public void displaySalary(){
            if(grossSalary != 0){
                Console.WriteLine(grossSalary);
            }else{
                Console.WriteLine("Please enter valid designation!");
            }
        }

    }

    public static void Main(string[] args)
    {
        SalarySlip sa = new SalarySlip(1500); // setting base salary through constructor
        string designation = Console.ReadLine();
        sa.calculateSalary(designation);
        sa.displaySalary();
    }
}
