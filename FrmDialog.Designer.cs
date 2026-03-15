namespace tstTreeView
{
    partial class FrmDialog
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
            LabelEnterValue = new Label();
            TextBoxInputName = new TextBox();
            BtnOK = new Button();
            BtnCancel = new Button();
            TextBoxInputValue = new TextBox();
            SuspendLayout();
            // 
            // LabelEnterValue
            // 
            LabelEnterValue.AutoSize = true;
            LabelEnterValue.Location = new Point(12, 9);
            LabelEnterValue.Name = "LabelEnterValue";
            LabelEnterValue.Size = new Size(761, 32);
            LabelEnterValue.TabIndex = 0;
            LabelEnterValue.Text = "Введите название нового элемента и его значение соответсвенно:";
            // 
            // TextBoxInputName
            // 
            TextBoxInputName.Location = new Point(12, 58);
            TextBoxInputName.Name = "TextBoxInputName";
            TextBoxInputName.Size = new Size(382, 39);
            TextBoxInputName.TabIndex = 1;
            TextBoxInputName.Text = "Узел";
            // 
            // BtnOK
            // 
            BtnOK.Location = new Point(482, 112);
            BtnOK.Name = "BtnOK";
            BtnOK.Size = new Size(150, 46);
            BtnOK.TabIndex = 2;
            BtnOK.Text = "&ОК";
            BtnOK.UseVisualStyleBackColor = true;
            BtnOK.Click += BtnOK_Click;
            // 
            // BtnCancel
            // 
            BtnCancel.Location = new Point(638, 112);
            BtnCancel.Name = "BtnCancel";
            BtnCancel.Size = new Size(150, 46);
            BtnCancel.TabIndex = 3;
            BtnCancel.Text = "&Отмена";
            BtnCancel.UseVisualStyleBackColor = true;
            BtnCancel.Click += BtnCancel_Click;
            // 
            // TextBoxInputValue
            // 
            TextBoxInputValue.Location = new Point(406, 58);
            TextBoxInputValue.Name = "TextBoxInputValue";
            TextBoxInputValue.Size = new Size(382, 39);
            TextBoxInputValue.TabIndex = 4;
            // 
            // FrmDialog
            // 
            AcceptButton = BtnOK;
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = BtnCancel;
            ClientSize = new Size(800, 176);
            Controls.Add(TextBoxInputValue);
            Controls.Add(BtnCancel);
            Controls.Add(BtnOK);
            Controls.Add(TextBoxInputName);
            Controls.Add(LabelEnterValue);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmDialog";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Введите значение";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LabelEnterValue;
        private TextBox TextBoxInputName;
        private Button BtnOK;
        private Button BtnCancel;
        private TextBox TextBoxInputValue;
    }
}