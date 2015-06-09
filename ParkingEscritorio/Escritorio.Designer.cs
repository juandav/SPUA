
using MetroFramework.Forms;
namespace ParkingEscritorio
{
    partial class Escritorio 
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.MTPINICIO = new MetroFramework.Controls.MetroTabPage();
            this.MTPREGISTRO = new MetroFramework.Controls.MetroTabPage();
            this.metroComboBox1 = new MetroFramework.Controls.MetroComboBox();
            this.MBTARJETA = new MetroFramework.Controls.MetroButton();
            this.MBHUELLA = new MetroFramework.Controls.MetroButton();
            this.MGTARJETA = new MetroFramework.Controls.MetroGrid();
            this.MGHUELLA = new MetroFramework.Controls.MetroGrid();
            this.MGUSUARIO = new MetroFramework.Controls.MetroGrid();
            this.MTPVALIDACION = new MetroFramework.Controls.MetroTabPage();
            this.MTPTERMINAL = new MetroFramework.Controls.MetroTabPage();
            this.MTPCONFIGURACION = new MetroFramework.Controls.MetroTabPage();
            this.MBCONECTAR = new MetroFramework.Controls.MetroButton();
            this.metroTabControl1.SuspendLayout();
            this.MTPREGISTRO.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MGTARJETA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MGHUELLA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MGUSUARIO)).BeginInit();
            this.SuspendLayout();
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.MTPINICIO);
            this.metroTabControl1.Controls.Add(this.MTPREGISTRO);
            this.metroTabControl1.Controls.Add(this.MTPVALIDACION);
            this.metroTabControl1.Controls.Add(this.MTPTERMINAL);
            this.metroTabControl1.Controls.Add(this.MTPCONFIGURACION);
            this.metroTabControl1.Location = new System.Drawing.Point(40, 63);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 1;
            this.metroTabControl1.Size = new System.Drawing.Size(935, 527);
            this.metroTabControl1.TabIndex = 0;
            this.metroTabControl1.UseSelectable = true;
            // 
            // MTPINICIO
            // 
            this.MTPINICIO.HorizontalScrollbarBarColor = true;
            this.MTPINICIO.HorizontalScrollbarHighlightOnWheel = false;
            this.MTPINICIO.HorizontalScrollbarSize = 10;
            this.MTPINICIO.Location = new System.Drawing.Point(4, 38);
            this.MTPINICIO.Name = "MTPINICIO";
            this.MTPINICIO.Size = new System.Drawing.Size(927, 485);
            this.MTPINICIO.TabIndex = 0;
            this.MTPINICIO.Text = "Presentación";
            this.MTPINICIO.VerticalScrollbarBarColor = true;
            this.MTPINICIO.VerticalScrollbarHighlightOnWheel = false;
            this.MTPINICIO.VerticalScrollbarSize = 10;
            // 
            // MTPREGISTRO
            // 
            this.MTPREGISTRO.Controls.Add(this.MBCONECTAR);
            this.MTPREGISTRO.Controls.Add(this.metroComboBox1);
            this.MTPREGISTRO.Controls.Add(this.MBTARJETA);
            this.MTPREGISTRO.Controls.Add(this.MBHUELLA);
            this.MTPREGISTRO.Controls.Add(this.MGTARJETA);
            this.MTPREGISTRO.Controls.Add(this.MGHUELLA);
            this.MTPREGISTRO.Controls.Add(this.MGUSUARIO);
            this.MTPREGISTRO.HorizontalScrollbarBarColor = true;
            this.MTPREGISTRO.HorizontalScrollbarHighlightOnWheel = false;
            this.MTPREGISTRO.HorizontalScrollbarSize = 10;
            this.MTPREGISTRO.Location = new System.Drawing.Point(4, 38);
            this.MTPREGISTRO.Name = "MTPREGISTRO";
            this.MTPREGISTRO.Size = new System.Drawing.Size(927, 485);
            this.MTPREGISTRO.TabIndex = 1;
            this.MTPREGISTRO.Text = "Registro de Personas";
            this.MTPREGISTRO.VerticalScrollbarBarColor = true;
            this.MTPREGISTRO.VerticalScrollbarHighlightOnWheel = false;
            this.MTPREGISTRO.VerticalScrollbarSize = 10;
            // 
            // metroComboBox1
            // 
            this.metroComboBox1.FormattingEnabled = true;
            this.metroComboBox1.ItemHeight = 23;
            this.metroComboBox1.Location = new System.Drawing.Point(54, 456);
            this.metroComboBox1.Name = "metroComboBox1";
            this.metroComboBox1.Size = new System.Drawing.Size(222, 29);
            this.metroComboBox1.TabIndex = 5;
            this.metroComboBox1.UseSelectable = true;
            // 
            // MBTARJETA
            // 
            this.MBTARJETA.Location = new System.Drawing.Point(634, 462);
            this.MBTARJETA.Name = "MBTARJETA";
            this.MBTARJETA.Size = new System.Drawing.Size(120, 23);
            this.MBTARJETA.TabIndex = 3;
            this.MBTARJETA.Text = "Agregar Tarjeta";
            this.MBTARJETA.UseSelectable = true;
            this.MBTARJETA.Click += new System.EventHandler(this.MBTARJETA_Click);
            this.MBTARJETA.MouseClick += new System.Windows.Forms.MouseEventHandler(this.registrarTarjeta);
            // 
            // MBHUELLA
            // 
            this.MBHUELLA.Location = new System.Drawing.Point(760, 462);
            this.MBHUELLA.Name = "MBHUELLA";
            this.MBHUELLA.Size = new System.Drawing.Size(134, 23);
            this.MBHUELLA.TabIndex = 3;
            this.MBHUELLA.Text = "Agregar Huella";
            this.MBHUELLA.UseSelectable = true;
            this.MBHUELLA.Click += new System.EventHandler(this.MBHUELLA_Click);
            this.MBHUELLA.MouseClick += new System.Windows.Forms.MouseEventHandler(this.registrarHuella);
            // 
            // MGTARJETA
            // 
            this.MGTARJETA.AllowUserToResizeRows = false;
            this.MGTARJETA.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.MGTARJETA.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.MGTARJETA.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.MGTARJETA.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.MGTARJETA.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.MGTARJETA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.MGTARJETA.DefaultCellStyle = dataGridViewCellStyle2;
            this.MGTARJETA.EnableHeadersVisualStyles = false;
            this.MGTARJETA.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.MGTARJETA.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.MGTARJETA.Location = new System.Drawing.Point(496, 271);
            this.MGTARJETA.Name = "MGTARJETA";
            this.MGTARJETA.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.MGTARJETA.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.MGTARJETA.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.MGTARJETA.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.MGTARJETA.Size = new System.Drawing.Size(387, 150);
            this.MGTARJETA.TabIndex = 4;
            // 
            // MGHUELLA
            // 
            this.MGHUELLA.AllowUserToResizeRows = false;
            this.MGHUELLA.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.MGHUELLA.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.MGHUELLA.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.MGHUELLA.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.MGHUELLA.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.MGHUELLA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.MGHUELLA.DefaultCellStyle = dataGridViewCellStyle5;
            this.MGHUELLA.EnableHeadersVisualStyles = false;
            this.MGHUELLA.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.MGHUELLA.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.MGHUELLA.Location = new System.Drawing.Point(54, 271);
            this.MGHUELLA.Name = "MGHUELLA";
            this.MGHUELLA.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.MGHUELLA.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.MGHUELLA.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.MGHUELLA.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.MGHUELLA.Size = new System.Drawing.Size(408, 150);
            this.MGHUELLA.TabIndex = 3;
            // 
            // MGUSUARIO
            // 
            this.MGUSUARIO.AllowUserToResizeRows = false;
            this.MGUSUARIO.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.MGUSUARIO.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.MGUSUARIO.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.MGUSUARIO.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.MGUSUARIO.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.MGUSUARIO.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.MGUSUARIO.DefaultCellStyle = dataGridViewCellStyle8;
            this.MGUSUARIO.EnableHeadersVisualStyles = false;
            this.MGUSUARIO.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.MGUSUARIO.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.MGUSUARIO.Location = new System.Drawing.Point(54, 37);
            this.MGUSUARIO.Name = "MGUSUARIO";
            this.MGUSUARIO.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.MGUSUARIO.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.MGUSUARIO.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.MGUSUARIO.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.MGUSUARIO.Size = new System.Drawing.Size(829, 211);
            this.MGUSUARIO.TabIndex = 2;
            this.MGUSUARIO.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.cargarHuellaTarjeta);
            this.MGUSUARIO.SizeChanged += new System.EventHandler(this.MGUSUARIO_SizeChanged);
            // 
            // MTPVALIDACION
            // 
            this.MTPVALIDACION.HorizontalScrollbarBarColor = true;
            this.MTPVALIDACION.HorizontalScrollbarHighlightOnWheel = false;
            this.MTPVALIDACION.HorizontalScrollbarSize = 10;
            this.MTPVALIDACION.Location = new System.Drawing.Point(4, 38);
            this.MTPVALIDACION.Name = "MTPVALIDACION";
            this.MTPVALIDACION.Size = new System.Drawing.Size(927, 485);
            this.MTPVALIDACION.TabIndex = 2;
            this.MTPVALIDACION.Text = "Modo Validación";
            this.MTPVALIDACION.VerticalScrollbarBarColor = true;
            this.MTPVALIDACION.VerticalScrollbarHighlightOnWheel = false;
            this.MTPVALIDACION.VerticalScrollbarSize = 10;
            // 
            // MTPTERMINAL
            // 
            this.MTPTERMINAL.HorizontalScrollbarBarColor = true;
            this.MTPTERMINAL.HorizontalScrollbarHighlightOnWheel = false;
            this.MTPTERMINAL.HorizontalScrollbarSize = 10;
            this.MTPTERMINAL.Location = new System.Drawing.Point(4, 38);
            this.MTPTERMINAL.Name = "MTPTERMINAL";
            this.MTPTERMINAL.Size = new System.Drawing.Size(927, 485);
            this.MTPTERMINAL.TabIndex = 3;
            this.MTPTERMINAL.Text = "Manejo de Terminales";
            this.MTPTERMINAL.VerticalScrollbarBarColor = true;
            this.MTPTERMINAL.VerticalScrollbarHighlightOnWheel = false;
            this.MTPTERMINAL.VerticalScrollbarSize = 10;
            // 
            // MTPCONFIGURACION
            // 
            this.MTPCONFIGURACION.HorizontalScrollbarBarColor = true;
            this.MTPCONFIGURACION.HorizontalScrollbarHighlightOnWheel = false;
            this.MTPCONFIGURACION.HorizontalScrollbarSize = 10;
            this.MTPCONFIGURACION.Location = new System.Drawing.Point(4, 38);
            this.MTPCONFIGURACION.Name = "MTPCONFIGURACION";
            this.MTPCONFIGURACION.Size = new System.Drawing.Size(927, 485);
            this.MTPCONFIGURACION.TabIndex = 4;
            this.MTPCONFIGURACION.Text = "Configuraciones";
            this.MTPCONFIGURACION.VerticalScrollbarBarColor = true;
            this.MTPCONFIGURACION.VerticalScrollbarHighlightOnWheel = false;
            this.MTPCONFIGURACION.VerticalScrollbarSize = 10;
            // 
            // MBCONECTAR
            // 
            this.MBCONECTAR.Location = new System.Drawing.Point(282, 459);
            this.MBCONECTAR.Name = "MBCONECTAR";
            this.MBCONECTAR.Size = new System.Drawing.Size(112, 23);
            this.MBCONECTAR.TabIndex = 6;
            this.MBCONECTAR.Text = "Conectar";
            this.MBCONECTAR.UseSelectable = true;
            // 
            // Escritorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 629);
            this.Controls.Add(this.metroTabControl1);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.MinimumSize = new System.Drawing.Size(1024, 600);
            this.Name = "Escritorio";
            this.Text = "Parqueadero";
            this.Load += new System.EventHandler(this.Escritorio_Load);
            this.metroTabControl1.ResumeLayout(false);
            this.MTPREGISTRO.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MGTARJETA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MGHUELLA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MGUSUARIO)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage MTPINICIO;
        private MetroFramework.Controls.MetroTabPage MTPREGISTRO;
        private MetroFramework.Controls.MetroTabPage MTPVALIDACION;
        private MetroFramework.Controls.MetroTabPage MTPTERMINAL;
        private MetroFramework.Controls.MetroTabPage MTPCONFIGURACION;
        private MetroFramework.Controls.MetroGrid MGUSUARIO;
        private MetroFramework.Controls.MetroButton MBHUELLA;
        private MetroFramework.Controls.MetroGrid MGHUELLA;
        private MetroFramework.Controls.MetroButton MBTARJETA;
        private MetroFramework.Controls.MetroGrid MGTARJETA;
        private MetroFramework.Controls.MetroComboBox metroComboBox1;
        private MetroFramework.Controls.MetroButton MBCONECTAR;
    }
}