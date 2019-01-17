namespace ColorSorting
{
    partial class ColorSortingForm
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
            this.ObjectsField = new System.Windows.Forms.TextBox();
            this.SortButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.CleanObjectsField = new System.Windows.Forms.Button();
            this.ResultBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.AddGreenButton = new System.Windows.Forms.Button();
            this.AddBlueButton = new System.Windows.Forms.Button();
            this.AddRedButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.FirstObfectColor = new System.Windows.Forms.ComboBox();
            this.SecondObjectColor = new System.Windows.Forms.ComboBox();
            this.ThirdObjectColor = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // ObjectsField
            // 
            this.ObjectsField.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ObjectsField.Location = new System.Drawing.Point(14, 56);
            this.ObjectsField.Name = "ObjectsField";
            this.ObjectsField.Size = new System.Drawing.Size(379, 26);
            this.ObjectsField.TabIndex = 0;
            this.ObjectsField.Text = "ССЗСКЗЗЗККСЗССКЗ";
            this.ObjectsField.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ObjectsField_KeyPress);
            // 
            // SortButton
            // 
            this.SortButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SortButton.Location = new System.Drawing.Point(17, 339);
            this.SortButton.Name = "SortButton";
            this.SortButton.Size = new System.Drawing.Size(107, 23);
            this.SortButton.TabIndex = 4;
            this.SortButton.Text = "Сортировка";
            this.SortButton.UseVisualStyleBackColor = true;
            this.SortButton.Click += new System.EventHandler(this.SortButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ExitButton.Location = new System.Drawing.Point(375, 339);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(75, 23);
            this.ExitButton.TabIndex = 5;
            this.ExitButton.Text = "Выход";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(10, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(268, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Введите набор объектов (К, З, С):";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(11, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(369, 32);
            this.label2.TabIndex = 7;
            this.label2.Text = "Выбирете отношение порядка цветов\r\n(где: З - Зелёный цвет; С - Синий цвет; К - Кр" +
    "асный цвет)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(60, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "<";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(136, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "<";
            // 
            // CleanObjectsField
            // 
            this.CleanObjectsField.Location = new System.Drawing.Point(268, 88);
            this.CleanObjectsField.Name = "CleanObjectsField";
            this.CleanObjectsField.Size = new System.Drawing.Size(125, 30);
            this.CleanObjectsField.TabIndex = 11;
            this.CleanObjectsField.Text = "Отчистить поле";
            this.CleanObjectsField.UseVisualStyleBackColor = true;
            this.CleanObjectsField.Click += new System.EventHandler(this.CleanObjectsField_Click);
            // 
            // ResultBox
            // 
            this.ResultBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ResultBox.Location = new System.Drawing.Point(31, 294);
            this.ResultBox.Name = "ResultBox";
            this.ResultBox.Size = new System.Drawing.Size(379, 26);
            this.ResultBox.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(10, 93);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(147, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "Добавить объект:";
            // 
            // AddGreenButton
            // 
            this.AddGreenButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddGreenButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.AddGreenButton.Location = new System.Drawing.Point(160, 88);
            this.AddGreenButton.Name = "AddGreenButton";
            this.AddGreenButton.Size = new System.Drawing.Size(30, 30);
            this.AddGreenButton.TabIndex = 14;
            this.AddGreenButton.Text = "З";
            this.AddGreenButton.UseVisualStyleBackColor = true;
            this.AddGreenButton.Click += new System.EventHandler(this.AddGreenButton_Click);
            // 
            // AddBlueButton
            // 
            this.AddBlueButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddBlueButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.AddBlueButton.Location = new System.Drawing.Point(196, 88);
            this.AddBlueButton.Name = "AddBlueButton";
            this.AddBlueButton.Size = new System.Drawing.Size(30, 30);
            this.AddBlueButton.TabIndex = 15;
            this.AddBlueButton.Text = "С";
            this.AddBlueButton.UseVisualStyleBackColor = true;
            this.AddBlueButton.Click += new System.EventHandler(this.AddBlueButton_Click);
            // 
            // AddRedButton
            // 
            this.AddRedButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddRedButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.AddRedButton.Location = new System.Drawing.Point(232, 88);
            this.AddRedButton.Name = "AddRedButton";
            this.AddRedButton.Size = new System.Drawing.Size(30, 30);
            this.AddRedButton.TabIndex = 16;
            this.AddRedButton.Text = "К";
            this.AddRedButton.UseVisualStyleBackColor = true;
            this.AddRedButton.Click += new System.EventHandler(this.AddRedButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(13, 269);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 20);
            this.label5.TabIndex = 17;
            this.label5.Text = "Результат:";
            // 
            // FirstObfectColor
            // 
            this.FirstObfectColor.DisplayMember = "1";
            this.FirstObfectColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FirstObfectColor.FormattingEnabled = true;
            this.FirstObfectColor.Items.AddRange(new object[] {
            "З",
            "С",
            "К"});
            this.FirstObfectColor.Location = new System.Drawing.Point(14, 65);
            this.FirstObfectColor.Name = "FirstObfectColor";
            this.FirstObfectColor.Size = new System.Drawing.Size(40, 28);
            this.FirstObfectColor.TabIndex = 18;
            // 
            // SecondObjectColor
            // 
            this.SecondObjectColor.DisplayMember = "1";
            this.SecondObjectColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SecondObjectColor.FormattingEnabled = true;
            this.SecondObjectColor.Items.AddRange(new object[] {
            "З",
            "С",
            "К"});
            this.SecondObjectColor.Location = new System.Drawing.Point(88, 65);
            this.SecondObjectColor.Name = "SecondObjectColor";
            this.SecondObjectColor.Size = new System.Drawing.Size(40, 28);
            this.SecondObjectColor.TabIndex = 19;
            // 
            // ThirdObjectColor
            // 
            this.ThirdObjectColor.DisplayMember = "1";
            this.ThirdObjectColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ThirdObjectColor.FormattingEnabled = true;
            this.ThirdObjectColor.Items.AddRange(new object[] {
            "З",
            "С",
            "К"});
            this.ThirdObjectColor.Location = new System.Drawing.Point(162, 65);
            this.ThirdObjectColor.Name = "ThirdObjectColor";
            this.ThirdObjectColor.Size = new System.Drawing.Size(40, 28);
            this.ThirdObjectColor.TabIndex = 20;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.ObjectsField);
            this.groupBox1.Controls.Add(this.CleanObjectsField);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.AddGreenButton);
            this.groupBox1.Controls.Add(this.AddRedButton);
            this.groupBox1.Controls.Add(this.AddBlueButton);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(17, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(433, 133);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Управление набором объектов";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.ThirdObjectColor);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.SecondObjectColor);
            this.groupBox2.Controls.Add(this.FirstObfectColor);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.Location = new System.Drawing.Point(17, 152);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(433, 111);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Управление отношениями между объектами";
            // 
            // ColorSortingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 374);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ResultBox);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.SortButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ColorSortingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Программа сортировки объектов";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ObjectsField;
        private System.Windows.Forms.Button SortButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button CleanObjectsField;
        private System.Windows.Forms.TextBox ResultBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button AddGreenButton;
        private System.Windows.Forms.Button AddBlueButton;
        private System.Windows.Forms.Button AddRedButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox FirstObfectColor;
        private System.Windows.Forms.ComboBox SecondObjectColor;
        private System.Windows.Forms.ComboBox ThirdObjectColor;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

