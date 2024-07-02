namespace Integrador_Repaso
{
    partial class FrmMostrar
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
            lstMostrar = new ListBox();
            btnTodos = new Button();
            btnGerentes = new Button();
            btnDesarrolladores = new Button();
            btnUltimo = new Button();
            btnBuscar = new Button();
            txtId = new TextBox();
            button1 = new Button();
            btnAsignar = new Button();
            SuspendLayout();
            // 
            // lstMostrar
            // 
            lstMostrar.FormattingEnabled = true;
            lstMostrar.ItemHeight = 15;
            lstMostrar.Location = new Point(67, 34);
            lstMostrar.Name = "lstMostrar";
            lstMostrar.Size = new Size(617, 214);
            lstMostrar.TabIndex = 0;
            // 
            // btnTodos
            // 
            btnTodos.Location = new Point(67, 272);
            btnTodos.Name = "btnTodos";
            btnTodos.Size = new Size(128, 44);
            btnTodos.TabIndex = 1;
            btnTodos.Text = "Todos";
            btnTodos.UseVisualStyleBackColor = true;
            btnTodos.Click += btnTodos_Click;
            // 
            // btnGerentes
            // 
            btnGerentes.Location = new Point(67, 372);
            btnGerentes.Name = "btnGerentes";
            btnGerentes.Size = new Size(128, 44);
            btnGerentes.TabIndex = 2;
            btnGerentes.Text = "Gerentes";
            btnGerentes.UseVisualStyleBackColor = true;
            btnGerentes.Click += btnGerentes_Click;
            // 
            // btnDesarrolladores
            // 
            btnDesarrolladores.Location = new Point(67, 322);
            btnDesarrolladores.Name = "btnDesarrolladores";
            btnDesarrolladores.Size = new Size(128, 44);
            btnDesarrolladores.TabIndex = 3;
            btnDesarrolladores.Text = "Desarrolladores";
            btnDesarrolladores.UseVisualStyleBackColor = true;
            btnDesarrolladores.Click += btnDesarrolladores_Click;
            // 
            // btnUltimo
            // 
            btnUltimo.Location = new Point(320, 272);
            btnUltimo.Name = "btnUltimo";
            btnUltimo.Size = new Size(128, 44);
            btnUltimo.TabIndex = 4;
            btnUltimo.Text = "Ultimo";
            btnUltimo.UseVisualStyleBackColor = true;
            btnUltimo.Click += btnUltimo_Click;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(320, 333);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(128, 44);
            btnBuscar.TabIndex = 5;
            btnBuscar.Text = "Buscar Por Id";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // txtId
            // 
            txtId.Location = new Point(466, 345);
            txtId.Name = "txtId";
            txtId.Size = new Size(146, 23);
            txtId.TabIndex = 6;
            // 
            // button1
            // 
            button1.Location = new Point(0, 0);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 7;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // btnAsignar
            // 
            btnAsignar.Location = new Point(502, 272);
            btnAsignar.Name = "btnAsignar";
            btnAsignar.Size = new Size(128, 44);
            btnAsignar.TabIndex = 8;
            btnAsignar.Text = "Asignar";
            btnAsignar.UseVisualStyleBackColor = true;
            btnAsignar.Click += btnAsignar_Click;
            // 
            // FrmMostrar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnAsignar);
            Controls.Add(button1);
            Controls.Add(txtId);
            Controls.Add(btnBuscar);
            Controls.Add(btnUltimo);
            Controls.Add(btnDesarrolladores);
            Controls.Add(btnGerentes);
            Controls.Add(btnTodos);
            Controls.Add(lstMostrar);
            Name = "FrmMostrar";
            Text = "FrmMostrar";
            Load += FrmMostrar_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lstMostrar;
        private Button btnTodos;
        private Button btnGerentes;
        private Button btnDesarrolladores;
        private Button btnUltimo;
        private Button btnBuscar;
        private TextBox txtId;
        private Button button1;
        private Button btnAsignar;
    }
}