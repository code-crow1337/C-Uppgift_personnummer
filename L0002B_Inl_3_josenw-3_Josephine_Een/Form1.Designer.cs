namespace L0002B_Inl_3_josenw_3_Josephine_Een
{
    partial class Form1
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
            this.btnOk = new System.Windows.Forms.Button();
            this.btnAvslut = new System.Windows.Forms.Button();
            this.txtFNamn = new System.Windows.Forms.TextBox();
            this.txtENamn = new System.Windows.Forms.TextBox();
            this.txtPerNr = new System.Windows.Forms.TextBox();
            this.lbFnamn = new System.Windows.Forms.Label();
            this.lbENamn = new System.Windows.Forms.Label();
            this.lbPerNr = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtGroup = new System.Windows.Forms.GroupBox();
            this.txtSex = new System.Windows.Forms.Label();
            this.txtGroupPerNrSvar = new System.Windows.Forms.Label();
            this.txtGroupPerNrFalse = new System.Windows.Forms.Label();
            this.txtGroupPerNr = new System.Windows.Forms.Label();
            this.txtGroupENamn = new System.Windows.Forms.Label();
            this.txtGroupFnamn = new System.Windows.Forms.Label();
            this.btnTryAgain = new System.Windows.Forms.Button();
            this.btnTestaIgen = new System.Windows.Forms.Button();
            this.txtGroupFNamnSvar = new System.Windows.Forms.Label();
            this.txtGroupENamnSvar = new System.Windows.Forms.Label();
            this.txtGroupSexSvar = new System.Windows.Forms.Label();
            this.txtGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(377, 178);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 0;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnAvslut
            // 
            this.btnAvslut.Location = new System.Drawing.Point(377, 207);
            this.btnAvslut.Name = "btnAvslut";
            this.btnAvslut.Size = new System.Drawing.Size(75, 23);
            this.btnAvslut.TabIndex = 1;
            this.btnAvslut.Text = "Avsluta";
            this.btnAvslut.UseVisualStyleBackColor = true;
            this.btnAvslut.Click += new System.EventHandler(this.btnAvslut_Click);
            // 
            // txtFNamn
            // 
            this.txtFNamn.Location = new System.Drawing.Point(224, 102);
            this.txtFNamn.Name = "txtFNamn";
            this.txtFNamn.Size = new System.Drawing.Size(127, 20);
            this.txtFNamn.TabIndex = 2;
            this.txtFNamn.TextChanged += new System.EventHandler(this.txtFNamn_TextChanged);
            // 
            // txtENamn
            // 
            this.txtENamn.Location = new System.Drawing.Point(224, 140);
            this.txtENamn.Name = "txtENamn";
            this.txtENamn.Size = new System.Drawing.Size(127, 20);
            this.txtENamn.TabIndex = 3;
            this.txtENamn.TextChanged += new System.EventHandler(this.txtENamn_TextChanged);
            // 
            // txtPerNr
            // 
            this.txtPerNr.Location = new System.Drawing.Point(224, 178);
            this.txtPerNr.Name = "txtPerNr";
            this.txtPerNr.Size = new System.Drawing.Size(127, 20);
            this.txtPerNr.TabIndex = 4;
            this.txtPerNr.TextChanged += new System.EventHandler(this.txtPerNr_TextChanged);
            // 
            // lbFnamn
            // 
            this.lbFnamn.AutoSize = true;
            this.lbFnamn.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFnamn.Location = new System.Drawing.Point(145, 102);
            this.lbFnamn.Name = "lbFnamn";
            this.lbFnamn.Size = new System.Drawing.Size(73, 21);
            this.lbFnamn.TabIndex = 5;
            this.lbFnamn.Text = "Förnamn:";
            this.lbFnamn.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbENamn
            // 
            this.lbENamn.AutoSize = true;
            this.lbENamn.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbENamn.Location = new System.Drawing.Point(135, 139);
            this.lbENamn.Name = "lbENamn";
            this.lbENamn.Size = new System.Drawing.Size(83, 21);
            this.lbENamn.TabIndex = 6;
            this.lbENamn.Text = "Efternamn:";
            // 
            // lbPerNr
            // 
            this.lbPerNr.AutoSize = true;
            this.lbPerNr.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPerNr.Location = new System.Drawing.Point(52, 177);
            this.lbPerNr.Name = "lbPerNr";
            this.lbPerNr.Size = new System.Drawing.Size(166, 21);
            this.lbPerNr.TabIndex = 7;
            this.lbPerNr.Text = "Personummer ,10 siffror:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(222, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 31);
            this.label1.TabIndex = 8;
            this.label1.Text = "Välkommen";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtGroup
            // 
            this.txtGroup.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.txtGroup.Controls.Add(this.txtGroupSexSvar);
            this.txtGroup.Controls.Add(this.txtGroupENamnSvar);
            this.txtGroup.Controls.Add(this.txtGroupFNamnSvar);
            this.txtGroup.Controls.Add(this.txtSex);
            this.txtGroup.Controls.Add(this.txtGroupPerNrSvar);
            this.txtGroup.Controls.Add(this.txtGroupPerNrFalse);
            this.txtGroup.Controls.Add(this.txtGroupPerNr);
            this.txtGroup.Controls.Add(this.txtGroupENamn);
            this.txtGroup.Controls.Add(this.txtGroupFnamn);
            this.txtGroup.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGroup.Location = new System.Drawing.Point(56, 233);
            this.txtGroup.Name = "txtGroup";
            this.txtGroup.Size = new System.Drawing.Size(295, 180);
            this.txtGroup.TabIndex = 9;
            this.txtGroup.TabStop = false;
            this.txtGroup.Text = "Resultat";
            this.txtGroup.Enter += new System.EventHandler(this.txtGroup_Enter);
            // 
            // txtSex
            // 
            this.txtSex.AutoSize = true;
            this.txtSex.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSex.Location = new System.Drawing.Point(6, 122);
            this.txtSex.Name = "txtSex";
            this.txtSex.Size = new System.Drawing.Size(61, 20);
            this.txtSex.TabIndex = 15;
            this.txtSex.Text = "Du är en:";
            this.txtSex.Visible = false;
            // 
            // txtGroupPerNrSvar
            // 
            this.txtGroupPerNrSvar.AutoSize = true;
            this.txtGroupPerNrSvar.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGroupPerNrSvar.Location = new System.Drawing.Point(118, 92);
            this.txtGroupPerNrSvar.Name = "txtGroupPerNrSvar";
            this.txtGroupPerNrSvar.Size = new System.Drawing.Size(45, 20);
            this.txtGroupPerNrSvar.TabIndex = 14;
            this.txtGroupPerNrSvar.Text = "Giltigt";
            this.txtGroupPerNrSvar.Visible = false;
            this.txtGroupPerNrSvar.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // txtGroupPerNrFalse
            // 
            this.txtGroupPerNrFalse.AutoSize = true;
            this.txtGroupPerNrFalse.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGroupPerNrFalse.ForeColor = System.Drawing.Color.DarkRed;
            this.txtGroupPerNrFalse.Location = new System.Drawing.Point(15, 50);
            this.txtGroupPerNrFalse.Name = "txtGroupPerNrFalse";
            this.txtGroupPerNrFalse.Size = new System.Drawing.Size(242, 20);
            this.txtGroupPerNrFalse.TabIndex = 13;
            this.txtGroupPerNrFalse.Text = "Personnummret är ogitligt. Försök igen";
            this.txtGroupPerNrFalse.Visible = false;
            this.txtGroupPerNrFalse.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtGroupPerNr
            // 
            this.txtGroupPerNr.AutoSize = true;
            this.txtGroupPerNr.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGroupPerNr.Location = new System.Drawing.Point(6, 92);
            this.txtGroupPerNr.Name = "txtGroupPerNr";
            this.txtGroupPerNr.Size = new System.Drawing.Size(106, 20);
            this.txtGroupPerNr.TabIndex = 12;
            this.txtGroupPerNr.Text = "Personnummer:";
            this.txtGroupPerNr.Visible = false;
            // 
            // txtGroupENamn
            // 
            this.txtGroupENamn.AutoSize = true;
            this.txtGroupENamn.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGroupENamn.Location = new System.Drawing.Point(6, 60);
            this.txtGroupENamn.Name = "txtGroupENamn";
            this.txtGroupENamn.Size = new System.Drawing.Size(76, 20);
            this.txtGroupENamn.TabIndex = 11;
            this.txtGroupENamn.Text = "Efternamn:";
            this.txtGroupENamn.Visible = false;
            // 
            // txtGroupFnamn
            // 
            this.txtGroupFnamn.AutoSize = true;
            this.txtGroupFnamn.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGroupFnamn.Location = new System.Drawing.Point(6, 30);
            this.txtGroupFnamn.Name = "txtGroupFnamn";
            this.txtGroupFnamn.Size = new System.Drawing.Size(66, 20);
            this.txtGroupFnamn.TabIndex = 10;
            this.txtGroupFnamn.Text = "Förnamn:";
            this.txtGroupFnamn.Visible = false;
            // 
            // btnTryAgain
            // 
            this.btnTryAgain.Location = new System.Drawing.Point(377, 178);
            this.btnTryAgain.Name = "btnTryAgain";
            this.btnTryAgain.Size = new System.Drawing.Size(75, 23);
            this.btnTryAgain.TabIndex = 10;
            this.btnTryAgain.Text = "Försök Igen";
            this.btnTryAgain.UseVisualStyleBackColor = true;
            this.btnTryAgain.Visible = false;
            this.btnTryAgain.Click += new System.EventHandler(this.btnTryAgain_Click);
            // 
            // btnTestaIgen
            // 
            this.btnTestaIgen.Location = new System.Drawing.Point(377, 178);
            this.btnTestaIgen.Name = "btnTestaIgen";
            this.btnTestaIgen.Size = new System.Drawing.Size(75, 23);
            this.btnTestaIgen.TabIndex = 11;
            this.btnTestaIgen.Text = "Testa igen";
            this.btnTestaIgen.UseVisualStyleBackColor = false;
            this.btnTestaIgen.Visible = false;
            this.btnTestaIgen.Click += new System.EventHandler(this.btnTestaIgen_Click);
            // 
            // txtGroupFNamnSvar
            // 
            this.txtGroupFNamnSvar.AutoSize = true;
            this.txtGroupFNamnSvar.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGroupFNamnSvar.Location = new System.Drawing.Point(79, 30);
            this.txtGroupFNamnSvar.Name = "txtGroupFNamnSvar";
            this.txtGroupFNamnSvar.Size = new System.Drawing.Size(20, 20);
            this.txtGroupFNamnSvar.Text = "Svar"; 
            this.txtGroupFNamnSvar.TabIndex = 16;
            this.txtGroupFNamnSvar.Visible = false;
            // 
            // txtGroupENamnSvar
            // 
            this.txtGroupENamnSvar.AutoSize = true;
            this.txtGroupENamnSvar.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGroupENamnSvar.Location = new System.Drawing.Point(88, 60);
            this.txtGroupENamnSvar.Name = "txtGroupENamnSvar";
            this.txtGroupENamnSvar.Size = new System.Drawing.Size(0, 20);
            this.txtGroupENamnSvar.TabIndex = 17;
            this.txtGroupENamnSvar.Text = "Svar";
            this.txtGroupENamnSvar.Visible = false;
            // 
            // txtGroupSexSvar
            // 
            this.txtGroupSexSvar.AutoSize = true;
            this.txtGroupSexSvar.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGroupSexSvar.Location = new System.Drawing.Point(73, 122);
            this.txtGroupSexSvar.Name = "txtGroupSexSvar";
            this.txtGroupSexSvar.Size = new System.Drawing.Size(0, 20);
            this.txtGroupSexSvar.Text = "Svar";
            this.txtGroupSexSvar.TabIndex = 18;
            this.txtGroupSexSvar.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 509);
            this.Controls.Add(this.btnTestaIgen);
            this.Controls.Add(this.btnTryAgain);
            this.Controls.Add(this.txtGroup);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbPerNr);
            this.Controls.Add(this.lbENamn);
            this.Controls.Add(this.lbFnamn);
            this.Controls.Add(this.txtPerNr);
            this.Controls.Add(this.txtENamn);
            this.Controls.Add(this.txtFNamn);
            this.Controls.Add(this.btnAvslut);
            this.Controls.Add(this.btnOk);
            this.Name = "Form1";
            this.Text = "Form1";
            this.txtGroup.ResumeLayout(false);
            this.txtGroup.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnAvslut;
        private System.Windows.Forms.TextBox txtFNamn;
        private System.Windows.Forms.TextBox txtENamn;
        private System.Windows.Forms.TextBox txtPerNr;
        private System.Windows.Forms.Label lbFnamn;
        private System.Windows.Forms.Label lbENamn;
        private System.Windows.Forms.Label lbPerNr;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox txtGroup;
        private System.Windows.Forms.Label txtGroupPerNrFalse;
        private System.Windows.Forms.Label txtGroupPerNr;
        private System.Windows.Forms.Label txtGroupENamn;
        private System.Windows.Forms.Label txtGroupFnamn;
        private System.Windows.Forms.Label txtGroupPerNrSvar;
        private System.Windows.Forms.Button btnTryAgain;
        private System.Windows.Forms.Button btnTestaIgen;
        private System.Windows.Forms.Label txtSex;
        private System.Windows.Forms.Label txtGroupSexSvar;
        private System.Windows.Forms.Label txtGroupENamnSvar;
        private System.Windows.Forms.Label txtGroupFNamnSvar;
    }
}

