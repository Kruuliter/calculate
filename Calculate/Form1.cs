using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculate
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
         
        /// <summary>
        /// операция для switch
        /// </summary>
        string SwIndex;

        /// <summary>
        /// операция
        /// </summary>
        string index;

        /// <summary>
        /// аргумент
        /// </summary>
        double arg, arg2;

        /// <summary>
        /// состояние табло (false - не пусто, true - пусто)
        /// </summary>
        bool fl = false;

        /// <summary>
        /// повтор операции (false - нет повтора, true - есть повтор)
        /// </summary>
        bool povtor = false;

        /// <summary>
        /// выполнение операциии
        /// </summary>
        public void calcul ()
        {
            if (index != "=")
                    arg2 = Convert.ToDouble(lb_Tablo.Text);

                switch (SwIndex)
                {
                    case "+":
                        lb_Tablo.Text = Convert.ToString(arg + arg2); fl = true; break;
                    case "-":
                        lb_Tablo.Text = Convert.ToString(arg - arg2); fl = true; break;
                    case "*":
                        lb_Tablo.Text = Convert.ToString(arg * arg2); fl = true; break;
                    case "/":
                        {
                            if (arg2 != 0) { lb_Tablo.Text = Convert.ToString(arg / arg2); fl = true; break; }
                            else
                            { MessageBox.Show("Ошибка: Попытка деления на 0"); btn_Dump.PerformClick(); }
                            break;
                        }

                    default: break;
                }
                arg = Convert.ToDouble(lb_Tablo.Text);

        }


       private void btn_One_Click(object sender, EventArgs e)
       {
           Button snd = (Button)sender;

           // если fl = true, то значит, поле пусто
           if (fl)
           {
               // по умолчанию, начальное значение табло - 0
               lb_Tablo.Text = "0";
               fl = false;
           }

           if (lb_Tablo.Text.Length > 9) return; // ограничение длины числа (до 9 цифр)

           if (lb_Tablo.Text == "0") lb_Tablo.Text = snd.Text.ToString(); // если цифра 0, то заменяем на значение на кнопке
           else lb_Tablo.Text += snd.Text.ToString(); // если нет, то добавляем в число цыфру с кнопки

           //btn_EraseLast.Enabled = true;
           //btn_Point.Enabled = true;

           btn_Result.Focus();
       }



       private void btn_Point_Click(object sender, EventArgs e)
       {
           if (fl)
           { lb_Tablo.Text = "0,"; fl = false; }
           // если "," еще не встречалась, то ставим ее
           if (lb_Tablo.Text.IndexOf(",") == -1)
               lb_Tablo.Text += ",";

           btn_Result.Focus();
       }

       private void btn_СhangeSign_Click(object sender, EventArgs e)
       {
           // смена знака операции

               if (lb_Tablo.Text == "0")
               {
                   return;
               }
               if (lb_Tablo.Text.IndexOf("-") == -1)
               // String.IndexOf возвращает целочисленное значение - 
               // индекс первого вхождения символа в строку. 
               // Если искомого символа нет в строке - метод String.IndexOf возвращает в качестве значения -1(минус 1).
               {
                   lb_Tablo.Text = "-" + lb_Tablo.Text;
               }
               else
               {
                   lb_Tablo.Text = lb_Tablo.Text.Substring(1);
               }
           
           btn_Result.Focus();
       }

       private void btn_EraseLast_Click(object sender, EventArgs e)
       {
           if (!fl)
           {
               if (lb_Tablo.Text.Length > 1)
               {
                   if (lb_Tablo.Text != "-0,")
                       lb_Tablo.Text = lb_Tablo.Text.Substring(0, lb_Tablo.Text.Length - 1);
                   else lb_Tablo.Text = "0";
               }
               else lb_Tablo.Text = "0";
           }

           btn_Result.Focus();
       }

       private void btn_Dump_Click(object sender, EventArgs e)
       {
           //стираем все
           lb_Tablo.Text = "0";
           arg = 0;
           arg2 = 0;

           //btn_EraseLast.Enabled = true;
           //btn_Point.Enabled = true;

           SwIndex = "=";

           btn_Result.Focus();
       }

      


       private void btn_Plus_Click(object sender, EventArgs e)
       {
           Button snd = (Button)sender;

           index = snd.Text;
           SwIndex = snd.Text;

           fl = false; // табло не пусто
           if (povtor == false) // если повторов нет
           {
               povtor = true;
               arg = Convert.ToDouble(lb_Tablo.Text);
           }
           else // операция повторяется
           {
               calcul();
               lb_Tablo.Text = Convert.ToString(arg);
           }

           fl = true; // новое число

           btn_Result.Focus();
       }

       private void btn_Result_Click(object sender, EventArgs e)
       
       {
           povtor = false;

           calcul();

               index = "=";
               fl = true;
           
               if (lb_Tablo.Text == "NaN")
               {
                   MessageBox.Show("Неккоректно заданная команда");
                   btn_Dump.PerformClick();
               }

               if (lb_Tablo.Text == "∞" || lb_Tablo.Text == "-∞")
                {
                    MessageBox.Show("Неккоректно заданная команда");
                    btn_Dump.PerformClick();
                }

               lb_History.Items.Add(arg.ToString());
       }

       private void Form1_KeyPress(object sender, KeyPressEventArgs e)
       {
           btn_Result.Focus();

           switch (e.KeyChar)
           {
               case '1': btn_One.PerformClick(); break;
               case '2': btn_two.PerformClick(); break;
               case '3': btn_Three.PerformClick(); break;
               case '4': btn_Four.PerformClick(); break;
               case '5': btn_Five.PerformClick(); break;
               case '6': btn_Six.PerformClick(); break;
               case '7': btn_Seven.PerformClick(); break;
               case '8': btn_Eight.PerformClick(); break;
               case '9': btn_Nine.PerformClick(); break;
               case '0': btn_Zero.PerformClick(); break;
               case '+': btn_Plus.PerformClick(); break;
               case '-': btn_Minus.PerformClick(); break;
               case '*': btn_Increase.PerformClick(); break;
               case '/': btn_Divide.PerformClick(); break;
               case ',': btn_Point.PerformClick(); break;
               case (char)Keys.Back: btn_EraseLast.PerformClick(); break;
               case (char)Keys.Enter: btn_Result.PerformClick(); break;
               default: break;
           }
       }

        // открываем/закрываем доп.панель с историей
       private void btn_Panel_Click(object sender, EventArgs e)
       {
           if (ActiveForm.Width < 500)
           {
               ActiveForm.Width = ActiveForm.Width + 200;
               btn_Panel.Text = "<";
           }
           else
               if (ActiveForm.Width > 500)
               {
                   ActiveForm.Width = ActiveForm.Width - 200;
                   btn_Panel.Text = ">";
               }
       }

        // выбираем элемент из истории
       private void lb_History_MouseDown(object sender, MouseEventArgs e)
       {
           ListBox lb = (ListBox)sender;
           lb.DoDragDrop(lb, DragDropEffects.Copy);
       }

        //добавляем элемент в табло 
       private void lb_Tablo_DragDrop(object sender, DragEventArgs e)
       {
           try
           {
               string st = lb_History.SelectedItem.ToString();
               arg2 = double.Parse(st);
               Label lb = (Label)sender;
               lb.Text = lb_History.SelectedItem.ToString();
               
               btn_EraseLast.Enabled = false;
               btn_Point.Enabled = false;
           }
           catch (NullReferenceException)
           { }
       }

       private void lb_Tablo_DragOver(object sender, DragEventArgs e)
       {
           Label lb = (Label)sender;
           e.Effect = DragDropEffects.Copy;
       }

        // очистить историю
       private void btn_ClearHistory_Click(object sender, EventArgs e)
       {
           lb_History.Items.Clear();
       }

       private void btn_SQRT_Click(object sender, EventArgs e)
       {
               if (Convert.ToDouble(lb_Tablo.Text) >= 0) lb_Tablo.Text = Convert.ToString(Math.Sqrt(Convert.ToDouble(lb_Tablo.Text)));
               else
               {
                   MessageBox.Show("Ошибка ввода: \nПопытка извлечения корня из отрицательного числа");
                   lb_Tablo.Text = "0";
               }
               lb_History.Items.Add(lb_Tablo.Text);
       }

       private void btn_SinX_Click(object sender, EventArgs e)
       {
               lb_Tablo.Text = Convert.ToString(Math.Sin(Convert.ToDouble(lb_Tablo.Text)));
               lb_History.Items.Add(lb_Tablo.Text);
       }

       private void btn_CosX_Click(object sender, EventArgs e)
       {
               lb_Tablo.Text = Convert.ToString(Math.Cos(Convert.ToDouble(lb_Tablo.Text)));
               lb_History.Items.Add(lb_Tablo.Text);
       }
    }
}
