namespace WFA241120;

public partial class FrmAkasztofa : Form
{
    const string KEPEK_MAPPA = "D:\\PROJECTS\\WFA241120\\resources\\";

    public FrmAkasztofa()
    {
        InitializeComponent();
        pbAkasztofa.Image = Image.FromFile($"{KEPEK_MAPPA}akasztofa_00.png");
        tbxTipp.TextChanged += TbxTipp_TextChanged;
    }

    private void TbxTipp_TextChanged(object? sender, EventArgs e)
    {
        if (!string.IsNullOrEmpty(tbxTipp.Text))
        {
            char tipp = char.Parse(tbxTipp.Text.ToUpper());
            if (char.IsLetter(tipp))
            {
                lblEddigiTippek.Text += $"{tipp}, ";
                tbxTipp.Text = string.Empty;
            }
        }

    }
}
