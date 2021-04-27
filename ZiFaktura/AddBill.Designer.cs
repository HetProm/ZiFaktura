
namespace ZiFaktura
{
    partial class AddBill
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

        #region Kod wygenerowany przez Projektanta składników

        /// <summary> 
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować 
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxbrutto = new System.Windows.Forms.TextBox();
            this.textBoxvat = new System.Windows.Forms.TextBox();
            this.texboxnetto = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.textboxpay = new System.Windows.Forms.TextBox();
            this.textboxcountry = new System.Windows.Forms.TextBox();
            this.textBoxcity = new System.Windows.Forms.TextBox();
            this.textBoxpostcode = new System.Windows.Forms.TextBox();
            this.texboxaddress = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxnip = new System.Windows.Forms.TextBox();
            this.textBoxlastname = new System.Windows.Forms.TextBox();
            this.texboxFirstname = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.texboxdocument = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonadd = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1032, 703);
            this.panel1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.label10, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.label9, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.textBoxbrutto, 3, 5);
            this.tableLayoutPanel1.Controls.Add(this.textBoxvat, 2, 5);
            this.tableLayoutPanel1.Controls.Add(this.texboxnetto, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.label16, 3, 4);
            this.tableLayoutPanel1.Controls.Add(this.label15, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.label14, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.label13, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.textboxpay, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.textboxcountry, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.textBoxcity, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.textBoxpostcode, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.texboxaddress, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label8, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.label7, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.label6, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.textBoxnip, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.textBoxlastname, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.texboxFirstname, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label4, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.texboxdocument, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.buttonadd, 3, 7);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 0, 5);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 8;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1032, 703);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label10.Font = new System.Drawing.Font("Microsoft YaHei Light", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(261, 523);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(250, 86);
            this.label10.TabIndex = 33;
            this.label10.Text = "Kraj";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label9.Font = new System.Drawing.Font("Microsoft YaHei Light", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(4, 523);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(250, 86);
            this.label9.TabIndex = 32;
            this.label9.Text = "Sposób płatności";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxbrutto
            // 
            this.textBoxbrutto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxbrutto.Location = new System.Drawing.Point(775, 439);
            this.textBoxbrutto.Multiline = true;
            this.textBoxbrutto.Name = "textBoxbrutto";
            this.textBoxbrutto.ReadOnly = true;
            this.textBoxbrutto.Size = new System.Drawing.Size(253, 80);
            this.textBoxbrutto.TabIndex = 31;
            // 
            // textBoxvat
            // 
            this.textBoxvat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxvat.Location = new System.Drawing.Point(518, 439);
            this.textBoxvat.Multiline = true;
            this.textBoxvat.Name = "textBoxvat";
            this.textBoxvat.Size = new System.Drawing.Size(250, 80);
            this.textBoxvat.TabIndex = 30;
            this.textBoxvat.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxvat_Validating);
            // 
            // texboxnetto
            // 
            this.texboxnetto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.texboxnetto.Location = new System.Drawing.Point(261, 439);
            this.texboxnetto.Multiline = true;
            this.texboxnetto.Name = "texboxnetto";
            this.texboxnetto.Size = new System.Drawing.Size(250, 80);
            this.texboxnetto.TabIndex = 29;
            this.texboxnetto.Validating += new System.ComponentModel.CancelEventHandler(this.texboxnetto_Validating);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label16.Font = new System.Drawing.Font("Microsoft YaHei Light", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label16.Location = new System.Drawing.Point(775, 349);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(253, 86);
            this.label16.TabIndex = 27;
            this.label16.Text = "Brutto";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label15.Font = new System.Drawing.Font("Microsoft YaHei Light", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label15.Location = new System.Drawing.Point(518, 349);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(250, 86);
            this.label15.TabIndex = 26;
            this.label15.Text = "Vat";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label14.Font = new System.Drawing.Font("Microsoft YaHei Light", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label14.Location = new System.Drawing.Point(261, 349);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(250, 86);
            this.label14.TabIndex = 25;
            this.label14.Text = "Netto";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label13.Font = new System.Drawing.Font("Microsoft YaHei Light", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label13.Location = new System.Drawing.Point(4, 349);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(250, 86);
            this.label13.TabIndex = 24;
            this.label13.Text = "Data sprzedaży";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textboxpay
            // 
            this.textboxpay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textboxpay.Location = new System.Drawing.Point(4, 613);
            this.textboxpay.Multiline = true;
            this.textboxpay.Name = "textboxpay";
            this.textboxpay.Size = new System.Drawing.Size(250, 86);
            this.textboxpay.TabIndex = 19;
            this.textboxpay.Validating += new System.ComponentModel.CancelEventHandler(this.textboxpay_Validating);
            // 
            // textboxcountry
            // 
            this.textboxcountry.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textboxcountry.Location = new System.Drawing.Point(261, 613);
            this.textboxcountry.Multiline = true;
            this.textboxcountry.Name = "textboxcountry";
            this.textboxcountry.Size = new System.Drawing.Size(250, 86);
            this.textboxcountry.TabIndex = 18;
            this.textboxcountry.Validating += new System.ComponentModel.CancelEventHandler(this.textboxcountry_Validating);
            // 
            // textBoxcity
            // 
            this.textBoxcity.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxcity.Location = new System.Drawing.Point(518, 265);
            this.textBoxcity.Multiline = true;
            this.textBoxcity.Name = "textBoxcity";
            this.textBoxcity.Size = new System.Drawing.Size(250, 80);
            this.textBoxcity.TabIndex = 14;
            this.textBoxcity.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxcity_Validating);
            // 
            // textBoxpostcode
            // 
            this.textBoxpostcode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxpostcode.Location = new System.Drawing.Point(261, 265);
            this.textBoxpostcode.Multiline = true;
            this.textBoxpostcode.Name = "textBoxpostcode";
            this.textBoxpostcode.Size = new System.Drawing.Size(250, 80);
            this.textBoxpostcode.TabIndex = 13;
            this.textBoxpostcode.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxpostcode_Validating);
            // 
            // texboxaddress
            // 
            this.texboxaddress.Dock = System.Windows.Forms.DockStyle.Fill;
            this.texboxaddress.Location = new System.Drawing.Point(4, 265);
            this.texboxaddress.Multiline = true;
            this.texboxaddress.Name = "texboxaddress";
            this.texboxaddress.Size = new System.Drawing.Size(250, 80);
            this.texboxaddress.TabIndex = 12;
            this.texboxaddress.Validating += new System.ComponentModel.CancelEventHandler(this.texboxaddress_Validating);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei Light", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(775, 175);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(253, 86);
            this.label8.TabIndex = 11;
            this.label8.Text = "Data wystawienia";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei Light", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(518, 175);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(250, 86);
            this.label7.TabIndex = 10;
            this.label7.Text = "Miasto";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei Light", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(261, 175);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(250, 86);
            this.label6.TabIndex = 9;
            this.label6.Text = "Kod pocztowy";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei Light", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(4, 175);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(250, 86);
            this.label5.TabIndex = 8;
            this.label5.Text = "Adres";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxnip
            // 
            this.textBoxnip.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxnip.Location = new System.Drawing.Point(775, 91);
            this.textBoxnip.Multiline = true;
            this.textBoxnip.Name = "textBoxnip";
            this.textBoxnip.Size = new System.Drawing.Size(253, 80);
            this.textBoxnip.TabIndex = 7;
            this.textBoxnip.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxnip_Validating);
            // 
            // textBoxlastname
            // 
            this.textBoxlastname.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxlastname.Location = new System.Drawing.Point(518, 91);
            this.textBoxlastname.Multiline = true;
            this.textBoxlastname.Name = "textBoxlastname";
            this.textBoxlastname.Size = new System.Drawing.Size(250, 80);
            this.textBoxlastname.TabIndex = 6;
            this.textBoxlastname.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxlastname_Validating);
            // 
            // texboxFirstname
            // 
            this.texboxFirstname.Dock = System.Windows.Forms.DockStyle.Fill;
            this.texboxFirstname.Location = new System.Drawing.Point(261, 91);
            this.texboxFirstname.Multiline = true;
            this.texboxFirstname.Name = "texboxFirstname";
            this.texboxFirstname.Size = new System.Drawing.Size(250, 80);
            this.texboxFirstname.TabIndex = 5;
            this.texboxFirstname.Validating += new System.ComponentModel.CancelEventHandler(this.texboxFirstname_Validating);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei Light", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(775, 1);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(253, 86);
            this.label4.TabIndex = 4;
            this.label4.Text = "NIP";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei Light", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(518, 1);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(250, 86);
            this.label3.TabIndex = 3;
            this.label3.Text = "Nazwisko";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei Light", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(261, 1);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(250, 86);
            this.label2.TabIndex = 2;
            this.label2.Text = "Imię";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // texboxdocument
            // 
            this.texboxdocument.Dock = System.Windows.Forms.DockStyle.Fill;
            this.texboxdocument.Location = new System.Drawing.Point(4, 91);
            this.texboxdocument.Multiline = true;
            this.texboxdocument.Name = "texboxdocument";
            this.texboxdocument.Size = new System.Drawing.Size(250, 80);
            this.texboxdocument.TabIndex = 0;
            this.texboxdocument.Validating += new System.ComponentModel.CancelEventHandler(this.texboxdocument_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei Light", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(4, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(250, 86);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nazwa";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonadd
            // 
            this.buttonadd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonadd.Location = new System.Drawing.Point(775, 613);
            this.buttonadd.Name = "buttonadd";
            this.buttonadd.Size = new System.Drawing.Size(253, 86);
            this.buttonadd.TabIndex = 34;
            this.buttonadd.Text = "Dodaj";
            this.buttonadd.UseVisualStyleBackColor = true;
            this.buttonadd.Click += new System.EventHandler(this.buttonadd_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.dateTimePicker1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(775, 265);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(253, 80);
            this.panel2.TabIndex = 35;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarTrailingForeColor = System.Drawing.SystemColors.ControlDark;
            this.dateTimePicker1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(251, 27);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.dateTimePicker2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(4, 439);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(250, 80);
            this.panel3.TabIndex = 36;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CalendarTrailingForeColor = System.Drawing.SystemColors.ControlDark;
            this.dateTimePicker2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(0, 0);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(248, 27);
            this.dateTimePicker2.TabIndex = 0;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // AddBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "AddBill";
            this.Size = new System.Drawing.Size(1032, 703);
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBoxpostcode;
        private System.Windows.Forms.TextBox texboxaddress;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxnip;
        private System.Windows.Forms.TextBox textBoxlastname;
        private System.Windows.Forms.TextBox texboxFirstname;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox texboxdocument;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxbrutto;
        private System.Windows.Forms.TextBox textBoxvat;
        private System.Windows.Forms.TextBox texboxnetto;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textboxpay;
        private System.Windows.Forms.TextBox textboxcountry;
        private System.Windows.Forms.TextBox F;
        private System.Windows.Forms.TextBox T;
        private System.Windows.Forms.TextBox men;
        private System.Windows.Forms.TextBox textBoxcity;
        private System.Windows.Forms.Button buttonadd;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
    }
}
