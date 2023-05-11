using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace araclistesivizeödevi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public List<cars> Cars = new List<cars>();
    }

    class cars
    {
        public string id;
        public string ID
        {
            get
            {
                if (id == null)
                    id = Guid.NewGuid().ToString();
                return id;
            }
            set { id = value; }
        }
        public string marka { get; set; }
        public string model { get; set; }
        public string yil { get; set; }
        public string km { get; set; }
        public string adress { get; set; }
        public string city { get; set; }
    }
}
