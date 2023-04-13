using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design.Serialization;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace Web
{
    public partial class FormBrowser : Form
    {
        public WebPage wp = new WebPage();
        public HistoryPage hp = new HistoryPage();
        public FavPage fp = new FavPage();
        public Rectangle origFormSize;
        public Rectangle origUCSize;
        public Rectangle origUCSizeHis;
        public Rectangle origUCSizeFav;
        public XmlDocument data = new XmlDocument();
        public XmlDocument dataFav = new XmlDocument();
        public int index = -1;
        public FormBrowser()
        {
            data.Load(@"./../../HistoryData.xml");
            dataFav.Load(@"./../../FavData.xml");
            wp.Location = new Point(0, 39);
            hp.Location = new Point(0, 39);
            fp.Location = new Point(0, 39);
            ToListHis(hp.hist, data.DocumentElement);
            ToListFav(fp.fav, dataFav.DocumentElement);
            InitializeComponent();
        }
        private void SearchKeyPressForMainSearchbar(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (String.IsNullOrEmpty(searchBar.Text) || searchBar.Text.Length > searchBar.MaxLength)
                {
                    MessageBox.Show("Некорректный ввод!");
                }
                else
                {
                    index += 1;
                    urlSearchBar.Text = searchBar.Text;
                    urlSearchBar.ReadOnly = false;
                    urlSearchBar.Enabled = true;
                    urlSearchPicture.Enabled = true;
                    urlSearchBar.Visible = true;
                    urlSearchPicture.Visible = true;
                    refreshPicture.Enabled = true;
                    stopPicture.Enabled = true;
                    addToFavPicture.Enabled = true;
                    wp.URL = urlSearchBar.Text;
                    wp.Navigate();
                    SetPage(wp);
                    SaveToXmlHis(urlSearchBar.Text);
                }
            }
        }
        private void searchPicture_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(searchBar.Text) || searchBar.Text.Length > searchBar.MaxLength)
            {
                MessageBox.Show("Некорректный ввод!");
            }
            else
            {
                index += 1;
                urlSearchBar.Text = searchBar.Text;
                urlSearchBar.ReadOnly = false;
                urlSearchBar.Enabled = true;
                urlSearchPicture.Enabled = true;
                urlSearchBar.Visible = true;
                urlSearchPicture.Visible = true;
                refreshPicture.Enabled = true;
                stopPicture.Enabled = true;
                addToFavPicture.Enabled = true;
                wp.URL = urlSearchBar.Text;
                wp.Navigate();
                SetPage(wp);
                SaveToXmlHis(urlSearchBar.Text);
            }
        }
        private void SetPage(UserControl wp)
        {
            wp.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top | AnchorStyles.Bottom;
            Controls.Add(wp);
            wp.BringToFront();
        }

        private void refreshPicture_Click(object sender, EventArgs e)
        {
            wp.Reload();
        }

        private void stopPicture_Click(object sender, EventArgs e)
        {
            wp.Cancel();
        }

        private void FormBrowser_Load(object sender, EventArgs e)
        {
            origUCSize = new Rectangle(wp.Location.X, wp.Location.Y, wp.Size.Width, wp.Size.Height);
            origUCSizeHis = new Rectangle(hp.Location.X, hp.Location.Y, hp.Size.Width, hp.Size.Height);
            origUCSizeFav = new Rectangle(fp.Location.X, fp.Location.Y, fp.Size.Width, fp.Size.Height);
            origFormSize = new Rectangle(this.Location.X, this.Location.Y, this.Size.Width, this.Size.Height);
        }

        private void ResizeUC(Rectangle r, Control us)
        {
            float xRatio = (float)this.Width / (float)origFormSize.Width;
            float yRatio = (float)this.Height / (float)origFormSize.Height;

            int newX = (int)(r.Location.X * xRatio);
            int newY = (int)(r.Location.Y * yRatio);

            int newWidth = (int)(r.Width * xRatio);
            int newHeight = (int)(r.Height * yRatio);

            us.Location = new Point(newX, newY);
            us.Size = new Size(newWidth, newHeight);
        }
        private void FormBrowser_Resize(object sender, EventArgs e)
        {
            ResizeUC(origUCSize, wp);
            ResizeUC(origUCSizeHis, hp);
            ResizeUC(origUCSizeFav, fp);
        }

        private void backPicture_Click(object sender, EventArgs e)
        {
            if (index >= 0 && index < hp.hist.Count)
            {
                urlSearchBar.Text = hp.hist[index - 1].Split(' ').ToArray()[0];
                index -= 1;
            }
            wp.Prev();
            forwardPicture.Enabled = true;

        }

        private void forwardPicture_Click(object sender, EventArgs e)
        {
            if (index >= 0 && index < hp.hist.Count)
            {
                urlSearchBar.Text = hp.hist[index + 1].Split(' ').ToArray()[0];
                index += 1;
            }
            wp.Next();
        }
         private void addToFavPicture_Click(object sender, EventArgs e)
         {
            SaveToListFav(urlSearchBar.Text);
         }
      
        private void историяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            hp.Show();
            hp.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top | AnchorStyles.Bottom;
            Controls.Add(hp);
            hp.ShowHistory(hp.hist);
            hp.BringToFront();
        }
        private void закладкиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            hp.Hide();
            fp.Show();
            fp.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top | AnchorStyles.Bottom;
            Controls.Add(fp);
            fp.ShowFav(fp.fav);
            fp.BringToFront();
        }
        public void SaveToXmlHis(string url)
        {
            XmlElement root = data.DocumentElement;
            XmlElement site = data.CreateElement("site");
            XmlElement URL = data.CreateElement("url");
            XmlElement date = data.CreateElement("date");
            XmlText urltext = data.CreateTextNode(url);
            XmlText datetext = data.CreateTextNode(DateTime.Now.ToString("dd.MM.yyyy | hh:mm:ss tt"));
            URL.AppendChild(urltext);
            date.AppendChild(datetext);
            site.AppendChild(URL);
            site.AppendChild(date);
            root.AppendChild(site);
            data.Save(@"./../../HistoryData.xml");
            hp.hist.Add($"{url} {DateTime.Now:dd.MM.yyyy | hh:mm:ss tt}");
        }
        public void SaveToListFav(string url)
        {
            dataFav.Load(@"./../../FavData.xml");
            XmlElement root = dataFav.DocumentElement;
            XmlElement site = dataFav.CreateElement("site");
            XmlElement URL = dataFav.CreateElement("url");
            XmlText urltext = dataFav.CreateTextNode(url);
            URL.AppendChild(urltext);
            site.AppendChild(URL);
            root.AppendChild(site);
            XmlNode node = dataFav.CreateNode(XmlNodeType.Element, "site", "");
            XmlNode url1 = dataFav.CreateNode(XmlNodeType.Element, "url", "");
            url1.InnerText = url;
            node.AppendChild(url1);
            root.AppendChild(node);
            dataFav.Save(@"./../../FavData.xml");
            fp.fav.Add($"{url}");
        }
        public void ToListHis(List<string> list, XmlElement doc) // добавление информации при запуске прграммы
        {
            foreach (XmlElement elem in doc)
            {
                list.Add($"{elem.ChildNodes[0].InnerText} {elem.ChildNodes[1].InnerText}");
            }
        }
        public void ToListFav(List<string> list, XmlElement doc) // добавление информации при запуске прграммы
        {
            foreach (XmlElement elem in doc)
            {
                list.Add($"{elem.ChildNodes[0].InnerText}");
            }
        }
        public void DeleteDataHis()
        {
            for (int i = 0; i < hp.hist.Count; i++)
            {
                XmlElement root = data.DocumentElement;
                XmlNode node = root.FirstChild;
                root.RemoveChild(node);
                data.Save(@"./../../HistoryData.xml");
            }
        }
        public void DeleteDataFav(string url)
        {
            XmlElement root = dataFav.DocumentElement;
            XmlNode node = root.SelectSingleNode($"site[url='{url}']");
            if (node != null)
            {
                root.RemoveChild(node);
                dataFav.Save(@"./../../FavData.xml");
            }
        }

        private void urlSearchPicture_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(urlSearchBar.Text) || urlSearchBar.Text.Length > urlSearchBar.MaxLength)
            {
                MessageBox.Show("Некорректный ввод!");
            }
            else
            {
                index += 1;
                wp.URL = urlSearchBar.Text;
                backPicture.Enabled = true;
                wp.Navigate();
                SaveToXmlHis(urlSearchBar.Text);
            }
        }
    }
}
