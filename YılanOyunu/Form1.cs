

namespace YilanOyunu
{
    public partial class Form1 : Form
    {
        List<Point> yilan;
        int bolumX, bolumY, bolumYukseklik, bolumGenislik, yonX, yonY, skor;
        Point yem;
        Random rndmYem = new Random();
        bool yondegistir;
        public Form1()
        {
            InitializeComponent();
            OyunuBaslat();

        }

        private void OyunuBaslat()
        {
            tmrOyun.Interval = 500;
            skor = 0;
            lblSkor.Text = skor.ToString("000");
            bolumX = 20;
            bolumY = 20;
            int baslangicX = bolumX / 2;
            int baslangicY = bolumY / 2;

            bolumYukseklik = pnlMain.Height / bolumY;
            bolumGenislik = pnlMain.Width / bolumX;
            yilan = new List<Point>(bolumGenislik * bolumX / 2)
            {
                new Point(baslangicX, baslangicY),
                new Point(baslangicX-1, baslangicY),
                new Point(baslangicX-2, baslangicY)

            };
            yonX = +1;
            yonY = 0;
            yemUret();
        }

        private void yemUret()
        {
            do
            {
                yem = new Point(rndmYem.Next(bolumX), rndmYem.Next(bolumY));
            } while (yilan.Any(p => p.X == yem.X && p.Y == yem.Y));
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pnlMain_Paint(object sender, PaintEventArgs e)
        {
            bool basi = true;
            foreach (Point p in yilan)
            {
                panelBoya(e.Graphics, p, basi ? Brushes.PowderBlue : Brushes.Pink);
                basi = false;
            }
            panelBoya(e.Graphics, yem, Brushes.OliveDrab);
        }

        private void panelBoya(Graphics graphics, Point p, Brush firca)
        {
            int x = p.X * bolumGenislik;
            int y = p.Y * bolumGenislik;
            graphics.FillRectangle(firca, x, y, bolumGenislik, bolumYukseklik);
            graphics.DrawRectangle(Pens.Black, x, y, bolumGenislik, bolumYukseklik);
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (yondegistir)
                return base.ProcessCmdKey(ref msg, keyData);
            if (keyData == Keys.Up || keyData == Keys.Down || keyData == Keys.Left || keyData == Keys.Right)
                tmrOyun.Start();
            int x = 0, y = 0;
            if (keyData == Keys.Up)
                y = -1;
            else if (keyData == Keys.Down)
                y = 1;
            else if (keyData == Keys.Left)
                x = -1;
            else if (keyData == Keys.Right)
                x = 1;

            if (yonX != -x && yonY != -y)
            {
                yonX = x;
                yonY = y;
                yondegistir = true;
            }
            return base.ProcessCmdKey(ref msg, keyData);

        }
        private void tmrOyun_Tick(object sender, EventArgs e)
        {
            yondegistir = false;
            Point yeniBas = new Point(yilan[0].X + yonX, yilan[0].Y + yonY);
            if (yeniBas.X >= bolumX || yeniBas.X < 0 || yeniBas.Y >= bolumY || yeniBas.Y < 0 || yilan.Any(p => p == yeniBas) && yeniBas != yilan[yilan.Count - 1])
            {
                tmrOyun.Stop();
                MessageBox.Show("Oyun Bitti Toplam Skorunuz " + skor);
                lblOncekiSkor.Text = skor.ToString("000");
                OyunuBaslat();
                pnlMain.Refresh();
                return;

            }
            yilan.Insert(0, yeniBas);

            if (yeniBas == yem)
            {
                tmrOyun.Interval -= 10;
                skor++;
                lblSkor.Text = skor.ToString("000");
                yemUret();

            }
            else { yilan.RemoveAt(yilan.Count - 1); }
            pnlMain.Refresh();

        }
    }
}
