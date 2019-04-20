using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TSI_Schedule
{
    public partial class NoInternet : UserControl
    {
        public bool shown = false;

        public NoInternet()
        {
            InitializeComponent();
        }

        public delegate void TryToConectDeleg();
        public event TryToConectDeleg TryToConnectInterEvent; 

        private void button1_Click(object sender, EventArgs e)
        {
            TryToConnectInterEvent?.Invoke();
        }
    }
}
