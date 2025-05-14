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


namespace _30_04_25_WindowsFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCrearFicheros_Click(object sender, EventArgs e)
        {
            // StreamWrite es la clase que representa a un fichero de texto
            //en el que podemos escribir informacion
            //El fichero de texto lo creamos en el metodo (Estatico)CreateText,
            //que pertenece a la clase File
            //Paea escribir en el fichero de texto, utilizamos el metodo WriteLine
            //Close para cerrar el archivo,o podria quedar algun dato
            //sin guardar

            StreamWriter fichero;
            fichero = File.CreateText("fichero1.txt");
            fichero.WriteLine("Hola este es mi primer ficher");
            fichero.Write("Siguiente linea");
            fichero.Write("\r\n");
            fichero.WriteLine("Parte de la linea anterir");
            fichero.Close();
        }

        private void btnForma2Crear_Click(object sender, EventArgs e)
        {
            using(StreamWriter fichero = new StreamWriter("fichero1.txt"))
            {
                fichero.WriteLine("Hola este es mi segundo fichero");
                fichero.WriteLine("Carolina");
                fichero.WriteLine("jimena");

            }
        }

        private void btnLeerArchivo1_Click(object sender, EventArgs e)
        {
            StreamReader fichero;
            string linea;
            fichero = File.OpenText("fichero1.txt");
            linea = fichero.ReadLine();
            Console.WriteLine(linea);

            fichero.Close();

        }

        private void btnLeerArchivo3_Click(object sender, EventArgs e)
        {
            //archivofinal
            StreamReader fichero;
            fichero = File.OpenText("fichero1.txt");
            while (!fichero.EndOfStream)
               
                Console.WriteLine(fichero.ReadLine());
            fichero.Close();

        }

        private void btnLeerArchivo2_Click(object sender, EventArgs e)
        {
            StreamReader fichero;
            string linea;
            fichero = File.OpenText("fichero1.txt");
            do
            {
                linea = fichero.ReadLine();
                if (linea != null)
                {
                    Console.WriteLine(linea);
                }
            }
            while (linea != null);
            fichero.Close();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            StreamWriter fichero;

            fichero = File.CreateText("fichero2.txt");
            fichero.WriteLine("Primera linea");
            fichero.Close();

            fichero = File.AppendText("fichero2.txt");
            fichero.WriteLine("Segunda linea");
            fichero.Close();

        }

        private void btnLeerArchivo4_Click(object sender, EventArgs e)
        {
            using (StreamReader fichero = new StreamReader("fichero2.txt"))
            {
                string linea;
                linea = fichero.ReadLine();
                Console.WriteLine(linea);
                Console.WriteLine(fichero.ReadLine());
                Console.WriteLine(fichero.ReadLine());


            }
        }
        
    }
}
