using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistanceConverter.Views;

public partial class WeightPage : ContentPage
{
    private double KeyValue = 0;
    
    private double dbl_g2k = 1000;
    private double dbl_g2g = 1;
    private double dbl_g2oz = 28.34942313;
    private double dbl_g2p = 500;

    
    public WeightPage()
    {
        InitializeComponent();
        Title = "Weight Converter";
    }

    private void Clear_OnClicked(object sender, EventArgs e)
    {
        txtGrams.Text = "";
        txtKilograms.Text = "";
        txtOunces.Text = "";
        txtPounds.Text = "";
    }

    private void Convert_OnClicked(object sender, EventArgs e)
    {
        txtGrams.Text = (KeyValue / dbl_g2g).ToString("G9");
        txtKilograms.Text = (KeyValue / dbl_g2k).ToString("G9");
        txtOunces.Text = (KeyValue / dbl_g2oz).ToString("G9");
        txtPounds.Text = (KeyValue / dbl_g2p).ToString("G9");
    }

    private void TxtGrams_OnTextChanged(object sender, TextChangedEventArgs e)
    {
        //g2g
        double dblNumber;
        var isValid = Double.TryParse(txtGrams.Text, out dblNumber);

        if (isValid && dblNumber != 0)
        {
            KeyValue = dblNumber / dbl_g2g;
        }
        else
        {
            KeyValue = 0;
        }
    }

    private void TxtKilograms_OnTextChanged(object sender, TextChangedEventArgs e)
    {
        //g2k
        double dblNumber;
        var isValid = Double.TryParse(txtKilograms.Text, out dblNumber);

        if (isValid && dblNumber != 0)
        {
            KeyValue = dblNumber / dbl_g2k;
        }
        else
        {
            KeyValue = 0;
        }
    }

    private void TxtOunces_OnTextChanged(object sender, TextChangedEventArgs e)
    {
        //g2o
        double dblNumber;
        var isValid = Double.TryParse(txtOunces.Text, out dblNumber);

        if (isValid && dblNumber != 0)
        {
            KeyValue = dblNumber / dbl_g2oz;
        }
        else
        {
            KeyValue = 0;
        }
    }

    private void TxtPounds_OnTextChanged(object sender, TextChangedEventArgs e)
    {
        //g2p
        double dblNumber;
        var isValid = Double.TryParse(txtPounds.Text, out dblNumber);

        if (isValid && dblNumber != 0)
        {
            KeyValue = dblNumber / dbl_g2p;
        }
        else
        {
            KeyValue = 0;
        }
    }
}