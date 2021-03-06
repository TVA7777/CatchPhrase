﻿
namespace CatchPhrase
{
    partial class FormMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMenu));
            this.authors = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.types = new System.Windows.Forms.Button();
            this.phrase = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.about = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // authors
            // 
            this.authors.Dock = System.Windows.Forms.DockStyle.Top;
            this.authors.Location = new System.Drawing.Point(10, 10);
            this.authors.Name = "authors";
            this.authors.Size = new System.Drawing.Size(239, 92);
            this.authors.TabIndex = 0;
            this.authors.Text = "Авторы";
            this.authors.UseVisualStyleBackColor = true;
            this.authors.Click += new System.EventHandler(this.authors_Click);
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(10, 102);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(239, 10);
            this.panel1.TabIndex = 1;
            // 
            // types
            // 
            this.types.Dock = System.Windows.Forms.DockStyle.Top;
            this.types.Location = new System.Drawing.Point(10, 112);
            this.types.Name = "types";
            this.types.Size = new System.Drawing.Size(239, 92);
            this.types.TabIndex = 2;
            this.types.Text = "Типы и виды фраз";
            this.types.UseVisualStyleBackColor = true;
            this.types.Click += new System.EventHandler(this.types_Click);
            // 
            // phrase
            // 
            this.phrase.Dock = System.Windows.Forms.DockStyle.Top;
            this.phrase.Location = new System.Drawing.Point(10, 214);
            this.phrase.Name = "phrase";
            this.phrase.Size = new System.Drawing.Size(239, 92);
            this.phrase.TabIndex = 4;
            this.phrase.Text = "Фразы";
            this.phrase.UseVisualStyleBackColor = true;
            this.phrase.Click += new System.EventHandler(this.phrase_Click);
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(10, 204);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(239, 10);
            this.panel2.TabIndex = 3;
            // 
            // about
            // 
            this.about.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.about.FlatAppearance.BorderSize = 0;
            this.about.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.about.Location = new System.Drawing.Point(10, 315);
            this.about.Name = "about";
            this.about.Size = new System.Drawing.Size(239, 71);
            this.about.TabIndex = 5;
            this.about.Text = "О Программе";
            this.about.UseVisualStyleBackColor = true;
            this.about.Click += new System.EventHandler(this.about_Click);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 10F);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(10, 386);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(239, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "v 1.0.1";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // FormMenu
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(259, 416);
            this.Controls.Add(this.about);
            this.Controls.Add(this.phrase);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.types);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.authors);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(275, 455);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(275, 455);
            this.Name = "FormMenu";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Крылатые фразы";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button authors;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button types;
        private System.Windows.Forms.Button phrase;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button about;
        private System.Windows.Forms.Label label1;
    }
}

