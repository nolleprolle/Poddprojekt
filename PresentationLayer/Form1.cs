using DataLayer;
using BusinessLayer;
using ModelsLayer;

namespace PresentationLayer
{
    public partial class Form1 : Form
    {
        private MongoDBService _mongoService;

        public Form1()
        {
            InitializeComponent();

            this.Load += new System.EventHandler(this.Form1_Load);

            _mongoService = new MongoDBService();
        }

        private void Form1_Load(object? sender, EventArgs e)
        {
            bool connected = _mongoService.TestConnection();

            if (connected)
                MessageBox.Show("Anslutningen lyckades!");
            else
                MessageBox.Show("Misslyckades – kunde inte ansluta till MongoDB.");
        }
    }
}