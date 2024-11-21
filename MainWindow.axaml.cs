using System;
using Avalonia.Controls;
using Avalonia.Interactivity;

namespace Calculadora;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private void Escribir(object? sender, RoutedEventArgs e)
    {
        if (sender != null)
        {
            var boton = (Button)sender;

            string numero = (string)boton.Content!;


            TextBlockResultado.Text += $"{numero}";
        }
    }

    private void Signos(object? sender, RoutedEventArgs e)
    {
        if (sender != null)
        {
            var boton = (Button)sender;

            string signo = boton.Content!.ToString()!;


            TextBlockResultado.Text += $" {signo} ";
        }
    }

    private void Limpiar(object? sender, RoutedEventArgs e)
    {
        TextBlockResultado.Text = "";
    }

    private void Resolver(object? sender, RoutedEventArgs e)
    {
        var numeros = TextBlockResultado.Text!.Split(" ");

        if (TextBlockResultado.Text.Contains("\u00f7"))
        {
            float mostrar = (Int32.Parse(numeros[0])) / (Int32.Parse(numeros[2]));
            TextBlockResultado.Text = $"{mostrar}";
        }

        if (TextBlockResultado.Text.Contains("+"))
        {
            float mostrar = (Int32.Parse(numeros[0])) + (Int32.Parse(numeros[2]));
            TextBlockResultado.Text = $"{mostrar}";
        }

        if (TextBlockResultado.Text.Contains("-"))
        {
            float mostrar = (Int32.Parse(numeros[0])) - (Int32.Parse(numeros[2]));
            TextBlockResultado.Text = $"{mostrar}";
        }

        if (TextBlockResultado.Text.Contains("x"))
        {
            float mostrar = (Int32.Parse(numeros[0])) * (Int32.Parse(numeros[2]));
            TextBlockResultado.Text = $"{mostrar}";
        }
    }
}