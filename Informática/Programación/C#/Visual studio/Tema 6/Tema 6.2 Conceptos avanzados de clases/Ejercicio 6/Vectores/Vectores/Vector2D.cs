class Vector2D
{
    private double x;
    private double y;

    public Vector2D(double x, double y)
    {
        this.x = x;
        this.y = y;
    }      
    
    public static Vector2D operator +(Vector2D v1, Vector2D v2)
    {
        Vector2D v3 = new Vector2D(v1.x + v2.x, v1.y + v2.y);
        return v3;
    }

    public override string ToString()
    {
        return "(" + x + ", " + y + ")";
    }
}

