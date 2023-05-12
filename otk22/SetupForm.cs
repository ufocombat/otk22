using otk22.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace otk22
{
    public partial class SetupForm : Form
    {
        public SetupForm()
        {
            InitializeComponent();
        }

        private void SetupForm_Load(object sender, EventArgs e)
        {
            List<string> dinosaurs = new List<string>();

            dinosaurs.Add("Tyrannosaurus");
            dinosaurs.Add("Amargasaurus");
            dinosaurs.Add("Mamenchisaurus");
            dinosaurs.Add("Deinonychus");
            dinosaurs.Add("Compsognathus");

            foreach(var d in dinosaurs)
            {
                checkedListBox1.Items.Add(d);
            }


        }

        private void checkedListBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            foreach (var i in checkedListBox1.CheckedItems)
            {
                listBox1.Items.Add(i.ToString());
            }
        }

        private void SaveOptions() {
            var path = System.AppDomain.CurrentDomain.BaseDirectory+"/setup.json";

            Setup setup = new Setup();

            foreach (var i in checkedListBox1.CheckedItems)
            {
                setup.options.Add(new CheckOption() { selected = true, name = i.ToString()});
            }

            using (StreamWriter writer = new StreamWriter(path))
            {
                writer.WriteLine(JsonSerializer.Serialize(setup));
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SaveOptions();
        }
    }
}
