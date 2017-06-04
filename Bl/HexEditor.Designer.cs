namespace Bl
{
    partial class HexEditor
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.InputLbl = new System.Windows.Forms.Label();
            this.EditorTxtBox = new System.Windows.Forms.TextBox();
            this.EditorBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // InputLbl
            // 
            this.InputLbl.BackColor = System.Drawing.SystemColors.Control;
            this.InputLbl.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InputLbl.Location = new System.Drawing.Point(0, 60);
            this.InputLbl.Name = "InputLbl";
            this.InputLbl.Size = new System.Drawing.Size(340, 60);
            this.InputLbl.TabIndex = 1;
            this.InputLbl.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.InputLbl_MouseDoubleClick);
            // 
            // EditorTxtBox
            // 
            this.EditorTxtBox.Location = new System.Drawing.Point(0, 0);
            this.EditorTxtBox.Multiline = true;
            this.EditorTxtBox.Name = "EditorTxtBox";
            this.EditorTxtBox.Size = new System.Drawing.Size(340, 60);
            this.EditorTxtBox.TabIndex = 2;
            // 
            // EditorBtn
            // 
            this.EditorBtn.Location = new System.Drawing.Point(347, 51);
            this.EditorBtn.Name = "EditorBtn";
            this.EditorBtn.Size = new System.Drawing.Size(95, 23);
            this.EditorBtn.TabIndex = 3;
            this.EditorBtn.Text = "edit";
            this.EditorBtn.UseVisualStyleBackColor = true;
            this.EditorBtn.Click += new System.EventHandler(this.EditorBtn_Click);
            // 
            // HexEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.EditorBtn);
            this.Controls.Add(this.EditorTxtBox);
            this.Controls.Add(this.InputLbl);
            this.Name = "HexEditor";
            this.Size = new System.Drawing.Size(447, 122);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label InputLbl;
        private System.Windows.Forms.TextBox EditorTxtBox;
        private System.Windows.Forms.Button EditorBtn;
    }
}
