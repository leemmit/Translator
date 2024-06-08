
namespace translate
{
    partial class Mainform
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

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.tb_input = new System.Windows.Forms.TextBox();
            this.btn_translate = new System.Windows.Forms.Button();
            this.tb_output = new System.Windows.Forms.TextBox();
            this.cb_1 = new System.Windows.Forms.ComboBox();
            this.cb_2 = new System.Windows.Forms.ComboBox();
            this.btn_addWord = new System.Windows.Forms.Button();
            this.btn_addDictionary = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_changeLang = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tb_input
            // 
            this.tb_input.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_input.Location = new System.Drawing.Point(35, 134);
            this.tb_input.Name = "tb_input";
            this.tb_input.Size = new System.Drawing.Size(229, 31);
            this.tb_input.TabIndex = 0;
            this.tb_input.TextChanged += new System.EventHandler(this.tb_input_TextChanged);
            this.tb_input.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_input_KeyPress);
            // 
            // btn_translate
            // 
            this.btn_translate.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_translate.Location = new System.Drawing.Point(249, 184);
            this.btn_translate.Name = "btn_translate";
            this.btn_translate.Size = new System.Drawing.Size(93, 41);
            this.btn_translate.TabIndex = 2;
            this.btn_translate.Text = "Перевести";
            this.btn_translate.UseVisualStyleBackColor = true;
            this.btn_translate.Click += new System.EventHandler(this.btn_translate_Click);
            // 
            // tb_output
            // 
            this.tb_output.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_output.Location = new System.Drawing.Point(334, 134);
            this.tb_output.Name = "tb_output";
            this.tb_output.Size = new System.Drawing.Size(233, 31);
            this.tb_output.TabIndex = 6;
            this.tb_output.TextChanged += new System.EventHandler(this.tb_output_TextChanged);
            // 
            // cb_1
            // 
            this.cb_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cb_1.FormattingEnabled = true;
            this.cb_1.Location = new System.Drawing.Point(35, 83);
            this.cb_1.Name = "cb_1";
            this.cb_1.Size = new System.Drawing.Size(125, 28);
            this.cb_1.TabIndex = 8;
            this.cb_1.SelectedIndexChanged += new System.EventHandler(this.cb_1_SelectedIndexChanged);
            // 
            // cb_2
            // 
            this.cb_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cb_2.FormattingEnabled = true;
            this.cb_2.Location = new System.Drawing.Point(442, 83);
            this.cb_2.Name = "cb_2";
            this.cb_2.Size = new System.Drawing.Size(125, 28);
            this.cb_2.TabIndex = 12;
            // 
            // btn_addWord
            // 
            this.btn_addWord.Font = new System.Drawing.Font("Calibri", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btn_addWord.Location = new System.Drawing.Point(411, 237);
            this.btn_addWord.Name = "btn_addWord";
            this.btn_addWord.Size = new System.Drawing.Size(155, 40);
            this.btn_addWord.TabIndex = 13;
            this.btn_addWord.Text = "Добавить слово";
            this.btn_addWord.UseVisualStyleBackColor = true;
            this.btn_addWord.Click += new System.EventHandler(this.btn_addWord_Click);
            // 
            // btn_addDictionary
            // 
            this.btn_addDictionary.Font = new System.Drawing.Font("Calibri", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btn_addDictionary.Location = new System.Drawing.Point(35, 237);
            this.btn_addDictionary.Name = "btn_addDictionary";
            this.btn_addDictionary.Size = new System.Drawing.Size(155, 40);
            this.btn_addDictionary.TabIndex = 14;
            this.btn_addDictionary.Text = "Добавить словарь";
            this.btn_addDictionary.UseVisualStyleBackColor = true;
            this.btn_addDictionary.Click += new System.EventHandler(this.btn_addDictionary_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label5.Location = new System.Drawing.Point(229, 13);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(147, 30);
            this.label5.TabIndex = 16;
            this.label5.Text = "Переводчик";
            // 
            // btn_changeLang
            // 
            this.btn_changeLang.Font = new System.Drawing.Font("Calibri", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_changeLang.Image = global::perevodchik.Properties.Resources.icons8_change_24;
            this.btn_changeLang.Location = new System.Drawing.Point(273, 78);
            this.btn_changeLang.Name = "btn_changeLang";
            this.btn_changeLang.Size = new System.Drawing.Size(54, 33);
            this.btn_changeLang.TabIndex = 17;
            this.btn_changeLang.UseVisualStyleBackColor = true;
            this.btn_changeLang.Click += new System.EventHandler(this.btn_changeLang_Click);
            // 
            // Mainform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 301);
            this.Controls.Add(this.btn_changeLang);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_addDictionary);
            this.Controls.Add(this.btn_addWord);
            this.Controls.Add(this.cb_2);
            this.Controls.Add(this.cb_1);
            this.Controls.Add(this.tb_output);
            this.Controls.Add(this.btn_translate);
            this.Controls.Add(this.tb_input);
            this.Name = "Mainform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Переводчик";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_input;
        private System.Windows.Forms.Button btn_translate;
        private System.Windows.Forms.TextBox tb_output;
        private System.Windows.Forms.ComboBox cb_1;
        private System.Windows.Forms.ComboBox cb_2;
        private System.Windows.Forms.Button btn_addWord;
        private System.Windows.Forms.Button btn_addDictionary;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_changeLang;
    }
}

