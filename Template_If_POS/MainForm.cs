using System.Globalization;
using Template_If_POS.Classes;

namespace Template_If_POS
{
    public partial class MainForm : Form
    {
        /// <summary>
        /// Eine Liste zum speichern der Filme und Serien
        /// </summary>
        public List<Movie> movies = new List<Movie>();

        /// <summary>
        /// Der Konstruktor
        /// Dieser wird als erstes aufgerufen
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Dieses Event wird aufgerufen, wenn die Benutzeroberfläche geladen wird
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            SampleList();
            SetupListView();
            LoadListView();
        }

        /// <summary>
        /// Diese Methode richtet die zwei ListView-Elemente ein
        /// </summary>
        private void SetupListView()
        {
            catalogView.Items.Clear();
            catalogView.Columns.Clear();

            catalogView.View = View.Details;
            catalogView.GridLines = true;
            catalogView.FullRowSelect = true;

            catalogView.Columns.Add("Film/Serie", 250);
            catalogView.Columns.Add("Staffel", 50);
            catalogView.Columns.Add("Altersfreigabe", 80);
            catalogView.Columns.Add("Preis", 60);

            billView.Items.Clear();
            billView.Columns.Clear();

            billView.View = View.Details;
            billView.GridLines = true;
            billView.FullRowSelect = true;

            billView.Columns.Add("Film/Serie", 250);
            billView.Columns.Add("Staffel", 50);
            billView.Columns.Add("Altersfreigabe", 80);
            billView.Columns.Add("Preis", 60);

        }

        /// <summary>
        /// Diese Methode schreibt Filme und Serien manuell in die oben definierte Liste
        /// </summary>
        private void SampleList()
        {
            movies.Add(new Movie("Wednesday", 1, 21.30f, 12));
            movies.Add(new Movie("Der Herr der Ringe: Die Ringe der Macht", 0, 25f, 12));
            movies.Add(new Movie("Halloween Ends", 0, 14.50f, 18));
            movies.Add(new Movie("Scream (2022)", 0, 16.99f, 16));
            movies.Add(new Movie("The Walking Dead", 2, 24.99f, 18));
            movies.Add(new Movie("The Walking Dead", 3, 22.99f, 18));
        }

        /// <summary>
        /// Diese Methode lädt die Daten der Liste in das ListView-Element
        /// </summary>
        private void LoadListView()
        {
            catalogView.Items.Clear();
            foreach(Movie movie in movies)
            {
                string[] itemArr = new string[4];
                itemArr[0] = movie.Name;

                if (movie.Season == 0)
                    itemArr[1] = "Film";
                else
                    itemArr[1] = movie.Season.ToString();

                itemArr[2] = movie.AgeRating.ToString();
                itemArr[3] = movie.Price.ToString("C", CultureInfo.CurrentCulture);


                ListViewItem item = new ListViewItem(itemArr);
                catalogView.Items.Add(item);
            }

        }

        /// <summary>
        /// Dieses Event wird aufgerufen, wenn der Produkt hinzufügen Button gedrückt wird
        /// Hier wird das gewählte Element in die Rechnungsliste eingefügt
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addProductButton_Click(object sender, EventArgs e)
        {
            if(catalogView.SelectedItems.Count == 0) return;


            ListViewItem copyItem = (ListViewItem)catalogView.SelectedItems[0].Clone();
            billView.Items.Add(copyItem);
        }

        /// <summary>
        /// Dieses Event wird aufgerufen, wenn der Produkt entfernen Button gedrückt wird
        /// Hier wird das gewählte Element gelöscht
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void removeProductButton_Click(object sender, EventArgs e)
        {
            if(billView.SelectedItems.Count == 0) return;

            billView.Items.Remove(billView.SelectedItems[0]);
        }

        /// <summary>
        /// Dieses Event wird aufgerufen, wenn Liste leeren Button gedrückt wird
        /// Hier wird die Rechnungsliste geleert
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void clearBillButton_Click(object sender, EventArgs e) => billView.Items.Clear();

        /// <summary>
        /// Dieses Event wird aufgerufen, wenn der Bezahlen Button gedrückt wird
        /// Hier wird die Methode der Alterswarnung aufgerufen, der Preis berechnet und der Endpreis ausgegeben
        /// Anschließend wird die Rechnungsliste geleert.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void payButton_Click(object sender, EventArgs e)
        {
            float sum = 0;

            foreach(var item in billView.Items)
            {
                var itemObj = (ListViewItem)item;
                var price = float.Parse(itemObj.SubItems[3].Text, NumberStyles.AllowCurrencySymbol | NumberStyles.Currency);
                sum += price;
            }

            MessageBox.Show("Zu bezahlen sind: " + sum.ToString("C", CultureInfo.CurrentCulture), "Bezahlen");
            clearBillButton_Click(sender, e);
        }
    }
}