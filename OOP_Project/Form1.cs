using System.Windows.Forms;

namespace OOP_Project
{
    public partial class Form1 : Form
    {

        private Polygon polygon = null!; // null! yazmadýðýmda polygon non-nullable olduðu için hata veriyordu

        public Form1()
        {
            InitializeComponent();
            SetDefaultValues();
        }

        private void SetDefaultValues()
        {
            // renk trackbarlarýnýn max min ve baþlangýç deðerleri
            trackBar1.Minimum = trackBar2.Minimum = trackBar3.Minimum = 0;
            trackBar1.Maximum = trackBar2.Maximum = trackBar3.Maximum = 255;
            trackBar1.Value = trackBar2.Value = trackBar3.Value = 0;

            // sayý dðerlerinin default deðerleri (tasarým yaparken yapmýþtým ama kod üzerinde de gözükmesi için tekrar yaptým)
            value_x.Text = "0";
            value_y.Text = "0";
            value_length.Text = "4";
            value_edges.Text = "5";
            value_angle.Text = "30";

            // baþlangýçta saat yönünde döneceði için false ile baþlamalý
            checkBox1.Checked = false;
        }

        // draw butonuna basýldýðýnda çalýþacak fonksiyon
        private void drawButton(object sender, EventArgs e)
        {
            try
            {
                // girilen deðerleri alýyoruz
                int centerX = int.Parse(value_x.Text);
                int centerY = int.Parse(value_y.Text);
                int length = int.Parse(value_length.Text);
                int edges = int.Parse(value_edges.Text);

                // burada poligonu oluþturuyoruz
                Point2D center = new Point2D(centerX, centerY);
                ColorRGB color = new ColorRGB(trackBar1.Value, trackBar2.Value, trackBar3.Value);
                polygon = new Polygon(center, length, color, edges);

                // daha önce yazdýðým fonksiyonlarý kullanarak heasplamalar yapýp poligonu çizdiriyorum
                polygon.calculateEdgeCoordinates();
                DrawPolygon();
                UpdateVertexList();

                // uzunluk ve köþe saysýnýn belirtilen deðer aralýðýnda olmasý için if else ile kullanýcýya uyarý verdirdim
                if (length < 3 || length > 9)
                {
                    MessageBox.Show("Length must be in between 3 and 9!", "Input Error");
                    return;
                }

                if (edges < 3 || edges > 10)
                {
                    MessageBox.Show("Number of edges must be in between 3 and 10!", "Input Error");
                    return;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Invalid input!");
            }
        }

        // rotate butonuna basýldýðýnda çalýþacak fonksiyon
        private void rotateButton_Click(object sender, EventArgs e)
        {
            if (polygon == null)
            {
                resetButton_Click(sender, e);
                return;
            }

            try
            {
                double angle = double.Parse(value_angle.Text);
                polygon.rotatePolygon(angle, !checkBox1.Checked);
                DrawPolygon();
                UpdateVertexList();

                if (angle < 0 || angle >= 360)
                {
                    MessageBox.Show("Angle must be in between 0 and 360 (360 not included)!");
                    return;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Invalid input!");
            }
        }

        // reset butonuna basýldýðýnda çalýþacak fonksiyon
        private void resetButton_Click(object sender, EventArgs e)
        {
            Random random = new Random();

            // reset butonu random deðerler üreteceði için burada random deðerler belirliyorum
            int centerX = random.Next(0, 4);
            int centerY = random.Next(0, 4);
            int length = random.Next(3, 10);
            int edges = random.Next(3, 11);
            int red = random.Next(0, 256);
            int green = random.Next(0, 256);
            int blue = random.Next(0, 256);
            int angle = random.Next(0, 360);

            // bazý deðerler text olarak ekranda gözükeceði için onlarý stringe çeviridm ayný zmaanda bütün deðerleri yeni deðerlerle güncelledim
            value_x.Text = centerX.ToString();
            value_y.Text = centerY.ToString();
            value_length.Text = length.ToString();
            value_edges.Text = edges.ToString();
            trackBar1.Value = red;
            trackBar2.Value = green;
            trackBar3.Value = blue;
            value_angle.Text = angle.ToString();

            // poligonu oluþturdum
            Point2D center = new Point2D(centerX, centerY);
            ColorRGB color = new ColorRGB(red, green, blue);
            polygon = new Polygon(center, length, color, edges);
            polygon.calculateEdgeCoordinates();

            DrawPolygon();
            UpdateVertexList();
        }

        // pictureboxun üzerine poligonu çizdirecek olan fonksiyon
        private void DrawPolygon()
        {
            if (polygon == null || pictureBox1.Width == 0) return;

            Bitmap bitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            using (Graphics g = Graphics.FromImage(bitmap))
            {
                g.Clear(Color.White);

                //burada pictureboxun merkezini koordinat sisteminin merkezi olarak ayarladým
                int centerX = pictureBox1.Width / 2;
                int centerY = pictureBox1.Height / 2;

                // poligon çizimi
                if (polygon.Vertices.Count >= 3 || polygon.Vertices.Count <= 10)
                {
                    Color drawColor = Color.FromArgb(polygon.Color.Red, polygon.Color.Green, polygon.Color.Blue);
                    Pen polygonPen = new Pen(drawColor, 2); // çiziginin kalýnlýðýný 2 olarak belirledim

                    Point[] points = new Point[polygon.Vertices.Count];
                    for (int i = 0; i < polygon.Vertices.Count; i++)
                    {
                        points[i] = new Point(
                            centerX + (polygon.Vertices[i].coordinate_X * Polygon.scaleFactor),
                            centerY - (polygon.Vertices[i].coordinate_Y * Polygon.scaleFactor)
                        );
                    }

                    g.DrawPolygon(polygonPen, points);
                }


                pictureBox1.Image = bitmap;
            }

        }


        // köþelerin güncel listrsi
        private void UpdateVertexList()
        {
            if (polygon == null) return;

            // önce eski deðerleri temizledim
            listBox1.Items.Clear();

            // köþelerin kordinatlarýný listboxa yazdýrdým
            for (int i = 0; i < polygon.Vertices.Count; i++)
            {
                Point2D v = polygon.Vertices[i];
                listBox1.Items.Add((i + 1) + ". Edge = (" + v.coordinate_X + "," + v.coordinate_Y + ")");
            }
        }

    }
}
