namespace WindowsFormsApp
{
    partial class Agenda
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Agenda));
            this.lbNome = new System.Windows.Forms.Label();
            this.lbEndereco = new System.Windows.Forms.Label();
            this.lbTelefone = new System.Windows.Forms.Label();
            this.lbEmail = new System.Windows.Forms.Label();
            this.boxNome = new System.Windows.Forms.TextBox();
            this.boxEndereco = new System.Windows.Forms.TextBox();
            this.boxTelefone = new System.Windows.Forms.MaskedTextBox();
            this.boxEmail = new System.Windows.Forms.TextBox();
            this.lvAgenda = new System.Windows.Forms.ListView();
            this.Nome = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Endereco = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Telefone = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Email = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnNovo = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnEditar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Editar = new System.Windows.Forms.Label();
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.flowLayoutPanel5 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.flowLayoutPanel6 = new System.Windows.Forms.FlowLayoutPanel();
            this.button5 = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.flowLayoutPanel4.SuspendLayout();
            this.flowLayoutPanel5.SuspendLayout();
            this.flowLayoutPanel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbNome
            // 
            this.lbNome.AutoSize = true;
            this.lbNome.Location = new System.Drawing.Point(64, 48);
            this.lbNome.Name = "lbNome";
            this.lbNome.Size = new System.Drawing.Size(38, 13);
            this.lbNome.TabIndex = 0;
            this.lbNome.Text = "Nome:";
            // 
            // lbEndereco
            // 
            this.lbEndereco.AutoSize = true;
            this.lbEndereco.Location = new System.Drawing.Point(64, 83);
            this.lbEndereco.Name = "lbEndereco";
            this.lbEndereco.Size = new System.Drawing.Size(56, 13);
            this.lbEndereco.TabIndex = 1;
            this.lbEndereco.Text = "Endereço:";
            // 
            // lbTelefone
            // 
            this.lbTelefone.AutoSize = true;
            this.lbTelefone.Location = new System.Drawing.Point(64, 119);
            this.lbTelefone.Name = "lbTelefone";
            this.lbTelefone.Size = new System.Drawing.Size(52, 13);
            this.lbTelefone.TabIndex = 2;
            this.lbTelefone.Text = "Telefone:";
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Location = new System.Drawing.Point(64, 154);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(38, 13);
            this.lbEmail.TabIndex = 3;
            this.lbEmail.Text = "E-mail:";
            // 
            // boxNome
            // 
            this.boxNome.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.boxNome.Location = new System.Drawing.Point(126, 45);
            this.boxNome.Name = "boxNome";
            this.boxNome.Size = new System.Drawing.Size(263, 20);
            this.boxNome.TabIndex = 4;
            // 
            // boxEndereco
            // 
            this.boxEndereco.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.boxEndereco.Location = new System.Drawing.Point(126, 80);
            this.boxEndereco.Name = "boxEndereco";
            this.boxEndereco.Size = new System.Drawing.Size(263, 20);
            this.boxEndereco.TabIndex = 6;
            // 
            // boxTelefone
            // 
            this.boxTelefone.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.boxTelefone.Location = new System.Drawing.Point(126, 116);
            this.boxTelefone.Mask = "(99) 00000-0000";
            this.boxTelefone.Name = "boxTelefone";
            this.boxTelefone.Size = new System.Drawing.Size(263, 20);
            this.boxTelefone.TabIndex = 7;
            this.boxTelefone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // boxEmail
            // 
            this.boxEmail.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.boxEmail.Location = new System.Drawing.Point(126, 151);
            this.boxEmail.Name = "boxEmail";
            this.boxEmail.Size = new System.Drawing.Size(263, 20);
            this.boxEmail.TabIndex = 5;
            // 
            // lvAgenda
            // 
            this.lvAgenda.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.lvAgenda.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Nome,
            this.Endereco,
            this.Telefone,
            this.Email});
            this.lvAgenda.GridLines = true;
            this.lvAgenda.HideSelection = false;
            this.lvAgenda.Location = new System.Drawing.Point(12, 216);
            this.lvAgenda.MultiSelect = false;
            this.lvAgenda.Name = "lvAgenda";
            this.lvAgenda.Size = new System.Drawing.Size(638, 180);
            this.lvAgenda.TabIndex = 8;
            this.lvAgenda.UseCompatibleStateImageBehavior = false;
            this.lvAgenda.View = System.Windows.Forms.View.Details;
            this.lvAgenda.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.lvAgenda_ColumnClick);
            this.lvAgenda.ColumnWidthChanging += new System.Windows.Forms.ColumnWidthChangingEventHandler(this.lvAgenda_ColumnWidthChanging);
            // 
            // Nome
            // 
            this.Nome.Text = "Nome";
            this.Nome.Width = 238;
            // 
            // Endereco
            // 
            this.Endereco.Text = "Endereço";
            this.Endereco.Width = 159;
            // 
            // Telefone
            // 
            this.Telefone.Text = "Telefone";
            this.Telefone.Width = 91;
            // 
            // Email
            // 
            this.Email.Text = "E-mail";
            this.Email.Width = 146;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.flowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel1.Controls.Add(this.btnNovo);
            this.flowLayoutPanel1.Controls.Add(this.label2);
            this.flowLayoutPanel1.Controls.Add(this.label1);
            this.flowLayoutPanel1.Controls.Add(this.flowLayoutPanel2);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(454, 45);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(10, 8, 8, 6);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(53, 55);
            this.flowLayoutPanel1.TabIndex = 11;
            // 
            // btnNovo
            // 
            this.btnNovo.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnNovo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnNovo.BackgroundImage")));
            this.btnNovo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnNovo.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnNovo.Location = new System.Drawing.Point(10, 8);
            this.btnNovo.Margin = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Padding = new System.Windows.Forms.Padding(3);
            this.btnNovo.Size = new System.Drawing.Size(30, 25);
            this.btnNovo.TabIndex = 0;
            this.btnNovo.UseVisualStyleBackColor = false;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 36);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Novo";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 1;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.flowLayoutPanel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel2.Controls.Add(this.button1);
            this.flowLayoutPanel2.Controls.Add(this.label3);
            this.flowLayoutPanel2.Controls.Add(this.label4);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(10, 62);
            this.flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Padding = new System.Windows.Forms.Padding(10, 8, 8, 6);
            this.flowLayoutPanel2.Size = new System.Drawing.Size(53, 55);
            this.flowLayoutPanel2.TabIndex = 12;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.Cursor = System.Windows.Forms.Cursors.Default;
            this.button1.Location = new System.Drawing.Point(10, 8);
            this.button1.Margin = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(3);
            this.button1.Size = new System.Drawing.Size(30, 25);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 36);
            this.label3.Margin = new System.Windows.Forms.Padding(0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Novo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 1;
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.flowLayoutPanel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel3.Controls.Add(this.btnEditar);
            this.flowLayoutPanel3.Controls.Add(this.label5);
            this.flowLayoutPanel3.Controls.Add(this.label6);
            this.flowLayoutPanel3.Controls.Add(this.Editar);
            this.flowLayoutPanel3.Location = new System.Drawing.Point(454, 116);
            this.flowLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Padding = new System.Windows.Forms.Padding(10, 8, 5, 5);
            this.flowLayoutPanel3.Size = new System.Drawing.Size(53, 55);
            this.flowLayoutPanel3.TabIndex = 12;
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnEditar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEditar.BackgroundImage")));
            this.btnEditar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnEditar.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnEditar.Location = new System.Drawing.Point(10, 8);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Padding = new System.Windows.Forms.Padding(3);
            this.btnEditar.Size = new System.Drawing.Size(30, 25);
            this.btnEditar.TabIndex = 0;
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(40, 8);
            this.label5.Margin = new System.Windows.Forms.Padding(0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 13);
            this.label5.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(43, 8);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 13);
            this.label6.TabIndex = 1;
            // 
            // Editar
            // 
            this.Editar.AutoSize = true;
            this.Editar.Location = new System.Drawing.Point(10, 36);
            this.Editar.Margin = new System.Windows.Forms.Padding(0);
            this.Editar.Name = "Editar";
            this.Editar.Size = new System.Drawing.Size(34, 13);
            this.Editar.TabIndex = 3;
            this.Editar.Text = "Editar";
            // 
            // flowLayoutPanel4
            // 
            this.flowLayoutPanel4.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.flowLayoutPanel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel4.Controls.Add(this.btnSalvar);
            this.flowLayoutPanel4.Controls.Add(this.label7);
            this.flowLayoutPanel4.Controls.Add(this.label8);
            this.flowLayoutPanel4.Controls.Add(this.label9);
            this.flowLayoutPanel4.Location = new System.Drawing.Point(525, 45);
            this.flowLayoutPanel4.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            this.flowLayoutPanel4.Padding = new System.Windows.Forms.Padding(9, 8, 0, 5);
            this.flowLayoutPanel4.Size = new System.Drawing.Size(53, 55);
            this.flowLayoutPanel4.TabIndex = 14;
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnSalvar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSalvar.BackgroundImage")));
            this.btnSalvar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSalvar.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnSalvar.Location = new System.Drawing.Point(9, 8);
            this.btnSalvar.Margin = new System.Windows.Forms.Padding(0);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Padding = new System.Windows.Forms.Padding(3);
            this.btnSalvar.Size = new System.Drawing.Size(33, 25);
            this.btnSalvar.TabIndex = 0;
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(42, 8);
            this.label7.Margin = new System.Windows.Forms.Padding(0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 13);
            this.label7.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(45, 8);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 13);
            this.label8.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(9, 33);
            this.label9.Margin = new System.Windows.Forms.Padding(0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 13);
            this.label9.TabIndex = 3;
            this.label9.Text = "Salvar";
            // 
            // flowLayoutPanel5
            // 
            this.flowLayoutPanel5.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.flowLayoutPanel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel5.Controls.Add(this.btnExcluir);
            this.flowLayoutPanel5.Controls.Add(this.label10);
            this.flowLayoutPanel5.Controls.Add(this.label11);
            this.flowLayoutPanel5.Controls.Add(this.flowLayoutPanel6);
            this.flowLayoutPanel5.Location = new System.Drawing.Point(525, 116);
            this.flowLayoutPanel5.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel5.Name = "flowLayoutPanel5";
            this.flowLayoutPanel5.Padding = new System.Windows.Forms.Padding(8, 8, 0, 6);
            this.flowLayoutPanel5.Size = new System.Drawing.Size(53, 55);
            this.flowLayoutPanel5.TabIndex = 13;
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackColor = System.Drawing.Color.Red;
            this.btnExcluir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExcluir.BackgroundImage")));
            this.btnExcluir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnExcluir.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnExcluir.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnExcluir.Location = new System.Drawing.Point(8, 8);
            this.btnExcluir.Margin = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Padding = new System.Windows.Forms.Padding(3);
            this.btnExcluir.Size = new System.Drawing.Size(34, 25);
            this.btnExcluir.TabIndex = 0;
            this.btnExcluir.UseVisualStyleBackColor = false;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(8, 36);
            this.label10.Margin = new System.Windows.Forms.Padding(0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(38, 13);
            this.label10.TabIndex = 2;
            this.label10.Text = "Excluir";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(11, 49);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(0, 13);
            this.label11.TabIndex = 1;
            // 
            // flowLayoutPanel6
            // 
            this.flowLayoutPanel6.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.flowLayoutPanel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel6.Controls.Add(this.button5);
            this.flowLayoutPanel6.Controls.Add(this.label12);
            this.flowLayoutPanel6.Controls.Add(this.label13);
            this.flowLayoutPanel6.Location = new System.Drawing.Point(8, 62);
            this.flowLayoutPanel6.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel6.Name = "flowLayoutPanel6";
            this.flowLayoutPanel6.Padding = new System.Windows.Forms.Padding(10, 8, 8, 6);
            this.flowLayoutPanel6.Size = new System.Drawing.Size(53, 55);
            this.flowLayoutPanel6.TabIndex = 12;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.ControlDark;
            this.button5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button5.BackgroundImage")));
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button5.Cursor = System.Windows.Forms.Cursors.Default;
            this.button5.Location = new System.Drawing.Point(10, 8);
            this.button5.Margin = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.button5.Name = "button5";
            this.button5.Padding = new System.Windows.Forms.Padding(3);
            this.button5.Size = new System.Drawing.Size(30, 25);
            this.button5.TabIndex = 0;
            this.button5.UseVisualStyleBackColor = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(10, 36);
            this.label12.Margin = new System.Windows.Forms.Padding(0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(33, 13);
            this.label12.TabIndex = 2;
            this.label12.Text = "Novo";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(13, 49);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(0, 13);
            this.label13.TabIndex = 1;
            // 
            // Agenda
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(662, 409);
            this.Controls.Add(this.flowLayoutPanel3);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.lvAgenda);
            this.Controls.Add(this.boxTelefone);
            this.Controls.Add(this.flowLayoutPanel4);
            this.Controls.Add(this.flowLayoutPanel5);
            this.Controls.Add(this.boxEndereco);
            this.Controls.Add(this.boxEmail);
            this.Controls.Add(this.boxNome);
            this.Controls.Add(this.lbEmail);
            this.Controls.Add(this.lbTelefone);
            this.Controls.Add(this.lbEndereco);
            this.Controls.Add(this.lbNome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Agenda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agenda";
            this.Load += new System.EventHandler(this.Agenda_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel3.PerformLayout();
            this.flowLayoutPanel4.ResumeLayout(false);
            this.flowLayoutPanel4.PerformLayout();
            this.flowLayoutPanel5.ResumeLayout(false);
            this.flowLayoutPanel5.PerformLayout();
            this.flowLayoutPanel6.ResumeLayout(false);
            this.flowLayoutPanel6.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbNome;
        private System.Windows.Forms.Label lbEndereco;
        private System.Windows.Forms.Label lbTelefone;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.TextBox boxNome;
        private System.Windows.Forms.TextBox boxEndereco;
        private System.Windows.Forms.MaskedTextBox boxTelefone;
        private System.Windows.Forms.TextBox boxEmail;
        private System.Windows.Forms.ListView lvAgenda;
        private System.Windows.Forms.ColumnHeader Endereco;
        private System.Windows.Forms.ColumnHeader Telefone;
        private System.Windows.Forms.ColumnHeader Email;
        private System.Windows.Forms.ColumnHeader Nome;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label Editar;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel4;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel5;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
    }
}