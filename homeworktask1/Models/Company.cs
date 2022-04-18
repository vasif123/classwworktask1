using System;
using System.Collections.Generic;
using System.Text;

namespace homeworktask1.Models
{
    class Company
    {
        private string _company;
        public int Limit;
        public Employer[] Employe;
        public string company
        {
            get => _company;
            set
            {
                bool check = true;
                while (check)
                {
                    bool symbol = false;
                    if (char.IsLetter(value[0]))
                    {
                        foreach (char item in value)
                        {
                            if (char.IsSymbol(item))
                            {
                                symbol = true;
                                Console.WriteLine("Simvol olmaz");
                            }
                        }
                        if (symbol == false)
                        {
                            Console.WriteLine("duzgundur");

                        }

                        
                    }
                    else
                    {

                    symbol = true;
                    Console.WriteLine("1 ci herf boyuk olmalidi");
                    }
                    
                    return ;
                }
            }
        }
        public Company()
        {
            Employe = new Employer[0];
        }
        public void Addemployer(Employer employer)
        {
            if (Employe.Length<Limit)
            {
                Array.Resize(ref Employe, Employe.Length + 1);
                Employe[Employe.Length - 1] = employer;
                Console.WriteLine("Iwci elave olundu");
                return;
            }
            Console.WriteLine("Wirketde yer yoxdu");
        }
        public Employer[] GetEmployers()
        {
            return Employe;
        }
    }
}
