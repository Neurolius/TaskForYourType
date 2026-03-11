namespace TaskForYourType
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }

    public class Vector
    {
        private int X, Y, Z;
        public Vector(int x, int y, int z)
        {
            X = x;
            Y = y;
            Z = z;
        }
        public Vector Sum(Vector v) { 
            Vector result = new Vector(this.X+v.X, this.Y+v.Y, this.Z+v.Z);
            return result;
        }

        public Vector Sub(Vector v) {
            Vector result = new Vector(this.X-v.X, this.Y-v.Y, this.Z-v.Z);
            return result;
        }

        public int Dot(Vector v) { 
            int result = this.X*v.X + this.Y+v.Y + this.Z*v.Z;
            return result;
            
        }

        public double Lenght() { 
            double result = Math.Sqrt(X*X + Y*Y + Z + Z);
            return result;
        }

        public Vector Cross(Vector v) {
            Vector result = new Vector(this.Y * v.Z - this.Z * v.Y, this.Z*v.X - this.X*v.Z, this.X*v.Y - this.Y*v.X);
            return result;
        }
    }
}
