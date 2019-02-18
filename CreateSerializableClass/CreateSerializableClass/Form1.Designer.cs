namespace CreateSerializableClass
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.NamespaceName = new System.Windows.Forms.TextBox();
            this.ClassName = new System.Windows.Forms.TextBox();
            this.ListOfUsings = new System.Windows.Forms.ListBox();
            this.ComboUsings = new System.Windows.Forms.ComboBox();
            this.ComboDatatype = new System.Windows.Forms.ComboBox();
            this.PropertyName = new System.Windows.Forms.TextBox();
            this.ComboAccessModifier = new System.Windows.Forms.ComboBox();
            this.ListOfProperties = new System.Windows.Forms.ListBox();
            this.ComboConstructor = new System.Windows.Forms.ComboBox();
            this.PropertyAddCalled = new System.Windows.Forms.CheckBox();
            this.ListConstructorParams = new System.Windows.Forms.ListBox();
            this.ConstructorBox = new System.Windows.Forms.GroupBox();
            this.ListContructors = new System.Windows.Forms.ListBox();
            this.CreateConstructorBtn = new System.Windows.Forms.Button();
            this.PropertyBox = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.UsingBox = new System.Windows.Forms.GroupBox();
            this.NameBox = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CreateFileBtn = new System.Windows.Forms.Button();
            this.ConstructorBox.SuspendLayout();
            this.PropertyBox.SuspendLayout();
            this.UsingBox.SuspendLayout();
            this.NameBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name of Namespace:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name of Class:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Select Properties:";
            // 
            // NamespaceName
            // 
            this.NamespaceName.Location = new System.Drawing.Point(142, 30);
            this.NamespaceName.Name = "NamespaceName";
            this.NamespaceName.Size = new System.Drawing.Size(145, 20);
            this.NamespaceName.TabIndex = 5;
            this.NamespaceName.Text = "Program";
            // 
            // ClassName
            // 
            this.ClassName.Location = new System.Drawing.Point(142, 63);
            this.ClassName.Name = "ClassName";
            this.ClassName.Size = new System.Drawing.Size(145, 20);
            this.ClassName.TabIndex = 6;
            // 
            // ListOfUsings
            // 
            this.ListOfUsings.FormattingEnabled = true;
            this.ListOfUsings.Location = new System.Drawing.Point(31, 56);
            this.ListOfUsings.Name = "ListOfUsings";
            this.ListOfUsings.Size = new System.Drawing.Size(258, 134);
            this.ListOfUsings.TabIndex = 7;
            // 
            // ComboUsings
            // 
            this.ComboUsings.FormattingEnabled = true;
            this.ComboUsings.Items.AddRange(new object[] {
            "using System;",
            "using System.Buffers;",
            "using System.CodeDom;",
            "using System.CodeDom.Compiler;",
            "using System.Collections;",
            "using System.ComponentModel;",
            "using System.Configuration;",
            "using System.Configuration.Assemblies;",
            "using System.Data;",
            "using System.Diagnostics;",
            "using System.Drawing;",
            "using System.Dynamic;",
            "using System.Globalization;",
            "using System.IO;",
            "using System.Linq;",
            "using System.Linq.Expressions;",
            "using System.Net;",
            "using System.Numerics;",
            "using System.Reflection;",
            "using System.Resources;",
            "using System.Runtime;",
            "using System.Security;",
            "using System.Text;",
            "using System.Text.RegularExpressions;",
            "using System.Threading;",
            "using System.Threading.Tasks;",
            "using System.Threading.Tasks.Dataflow;",
            "using System.Timers;"});
            this.ComboUsings.Location = new System.Drawing.Point(31, 29);
            this.ComboUsings.MaxDropDownItems = 1;
            this.ComboUsings.Name = "ComboUsings";
            this.ComboUsings.Size = new System.Drawing.Size(258, 21);
            this.ComboUsings.TabIndex = 8;
            // 
            // ComboDatatype
            // 
            this.ComboDatatype.FormattingEnabled = true;
            this.ComboDatatype.Items.AddRange(new object[] {
            "bool",
            "byte",
            "char",
            "decimal",
            "double",
            "float",
            "int",
            "long",
            "sbyte",
            "short",
            "uint",
            "ulong",
            "ushort"});
            this.ComboDatatype.Location = new System.Drawing.Point(194, 45);
            this.ComboDatatype.Name = "ComboDatatype";
            this.ComboDatatype.Size = new System.Drawing.Size(58, 21);
            this.ComboDatatype.TabIndex = 9;
            // 
            // PropertyName
            // 
            this.PropertyName.Enabled = false;
            this.PropertyName.Location = new System.Drawing.Point(258, 45);
            this.PropertyName.Name = "PropertyName";
            this.PropertyName.Size = new System.Drawing.Size(100, 20);
            this.PropertyName.TabIndex = 10;
            // 
            // ComboAccessModifier
            // 
            this.ComboAccessModifier.FormattingEnabled = true;
            this.ComboAccessModifier.Items.AddRange(new object[] {
            "public",
            "private",
            "protected",
            "private protected",
            "internal",
            "protected internal",
            "static",
            "public static",
            "private static"});
            this.ComboAccessModifier.Location = new System.Drawing.Point(100, 45);
            this.ComboAccessModifier.Name = "ComboAccessModifier";
            this.ComboAccessModifier.Size = new System.Drawing.Size(88, 21);
            this.ComboAccessModifier.TabIndex = 11;
            // 
            // ListOfProperties
            // 
            this.ListOfProperties.FormattingEnabled = true;
            this.ListOfProperties.Location = new System.Drawing.Point(100, 72);
            this.ListOfProperties.Name = "ListOfProperties";
            this.ListOfProperties.Size = new System.Drawing.Size(258, 134);
            this.ListOfProperties.TabIndex = 12;
            // 
            // ComboConstructor
            // 
            this.ComboConstructor.Enabled = false;
            this.ComboConstructor.FormattingEnabled = true;
            this.ComboConstructor.Location = new System.Drawing.Point(100, 30);
            this.ComboConstructor.Name = "ComboConstructor";
            this.ComboConstructor.Size = new System.Drawing.Size(152, 21);
            this.ComboConstructor.TabIndex = 13;
            // 
            // PropertyAddCalled
            // 
            this.PropertyAddCalled.AutoSize = true;
            this.PropertyAddCalled.Location = new System.Drawing.Point(815, 12);
            this.PropertyAddCalled.Name = "PropertyAddCalled";
            this.PropertyAddCalled.Size = new System.Drawing.Size(15, 14);
            this.PropertyAddCalled.TabIndex = 14;
            this.PropertyAddCalled.UseVisualStyleBackColor = true;
            this.PropertyAddCalled.Visible = false;
            // 
            // ListConstructorParams
            // 
            this.ListConstructorParams.FormattingEnabled = true;
            this.ListConstructorParams.Location = new System.Drawing.Point(100, 63);
            this.ListConstructorParams.Name = "ListConstructorParams";
            this.ListConstructorParams.Size = new System.Drawing.Size(258, 95);
            this.ListConstructorParams.TabIndex = 15;
            // 
            // ConstructorBox
            // 
            this.ConstructorBox.Controls.Add(this.ListContructors);
            this.ConstructorBox.Controls.Add(this.CreateConstructorBtn);
            this.ConstructorBox.Controls.Add(this.ListConstructorParams);
            this.ConstructorBox.Controls.Add(this.ComboConstructor);
            this.ConstructorBox.Controls.Add(this.label5);
            this.ConstructorBox.Enabled = false;
            this.ConstructorBox.Location = new System.Drawing.Point(366, 262);
            this.ConstructorBox.Name = "ConstructorBox";
            this.ConstructorBox.Size = new System.Drawing.Size(451, 356);
            this.ConstructorBox.TabIndex = 16;
            this.ConstructorBox.TabStop = false;
            this.ConstructorBox.Text = "Create Constructor";
            // 
            // ListContructors
            // 
            this.ListContructors.FormattingEnabled = true;
            this.ListContructors.Location = new System.Drawing.Point(9, 194);
            this.ListContructors.Name = "ListContructors";
            this.ListContructors.Size = new System.Drawing.Size(436, 147);
            this.ListContructors.TabIndex = 17;
            // 
            // CreateConstructorBtn
            // 
            this.CreateConstructorBtn.Enabled = false;
            this.CreateConstructorBtn.Location = new System.Drawing.Point(100, 165);
            this.CreateConstructorBtn.Name = "CreateConstructorBtn";
            this.CreateConstructorBtn.Size = new System.Drawing.Size(109, 23);
            this.CreateConstructorBtn.TabIndex = 16;
            this.CreateConstructorBtn.Text = "Create Constructor";
            this.CreateConstructorBtn.UseVisualStyleBackColor = true;
            this.CreateConstructorBtn.Click += new System.EventHandler(this.CreateConstructorBtn_Click);
            // 
            // PropertyBox
            // 
            this.PropertyBox.Controls.Add(this.label8);
            this.PropertyBox.Controls.Add(this.label7);
            this.PropertyBox.Controls.Add(this.label6);
            this.PropertyBox.Controls.Add(this.label4);
            this.PropertyBox.Controls.Add(this.ListOfProperties);
            this.PropertyBox.Controls.Add(this.ComboDatatype);
            this.PropertyBox.Controls.Add(this.PropertyName);
            this.PropertyBox.Controls.Add(this.ComboAccessModifier);
            this.PropertyBox.Enabled = false;
            this.PropertyBox.Location = new System.Drawing.Point(366, 33);
            this.PropertyBox.Name = "PropertyBox";
            this.PropertyBox.Size = new System.Drawing.Size(385, 212);
            this.PropertyBox.TabIndex = 17;
            this.PropertyBox.TabStop = false;
            this.PropertyBox.Text = "Create Property";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 5.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(260, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(103, 7);
            this.label8.TabIndex = 8;
            this.label8.Text = "*Press enter to proceed";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(259, 29);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "|       Name              |";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(194, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "|  Type      |";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(97, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "|     Modifier          |";
            // 
            // UsingBox
            // 
            this.UsingBox.Controls.Add(this.ListOfUsings);
            this.UsingBox.Controls.Add(this.ComboUsings);
            this.UsingBox.Location = new System.Drawing.Point(29, 33);
            this.UsingBox.Name = "UsingBox";
            this.UsingBox.Size = new System.Drawing.Size(320, 212);
            this.UsingBox.TabIndex = 18;
            this.UsingBox.TabStop = false;
            this.UsingBox.Text = "Select Usings";
            // 
            // NameBox
            // 
            this.NameBox.Controls.Add(this.label3);
            this.NameBox.Controls.Add(this.ClassName);
            this.NameBox.Controls.Add(this.label2);
            this.NameBox.Controls.Add(this.NamespaceName);
            this.NameBox.Controls.Add(this.label1);
            this.NameBox.Location = new System.Drawing.Point(29, 262);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(320, 224);
            this.NameBox.TabIndex = 19;
            this.NameBox.TabStop = false;
            this.NameBox.Text = "Set Names";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 5.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(140, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 7);
            this.label3.TabIndex = 7;
            this.label3.Text = "*Press enter to proceed";
            // 
            // CreateFileBtn
            // 
            this.CreateFileBtn.Enabled = false;
            this.CreateFileBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateFileBtn.Location = new System.Drawing.Point(90, 530);
            this.CreateFileBtn.Name = "CreateFileBtn";
            this.CreateFileBtn.Size = new System.Drawing.Size(158, 49);
            this.CreateFileBtn.TabIndex = 20;
            this.CreateFileBtn.Text = "Create File";
            this.CreateFileBtn.UseVisualStyleBackColor = true;
            this.CreateFileBtn.Click += new System.EventHandler(this.CreateFileBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 694);
            this.Controls.Add(this.CreateFileBtn);
            this.Controls.Add(this.NameBox);
            this.Controls.Add(this.UsingBox);
            this.Controls.Add(this.PropertyBox);
            this.Controls.Add(this.ConstructorBox);
            this.Controls.Add(this.PropertyAddCalled);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Create Serializable Class";
            this.ConstructorBox.ResumeLayout(false);
            this.ConstructorBox.PerformLayout();
            this.PropertyBox.ResumeLayout(false);
            this.PropertyBox.PerformLayout();
            this.UsingBox.ResumeLayout(false);
            this.NameBox.ResumeLayout(false);
            this.NameBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox NamespaceName;
        private System.Windows.Forms.TextBox ClassName;
        private System.Windows.Forms.ListBox ListOfUsings;
        private System.Windows.Forms.ComboBox ComboUsings;
        private System.Windows.Forms.ComboBox ComboDatatype;
        private System.Windows.Forms.TextBox PropertyName;
        private System.Windows.Forms.ComboBox ComboAccessModifier;
        private System.Windows.Forms.ListBox ListOfProperties;
        private System.Windows.Forms.ComboBox ComboConstructor;
        private System.Windows.Forms.CheckBox PropertyAddCalled;
        private System.Windows.Forms.ListBox ListConstructorParams;
        private System.Windows.Forms.GroupBox ConstructorBox;
        private System.Windows.Forms.GroupBox PropertyBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox UsingBox;
        private System.Windows.Forms.GroupBox NameBox;
        private System.Windows.Forms.ListBox ListContructors;
        private System.Windows.Forms.Button CreateConstructorBtn;
        private System.Windows.Forms.Button CreateFileBtn;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
    }
}

