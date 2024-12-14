namespace Generics
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExchange_Click(object sender, EventArgs e)
        {
            double p = 5.8;
            double q = 7.3;
            GenUtil.Exchange(ref p, ref q);
            MessageBox.Show("x = " + p.ToString() + " y = " +
           q.ToString());
        }

        private void btnGenericClass_Click(object sender, EventArgs e)
        {
            MyGen<int, float> mg = new MyGen<int, float>();
            mg.A = 5;
            mg.B = 3.75f;
            MessageBox.Show(mg.ToString());
        }

        private void btnStudentArray_Click(object sender, EventArgs e)
        {
            Student[] STArr = new Student[5];
            for (int i = 0; i < STArr.Length; i++)
                STArr[i] = new Student();
        }

        private void btnInitArray_Click(object sender, EventArgs e)
        {
            Student[] STArr = GenArr.InitArray<Student>(4);
            MessageBox.Show(STArr.Length.ToString());
        }

        private void btnFindMaxScoreStudent_Click(object sender, EventArgs e)
        {
            Student[] STArr = GenArr.InitArray<Student>(3);
            STArr[0].Id = 12345;
            STArr[0].FirstName = "Bill";
            STArr[0].Test1Score = 83;
            STArr[1].Id = 12348;
            STArr[1].FirstName = "Sally";
            STArr[1].Test1Score = 91;
            STArr[2].Id = 12346;
            STArr[2].FirstName = "Mark";
            
 STArr[2].Test1Score = 85;
            Student maxScoreStudent = GenArr.FindMax<Student>(STArr);
            MessageBox.Show(maxScoreStudent.ToString());
        }

        private void btnDictionary_Click(object sender, EventArgs e)
        {
            // Dictionary is the generic equivalent of Hashtable
            Dictionary<int, Student> DTable = new Dictionary<int,
           Student>();
            Student s1 = new Student
            {
                FirstName = "Bill",
                LastName = "Baker",
                Id = 12337,
                Test1Score = 87,
                Test2Score = 91
            };
            DTable.Add(s1.Id, s1);
            Student s2 = new Student
            {
                FirstName = "Sally",
                LastName = "Simpson",
                Id = 12365,
                Test1Score = 89,
                Test2Score = 93
            };
            DTable.Add(s2.Id, s2);
            // lookup a student
            int id = 12365;
            try
            {
                Student st = DTable[id];
                MessageBox.Show(st.ToString());
            }
            catch (KeyNotFoundException)
            {
                MessageBox.Show("Student does not exist");
            }
            }

        private void btnEmployeeExtension_Click(object sender, EventArgs e)
        {
            Employee e1 = new Employee
            {
                FisrtName = "Bill",
                LastName = "Baker",
                HoursWorked = 48,
                PayRate = 17.5
            };
            double overtimePay = e1.ComputeOvertimePay(1.5);
            MessageBox.Show("Overtime pay = " + overtimePay.ToString());
        }

        private void btnJSONSerializeDeserailize_Click(object sender, EventArgs e)
        {
            Employee e1 = new Employee
            {
                FisrtName = "Bill",
                LastName = "Baker",
                HoursWorked = 48,
                PayRate = 17.5
            };
            string jsonEmp = e1.SerializeJson<Employee>();
            MessageBox.Show("JSON converted employee e1: \n" + jsonEmp);
            // recover employee object from JSON
            Employee emp = jsonEmp.DeserializeJson<Employee>();
            MessageBox.Show(emp.FisrtName + " " + emp.LastName + " " +
           emp.HoursWorked +
            " " + emp.PayRate);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}