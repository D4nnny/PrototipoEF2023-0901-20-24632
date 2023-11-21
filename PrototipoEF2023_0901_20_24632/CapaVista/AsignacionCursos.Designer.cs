
namespace CapaVista
{
    partial class AsignacionCursos
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
            this.navegador1 = new NavegadorVista.Navegador();
            this.TXT_CARRERA = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.TXTSEDE = new System.Windows.Forms.TextBox();
            this.TXTJORNADA = new System.Windows.Forms.TextBox();
            this.TXTSECCION = new System.Windows.Forms.TextBox();
            this.TXTAULA = new System.Windows.Forms.TextBox();
            this.TXTCURSO = new System.Windows.Forms.TextBox();
            this.TXTCARNET = new System.Windows.Forms.TextBox();
            this.TXTNOTA = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // navegador1
            // 
            this.navegador1.Location = new System.Drawing.Point(112, 12);
            this.navegador1.Name = "navegador1";
            this.navegador1.Size = new System.Drawing.Size(574, 152);
            this.navegador1.TabIndex = 0;
            this.navegador1.Load += new System.EventHandler(this.navegador1_Load);
            // 
            // TXT_CARRERA
            // 
            this.TXT_CARRERA.Location = new System.Drawing.Point(165, 195);
            this.TXT_CARRERA.Name = "TXT_CARRERA";
            this.TXT_CARRERA.Size = new System.Drawing.Size(143, 20);
            this.TXT_CARRERA.TabIndex = 1;
            this.TXT_CARRERA.Tag = "codigo_carrera";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 198);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "CODIGO CARRERA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(78, 233);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "CODIGO SEDE";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(56, 264);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "CODIGO JORNADA";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(60, 296);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "CODIGO SECCION";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(349, 194);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "CODIGO AULA";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(343, 229);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "CODIGO CURSO";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(333, 260);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "CARNET ALUMNO";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(396, 291);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "NOTA";
            // 
            // TXTSEDE
            // 
            this.TXTSEDE.Location = new System.Drawing.Point(165, 230);
            this.TXTSEDE.Name = "TXTSEDE";
            this.TXTSEDE.Size = new System.Drawing.Size(143, 20);
            this.TXTSEDE.TabIndex = 10;
            this.TXTSEDE.Tag = "codigo_sede";
            // 
            // TXTJORNADA
            // 
            this.TXTJORNADA.Location = new System.Drawing.Point(165, 261);
            this.TXTJORNADA.Name = "TXTJORNADA";
            this.TXTJORNADA.Size = new System.Drawing.Size(143, 20);
            this.TXTJORNADA.TabIndex = 11;
            this.TXTJORNADA.Tag = "codigo_jornada";
            // 
            // TXTSECCION
            // 
            this.TXTSECCION.Location = new System.Drawing.Point(165, 293);
            this.TXTSECCION.Name = "TXTSECCION";
            this.TXTSECCION.Size = new System.Drawing.Size(143, 20);
            this.TXTSECCION.TabIndex = 12;
            this.TXTSECCION.Tag = "codigo_seccion";
            // 
            // TXTAULA
            // 
            this.TXTAULA.Location = new System.Drawing.Point(439, 191);
            this.TXTAULA.Name = "TXTAULA";
            this.TXTAULA.Size = new System.Drawing.Size(143, 20);
            this.TXTAULA.TabIndex = 13;
            this.TXTAULA.Tag = "codigo_aula ";
            // 
            // TXTCURSO
            // 
            this.TXTCURSO.Location = new System.Drawing.Point(439, 226);
            this.TXTCURSO.Name = "TXTCURSO";
            this.TXTCURSO.Size = new System.Drawing.Size(143, 20);
            this.TXTCURSO.TabIndex = 14;
            this.TXTCURSO.Tag = "codigo_curso";
            // 
            // TXTCARNET
            // 
            this.TXTCARNET.Location = new System.Drawing.Point(439, 257);
            this.TXTCARNET.Name = "TXTCARNET";
            this.TXTCARNET.Size = new System.Drawing.Size(143, 20);
            this.TXTCARNET.TabIndex = 15;
            this.TXTCARNET.Tag = "carnet_alumno";
            // 
            // TXTNOTA
            // 
            this.TXTNOTA.Location = new System.Drawing.Point(439, 288);
            this.TXTNOTA.Name = "TXTNOTA";
            this.TXTNOTA.Size = new System.Drawing.Size(143, 20);
            this.TXTNOTA.TabIndex = 16;
            this.TXTNOTA.Tag = "nota_asignacioncursoalumnos";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(38, 366);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(709, 291);
            this.dataGridView1.TabIndex = 17;
            // 
            // AsignacionCursos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 650);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.TXTNOTA);
            this.Controls.Add(this.TXTCARNET);
            this.Controls.Add(this.TXTCURSO);
            this.Controls.Add(this.TXTAULA);
            this.Controls.Add(this.TXTSECCION);
            this.Controls.Add(this.TXTJORNADA);
            this.Controls.Add(this.TXTSEDE);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TXT_CARRERA);
            this.Controls.Add(this.navegador1);
            this.Name = "AsignacionCursos";
            this.Text = "AsignacionCursos";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private NavegadorVista.Navegador navegador1;
        private System.Windows.Forms.TextBox TXT_CARRERA;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TXTSEDE;
        private System.Windows.Forms.TextBox TXTJORNADA;
        private System.Windows.Forms.TextBox TXTSECCION;
        private System.Windows.Forms.TextBox TXTAULA;
        private System.Windows.Forms.TextBox TXTCURSO;
        private System.Windows.Forms.TextBox TXTCARNET;
        private System.Windows.Forms.TextBox TXTNOTA;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}