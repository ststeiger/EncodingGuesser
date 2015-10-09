namespace EncodingTester
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvResult = new System.Windows.Forms.DataGridView();
            this.btnTest = new System.Windows.Forms.Button();
            this.btnTestAll = new System.Windows.Forms.Button();
            this.txtCorrect = new System.Windows.Forms.TextBox();
            this.lblCorrect = new System.Windows.Forms.Label();
            this.txtWrong = new System.Windows.Forms.TextBox();
            this.lblWrong = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResult)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvResult
            // 
            this.dgvResult.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResult.Location = new System.Drawing.Point(12, 93);
            this.dgvResult.Name = "dgvResult";
            this.dgvResult.Size = new System.Drawing.Size(923, 475);
            this.dgvResult.TabIndex = 0;
            // 
            // btnTest
            // 
            this.btnTest.Location = new System.Drawing.Point(12, 587);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(91, 23);
            this.btnTest.TabIndex = 1;
            this.btnTest.Text = "Test Common";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // btnTestAll
            // 
            this.btnTestAll.Location = new System.Drawing.Point(109, 587);
            this.btnTestAll.Name = "btnTestAll";
            this.btnTestAll.Size = new System.Drawing.Size(75, 23);
            this.btnTestAll.TabIndex = 2;
            this.btnTestAll.Text = "Test All";
            this.btnTestAll.UseVisualStyleBackColor = true;
            this.btnTestAll.Click += new System.EventHandler(this.btnTestAll_Click);
            // 
            // txtCorrect
            // 
            this.txtCorrect.Location = new System.Drawing.Point(86, 29);
            this.txtCorrect.Name = "txtCorrect";
            this.txtCorrect.Size = new System.Drawing.Size(849, 20);
            this.txtCorrect.TabIndex = 3;
            // 
            // lblCorrect
            // 
            this.lblCorrect.AutoSize = true;
            this.lblCorrect.Location = new System.Drawing.Point(12, 32);
            this.lblCorrect.Name = "lblCorrect";
            this.lblCorrect.Size = new System.Drawing.Size(68, 13);
            this.lblCorrect.TabIndex = 4;
            this.lblCorrect.Text = "Correct Text:";
            // 
            // txtWrong
            // 
            this.txtWrong.Location = new System.Drawing.Point(86, 55);
            this.txtWrong.Name = "txtWrong";
            this.txtWrong.Size = new System.Drawing.Size(849, 20);
            this.txtWrong.TabIndex = 5;
            // 
            // lblWrong
            // 
            this.lblWrong.AutoSize = true;
            this.lblWrong.Location = new System.Drawing.Point(12, 58);
            this.lblWrong.Name = "lblWrong";
            this.lblWrong.Size = new System.Drawing.Size(66, 13);
            this.lblWrong.TabIndex = 6;
            this.lblWrong.Text = "Wrong Text:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(959, 628);
            this.Controls.Add(this.lblWrong);
            this.Controls.Add(this.txtWrong);
            this.Controls.Add(this.lblCorrect);
            this.Controls.Add(this.txtCorrect);
            this.Controls.Add(this.btnTestAll);
            this.Controls.Add(this.btnTest);
            this.Controls.Add(this.dgvResult);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Encoding Guesser";
            ((System.ComponentModel.ISupportInitialize)(this.dgvResult)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvResult;
        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.Button btnTestAll;
        private System.Windows.Forms.TextBox txtCorrect;
        private System.Windows.Forms.Label lblCorrect;
        private System.Windows.Forms.TextBox txtWrong;
        private System.Windows.Forms.Label lblWrong;
    }
}

