namespace Generics
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnExchange = new System.Windows.Forms.Button();
            this.btnGenericClass = new System.Windows.Forms.Button();
            this.btnStudentArray = new System.Windows.Forms.Button();
            this.btnInitArray = new System.Windows.Forms.Button();
            this.btnFindMaxScoreStudent = new System.Windows.Forms.Button();
            this.btnDictionary = new System.Windows.Forms.Button();
            this.btnEmployeeExtension = new System.Windows.Forms.Button();
            this.btnJSONSerializeDeserialize = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnExchange
            // 
            this.btnExchange.Location = new System.Drawing.Point(232, 88);
            this.btnExchange.Name = "btnExchange";
            this.btnExchange.Size = new System.Drawing.Size(96, 23);
            this.btnExchange.TabIndex = 0;
            this.btnExchange.Text = "ok";
            this.btnExchange.UseVisualStyleBackColor = true;
            this.btnExchange.Click += new System.EventHandler(this.btnExchange_Click);
            // 
            // btnGenericClass
            // 
            this.btnGenericClass.Location = new System.Drawing.Point(232, 136);
            this.btnGenericClass.Name = "btnGenericClass";
            this.btnGenericClass.Size = new System.Drawing.Size(96, 23);
            this.btnGenericClass.TabIndex = 1;
            this.btnGenericClass.Text = "btnGenericClass";
            this.btnGenericClass.UseVisualStyleBackColor = true;
            this.btnGenericClass.Click += new System.EventHandler(this.btnGenericClass_Click);
            // 
            // btnStudentArray
            // 
            this.btnStudentArray.Location = new System.Drawing.Point(99, 190);
            this.btnStudentArray.Name = "btnStudentArray";
            this.btnStudentArray.Size = new System.Drawing.Size(96, 23);
            this.btnStudentArray.TabIndex = 2;
            this.btnStudentArray.Text = "btnStudentArray";
            this.btnStudentArray.UseVisualStyleBackColor = true;
            this.btnStudentArray.Click += new System.EventHandler(this.btnStudentArray_Click);
            // 
            // btnInitArray
            // 
            this.btnInitArray.Location = new System.Drawing.Point(321, 190);
            this.btnInitArray.Name = "btnInitArray";
            this.btnInitArray.Size = new System.Drawing.Size(131, 23);
            this.btnInitArray.TabIndex = 3;
            this.btnInitArray.Text = "btnInitArray";
            this.btnInitArray.UseVisualStyleBackColor = true;
            this.btnInitArray.Click += new System.EventHandler(this.btnInitArray_Click);
            // 
            // btnFindMaxScoreStudent
            // 
            this.btnFindMaxScoreStudent.Location = new System.Drawing.Point(193, 233);
            this.btnFindMaxScoreStudent.Name = "btnFindMaxScoreStudent";
            this.btnFindMaxScoreStudent.Size = new System.Drawing.Size(181, 23);
            this.btnFindMaxScoreStudent.TabIndex = 4;
            this.btnFindMaxScoreStudent.Text = "btnFindMaxScoreStudent";
            this.btnFindMaxScoreStudent.UseVisualStyleBackColor = true;
            this.btnFindMaxScoreStudent.Click += new System.EventHandler(this.btnFindMaxScoreStudent_Click);
            // 
            // btnDictionary
            // 
            this.btnDictionary.Location = new System.Drawing.Point(216, 283);
            this.btnDictionary.Name = "btnDictionary";
            this.btnDictionary.Size = new System.Drawing.Size(112, 23);
            this.btnDictionary.TabIndex = 5;
            this.btnDictionary.Text = "btnDictionary";
            this.btnDictionary.UseVisualStyleBackColor = true;
            this.btnDictionary.Click += new System.EventHandler(this.btnDictionary_Click);
            // 
            // btnEmployeeExtension
            // 
            this.btnEmployeeExtension.Location = new System.Drawing.Point(99, 346);
            this.btnEmployeeExtension.Name = "btnEmployeeExtension";
            this.btnEmployeeExtension.Size = new System.Drawing.Size(139, 23);
            this.btnEmployeeExtension.TabIndex = 6;
            this.btnEmployeeExtension.Text = "btnEmployeeExtension";
            this.btnEmployeeExtension.UseVisualStyleBackColor = true;
            this.btnEmployeeExtension.Click += new System.EventHandler(this.btnEmployeeExtension_Click);
            // 
            // btnJSONSerializeDeserialize
            // 
            this.btnJSONSerializeDeserialize.Location = new System.Drawing.Point(295, 353);
            this.btnJSONSerializeDeserialize.Name = "btnJSONSerializeDeserialize";
            this.btnJSONSerializeDeserialize.Size = new System.Drawing.Size(204, 23);
            this.btnJSONSerializeDeserialize.TabIndex = 7;
            this.btnJSONSerializeDeserialize.Text = "btnJSONSerializeDeserialize";
            this.btnJSONSerializeDeserialize.UseVisualStyleBackColor = true;
            this.btnJSONSerializeDeserialize.Click += new System.EventHandler(this.btnJSONSerializeDeserailize_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(447, 406);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "--  AshwinRaj_1262774";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnJSONSerializeDeserialize);
            this.Controls.Add(this.btnEmployeeExtension);
            this.Controls.Add(this.btnDictionary);
            this.Controls.Add(this.btnFindMaxScoreStudent);
            this.Controls.Add(this.btnInitArray);
            this.Controls.Add(this.btnStudentArray);
            this.Controls.Add(this.btnGenericClass);
            this.Controls.Add(this.btnExchange);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnExchange;
        private Button btnGenericClass;
        private Button btnStudentArray;
        private Button btnInitArray;
        private Button btnFindMaxScoreStudent;
        private Button btnDictionary;
        private Button btnEmployeeExtension;
        private Button btnJSONSerializeDeserialize;
        private Label label1;
    }
}