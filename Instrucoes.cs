using System;

public class Instrucoes
{
    //byte Number;
    public short X;
    public short Y;
    public char Key;
    
    public Instrucoes(short X, short Y, char Key)
    {
        //this.Number = number;
        this.X = X;
        this.Y = Y;
        this.Key = Key;    
    }

    public string toString()
    {
        return string.Format("X = {0}, Y = {1}, Key = {2}", X, Y, Key);
    }
}
