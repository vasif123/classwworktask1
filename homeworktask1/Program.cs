using System;
using homeworktask1.Models;

namespace homeworktask1
{
    class Program
    {
        static void Main(string[] args)
        {
            Employer worker = new Employer("Vasif Haciyev", 2000, "Menecer");
            Employer worker1 = new Employer("Vasif Haciyev", 2000, "Menecer");
            Employer worker2 = new Employer("Vasif Haciyev", 2000, "Menecer");
            Employer worker3 = new Employer("Vasif Haciyev", 2000, "Menecer");

            Company companyfirst = new Company();
            companyfirst.Limit = 2;
            companyfirst.company = "Pasha 123Holding";
            companyfirst.Addemployer(worker);
            companyfirst.Addemployer(worker1);
            companyfirst.Addemployer(worker2);
            companyfirst.Addemployer(worker3);

        }
    }
}
