﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.IO.Ports;
using System.Numerics;
using System.Diagnostics;


namespace ProyectoSenales
{
    public partial class MainForm : Form
    {

        private const int NUMERO_MUESTRAS = 4096;//4096;

        private Random random = new Random();

        SerialPort port = new SerialPort(Configuracion.puertoCOM);
        // SerialPort fakePort = new SerialPort("COM2");               

        public MainForm()
        {
            InitializeComponent();            

            // Permite modificar los componentes desde hilos separados
            CheckForIllegalCrossThreadCalls = false;
            // Remueve el label del chart
            testChart.Series["datos"].IsVisibleInLegend = false;
            testChart.ChartAreas[0].CursorX.IsUserEnabled = true;
            testChart.ChartAreas[0].CursorX.IsUserSelectionEnabled = true;
            testChart.ChartAreas[0].CursorY.IsUserEnabled = true;
            // Se establece el maximo valor para la barra de progreso
            grabacionProgressBar.Maximum = NUMERO_MUESTRAS;

            port.BaudRate = 115200;

            port.NewLine = "\n";
            
        }
      
        private void button1_Click(object sender, EventArgs e)
        {
            // Crea una lista de muestras con los valores de las muestras
            Muestra[] muestrasArray = new Muestra[NUMERO_MUESTRAS];
            // List<Muestra> muestrasList = new List<Muestra>();
            // Deshabilita el boton para evitar hacer mas de un click
            startButton.Enabled = false;
            // Muestra la barra de progreso
            grabacionProgressBar.Visible = true;
            // Borra las series anteriores de la grafica (si existen)
            testChart.Series["datos"].Points.Clear();

            /*Thread fakeInfo = new Thread(()=>
            {
                while (true)
                {
                    fakePort.Write($"{random.Next(0, 1024)}\n");
                }                
            });*/

            // Creacion del hilo de muestreo
            Thread thread = new Thread(()=>
            {
                // fakeInfo.Start();
                int muestras = 0;
                while (muestras < NUMERO_MUESTRAS)
                {                
                    // Añadir un punto con los valores recibidos
                    // muestras va de 0 a NUMERO_MUESTRAS
                    // TODO: reemplazar random con lectura de arduino
                    string var = port.ReadLine();
                    if (Double.TryParse(var, out double varDouble))
                    {
                        Console.WriteLine(varDouble);
                        Console.WriteLine(Double.Parse(var.Trim()));
                        muestrasArray[muestras] = new Muestra(muestras, varDouble);
                        // muestrasList.Add(new Muestra(muestras, Math.Sin(muestras) /*random.Next(0, 1024)*/));
                        // Incrementar el valor del progreso                    
                        grabacionProgressBar.Value++;
                        muestras++;
                    }                                        
                }
                // Borra el progreso
                grabacionProgressBar.Value = 0;
                // Y esconde la barra de progreso
                grabacionProgressBar.Visible = false;
            });            

            // Empezar el hilo
            Stopwatch stopwatch = new Stopwatch();
            // fakePort.Open();
            port.Open();            
            stopwatch.Start();            
            thread.Start();            
            // Esperar hasta que el hilo acabe
            thread.Join();
            stopwatch.Stop();
            port.Close();
            Console.WriteLine(stopwatch.Elapsed);

            startButton.Enabled = true;            

            Complex[] com_array = new Complex[muestrasArray.Length];

            for (int i = 0; i < com_array.Length; i++)
            {
                com_array[i] = muestrasArray[i].complejo;
            }

            FFT.FFT_Calc(com_array);

            for (int i = 0; i < com_array.Length; i++)
            {
                if (i == 0)
                {
                    muestrasArray[i].complejo = 0.0;
                    testChart.Series["datos"].Points.AddXY(i, 0.0);
                }
                else
                {
                    muestrasArray[i].complejo = com_array[i];
                    testChart.Series["datos"].Points.AddXY(i, com_array[i].Magnitude);
                }                
            }
            
            foreach (Complex complejo in com_array)
            {
                // Console.WriteLine(complejo.Magnitude);
            }

            //muestrasList.ForEach(Console.WriteLine);
        }

        private void establecerFrecuenciasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConfigurationForm configForm = new ConfigurationForm();            
            configForm.ShowDialog();            
        }
    }
}