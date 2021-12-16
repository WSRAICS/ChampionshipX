
namespace WorldSkillsX
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.canvas = new System.Windows.Forms.PictureBox();
            this.RenderingTimer = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.coordsLabel = new System.Windows.Forms.Label();
            this.addObjBtn = new System.Windows.Forms.Button();
            this.toolsBox = new System.Windows.Forms.GroupBox();
            this.rsToolBtn = new System.Windows.Forms.Button();
            this.pedToolBtn = new System.Windows.Forms.Button();
            this.plToolBtn = new System.Windows.Forms.Button();
            this.tlToolBtn = new System.Windows.Forms.Button();
            this.remObjBtn = new System.Windows.Forms.Button();
            this.pedSetBox = new System.Windows.Forms.GroupBox();
            this.pedTimerMinusBtn = new System.Windows.Forms.Button();
            this.pedTimerPlusBtn = new System.Windows.Forms.Button();
            this.pedTimerLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rsSetBox = new System.Windows.Forms.GroupBox();
            this.rsVagonRadio = new System.Windows.Forms.RadioButton();
            this.rsHeavyRadio = new System.Windows.Forms.RadioButton();
            this.rsAllRadio = new System.Windows.Forms.RadioButton();
            this.tlTimeModeBtn = new System.Windows.Forms.Button();
            this.tlVehicleModeBtn = new System.Windows.Forms.Button();
            this.commonTlSetBox = new System.Windows.Forms.GroupBox();
            this.currentCommonTlSetLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tlSetBox = new System.Windows.Forms.GroupBox();
            this.setTlStandartMode = new System.Windows.Forms.Button();
            this.setTlRedBtn = new System.Windows.Forms.Button();
            this.setTlGreenBtn = new System.Windows.Forms.Button();
            this.testsBox = new System.Windows.Forms.GroupBox();
            this.testRandBtn = new System.Windows.Forms.Button();
            this.testPhBtn = new System.Windows.Forms.Button();
            this.carMoveTimer = new System.Windows.Forms.Timer(this.components);
            this.plchldrtstCarSpawnTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.canvas)).BeginInit();
            this.toolsBox.SuspendLayout();
            this.pedSetBox.SuspendLayout();
            this.rsSetBox.SuspendLayout();
            this.commonTlSetBox.SuspendLayout();
            this.tlSetBox.SuspendLayout();
            this.testsBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // canvas
            // 
            this.canvas.Location = new System.Drawing.Point(3, 3);
            this.canvas.Name = "canvas";
            this.canvas.Size = new System.Drawing.Size(701, 701);
            this.canvas.TabIndex = 0;
            this.canvas.TabStop = false;
            this.canvas.Paint += new System.Windows.Forms.PaintEventHandler(this.canvas_Paint);
            this.canvas.MouseClick += new System.Windows.Forms.MouseEventHandler(this.canvas_MouseClick);
            this.canvas.MouseMove += new System.Windows.Forms.MouseEventHandler(this.canvas_MouseMove);
            // 
            // RenderingTimer
            // 
            this.RenderingTimer.Enabled = true;
            this.RenderingTimer.Interval = 20;
            this.RenderingTimer.Tick += new System.EventHandler(this.RenderingTimer_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(710, 684);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Координаты: ";
            // 
            // coordsLabel
            // 
            this.coordsLabel.AutoSize = true;
            this.coordsLabel.Location = new System.Drawing.Point(791, 684);
            this.coordsLabel.Name = "coordsLabel";
            this.coordsLabel.Size = new System.Drawing.Size(31, 13);
            this.coordsLabel.TabIndex = 2;
            this.coordsLabel.Text = "{x; y}";
            // 
            // addObjBtn
            // 
            this.addObjBtn.Location = new System.Drawing.Point(713, 3);
            this.addObjBtn.Name = "addObjBtn";
            this.addObjBtn.Size = new System.Drawing.Size(123, 23);
            this.addObjBtn.TabIndex = 3;
            this.addObjBtn.Text = "Добавить объект";
            this.addObjBtn.UseVisualStyleBackColor = true;
            this.addObjBtn.Click += new System.EventHandler(this.addObjBtn_Click);
            // 
            // toolsBox
            // 
            this.toolsBox.Controls.Add(this.rsToolBtn);
            this.toolsBox.Controls.Add(this.pedToolBtn);
            this.toolsBox.Controls.Add(this.plToolBtn);
            this.toolsBox.Controls.Add(this.tlToolBtn);
            this.toolsBox.Location = new System.Drawing.Point(713, 32);
            this.toolsBox.Name = "toolsBox";
            this.toolsBox.Size = new System.Drawing.Size(224, 65);
            this.toolsBox.TabIndex = 4;
            this.toolsBox.TabStop = false;
            this.toolsBox.Text = "Выбор объекта к добавлению";
            this.toolsBox.Visible = false;
            // 
            // rsToolBtn
            // 
            this.rsToolBtn.Image = global::WorldSkillsX.Properties.Resources.Block;
            this.rsToolBtn.Location = new System.Drawing.Point(165, 16);
            this.rsToolBtn.Name = "rsToolBtn";
            this.rsToolBtn.Size = new System.Drawing.Size(43, 43);
            this.rsToolBtn.TabIndex = 3;
            this.rsToolBtn.UseVisualStyleBackColor = true;
            this.rsToolBtn.Click += new System.EventHandler(this.rsToolBtn_Click);
            // 
            // pedToolBtn
            // 
            this.pedToolBtn.Image = global::WorldSkillsX.Properties.Resources.Pedestrain;
            this.pedToolBtn.Location = new System.Drawing.Point(116, 16);
            this.pedToolBtn.Name = "pedToolBtn";
            this.pedToolBtn.Size = new System.Drawing.Size(43, 43);
            this.pedToolBtn.TabIndex = 2;
            this.pedToolBtn.UseVisualStyleBackColor = true;
            this.pedToolBtn.Click += new System.EventHandler(this.pedToolBtn_Click);
            // 
            // plToolBtn
            // 
            this.plToolBtn.Image = global::WorldSkillsX.Properties.Resources.Zhorizontal1;
            this.plToolBtn.Location = new System.Drawing.Point(67, 16);
            this.plToolBtn.Name = "plToolBtn";
            this.plToolBtn.Size = new System.Drawing.Size(43, 43);
            this.plToolBtn.TabIndex = 1;
            this.plToolBtn.UseVisualStyleBackColor = true;
            this.plToolBtn.Click += new System.EventHandler(this.plToolBtn_Click);
            // 
            // tlToolBtn
            // 
            this.tlToolBtn.Image = global::WorldSkillsX.Properties.Resources.TLgreen1;
            this.tlToolBtn.Location = new System.Drawing.Point(18, 16);
            this.tlToolBtn.Name = "tlToolBtn";
            this.tlToolBtn.Size = new System.Drawing.Size(43, 43);
            this.tlToolBtn.TabIndex = 0;
            this.tlToolBtn.UseVisualStyleBackColor = true;
            this.tlToolBtn.Click += new System.EventHandler(this.tlToolBtn_Click);
            // 
            // remObjBtn
            // 
            this.remObjBtn.Enabled = false;
            this.remObjBtn.Location = new System.Drawing.Point(842, 3);
            this.remObjBtn.Name = "remObjBtn";
            this.remObjBtn.Size = new System.Drawing.Size(123, 23);
            this.remObjBtn.TabIndex = 5;
            this.remObjBtn.Text = "Удалить объект";
            this.remObjBtn.UseVisualStyleBackColor = true;
            this.remObjBtn.Click += new System.EventHandler(this.remObjBtn_Click);
            // 
            // pedSetBox
            // 
            this.pedSetBox.Controls.Add(this.pedTimerMinusBtn);
            this.pedSetBox.Controls.Add(this.pedTimerPlusBtn);
            this.pedSetBox.Controls.Add(this.pedTimerLabel);
            this.pedSetBox.Controls.Add(this.label2);
            this.pedSetBox.Location = new System.Drawing.Point(713, 103);
            this.pedSetBox.Name = "pedSetBox";
            this.pedSetBox.Size = new System.Drawing.Size(230, 70);
            this.pedSetBox.TabIndex = 6;
            this.pedSetBox.TabStop = false;
            this.pedSetBox.Text = "Настройки пешехода";
            this.pedSetBox.Visible = false;
            // 
            // pedTimerMinusBtn
            // 
            this.pedTimerMinusBtn.Location = new System.Drawing.Point(51, 37);
            this.pedTimerMinusBtn.Name = "pedTimerMinusBtn";
            this.pedTimerMinusBtn.Size = new System.Drawing.Size(60, 23);
            this.pedTimerMinusBtn.TabIndex = 3;
            this.pedTimerMinusBtn.Text = "-1 сек.";
            this.pedTimerMinusBtn.UseVisualStyleBackColor = true;
            this.pedTimerMinusBtn.Click += new System.EventHandler(this.pedTimerMinusBtn_Click);
            // 
            // pedTimerPlusBtn
            // 
            this.pedTimerPlusBtn.Location = new System.Drawing.Point(118, 37);
            this.pedTimerPlusBtn.Name = "pedTimerPlusBtn";
            this.pedTimerPlusBtn.Size = new System.Drawing.Size(60, 23);
            this.pedTimerPlusBtn.TabIndex = 2;
            this.pedTimerPlusBtn.Text = "+1 сек.";
            this.pedTimerPlusBtn.UseVisualStyleBackColor = true;
            this.pedTimerPlusBtn.Click += new System.EventHandler(this.pedTimerPlusBtn_Click);
            // 
            // pedTimerLabel
            // 
            this.pedTimerLabel.AutoSize = true;
            this.pedTimerLabel.Location = new System.Drawing.Point(124, 21);
            this.pedTimerLabel.Name = "pedTimerLabel";
            this.pedTimerLabel.Size = new System.Drawing.Size(13, 13);
            this.pedTimerLabel.TabIndex = 1;
            this.pedTimerLabel.Text = "7";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(70, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Секунды:";
            // 
            // rsSetBox
            // 
            this.rsSetBox.Controls.Add(this.rsVagonRadio);
            this.rsSetBox.Controls.Add(this.rsHeavyRadio);
            this.rsSetBox.Controls.Add(this.rsAllRadio);
            this.rsSetBox.Location = new System.Drawing.Point(713, 179);
            this.rsSetBox.Name = "rsSetBox";
            this.rsSetBox.Size = new System.Drawing.Size(230, 94);
            this.rsSetBox.TabIndex = 7;
            this.rsSetBox.TabStop = false;
            this.rsSetBox.Text = "Настройки знака";
            this.rsSetBox.Visible = false;
            // 
            // rsVagonRadio
            // 
            this.rsVagonRadio.AutoSize = true;
            this.rsVagonRadio.Location = new System.Drawing.Point(7, 66);
            this.rsVagonRadio.Name = "rsVagonRadio";
            this.rsVagonRadio.Size = new System.Drawing.Size(217, 17);
            this.rsVagonRadio.TabIndex = 2;
            this.rsVagonRadio.TabStop = true;
            this.rsVagonRadio.Text = "Движение запрещено ТС с пицепами";
            this.rsVagonRadio.UseVisualStyleBackColor = true;
            this.rsVagonRadio.CheckedChanged += new System.EventHandler(this.rsVagonRadio_CheckedChanged);
            // 
            // rsHeavyRadio
            // 
            this.rsHeavyRadio.AutoSize = true;
            this.rsHeavyRadio.Location = new System.Drawing.Point(7, 43);
            this.rsHeavyRadio.Name = "rsHeavyRadio";
            this.rsHeavyRadio.Size = new System.Drawing.Size(201, 17);
            this.rsHeavyRadio.TabIndex = 1;
            this.rsHeavyRadio.TabStop = true;
            this.rsHeavyRadio.Text = "Движение запрещено грузовикам";
            this.rsHeavyRadio.UseVisualStyleBackColor = true;
            this.rsHeavyRadio.CheckedChanged += new System.EventHandler(this.rsHeavyRadio_CheckedChanged);
            // 
            // rsAllRadio
            // 
            this.rsAllRadio.AutoSize = true;
            this.rsAllRadio.Location = new System.Drawing.Point(7, 20);
            this.rsAllRadio.Name = "rsAllRadio";
            this.rsAllRadio.Size = new System.Drawing.Size(167, 17);
            this.rsAllRadio.TabIndex = 0;
            this.rsAllRadio.TabStop = true;
            this.rsAllRadio.Text = "Движение запрещено всем";
            this.rsAllRadio.UseVisualStyleBackColor = true;
            this.rsAllRadio.CheckedChanged += new System.EventHandler(this.rsAllRadio_CheckedChanged);
            // 
            // tlTimeModeBtn
            // 
            this.tlTimeModeBtn.Location = new System.Drawing.Point(35, 45);
            this.tlTimeModeBtn.Name = "tlTimeModeBtn";
            this.tlTimeModeBtn.Size = new System.Drawing.Size(159, 23);
            this.tlTimeModeBtn.TabIndex = 8;
            this.tlTimeModeBtn.Text = "Режим по времени";
            this.tlTimeModeBtn.UseVisualStyleBackColor = true;
            this.tlTimeModeBtn.Click += new System.EventHandler(this.tlTimeModeBtn_Click);
            // 
            // tlVehicleModeBtn
            // 
            this.tlVehicleModeBtn.Location = new System.Drawing.Point(35, 74);
            this.tlVehicleModeBtn.Name = "tlVehicleModeBtn";
            this.tlVehicleModeBtn.Size = new System.Drawing.Size(159, 23);
            this.tlVehicleModeBtn.TabIndex = 9;
            this.tlVehicleModeBtn.Text = "Режим по транспорту";
            this.tlVehicleModeBtn.UseVisualStyleBackColor = true;
            this.tlVehicleModeBtn.Click += new System.EventHandler(this.tlVehicleModeBtn_Click);
            // 
            // commonTlSetBox
            // 
            this.commonTlSetBox.Controls.Add(this.currentCommonTlSetLabel);
            this.commonTlSetBox.Controls.Add(this.label3);
            this.commonTlSetBox.Controls.Add(this.tlTimeModeBtn);
            this.commonTlSetBox.Controls.Add(this.tlVehicleModeBtn);
            this.commonTlSetBox.Location = new System.Drawing.Point(713, 388);
            this.commonTlSetBox.Name = "commonTlSetBox";
            this.commonTlSetBox.Size = new System.Drawing.Size(230, 116);
            this.commonTlSetBox.TabIndex = 10;
            this.commonTlSetBox.TabStop = false;
            this.commonTlSetBox.Text = "Общие настройки светофоров";
            // 
            // currentCommonTlSetLabel
            // 
            this.currentCommonTlSetLabel.AutoSize = true;
            this.currentCommonTlSetLabel.Location = new System.Drawing.Point(124, 24);
            this.currentCommonTlSetLabel.Name = "currentCommonTlSetLabel";
            this.currentCommonTlSetLabel.Size = new System.Drawing.Size(82, 13);
            this.currentCommonTlSetLabel.TabIndex = 10;
            this.currentCommonTlSetLabel.Text = "Не установлен";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Текущий режим:";
            // 
            // tlSetBox
            // 
            this.tlSetBox.Controls.Add(this.setTlStandartMode);
            this.tlSetBox.Controls.Add(this.setTlRedBtn);
            this.tlSetBox.Controls.Add(this.setTlGreenBtn);
            this.tlSetBox.Location = new System.Drawing.Point(713, 280);
            this.tlSetBox.Name = "tlSetBox";
            this.tlSetBox.Size = new System.Drawing.Size(230, 102);
            this.tlSetBox.TabIndex = 11;
            this.tlSetBox.TabStop = false;
            this.tlSetBox.Text = "Настройка светофора";
            this.tlSetBox.Visible = false;
            // 
            // setTlStandartMode
            // 
            this.setTlStandartMode.Location = new System.Drawing.Point(34, 69);
            this.setTlStandartMode.Name = "setTlStandartMode";
            this.setTlStandartMode.Size = new System.Drawing.Size(160, 23);
            this.setTlStandartMode.TabIndex = 2;
            this.setTlStandartMode.Text = "Стандартный режим";
            this.setTlStandartMode.UseVisualStyleBackColor = true;
            this.setTlStandartMode.Click += new System.EventHandler(this.setTlStandartMode_Click);
            // 
            // setTlRedBtn
            // 
            this.setTlRedBtn.BackColor = System.Drawing.Color.Red;
            this.setTlRedBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.setTlRedBtn.Location = new System.Drawing.Point(119, 19);
            this.setTlRedBtn.Name = "setTlRedBtn";
            this.setTlRedBtn.Size = new System.Drawing.Size(75, 41);
            this.setTlRedBtn.TabIndex = 1;
            this.setTlRedBtn.Text = "Красный";
            this.setTlRedBtn.UseVisualStyleBackColor = false;
            this.setTlRedBtn.Click += new System.EventHandler(this.setTlRedBtn_Click);
            // 
            // setTlGreenBtn
            // 
            this.setTlGreenBtn.BackColor = System.Drawing.Color.OliveDrab;
            this.setTlGreenBtn.Location = new System.Drawing.Point(34, 19);
            this.setTlGreenBtn.Name = "setTlGreenBtn";
            this.setTlGreenBtn.Size = new System.Drawing.Size(75, 41);
            this.setTlGreenBtn.TabIndex = 0;
            this.setTlGreenBtn.Text = "Зеленый";
            this.setTlGreenBtn.UseVisualStyleBackColor = false;
            this.setTlGreenBtn.Click += new System.EventHandler(this.setTlGreenBtn_Click);
            // 
            // testsBox
            // 
            this.testsBox.Controls.Add(this.testRandBtn);
            this.testsBox.Controls.Add(this.testPhBtn);
            this.testsBox.Location = new System.Drawing.Point(713, 510);
            this.testsBox.Name = "testsBox";
            this.testsBox.Size = new System.Drawing.Size(230, 85);
            this.testsBox.TabIndex = 12;
            this.testsBox.TabStop = false;
            this.testsBox.Text = "Тесты";
            // 
            // testRandBtn
            // 
            this.testRandBtn.Location = new System.Drawing.Point(35, 48);
            this.testRandBtn.Name = "testRandBtn";
            this.testRandBtn.Size = new System.Drawing.Size(159, 23);
            this.testRandBtn.TabIndex = 12;
            this.testRandBtn.Text = "Тест-рандом";
            this.testRandBtn.UseVisualStyleBackColor = true;
            this.testRandBtn.Click += new System.EventHandler(this.testRandBtn_Click);
            // 
            // testPhBtn
            // 
            this.testPhBtn.Location = new System.Drawing.Point(35, 19);
            this.testPhBtn.Name = "testPhBtn";
            this.testPhBtn.Size = new System.Drawing.Size(159, 23);
            this.testPhBtn.TabIndex = 11;
            this.testPhBtn.Text = "Тест-шаблон";
            this.testPhBtn.UseVisualStyleBackColor = true;
            this.testPhBtn.Click += new System.EventHandler(this.testPhBtn_Click);
            // 
            // carMoveTimer
            // 
            this.carMoveTimer.Enabled = true;
            this.carMoveTimer.Interval = 380;
            this.carMoveTimer.Tick += new System.EventHandler(this.carMoveTimer_Tick);
            // 
            // plchldrtstCarSpawnTimer
            // 
            this.plchldrtstCarSpawnTimer.Interval = 7000;
            this.plchldrtstCarSpawnTimer.Tick += new System.EventHandler(this.plchldrtstCarSpawnTimer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(970, 706);
            this.Controls.Add(this.testsBox);
            this.Controls.Add(this.tlSetBox);
            this.Controls.Add(this.commonTlSetBox);
            this.Controls.Add(this.rsSetBox);
            this.Controls.Add(this.pedSetBox);
            this.Controls.Add(this.remObjBtn);
            this.Controls.Add(this.toolsBox);
            this.Controls.Add(this.addObjBtn);
            this.Controls.Add(this.coordsLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.canvas);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "World Skills X";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.canvas)).EndInit();
            this.toolsBox.ResumeLayout(false);
            this.pedSetBox.ResumeLayout(false);
            this.pedSetBox.PerformLayout();
            this.rsSetBox.ResumeLayout(false);
            this.rsSetBox.PerformLayout();
            this.commonTlSetBox.ResumeLayout(false);
            this.commonTlSetBox.PerformLayout();
            this.tlSetBox.ResumeLayout(false);
            this.testsBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox canvas;
        private System.Windows.Forms.Timer RenderingTimer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label coordsLabel;
        private System.Windows.Forms.Button addObjBtn;
        private System.Windows.Forms.GroupBox toolsBox;
        private System.Windows.Forms.Button rsToolBtn;
        private System.Windows.Forms.Button pedToolBtn;
        private System.Windows.Forms.Button plToolBtn;
        private System.Windows.Forms.Button tlToolBtn;
        private System.Windows.Forms.Button remObjBtn;
        private System.Windows.Forms.GroupBox pedSetBox;
        private System.Windows.Forms.Button pedTimerMinusBtn;
        private System.Windows.Forms.Button pedTimerPlusBtn;
        private System.Windows.Forms.Label pedTimerLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox rsSetBox;
        private System.Windows.Forms.RadioButton rsVagonRadio;
        private System.Windows.Forms.RadioButton rsHeavyRadio;
        private System.Windows.Forms.RadioButton rsAllRadio;
        private System.Windows.Forms.Button tlTimeModeBtn;
        private System.Windows.Forms.Button tlVehicleModeBtn;
        private System.Windows.Forms.GroupBox commonTlSetBox;
        private System.Windows.Forms.Label currentCommonTlSetLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox tlSetBox;
        private System.Windows.Forms.Button setTlStandartMode;
        private System.Windows.Forms.Button setTlRedBtn;
        private System.Windows.Forms.Button setTlGreenBtn;
        private System.Windows.Forms.GroupBox testsBox;
        private System.Windows.Forms.Button testRandBtn;
        private System.Windows.Forms.Button testPhBtn;
        private System.Windows.Forms.Timer carMoveTimer;
        private System.Windows.Forms.Timer plchldrtstCarSpawnTimer;
    }
}

