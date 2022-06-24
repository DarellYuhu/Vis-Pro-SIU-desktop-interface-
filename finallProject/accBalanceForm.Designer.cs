namespace finallProject
{
    partial class accBalanceForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(accBalanceForm));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.bunifuPanel1 = new Bunifu.UI.WinForms.BunifuPanel();
            this.financeID = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.fullName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bunifuPanel2 = new Bunifu.UI.WinForms.BunifuPanel();
            this.lastBalance = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.bunifuGradientPanel1 = new Bunifu.UI.WinForms.BunifuGradientPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.bunifuPanel3 = new Bunifu.UI.WinForms.BunifuPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvTransacHist = new System.Windows.Forms.DataGridView();
            this.bunifuGradientPanel2 = new Bunifu.UI.WinForms.BunifuGradientPanel();
            this.label10 = new System.Windows.Forms.Label();
            this.btnGetCr = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.bunifuTileButton1 = new Bunifu.Framework.UI.BunifuTileButton();
            this.bunifuPanel1.SuspendLayout();
            this.bunifuPanel2.SuspendLayout();
            this.bunifuGradientPanel1.SuspendLayout();
            this.bunifuPanel3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransacHist)).BeginInit();
            this.bunifuGradientPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuPanel1
            // 
            this.bunifuPanel1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.bunifuPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuPanel1.BackgroundImage")));
            this.bunifuPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuPanel1.BorderColor = System.Drawing.Color.Transparent;
            this.bunifuPanel1.BorderRadius = 20;
            this.bunifuPanel1.BorderThickness = 0;
            this.bunifuPanel1.Controls.Add(this.financeID);
            this.bunifuPanel1.Controls.Add(this.label3);
            this.bunifuPanel1.Controls.Add(this.fullName);
            this.bunifuPanel1.Controls.Add(this.label1);
            this.bunifuPanel1.Location = new System.Drawing.Point(53, 47);
            this.bunifuPanel1.Name = "bunifuPanel1";
            this.bunifuPanel1.ShowBorders = true;
            this.bunifuPanel1.Size = new System.Drawing.Size(250, 124);
            this.bunifuPanel1.TabIndex = 0;
            // 
            // financeID
            // 
            this.financeID.AutoSize = true;
            this.financeID.BackColor = System.Drawing.Color.Transparent;
            this.financeID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.financeID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(224)))), ((int)(((byte)(255)))));
            this.financeID.Location = new System.Drawing.Point(22, 86);
            this.financeID.Name = "financeID";
            this.financeID.Size = new System.Drawing.Size(111, 20);
            this.financeID.TabIndex = 0;
            this.financeID.Text = "--------- / ---------";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(22, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(182, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Reg. / Financial Number:";
            // 
            // fullName
            // 
            this.fullName.AutoSize = true;
            this.fullName.BackColor = System.Drawing.Color.Transparent;
            this.fullName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fullName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(224)))), ((int)(((byte)(255)))));
            this.fullName.Location = new System.Drawing.Point(22, 35);
            this.fullName.Name = "fullName";
            this.fullName.Size = new System.Drawing.Size(67, 20);
            this.fullName.TabIndex = 0;
            this.fullName.Text = "----, ------";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(22, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Student Name:";
            // 
            // bunifuPanel2
            // 
            this.bunifuPanel2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.bunifuPanel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuPanel2.BackgroundImage")));
            this.bunifuPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuPanel2.BorderColor = System.Drawing.Color.Transparent;
            this.bunifuPanel2.BorderRadius = 20;
            this.bunifuPanel2.BorderThickness = 0;
            this.bunifuPanel2.Controls.Add(this.lastBalance);
            this.bunifuPanel2.Controls.Add(this.label6);
            this.bunifuPanel2.Controls.Add(this.bunifuGradientPanel1);
            this.bunifuPanel2.Location = new System.Drawing.Point(333, 47);
            this.bunifuPanel2.Name = "bunifuPanel2";
            this.bunifuPanel2.ShowBorders = true;
            this.bunifuPanel2.Size = new System.Drawing.Size(250, 124);
            this.bunifuPanel2.TabIndex = 0;
            // 
            // lastBalance
            // 
            this.lastBalance.BackColor = System.Drawing.Color.Transparent;
            this.lastBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastBalance.ForeColor = System.Drawing.Color.White;
            this.lastBalance.Location = new System.Drawing.Point(110, 62);
            this.lastBalance.Name = "lastBalance";
            this.lastBalance.Size = new System.Drawing.Size(122, 27);
            this.lastBalance.TabIndex = 2;
            this.lastBalance.Text = "000.000.000";
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(3, 38);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 75);
            this.label6.TabIndex = 2;
            this.label6.Text = "Rp. ";
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.BorderRadius = 5;
            this.bunifuGradientPanel1.Controls.Add(this.label5);
            this.bunifuGradientPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.Teal;
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.DarkGreen;
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.Green;
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(250, 27);
            this.bunifuGradientPanel1.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(0, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(250, 27);
            this.label5.TabIndex = 0;
            this.label5.Text = "Last Balance";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bunifuPanel3
            // 
            this.bunifuPanel3.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.bunifuPanel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuPanel3.BackgroundImage")));
            this.bunifuPanel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuPanel3.BorderColor = System.Drawing.Color.Transparent;
            this.bunifuPanel3.BorderRadius = 20;
            this.bunifuPanel3.BorderThickness = 0;
            this.bunifuPanel3.Controls.Add(this.panel1);
            this.bunifuPanel3.Controls.Add(this.bunifuGradientPanel2);
            this.bunifuPanel3.Location = new System.Drawing.Point(53, 199);
            this.bunifuPanel3.Name = "bunifuPanel3";
            this.bunifuPanel3.ShowBorders = true;
            this.bunifuPanel3.Size = new System.Drawing.Size(530, 287);
            this.bunifuPanel3.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvTransacHist);
            this.panel1.Location = new System.Drawing.Point(27, 42);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(476, 225);
            this.panel1.TabIndex = 2;
            // 
            // dgvTransacHist
            // 
            this.dgvTransacHist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTransacHist.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTransacHist.Location = new System.Drawing.Point(0, 0);
            this.dgvTransacHist.Name = "dgvTransacHist";
            this.dgvTransacHist.Size = new System.Drawing.Size(476, 225);
            this.dgvTransacHist.TabIndex = 0;
            // 
            // bunifuGradientPanel2
            // 
            this.bunifuGradientPanel2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuGradientPanel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel2.BackgroundImage")));
            this.bunifuGradientPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel2.BorderRadius = 5;
            this.bunifuGradientPanel2.Controls.Add(this.label10);
            this.bunifuGradientPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.bunifuGradientPanel2.GradientBottomLeft = System.Drawing.Color.Teal;
            this.bunifuGradientPanel2.GradientBottomRight = System.Drawing.Color.DarkGreen;
            this.bunifuGradientPanel2.GradientTopLeft = System.Drawing.Color.Green;
            this.bunifuGradientPanel2.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.bunifuGradientPanel2.Location = new System.Drawing.Point(0, 0);
            this.bunifuGradientPanel2.Name = "bunifuGradientPanel2";
            this.bunifuGradientPanel2.Quality = 10;
            this.bunifuGradientPanel2.Size = new System.Drawing.Size(530, 27);
            this.bunifuGradientPanel2.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(0, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(530, 27);
            this.label10.TabIndex = 0;
            this.label10.Text = "Transaction History";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnGetCr
            // 
            this.btnGetCr.AllowAnimations = true;
            this.btnGetCr.AllowMouseEffects = true;
            this.btnGetCr.AllowToggling = false;
            this.btnGetCr.AnimationSpeed = 200;
            this.btnGetCr.AutoGenerateColors = false;
            this.btnGetCr.AutoRoundBorders = false;
            this.btnGetCr.AutoSizeLeftIcon = true;
            this.btnGetCr.AutoSizeRightIcon = true;
            this.btnGetCr.BackColor = System.Drawing.Color.Transparent;
            this.btnGetCr.BackColor1 = System.Drawing.Color.DodgerBlue;
            this.btnGetCr.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGetCr.BackgroundImage")));
            this.btnGetCr.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnGetCr.ButtonText = "Get Crystal Report";
            this.btnGetCr.ButtonTextMarginLeft = 0;
            this.btnGetCr.ColorContrastOnClick = 45;
            this.btnGetCr.ColorContrastOnHover = 45;
            this.btnGetCr.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.btnGetCr.CustomizableEdges = borderEdges2;
            this.btnGetCr.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnGetCr.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnGetCr.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnGetCr.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnGetCr.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnGetCr.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnGetCr.ForeColor = System.Drawing.Color.White;
            this.btnGetCr.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGetCr.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnGetCr.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnGetCr.IconMarginLeft = 11;
            this.btnGetCr.IconPadding = 10;
            this.btnGetCr.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGetCr.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnGetCr.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnGetCr.IconSize = 25;
            this.btnGetCr.IdleBorderColor = System.Drawing.Color.DodgerBlue;
            this.btnGetCr.IdleBorderRadius = 10;
            this.btnGetCr.IdleBorderThickness = 1;
            this.btnGetCr.IdleFillColor = System.Drawing.Color.DodgerBlue;
            this.btnGetCr.IdleIconLeftImage = null;
            this.btnGetCr.IdleIconRightImage = null;
            this.btnGetCr.IndicateFocus = false;
            this.btnGetCr.Location = new System.Drawing.Point(475, 501);
            this.btnGetCr.Name = "btnGetCr";
            this.btnGetCr.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnGetCr.OnDisabledState.BorderRadius = 10;
            this.btnGetCr.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnGetCr.OnDisabledState.BorderThickness = 1;
            this.btnGetCr.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnGetCr.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnGetCr.OnDisabledState.IconLeftImage = null;
            this.btnGetCr.OnDisabledState.IconRightImage = null;
            this.btnGetCr.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnGetCr.onHoverState.BorderRadius = 10;
            this.btnGetCr.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnGetCr.onHoverState.BorderThickness = 1;
            this.btnGetCr.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnGetCr.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnGetCr.onHoverState.IconLeftImage = null;
            this.btnGetCr.onHoverState.IconRightImage = null;
            this.btnGetCr.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnGetCr.OnIdleState.BorderRadius = 10;
            this.btnGetCr.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnGetCr.OnIdleState.BorderThickness = 1;
            this.btnGetCr.OnIdleState.FillColor = System.Drawing.Color.DodgerBlue;
            this.btnGetCr.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnGetCr.OnIdleState.IconLeftImage = null;
            this.btnGetCr.OnIdleState.IconRightImage = null;
            this.btnGetCr.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnGetCr.OnPressedState.BorderRadius = 10;
            this.btnGetCr.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnGetCr.OnPressedState.BorderThickness = 1;
            this.btnGetCr.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnGetCr.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnGetCr.OnPressedState.IconLeftImage = null;
            this.btnGetCr.OnPressedState.IconRightImage = null;
            this.btnGetCr.Size = new System.Drawing.Size(108, 32);
            this.btnGetCr.TabIndex = 1;
            this.btnGetCr.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnGetCr.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnGetCr.TextMarginLeft = 0;
            this.btnGetCr.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnGetCr.UseDefaultRadiusAndThickness = true;
            this.btnGetCr.Click += new System.EventHandler(this.btnGetCr_Click);
            // 
            // bunifuTileButton1
            // 
            this.bunifuTileButton1.BackColor = System.Drawing.Color.SeaGreen;
            this.bunifuTileButton1.color = System.Drawing.Color.SeaGreen;
            this.bunifuTileButton1.colorActive = System.Drawing.Color.MediumSeaGreen;
            this.bunifuTileButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTileButton1.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.bunifuTileButton1.ForeColor = System.Drawing.Color.White;
            this.bunifuTileButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuTileButton1.Image")));
            this.bunifuTileButton1.ImagePosition = 14;
            this.bunifuTileButton1.ImageZoom = 50;
            this.bunifuTileButton1.LabelPosition = 27;
            this.bunifuTileButton1.LabelText = "Pay Tuition";
            this.bunifuTileButton1.Location = new System.Drawing.Point(53, 501);
            this.bunifuTileButton1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bunifuTileButton1.Name = "bunifuTileButton1";
            this.bunifuTileButton1.Size = new System.Drawing.Size(108, 32);
            this.bunifuTileButton1.TabIndex = 2;
            this.bunifuTileButton1.Click += new System.EventHandler(this.bunifuTileButton1_Click);
            // 
            // accBalanceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.ClientSize = new System.Drawing.Size(636, 580);
            this.Controls.Add(this.bunifuTileButton1);
            this.Controls.Add(this.btnGetCr);
            this.Controls.Add(this.bunifuPanel3);
            this.Controls.Add(this.bunifuPanel2);
            this.Controls.Add(this.bunifuPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "accBalanceForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.accBalanceForm_Load);
            this.bunifuPanel1.ResumeLayout(false);
            this.bunifuPanel1.PerformLayout();
            this.bunifuPanel2.ResumeLayout(false);
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.bunifuPanel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransacHist)).EndInit();
            this.bunifuGradientPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel1;
        private System.Windows.Forms.Label financeID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label fullName;
        private System.Windows.Forms.Label label1;
        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel2;
        private Bunifu.UI.WinForms.BunifuGradientPanel bunifuGradientPanel1;
        private System.Windows.Forms.Label lastBalance;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel3;
        private Bunifu.UI.WinForms.BunifuGradientPanel bunifuGradientPanel2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvTransacHist;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnGetCr;
        private Bunifu.Framework.UI.BunifuTileButton bunifuTileButton1;
    }
}