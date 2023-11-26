using Microsoft.VisualBasic.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CreatingTextFile
{
    public partial class FrmRegistration : Form
    {
        public static string SetFileName;

        public long StudentNumber(string sn)
        {
            studno = long.Parse(sn);
            return studno;
        }

        public long ContactNo(string cn)
        {
            if (Regex.IsMatch(cn, "^[0-9]{10,11}$"))
            {
                ConNo = long.Parse(cn);
            }
            else
            {
                throw new FormatException("please enter a number");
            }
            return ConNo;
        }

        public string FullName(string Ln, string fn, string mi)
        {
            if (Regex.IsMatch(Ln, @"^[a-zA-Z]+") || Regex.IsMatch(fn, @"^[a-zA-Z]+$") || Regex.IsMatch(mi, @"^[a-zA-Z]+$"))
            {
                Fulneym = Ln + "," + fn + "," + mi;
            }
            else
            {
                throw new FormatException("Wrong Format");
            }
            return Fulneym;
        }

        public int Age(string age)
        {
            if (Regex.IsMatch(age, @"^[0-9]{1,3}$"))
            {
                edad = Int32.Parse(age);
            }
            else
            {
                throw new FormatException("Please Enter a Nuber");
            }
            return edad;
        }

        public FrmRegistration()
        {
            InitializeComponent();
        }

        public class RegistrationInfo
        {
            public static int studentno = 0;
            public static string fullname = "";
            public static int agee = 0;
            public static string birthday = "";
            public static string program = "";
            public static string gender = "";
            public static int contactno = 0;
        }
        private string Fulneym;
        private int edad;
        private long ConNo;
        private long studno;

        private void FrmRegistration_Load(object sender, EventArgs e)
        {
            string[] courses = new string[]
            {
                "BS in Information Technology",
                "BS in Computer Engineering",
                "BS in Computer Science",
                "BS in Accountancy",
                "BS in Information System"
            };
            for (int x = 0; x < 5; x++)
            {
                cbProgram.Items.Add(courses[x].ToString());
            }
            string[] Genderrr = new string[]
            {
                "Male",
                "Female"
            };
            for (int x = 0; x < 2; x++)
            {
                cbGender.Items.Add(Genderrr[x].ToString());
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
           
            string docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            StreamWriter outputFile = new StreamWriter(Path.Combine(docPath, FrmFileName.SetFileName = txtStudNo.Text + ".txt"));
            StreamWriter Content;
            Content = outputFile;
            

            string sno = label2.Text + " :" + txtStudNo.Text;
            string sfn = "Name: " + FullName(txtLastName.Text, txtFirstName.Text, txtMI.Text);
            string old = label5.Text + " :" + txtAge.Text;
            string bday = label6.Text + " :" + dtpBirthday.Value.ToString("yyyy-MM-dd");
            string courses = label3.Text + " :" + cbProgram.SelectedItem.ToString();
            string gndr = label9.Text + " :" + cbGender.SelectedItem.ToString();
            string cno = label10.Text + " :" + txtContact.Text;

            Content.WriteLine(sno);
            Content.WriteLine(sfn);
            Content.WriteLine(old);
            Content.WriteLine(bday);
            Content.WriteLine(courses);
            Content.WriteLine(gndr);
            Content.WriteLine(cno);
            Content.Close();

            txtAge.Clear();
            txtContact.Clear();
            txtFirstName.Clear();
            txtLastName.Clear();
            txtMI.Clear();
            txtStudNo.Clear();

        }
    }
}
