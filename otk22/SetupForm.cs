using otk22.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using otk22.db;

namespace otk22
{
    public partial class SetupForm : Form
    {
        public SetupForm()
        {
            InitializeComponent();
        }

        private String optionsFileName()
        {
            return System.AppDomain.CurrentDomain.BaseDirectory + "setup.json";
        }

        private void SetupForm_Load(object sender, EventArgs e)
        {
            Setup setup = new Setup();

            setup.options.Add(new CheckOption() { name = "Tyrannosaurus" });
            setup.options.Add(new CheckOption() { name = "Amargasaurus" });
            setup.options.Add(new CheckOption() { name = "Mamenchisaurus" });
            setup.options.Add(new CheckOption() { name = "Deinonychus" });
            setup.options.Add(new CheckOption() { name = "Compsognathus" });
            
            if (File.Exists(optionsFileName()))
            { 
                String options = File.ReadAllText(optionsFileName());

                Setup stp =  JsonSerializer.Deserialize<Setup>(options);

                foreach (CheckOption o in stp.options)
                {
                    CheckOption c = setup.options.Find(x => x.name == o.name);
                    c.selected = o.selected;
                }

            }

            foreach (var d in setup.options)
            {
                checkedListBox1.Items.Add(d.name,d.selected);
            }

            curDataGridView.DataSource = MyDb.getCurrencies();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Setup setup = new Setup();

            foreach (var i in checkedListBox1.CheckedItems)
            {
                setup.options.Add(
                    new CheckOption()
                    {
                        selected = true,
                        name = i.ToString()
                    });
            }

            File.WriteAllText(optionsFileName(), JsonSerializer.Serialize(setup));
        }

        private void curTimer_Tick(object sender, EventArgs e)
        {
            MessageBox.Show("Таймер");
        }
    }
}
