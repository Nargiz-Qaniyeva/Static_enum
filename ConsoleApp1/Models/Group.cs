using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Models
{
    internal class Group
    {
        private string _studentLimit;
        public int GroupNo { get; set; }
        public string StudentLimit
        {
            get => _studentLimit;
            set
            {
                    if (_studentLimit.Length >= 5 &&
                    _studentLimit.Length <= 18)
                    {
                        return ;
                    }

            }
        }
        private Student[] _students;

        public bool CheckGroupNo(string GroupNo)
        {
            bool grp = false;
            bool grp1=false;
            for (int i = 0;  i < GroupNo.Length-1; i++)
            {
                if(GroupNo.Length==5)
                {
                   
                    if (char.IsSymbol(GroupNo[1]) && char.IsSymbol(GroupNo[2]))
                    {
                        grp = true;
                    }
                    else
                    {
                        grp = false;
                    }

                    if (char.IsNumber(GroupNo[3]) && char.IsNumber(GroupNo[4]) && char.IsNumber(GroupNo[5]))
                    {
                        grp1 = true;
                    }
                    else
                    {
                        grp1 = false;
                    }
                   
                }
            }
            if (grp == true && grp1 == true )
            {
                return true;
            }
            return false;
        }
        //public string AddStudent(string _students)
        //{

        //}
        // if (char.IsSymbol(GroupNo[1])&&char.IsSymbol(GroupNo[2]))
        
    }
}
