namespace Estructuras_lineales__listas_
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
            btnOrdenar = new Button();
            btnInserta = new Button();
            btnMostrar = new Button();
            txtNombre = new TextBox();
            numericUpDownPrecio = new NumericUpDown();
            ListViewData = new ListView();
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)numericUpDownPrecio).BeginInit();
            SuspendLayout();
            // 
            // btnOrdenar
            // 
            btnOrdenar.Location = new Point(32, 259);
            btnOrdenar.Name = "btnOrdenar";
            btnOrdenar.Size = new Size(136, 43);
            btnOrdenar.TabIndex = 0;
            btnOrdenar.Text = "Ordenar";
            btnOrdenar.UseVisualStyleBackColor = true;
            btnOrdenar.Click += btnOrdenar_Click;
            // 
            // btnInserta
            // 
            btnInserta.Location = new Point(32, 174);
            btnInserta.Name = "btnInserta";
            btnInserta.Size = new Size(136, 43);
            btnInserta.TabIndex = 1;
            btnInserta.Text = "Insertar";
            btnInserta.UseVisualStyleBackColor = true;
            btnInserta.Click += btnInserta_Click;
            // 
            // btnMostrar
            // 
            btnMostrar.Location = new Point(32, 348);
            btnMostrar.Name = "btnMostrar";
            btnMostrar.Size = new Size(136, 43);
            btnMostrar.TabIndex = 2;
            btnMostrar.Text = "Mostrar";
            btnMostrar.UseVisualStyleBackColor = true;
            btnMostrar.Click += btnMostrar_Click;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(72, 48);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(272, 23);
            txtNombre.TabIndex = 3;
            // 
            // numericUpDownPrecio
            // 
            numericUpDownPrecio.Location = new Point(138, 92);
            numericUpDownPrecio.Name = "numericUpDownPrecio";
            numericUpDownPrecio.Size = new Size(120, 23);
            numericUpDownPrecio.TabIndex = 6;
            // 
            // ListViewData
            // 
            ListViewData.Location = new Point(415, 48);
            ListViewData.Name = "ListViewData";
            ListViewData.Size = new Size(325, 343);
            ListViewData.TabIndex = 7;
            ListViewData.UseCompatibleStateImageBehavior = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(181, 18);
            label1.Name = "label1";
            label1.Size = new Size(56, 15);
            label1.TabIndex = 8;
            label1.Text = "Producto";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(53, 100);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 9;
            label2.Text = "Precio";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(ListViewData);
            Controls.Add(numericUpDownPrecio);
            Controls.Add(txtNombre);
            Controls.Add(btnMostrar);
            Controls.Add(btnInserta);
            Controls.Add(btnOrdenar);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)numericUpDownPrecio).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnOrdenar;
        private Button btnInserta;
        private Button btnMostrar;
        private TextBox txtNombre;
        private NumericUpDown numericUpDownPrecio;
        private ListView ListViewData;
        private Label label1;
        private Label label2;
    }
}
