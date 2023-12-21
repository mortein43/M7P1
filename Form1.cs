namespace M7P1;

public partial class Form1 : Form
{
    private Class1 db = new Class1();
    public Form1()
    {
        InitializeComponent();
        this.radioAllBuyers.Checked = true;
        this.comboCity.SelectedIndex = 0;
        this.comboCountry.SelectedIndex = 0;
        this.comboPromotionsForSpecificCountry.SelectedIndex = 0;
        db.PrintAllBuyers(this.dataGridView1);
    }

    private void radioAllBuyers_CheckedChanged(object sender, EventArgs e)
    {
        db.PrintAllBuyers(this.dataGridView1);
    }

    private void radioAllEmails_CheckedChanged(object sender, EventArgs e)
    {
        db.PrintAllEmails(this.dataGridView1);
    }

    private void radioSectionList_CheckedChanged(object sender, EventArgs e)
    {
        db.PrintAllDistinctSections(this.dataGridView1);
    }

    private void radioPromotionalProducts_CheckedChanged(object sender, EventArgs e)
    {
        db.PrintListOfPromotionalProducts(this.dataGridView1);
    }

    private void radioAllCities_CheckedChanged(object sender, EventArgs e)
    {
        db.PrintAllCities(this.dataGridView1);
    }

    private void radioButton1_CheckedChanged(object sender, EventArgs e)
    {
        db.PrintAllCountries(this.dataGridView1);
    }

    private void radioBuyersFromCity_CheckedChanged(object sender, EventArgs e)
    {
        db.PrintAllBuyersFromCertainCity(this.dataGridView1, this.comboCity.Text);
    }

    private void radioAllBuyersFromSpecificCountry_CheckedChanged(object sender, EventArgs e)
    {
        db.PrintAllBuyersFromSpecificCountry(this.dataGridView1, this.comboCountry.Text);
    }

    private void radioAllPromotionsForSpecificCountry_CheckedChanged(object sender, EventArgs e)
    {
        db.PrintAllPromotionsForSpecificCountry(this.dataGridView1, this.comboPromotionsForSpecificCountry.Text);
    }

}
