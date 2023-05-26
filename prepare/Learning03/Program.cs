using System;

class Program
{
    static void Main(string[] args)
    {
        var fraction1 = new Fraction (1,1);
        var fraction2 = new Fraction (5,1);
        var fraction3 = new Fraction (3,4);
        var fraction4 = new Fraction (1,3);

        fraction1.GetFractionString();
        fraction1.GetDecimalValue();
        fraction2.GetFractionString();
        fraction2.GetDecimalValue();
        fraction3.GetFractionString();
        fraction3.GetDecimalValue();
        fraction4.GetFractionString();
        fraction4.GetDecimalValue();
        


    }
}



public class Fraction {
    public float _top;
    public float _bottom;

    public int GetTop() {
        return _top;
    }

    public void SetBottom(int newBottom) {
        if (newBottom == 0) {
            _bottom = 1;
        }else {
            _bottom = newBottom;
        }
    }

    public Fraction (float top, float bottom){
        _top = top;
        _bottom = bottom;
    }

    public void GetFractionString (){
        Console.WriteLine ($"{_top}/{_bottom}");
    }

    public void GetDecimalValue () {
        float decimalfraction = _top/_bottom;
        Console.WriteLine ($"{decimalfraction}");
    }
}

