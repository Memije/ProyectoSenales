﻿namespace ProyectoSenales
{
    partial class MainForm
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.grabacionProgressBar = new System.Windows.Forms.ProgressBar();
            this.testChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.generoPictureBox = new System.Windows.Forms.PictureBox();
            this.startButton = new System.Windows.Forms.Button();
            this.vocalPictureBox = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.testChart)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.generoPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vocalPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.grabacionProgressBar);
            this.groupBox1.Controls.Add(this.testChart);
            this.groupBox1.Location = new System.Drawing.Point(12, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(689, 404);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Gráfica de la señal";
            // 
            // grabacionProgressBar
            // 
            this.grabacionProgressBar.Location = new System.Drawing.Point(6, 19);
            this.grabacionProgressBar.Name = "grabacionProgressBar";
            this.grabacionProgressBar.Size = new System.Drawing.Size(672, 10);
            this.grabacionProgressBar.TabIndex = 0;
            this.grabacionProgressBar.Visible = false;
            // 
            // testChart
            // 
            chartArea1.Name = "ChartArea1";
            this.testChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.testChart.Legends.Add(legend1);
            this.testChart.Location = new System.Drawing.Point(6, 35);
            this.testChart.Name = "testChart";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "datos";
            this.testChart.Series.Add(series1);
            this.testChart.Size = new System.Drawing.Size(672, 353);
            this.testChart.TabIndex = 0;
            this.testChart.Text = "chart1";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.Window;
            this.groupBox2.Controls.Add(this.vocalPictureBox);
            this.groupBox2.Location = new System.Drawing.Point(707, 63);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(291, 199);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Vocal";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.generoPictureBox);
            this.groupBox3.Location = new System.Drawing.Point(707, 268);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(291, 199);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Género";
            // 
            this.generoPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.generoPictureBox.Location = new System.Drawing.Point(6, 19);
            this.generoPictureBox.Name = "generoPictureBox";
            this.generoPictureBox.Size = new System.Drawing.Size(279, 174);
            this.generoPictureBox.TabIndex = 0;
            this.generoPictureBox.TabStop = false;
            // startButton
            // 
            this.startButton.FlatAppearance.BorderSize = 0;
            this.startButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startButton.Image = global::ProyectoSenales.Properties.Resources.record;
            this.startButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.startButton.Location = new System.Drawing.Point(12, 12);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(204, 45);
            this.startButton.TabIndex = 3;
            this.startButton.Text = "Iniciar Grabación";
            this.startButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // vocalPictureBox
            // 
            this.vocalPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.vocalPictureBox.Location = new System.Drawing.Point(6, 19);
            this.vocalPictureBox.Name = "vocalPictureBox";
            this.vocalPictureBox.Size = new System.Drawing.Size(279, 174);
            this.vocalPictureBox.TabIndex = 0;
            this.vocalPictureBox.TabStop = false;
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1010, 477);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "MainForm";
            this.Text = "Reconocedor de Vocales";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.testChart)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.generoPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vocalPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.ProgressBar grabacionProgressBar;
        private System.Windows.Forms.DataVisualization.Charting.Chart testChart;
        private System.Windows.Forms.PictureBox vocalPictureBox;
        private System.Windows.Forms.PictureBox generoPictureBox;
    }
}

