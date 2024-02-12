namespace InvestmentSistem
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tipoLabel = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dataCompraLabel = new System.Windows.Forms.Label();
            this.nomeAcaoFundoLabel = new System.Windows.Forms.Label();
            this.ValorLabel = new System.Windows.Forms.Label();
            this.quantidadeCotaLabel = new System.Windows.Forms.Label();
            this.nomeAcaoFundoTextBox = new System.Windows.Forms.TextBox();
            this.valorAcaoFundoTextBox = new System.Windows.Forms.TextBox();
            this.quantidadeCotaTextBox = new System.Windows.Forms.TextBox();
            this.salvarButton = new System.Windows.Forms.Button();
            this.dataCompraDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // tipoLabel
            // 
            this.tipoLabel.AutoSize = true;
            this.tipoLabel.Location = new System.Drawing.Point(60, 94);
            this.tipoLabel.Name = "tipoLabel";
            this.tipoLabel.Size = new System.Drawing.Size(39, 20);
            this.tipoLabel.TabIndex = 0;
            this.tipoLabel.Text = "Tipo";
            this.tipoLabel.Click += new System.EventHandler(this.tipoLabel_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "FII",
            "Ação"});
            this.comboBox1.Location = new System.Drawing.Point(220, 94);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(151, 28);
            this.comboBox1.TabIndex = 1;
            // 
            // dataCompraLabel
            // 
            this.dataCompraLabel.AutoSize = true;
            this.dataCompraLabel.Location = new System.Drawing.Point(56, 196);
            this.dataCompraLabel.Name = "dataCompraLabel";
            this.dataCompraLabel.Size = new System.Drawing.Size(119, 20);
            this.dataCompraLabel.TabIndex = 2;
            this.dataCompraLabel.Text = "Data de Compra";
            // 
            // nomeAcaoFundoLabel
            // 
            this.nomeAcaoFundoLabel.AutoSize = true;
            this.nomeAcaoFundoLabel.Location = new System.Drawing.Point(56, 248);
            this.nomeAcaoFundoLabel.Name = "nomeAcaoFundoLabel";
            this.nomeAcaoFundoLabel.Size = new System.Drawing.Size(156, 20);
            this.nomeAcaoFundoLabel.TabIndex = 3;
            this.nomeAcaoFundoLabel.Text = "Nome da Ação/Fundo";
            // 
            // ValorLabel
            // 
            this.ValorLabel.AutoSize = true;
            this.ValorLabel.Location = new System.Drawing.Point(56, 288);
            this.ValorLabel.Name = "ValorLabel";
            this.ValorLabel.Size = new System.Drawing.Size(43, 20);
            this.ValorLabel.TabIndex = 4;
            this.ValorLabel.Text = "Valor";
            // 
            // quantidadeCotaLabel
            // 
            this.quantidadeCotaLabel.AutoSize = true;
            this.quantidadeCotaLabel.Location = new System.Drawing.Point(56, 339);
            this.quantidadeCotaLabel.Name = "quantidadeCotaLabel";
            this.quantidadeCotaLabel.Size = new System.Drawing.Size(122, 20);
            this.quantidadeCotaLabel.TabIndex = 5;
            this.quantidadeCotaLabel.Text = "Quantidade Cota";
            // 
            // nomeAcaoFundoTextBox
            // 
            this.nomeAcaoFundoTextBox.Location = new System.Drawing.Point(220, 245);
            this.nomeAcaoFundoTextBox.Name = "nomeAcaoFundoTextBox";
            this.nomeAcaoFundoTextBox.Size = new System.Drawing.Size(151, 27);
            this.nomeAcaoFundoTextBox.TabIndex = 7;
            // 
            // valorAcaoFundoTextBox
            // 
            this.valorAcaoFundoTextBox.Location = new System.Drawing.Point(220, 288);
            this.valorAcaoFundoTextBox.Name = "valorAcaoFundoTextBox";
            this.valorAcaoFundoTextBox.Size = new System.Drawing.Size(151, 27);
            this.valorAcaoFundoTextBox.TabIndex = 8;
            // 
            // quantidadeCotaTextBox
            // 
            this.quantidadeCotaTextBox.Location = new System.Drawing.Point(220, 339);
            this.quantidadeCotaTextBox.Name = "quantidadeCotaTextBox";
            this.quantidadeCotaTextBox.Size = new System.Drawing.Size(151, 27);
            this.quantidadeCotaTextBox.TabIndex = 9;
            // 
            // salvarButton
            // 
            this.salvarButton.Location = new System.Drawing.Point(440, 391);
            this.salvarButton.Name = "salvarButton";
            this.salvarButton.Size = new System.Drawing.Size(94, 29);
            this.salvarButton.TabIndex = 10;
            this.salvarButton.Text = "Salvar";
            this.salvarButton.UseVisualStyleBackColor = true;
            this.salvarButton.Click += new System.EventHandler(this.salvarButton_Click);
            // 
            // dataCompraDateTimePicker
            // 
            this.dataCompraDateTimePicker.CustomFormat = "dd-MM-yyyy";
            this.dataCompraDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dataCompraDateTimePicker.Location = new System.Drawing.Point(220, 189);
            this.dataCompraDateTimePicker.Name = "dataCompraDateTimePicker";
            this.dataCompraDateTimePicker.Size = new System.Drawing.Size(168, 27);
            this.dataCompraDateTimePicker.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataCompraDateTimePicker);
            this.Controls.Add(this.salvarButton);
            this.Controls.Add(this.quantidadeCotaTextBox);
            this.Controls.Add(this.valorAcaoFundoTextBox);
            this.Controls.Add(this.nomeAcaoFundoTextBox);
            this.Controls.Add(this.quantidadeCotaLabel);
            this.Controls.Add(this.ValorLabel);
            this.Controls.Add(this.nomeAcaoFundoLabel);
            this.Controls.Add(this.dataCompraLabel);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.tipoLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label tipoLabel;
        private ComboBox comboBox1;
        private Label dataCompraLabel;
        private Label nomeAcaoFundoLabel;
        private Label ValorLabel;
        private Label quantidadeCotaLabel;
        private TextBox nomeAcaoFundoTextBox;
        private TextBox valorAcaoFundoTextBox;
        private TextBox quantidadeCotaTextBox;
        private Button salvarButton;
        private DateTimePicker dataCompraDateTimePicker;
    }
}