using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccountForms
{
    public partial class CabinetForm : Form
    {
        public CabinetForm()
        {
            InitializeComponent();
        }

        public void SetLogin(string login)
        {
            accountLogin_lable.Text = login;
        }
    }
}
