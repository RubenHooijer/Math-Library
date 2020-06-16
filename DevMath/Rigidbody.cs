namespace DevMath
{
    //NOTE: This class only updates the Velocity variable
    public class Rigidbody
    {
        public Vector2 Velocity
        {
            get; private set;
        }

        public float mass = 1.0f;
        public float force = 150.0f;
        public float dragCoefficient = .47f;

        public void AddForce(Vector2 forceDirection, float deltaTime)
        {
            Velocity = (1 / dragCoefficient) * (float)Math.Exp(-dragCoefficient / mass * deltaTime) * (dragCoefficient * Velocity + forceDirection) - (forceDirection / dragCoefficient);
        }
    }
}
