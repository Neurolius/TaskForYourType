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

        private void Sum_Click(object sender, EventArgs e)
        {
            Vector Vect1 = new Vector(
                int.Parse(Vect1X.Text),
                int.Parse(Vect1Y.Text),
                int.Parse(Vect1Z.Text)
                );
            Vector Vect2 = new Vector(
                int.Parse(Vect2X.Text),
                int.Parse(Vect2Y.Text),
                int.Parse(Vect2Z.Text)
                );
            Vector res = Vect1 + Vect2;
            string outputRes = "Vector = (" + res.GetX() + " , " + res.GetY() + " , " + res.GetZ() + ")";
            SumRes.Text = outputRes;
        }

        private void Sub_Click(object sender, EventArgs e)
        {
            Vector Vect1 = new Vector(
                int.Parse(Vect1X.Text),
                int.Parse(Vect1Y.Text),
                int.Parse(Vect1Z.Text)
                );
            Vector Vect2 = new Vector(
                int.Parse(Vect2X.Text),
                int.Parse(Vect2Y.Text),
                int.Parse(Vect2Z.Text)
                );
            Vector res = Vect1 - Vect2;
            string outputRes = "Vector = (" + res.GetX() + " , " + res.GetY() + " , " + res.GetZ() + ")";
            SubRes.Text = outputRes;
        }

        private void Dot_Click(object sender, EventArgs e)
        {
            Vector Vect1 = new Vector(
               int.Parse(Vect1X.Text),
               int.Parse(Vect1Y.Text),
               int.Parse(Vect1Z.Text)
               );
            Vector Vect2 = new Vector(
                int.Parse(Vect2X.Text),
                int.Parse(Vect2Y.Text),
                int.Parse(Vect2Z.Text)
                );
            int res = Vect1 * Vect2;
            string outputRes = "—кал€рное произведение = " + res;
            DotRes.Text = outputRes;
        }

        private void Cross_Click(object sender, EventArgs e)
        {
            Vector Vect1 = new Vector(
                int.Parse(Vect1X.Text),
                int.Parse(Vect1Y.Text),
                int.Parse(Vect1Z.Text)
                );
            Vector Vect2 = new Vector(
                int.Parse(Vect2X.Text),
                int.Parse(Vect2Y.Text),
                int.Parse(Vect2Z.Text)
                );
            Vector res = Vect1 & Vect2;
            string outputRes = "Vector = (" + res.GetX() + " , " + res.GetY() + " , " + res.GetZ() + ")";
            CrossRes.Text = outputRes;
        }

        private void LenVect1_Click(object sender, EventArgs e)
        {
            Vector Vect1 = new Vector(
                int.Parse(Vect1X.Text),
                int.Parse(Vect1Y.Text),
                int.Parse(Vect1Z.Text)
                );

            double res = Vect1.Lenght();
            string outputRes = "ƒлина вектора = " + res;
            LenVect1Res.Text = outputRes;
        }

        private void LenVect2_Click(object sender, EventArgs e)
        {
            Vector Vect2 = new Vector(
                int.Parse(Vect2X.Text),
                int.Parse(Vect2Y.Text),
                int.Parse(Vect2Z.Text)
                );

            double res = Vect2.Lenght();
            string outputRes = "ƒлина вектора = " + res;
            LenVect2Res.Text = outputRes;
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

        public static Vector operator+(Vector v1, Vector v2)
        {
            return new Vector(v1.X + v2.X, v1.Y + v2.Y, v1.Z + v2.Z);
        }
        
        public static Vector operator-(Vector v1, Vector v2)
        {
            return new Vector(v1.X - v2.X, v1.Y - v2.Y, v1.Z - v2.Z);
        }

        public static int operator *(Vector v1, Vector v2) {
            return v1.X * v2.X + v1.Y + v2.Y + v1.Z * v2.Z;
        }

        public static Vector operator&(Vector v1, Vector v2)
        {
            return new Vector(v1.Y* v2.Z -v1.Z * v2.Y, v1.Z * v2.X - v1.X * v2.Z, v1.X * v2.Y - v1.Y * v2.X);
        }

        public double Lenght()
        {
            double result = Math.Sqrt(X * X + Y * Y + Z + Z);
            return result;
        }

    }
}
