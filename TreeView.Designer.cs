namespace tstTreeView
{
    partial class TreeView
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
            components = new System.ComponentModel.Container();
            SplitContainerMain = new SplitContainer();
            TreeViewMain = new System.Windows.Forms.TreeView();
            СontextMenuForTreeView = new ContextMenuStrip(components);
            CtxMenuAddElement = new ToolStripMenuItem();
            CtxMenuRemoveElement = new ToolStripMenuItem();
            ButtonSearchEle = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            LabelNameEle = new Label();
            TextBoxNameSE = new TextBox();
            TextBoxValueSE = new TextBox();
            LabelValueEle = new Label();
            ButtonSaveNewEle = new Button();
            TextBoxSearch = new TextBox();
            ((System.ComponentModel.ISupportInitialize)SplitContainerMain).BeginInit();
            SplitContainerMain.Panel1.SuspendLayout();
            SplitContainerMain.Panel2.SuspendLayout();
            SplitContainerMain.SuspendLayout();
            СontextMenuForTreeView.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // SplitContainerMain
            // 
            SplitContainerMain.Dock = DockStyle.Fill;
            SplitContainerMain.Location = new Point(0, 0);
            SplitContainerMain.Name = "SplitContainerMain";
            // 
            // SplitContainerMain.Panel1
            // 
            SplitContainerMain.Panel1.Controls.Add(TreeViewMain);
            // 
            // SplitContainerMain.Panel2
            // 
            SplitContainerMain.Panel2.Controls.Add(ButtonSearchEle);
            SplitContainerMain.Panel2.Controls.Add(tableLayoutPanel1);
            SplitContainerMain.Panel2.Controls.Add(TextBoxSearch);
            SplitContainerMain.Size = new Size(800, 450);
            SplitContainerMain.SplitterDistance = 266;
            SplitContainerMain.TabIndex = 0;
            // 
            // TreeViewMain
            // 
            TreeViewMain.ContextMenuStrip = СontextMenuForTreeView;
            TreeViewMain.Dock = DockStyle.Fill;
            TreeViewMain.Location = new Point(0, 0);
            TreeViewMain.Name = "TreeViewMain";
            TreeViewMain.Size = new Size(266, 450);
            TreeViewMain.TabIndex = 0;
            TreeViewMain.AfterSelect += TreeViewMain_AfterSelect;
            TreeViewMain.MouseClick += TreeViewMain_MouseClick;
            TreeViewMain.MouseDown += TreeViewMain_MouseDown;
            // 
            // СontextMenuForTreeView
            // 
            СontextMenuForTreeView.ImageScalingSize = new Size(32, 32);
            СontextMenuForTreeView.Items.AddRange(new ToolStripItem[] { CtxMenuAddElement, CtxMenuRemoveElement });
            СontextMenuForTreeView.Name = "СontextMenuForTreeView";
            СontextMenuForTreeView.Size = new Size(195, 80);
            // 
            // CtxMenuAddElement
            // 
            CtxMenuAddElement.Name = "CtxMenuAddElement";
            CtxMenuAddElement.Size = new Size(194, 38);
            CtxMenuAddElement.Text = "Добавить";
            CtxMenuAddElement.Click += CtxMenuAddElement_Click;
            // 
            // CtxMenuRemoveElement
            // 
            CtxMenuRemoveElement.Name = "CtxMenuRemoveElement";
            CtxMenuRemoveElement.Size = new Size(194, 38);
            CtxMenuRemoveElement.Text = "Удалить";
            CtxMenuRemoveElement.Click += CtxMenuRemoveElement_Click;
            // 
            // ButtonSearchEle
            // 
            ButtonSearchEle.Location = new Point(286, 33);
            ButtonSearchEle.Name = "ButtonSearchEle";
            ButtonSearchEle.Size = new Size(145, 40);
            ButtonSearchEle.TabIndex = 1;
            ButtonSearchEle.Text = "Найти";
            ButtonSearchEle.UseVisualStyleBackColor = true;
            ButtonSearchEle.Click += ButtonSearchEle_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 41.6184959F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 58.3815041F));
            tableLayoutPanel1.Controls.Add(LabelNameEle, 0, 0);
            tableLayoutPanel1.Controls.Add(TextBoxNameSE, 1, 0);
            tableLayoutPanel1.Controls.Add(TextBoxValueSE, 1, 1);
            tableLayoutPanel1.Controls.Add(LabelValueEle, 0, 1);
            tableLayoutPanel1.Controls.Add(ButtonSaveNewEle, 1, 2);
            tableLayoutPanel1.Location = new Point(90, 90);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 46.5517235F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 53.4482765F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel1.Size = new Size(346, 142);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // LabelNameEle
            // 
            LabelNameEle.AutoSize = true;
            LabelNameEle.Location = new Point(3, 0);
            LabelNameEle.Name = "LabelNameEle";
            LabelNameEle.Size = new Size(116, 32);
            LabelNameEle.TabIndex = 3;
            LabelNameEle.Text = "Имя узла";
            LabelNameEle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // TextBoxNameSE
            // 
            TextBoxNameSE.Location = new Point(147, 3);
            TextBoxNameSE.Name = "TextBoxNameSE";
            TextBoxNameSE.Size = new Size(194, 39);
            TextBoxNameSE.TabIndex = 2;
            // 
            // TextBoxValueSE
            // 
            TextBoxValueSE.Location = new Point(147, 45);
            TextBoxValueSE.Name = "TextBoxValueSE";
            TextBoxValueSE.Size = new Size(194, 39);
            TextBoxValueSE.TabIndex = 1;
            // 
            // LabelValueEle
            // 
            LabelValueEle.AutoSize = true;
            LabelValueEle.Location = new Point(3, 42);
            LabelValueEle.Name = "LabelValueEle";
            LabelValueEle.Size = new Size(121, 32);
            LabelValueEle.TabIndex = 4;
            LabelValueEle.Text = "Значение";
            LabelValueEle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ButtonSaveNewEle
            // 
            ButtonSaveNewEle.Location = new Point(147, 94);
            ButtonSaveNewEle.Name = "ButtonSaveNewEle";
            ButtonSaveNewEle.Size = new Size(194, 45);
            ButtonSaveNewEle.TabIndex = 2;
            ButtonSaveNewEle.Text = "Сохранить";
            ButtonSaveNewEle.UseVisualStyleBackColor = true;
            ButtonSaveNewEle.Click += ButtonSaveNewEle_Click;
            // 
            // TextBoxSearch
            // 
            TextBoxSearch.Location = new Point(90, 33);
            TextBoxSearch.Name = "TextBoxSearch";
            TextBoxSearch.Size = new Size(171, 39);
            TextBoxSearch.TabIndex = 0;
            // 
            // TreeView
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(SplitContainerMain);
            Name = "TreeView";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TreeView";
            SplitContainerMain.Panel1.ResumeLayout(false);
            SplitContainerMain.Panel2.ResumeLayout(false);
            SplitContainerMain.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)SplitContainerMain).EndInit();
            SplitContainerMain.ResumeLayout(false);
            СontextMenuForTreeView.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer SplitContainerMain;
        private System.Windows.Forms.TreeView TreeViewMain;
        private Button ButtonSearchEle;
        private TableLayoutPanel tableLayoutPanel1;
        private Label LabelNameEle;
        private TextBox TextBoxNameSE;
        private TextBox TextBoxValueSE;
        private Label LabelValueEle;
        private Button ButtonSaveNewEle;
        private TextBox TextBoxSearch;
        private ContextMenuStrip СontextMenuForTreeView;
        private ToolStripMenuItem CtxMenuAddElement;
        private ToolStripMenuItem CtxMenuRemoveElement;
    }
}
