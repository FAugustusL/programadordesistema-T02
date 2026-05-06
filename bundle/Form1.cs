using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bundle
{
    public partial class frmBundle : Form
    {
        public frmBundle()
        {
            InitializeComponent();

            lstBook.Columns.Add("ID", 100, HorizontalAlignment.Left); 
            lstBook.Columns.Add("Title", 200, HorizontalAlignment.Left);
            lstBook.Columns.Add("Author", 200, HorizontalAlignment.Left);
            lstBook.Columns.Add("Condtion", 200, HorizontalAlignment.Left);
            lstBook.Columns.Add("Price", 200, HorizontalAlignment.Left);

           
        }

        

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
