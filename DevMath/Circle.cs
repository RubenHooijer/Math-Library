namespace DevMath
{
    public class Circle
    {
        public Vector2 Position
        {
            get; set;
        }

        public float Radius
        {
            get; set;
        }

        public bool CollidesWith(Circle circle)
        {
            float dx = Position.x - circle.Position.x;
            float dy = Position.y - circle.Position.y;
            float radius = Radius + circle.Radius;

            return ((dx * dx) + (dy * dy) < radius * radius);
        }
    }
}
