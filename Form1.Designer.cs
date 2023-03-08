namespace BAZA_DANYCH_W
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label płećLabel;
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.tabelaosobTabelaksiazkiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button_dodaj = new System.Windows.Forms.Button();
            this.button_usun = new System.Windows.Forms.Button();
            this.textBox_adres = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_nazwisko = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_imie = new System.Windows.Forms.TextBox();
            this.button_wczytaj = new System.Windows.Forms.Button();
            this.button_zapisz = new System.Windows.Forms.Button();
            this.button_edytuj = new System.Windows.Forms.Button();
            this.tabelaosobTabelaksiazkiBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tabelaosobTabelaksiazkiBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.tabelaosobTabelaksiazkiBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.płećTextBox = new System.Windows.Forms.TextBox();
            this.tabelaosobBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ZD = new BAZA_DANYCH_W.Zbior_danych();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazwiskoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adresDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.płećDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDosobyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tytułDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.autorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zDBindingSource = new System.Windows.Forms.BindingSource(this.components);
            płećLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabelaosobTabelaksiazkiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabelaosobTabelaksiazkiBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabelaosobTabelaksiazkiBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabelaosobTabelaksiazkiBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabelaosobBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ZD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zDBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn1,
            this.iDosobyDataGridViewTextBoxColumn,
            this.tytułDataGridViewTextBoxColumn,
            this.autorDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.tabelaosobTabelaksiazkiBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(867, 315);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(591, 357);
            this.dataGridView2.TabIndex = 1;
            // 
            // tabelaosobTabelaksiazkiBindingSource
            // 
            this.tabelaosobTabelaksiazkiBindingSource.DataMember = "Tabela_osob_Tabela_ksiazki";
            this.tabelaosobTabelaksiazkiBindingSource.DataSource = this.tabelaosobBindingSource;
            // 
            // button_dodaj
            // 
            this.button_dodaj.Location = new System.Drawing.Point(551, 200);
            this.button_dodaj.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_dodaj.Name = "button_dodaj";
            this.button_dodaj.Size = new System.Drawing.Size(125, 28);
            this.button_dodaj.TabIndex = 2;
            this.button_dodaj.Text = "Dodaj";
            this.button_dodaj.UseVisualStyleBackColor = true;
            this.button_dodaj.Click += new System.EventHandler(this.button_dodaj_click);
            // 
            // button_usun
            // 
            this.button_usun.Location = new System.Drawing.Point(818, 200);
            this.button_usun.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_usun.Name = "button_usun";
            this.button_usun.Size = new System.Drawing.Size(131, 28);
            this.button_usun.TabIndex = 3;
            this.button_usun.Text = "Usuń";
            this.button_usun.UseVisualStyleBackColor = true;
            this.button_usun.Click += new System.EventHandler(this.button_usun_Click);
            // 
            // textBox_adres
            // 
            this.textBox_adres.Location = new System.Drawing.Point(505, 126);
            this.textBox_adres.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox_adres.Name = "textBox_adres";
            this.textBox_adres.Size = new System.Drawing.Size(501, 22);
            this.textBox_adres.TabIndex = 4;
            this.textBox_adres.Text = "Jakis_adres";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(505, 106);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Adres";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(505, 58);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Nazwisko";
            // 
            // textBox_nazwisko
            // 
            this.textBox_nazwisko.Location = new System.Drawing.Point(505, 78);
            this.textBox_nazwisko.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox_nazwisko.Name = "textBox_nazwisko";
            this.textBox_nazwisko.Size = new System.Drawing.Size(501, 22);
            this.textBox_nazwisko.TabIndex = 6;
            this.textBox_nazwisko.Text = "Kowalski";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(509, 10);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Imię";
            // 
            // textBox_imie
            // 
            this.textBox_imie.Location = new System.Drawing.Point(505, 30);
            this.textBox_imie.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox_imie.Name = "textBox_imie";
            this.textBox_imie.Size = new System.Drawing.Size(501, 22);
            this.textBox_imie.TabIndex = 8;
            this.textBox_imie.Text = "Michał";
            // 
            // button_wczytaj
            // 
            this.button_wczytaj.Location = new System.Drawing.Point(1279, 262);
            this.button_wczytaj.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_wczytaj.Name = "button_wczytaj";
            this.button_wczytaj.Size = new System.Drawing.Size(179, 28);
            this.button_wczytaj.TabIndex = 10;
            this.button_wczytaj.Text = "Wczytaj baze";
            this.button_wczytaj.UseVisualStyleBackColor = true;
            this.button_wczytaj.Click += new System.EventHandler(this.button_wczytaj_click);
            // 
            // button_zapisz
            // 
            this.button_zapisz.Location = new System.Drawing.Point(1279, 226);
            this.button_zapisz.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_zapisz.Name = "button_zapisz";
            this.button_zapisz.Size = new System.Drawing.Size(179, 28);
            this.button_zapisz.TabIndex = 11;
            this.button_zapisz.Text = "Zapisz baze";
            this.button_zapisz.UseVisualStyleBackColor = true;
            this.button_zapisz.Click += new System.EventHandler(this.button_zapisz_Click);
            // 
            // button_edytuj
            // 
            this.button_edytuj.Location = new System.Drawing.Point(685, 200);
            this.button_edytuj.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_edytuj.Name = "button_edytuj";
            this.button_edytuj.Size = new System.Drawing.Size(125, 28);
            this.button_edytuj.TabIndex = 12;
            this.button_edytuj.Text = "Edytuj";
            this.button_edytuj.UseVisualStyleBackColor = true;
            this.button_edytuj.Click += new System.EventHandler(this.button_edytuj_Click);
            // 
            // tabelaosobTabelaksiazkiBindingSource1
            // 
            this.tabelaosobTabelaksiazkiBindingSource1.DataMember = "Tabela_osob_Tabela_ksiazki";
            this.tabelaosobTabelaksiazkiBindingSource1.DataSource = this.tabelaosobBindingSource;
            // 
            // tabelaosobTabelaksiazkiBindingSource2
            // 
            this.tabelaosobTabelaksiazkiBindingSource2.DataMember = "Tabela_osob_Tabela_ksiazki";
            this.tabelaosobTabelaksiazkiBindingSource2.DataSource = this.tabelaosobBindingSource;
            // 
            // tabelaosobTabelaksiazkiBindingSource3
            // 
            this.tabelaosobTabelaksiazkiBindingSource3.DataMember = "Tabela_osob_Tabela_ksiazki";
            this.tabelaosobTabelaksiazkiBindingSource3.DataSource = this.tabelaosobBindingSource;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.imieDataGridViewTextBoxColumn,
            this.nazwiskoDataGridViewTextBoxColumn,
            this.adresDataGridViewTextBoxColumn,
            this.płećDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tabelaosobBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(20, 271);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(839, 401);
            this.dataGridView1.TabIndex = 13;
            // 
            // płećLabel
            // 
            płećLabel.AutoSize = true;
            płećLabel.Location = new System.Drawing.Point(508, 152);
            płećLabel.Name = "płećLabel";
            płećLabel.Size = new System.Drawing.Size(40, 16);
            płećLabel.TabIndex = 13;
            płećLabel.Text = "Płeć:";
            // 
            // płećTextBox
            // 
            this.płećTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tabelaosobBindingSource, "Płeć", true));
            this.płećTextBox.Location = new System.Drawing.Point(508, 171);
            this.płećTextBox.Name = "płećTextBox";
            this.płećTextBox.Size = new System.Drawing.Size(501, 22);
            this.płećTextBox.TabIndex = 14;
            // 
            // tabelaosobBindingSource
            // 
            this.tabelaosobBindingSource.DataMember = "Tabela_osob";
            this.tabelaosobBindingSource.DataSource = this.ZD;
            // 
            // ZD
            // 
            this.ZD.DataSetName = "Zbior_danych";
            this.ZD.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDDataGridViewTextBoxColumn.Width = 125;
            // 
            // imieDataGridViewTextBoxColumn
            // 
            this.imieDataGridViewTextBoxColumn.DataPropertyName = "Imie";
            this.imieDataGridViewTextBoxColumn.HeaderText = "Imie";
            this.imieDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.imieDataGridViewTextBoxColumn.Name = "imieDataGridViewTextBoxColumn";
            this.imieDataGridViewTextBoxColumn.Width = 125;
            // 
            // nazwiskoDataGridViewTextBoxColumn
            // 
            this.nazwiskoDataGridViewTextBoxColumn.DataPropertyName = "Nazwisko";
            this.nazwiskoDataGridViewTextBoxColumn.HeaderText = "Nazwisko";
            this.nazwiskoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nazwiskoDataGridViewTextBoxColumn.Name = "nazwiskoDataGridViewTextBoxColumn";
            this.nazwiskoDataGridViewTextBoxColumn.Width = 125;
            // 
            // adresDataGridViewTextBoxColumn
            // 
            this.adresDataGridViewTextBoxColumn.DataPropertyName = "Adres";
            this.adresDataGridViewTextBoxColumn.HeaderText = "Adres";
            this.adresDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.adresDataGridViewTextBoxColumn.Name = "adresDataGridViewTextBoxColumn";
            this.adresDataGridViewTextBoxColumn.Width = 125;
            // 
            // płećDataGridViewTextBoxColumn
            // 
            this.płećDataGridViewTextBoxColumn.DataPropertyName = "Płeć";
            this.płećDataGridViewTextBoxColumn.HeaderText = "Płeć";
            this.płećDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.płećDataGridViewTextBoxColumn.Name = "płećDataGridViewTextBoxColumn";
            this.płećDataGridViewTextBoxColumn.Width = 125;
            // 
            // iDDataGridViewTextBoxColumn1
            // 
            this.iDDataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn1.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.iDDataGridViewTextBoxColumn1.Name = "iDDataGridViewTextBoxColumn1";
            this.iDDataGridViewTextBoxColumn1.ReadOnly = true;
            this.iDDataGridViewTextBoxColumn1.Width = 125;
            // 
            // iDosobyDataGridViewTextBoxColumn
            // 
            this.iDosobyDataGridViewTextBoxColumn.DataPropertyName = "ID_osoby";
            this.iDosobyDataGridViewTextBoxColumn.HeaderText = "ID_osoby";
            this.iDosobyDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDosobyDataGridViewTextBoxColumn.Name = "iDosobyDataGridViewTextBoxColumn";
            this.iDosobyDataGridViewTextBoxColumn.Width = 125;
            // 
            // tytułDataGridViewTextBoxColumn
            // 
            this.tytułDataGridViewTextBoxColumn.DataPropertyName = "Tytuł";
            this.tytułDataGridViewTextBoxColumn.HeaderText = "Tytuł";
            this.tytułDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tytułDataGridViewTextBoxColumn.Name = "tytułDataGridViewTextBoxColumn";
            this.tytułDataGridViewTextBoxColumn.Width = 125;
            // 
            // autorDataGridViewTextBoxColumn
            // 
            this.autorDataGridViewTextBoxColumn.DataPropertyName = "Autor";
            this.autorDataGridViewTextBoxColumn.HeaderText = "Autor";
            this.autorDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.autorDataGridViewTextBoxColumn.Name = "autorDataGridViewTextBoxColumn";
            this.autorDataGridViewTextBoxColumn.Width = 125;
            // 
            // zDBindingSource
            // 
            this.zDBindingSource.DataSource = this.ZD;
            this.zDBindingSource.Position = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1478, 692);
            this.Controls.Add(płećLabel);
            this.Controls.Add(this.płećTextBox);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button_edytuj);
            this.Controls.Add(this.button_zapisz);
            this.Controls.Add(this.button_wczytaj);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_imie);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_nazwisko);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_adres);
            this.Controls.Add(this.button_usun);
            this.Controls.Add(this.button_dodaj);
            this.Controls.Add(this.dataGridView2);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabelaosobTabelaksiazkiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabelaosobTabelaksiazkiBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabelaosobTabelaksiazkiBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabelaosobTabelaksiazkiBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabelaosobBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ZD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zDBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn imięDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button_dodaj;
        private System.Windows.Forms.Button button_usun;
        private System.Windows.Forms.TextBox textBox_adres;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_nazwisko;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_imie;
        private System.Windows.Forms.Button button_wczytaj;
        private System.Windows.Forms.Button button_zapisz;
        private Zbior_danych ZD;
        private System.Windows.Forms.BindingSource tabelaosobBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDosobyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tytułDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn autorDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource tabelaosobTabelaksiazkiBindingSource;
        private System.Windows.Forms.Button button_edytuj;
        private System.Windows.Forms.BindingSource tabelaosobTabelaksiazkiBindingSource1;
        private System.Windows.Forms.BindingSource tabelaosobTabelaksiazkiBindingSource2;
        private System.Windows.Forms.BindingSource zDBindingSource;
        private System.Windows.Forms.BindingSource tabelaosobTabelaksiazkiBindingSource3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn imieDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazwiskoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adresDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn płećDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox płećTextBox;
    }
}

