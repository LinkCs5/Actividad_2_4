using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Actividad_2_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void SelecMetodo(object sender, EventArgs e)
        {
            SeleccionarMetodo();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void NumeroTotal(object sender, EventArgs e)
        {

        }

        private void primer_valor_TextChanged(object sender, EventArgs e)
        {
            Factorial  miFactorial= new Factorial();
            Fibonacci miFibonacci = new Fibonacci();
            MCD miMcd = new MCD();


            if (seleccionarMetodo.SelectedIndex == 0)
            {
                if (long.TryParse(primer_valor.Text, out long numero) && numero >= 0)
                {
                    long factorial = miFactorial.CalcularFactorial(numero);

                    total_numero.Text = factorial.ToString();
                }
                else
                {
                    MessageBox.Show("Ingrese un número entero no negativo válido.");
                }

            }
            else if (seleccionarMetodo.SelectedIndex == 1)
            {
                if(int.TryParse(primer_valor.Text,out int n)&& n >= 0)
                {
                    string fibonacciSeries = miFibonacci.CalcularFibonacci(n);
                    total_numero.Text = fibonacciSeries.ToString();
                }
                else
                {
                    MessageBox.Show("Ingrese un número entero no negativo válido.");
                }
            }
            else if (seleccionarMetodo.SelectedIndex == 2)
            {
                if(int.TryParse(primer_valor.Text,out int numero1)&& int.TryParse(segundo_valor.Text, out int numero2))
                {
                    int mcd = miMcd.CalcularMCD(numero1,numero2);

                    total_numero.Text = mcd.ToString();
                }
                else
                {
                    MessageBox.Show("Ingrese un número entero no negativo vákido.");
                }
            }
        }

        private void text_cambiante_Click(object sender, EventArgs e)
        {

        }





        private void SeleccionarMetodo()
        {
            if(seleccionarMetodo.SelectedIndex == 0)
            {
                segundo_valor.Visible = false;
                text_cambiante.Text = "Ingrese un número entero no negativo: ";
                label1.Text = "El factorial es: ";
      

            }
            else if(seleccionarMetodo.SelectedIndex == 1)
            {
                segundo_valor.Visible = false;
                text_cambiante.Text = "Fibonacci";
                label1.Text = "El Fibonacci es: ";

            }
            else if(seleccionarMetodo.SelectedIndex == 2)
            {
                segundo_valor.Visible = true;
                text_cambiante.Text = "Máximo Común Divisor";
                label1.Text = "El MCD es: ";

            }
        }
    }
}

public class Factorial
{
    public long CalcularFactorial(long n)
    {
        if (n == 0)
        {
            return 1;
        }
        else
        {
            return n * CalcularFactorial(n - 1);

        }
    }
}

public class Fibonacci
{
    public string CalcularFibonacci(int n)
    {
        if (n == 0)
        {
            return "0";
        }
        if (n == 1)
        {
            return "0,1";
        }
        long a = 0, b = 1;
        string series = "0,1";
        for (int i = 2; i <= n; i++)
        {
            long temp = a + b;
            a = b;
            b = temp;
            series += $",{temp}";

        }
        return series;
    }

}

public class MCD
{
    public int CalcularMCD(int a, int b)
    {
        if(b == 0)
          return a;

            return CalcularMCD(b, a % b);
        

    }

}