using System;

public class SalarySystem
{
    public class SalarySlip {
        private int baseSalary;
        private int grossSalary;

        public SalarySlip(int baseSalary){
            this.baseSalary = baseSalary;
        }

        public void calculateSalary(string designation){
            if (designation == "engineer")
            {
                this.grossSalary = this.baseSalary + 100 + 500;
            } else if (designation == "analyst"){
                this.grossSalary = this.baseSalary + 150 + 800;
            }else if(designation == "manager"){
                this.grossSalary = this.baseSalary + 250 + 1000;
            }else{
                this.grossSalary = 0;
            }
        }

        public void displaySalary(){
            if(this.grossSalary != 0){
                Console.WriteLine(this.grossSalary);
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