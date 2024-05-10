namespace Vistas
{
    partial class Sistema
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
            label1 = new Label();
            btnAltaCategorias = new Button();
            btnAltaDisciplinas = new Button();
            btnVolverSistema = new Button();
            btnListaCateogrias = new Button();
            btnListaDisciplinas = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F);
            label1.Location = new Point(47, 44);
            label1.Name = "label1";
            label1.Size = new Size(114, 32);
            label1.TabIndex = 0;
            label1.Text = "Opciones";
            // 
            // btnAltaCategorias
            // 
            btnAltaCategorias.Location = new Point(47, 106);
            btnAltaCategorias.Name = "btnAltaCategorias";
            btnAltaCategorias.Size = new Size(161, 64);
            btnAltaCategorias.TabIndex = 1;
            btnAltaCategorias.Text = "Alta de Categorias";
            btnAltaCategorias.UseVisualStyleBackColor = true;
            // 
            // btnAltaDisciplinas
            // 
            btnAltaDisciplinas.Location = new Point(47, 176);
            btnAltaDisciplinas.Name = "btnAltaDisciplinas";
            btnAltaDisciplinas.Size = new Size(161, 64);
            btnAltaDisciplinas.TabIndex = 2;
            btnAltaDisciplinas.Text = "Alta de Disciplinas";
            btnAltaDisciplinas.UseVisualStyleBackColor = true;
            // 
            // btnVolverSistema
            // 
            btnVolverSistema.BackgroundImage = Properties.Resources.volver;
            btnVolverSistema.BackgroundImageLayout = ImageLayout.Stretch;
            btnVolverSistema.Location = new Point(740, 12);
            btnVolverSistema.Name = "btnVolverSistema";
            btnVolverSistema.Size = new Size(48, 48);
            btnVolverSistema.TabIndex = 3;
            btnVolverSistema.UseVisualStyleBackColor = true;
            btnVolverSistema.Click += btnVolverSistema_Click;
            // 
            // btnListaCateogrias
            // 
            btnListaCateogrias.Location = new Point(214, 106);
            btnListaCateogrias.Name = "btnListaCateogrias";
            btnListaCateogrias.Size = new Size(161, 64);
            btnListaCateogrias.TabIndex = 4;
            btnListaCateogrias.Text = "Lista de Categorias";
            btnListaCateogrias.UseVisualStyleBackColor = true;
            // 
            // btnListaDisciplinas
            // 
            btnListaDisciplinas.Location = new Point(214, 176);
            btnListaDisciplinas.Name = "btnListaDisciplinas";
            btnListaDisciplinas.Size = new Size(161, 64);
            btnListaDisciplinas.TabIndex = 5;
            btnListaDisciplinas.Text = "Lista de Disciplinas";
            btnListaDisciplinas.UseVisualStyleBackColor = true;
            // 
            // Sistema
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnListaDisciplinas);
            Controls.Add(btnListaCateogrias);
            Controls.Add(btnVolverSistema);
            Controls.Add(btnAltaDisciplinas);
            Controls.Add(btnAltaCategorias);
            Controls.Add(label1);
            Name = "Sistema";
            Text = "Sistema";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnAltaCategorias;
        private Button btnAltaDisciplinas;
        private Button btnVolverSistema;
        private Button btnListaCateogrias;
        private Button btnListaDisciplinas;
    }
}