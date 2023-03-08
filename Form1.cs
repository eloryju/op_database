using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace BAZA_DANYCH_W
{
    public partial class Form1 : Form
    {
        string plik = null;

        public Form1()
        {
            InitializeComponent();
            dodaj_dane();
        }

        void dodaj_dane()
        {
            ZD.Tabela_osob.AddTabela_osobRow("Jan", "Pawel", "Wadowice","mezczyzna");
            ZD.Tabela_osob.AddTabela_osobRow("Mariusz", "Pudzianowski", "BuskoZdroj","kobieta");
            ZD.Tabela_osob.AddTabela_osobRow("Jan", "Pawel", "Wadowice","mezczyzna");
            ZD.Tabela_osob.AddTabela_osobRow("Adam", "Malysz", "Zakopane","mezczyzna");
            ZD.Tabela_osob.AddTabela_osobRow("Robert", "Kubica", "Warszawa", "mezczyzna");
            ZD.Tabela_osob.AddTabela_osobRow("Jan", "Matejko", "Krakow", "kobieta");
            ZD.Tabela_osob.AddTabela_osobRow("Kazimierz", "Wielki", "Gniezno", "kobieta");
            tabelaosobBindingSource.MoveLast();

            ZD.Tabela_ksiazki.AddTabela_ksiazkiRow(ZD.Tabela_osob.Where(x => x.Imie == "Jan").ToList()[0], "WladcaPierscieni", "Tolkien");
            ZD.Tabela_ksiazki.AddTabela_ksiazkiRow(ZD.Tabela_osob.Where(x => x.Imie == "Mariusz").ToList()[0], "Potop", "Sienkiewicz");
            ZD.Tabela_ksiazki.AddTabela_ksiazkiRow(ZD.Tabela_osob.Where(x => x.Imie == "Robert").ToList()[0], "lalka", "Zeromski");
            ZD.Tabela_ksiazki.AddTabela_ksiazkiRow(ZD.Tabela_osob.Where(x => x.Imie == "Robert").ToList()[0], "Przedwiosnie", "Zeromski");
            ZD.Tabela_ksiazki.AddTabela_ksiazkiRow(ZD.Tabela_osob.Where(x => x.Imie == "Jan").ToList()[0], "kordian", "Mickiewicz");
            ZD.Tabela_ksiazki.AddTabela_ksiazkiRow(ZD.Tabela_osob.Where(x => x.Imie == "Robert").ToList()[0], "Przedwiosnie", "Zeromski");
            ZD.Tabela_ksiazki.AddTabela_ksiazkiRow(ZD.Tabela_osob.Where(x => x.Imie == "Jan").ToList()[0], "dzuma", "Mickiewicz");
            ZD.Tabela_ksiazki.AddTabela_ksiazkiRow(ZD.Tabela_osob.Where(x => x.Imie == "Jan").ToList()[0], "Dziady", "Mickiewicz");
            ZD.Tabela_ksiazki.AddTabela_ksiazkiRow(ZD.Tabela_osob.Where(x => x.Imie == "Kazimierz").ToList()[0], "krzyzak", "Sienkiewicz");
            tabelaosobTabelaksiazkiBindingSource.MoveLast();
        }

        private void button_dodaj_click(object sender, EventArgs e)
        {
            if(ZD.Tabela_osob.Where(x=>x.Nazwisko==textBox_nazwisko.Text).Where(x=>x.Imie==textBox_imie.Text).Any())
            {
                switch (MessageBox.Show("Czy zapisać?","Osoba o takimi samym nazwisku i imieniu istnieje w bazie",  MessageBoxButtons.YesNo))
                {
                    case DialogResult.Yes:
                        ZD.Tabela_osob.AddTabela_osobRow(textBox_imie.Text, textBox_nazwisko.Text, textBox_adres.Text, płećTextBox.Text);
                        break;
                    case DialogResult.No:
                        break;
                    default:
                        break;
                }               
            }
            else
            {
                ZD.Tabela_osob.AddTabela_osobRow(textBox_imie.Text, textBox_nazwisko.Text, textBox_adres.Text, płećTextBox.Text);
            }
        }

        private void button_usun_Click(object sender, EventArgs e)
        {
            switch (MessageBox.Show("Czy usunac?", "Osoba o ta zostanie trwale usunieta z bazy danych", MessageBoxButtons.YesNo))
            {
                case DialogResult.Yes:
                    List<int> ID_list = new List<int>();
                    foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                    {
                        ID_list.Add((int)row.Cells[0].Value);
                    }
                    foreach (var ID_osoby in ID_list)
                    {
                        ZD.Tabela_osob.RemoveTabela_osobRow(ZD.Tabela_osob.Where(x => x.ID == ID_osoby).ToList()[0]);
                    }
                    break;
                case DialogResult.No:
                    break;
                   

            }
        }

            private void button_wczytaj_click(object sender, EventArgs e)
        {
            Zbior_danych temp = new Zbior_danych();

            temp.ReadXml("data.dat");
            ZD.Merge(temp, true, MissingSchemaAction.Ignore);
        
        }
        private void button_zapisz_Click(object sender, EventArgs e)
        {
            ZD.WriteXml("data.dat");
        }

        private void button_edytuj_Click(object sender, EventArgs e)
        {
            tabelaosobBindingSource.EndEdit();
            tabelaosobBindingSource.MoveLast();
        }

    }
}
