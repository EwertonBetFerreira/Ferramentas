namespace Tibia
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
            btn1 = new Button();
            txtNomeChar = new TextBox();
            txtDirSelecionado = new TextBox();
            selecionarDir = new FolderBrowserDialog();
            btnSelecionaDir = new Button();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // btn1
            // 
            btn1.Location = new Point(530, 184);
            btn1.Name = "btn1";
            btn1.Size = new Size(144, 23);
            btn1.TabIndex = 0;
            btn1.Text = "Buscar Char";
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += btn1_Click;
            // 
            // txtNomeChar
            // 
            txtNomeChar.Location = new Point(247, 184);
            txtNomeChar.Name = "txtNomeChar";
            txtNomeChar.Size = new Size(277, 23);
            txtNomeChar.TabIndex = 1;
            // 
            // txtDirSelecionado
            // 
            txtDirSelecionado.Location = new Point(247, 137);
            txtDirSelecionado.Name = "txtDirSelecionado";
            txtDirSelecionado.Size = new Size(277, 23);
            txtDirSelecionado.TabIndex = 2;
            // 
            // btnSelecionaDir
            // 
            btnSelecionaDir.Location = new Point(530, 137);
            btnSelecionaDir.Name = "btnSelecionaDir";
            btnSelecionaDir.Size = new Size(30, 23);
            btnSelecionaDir.TabIndex = 3;
            btnSelecionaDir.Text = "...";
            btnSelecionaDir.UseVisualStyleBackColor = true;
            btnSelecionaDir.Click += btnSelecionaDir_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(122, 141);
            label1.Name = "label1";
            label1.Size = new Size(119, 15);
            label1.TabIndex = 4;
            label1.Text = "Selecione o Diretório:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(52, 188);
            label2.Name = "label2";
            label2.Size = new Size(189, 15);
            label2.TabIndex = 5;
            label2.Text = "Nome ou parte do nome do Char: ";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(723, 301);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnSelecionaDir);
            Controls.Add(txtDirSelecionado);
            Controls.Add(txtNomeChar);
            Controls.Add(btn1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn1;
        private TextBox txtNomeChar;
        private TextBox txtDirSelecionado;
        private FolderBrowserDialog selecionarDir;
        private Button btnSelecionaDir;
        private Label label1;
        private Label label2;
    }
}