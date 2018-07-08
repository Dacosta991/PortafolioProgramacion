namespace CalculoDePrestaciones
{
    partial class CalculadoraPrestaciones
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
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.salaryGridView = new System.Windows.Forms.DataGridView();
            this.salrio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comisiones = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totales = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtSalario = new System.Windows.Forms.TextBox();
            this.txtComisiones = new System.Windows.Forms.TextBox();
            this.txtTotales = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.salaryPanel = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.gbPrestaciones = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.lblSalarioNavidad = new System.Windows.Forms.Label();
            this.chkIncluirSalarioNavidad = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblPagoTotal = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblIncluirCesantia = new System.Windows.Forms.Label();
            this.chkIncluirCesantia = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lblIncluirVacaciones = new System.Windows.Forms.Label();
            this.chkIncluirVacaciones = new System.Windows.Forms.CheckBox();
            this.lblSimboloMoneda3 = new System.Windows.Forms.Label();
            this.lblSalarioPromedioDiario = new System.Windows.Forms.Label();
            this.lblSalarioDiario = new System.Windows.Forms.Label();
            this.lblSimboloMoneda2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblPromedioMensual = new System.Windows.Forms.Label();
            this.lblSimboloMoneda1 = new System.Windows.Forms.Label();
            this.lblSumatoria = new System.Windows.Forms.Label();
            this.lblSUmatoriaSalarios = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.salaryGridView)).BeginInit();
            this.salaryPanel.SuspendLayout();
            this.gbPrestaciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpStartDate.Location = new System.Drawing.Point(620, 101);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(200, 20);
            this.dtpStartDate.TabIndex = 0;
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEndDate.Location = new System.Drawing.Point(620, 147);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(200, 20);
            this.dtpEndDate.TabIndex = 1;
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(560, 207);
            this.txtResult.Name = "txtResult";
            this.txtResult.ReadOnly = true;
            this.txtResult.Size = new System.Drawing.Size(272, 20);
            this.txtResult.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(241, 457);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(143, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Calcular Tiempo Contrato";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // salaryGridView
            // 
            this.salaryGridView.AllowUserToAddRows = false;
            this.salaryGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.salaryGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.salrio,
            this.comisiones,
            this.totales});
            this.salaryGridView.Location = new System.Drawing.Point(23, 270);
            this.salaryGridView.Name = "salaryGridView";
            this.salaryGridView.Size = new System.Drawing.Size(344, 150);
            this.salaryGridView.TabIndex = 4;
            // 
            // salrio
            // 
            this.salrio.HeaderText = "Salary";
            this.salrio.Name = "salrio";
            // 
            // comisiones
            // 
            this.comisiones.HeaderText = "Commissions";
            this.comisiones.Name = "comisiones";
            // 
            // totales
            // 
            this.totales.HeaderText = "Totals";
            this.totales.Name = "totales";
            // 
            // txtSalario
            // 
            this.txtSalario.Location = new System.Drawing.Point(73, 20);
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.Size = new System.Drawing.Size(139, 20);
            this.txtSalario.TabIndex = 5;
            this.txtSalario.Text = "0.00";
            // 
            // txtComisiones
            // 
            this.txtComisiones.Location = new System.Drawing.Point(73, 47);
            this.txtComisiones.Name = "txtComisiones";
            this.txtComisiones.Size = new System.Drawing.Size(139, 20);
            this.txtComisiones.TabIndex = 6;
            this.txtComisiones.Text = "0.00";
            // 
            // txtTotales
            // 
            this.txtTotales.Location = new System.Drawing.Point(73, 74);
            this.txtTotales.Name = "txtTotales";
            this.txtTotales.ReadOnly = true;
            this.txtTotales.Size = new System.Drawing.Size(139, 20);
            this.txtTotales.TabIndex = 7;
            this.txtTotales.Text = "0.00";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Salario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Comisiones";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Totales";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(96, 230);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 11;
            this.button2.Text = "Add";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // salaryPanel
            // 
            this.salaryPanel.Controls.Add(this.txtComisiones);
            this.salaryPanel.Controls.Add(this.txtSalario);
            this.salaryPanel.Controls.Add(this.label3);
            this.salaryPanel.Controls.Add(this.txtTotales);
            this.salaryPanel.Controls.Add(this.label2);
            this.salaryPanel.Controls.Add(this.label1);
            this.salaryPanel.Location = new System.Drawing.Point(12, 127);
            this.salaryPanel.Name = "salaryPanel";
            this.salaryPanel.Size = new System.Drawing.Size(234, 100);
            this.salaryPanel.TabIndex = 12;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(35, 457);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(148, 23);
            this.button3.TabIndex = 13;
            this.button3.Text = "Calcular prestaciones";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // gbPrestaciones
            // 
            this.gbPrestaciones.Controls.Add(this.label8);
            this.gbPrestaciones.Controls.Add(this.lblSalarioNavidad);
            this.gbPrestaciones.Controls.Add(this.chkIncluirSalarioNavidad);
            this.gbPrestaciones.Controls.Add(this.label5);
            this.gbPrestaciones.Controls.Add(this.lblPagoTotal);
            this.gbPrestaciones.Controls.Add(this.label7);
            this.gbPrestaciones.Controls.Add(this.lblIncluirCesantia);
            this.gbPrestaciones.Controls.Add(this.chkIncluirCesantia);
            this.gbPrestaciones.Controls.Add(this.label6);
            this.gbPrestaciones.Controls.Add(this.lblIncluirVacaciones);
            this.gbPrestaciones.Controls.Add(this.chkIncluirVacaciones);
            this.gbPrestaciones.Controls.Add(this.lblSimboloMoneda3);
            this.gbPrestaciones.Controls.Add(this.lblSalarioPromedioDiario);
            this.gbPrestaciones.Controls.Add(this.lblSalarioDiario);
            this.gbPrestaciones.Controls.Add(this.lblSimboloMoneda2);
            this.gbPrestaciones.Controls.Add(this.label4);
            this.gbPrestaciones.Controls.Add(this.lblPromedioMensual);
            this.gbPrestaciones.Controls.Add(this.lblSimboloMoneda1);
            this.gbPrestaciones.Controls.Add(this.lblSumatoria);
            this.gbPrestaciones.Controls.Add(this.lblSUmatoriaSalarios);
            this.gbPrestaciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbPrestaciones.Location = new System.Drawing.Point(406, 255);
            this.gbPrestaciones.Name = "gbPrestaciones";
            this.gbPrestaciones.Size = new System.Drawing.Size(518, 225);
            this.gbPrestaciones.TabIndex = 14;
            this.gbPrestaciones.TabStop = false;
            this.gbPrestaciones.Text = "Prestaciones";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(367, 84);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 13);
            this.label8.TabIndex = 31;
            this.label8.Text = "RD$";
            // 
            // lblSalarioNavidad
            // 
            this.lblSalarioNavidad.AutoSize = true;
            this.lblSalarioNavidad.Location = new System.Drawing.Point(405, 84);
            this.lblSalarioNavidad.Name = "lblSalarioNavidad";
            this.lblSalarioNavidad.Size = new System.Drawing.Size(32, 13);
            this.lblSalarioNavidad.TabIndex = 30;
            this.lblSalarioNavidad.Text = "0.00";
            // 
            // chkIncluirSalarioNavidad
            // 
            this.chkIncluirSalarioNavidad.AutoSize = true;
            this.chkIncluirSalarioNavidad.Location = new System.Drawing.Point(335, 64);
            this.chkIncluirSalarioNavidad.Name = "chkIncluirSalarioNavidad";
            this.chkIncluirSalarioNavidad.Size = new System.Drawing.Size(173, 17);
            this.chkIncluirSalarioNavidad.TabIndex = 29;
            this.chkIncluirSalarioNavidad.Text = "Incluir Salario de Navidad";
            this.chkIncluirSalarioNavidad.UseVisualStyleBackColor = true;
            this.chkIncluirSalarioNavidad.CheckStateChanged += new System.EventHandler(this.chkIncluirSalarioNavidad_CheckStateChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(113, 173);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 13);
            this.label5.TabIndex = 28;
            this.label5.Text = "Total a Recibir.:";
            // 
            // lblPagoTotal
            // 
            this.lblPagoTotal.AutoSize = true;
            this.lblPagoTotal.Location = new System.Drawing.Point(208, 173);
            this.lblPagoTotal.Name = "lblPagoTotal";
            this.lblPagoTotal.Size = new System.Drawing.Size(32, 13);
            this.lblPagoTotal.TabIndex = 27;
            this.lblPagoTotal.Text = "0.00";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(208, 84);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 13);
            this.label7.TabIndex = 26;
            this.label7.Text = "RD$";
            // 
            // lblIncluirCesantia
            // 
            this.lblIncluirCesantia.AutoSize = true;
            this.lblIncluirCesantia.Location = new System.Drawing.Point(246, 84);
            this.lblIncluirCesantia.Name = "lblIncluirCesantia";
            this.lblIncluirCesantia.Size = new System.Drawing.Size(32, 13);
            this.lblIncluirCesantia.TabIndex = 25;
            this.lblIncluirCesantia.Text = "0.00";
            // 
            // chkIncluirCesantia
            // 
            this.chkIncluirCesantia.AutoSize = true;
            this.chkIncluirCesantia.Location = new System.Drawing.Point(176, 64);
            this.chkIncluirCesantia.Name = "chkIncluirCesantia";
            this.chkIncluirCesantia.Size = new System.Drawing.Size(116, 17);
            this.chkIncluirCesantia.TabIndex = 24;
            this.chkIncluirCesantia.Text = "Incluir Cesantía";
            this.chkIncluirCesantia.UseVisualStyleBackColor = true;
            this.chkIncluirCesantia.CheckStateChanged += new System.EventHandler(this.chkIncluirCesantia_CheckStateChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(40, 84);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 23;
            this.label6.Text = "RD$";
            // 
            // lblIncluirVacaciones
            // 
            this.lblIncluirVacaciones.AutoSize = true;
            this.lblIncluirVacaciones.Location = new System.Drawing.Point(78, 84);
            this.lblIncluirVacaciones.Name = "lblIncluirVacaciones";
            this.lblIncluirVacaciones.Size = new System.Drawing.Size(32, 13);
            this.lblIncluirVacaciones.TabIndex = 22;
            this.lblIncluirVacaciones.Text = "0.00";
            // 
            // chkIncluirVacaciones
            // 
            this.chkIncluirVacaciones.AutoSize = true;
            this.chkIncluirVacaciones.Location = new System.Drawing.Point(18, 64);
            this.chkIncluirVacaciones.Name = "chkIncluirVacaciones";
            this.chkIncluirVacaciones.Size = new System.Drawing.Size(131, 17);
            this.chkIncluirVacaciones.TabIndex = 21;
            this.chkIncluirVacaciones.Text = "Incluir Vacaciones";
            this.chkIncluirVacaciones.UseVisualStyleBackColor = true;
            this.chkIncluirVacaciones.CheckStateChanged += new System.EventHandler(this.chkIncluirVacaciones_CheckStateChanged);
            // 
            // lblSimboloMoneda3
            // 
            this.lblSimboloMoneda3.AutoSize = true;
            this.lblSimboloMoneda3.Location = new System.Drawing.Point(341, 29);
            this.lblSimboloMoneda3.Name = "lblSimboloMoneda3";
            this.lblSimboloMoneda3.Size = new System.Drawing.Size(32, 13);
            this.lblSimboloMoneda3.TabIndex = 19;
            this.lblSimboloMoneda3.Text = "RD$";
            // 
            // lblSalarioPromedioDiario
            // 
            this.lblSalarioPromedioDiario.AutoSize = true;
            this.lblSalarioPromedioDiario.Location = new System.Drawing.Point(377, 29);
            this.lblSalarioPromedioDiario.Name = "lblSalarioPromedioDiario";
            this.lblSalarioPromedioDiario.Size = new System.Drawing.Size(32, 13);
            this.lblSalarioPromedioDiario.TabIndex = 20;
            this.lblSalarioPromedioDiario.Text = "0.00";
            // 
            // lblSalarioDiario
            // 
            this.lblSalarioDiario.AutoSize = true;
            this.lblSalarioDiario.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalarioDiario.Location = new System.Drawing.Point(332, 16);
            this.lblSalarioDiario.Name = "lblSalarioDiario";
            this.lblSalarioDiario.Size = new System.Drawing.Size(139, 13);
            this.lblSalarioDiario.TabIndex = 17;
            this.lblSalarioDiario.Text = "Salario Promedio Diario";
            // 
            // lblSimboloMoneda2
            // 
            this.lblSimboloMoneda2.AutoSize = true;
            this.lblSimboloMoneda2.Location = new System.Drawing.Point(173, 29);
            this.lblSimboloMoneda2.Name = "lblSimboloMoneda2";
            this.lblSimboloMoneda2.Size = new System.Drawing.Size(32, 13);
            this.lblSimboloMoneda2.TabIndex = 17;
            this.lblSimboloMoneda2.Text = "RD$";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(161, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(153, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Salario Promedio Mensual";
            // 
            // lblPromedioMensual
            // 
            this.lblPromedioMensual.AutoSize = true;
            this.lblPromedioMensual.Location = new System.Drawing.Point(208, 29);
            this.lblPromedioMensual.Name = "lblPromedioMensual";
            this.lblPromedioMensual.Size = new System.Drawing.Size(32, 13);
            this.lblPromedioMensual.TabIndex = 18;
            this.lblPromedioMensual.Text = "0.00";
            // 
            // lblSimboloMoneda1
            // 
            this.lblSimboloMoneda1.AutoSize = true;
            this.lblSimboloMoneda1.Location = new System.Drawing.Point(24, 29);
            this.lblSimboloMoneda1.Name = "lblSimboloMoneda1";
            this.lblSimboloMoneda1.Size = new System.Drawing.Size(32, 13);
            this.lblSimboloMoneda1.TabIndex = 15;
            this.lblSimboloMoneda1.Text = "RD$";
            // 
            // lblSumatoria
            // 
            this.lblSumatoria.AutoSize = true;
            this.lblSumatoria.Location = new System.Drawing.Point(59, 29);
            this.lblSumatoria.Name = "lblSumatoria";
            this.lblSumatoria.Size = new System.Drawing.Size(32, 13);
            this.lblSumatoria.TabIndex = 16;
            this.lblSumatoria.Text = "0.00";
            // 
            // lblSUmatoriaSalarios
            // 
            this.lblSUmatoriaSalarios.AutoSize = true;
            this.lblSUmatoriaSalarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSUmatoriaSalarios.Location = new System.Drawing.Point(15, 16);
            this.lblSUmatoriaSalarios.Name = "lblSUmatoriaSalarios";
            this.lblSUmatoriaSalarios.Size = new System.Drawing.Size(130, 13);
            this.lblSUmatoriaSalarios.TabIndex = 15;
            this.lblSUmatoriaSalarios.Text = "Sumatoria de Salarios";
            // 
            // CalculadoraPrestaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(936, 492);
            this.Controls.Add(this.gbPrestaciones);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.salaryPanel);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.salaryGridView);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.dtpEndDate);
            this.Controls.Add(this.dtpStartDate);
            this.Name = "CalculadoraPrestaciones";
            this.Text = "Calculadora de Prestaciones";
            this.Load += new System.EventHandler(this.CalculadoraPrestaciones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.salaryGridView)).EndInit();
            this.salaryPanel.ResumeLayout(false);
            this.salaryPanel.PerformLayout();
            this.gbPrestaciones.ResumeLayout(false);
            this.gbPrestaciones.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView salaryGridView;
        private System.Windows.Forms.TextBox txtSalario;
        private System.Windows.Forms.TextBox txtComisiones;
        private System.Windows.Forms.TextBox txtTotales;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewTextBoxColumn salrio;
        private System.Windows.Forms.DataGridViewTextBoxColumn comisiones;
        private System.Windows.Forms.DataGridViewTextBoxColumn totales;
        private System.Windows.Forms.Panel salaryPanel;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.GroupBox gbPrestaciones;
        private System.Windows.Forms.Label lblSimboloMoneda3;
        private System.Windows.Forms.Label lblSalarioPromedioDiario;
        private System.Windows.Forms.Label lblSalarioDiario;
        private System.Windows.Forms.Label lblSimboloMoneda2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblPromedioMensual;
        private System.Windows.Forms.Label lblSimboloMoneda1;
        private System.Windows.Forms.Label lblSumatoria;
        private System.Windows.Forms.Label lblSUmatoriaSalarios;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblIncluirCesantia;
        private System.Windows.Forms.CheckBox chkIncluirCesantia;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblIncluirVacaciones;
        private System.Windows.Forms.CheckBox chkIncluirVacaciones;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblPagoTotal;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblSalarioNavidad;
        private System.Windows.Forms.CheckBox chkIncluirSalarioNavidad;
    }
}

