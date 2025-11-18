using DataLayer;
using BusinessLayer;
using ModelsLayer;
using System.Xml.Linq;

namespace PresentationLayer
{
    public partial class MainPage : Form
    {
        private MongoDBService _mongoService;

        public MainPage()
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
        private void LoadRss(string url)
        {
            var xml = XDocument.Load(url);

            var items = xml.Descendants("item")
                .Select(x => new
                {
                    Title = (string)x.Element("title"),
                    Link = (string)x.Element("link"),
                    Description = (string)x.Element("description"),
                    PubDate = (string)x.Element("pubDate")
                })
                .ToList();

            dataGridView1.DataSource = items;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadRss(textBoxUrl.Text);

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}