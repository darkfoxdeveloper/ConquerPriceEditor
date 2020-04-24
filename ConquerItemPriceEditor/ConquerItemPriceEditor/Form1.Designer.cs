namespace ConquerItemPriceEditor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.openItemtype = new System.Windows.Forms.OpenFileDialog();
            this.console = new System.Windows.Forms.RichTextBox();
            this.priceMoney = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.priceConquerPoints = new System.Windows.Forms.TextBox();
            this.searchItem = new System.Windows.Forms.TextBox();
            this.caseSensitiveSearch = new System.Windows.Forms.CheckBox();
            this.about = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.previewImg = new System.Windows.Forms.PictureBox();
            this.searchNext = new System.Windows.Forms.Button();
            this.save = new System.Windows.Forms.Button();
            this.loadItemtype = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.previewImg)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 4);
            this.listBox1.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(177, 225);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // openItemtype
            // 
            this.openItemtype.Filter = "Itemtype|itemtype.dat";
            // 
            // console
            // 
            this.console.BackColor = System.Drawing.SystemColors.MenuText;
            this.console.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.console.ForeColor = System.Drawing.Color.LawnGreen;
            this.console.Location = new System.Drawing.Point(289, 68);
            this.console.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.console.Name = "console";
            this.console.ReadOnly = true;
            this.console.Size = new System.Drawing.Size(420, 123);
            this.console.TabIndex = 2;
            this.console.Text = "Waiting for action...";
            this.console.TextChanged += new System.EventHandler(this.console_TextChanged);
            // 
            // priceMoney
            // 
            this.priceMoney.Location = new System.Drawing.Point(288, 38);
            this.priceMoney.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.priceMoney.Name = "priceMoney";
            this.priceMoney.Size = new System.Drawing.Size(100, 21);
            this.priceMoney.TabIndex = 4;
            this.priceMoney.TextChanged += new System.EventHandler(this.priceMoney_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(286, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Price (Money)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(413, 21);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Price (ConquerPoints)";
            // 
            // priceConquerPoints
            // 
            this.priceConquerPoints.Location = new System.Drawing.Point(416, 38);
            this.priceConquerPoints.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.priceConquerPoints.Name = "priceConquerPoints";
            this.priceConquerPoints.Size = new System.Drawing.Size(100, 21);
            this.priceConquerPoints.TabIndex = 7;
            this.priceConquerPoints.TextChanged += new System.EventHandler(this.priceConquerPoints_TextChanged);
            // 
            // searchItem
            // 
            this.searchItem.Location = new System.Drawing.Point(12, 235);
            this.searchItem.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.searchItem.Name = "searchItem";
            this.searchItem.Size = new System.Drawing.Size(136, 21);
            this.searchItem.TabIndex = 9;
            this.searchItem.TextChanged += new System.EventHandler(this.searchItem_TextChanged);
            // 
            // caseSensitiveSearch
            // 
            this.caseSensitiveSearch.AutoSize = true;
            this.caseSensitiveSearch.Location = new System.Drawing.Point(27, 264);
            this.caseSensitiveSearch.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.caseSensitiveSearch.Name = "caseSensitiveSearch";
            this.caseSensitiveSearch.Size = new System.Drawing.Size(121, 17);
            this.caseSensitiveSearch.TabIndex = 10;
            this.caseSensitiveSearch.Text = "Search case sensitive";
            this.caseSensitiveSearch.UseVisualStyleBackColor = true;
            // 
            // about
            // 
            this.about.Location = new System.Drawing.Point(209, 161);
            this.about.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.about.Name = "about";
            this.about.Size = new System.Drawing.Size(68, 30);
            this.about.TabIndex = 12;
            this.about.Text = "About";
            this.about.UseVisualStyleBackColor = true;
            this.about.Click += new System.EventHandler(this.about_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(199, 20);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Preview Image:";
            // 
            // previewImg
            // 
            this.previewImg.BackColor = System.Drawing.Color.Transparent;
            this.previewImg.Image = global::ConquerItemPriceEditor.Properties.Resources.icono_forobeta;
            this.previewImg.Location = new System.Drawing.Point(202, 37);
            this.previewImg.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.previewImg.Name = "previewImg";
            this.previewImg.Size = new System.Drawing.Size(75, 67);
            this.previewImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.previewImg.TabIndex = 13;
            this.previewImg.TabStop = false;
            // 
            // searchNext
            // 
            this.searchNext.BackgroundImage = global::ConquerItemPriceEditor.Properties.Resources.icon;
            this.searchNext.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.searchNext.Location = new System.Drawing.Point(156, 235);
            this.searchNext.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.searchNext.Name = "searchNext";
            this.searchNext.Size = new System.Drawing.Size(33, 35);
            this.searchNext.TabIndex = 11;
            this.searchNext.UseVisualStyleBackColor = true;
            this.searchNext.Click += new System.EventHandler(this.searchNext_Click);
            // 
            // save
            // 
            this.save.BackgroundImage = global::ConquerItemPriceEditor.Properties.Resources.save;
            this.save.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.save.Location = new System.Drawing.Point(239, 112);
            this.save.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(33, 33);
            this.save.TabIndex = 3;
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // loadItemtype
            // 
            this.loadItemtype.BackgroundImage = global::ConquerItemPriceEditor.Properties.Resources.import;
            this.loadItemtype.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.loadItemtype.Location = new System.Drawing.Point(202, 112);
            this.loadItemtype.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.loadItemtype.Name = "loadItemtype";
            this.loadItemtype.Size = new System.Drawing.Size(33, 33);
            this.loadItemtype.TabIndex = 1;
            this.loadItemtype.UseVisualStyleBackColor = true;
            this.loadItemtype.Click += new System.EventHandler(this.loadItemtype_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 283);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.previewImg);
            this.Controls.Add(this.about);
            this.Controls.Add(this.searchNext);
            this.Controls.Add(this.caseSensitiveSearch);
            this.Controls.Add(this.searchItem);
            this.Controls.Add(this.priceConquerPoints);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.priceMoney);
            this.Controls.Add(this.save);
            this.Controls.Add(this.console);
            this.Controls.Add(this.loadItemtype);
            this.Controls.Add(this.listBox1);
            this.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "ConquerItemPriceEditor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.previewImg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button loadItemtype;
        private System.Windows.Forms.OpenFileDialog openItemtype;
        private System.Windows.Forms.RichTextBox console;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.TextBox priceMoney;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox priceConquerPoints;
        private System.Windows.Forms.TextBox searchItem;
        private System.Windows.Forms.CheckBox caseSensitiveSearch;
        private System.Windows.Forms.Button searchNext;
        private System.Windows.Forms.Button about;
        private System.Windows.Forms.PictureBox previewImg;
        private System.Windows.Forms.Label label4;
    }
}

