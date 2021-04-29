
namespace Task_4
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
            this.lblTranslation = new System.Windows.Forms.Label();
            this.word = new System.Windows.Forms.Label();
            this.tbTranslate = new System.Windows.Forms.RichTextBox();
            this.tbWord = new System.Windows.Forms.RichTextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.mainMenu = new System.Windows.Forms.ToolStripDropDownButton();
            this.menuItemNew = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemSave = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemSaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.menuItemExit = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.menuItemAdd = new System.Windows.Forms.ToolStripButton();
            this.menuItemDelete = new System.Windows.Forms.ToolStripButton();
            this.nudNumber = new System.Windows.Forms.NumericUpDown();
            this.countLbl = new System.Windows.Forms.Label();
            this.tbAboutApp = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTranslation
            // 
            this.lblTranslation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblTranslation.AutoSize = true;
            this.lblTranslation.Font = new System.Drawing.Font("Franklin Gothic Medium", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTranslation.ForeColor = System.Drawing.Color.DarkSeaGreen;
            this.lblTranslation.Location = new System.Drawing.Point(555, 87);
            this.lblTranslation.Name = "lblTranslation";
            this.lblTranslation.Size = new System.Drawing.Size(175, 37);
            this.lblTranslation.TabIndex = 9;
            this.lblTranslation.Text = "Translation:";
            // 
            // word
            // 
            this.word.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.word.AutoSize = true;
            this.word.Font = new System.Drawing.Font("Franklin Gothic Medium", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.word.ForeColor = System.Drawing.Color.DarkSeaGreen;
            this.word.Location = new System.Drawing.Point(58, 87);
            this.word.Name = "word";
            this.word.Size = new System.Drawing.Size(159, 37);
            this.word.TabIndex = 8;
            this.word.Text = "Your word:";
            // 
            // tbTranslate
            // 
            this.tbTranslate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbTranslate.Font = new System.Drawing.Font("Swis721 BT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTranslate.ForeColor = System.Drawing.Color.DodgerBlue;
            this.tbTranslate.Location = new System.Drawing.Point(560, 158);
            this.tbTranslate.Name = "tbTranslate";
            this.tbTranslate.Size = new System.Drawing.Size(420, 120);
            this.tbTranslate.TabIndex = 7;
            this.tbTranslate.Text = "";
            // 
            // tbWord
            // 
            this.tbWord.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbWord.Font = new System.Drawing.Font("Swis721 BT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbWord.ForeColor = System.Drawing.Color.DodgerBlue;
            this.tbWord.Location = new System.Drawing.Point(65, 158);
            this.tbWord.Name = "tbWord";
            this.tbWord.Size = new System.Drawing.Size(420, 120);
            this.tbWord.TabIndex = 6;
            this.tbWord.Text = "";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mainMenu,
            this.toolStripSeparator2,
            this.toolStripSeparator3,
            this.menuItemAdd,
            this.toolStripSeparator5,
            this.menuItemDelete,
            this.toolStripSeparator4,
            this.toolStripSeparator7,
            this.tbAboutApp});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1050, 25);
            this.toolStrip1.TabIndex = 10;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // mainMenu
            // 
            this.mainMenu.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.mainMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemNew,
            this.menuItemOpen,
            this.menuItemSave,
            this.menuItemSaveAs,
            this.toolStripSeparator1,
            this.menuItemExit});
            this.mainMenu.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mainMenu.Image = ((System.Drawing.Image)(resources.GetObject("mainMenu.Image")));
            this.mainMenu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Size = new System.Drawing.Size(38, 22);
            this.mainMenu.Text = "File";
            // 
            // menuItemNew
            // 
            this.menuItemNew.Name = "menuItemNew";
            this.menuItemNew.Size = new System.Drawing.Size(180, 22);
            this.menuItemNew.Text = "New";
            this.menuItemNew.Click += new System.EventHandler(this.menuItemNew_Click);
            // 
            // menuItemOpen
            // 
            this.menuItemOpen.Name = "menuItemOpen";
            this.menuItemOpen.Size = new System.Drawing.Size(180, 22);
            this.menuItemOpen.Text = "Open";
            this.menuItemOpen.Click += new System.EventHandler(this.menuItemOpen_Click);
            // 
            // menuItemSave
            // 
            this.menuItemSave.Name = "menuItemSave";
            this.menuItemSave.Size = new System.Drawing.Size(180, 22);
            this.menuItemSave.Text = "Save current word";
            this.menuItemSave.Click += new System.EventHandler(this.menuItemSave_Click);
            // 
            // menuItemSaveAs
            // 
            this.menuItemSaveAs.Name = "menuItemSaveAs";
            this.menuItemSaveAs.Size = new System.Drawing.Size(180, 22);
            this.menuItemSaveAs.Text = "Save All As ...";
            this.menuItemSaveAs.Click += new System.EventHandler(this.menuItemSaveAs_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // menuItemExit
            // 
            this.menuItemExit.Name = "menuItemExit";
            this.menuItemExit.Size = new System.Drawing.Size(180, 22);
            this.menuItemExit.Text = "Exit";
            this.menuItemExit.Click += new System.EventHandler(this.menuItemExit_Click_1);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // menuItemAdd
            // 
            this.menuItemAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.menuItemAdd.Image = ((System.Drawing.Image)(resources.GetObject("menuItemAdd.Image")));
            this.menuItemAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.menuItemAdd.Name = "menuItemAdd";
            this.menuItemAdd.Size = new System.Drawing.Size(88, 22);
            this.menuItemAdd.Text = "Add new word";
            this.menuItemAdd.Click += new System.EventHandler(this.menuItemAdd_Click);
            // 
            // menuItemDelete
            // 
            this.menuItemDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.menuItemDelete.Image = ((System.Drawing.Image)(resources.GetObject("menuItemDelete.Image")));
            this.menuItemDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.menuItemDelete.Name = "menuItemDelete";
            this.menuItemDelete.Size = new System.Drawing.Size(74, 22);
            this.menuItemDelete.Text = "Delete word";
            this.menuItemDelete.Click += new System.EventHandler(this.menuItemDelete_Click);
            // 
            // nudNumber
            // 
            this.nudNumber.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.nudNumber.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nudNumber.ForeColor = System.Drawing.Color.DarkSeaGreen;
            this.nudNumber.Location = new System.Drawing.Point(274, 333);
            this.nudNumber.Name = "nudNumber";
            this.nudNumber.Size = new System.Drawing.Size(49, 35);
            this.nudNumber.TabIndex = 11;
            this.nudNumber.ValueChanged += new System.EventHandler(this.nudNumber_ValueChanged);
            // 
            // countLbl
            // 
            this.countLbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.countLbl.AutoSize = true;
            this.countLbl.Font = new System.Drawing.Font("Franklin Gothic Demi", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.countLbl.ForeColor = System.Drawing.Color.DarkSeaGreen;
            this.countLbl.Location = new System.Drawing.Point(59, 332);
            this.countLbl.Name = "countLbl";
            this.countLbl.Size = new System.Drawing.Size(200, 34);
            this.countLbl.TabIndex = 12;
            this.countLbl.Text = "Count of words:";
            // 
            // tbAboutApp
            // 
            this.tbAboutApp.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tbAboutApp.Image = ((System.Drawing.Image)(resources.GetObject("tbAboutApp.Image")));
            this.tbAboutApp.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbAboutApp.Name = "tbAboutApp";
            this.tbAboutApp.Size = new System.Drawing.Size(106, 22);
            this.tbAboutApp.Text = "About application";
            this.tbAboutApp.Click += new System.EventHandler(this.tbAboutApp_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(6, 25);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1050, 435);
            this.Controls.Add(this.countLbl);
            this.Controls.Add(this.nudNumber);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.lblTranslation);
            this.Controls.Add(this.word);
            this.Controls.Add(this.tbTranslate);
            this.Controls.Add(this.tbWord);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumber)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTranslation;
        private System.Windows.Forms.Label word;
        private System.Windows.Forms.RichTextBox tbTranslate;
        private System.Windows.Forms.RichTextBox tbWord;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton mainMenu;
        private System.Windows.Forms.ToolStripMenuItem menuItemNew;
        private System.Windows.Forms.ToolStripMenuItem menuItemOpen;
        private System.Windows.Forms.ToolStripMenuItem menuItemSave;
        private System.Windows.Forms.ToolStripMenuItem menuItemSaveAs;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem menuItemExit;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton menuItemAdd;
        private System.Windows.Forms.ToolStripButton menuItemDelete;
        private System.Windows.Forms.NumericUpDown nudNumber;
        private System.Windows.Forms.Label countLbl;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton tbAboutApp;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
    }
}

