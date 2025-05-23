namespace ExamenU3
{
    partial class FrmInsertaProductos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmInsertaProductos));
            txtDescripcion = new TextBox();
            txtStock = new TextBox();
            txtPrecio = new TextBox();
            txtNombre = new TextBox();
            txtId = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            dtFecha = new DateTimePicker();
            label8 = new Label();
            SuspendLayout();
            // 
            // txtDescripcion
            // 
            txtDescripcion.Font = new Font("Comic Sans MS", 10.8F, FontStyle.Bold);
            txtDescripcion.Location = new Point(186, 279);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(125, 33);
            txtDescripcion.TabIndex = 25;
            // 
            // txtStock
            // 
            txtStock.Font = new Font("Comic Sans MS", 10.8F, FontStyle.Bold);
            txtStock.Location = new Point(489, 173);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(125, 33);
            txtStock.TabIndex = 24;
            // 
            // txtPrecio
            // 
            txtPrecio.Font = new Font("Comic Sans MS", 10.8F, FontStyle.Bold);
            txtPrecio.Location = new Point(186, 173);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(125, 33);
            txtPrecio.TabIndex = 23;
            // 
            // txtNombre
            // 
            txtNombre.Font = new Font("Comic Sans MS", 10.8F, FontStyle.Bold);
            txtNombre.Location = new Point(489, 279);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(125, 33);
            txtNombre.TabIndex = 22;
            // 
            // txtId
            // 
            txtId.Font = new Font("Comic Sans MS", 10.8F, FontStyle.Bold);
            txtId.Location = new Point(367, 77);
            txtId.Name = "txtId";
            txtId.Size = new Size(125, 33);
            txtId.TabIndex = 20;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Comic Sans MS", 10.8F, FontStyle.Bold);
            label7.Location = new Point(536, 323);
            label7.Name = "label7";
            label7.Size = new Size(0, 25);
            label7.TabIndex = 19;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Comic Sans MS", 10.8F, FontStyle.Bold);
            label6.Location = new Point(204, 85);
            label6.Name = "label6";
            label6.Size = new Size(115, 25);
            label6.TabIndex = 18;
            label6.Text = "Id Producto";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Comic Sans MS", 10.8F, FontStyle.Bold);
            label5.Location = new Point(204, 232);
            label5.Name = "label5";
            label5.Size = new Size(118, 25);
            label5.TabIndex = 17;
            label5.Text = "Desccripcion";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Comic Sans MS", 10.8F, FontStyle.Bold);
            label4.Location = new Point(190, 323);
            label4.Name = "label4";
            label4.Size = new Size(165, 25);
            label4.TabIndex = 16;
            label4.Text = "Fecha de Ingreso";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Comic Sans MS", 10.8F, FontStyle.Bold);
            label3.Location = new Point(523, 140);
            label3.Name = "label3";
            label3.Size = new Size(60, 25);
            label3.TabIndex = 15;
            label3.Text = "Stock";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Comic Sans MS", 10.8F, FontStyle.Bold);
            label2.Location = new Point(220, 133);
            label2.Name = "label2";
            label2.Size = new Size(64, 25);
            label2.TabIndex = 14;
            label2.Text = "Precio";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Comic Sans MS", 10.8F, FontStyle.Bold);
            label1.Location = new Point(523, 232);
            label1.Name = "label1";
            label1.Size = new Size(80, 25);
            label1.TabIndex = 13;
            label1.Text = "Nombre";
            // 
            // button1
            // 
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.BackgroundImageLayout = ImageLayout.Zoom;
            button1.Location = new Point(486, 364);
            button1.Name = "button1";
            button1.Size = new Size(94, 49);
            button1.TabIndex = 26;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackgroundImage = (Image)resources.GetObject("button2.BackgroundImage");
            button2.BackgroundImageLayout = ImageLayout.Zoom;
            button2.Location = new Point(653, 364);
            button2.Name = "button2";
            button2.Size = new Size(94, 49);
            button2.TabIndex = 27;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // dtFecha
            // 
            dtFecha.Location = new Point(129, 369);
            dtFecha.Name = "dtFecha";
            dtFecha.Size = new Size(250, 27);
            dtFecha.TabIndex = 28;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Comic Sans MS", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(275, 18);
            label8.Name = "label8";
            label8.Size = new Size(261, 39);
            label8.TabIndex = 29;
            label8.Text = "Inserta Productos";
            // 
            // FrmInsertaProductos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label8);
            Controls.Add(dtFecha);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(txtDescripcion);
            Controls.Add(txtStock);
            Controls.Add(txtPrecio);
            Controls.Add(txtNombre);
            Controls.Add(txtId);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmInsertaProductos";
            Text = "FrmInsertaProductos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtDescripcion;
        private TextBox txtStock;
        private TextBox txtPrecio;
        private TextBox txtNombre;
        private TextBox txtId;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button button1;
        private Button button2;
        private DateTimePicker dtFecha;
        private Label label8;
    }
}