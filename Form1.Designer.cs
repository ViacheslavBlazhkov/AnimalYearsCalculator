
namespace AnimalYearsCalculator
{
    partial class Form1
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
            this.textBoxHY = new System.Windows.Forms.TextBox();
            this.pictureBoxAnimals = new System.Windows.Forms.PictureBox();
            this.labelHY = new System.Windows.Forms.Label();
            this.groupBoxAnimals = new System.Windows.Forms.GroupBox();
            this.radioButtonTurtle = new System.Windows.Forms.RadioButton();
            this.radioButtonRabbit = new System.Windows.Forms.RadioButton();
            this.radioButtonParrot = new System.Windows.Forms.RadioButton();
            this.radioButtonHamster = new System.Windows.Forms.RadioButton();
            this.radioButtonDog = new System.Windows.Forms.RadioButton();
            this.radioButtonCat = new System.Windows.Forms.RadioButton();
            this.labelAY = new System.Windows.Forms.Label();
            this.textBoxAY = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAnimals)).BeginInit();
            this.groupBoxAnimals.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxHY
            // 
            this.textBoxHY.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxHY.Location = new System.Drawing.Point(166, 13);
            this.textBoxHY.Name = "textBoxHY";
            this.textBoxHY.Size = new System.Drawing.Size(83, 26);
            this.textBoxHY.TabIndex = 0;
            // 
            // pictureBoxAnimals
            // 
            this.pictureBoxAnimals.BackColor = System.Drawing.Color.White;
            this.pictureBoxAnimals.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxAnimals.Location = new System.Drawing.Point(270, 12);
            this.pictureBoxAnimals.Name = "pictureBoxAnimals";
            this.pictureBoxAnimals.Size = new System.Drawing.Size(320, 320);
            this.pictureBoxAnimals.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxAnimals.TabIndex = 1;
            this.pictureBoxAnimals.TabStop = false;
            // 
            // labelHY
            // 
            this.labelHY.AutoSize = true;
            this.labelHY.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelHY.ForeColor = System.Drawing.Color.White;
            this.labelHY.Location = new System.Drawing.Point(12, 12);
            this.labelHY.Name = "labelHY";
            this.labelHY.Size = new System.Drawing.Size(131, 25);
            this.labelHY.TabIndex = 2;
            this.labelHY.Text = "Human Years";
            // 
            // groupBoxAnimals
            // 
            this.groupBoxAnimals.Controls.Add(this.radioButtonTurtle);
            this.groupBoxAnimals.Controls.Add(this.radioButtonRabbit);
            this.groupBoxAnimals.Controls.Add(this.radioButtonParrot);
            this.groupBoxAnimals.Controls.Add(this.radioButtonHamster);
            this.groupBoxAnimals.Controls.Add(this.radioButtonDog);
            this.groupBoxAnimals.Controls.Add(this.radioButtonCat);
            this.groupBoxAnimals.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxAnimals.ForeColor = System.Drawing.Color.White;
            this.groupBoxAnimals.Location = new System.Drawing.Point(17, 48);
            this.groupBoxAnimals.Name = "groupBoxAnimals";
            this.groupBoxAnimals.Size = new System.Drawing.Size(232, 228);
            this.groupBoxAnimals.TabIndex = 3;
            this.groupBoxAnimals.TabStop = false;
            this.groupBoxAnimals.Text = "Animals";
            // 
            // radioButtonTurtle
            // 
            this.radioButtonTurtle.AutoSize = true;
            this.radioButtonTurtle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButtonTurtle.Location = new System.Drawing.Point(6, 187);
            this.radioButtonTurtle.Name = "radioButtonTurtle";
            this.radioButtonTurtle.Size = new System.Drawing.Size(73, 24);
            this.radioButtonTurtle.TabIndex = 5;
            this.radioButtonTurtle.TabStop = true;
            this.radioButtonTurtle.Text = "Turtle";
            this.radioButtonTurtle.UseVisualStyleBackColor = true;
            this.radioButtonTurtle.CheckedChanged += new System.EventHandler(this.radioButtonTurtle_CheckedChanged);
            // 
            // radioButtonRabbit
            // 
            this.radioButtonRabbit.AutoSize = true;
            this.radioButtonRabbit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButtonRabbit.Location = new System.Drawing.Point(6, 157);
            this.radioButtonRabbit.Name = "radioButtonRabbit";
            this.radioButtonRabbit.Size = new System.Drawing.Size(78, 24);
            this.radioButtonRabbit.TabIndex = 4;
            this.radioButtonRabbit.TabStop = true;
            this.radioButtonRabbit.Text = "Rabbit";
            this.radioButtonRabbit.UseVisualStyleBackColor = true;
            this.radioButtonRabbit.CheckedChanged += new System.EventHandler(this.radioButtonRabbit_CheckedChanged);
            // 
            // radioButtonParrot
            // 
            this.radioButtonParrot.AutoSize = true;
            this.radioButtonParrot.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButtonParrot.Location = new System.Drawing.Point(6, 127);
            this.radioButtonParrot.Name = "radioButtonParrot";
            this.radioButtonParrot.Size = new System.Drawing.Size(76, 24);
            this.radioButtonParrot.TabIndex = 3;
            this.radioButtonParrot.TabStop = true;
            this.radioButtonParrot.Text = "Parrot";
            this.radioButtonParrot.UseVisualStyleBackColor = true;
            this.radioButtonParrot.CheckedChanged += new System.EventHandler(this.radioButtonParrot_CheckedChanged);
            // 
            // radioButtonHamster
            // 
            this.radioButtonHamster.AutoSize = true;
            this.radioButtonHamster.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButtonHamster.Location = new System.Drawing.Point(6, 97);
            this.radioButtonHamster.Name = "radioButtonHamster";
            this.radioButtonHamster.Size = new System.Drawing.Size(95, 24);
            this.radioButtonHamster.TabIndex = 2;
            this.radioButtonHamster.TabStop = true;
            this.radioButtonHamster.Text = "Hamster";
            this.radioButtonHamster.UseVisualStyleBackColor = true;
            this.radioButtonHamster.CheckedChanged += new System.EventHandler(this.radioButtonHamster_CheckedChanged);
            // 
            // radioButtonDog
            // 
            this.radioButtonDog.AutoSize = true;
            this.radioButtonDog.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButtonDog.Location = new System.Drawing.Point(6, 67);
            this.radioButtonDog.Name = "radioButtonDog";
            this.radioButtonDog.Size = new System.Drawing.Size(61, 24);
            this.radioButtonDog.TabIndex = 1;
            this.radioButtonDog.TabStop = true;
            this.radioButtonDog.Text = "Dog";
            this.radioButtonDog.UseVisualStyleBackColor = true;
            this.radioButtonDog.CheckedChanged += new System.EventHandler(this.radioButtonDog_CheckedChanged);
            // 
            // radioButtonCat
            // 
            this.radioButtonCat.AutoSize = true;
            this.radioButtonCat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButtonCat.Location = new System.Drawing.Point(6, 37);
            this.radioButtonCat.Name = "radioButtonCat";
            this.radioButtonCat.Size = new System.Drawing.Size(56, 24);
            this.radioButtonCat.TabIndex = 0;
            this.radioButtonCat.TabStop = true;
            this.radioButtonCat.Text = "Cat";
            this.radioButtonCat.UseVisualStyleBackColor = true;
            this.radioButtonCat.CheckedChanged += new System.EventHandler(this.radioButtonCat_CheckedChanged);
            // 
            // labelAY
            // 
            this.labelAY.AutoSize = true;
            this.labelAY.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAY.ForeColor = System.Drawing.Color.White;
            this.labelAY.Location = new System.Drawing.Point(12, 281);
            this.labelAY.Name = "labelAY";
            this.labelAY.Size = new System.Drawing.Size(128, 25);
            this.labelAY.TabIndex = 5;
            this.labelAY.Text = "Animal Years";
            // 
            // textBoxAY
            // 
            this.textBoxAY.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxAY.Location = new System.Drawing.Point(18, 309);
            this.textBoxAY.Name = "textBoxAY";
            this.textBoxAY.Size = new System.Drawing.Size(231, 26);
            this.textBoxAY.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Purple;
            this.ClientSize = new System.Drawing.Size(606, 348);
            this.Controls.Add(this.labelAY);
            this.Controls.Add(this.textBoxAY);
            this.Controls.Add(this.groupBoxAnimals);
            this.Controls.Add(this.labelHY);
            this.Controls.Add(this.pictureBoxAnimals);
            this.Controls.Add(this.textBoxHY);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAnimals)).EndInit();
            this.groupBoxAnimals.ResumeLayout(false);
            this.groupBoxAnimals.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxHY;
        private System.Windows.Forms.PictureBox pictureBoxAnimals;
        private System.Windows.Forms.Label labelHY;
        private System.Windows.Forms.GroupBox groupBoxAnimals;
        private System.Windows.Forms.RadioButton radioButtonTurtle;
        private System.Windows.Forms.RadioButton radioButtonRabbit;
        private System.Windows.Forms.RadioButton radioButtonParrot;
        private System.Windows.Forms.RadioButton radioButtonHamster;
        private System.Windows.Forms.RadioButton radioButtonDog;
        private System.Windows.Forms.RadioButton radioButtonCat;
        private System.Windows.Forms.Label labelAY;
        private System.Windows.Forms.TextBox textBoxAY;
    }
}

