class Cylinder
{
    private Circle _circle;
    private double _height;
    public void SetHeight(double height)
    {
        _height = height;
    }
    public void SetCircle(Circle circle)
    {
        _circle = circle;
    }

    public double GetVolume()
    {
        double radius = _circle.GetRadius();
        return Math.PI * radius * radius * _height;
    }
}