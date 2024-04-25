namespace Shape{
    public abstract class ResizeableAndColortableShape : Shape, IResizeable, IColorable
    {
        public ResizeableAndColortableShape(String color, bool filled) : base(color, filled){}

        public ResizeableAndColortableShape(){}
        public abstract void Resize(double percent);

        public abstract void HowToColor();
    }
}