using System;
using System.Collections.Generic;
using System.Drawing;
using System.Net;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using BusinessLayer;
using BusinessLayer.IServices;
using ModelsLayer;

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

            dgvEpisodes.SelectionChanged += dgvEpisodes_SelectionChanged;

            // RichTextBox ska bara visa info
            rtxtEpisodeInfo.ReadOnly = true;
            rtxtEpisodeInfo.WordWrap = true;
            rtxtEpisodeInfo.ScrollBars = RichTextBoxScrollBars.Vertical;
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
                rtxtEpisodeInfo.Clear();
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
                rtxtEpisodeInfo.Clear();

                // Titel
                rtxtEpisodeInfo.SelectionFont = new Font("Segoe UI", 10, FontStyle.Bold);
                rtxtEpisodeInfo.AppendText("Titel: ");

                rtxtEpisodeInfo.SelectionFont = new Font("Segoe UI", 10, FontStyle.Regular);
                rtxtEpisodeInfo.AppendText((ep.Title ?? "(ingen titel)") + "\n\n");

                // Datum
                rtxtEpisodeInfo.SelectionFont = new Font("Segoe UI", 10, FontStyle.Bold);
                rtxtEpisodeInfo.AppendText("Publicerad: ");

                rtxtEpisodeInfo.SelectionFont = new Font("Segoe UI", 10, FontStyle.Regular);
                string dateText = ep.AirDate.HasValue
                    ? ep.AirDate.Value.ToString("yyyy-MM-dd HH:mm")
                    : "(okänt datum)";
                rtxtEpisodeInfo.AppendText(dateText + "\n\n");

                // Beskrivning
                rtxtEpisodeInfo.SelectionFont = new Font("Segoe UI", 10, FontStyle.Bold);
                rtxtEpisodeInfo.AppendText("Beskrivning:\n");

                rtxtEpisodeInfo.SelectionFont = new Font("Segoe UI", 10, FontStyle.Regular);
                rtxtEpisodeInfo.AppendText(ep.Description ?? "(ingen beskrivning)");
            }
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void btnEditPodd_click(object sender, EventArgs e)
        {

        }
    }
}