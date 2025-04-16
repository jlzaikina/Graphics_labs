namespace LR2
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
        int dx = 3, dy = 3;                                //шаг для рисования
        int X = 450, Y = 230;                              //позиция начала

        string rule = "F+F-F+F+F";                       //правило


        int pos = 90;                                     //начальный угол
        string turtle = "F+F+F+F";                        //начальная строка - аксиома

        void UpdStr()                                     //обновление строки
        {
            for (int i = 0; i < turtle.Length; i++)
            {
                int temp = i;
                if (turtle[i] == 'F')
                {
                    turtle = turtle.Insert(i, rule);
                    temp += 8;
                    turtle = turtle.Remove(temp, 1);
                }
                i = temp;
            }
        }

        void DrawTurtle(Graphics g)                       //вычисление угла и дальнейшее рисование
        {
            while (pos < -360) 
                pos += 360;
            while (pos > 360) 
                pos -= 360;
            if (pos == 0 || pos == -360 || pos == 360) DrawPart(g, dx, 0);
            if (pos == 90 || pos == -270) DrawPart(g, 0, dy);
            if (pos == 180 || pos == -180) DrawPart(g, -dx, 0);
            if (pos == -90 || pos == 270) DrawPart(g, 0, -dy);
        }
        private void DrawPart(Graphics g, int dx, int dy) //метод рисующий линию
        {
            g.DrawLine(Pens.Black, X, Y, X + dx, Y + dy);
            X += dx;
            Y += dy;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Graphics g = Graphics.FromHwnd(pictureBox1.Handle);
            g.Clear(Color.White);
            DrawMain(g);
            X = 450; Y = 230;
        }
        void DrawMain(Graphics g)                         //main
        {
            for (int i = 0; i < turtle.Length; i++)
            {
                if (turtle[i] == '-')                     
                    pos -= 90;
                if (turtle[i] == '+')
                    pos += 90;
                if (turtle[i] == 'F')
                    DrawTurtle(g);                        
            }
            UpdStr();                                    //обновление строки
        }
    }
}
