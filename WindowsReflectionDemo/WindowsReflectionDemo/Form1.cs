using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;

namespace WindowsReflectionDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            string FileName = openFileDialog1.FileName;
            Assembly assemblyObj = Assembly.LoadFile(FileName);
            Type[] myType = assemblyObj.GetTypes();
            this.ReflectAll(typeof(Employee));
        }

        public  void ReflectAll(Type typeObj)
        {
            //Getting all Mehtods 
            MethodInfo[] methods = typeObj.GetMethods();

            //Getting all Properties
            PropertyInfo[] propList = typeObj.GetProperties();

            //Getting all Fields
            FieldInfo[] fieldList = typeObj.GetFields();

            foreach(var item in propList)
            {
                listBox1.Items.Add(item);
            }
            foreach (var item in methods)
            {
                listBox2.Items.Add(item);
            }

        }
    }
}
