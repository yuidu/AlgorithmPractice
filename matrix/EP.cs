using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using AlgorithmPractice;


namespace AlgorithmPractice.matrix
{
    
}




public class Compensation
    {
        public string currency { get; set; }
        public double annualSalary { get; set; }
    }

    public class Employee
    {
        public int id { get; set; }
        public string department { get; set; }
        public Compensation compensation { get; set; }
        public string employmentType { get; set; }
    }

    public class ETest
    {
        private const string json_str =
            "[\n\t{\n\t\t\"id\": 1,\n\t\t\"department\": \"Sales\",\n\t\t\"compensation\": {\n\t\t\t\"currency\": \"USD\",\n\t\t\t\"annualSalary\": 52000.0\n\t\t},\n\t\t\"employmentType\": \"FULLTIME\"\n\t},\n\t{\n\t\t\"id\": 2,\n\t\t\"department\": \"CustomerSupport\",\n\t\t\"compensation\": {\n\t\t\t\"currency\": \"USD\",\n\t\t\t\"annualSalary\": 62000.0\n\t\t},\n\t\t\"employmentType\": \"FULLTIME\"\n\t},\n\t{\n\t\t\"id\": 3,\n\t\t\"department\": \"Sales\",\n\t\t\"compensation\": {\n\t\t\t\"currency\": \"USD\",\n\t\t\t\"annualSalary\": 50000.0\n\t\t},\n\t\t\"employmentType\": \"CONTRACTOR\"\n\t}\n]";



        public void test()
        {
            run();
        }

        public class DepartmentStat
        {
            public double NoOfEmployees;
            public double totalSalary;
            public double sum;
            public double avg;
        }

        public class ETreeNode
        {
            public ETreeNode Left;
            public ETreeNode Right;
            public double Value;
        }

        public void Test()
        {
        }

        public double GetMax(ETreeNode node, IDictionary<ETreeNode, double> memo)
        {
            if (node == null)
                return 0;

            if (memo.ContainsKey(node))
                return memo[node];

            double result = node.Value;
            if (node.Left != null)
                result = GetMax(node.Left.Left, memo) + GetMax(node.Left.Right, memo);
            if (node.Right != null)
                result = GetMax(node.Right.Left, memo) + GetMax(node.Right.Right, memo);

            var res = Math.Max(result, GetMax(node.Left, memo) + GetMax(node.Right, memo));
            memo[node] = res;
            return res;
        }

        public void run()
        {
            
            Employee[] es = JsonSerializer.Deserialize<Employee[]>(json_str);
            IDictionary<string, DepartmentStat> departToSalary = new Dictionary<string, DepartmentStat>();
            List<KeyValuePair<double, Employee>> avgToEmp = new List<KeyValuePair<double, Employee>>();

            for (int i = 0; i < es.Length; i++)
            {
                var e = es[i];
                if (departToSalary.ContainsKey(e.department))
                {
                    departToSalary[e.department].NoOfEmployees++;
                    departToSalary[e.department].sum += e.compensation.annualSalary;
                }
                else
                {
                    departToSalary.Add(e.department, new DepartmentStat());
                }
            }


            avgToEmp.Sort((x,y)=>(x.Value.compensation.annualSalary > y.Value.compensation.annualSalary)?1:-1);
            var top = avgToEmp.First();




            var res = from e in es
                      group e by e.id
                into eg
                      select new { id = eg.Key, total = eg.Sum(x => x.compensation.annualSalary) };

            var result = res.ToList();
            // var res = from e in es 
            //     group e by e. 

            var aa = new List<int>();
            aa.Sort((x, y) => x - y);
            var median = 0;
            if (aa.Count % 2 == 0)
            {
                median = (aa[aa.Count / 2] + aa[aa.Count / 2 + 1]) / 2;
            }
            else
                median = aa[aa.Count / 2];


        }
    }

