using System;
using System.Collections.Generic;
using System.Drawing;
using System.Net;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using BusinessLayer;
using BusinessLayer.IServices;
using ModelsLayer;
using System.Linq;
using System.Threading.Tasks;
namespace PresentationLayer
{
    public partial class FirstWindow : Form
    {
        private readonly IRssClientService _rssClientService;
        private readonly IPoddService _poddService;
        private readonly IEpisodeService _episodeService;
        private readonly ICategoryService _categoryService;

        // Håller de senaste inlästa episoderna från RSS-flödet
        private List<Episode>? _loadedEpisodes;

        public FirstWindow()
            : this(
                  ServiceFactory.CreateRssService(),
                  ServiceFactory.CreatePoddService(),
                  ServiceFactory.CreateEpisodeService(),
                  ServiceFactory.CreateCategoryService())
        {
        }

        public FirstWindow(
            IRssClientService rssClientService,
            IPoddService poddService,
            IEpisodeService episodeService,
            ICategoryService categoryService)
        {
            InitializeComponent();

            _rssClientService = rssClientService;
            _poddService = poddService;
            _episodeService = episodeService;
            _categoryService = categoryService;

            this.Load += FirstWindow_Load;

            dgvEpisodes.SelectionChanged += dgvEpisodes_SelectionChanged;
            tabControl1.SelectedIndexChanged += tabControl1_SelectedIndexChanged;
            cbCategoryFiltration.SelectedIndexChanged += cbCategoryFiltration_SelectedIndexChanged;
            dgvPoddNames.SelectionChanged += dgvPoddnames_SelectionChanged;
            dgvEpisodeRegister.SelectionChanged += dgvEpisodeRegister_SelectionChanged;

            btnEditPod.Click += btnEditPod_Click;


            rtbEpisodeInfo.ReadOnly = true;
            rtbEpisodeInfo.WordWrap = true;
            rtbEpisodeInfo.ScrollBars = RichTextBoxScrollBars.Vertical;

            rtbDescription.ReadOnly = true;
            rtbDescription.WordWrap = true;
            rtbDescription.ScrollBars = RichTextBoxScrollBars.Vertical;
        }






        private async void FirstWindow_Load(object? sender, EventArgs e)
        {
            try
            {
                await ReloadCategoriesAsync();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Kunde inte ladda kategorier:\r\n" + ex.Message);
            }
        }
        //try
        //{
        //    var categories = await _categoryService.GetAllAsync();
        //    cbCategory.DataSource = new List<Category>(categories);
        //    cbCategory.DisplayMember = "Name";
        //    cbCategory.ValueMember = "Id";
        //    cbCategory.SelectedIndex = categories.Count > 0 ? 0 : -1;

        //    cbCategoryFiltration.DataSource = new List<Category>(categories);
        //    cbCategoryFiltration.DisplayMember = "Name";
        //    cbCategoryFiltration.ValueMember = "Id";
        //    cbCategoryFiltration.SelectedIndex = -1;
        //}
        //catch (Exception ex)
        //{
        //    MessageBox.Show("Kunde inte ladda kategorier:\r\n" + ex.Message);
        //}

        private async Task ReloadCategoriesAsync()
        {
            var categories = await _categoryService.GetAllAsync();

            cbCategory.DataSource = new List<Category>(categories);
            cbCategory.DisplayMember = "Name";
            cbCategory.ValueMember = "Id";
            cbCategory.SelectedIndex = categories.Count > 0 ? 0 : -1;

            cbCategoryFiltration.DataSource = new List<Category>(categories);
            cbCategoryFiltration.DisplayMember = "Name";
            cbCategoryFiltration.ValueMember = "Id";
            cbCategoryFiltration.SelectedIndex = -1;

            cbPoddCatEdit.DataSource = new List<Category>(categories);
            cbPoddCatEdit.DisplayMember = "Name";
            cbPoddCatEdit.ValueMember = "Id";
            cbPoddCatEdit.SelectedIndex = -1;

        }
        private async void btnCreateCategory_Click(object? sender, EventArgs e)
        {
            string name = txtCreateCategory.Text.Trim();
            if (string.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show("Ange ett namn på kategorin!");
                return;
            }
            try
            {
                var cat = new Category { Name = name };
                await _categoryService.AddAsync(cat);

                txtCreateCategory.Clear();

                await ReloadCategoriesAsync();
                await LoadPoddRegisterAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kunde inte skapa kategorin:\r\n" + ex.Message);
            }
        }

        private async void btnEditCategory_Click(object? sender, EventArgs e)
        {
            if (cbCategoryFiltration.SelectedItem is not Category selectedCategory || string.IsNullOrEmpty(selectedCategory.Id))
            {
                MessageBox.Show("Välj en kategori att ändra!");
                return;
            }

            string newName = txtChangeName.Text.Trim();
            if (string.IsNullOrWhiteSpace(newName))
            {
                MessageBox.Show("Ange ett nytt namn för kategorin!");
                return;
            }

            try
            {
                selectedCategory.Name = newName;

                bool ok = await _categoryService.UpdateAsync(selectedCategory);

                if (!ok)
                {
                    MessageBox.Show("Kunde inte uppdatera kategorin.");
                    return;
                }

                txtChangeName.Clear();

                await ReloadCategoriesAsync();
                await LoadPoddRegisterAsync();
            }

            catch (Exception ex)
            {
                MessageBox.Show("Kunde inte uppdatera kategorin:\r\n" + ex.Message);
                return;
            }

        }

        private async void btnRemoveCat_Click(object? sender, EventArgs e)
        {
            if (cbCategoryFiltration.SelectedItem is not Category selectedCategory || string.IsNullOrEmpty(selectedCategory.Id))
            {
                MessageBox.Show("Välj en kategori att ta bort!");
                return;
            }

            var confirm = MessageBox.Show(
                $"Är du säker på att du vill ta bort kategorin \"{selectedCategory.Name}\"?",
                "Bekräfta borttagning",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (confirm != DialogResult.Yes)
            {
                return;
            }

            try
            {
                bool ok = await _categoryService.DeleteAsync(selectedCategory.Id);
                if (!ok)
                {
                    MessageBox.Show("Kunde inte ta bort kategorin.");
                    return;
                }
                await ReloadCategoriesAsync();
                await LoadPoddRegisterAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kunde inte ta bort kategorin:\r\n" + ex.Message);
                return;

            }


        }

        private async void btnEditPod_Click(object? sender, EventArgs e) {
            if (dgvPoddNames.CurrentRow?.DataBoundItem is not Podd podd || string.IsNullOrEmpty(podd.Id)) {
                MessageBox.Show("Välj ett poddflöde i listan först!");
                return;
            }
            string newName = txtEditPod.Text.Trim();
            if (string.IsNullOrWhiteSpace(newName)) 
            {
                MessageBox.Show("Ange ett nytt namn för poddflödet!");
                return;
            }

           

            try
            {
                podd.Name = newName;
                

                bool ok = await _poddService.UpdateAsync(podd);

                if (!ok)
                {
                    MessageBox.Show("Poddens namn kunde inte uppdateras!");
                    return;
                }
                await LoadPoddRegisterAsync();

                if (dgvPoddNames.DataSource is List<Podd> list)
                {
                    var updated = list.FirstOrDefault(p => p.Id == podd.Id);
                    if (updated != null)
                    {
                        int idx = list.IndexOf(updated);
                        if (idx >= 0 && idx < dgvPoddNames.Rows.Count)
                        {
                            dgvPoddNames.ClearSelection();
                            dgvPoddNames.Rows[idx].Selected = true;

                        }
                    }
                }
                txtEditPod.Clear();
            }
            catch (Exception ex) {
                MessageBox.Show("Fel vid uppdatering av poddens namn!:\r\n" + ex.Message);
            }
        }

        private async Task LoadPoddRegisterAsync()
        {
            try
            {
                var allPodds = await _poddService.GetAllAsync();

                string? selectedCategoryId = null;

                if (cbCategoryFiltration.SelectedItem is Category selectedCategory)
                {
                    selectedCategoryId = selectedCategory.Id;
                }

                List<Podd> filteredPodds;
                if (!string.IsNullOrEmpty(selectedCategoryId))
                {
                    filteredPodds = allPodds
                        .Where(p => p.CategoryId == selectedCategoryId)
                        .ToList();
                }
                else
                {
                    filteredPodds = allPodds;
                }

                dgvPoddNames.AutoGenerateColumns = false;
                dgvPoddNames.Columns.Clear();

                var nameCol = new DataGridViewTextBoxColumn
                {
                    DataPropertyName = "Name",
                    HeaderText = "Podd",
                    AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
                };

                var urlCol = new DataGridViewTextBoxColumn
                {
                    DataPropertyName = "Url",
                    HeaderText = "RSS-URL",
                    AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
                };

                dgvPoddNames.Columns.Add(nameCol);
                dgvPoddNames.Columns.Add(urlCol);

                dgvPoddNames.DataSource = filteredPodds;

                dgvEpisodeRegister.DataSource = null;
                rtbDescription.Clear();
            }

            catch (Exception ex)
            {
                MessageBox.Show("Kunde inte ladda poddregistret:\r\n" + ex.Message);
            }
        }

        private async void tabControl1_SelectedIndexChanged(object? sender, EventArgs e)
        {
            if (tabControl1.SelectedTab == tabPage2)
            {
                await LoadPoddRegisterAsync();
            }
        }

        private async void cbCategoryFiltration_SelectedIndexChanged(object? sender, EventArgs e)
        {
            if (tabControl1.SelectedTab == tabPage2)
            {
                await LoadPoddRegisterAsync();
            }


        }

        private async void dgvPoddnames_SelectionChanged(object? sender, EventArgs e)
        {
            if (dgvPoddNames.CurrentRow?.DataBoundItem is not Podd podd || string.IsNullOrEmpty(podd.Id))
            {
                return;
            }

            if (!string.IsNullOrEmpty(podd.CategoryId))
            {
                bool found = false;
                for (int i = 0; i < cbPoddCatEdit.Items.Count; i++)
                {

                    if (cbPoddCatEdit.Items[i] is Category cat && cat.Id == podd.CategoryId)
                    {
                        cbPoddCatEdit.SelectedIndex = i;
                        found = true;
                        break;
                    }

                }


                try
                {
                    var episodes = await _episodeService.GetByPoddIdAsync(podd.Id);

                    dgvEpisodeRegister.AutoGenerateColumns = false;
                    dgvEpisodeRegister.Columns.Clear();

                    var titleCol = new DataGridViewTextBoxColumn
                    {
                        DataPropertyName = "Title",
                        HeaderText = "Avsnitt",
                        AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
                    };

                    var dateCol = new DataGridViewTextBoxColumn
                    {
                        DataPropertyName = "AirDate",
                        HeaderText = "Publicerad",
                        DefaultCellStyle = { Format = "yyyy-MM-dd" }
                    };

                    dgvEpisodeRegister.Columns.Add(titleCol);
                    dgvEpisodeRegister.Columns.Add(dateCol);

                    dgvEpisodeRegister.DataSource = episodes;

                    rtbDescription.Clear();
                }

                catch (Exception ex)
                {
                    MessageBox.Show("Kunde inte hämta avsnitt för vald podd:\r\n" + ex.Message);
                }

            }
        }

        private void dgvEpisodeRegister_SelectionChanged(object? sender, EventArgs e)
        {
            if (dgvEpisodeRegister.CurrentRow?.DataBoundItem is not Episode ep)
            {
                return;
            }

            rtbDescription.Clear();

            // Titel
            rtbDescription.SelectionFont = new Font("Segoe UI", 10, FontStyle.Bold);
            rtbDescription.AppendText("Titel: ");

            rtbDescription.SelectionFont = new Font("Segoe UI", 10, FontStyle.Regular);
            rtbDescription.AppendText((ep.Title ?? "(ingen titel)") + "\n\n");

            // Datum
            rtbDescription.SelectionFont = new Font("Segoe UI", 10, FontStyle.Bold);
            rtbDescription.AppendText("Publicerad: ");

            rtbDescription.SelectionFont = new Font("Segoe UI", 10, FontStyle.Regular);
            string dateText = ep.AirDate.HasValue
                ? ep.AirDate.Value.ToString("yyyy-MM-dd HH:mm")
                : "(okänt datum)";
            rtbDescription.AppendText(dateText + "\n\n");

            // Beskrivning
            rtbDescription.SelectionFont = new Font("Segoe UI", 10, FontStyle.Bold);
            rtbDescription.AppendText("Beskrivning:\n");

            rtbDescription.SelectionFont = new Font("Segoe UI", 10, FontStyle.Regular);
            rtbDescription.AppendText(ep.Description ?? "(ingen beskrivning)");
        }


        /// Hjälpmetod som tar bort HTML-taggar och dekodar HTML-entiteter.

        private string StripHtml(string? input)
        {
            if (string.IsNullOrWhiteSpace(input))
                return string.Empty;

            // Avkoda HTML-entiteter (&amp;, &quot; osv)
            string decoded = WebUtility.HtmlDecode(input);

            // Ta bort alla HTML-taggar <...>
            string noTags = Regex.Replace(decoded, "<.*?>", string.Empty);

            return noTags.Trim();
        }

        /// Klick på "Hämta"-knappen.
        /// Läser in RSS-flödet via IRssClientService och visar episoder i DataGridView.
        /// Endast Titel + Beskrivning (HTML-rensad) visas i gridden.

        private async void btnGetInfo_Click(object? sender, EventArgs e)
        {
            string url = txtUrlInput.Text.Trim();

            if (string.IsNullOrWhiteSpace(url))
            {
                MessageBox.Show("Ange en RSS-länk.");
                return;
            }

            try
            {
                btnGetInfo.Enabled = false;
                rtbEpisodeInfo.Clear();
                dgvEpisodes.DataSource = null;

                // Hämta episoder via BusinessLayer-tjänsten
                List<Episode> episodes = await _rssClientService.GetEpisodesFromRssAsync(url);

                // Rensa HTML ur beskrivningar så det inte ser fult ut
                foreach (var ep in episodes)
                {
                    ep.Description = StripHtml(ep.Description);
                }

                _loadedEpisodes = episodes;

                // Visa BARA Titel + Beskrivning i gridden
                dgvEpisodes.AutoGenerateColumns = false;
                dgvEpisodes.Columns.Clear();

                var titleCol = new DataGridViewTextBoxColumn
                {
                    DataPropertyName = "Title",
                    HeaderText = "Titel",
                    AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
                };

                var descCol = new DataGridViewTextBoxColumn
                {
                    DataPropertyName = "Description",
                    HeaderText = "Beskrivning",
                    AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
                };

                dgvEpisodes.Columns.Add(titleCol);
                dgvEpisodes.Columns.Add(descCol);

                dgvEpisodes.DataSource = episodes;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kunde inte läsa in RSS-flödet:\r\n" + ex.Message);
            }
            finally
            {
                btnGetInfo.Enabled = true;
            }
        }

        /// När användaren markerar en rad i DataGridView visas detaljer
        /// (titel, datum, beskrivning) i RichTextBox:en.

        private void dgvEpisodes_SelectionChanged(object? sender, EventArgs e)
        {
            if (dgvEpisodes.CurrentRow?.DataBoundItem is Episode ep)
            {
                rtbEpisodeInfo.Clear();

                // Titel
                rtbEpisodeInfo.SelectionFont = new Font("Segoe UI", 10, FontStyle.Bold);
                rtbEpisodeInfo.AppendText("Titel: ");

                rtbEpisodeInfo.SelectionFont = new Font("Segoe UI", 10, FontStyle.Regular);
                rtbEpisodeInfo.AppendText((ep.Title ?? "(ingen titel)") + "\n\n");

                // Datum
                rtbEpisodeInfo.SelectionFont = new Font("Segoe UI", 10, FontStyle.Bold);
                rtbEpisodeInfo.AppendText("Publicerad: ");

                rtbEpisodeInfo.SelectionFont = new Font("Segoe UI", 10, FontStyle.Regular);
                string dateText = ep.AirDate.HasValue
                    ? ep.AirDate.Value.ToString("yyyy-MM-dd HH:mm")
                    : "(okänt datum)";
                rtbEpisodeInfo.AppendText(dateText + "\n\n");

                // Beskrivning
                rtbEpisodeInfo.SelectionFont = new Font("Segoe UI", 10, FontStyle.Bold);
                rtbEpisodeInfo.AppendText("Beskrivning:\n");

                rtbEpisodeInfo.SelectionFont = new Font("Segoe UI", 10, FontStyle.Regular);
                rtbEpisodeInfo.AppendText(ep.Description ?? "(ingen beskrivning)");
            }
        }
        private async void btnSave_Click(object? sender, EventArgs e)
        {
            if (_loadedEpisodes == null || _loadedEpisodes.Count == 0)
            {
                MessageBox.Show("Du måste läsa in ett RSS-flöde innan du kan spara!");
                return;
            }
            string url = txtUrlInput.Text.Trim();
            if (string.IsNullOrWhiteSpace(url))
            {
                MessageBox.Show("RSS-länken saknas!");
                return;
            }
            string poddName = txtPoddName.Text.Trim();
            if (string.IsNullOrWhiteSpace(poddName) || poddName == "Ange namn till flödet")
            {
                MessageBox.Show("Ange ett namn för poddflödet!");
                return;
            }
            string? categoryId = null;
            if (cbCategory.SelectedItem is Category selectedCategory)
            {
                categoryId = selectedCategory.Id;

            }
            try
            {
                btnSave.Enabled = false;
                var podd = new Podd
                {
                    Name = poddName,
                    Url = url,
                    CategoryId = categoryId

                };
                await _poddService.AddAsync(podd);
                if (string.IsNullOrEmpty(podd.Id))
                {
                    MessageBox.Show("Kunde inte få tillbaka poddens Id efter sparande.");
                    return;

                }
                foreach (var ep in _loadedEpisodes)
                {
                    ep.PoddId = podd.Id;
                    await _episodeService.AddAsync(ep);
                }
                MessageBox.Show("Du har sparat ner poddflödet.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Något gick fel när du skulle spara flödet:\r\n" + ex.Message);
            }
            finally
            {
                btnSave.Enabled = true;
            }
        }

        private async void btnEditCat_Click(object? sender, EventArgs e)
        {
            if (dgvPoddNames.CurrentRow?.DataBoundItem is not Podd podd || string.IsNullOrEmpty(podd.Id))
            {
                MessageBox.Show("Välj ett poddflöde i listan först!");
                return;
            }

            if (cbPoddCatEdit.SelectedItem is not Category selectedCategory || string.IsNullOrEmpty(selectedCategory.Id))
            {
                MessageBox.Show("Välj en kategori att sätta på poddflödet!");
                return;
            }

            try
            {
                podd.CategoryId = selectedCategory.Id;

                bool ok = await _poddService.UpdateAsync(podd);

                if (!ok)
                {
                    MessageBox.Show("Poddens kategori kunde inte uppdateras.");
                    return;
                }

                await LoadPoddRegisterAsync();

                MessageBox.Show("Poddens kategori har uppdaterats.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fel vid uppdatering av poddens kategori:\r\n" + ex.Message);
            }
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void btnEditPodd_click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        //private void btnEditPod_Click(object sender, EventArgs e)
        //{

        //}

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            if(dgvPoddNames.CurrentRow?.DataBoundItem is not Podd podd || string.IsNullOrEmpty(podd.Id))
            {
                MessageBox.Show("Välj ett poddflöde i listan först!");
                return;
            }

            var confirm = MessageBox.Show($"Är du säker på att du vill ta bort poddflödet \"{podd.Name}\"?",
                "Bekräfta borttagning",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if ( confirm!= DialogResult.Yes)
            {
                return;
            }

            try
            {

                var episodes = await _episodeService.GetByPoddIdAsync(podd.Id);

                foreach (var ep in episodes)
                {

                    if (!string.IsNullOrEmpty(ep.Id))
                    {
                        await _episodeService.DeleteAsync(ep.Id);
                    }

                }

                bool ok = await _poddService.DeleteAsync(podd.Id);

                if (!ok)
                {
                    MessageBox.Show("Poddflödet kunde inte tas bort.");
                    return;
                }

                await LoadPoddRegisterAsync();

                dgvEpisodeRegister.DataSource = null;
                rtbDescription.Clear();

                MessageBox.Show("Poddflödet har tagits bort.");
            }

            catch (Exception ex)
            {
                MessageBox.Show("Fel vid borttagning av poddflödet:\r\n" + ex.Message);
            }

        }
    }
}