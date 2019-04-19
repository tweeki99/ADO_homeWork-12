namespace CityPhones
{
    partial class MainForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ComboBoxCities = new System.Windows.Forms.ComboBox();
            this.TextBoxCode = new System.Windows.Forms.TextBox();
            this.MaskedTextBoxNumber = new System.Windows.Forms.MaskedTextBox();
            this.ButtonAddNumber = new System.Windows.Forms.Button();
            this.DataGridViewNumbers = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewNumbers)).BeginInit();
            this.SuspendLayout();
            // 
            // ComboBoxCities
            // 
            this.ComboBoxCities.BackColor = System.Drawing.Color.Black;
            this.ComboBoxCities.DisplayMember = "гшщ";
            this.ComboBoxCities.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxCities.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ComboBoxCities.ForeColor = System.Drawing.Color.White;
            this.ComboBoxCities.FormattingEnabled = true;
            this.ComboBoxCities.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ComboBoxCities.Location = new System.Drawing.Point(12, 12);
            this.ComboBoxCities.Name = "ComboBoxCities";
            this.ComboBoxCities.Size = new System.Drawing.Size(355, 47);
            this.ComboBoxCities.TabIndex = 9;
            this.ComboBoxCities.Tag = "";
            this.ComboBoxCities.SelectedIndexChanged += new System.EventHandler(this.ComboBoxCitiesSelectedIndexChanged);
            // 
            // TextBoxCode
            // 
            this.TextBoxCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBoxCode.Location = new System.Drawing.Point(374, 13);
            this.TextBoxCode.Name = "TextBoxCode";
            this.TextBoxCode.ReadOnly = true;
            this.TextBoxCode.Size = new System.Drawing.Size(104, 46);
            this.TextBoxCode.TabIndex = 10;
            this.TextBoxCode.Text = "XXXX";
            // 
            // MaskedTextBoxNumber
            // 
            this.MaskedTextBoxNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MaskedTextBoxNumber.Location = new System.Drawing.Point(485, 13);
            this.MaskedTextBoxNumber.Mask = "00-00-00";
            this.MaskedTextBoxNumber.Name = "MaskedTextBoxNumber";
            this.MaskedTextBoxNumber.Size = new System.Drawing.Size(144, 46);
            this.MaskedTextBoxNumber.TabIndex = 11;
            // 
            // ButtonAddNumber
            // 
            this.ButtonAddNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonAddNumber.Location = new System.Drawing.Point(374, 66);
            this.ButtonAddNumber.Name = "ButtonAddNumber";
            this.ButtonAddNumber.Size = new System.Drawing.Size(255, 92);
            this.ButtonAddNumber.TabIndex = 12;
            this.ButtonAddNumber.Text = "Добавить номер";
            this.ButtonAddNumber.UseVisualStyleBackColor = true;
            this.ButtonAddNumber.Click += new System.EventHandler(this.ButtonAddNumberClick);
            // 
            // DataGridViewNumbers
            // 
            this.DataGridViewNumbers.AllowUserToAddRows = false;
            this.DataGridViewNumbers.AllowUserToDeleteRows = false;
            this.DataGridViewNumbers.AllowUserToResizeColumns = false;
            this.DataGridViewNumbers.AllowUserToResizeRows = false;
            this.DataGridViewNumbers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridViewNumbers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGridViewNumbers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridViewNumbers.DefaultCellStyle = dataGridViewCellStyle2;
            this.DataGridViewNumbers.EnableHeadersVisualStyles = false;
            this.DataGridViewNumbers.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.DataGridViewNumbers.Location = new System.Drawing.Point(12, 65);
            this.DataGridViewNumbers.MultiSelect = false;
            this.DataGridViewNumbers.Name = "DataGridViewNumbers";
            this.DataGridViewNumbers.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Cyan;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridViewNumbers.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.DataGridViewNumbers.RowHeadersVisible = false;
            this.DataGridViewNumbers.RowTemplate.Height = 40;
            this.DataGridViewNumbers.Size = new System.Drawing.Size(355, 373);
            this.DataGridViewNumbers.TabIndex = 14;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 450);
            this.Controls.Add(this.DataGridViewNumbers);
            this.Controls.Add(this.ButtonAddNumber);
            this.Controls.Add(this.MaskedTextBoxNumber);
            this.Controls.Add(this.TextBoxCode);
            this.Controls.Add(this.ComboBoxCities);
            this.Name = "MainForm";
            this.Text = "Моя супер прога";
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewNumbers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox ComboBoxCities;
        private System.Windows.Forms.TextBox TextBoxCode;
        private System.Windows.Forms.MaskedTextBox MaskedTextBoxNumber;
        private System.Windows.Forms.Button ButtonAddNumber;
        private System.Windows.Forms.DataGridView DataGridViewNumbers;
    }
}

