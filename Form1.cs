using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PoddprojektetOru

{
    public partial class Form1 : Form
    {
        private MongoDBService _mongoService;

        public Form1()
        {
            InitializeComponent();
            _mongoService = new MongoDBService();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            bool connected = _mongoService.TestConnection();

            if (connected)
                MessageBox.Show("✅ Anslutningen till MongoDB lyckades!");
            else
                MessageBox.Show("❌ Misslyckades med att ansluta till MongoDB.");
        }
    }
}