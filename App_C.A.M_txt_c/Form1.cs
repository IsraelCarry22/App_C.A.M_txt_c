using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace App_C.A.M_txt_c
{
    public partial class Form1 : Form
    {
        string File_doc = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void Btmlimpiar_Click(object sender, EventArgs e)
        {
            Txtpagina.Clear();
            Txtpagina.Focus();
        }
        // evento que lee y abre un documento (.txt) con StreamReader
        private void Btmabrir_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Archivo de texto|*.txt";
            if (open.ShowDialog() == DialogResult.OK)
            {
                File_doc = open.FileName;
                StreamReader leer = new StreamReader(open.FileName);
                Txtpagina.Text = leer.ReadToEnd();
                leer.Close();
            }
        }
        // evento que crea y escribe un documento (.txt) con StreamWriter
        private void Btmguardar_Click(object sender, EventArgs e)
        {
            if (File_doc == "")
            {
                Btmguardarcomo_Click(sender,e);
            }
            else
            {
                StreamWriter escribir = new StreamWriter(File_doc);
                escribir.Write(Txtpagina.Text);
                escribir.Close();
            }
        }
        // evento que crea un (documento) de otro tipo de extencion
        private void Btmguardarcomo_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "Archivo de texto|*.txt";
            if (save.ShowDialog() == DialogResult.OK)
            {
                File_doc = save.FileName;
                StreamWriter escribir = new StreamWriter(save.FileName);
                escribir.Write(Txtpagina.Text);
                escribir.Close();
            }
        }
    }
}
