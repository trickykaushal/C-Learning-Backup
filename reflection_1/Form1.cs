using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Reflection;

namespace reflection_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           string TName= textBox1.Text;
            Type type = Type.GetType(TName);


           MethodInfo[] method_name=type.GetMethods();
            foreach(MethodInfo method in method_name)
            {
                listBox1.Items.Add(method.Name);
            }
         PropertyInfo[] pinfo= type.GetProperties();
            foreach(PropertyInfo property in pinfo)
            {
                listBox2.Items.Add(property.Name);
            }
        }
    }
}
