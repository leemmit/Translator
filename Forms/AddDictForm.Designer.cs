
namespace translate
{
    partial class AddDictForm
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
            this.empty_dict = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.JSON_dict = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // empty_dict
            // 
            this.empty_dict.Font = new System.Drawing.Font("Calibri", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.empty_dict.Location = new System.Drawing.Point(23, 130);
            this.empty_dict.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.empty_dict.Name = "empty_dict";
            this.empty_dict.Size = new System.Drawing.Size(266, 69);
            this.empty_dict.TabIndex = 0;
            this.empty_dict.Text = "Пустой словарь";
            this.empty_dict.UseVisualStyleBackColor = true;
            this.empty_dict.Click += new System.EventHandler(this.empty_dict_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(39, 37);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(565, 60);
            this.label1.TabIndex = 2;
            this.label1.Text = "Что вы хотите добавить?";
            // 
            // JSON_dict
            // 
            this.JSON_dict.Font = new System.Drawing.Font("Calibri", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.JSON_dict.Location = new System.Drawing.Point(356, 130);
            this.JSON_dict.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.JSON_dict.Name = "JSON_dict";
            this.JSON_dict.Size = new System.Drawing.Size(266, 69);
            this.JSON_dict.TabIndex = 3;
            this.JSON_dict.Text = "JSON-файл";
            this.JSON_dict.UseVisualStyleBackColor = true;
            this.JSON_dict.Click += new System.EventHandler(this.JSON_dict_Click);
            // 
            // AddDictForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 216);
            this.Controls.Add(this.JSON_dict);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.empty_dict);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "AddDictForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавление нового словаря";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button empty_dict;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button JSON_dict;
    }
}