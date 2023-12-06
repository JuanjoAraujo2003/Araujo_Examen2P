namespace JuanAraujoB_ExamenProgreso2.Views;

public partial class JA_Conteo : ContentPage
{
    public JA_Conteo()
    {
        InitializeComponent();
    }

    private void CalcularClicked(object sender, EventArgs e)
    {
        string input = inputEntry.Text;

        int numeros = 0;
        int letras = 0;
        int vocales = 0;
        int mayusculas = 0;
        int minusculas = 0;
        int totalCaracteres = input.Length;

        foreach (char caracter in input)
        {
            if (char.IsDigit(caracter))
                numeros++;
            else if (char.IsLetter(caracter))
            {
                letras++;
                if ("aeiouAEIOU".IndexOf(caracter) != -1)
                    vocales++;
                if (char.IsUpper(caracter))
                    mayusculas++;
                else
                    minusculas++;
            }
        }

        
        numerosLabel.Text = $"Números: {numeros}";
        letrasLabel.Text = $"Letras: {letras}";
        vocalesLabel.Text = $"Vocales: {vocales}";
        mayusculasLabel.Text = $"Mayúsculas: {mayusculas}";
        minusculasLabel.Text = $"Minúsculas: {minusculas}";
        totalLabel.Text = $"Total: {totalCaracteres}";
    }

    private void LimpiarClicked(object sender, EventArgs e)
    {
        numerosLabel.Text = "";
        letrasLabel.Text = "";
        vocalesLabel.Text = "";
        mayusculasLabel.Text = "";
        minusculasLabel.Text = "";
        totalLabel.Text = "";
    }
}