namespace Calculate
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.lb_Tablo = new System.Windows.Forms.Label();
            this.btn_Nine = new System.Windows.Forms.Button();
            this.btn_Eight = new System.Windows.Forms.Button();
            this.btn_Seven = new System.Windows.Forms.Button();
            this.btn_Four = new System.Windows.Forms.Button();
            this.btn_Five = new System.Windows.Forms.Button();
            this.btn_Six = new System.Windows.Forms.Button();
            this.btn_One = new System.Windows.Forms.Button();
            this.btn_two = new System.Windows.Forms.Button();
            this.btn_Three = new System.Windows.Forms.Button();
            this.btn_Point = new System.Windows.Forms.Button();
            this.btn_Zero = new System.Windows.Forms.Button();
            this.btn_СhangeSign = new System.Windows.Forms.Button();
            this.btn_EraseLast = new System.Windows.Forms.Button();
            this.btn_Result = new System.Windows.Forms.Button();
            this.btn_Minus = new System.Windows.Forms.Button();
            this.btn_Plus = new System.Windows.Forms.Button();
            this.btn_Divide = new System.Windows.Forms.Button();
            this.btn_Increase = new System.Windows.Forms.Button();
            this.btn_Dump = new System.Windows.Forms.Button();
            this.btn_Panel = new System.Windows.Forms.Button();
            this.lb_History = new System.Windows.Forms.ListBox();
            this.btn_ClearHistory = new System.Windows.Forms.Button();
            this.btn_CosX = new System.Windows.Forms.Button();
            this.btn_SinX = new System.Windows.Forms.Button();
            this.btn_SQRT = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb_Tablo
            // 
            this.lb_Tablo.AllowDrop = true;
            this.lb_Tablo.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lb_Tablo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lb_Tablo.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb_Tablo.Location = new System.Drawing.Point(20, 22);
            this.lb_Tablo.Name = "lb_Tablo";
            this.lb_Tablo.Size = new System.Drawing.Size(290, 48);
            this.lb_Tablo.TabIndex = 0;
            this.lb_Tablo.Text = "0";
            this.lb_Tablo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lb_Tablo.DragDrop += new System.Windows.Forms.DragEventHandler(this.lb_Tablo_DragDrop);
            this.lb_Tablo.DragOver += new System.Windows.Forms.DragEventHandler(this.lb_Tablo_DragOver);
            // 
            // btn_Nine
            // 
            this.btn_Nine.Location = new System.Drawing.Point(112, 107);
            this.btn_Nine.Name = "btn_Nine";
            this.btn_Nine.Size = new System.Drawing.Size(40, 40);
            this.btn_Nine.TabIndex = 1;
            this.btn_Nine.Text = "9";
            this.btn_Nine.UseVisualStyleBackColor = true;
            this.btn_Nine.Click += new System.EventHandler(this.btn_One_Click);
            // 
            // btn_Eight
            // 
            this.btn_Eight.Location = new System.Drawing.Point(66, 107);
            this.btn_Eight.Name = "btn_Eight";
            this.btn_Eight.Size = new System.Drawing.Size(40, 40);
            this.btn_Eight.TabIndex = 2;
            this.btn_Eight.Text = "8";
            this.btn_Eight.UseVisualStyleBackColor = true;
            this.btn_Eight.Click += new System.EventHandler(this.btn_One_Click);
            // 
            // btn_Seven
            // 
            this.btn_Seven.Location = new System.Drawing.Point(20, 107);
            this.btn_Seven.Name = "btn_Seven";
            this.btn_Seven.Size = new System.Drawing.Size(40, 40);
            this.btn_Seven.TabIndex = 3;
            this.btn_Seven.Text = "7";
            this.btn_Seven.UseVisualStyleBackColor = true;
            this.btn_Seven.Click += new System.EventHandler(this.btn_One_Click);
            // 
            // btn_Four
            // 
            this.btn_Four.Location = new System.Drawing.Point(20, 153);
            this.btn_Four.Name = "btn_Four";
            this.btn_Four.Size = new System.Drawing.Size(40, 40);
            this.btn_Four.TabIndex = 6;
            this.btn_Four.Text = "4";
            this.btn_Four.UseVisualStyleBackColor = true;
            this.btn_Four.Click += new System.EventHandler(this.btn_One_Click);
            // 
            // btn_Five
            // 
            this.btn_Five.Location = new System.Drawing.Point(66, 153);
            this.btn_Five.Name = "btn_Five";
            this.btn_Five.Size = new System.Drawing.Size(40, 40);
            this.btn_Five.TabIndex = 5;
            this.btn_Five.Text = "5";
            this.btn_Five.UseVisualStyleBackColor = true;
            this.btn_Five.Click += new System.EventHandler(this.btn_One_Click);
            // 
            // btn_Six
            // 
            this.btn_Six.Location = new System.Drawing.Point(112, 153);
            this.btn_Six.Name = "btn_Six";
            this.btn_Six.Size = new System.Drawing.Size(40, 40);
            this.btn_Six.TabIndex = 4;
            this.btn_Six.Text = "6";
            this.btn_Six.UseVisualStyleBackColor = true;
            this.btn_Six.Click += new System.EventHandler(this.btn_One_Click);
            // 
            // btn_One
            // 
            this.btn_One.Location = new System.Drawing.Point(20, 199);
            this.btn_One.Name = "btn_One";
            this.btn_One.Size = new System.Drawing.Size(40, 40);
            this.btn_One.TabIndex = 9;
            this.btn_One.Text = "1";
            this.btn_One.UseVisualStyleBackColor = true;
            this.btn_One.Click += new System.EventHandler(this.btn_One_Click);
            // 
            // btn_two
            // 
            this.btn_two.Location = new System.Drawing.Point(66, 199);
            this.btn_two.Name = "btn_two";
            this.btn_two.Size = new System.Drawing.Size(40, 40);
            this.btn_two.TabIndex = 8;
            this.btn_two.Text = "2";
            this.btn_two.UseVisualStyleBackColor = true;
            this.btn_two.Click += new System.EventHandler(this.btn_One_Click);
            // 
            // btn_Three
            // 
            this.btn_Three.Location = new System.Drawing.Point(112, 199);
            this.btn_Three.Name = "btn_Three";
            this.btn_Three.Size = new System.Drawing.Size(40, 40);
            this.btn_Three.TabIndex = 7;
            this.btn_Three.Text = "3";
            this.btn_Three.UseVisualStyleBackColor = true;
            this.btn_Three.Click += new System.EventHandler(this.btn_One_Click);
            // 
            // btn_Point
            // 
            this.btn_Point.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_Point.Location = new System.Drawing.Point(20, 245);
            this.btn_Point.Name = "btn_Point";
            this.btn_Point.Size = new System.Drawing.Size(40, 40);
            this.btn_Point.TabIndex = 12;
            this.btn_Point.Text = ",";
            this.btn_Point.UseVisualStyleBackColor = true;
            this.btn_Point.Click += new System.EventHandler(this.btn_Point_Click);
            // 
            // btn_Zero
            // 
            this.btn_Zero.Location = new System.Drawing.Point(66, 245);
            this.btn_Zero.Name = "btn_Zero";
            this.btn_Zero.Size = new System.Drawing.Size(40, 40);
            this.btn_Zero.TabIndex = 11;
            this.btn_Zero.Text = "0";
            this.btn_Zero.UseVisualStyleBackColor = true;
            this.btn_Zero.Click += new System.EventHandler(this.btn_One_Click);
            // 
            // btn_СhangeSign
            // 
            this.btn_СhangeSign.Location = new System.Drawing.Point(112, 245);
            this.btn_СhangeSign.Name = "btn_СhangeSign";
            this.btn_СhangeSign.Size = new System.Drawing.Size(40, 40);
            this.btn_СhangeSign.TabIndex = 10;
            this.btn_СhangeSign.Text = "+/-";
            this.btn_СhangeSign.UseVisualStyleBackColor = true;
            this.btn_СhangeSign.Click += new System.EventHandler(this.btn_СhangeSign_Click);
            // 
            // btn_EraseLast
            // 
            this.btn_EraseLast.Location = new System.Drawing.Point(224, 199);
            this.btn_EraseLast.Name = "btn_EraseLast";
            this.btn_EraseLast.Size = new System.Drawing.Size(40, 40);
            this.btn_EraseLast.TabIndex = 16;
            this.btn_EraseLast.Text = "<--";
            this.btn_EraseLast.UseVisualStyleBackColor = true;
            this.btn_EraseLast.Click += new System.EventHandler(this.btn_EraseLast_Click);
            // 
            // btn_Result
            // 
            this.btn_Result.Location = new System.Drawing.Point(168, 245);
            this.btn_Result.Name = "btn_Result";
            this.btn_Result.Size = new System.Drawing.Size(142, 40);
            this.btn_Result.TabIndex = 15;
            this.btn_Result.Text = "=";
            this.btn_Result.UseVisualStyleBackColor = true;
            this.btn_Result.Click += new System.EventHandler(this.btn_Result_Click);
            // 
            // btn_Minus
            // 
            this.btn_Minus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_Minus.Location = new System.Drawing.Point(224, 153);
            this.btn_Minus.Name = "btn_Minus";
            this.btn_Minus.Size = new System.Drawing.Size(40, 40);
            this.btn_Minus.TabIndex = 14;
            this.btn_Minus.Text = "-";
            this.btn_Minus.UseVisualStyleBackColor = true;
            this.btn_Minus.Click += new System.EventHandler(this.btn_Plus_Click);
            // 
            // btn_Plus
            // 
            this.btn_Plus.Location = new System.Drawing.Point(224, 107);
            this.btn_Plus.Name = "btn_Plus";
            this.btn_Plus.Size = new System.Drawing.Size(40, 40);
            this.btn_Plus.TabIndex = 13;
            this.btn_Plus.Text = "+";
            this.btn_Plus.UseVisualStyleBackColor = true;
            this.btn_Plus.Click += new System.EventHandler(this.btn_Plus_Click);
            // 
            // btn_Divide
            // 
            this.btn_Divide.Location = new System.Drawing.Point(270, 153);
            this.btn_Divide.Name = "btn_Divide";
            this.btn_Divide.Size = new System.Drawing.Size(40, 40);
            this.btn_Divide.TabIndex = 18;
            this.btn_Divide.Text = "/";
            this.btn_Divide.UseVisualStyleBackColor = true;
            this.btn_Divide.Click += new System.EventHandler(this.btn_Plus_Click);
            // 
            // btn_Increase
            // 
            this.btn_Increase.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_Increase.Location = new System.Drawing.Point(270, 107);
            this.btn_Increase.Name = "btn_Increase";
            this.btn_Increase.Size = new System.Drawing.Size(40, 40);
            this.btn_Increase.TabIndex = 17;
            this.btn_Increase.Text = "*";
            this.btn_Increase.UseVisualStyleBackColor = true;
            this.btn_Increase.Click += new System.EventHandler(this.btn_Plus_Click);
            // 
            // btn_Dump
            // 
            this.btn_Dump.Location = new System.Drawing.Point(270, 199);
            this.btn_Dump.Name = "btn_Dump";
            this.btn_Dump.Size = new System.Drawing.Size(40, 40);
            this.btn_Dump.TabIndex = 21;
            this.btn_Dump.Text = "C";
            this.btn_Dump.UseVisualStyleBackColor = true;
            this.btn_Dump.Click += new System.EventHandler(this.btn_Dump_Click);
            // 
            // btn_Panel
            // 
            this.btn_Panel.Location = new System.Drawing.Point(332, 22);
            this.btn_Panel.Name = "btn_Panel";
            this.btn_Panel.Size = new System.Drawing.Size(34, 263);
            this.btn_Panel.TabIndex = 24;
            this.btn_Panel.Text = ">";
            this.btn_Panel.UseVisualStyleBackColor = true;
            this.btn_Panel.Click += new System.EventHandler(this.btn_Panel_Click);
            // 
            // lb_History
            // 
            this.lb_History.AllowDrop = true;
            this.lb_History.FormattingEnabled = true;
            this.lb_History.Location = new System.Drawing.Point(384, 22);
            this.lb_History.Name = "lb_History";
            this.lb_History.Size = new System.Drawing.Size(172, 225);
            this.lb_History.TabIndex = 25;
            this.lb_History.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lb_History_MouseDown);
            // 
            // btn_ClearHistory
            // 
            this.btn_ClearHistory.Location = new System.Drawing.Point(397, 259);
            this.btn_ClearHistory.Name = "btn_ClearHistory";
            this.btn_ClearHistory.Size = new System.Drawing.Size(144, 25);
            this.btn_ClearHistory.TabIndex = 26;
            this.btn_ClearHistory.Text = "Очистить историю";
            this.btn_ClearHistory.UseVisualStyleBackColor = true;
            this.btn_ClearHistory.Click += new System.EventHandler(this.btn_ClearHistory_Click);
            // 
            // btn_CosX
            // 
            this.btn_CosX.Location = new System.Drawing.Point(168, 153);
            this.btn_CosX.Name = "btn_CosX";
            this.btn_CosX.Size = new System.Drawing.Size(50, 40);
            this.btn_CosX.TabIndex = 29;
            this.btn_CosX.Text = "cos(x)";
            this.btn_CosX.UseVisualStyleBackColor = true;
            this.btn_CosX.Click += new System.EventHandler(this.btn_CosX_Click);
            // 
            // btn_SinX
            // 
            this.btn_SinX.Location = new System.Drawing.Point(168, 107);
            this.btn_SinX.Name = "btn_SinX";
            this.btn_SinX.Size = new System.Drawing.Size(50, 40);
            this.btn_SinX.TabIndex = 28;
            this.btn_SinX.Text = "sin(x)";
            this.btn_SinX.UseVisualStyleBackColor = true;
            this.btn_SinX.Click += new System.EventHandler(this.btn_SinX_Click);
            // 
            // btn_SQRT
            // 
            this.btn_SQRT.Location = new System.Drawing.Point(168, 199);
            this.btn_SQRT.Name = "btn_SQRT";
            this.btn_SQRT.Size = new System.Drawing.Size(50, 40);
            this.btn_SQRT.TabIndex = 27;
            this.btn_SQRT.Text = "√";
            this.btn_SQRT.UseVisualStyleBackColor = true;
            this.btn_SQRT.Click += new System.EventHandler(this.btn_SQRT_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 303);
            this.Controls.Add(this.btn_CosX);
            this.Controls.Add(this.btn_SinX);
            this.Controls.Add(this.btn_SQRT);
            this.Controls.Add(this.btn_ClearHistory);
            this.Controls.Add(this.lb_History);
            this.Controls.Add(this.btn_Panel);
            this.Controls.Add(this.btn_Dump);
            this.Controls.Add(this.btn_Divide);
            this.Controls.Add(this.btn_Increase);
            this.Controls.Add(this.btn_EraseLast);
            this.Controls.Add(this.btn_Result);
            this.Controls.Add(this.btn_Minus);
            this.Controls.Add(this.btn_Plus);
            this.Controls.Add(this.btn_Point);
            this.Controls.Add(this.btn_Zero);
            this.Controls.Add(this.btn_СhangeSign);
            this.Controls.Add(this.btn_One);
            this.Controls.Add(this.btn_two);
            this.Controls.Add(this.btn_Three);
            this.Controls.Add(this.btn_Four);
            this.Controls.Add(this.btn_Five);
            this.Controls.Add(this.btn_Six);
            this.Controls.Add(this.btn_Seven);
            this.Controls.Add(this.btn_Eight);
            this.Controls.Add(this.btn_Nine);
            this.Controls.Add(this.lb_Tablo);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "Calculate";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lb_Tablo;
        private System.Windows.Forms.Button btn_Nine;
        private System.Windows.Forms.Button btn_Eight;
        private System.Windows.Forms.Button btn_Seven;
        private System.Windows.Forms.Button btn_Four;
        private System.Windows.Forms.Button btn_Five;
        private System.Windows.Forms.Button btn_Six;
        private System.Windows.Forms.Button btn_One;
        private System.Windows.Forms.Button btn_Three;
        private System.Windows.Forms.Button btn_Point;
        private System.Windows.Forms.Button btn_Zero;
        private System.Windows.Forms.Button btn_СhangeSign;
        private System.Windows.Forms.Button btn_EraseLast;
        private System.Windows.Forms.Button btn_Result;
        private System.Windows.Forms.Button btn_Minus;
        private System.Windows.Forms.Button btn_Plus;
        private System.Windows.Forms.Button btn_two;
        private System.Windows.Forms.Button btn_Divide;
        private System.Windows.Forms.Button btn_Increase;
        private System.Windows.Forms.Button btn_Dump;
        private System.Windows.Forms.Button btn_Panel;
        private System.Windows.Forms.ListBox lb_History;
        private System.Windows.Forms.Button btn_ClearHistory;
        private System.Windows.Forms.Button btn_CosX;
        private System.Windows.Forms.Button btn_SinX;
        private System.Windows.Forms.Button btn_SQRT;
    }
}

