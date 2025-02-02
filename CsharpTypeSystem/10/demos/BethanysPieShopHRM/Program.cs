﻿using BethanysPieShopHRM.HR;
using System;
using System.Collections.Generic;

namespace BethanysPieShopHRM
{
    class Program
    {
        static void Main(string[] args)
        {
            IEmployee bethany = new StoreManager(55156, "Bethany", "Smith", "bethany@snowball.be", new DateTime(1979, 1, 16), 25);
            IEmployee mary = new Manager(748, "Mary", "Jones", "mary@snowball.be", new DateTime(1965, 1, 16), 30);
            JuniorResearcher bobJunior = new JuniorResearcher(11231, "Bob", "Spencer", "bob@snowball.be", new DateTime(1988, 1, 23), 17);
            IEmployee kevin = new StoreManager(81131, "Kevin", "Marks", "kevin@snowball.be", new DateTime(1953, 12, 12), 10);
            IEmployee kate = new StoreManager(100, "Kate", "Greggs", "kate@snowball.be", new DateTime(1993, 8, 8), 10);



            List<IEmployee> employees = new List<IEmployee>();
            employees.Add(bethany);
            employees.Add(mary);
            employees.Add(bobJunior);
            employees.Add(kevin);
            employees.Add(kate);

            employees.Sort();

            foreach (var employee in employees)
            {
                employee.DisplayEmployeeDetails();
            }

            //mary.AttendManagementMeeting();
        }
    }
}
