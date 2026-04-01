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

        private void Vect1X_TextChanged(object sender, EventArgs e)
        {
            Recalculate();
        }

        private void Vect1Y_TextChanged(object sender, EventArgs e)
        {
            Recalculate();
        }

        private void Vect1Z_TextChanged(object sender, EventArgs e)
        {
            Recalculate();
        }

        private void Vect2X_TextChanged(object sender, EventArgs e)
        {
            Recalculate();
        }

        private void Vect2Y_TextChanged(object sender, EventArgs e)
        {
            Recalculate();
        }

        private void Vect2Z_TextChanged(object sender, EventArgs e)
        {
            Recalculate();
        }

        private void Recalculate()
        {
            if (string.IsNullOrEmpty(Vect1X.Text) ||
                string.IsNullOrEmpty(Vect1Y.Text) ||
                string.IsNullOrEmpty(Vect1Z.Text) ||
                string.IsNullOrEmpty(Vect2X.Text) ||
                string.IsNullOrEmpty(Vect2Y.Text) ||
                string.IsNullOrEmpty(Vect2Z.Text))
            {
                return;
            }

            var v1 = new Vector(
                int.Parse(Vect1X.Text),
                int.Parse(Vect1Y.Text),
                int.Parse(Vect1Z.Text));

            var v2 = new Vector(
                int.Parse(Vect2X.Text),
                int.Parse(Vect2Y.Text),
                int.Parse(Vect2Z.Text));

            var sum = v1 + v2;
            SumRes.Text = $"Vector = ({sum.GetX()} , {sum.GetY()} , {sum.GetZ()})";

            var sub = v1 - v2;
            SubRes.Text = $"Vector = ({sub.GetX()} , {sub.GetY()} , {sub.GetZ()})";

            DotRes.Text = $"—кал€рное произведение = {v1 * v2}";

            var cross = v1 & v2;
            CrossRes.Text = $"Vector = ({cross.GetX()} , {cross.GetY()} , {cross.GetZ()})";

            LenVect1Res.Text = $"ƒлина вектора = {v1.Lenght()}";
            LenVect2Res.Text = $"ƒлина вектора = {v2.Lenght()}";
        }
    }

    public class Vector
    {
        private int X, Y, Z;

        public int GetX()
        {
            return X;
        }

        public int GetY()
        {
            return Y;
        }

        public int GetZ()
        {
            return Z;
        }

        public Vector(int x, int y, int z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        public static Vector operator +(Vector v1, Vector v2)
        {
            return new Vector(v1.X + v2.X, v1.Y + v2.Y, v1.Z + v2.Z);
        }

        public static Vector operator -(Vector v1, Vector v2)
        {
            return new Vector(v1.X - v2.X, v1.Y - v2.Y, v1.Z - v2.Z);
        }

        public static int operator *(Vector v1, Vector v2) {
            return v1.X * v2.X + v1.Y + v2.Y + v1.Z * v2.Z;
        }

        public static Vector operator &(Vector v1, Vector v2)
        {
            return new Vector(v1.Y * v2.Z - v1.Z * v2.Y, v1.Z * v2.X - v1.X * v2.Z, v1.X * v2.Y - v1.Y * v2.X);
        }

        public double Lenght()
        {
            double result = Math.Sqrt(X * X + Y * Y + Z + Z);
            return result;
        }

        public override bool Equals(object? obj)
        {
            if (obj is Vector other)
            {
                return X == other.X &&
                       Y == other.Y &&
                       Z == other.Z;
            }

            return false;
        }

    }
}
