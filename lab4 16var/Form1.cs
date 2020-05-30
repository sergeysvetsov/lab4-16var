using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;

namespace lab4_16var
{
    public partial class Form1 : Form
    {
        Model1 db = new Model1();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            db.Kvartirs.Load();
            kvartirsBindingSource.DataSource = db.Kvartirs.Local.ToBindingList();
        }

        private void kvartirs1BindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            db.SaveChanges();
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            db.Dispose();
        }

        private void kvartirs1DataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bindingNavigator1_RefreshItems(object sender, EventArgs e)
        {

        }

        private void kvartirsBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}
