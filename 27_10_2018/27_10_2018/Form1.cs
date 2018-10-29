using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _27_10_2018
{
    public partial class Form1 : Form
    {
        //Class-dan gələn datanı Bu Listə doldururuq
        private List<Hall> Halls = new List<Hall>();
        private List<Book> Bookings = new List<Book>();
        private List<Button> SelectSeat = new List<Button>();
        private List<int> SelectSeats = new List<int>();
        private int oneSeatPrice=5;
        private Hall SelectIndex;
        public Form1()
        {
            InitializeComponent();
            AddHall();
        }

        //Konstraktr kimi class-dan instance aldiqda hər bir obyektə oz ilkin dəyərlərini veririkki
        //proqram basliyanda required valuelar her bir obyektdə olsun və biz strukturumuzu onların
        //əsasında quraq
        private void AddHall()
        {
            Hall hall1 = new Hall
            {
                SeatCount = 15,
                Column = 5
            };
            Hall hall2 = new Hall
            {
                SeatCount = 20,
                Column = 4
            };
            Hall hall3 = new Hall()
            {
                SeatCount = 18,
                Column = 6
            };
            this.Halls.Add(hall1);
            this.Halls.Add(hall2);
            this.Halls.Add(hall3);
        }



        //Click olunan zalın index-ni gotururuk.Çünki bu index vastəsilə biz zalları bir-birlərindən
        //ayiririq
        private void SelectHall_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            int HallIndex = Convert.ToInt32(button.Name[button.Name.Length - 1].ToString()) - 1;
            TitleLbl.Visible = true;
            if (HallIndex==0)
            {
                TitleLbl.Text = "Milyonluq Quş";
            }
            else if (HallIndex==1)
            {
                TitleLbl.Text = "Qaragöz";
            }
            else if (HallIndex==2)
            {
                TitleLbl.Text = "Göktaşı";
            }
            GenerateSeat(HallIndex);
            //Her defe zalin indeksini deyisdikde bir evvelkinin index-ni bir variable-da saxlayiriq
            SelectIndex = this.Halls[HallIndex];
        }



        //Hər zal üçün dovr vastəsilə yerlər yaradiriq(also the rule of creating dynamic buttons)
        private void GenerateSeat(int index)
        {
            ResetSeat();
            int x = 50;
            int y = 30;
            for (int i = 0; i < this.Halls[index].SeatCount; i++)
            {
                Button btn = new Button
                {
                    Size = new Size(60, 50),
                    Text = (i + 1).ToString(),
                    Location = new Point(x, y),
                    BackColor=Color.LightGray
                };

                x += 70;
                btn.Click += new EventHandler(AllBtn_Click);


                //Sifaris edilmisler listi ile zallar listindeki proplar yoxlanilir eger beraberdirlerse
                //demek evvelceden hemen yer zanit olunmusdur demekdir
                if (this.Bookings.Exists(b=>b.Hall==this.Halls[index] && b.seatİndex==i))
                {
                    btn.BackColor = Color.LightGreen;
                }

                PnlAddBtn.Controls.Add(btn);

                if ((i + 1) % this.Halls[index].Column == 0)
                {
                    y += 60;
                    x = 50;
                }
            }
        }


        //Yerləri resetlənə məntiqi
        private void ResetSeat()
        {
            PnlAddBtn.Controls.Clear();
        }


        //Hər bir zala uyğun bilet seçmə məntiqi
        private void AllBtn_Click(object sender,EventArgs e)
        {
            Button clicked = sender as Button;
            if (clicked.BackColor==Color.LightGray)
            {
                if (SelectSeats.Count==0 || SelectSeats.Exists(s => s == Convert.ToInt32(clicked.Text) + 1 || s == Convert.ToInt32(clicked.Text) - 1)) 
                {
                    clicked.BackColor = Color.Yellow;
                    this.SelectSeat.Add(clicked);
                    this.SelectSeats.Add(Convert.ToInt32(clicked.Text));
                }
            }
            else if (clicked.BackColor==Color.Yellow)
            {
                clicked.BackColor = Color.LightGray;
                this.SelectSeat.Remove(clicked);
                this.SelectSeats.Remove(Convert.ToInt32(clicked.Text));
            }
            else
            {
                DialogResult r = MessageBox.Show("Bu biletləri ləğv etməyə əminsiniz mi?", "Bilet ləğv etmə", MessageBoxButtons.OKCancel);
                if (r==DialogResult.OK)
                {
                    clicked.BackColor = Color.LightGray;
                    int index = this.Bookings.FindIndex(b => b.Hall == this.SelectIndex && b.seatİndex == (Convert.ToInt32(clicked.Text) - 1));
                    this.Bookings.RemoveAt(index);
                }
            }
            KnowPriceBook();
            SelectSeatShow();
            visibleBookButton();
        }


        //Yerəri seçdikcə seçilmiş yerin qiymetini label-da gosterir
        private void KnowPriceBook()
        {
            if (this.SelectSeat.Count>0)
            {
                LblTotalPrice.Text = ((this.SelectSeat.Count * oneSeatPrice).ToString() + " azn");
            }
            else
            {
                LblTotalPrice.Text = "";
            }
           
        }


        //Yerləri seçdikcə seçilmiş yerin nömrəsini göstərir
        private void SelectSeatShow()
        {
            List<string> places = new List<string>();
            foreach (Button button in SelectSeat)
            {
                places.Add(button.Text);
            }

            LblSeats.Text = string.Join(",", places.ToArray());
        }


        //Reserv buttonuna basdiqda secilmis yerler rezerv edilir
        private void TotalBook_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Bu biletləri rezerv etməyə əminsiniz mi?", "Bilet alma",MessageBoxButtons.OKCancel);
            if (r==DialogResult.OK)
            {
                foreach (Button button in SelectSeat)
                {
                    button.BackColor = Color.LightGreen;
                    Book booking = new Book
                    {
                        Hall = SelectIndex,
                        seatİndex = Convert.ToInt32(button.Text) - 1
                    };
                    this.Bookings.Add(booking);
                }
            }
            LblTotalPrice.Text = "";
            LblSeats.Text = "";
            this.SelectSeat.Clear();
            this.SelectSeats.Clear();
        }


        //Label və button-un gorunmezliyini ayarlayiriq
        private void visibleBookButton()
        {
            if (this.SelectSeat.Count>0)
            {
                TotalBook.Visible = true;
            }
            else
            {
                TotalBook.Visible = false;
            }
        }
    }
}
