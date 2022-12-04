namespace Template_If_POS
{
    partial class MainForm
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
            this.catalogView = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.billView = new System.Windows.Forms.ListView();
            this.label2 = new System.Windows.Forms.Label();
            this.addProductButton = new System.Windows.Forms.Button();
            this.removeProductButton = new System.Windows.Forms.Button();
            this.clearBillButton = new System.Windows.Forms.Button();
            this.payButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // catalogView
            // 
            this.catalogView.Location = new System.Drawing.Point(12, 37);
            this.catalogView.Name = "catalogView";
            this.catalogView.Size = new System.Drawing.Size(445, 543);
            this.catalogView.TabIndex = 0;
            this.catalogView.UseCompatibleStateImageBehavior = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Produktkatalog";
            // 
            // billView
            // 
            this.billView.Location = new System.Drawing.Point(555, 37);
            this.billView.Name = "billView";
            this.billView.Size = new System.Drawing.Size(445, 543);
            this.billView.TabIndex = 2;
            this.billView.UseCompatibleStateImageBehavior = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(555, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Rechnung";
            // 
            // addProductButton
            // 
            this.addProductButton.Location = new System.Drawing.Point(12, 586);
            this.addProductButton.Name = "addProductButton";
            this.addProductButton.Size = new System.Drawing.Size(153, 52);
            this.addProductButton.TabIndex = 4;
            this.addProductButton.Text = "Produkt hinzufügen";
            this.addProductButton.UseVisualStyleBackColor = true;
            this.addProductButton.Click += new System.EventHandler(this.addProductButton_Click);
            // 
            // removeProductButton
            // 
            this.removeProductButton.Location = new System.Drawing.Point(555, 586);
            this.removeProductButton.Name = "removeProductButton";
            this.removeProductButton.Size = new System.Drawing.Size(153, 52);
            this.removeProductButton.TabIndex = 5;
            this.removeProductButton.Text = "Produkt entfernen";
            this.removeProductButton.UseVisualStyleBackColor = true;
            this.removeProductButton.Click += new System.EventHandler(this.removeProductButton_Click);
            // 
            // clearBillButton
            // 
            this.clearBillButton.Location = new System.Drawing.Point(714, 586);
            this.clearBillButton.Name = "clearBillButton";
            this.clearBillButton.Size = new System.Drawing.Size(153, 52);
            this.clearBillButton.TabIndex = 6;
            this.clearBillButton.Text = "Liste leeren";
            this.clearBillButton.UseVisualStyleBackColor = true;
            this.clearBillButton.Click += new System.EventHandler(this.clearBillButton_Click);
            // 
            // payButton
            // 
            this.payButton.Location = new System.Drawing.Point(1056, 37);
            this.payButton.Name = "payButton";
            this.payButton.Size = new System.Drawing.Size(153, 52);
            this.payButton.TabIndex = 7;
            this.payButton.Text = "Bezahlen ...";
            this.payButton.UseVisualStyleBackColor = true;
            this.payButton.Click += new System.EventHandler(this.payButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1247, 651);
            this.Controls.Add(this.payButton);
            this.Controls.Add(this.clearBillButton);
            this.Controls.Add(this.removeProductButton);
            this.Controls.Add(this.addProductButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.billView);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.catalogView);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Point of Sale";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListView catalogView;
        private Label label1;
        private ListView billView;
        private Label label2;
        private Button addProductButton;
        private Button removeProductButton;
        private Button clearBillButton;
        private Button payButton;
    }
}