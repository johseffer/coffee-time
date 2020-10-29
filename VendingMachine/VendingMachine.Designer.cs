namespace VendingMachine
{
    partial class frmVendingMachine
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVendingMachine));
            this.btnCappuccino = new System.Windows.Forms.Button();
            this.btnMocha = new System.Windows.Forms.Button();
            this.btnCafeComLeite = new System.Windows.Forms.Button();
            this.pnlImageVendingMachine = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlActions = new System.Windows.Forms.Panel();
            this.lblTroco = new System.Windows.Forms.Label();
            this.lblValorTotal = new System.Windows.Forms.Label();
            this.lblValorInserido = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnComprar = new System.Windows.Forms.Button();
            this.gpbTroco = new System.Windows.Forms.GroupBox();
            this.flpTroco = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.pbDezCentavos = new System.Windows.Forms.PictureBox();
            this.pbCincoCentavos = new System.Windows.Forms.PictureBox();
            this.pbUmReal = new System.Windows.Forms.PictureBox();
            this.pbCinquentaCentavos = new System.Windows.Forms.PictureBox();
            this.pbVinteCincoCentavos = new System.Windows.Forms.PictureBox();
            this.pbUmCentavo = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pnlImageVendingMachine.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlActions.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.gpbTroco.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbDezCentavos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCincoCentavos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUmReal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCinquentaCentavos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbVinteCincoCentavos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUmCentavo)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCappuccino
            // 
            this.btnCappuccino.Enabled = false;
            this.btnCappuccino.Location = new System.Drawing.Point(6, 22);
            this.btnCappuccino.Name = "btnCappuccino";
            this.btnCappuccino.Size = new System.Drawing.Size(34, 30);
            this.btnCappuccino.TabIndex = 2;
            this.btnCappuccino.Text = "1";
            this.btnCappuccino.UseVisualStyleBackColor = true;
            this.btnCappuccino.Click += new System.EventHandler(this.btnCappuccino_Click);
            // 
            // btnMocha
            // 
            this.btnMocha.Enabled = false;
            this.btnMocha.Location = new System.Drawing.Point(60, 22);
            this.btnMocha.Name = "btnMocha";
            this.btnMocha.Size = new System.Drawing.Size(34, 30);
            this.btnMocha.TabIndex = 3;
            this.btnMocha.Text = "2";
            this.btnMocha.UseVisualStyleBackColor = true;
            this.btnMocha.Click += new System.EventHandler(this.btnMocha_Click);
            // 
            // btnCafeComLeite
            // 
            this.btnCafeComLeite.Enabled = false;
            this.btnCafeComLeite.Location = new System.Drawing.Point(114, 22);
            this.btnCafeComLeite.Name = "btnCafeComLeite";
            this.btnCafeComLeite.Size = new System.Drawing.Size(34, 30);
            this.btnCafeComLeite.TabIndex = 4;
            this.btnCafeComLeite.Text = "3";
            this.btnCafeComLeite.UseVisualStyleBackColor = true;
            this.btnCafeComLeite.Click += new System.EventHandler(this.btnCafeComLeite_Click);
            // 
            // pnlImageVendingMachine
            // 
            this.pnlImageVendingMachine.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlImageVendingMachine.Controls.Add(this.pictureBox1);
            this.pnlImageVendingMachine.Location = new System.Drawing.Point(13, 13);
            this.pnlImageVendingMachine.Name = "pnlImageVendingMachine";
            this.pnlImageVendingMachine.Size = new System.Drawing.Size(389, 572);
            this.pnlImageVendingMachine.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(387, 570);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pnlActions
            // 
            this.pnlActions.BackColor = System.Drawing.Color.White;
            this.pnlActions.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlActions.Controls.Add(this.lblTroco);
            this.pnlActions.Controls.Add(this.lblValorTotal);
            this.pnlActions.Controls.Add(this.lblValorInserido);
            this.pnlActions.Controls.Add(this.groupBox2);
            this.pnlActions.Controls.Add(this.label11);
            this.pnlActions.Controls.Add(this.label9);
            this.pnlActions.Controls.Add(this.label1);
            this.pnlActions.Controls.Add(this.btnCancelar);
            this.pnlActions.Controls.Add(this.btnComprar);
            this.pnlActions.Controls.Add(this.gpbTroco);
            this.pnlActions.Controls.Add(this.groupBox3);
            this.pnlActions.Controls.Add(this.groupBox1);
            this.pnlActions.Location = new System.Drawing.Point(408, 13);
            this.pnlActions.Name = "pnlActions";
            this.pnlActions.Size = new System.Drawing.Size(175, 572);
            this.pnlActions.TabIndex = 1;
            // 
            // lblTroco
            // 
            this.lblTroco.AutoSize = true;
            this.lblTroco.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTroco.Location = new System.Drawing.Point(112, 325);
            this.lblTroco.Name = "lblTroco";
            this.lblTroco.Size = new System.Drawing.Size(56, 15);
            this.lblTroco.TabIndex = 10;
            this.lblTroco.Text = "R$ 00,00";
            // 
            // lblValorTotal
            // 
            this.lblValorTotal.AutoSize = true;
            this.lblValorTotal.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblValorTotal.Location = new System.Drawing.Point(112, 310);
            this.lblValorTotal.Name = "lblValorTotal";
            this.lblValorTotal.Size = new System.Drawing.Size(56, 15);
            this.lblValorTotal.TabIndex = 10;
            this.lblValorTotal.Text = "R$ 00,00";
            // 
            // lblValorInserido
            // 
            this.lblValorInserido.AutoSize = true;
            this.lblValorInserido.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblValorInserido.Location = new System.Drawing.Point(112, 216);
            this.lblValorInserido.Name = "lblValorInserido";
            this.lblValorInserido.Size = new System.Drawing.Size(56, 15);
            this.lblValorInserido.TabIndex = 10;
            this.lblValorInserido.Text = "R$ 00,00";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnCappuccino);
            this.groupBox2.Controls.Add(this.btnMocha);
            this.groupBox2.Controls.Add(this.btnCafeComLeite);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox2.Location = new System.Drawing.Point(8, 240);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(161, 60);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Selecione seu produto:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(8, 325);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(38, 15);
            this.label11.TabIndex = 9;
            this.label11.Text = "Troco";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(8, 310);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 15);
            this.label9.TabIndex = 9;
            this.label9.Text = "Valor Total";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(8, 216);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 15);
            this.label1.TabIndex = 9;
            this.label1.Text = "Valor Inserido";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Enabled = false;
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCancelar.Location = new System.Drawing.Point(8, 398);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(161, 34);
            this.btnCancelar.TabIndex = 1;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnComprar
            // 
            this.btnComprar.Enabled = false;
            this.btnComprar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnComprar.Location = new System.Drawing.Point(8, 358);
            this.btnComprar.Name = "btnComprar";
            this.btnComprar.Size = new System.Drawing.Size(161, 34);
            this.btnComprar.TabIndex = 0;
            this.btnComprar.Text = "Comprar";
            this.btnComprar.UseVisualStyleBackColor = true;
            this.btnComprar.Click += new System.EventHandler(this.btnComprar_Click);
            // 
            // gpbTroco
            // 
            this.gpbTroco.Controls.Add(this.flpTroco);
            this.gpbTroco.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gpbTroco.Location = new System.Drawing.Point(8, 438);
            this.gpbTroco.Name = "gpbTroco";
            this.gpbTroco.Size = new System.Drawing.Size(161, 126);
            this.gpbTroco.TabIndex = 7;
            this.gpbTroco.TabStop = false;
            this.gpbTroco.Text = "Bandeja de troco";
            // 
            // flpTroco
            // 
            this.flpTroco.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpTroco.Location = new System.Drawing.Point(3, 19);
            this.flpTroco.Name = "flpTroco";
            this.flpTroco.Size = new System.Drawing.Size(155, 104);
            this.flpTroco.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.pbDezCentavos);
            this.groupBox3.Controls.Add(this.pbCincoCentavos);
            this.groupBox3.Controls.Add(this.pbUmReal);
            this.groupBox3.Controls.Add(this.pbCinquentaCentavos);
            this.groupBox3.Controls.Add(this.pbVinteCincoCentavos);
            this.groupBox3.Controls.Add(this.pbUmCentavo);
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox3.Location = new System.Drawing.Point(8, 89);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(161, 117);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Insira suas moedas";
            // 
            // pbDezCentavos
            // 
            this.pbDezCentavos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbDezCentavos.Image = ((System.Drawing.Image)(resources.GetObject("pbDezCentavos.Image")));
            this.pbDezCentavos.Location = new System.Drawing.Point(106, 23);
            this.pbDezCentavos.Name = "pbDezCentavos";
            this.pbDezCentavos.Size = new System.Drawing.Size(44, 40);
            this.pbDezCentavos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbDezCentavos.TabIndex = 0;
            this.pbDezCentavos.TabStop = false;
            this.pbDezCentavos.Click += new System.EventHandler(this.pbDezCentavos_Click);
            // 
            // pbCincoCentavos
            // 
            this.pbCincoCentavos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbCincoCentavos.Image = ((System.Drawing.Image)(resources.GetObject("pbCincoCentavos.Image")));
            this.pbCincoCentavos.Location = new System.Drawing.Point(56, 23);
            this.pbCincoCentavos.Name = "pbCincoCentavos";
            this.pbCincoCentavos.Size = new System.Drawing.Size(44, 40);
            this.pbCincoCentavos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCincoCentavos.TabIndex = 0;
            this.pbCincoCentavos.TabStop = false;
            this.pbCincoCentavos.Click += new System.EventHandler(this.pbCincoCentavos_Click);
            // 
            // pbUmReal
            // 
            this.pbUmReal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbUmReal.Image = ((System.Drawing.Image)(resources.GetObject("pbUmReal.Image")));
            this.pbUmReal.Location = new System.Drawing.Point(106, 69);
            this.pbUmReal.Name = "pbUmReal";
            this.pbUmReal.Size = new System.Drawing.Size(44, 39);
            this.pbUmReal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbUmReal.TabIndex = 0;
            this.pbUmReal.TabStop = false;
            this.pbUmReal.Click += new System.EventHandler(this.pbUmReal_Click);
            // 
            // pbCinquentaCentavos
            // 
            this.pbCinquentaCentavos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbCinquentaCentavos.Image = ((System.Drawing.Image)(resources.GetObject("pbCinquentaCentavos.Image")));
            this.pbCinquentaCentavos.Location = new System.Drawing.Point(56, 69);
            this.pbCinquentaCentavos.Name = "pbCinquentaCentavos";
            this.pbCinquentaCentavos.Size = new System.Drawing.Size(44, 39);
            this.pbCinquentaCentavos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCinquentaCentavos.TabIndex = 0;
            this.pbCinquentaCentavos.TabStop = false;
            this.pbCinquentaCentavos.Click += new System.EventHandler(this.pbCinquentaCentavos_Click);
            // 
            // pbVinteCincoCentavos
            // 
            this.pbVinteCincoCentavos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbVinteCincoCentavos.Image = ((System.Drawing.Image)(resources.GetObject("pbVinteCincoCentavos.Image")));
            this.pbVinteCincoCentavos.Location = new System.Drawing.Point(7, 68);
            this.pbVinteCincoCentavos.Name = "pbVinteCincoCentavos";
            this.pbVinteCincoCentavos.Size = new System.Drawing.Size(43, 40);
            this.pbVinteCincoCentavos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbVinteCincoCentavos.TabIndex = 0;
            this.pbVinteCincoCentavos.TabStop = false;
            this.pbVinteCincoCentavos.Click += new System.EventHandler(this.pbVinteCincoCentavos_Click);
            // 
            // pbUmCentavo
            // 
            this.pbUmCentavo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbUmCentavo.Image = ((System.Drawing.Image)(resources.GetObject("pbUmCentavo.Image")));
            this.pbUmCentavo.Location = new System.Drawing.Point(7, 23);
            this.pbUmCentavo.Name = "pbUmCentavo";
            this.pbUmCentavo.Size = new System.Drawing.Size(43, 39);
            this.pbUmCentavo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbUmCentavo.TabIndex = 0;
            this.pbUmCentavo.TabStop = false;
            this.pbUmCentavo.Click += new System.EventHandler(this.pbUmCentavo_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(8, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(161, 83);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Produtos Disponíveis";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(6, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "1 - Cappuccino";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(111, 60);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 15);
            this.label7.TabIndex = 3;
            this.label7.Text = "R$ 3.00";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(111, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "R$ 3.50";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(7, 60);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 15);
            this.label6.TabIndex = 2;
            this.label6.Text = "3 - Café com leite";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(111, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 15);
            this.label5.TabIndex = 3;
            this.label5.Text = "R$ 4.00";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(7, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 15);
            this.label4.TabIndex = 2;
            this.label4.Text = "2 - Mocha";
            // 
            // frmVendingMachine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 600);
            this.Controls.Add(this.pnlActions);
            this.Controls.Add(this.pnlImageVendingMachine);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmVendingMachine";
            this.Text = "É hora do café";
            this.Load += new System.EventHandler(this.frmVendingMachine_Load);
            this.pnlImageVendingMachine.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlActions.ResumeLayout(false);
            this.pnlActions.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.gpbTroco.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbDezCentavos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCincoCentavos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUmReal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCinquentaCentavos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbVinteCincoCentavos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUmCentavo)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCappuccino;
        private System.Windows.Forms.Button btnMocha;
        private System.Windows.Forms.Button btnCafeComLeite;
        private System.Windows.Forms.Panel pnlImageVendingMachine;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel pnlActions;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.PictureBox pbCincoCentavos;
        private System.Windows.Forms.PictureBox pbUmCentavo;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pbDezCentavos;
        private System.Windows.Forms.PictureBox pbUmReal;
        private System.Windows.Forms.PictureBox pbCinquentaCentavos;
        private System.Windows.Forms.PictureBox pbVinteCincoCentavos;
        private System.Windows.Forms.Label lblValorTotal;
        private System.Windows.Forms.Label lblValorInserido;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnComprar;
        private System.Windows.Forms.GroupBox gpbTroco;
        private System.Windows.Forms.Label lblTroco;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.FlowLayoutPanel flpTroco;
    }
}

