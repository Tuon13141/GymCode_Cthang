namespace Shape{
    public abstract class ResizeableShape : Shape, IResizeable
    {
        public ResizeableShape(String color, bool filled) : base(color, filled){}

        public ResizeableShape(){}
        public abstract void Resize(double percent);
    }
}