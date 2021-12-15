
namespace World_Skills_X
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnKrugX = new System.Windows.Forms.Button();
            this.btnKrugGruzavik = new System.Windows.Forms.Button();
            this.btnKrugPricep = new System.Windows.Forms.Button();
            this.btnChelovek = new System.Windows.Forms.Button();
            this.btnPerehod = new System.Windows.Forms.Button();
            this.btnSvetofor = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btn = new System.Windows.Forms.Button();
            this.btnSeve = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.перекресток = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(8, 9);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(767, 644);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(793, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnKrugX
            // 
            this.btnKrugX.Location = new System.Drawing.Point(916, 399);
            this.btnKrugX.Name = "btnKrugX";
            this.btnKrugX.Size = new System.Drawing.Size(66, 66);
            this.btnKrugX.TabIndex = 2;
            this.btnKrugX.Text = "Проезд -";
            this.btnKrugX.UseVisualStyleBackColor = true;
            this.btnKrugX.Click += new System.EventHandler(this.btnKrugX_Click);
            // 
            // btnKrugGruzavik
            // 
            this.btnKrugGruzavik.Location = new System.Drawing.Point(988, 471);
            this.btnKrugGruzavik.Name = "btnKrugGruzavik";
            this.btnKrugGruzavik.Size = new System.Drawing.Size(66, 66);
            this.btnKrugGruzavik.TabIndex = 3;
            this.btnKrugGruzavik.Text = "Грузавик -";
            this.btnKrugGruzavik.UseVisualStyleBackColor = true;
            // 
            // btnKrugPricep
            // 
            this.btnKrugPricep.Location = new System.Drawing.Point(916, 471);
            this.btnKrugPricep.Name = "btnKrugPricep";
            this.btnKrugPricep.Size = new System.Drawing.Size(66, 66);
            this.btnKrugPricep.TabIndex = 4;
            this.btnKrugPricep.Text = "Прицеп -";
            this.btnKrugPricep.UseVisualStyleBackColor = true;
            // 
            // btnChelovek
            // 
            this.btnChelovek.Location = new System.Drawing.Point(844, 471);
            this.btnChelovek.Name = "btnChelovek";
            this.btnChelovek.Size = new System.Drawing.Size(66, 66);
            this.btnChelovek.TabIndex = 5;
            this.btnChelovek.Text = "пешиход";
            this.btnChelovek.UseVisualStyleBackColor = true;
            // 
            // btnPerehod
            // 
            this.btnPerehod.Location = new System.Drawing.Point(988, 399);
            this.btnPerehod.Name = "btnPerehod";
            this.btnPerehod.Size = new System.Drawing.Size(66, 66);
            this.btnPerehod.TabIndex = 6;
            this.btnPerehod.Text = "зебра";
            this.btnPerehod.UseVisualStyleBackColor = true;
            // 
            // btnSvetofor
            // 
            this.btnSvetofor.Location = new System.Drawing.Point(844, 399);
            this.btnSvetofor.Name = "btnSvetofor";
            this.btnSvetofor.Size = new System.Drawing.Size(66, 66);
            this.btnSvetofor.TabIndex = 7;
            this.btnSvetofor.Text = "Светофор";
            this.btnSvetofor.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(816, 614);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btn
            // 
            this.btn.Location = new System.Drawing.Point(1006, 614);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(75, 23);
            this.btn.TabIndex = 9;
            this.btn.Text = "button2";
            this.btn.UseVisualStyleBackColor = true;
            // 
            // btnSeve
            // 
            this.btnSeve.Location = new System.Drawing.Point(908, 614);
            this.btnSeve.Name = "btnSeve";
            this.btnSeve.Size = new System.Drawing.Size(75, 23);
            this.btnSeve.TabIndex = 10;
            this.btnSeve.Text = "Сохранить";
            this.btnSeve.UseVisualStyleBackColor = true;
            this.btnSeve.Click += new System.EventHandler(this.btnSeve_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(862, 307);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(66, 50);
            this.button2.TabIndex = 12;
            this.button2.Text = "дорога в сторону";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(862, 251);
            this.button3.Name = "button3";
            this.button3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button3.Size = new System.Drawing.Size(66, 50);
            this.button3.TabIndex = 13;
            this.button3.Text = "дорога в сторону";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // перекресток
            // 
            this.перекресток.Location = new System.Drawing.Point(1006, 274);
            this.перекресток.Name = "перекресток";
            this.перекресток.Size = new System.Drawing.Size(66, 50);
            this.перекресток.TabIndex = 14;
            this.перекресток.Text = "перекресток";
            this.перекресток.UseVisualStyleBackColor = true;
            this.перекресток.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(934, 251);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(66, 50);
            this.button6.TabIndex = 15;
            this.button6.Text = "дорога вверх";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(934, 307);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(66, 50);
            this.button8.TabIndex = 17;
            this.button8.Text = "дорога вверх";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1120, 662);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.перекресток);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnKrugGruzavik);
            this.Controls.Add(this.btnSvetofor);
            this.Controls.Add(this.btnChelovek);
            this.Controls.Add(this.btnKrugX);
            this.Controls.Add(this.btnSeve);
            this.Controls.Add(this.btnPerehod);
            this.Controls.Add(this.btnKrugPricep);
            this.Controls.Add(this.btn);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnKrugX;
        private System.Windows.Forms.Button btnKrugGruzavik;
        private System.Windows.Forms.Button btnKrugPricep;
        private System.Windows.Forms.Button btnChelovek;
        private System.Windows.Forms.Button btnPerehod;
        private System.Windows.Forms.Button btnSvetofor;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn;
        private System.Windows.Forms.Button btnSeve;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button перекресток;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button8;
    }
}

