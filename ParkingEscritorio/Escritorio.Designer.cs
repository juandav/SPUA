
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle61 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle62 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle63 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle58 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle59 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle60 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle55 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle56 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle57 = new System.Windows.Forms.DataGridViewCellStyle();
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.MTPINICIO = new MetroFramework.Controls.MetroTabPage();
            this.MTPREGISTRO = new MetroFramework.Controls.MetroTabPage();
            this.MBHUELLA = new MetroFramework.Controls.MetroButton();
            this.MGUSUARIO = new MetroFramework.Controls.MetroGrid();
            this.MTPVALIDACION = new MetroFramework.Controls.MetroTabPage();
            this.MTPTERMINAL = new MetroFramework.Controls.MetroTabPage();
            this.MTPCONFIGURACION = new MetroFramework.Controls.MetroTabPage();
            this.MBTARJETA = new MetroFramework.Controls.MetroButton();
            this.MGHUELLA = new MetroFramework.Controls.MetroGrid();
            this.MGTARJETA = new MetroFramework.Controls.MetroGrid();
            this.metroComboBox1 = new MetroFramework.Controls.MetroComboBox();
            this.metroTabControl1.SuspendLayout();
            this.MTPREGISTRO.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MGUSUARIO)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MGHUELLA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MGTARJETA)).BeginInit();
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
            // MGUSUARIO
            // 
            this.MGUSUARIO.AllowUserToResizeRows = false;
            this.MGUSUARIO.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.MGUSUARIO.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.MGUSUARIO.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.MGUSUARIO.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle61.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle61.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle61.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle61.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle61.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle61.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle61.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.MGUSUARIO.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle61;
            this.MGUSUARIO.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle62.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle62.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle62.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle62.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle62.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle62.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle62.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.MGUSUARIO.DefaultCellStyle = dataGridViewCellStyle62;
            this.MGUSUARIO.EnableHeadersVisualStyles = false;
            this.MGUSUARIO.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.MGUSUARIO.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.MGUSUARIO.Location = new System.Drawing.Point(54, 37);
            this.MGUSUARIO.Name = "MGUSUARIO";
            this.MGUSUARIO.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle63.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle63.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle63.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle63.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle63.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle63.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle63.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.MGUSUARIO.RowHeadersDefaultCellStyle = dataGridViewCellStyle63;
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
            // MGHUELLA
            // 
            this.MGHUELLA.AllowUserToResizeRows = false;
            this.MGHUELLA.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.MGHUELLA.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.MGHUELLA.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.MGHUELLA.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle58.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle58.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle58.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle58.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle58.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle58.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle58.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.MGHUELLA.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle58;
            this.MGHUELLA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle59.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle59.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle59.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle59.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle59.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle59.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle59.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.MGHUELLA.DefaultCellStyle = dataGridViewCellStyle59;
            this.MGHUELLA.EnableHeadersVisualStyles = false;
            this.MGHUELLA.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.MGHUELLA.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.MGHUELLA.Location = new System.Drawing.Point(54, 271);
            this.MGHUELLA.Name = "MGHUELLA";
            this.MGHUELLA.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle60.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle60.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle60.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle60.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle60.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle60.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle60.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.MGHUELLA.RowHeadersDefaultCellStyle = dataGridViewCellStyle60;
            this.MGHUELLA.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.MGHUELLA.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.MGHUELLA.Size = new System.Drawing.Size(408, 150);
            this.MGHUELLA.TabIndex = 3;
            // 
            // MGTARJETA
            // 
            this.MGTARJETA.AllowUserToResizeRows = false;
            this.MGTARJETA.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.MGTARJETA.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.MGTARJETA.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.MGTARJETA.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle55.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle55.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle55.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle55.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle55.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle55.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle55.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.MGTARJETA.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle55;
            this.MGTARJETA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle56.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle56.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle56.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle56.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle56.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle56.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle56.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.MGTARJETA.DefaultCellStyle = dataGridViewCellStyle56;
            this.MGTARJETA.EnableHeadersVisualStyles = false;
            this.MGTARJETA.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.MGTARJETA.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.MGTARJETA.Location = new System.Drawing.Point(496, 271);
            this.MGTARJETA.Name = "MGTARJETA";
            this.MGTARJETA.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle57.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle57.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle57.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle57.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle57.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle57.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle57.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.MGTARJETA.RowHeadersDefaultCellStyle = dataGridViewCellStyle57;
            this.MGTARJETA.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.MGTARJETA.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.MGTARJETA.Size = new System.Drawing.Size(387, 150);
            this.MGTARJETA.TabIndex = 4;
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
            ((System.ComponentModel.ISupportInitialize)(this.MGUSUARIO)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MGHUELLA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MGTARJETA)).EndInit();
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
    }
}