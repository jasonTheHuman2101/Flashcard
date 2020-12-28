
namespace Flashcard
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.fileBox = new System.Windows.Forms.ToolStripDropDownButton();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutBttn = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.messageLabel = new System.Windows.Forms.ToolStripLabel();
            this.nextCard = new System.Windows.Forms.Button();
            this.prevCard = new System.Windows.Forms.Button();
            this.isQuestioncardCheckBox = new System.Windows.Forms.CheckBox();
            this.showCard = new System.Windows.Forms.Button();
            this.hideCard = new System.Windows.Forms.Button();
            this.backCard = new System.Windows.Forms.TextBox();
            this.frontCard = new System.Windows.Forms.TextBox();
            this.holdingFrame = new System.Windows.Forms.Panel();
            this.saveDiag = new System.Windows.Forms.SaveFileDialog();
            this.openDiag = new System.Windows.Forms.OpenFileDialog();
            this.toolStrip1.SuspendLayout();
            this.holdingFrame.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileBox,
            this.aboutBttn,
            this.toolStripSeparator1,
            this.messageLabel});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(708, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // fileBox
            // 
            this.fileBox.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem});
            this.fileBox.Name = "fileBox";
            this.fileBox.Size = new System.Drawing.Size(38, 22);
            this.fileBox.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // aboutBttn
            // 
            this.aboutBttn.Checked = true;
            this.aboutBttn.CheckState = System.Windows.Forms.CheckState.Checked;
            this.aboutBttn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.aboutBttn.Image = ((System.Drawing.Image)(resources.GetObject("aboutBttn.Image")));
            this.aboutBttn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.aboutBttn.Name = "aboutBttn";
            this.aboutBttn.Size = new System.Drawing.Size(53, 22);
            this.aboutBttn.Text = "About...";
            this.aboutBttn.Click += new System.EventHandler(this.aboutBttn_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // messageLabel
            // 
            this.messageLabel.Name = "messageLabel";
            this.messageLabel.Size = new System.Drawing.Size(191, 22);
            this.messageLabel.Text = "Create or Open a Flashpack to start";
            // 
            // nextCard
            // 
            this.nextCard.Location = new System.Drawing.Point(355, 272);
            this.nextCard.Name = "nextCard";
            this.nextCard.Size = new System.Drawing.Size(56, 51);
            this.nextCard.TabIndex = 3;
            this.nextCard.Text = "=>";
            this.nextCard.UseVisualStyleBackColor = true;
            this.nextCard.Click += new System.EventHandler(this.nextCard_Click);
            // 
            // prevCard
            // 
            this.prevCard.Location = new System.Drawing.Point(293, 272);
            this.prevCard.Name = "prevCard";
            this.prevCard.Size = new System.Drawing.Size(56, 51);
            this.prevCard.TabIndex = 4;
            this.prevCard.Text = "<=";
            this.prevCard.UseVisualStyleBackColor = true;
            this.prevCard.Click += new System.EventHandler(this.prevCard_Click);
            // 
            // isQuestioncardCheckBox
            // 
            this.isQuestioncardCheckBox.AutoSize = true;
            this.isQuestioncardCheckBox.Location = new System.Drawing.Point(466, 272);
            this.isQuestioncardCheckBox.Name = "isQuestioncardCheckBox";
            this.isQuestioncardCheckBox.Size = new System.Drawing.Size(93, 17);
            this.isQuestioncardCheckBox.TabIndex = 6;
            this.isQuestioncardCheckBox.Text = "Question Card";
            this.isQuestioncardCheckBox.UseVisualStyleBackColor = true;
            this.isQuestioncardCheckBox.CheckedChanged += new System.EventHandler(this.isQuestioncardCheckBox_CheckedChanged);
            // 
            // showCard
            // 
            this.showCard.Location = new System.Drawing.Point(466, 295);
            this.showCard.Name = "showCard";
            this.showCard.Size = new System.Drawing.Size(42, 23);
            this.showCard.TabIndex = 7;
            this.showCard.Text = "Show";
            this.showCard.UseVisualStyleBackColor = true;
            this.showCard.Click += new System.EventHandler(this.showCard_Click);
            // 
            // hideCard
            // 
            this.hideCard.Location = new System.Drawing.Point(514, 295);
            this.hideCard.Name = "hideCard";
            this.hideCard.Size = new System.Drawing.Size(42, 23);
            this.hideCard.TabIndex = 8;
            this.hideCard.Text = "Hide";
            this.hideCard.UseVisualStyleBackColor = true;
            this.hideCard.Click += new System.EventHandler(this.hideCard_Click);
            // 
            // backCard
            // 
            this.backCard.BackColor = System.Drawing.Color.White;
            this.backCard.ForeColor = System.Drawing.Color.Black;
            this.backCard.Location = new System.Drawing.Point(355, 3);
            this.backCard.Multiline = true;
            this.backCard.Name = "backCard";
            this.backCard.Size = new System.Drawing.Size(346, 264);
            this.backCard.TabIndex = 2;
            // 
            // frontCard
            // 
            this.frontCard.BackColor = System.Drawing.Color.White;
            this.frontCard.ForeColor = System.Drawing.Color.Black;
            this.frontCard.Location = new System.Drawing.Point(3, 2);
            this.frontCard.Multiline = true;
            this.frontCard.Name = "frontCard";
            this.frontCard.Size = new System.Drawing.Size(346, 264);
            this.frontCard.TabIndex = 1;
            // 
            // holdingFrame
            // 
            this.holdingFrame.Controls.Add(this.hideCard);
            this.holdingFrame.Controls.Add(this.backCard);
            this.holdingFrame.Controls.Add(this.showCard);
            this.holdingFrame.Controls.Add(this.isQuestioncardCheckBox);
            this.holdingFrame.Controls.Add(this.prevCard);
            this.holdingFrame.Controls.Add(this.nextCard);
            this.holdingFrame.Controls.Add(this.frontCard);
            this.holdingFrame.Enabled = false;
            this.holdingFrame.Location = new System.Drawing.Point(0, 28);
            this.holdingFrame.Name = "holdingFrame";
            this.holdingFrame.Size = new System.Drawing.Size(708, 334);
            this.holdingFrame.TabIndex = 9;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 361);
            this.Controls.Add(this.holdingFrame);
            this.Controls.Add(this.toolStrip1);
            this.Name = "MainForm";
            this.Text = "Flashcard";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.holdingFrame.ResumeLayout(false);
            this.holdingFrame.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton fileBox;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton aboutBttn;
        private System.Windows.Forms.Button nextCard;
        private System.Windows.Forms.Button prevCard;
        private System.Windows.Forms.CheckBox isQuestioncardCheckBox;
        private System.Windows.Forms.Button showCard;
        private System.Windows.Forms.Button hideCard;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel messageLabel;
        private System.Windows.Forms.TextBox backCard;
        private System.Windows.Forms.TextBox frontCard;
        private System.Windows.Forms.Panel holdingFrame;
        private System.Windows.Forms.SaveFileDialog saveDiag;
        private System.Windows.Forms.OpenFileDialog openDiag;
    }
}

