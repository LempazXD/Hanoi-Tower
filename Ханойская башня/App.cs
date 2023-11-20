using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Web.UI.Design;
using System.Media;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;
using System.Collections;
using System.Net.NetworkInformation;

namespace Ханойская_башня
{
	public partial class App : MaterialForm
	{
		public App()
		{
			InitializeComponent();
		}
										//Tag - размеры колец и значение стержня (какое кольцо находится сверху)
										//TabIndex - количество колец на стержне
										//А также я создал невидимую кнопку button 1 с Name=topRing
										//Так как при создании объекта Button topRing; у меня topRing  становилось = ring2
										//После определённой последовательности нажатий на кнопки и следовательно
										//ring2.Tag становился = 8 из-за нужного кода при нажатии "Опустить"

		private void App_Load(object sender, EventArgs e)
		{
			column1.SendToBack();  //Стержни на задний фон (потому что вставил стержни в последнюю очередь)
			column2.SendToBack();
			column3.SendToBack();
			timer1.Start();
		}

		short min=15;
		short sec=0;

		private void timer1_Tick(object sender, EventArgs e)
		{
			gameTimer();

			if (min == 0 && sec == 0)
				gameLoss();

			if (min==0 && sec < 30)
				left30Sec();

			if (column3.TabIndex == 8)
				gameWin();
		}

		private void gameTimer()
		{
			timerLabel.Text = $"{min:D2}:{sec:D2}";
			if (sec > 0)
				sec--;
			else if (sec == 0)
			{
				sec = 59;
				min--;
			}
		}

		private void gameWin()
		{
			string musicPath = "zvuk.wav"; //Для воспроизведения музыки победителя

			try
			{
				using (SoundPlayer musicPlay = new SoundPlayer(musicPath))
				{
					musicPlay.Play();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Ошибка воспроизведения музыки победителя: " + ex.Message);
			}
			timer1.Stop();
			MessageBox.Show("Поздравляем! Вы стали победителем!", "Победа!", MessageBoxButtons.OK);
		}

		private void gameLoss()
		{
			timer1.Stop();
			MessageBox.Show("Вы проиграли!", "Время вышло!");
		}

		private void left30Sec()
		{
			timerLabel.BackColor = Color.OrangeRed;
		}


		short buttonTag, columntag;    //Тег переносной кольца и тег стержня, на который хотим поставить кольцо

		short otkyda;	//С какого стержня переставляем кольцо

		int steps;  //Количество ходов

		short pressUp = 0, pressDown = 0;      //Для защиты от двойных нажатий кнопок Поднять/Опустить
											   //pressUp - нажатие "Поднять"
											   //pressDown - нажитие "Опустить"

		short a; //Для метода Pytanica

		Button[] ring;	//Эти переменные для метода Pytanica
		Button[] chtoto;
		List<Button> stick1;
		List<Button> stick2;
		List<Button> stick3;

		Button topRing;

		private void Pytanica()     //Название метода соответсвует коду (joke)
		{                           //Данный метод позволяет менять тег (размерность) стержней (верхнего кольца)
									//И не вызываться каждый раз при кнопке "down"

			ring = new Button[8] { ring0, ring1, ring2, ring3, ring4, ring5, ring6, ring7 };

			chtoto = new Button[8] { ring7, ring6, ring5, ring4, ring3, ring2, ring1, ring0 };

			stick1 = new List<Button>();
			foreach (Button rings in chtoto)
			{
				stick1.Add(rings);
			}

			stick2 = new List<Button>();
			stick3 = new List<Button>();

		}

		private void up_click(short up)
		{
			if (pressUp == 0)
			{
				Button[] ringDa = new Button[8] { ring0, ring1, ring2, ring3, ring4, ring5, ring6, ring7 }; //Список колец

				if (up == 1)
				{
					otkyda = 1;                         //Взяли с 1 стержня
					foreach (Button rings in ringDa)
					{
						if (column1.TabIndex == 0)
						{
							MessageBox.Show("На данном стержне отсутствуют кольца!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
							break;
						}
						if (rings.Tag == column1.Tag)           //Ищем верхнее кольцо в 1 стержне
						{
							pressDown = 0;
							pressUp = 1;
							buttonTag = Convert.ToInt16(rings.Tag);
							rings.Location = new Point(119 - buttonTag * 10, 303);          //Показываем, что выбрали кольцо со стержня
							column1.TabIndex--;
							break;
						}
					}
				}

				else if (up == 2)
				{
					otkyda = 2;
					foreach (Button rings in ringDa)
					{
						if (column2.TabIndex == 0)
						{
							MessageBox.Show("На данном стержне отсутствуют кольца!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
							break;
						}
						if (rings.Tag == column2.Tag)
						{
							pressDown = 0;
							pressUp = 1;
							buttonTag = Convert.ToInt16(rings.Tag);
							rings.Location = new Point(375 - buttonTag * 10, 303);
							column2.TabIndex--;
							break;
						}
					}
				}

				else if (up == 3)
				{
					otkyda = 3;
					foreach (Button rings in ringDa)
					{
						if (column3.TabIndex == 0)
						{
							MessageBox.Show("На данном стержне отсутствуют кольца!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
							break;
						}
						if (rings.Tag == column3.Tag)
						{
							pressDown = 0;
							pressUp = 1;
							buttonTag = Convert.ToInt16(rings.Tag);
							rings.Location = new Point(631 - buttonTag * 10, 303);
							column3.TabIndex--;
							break;
						}
					}
				}
			}
			else
				MessageBox.Show("Сначала опустите кольцо!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
		}

		private void down_click(short down)
		{
			if (a == 0)
			{
				a = 1;
				Pytanica();
			}

			if (pressDown == 0)
			{
				topRing = danet;
				if (down == 1)		//Кладём в 1 стержень
				{
					if (otkyda == 1)    //С 1 стержня подняли     //Если случайно взяли, то опускаем туда же, без засчитывания хода
					{
						foreach (Button rings in ring)
						{
							if (rings.Tag == column1.Tag)
							{
								pressUp = 0;        //Дабы не могли х2 раза нажать кнопки "Опустить/Поднять"
								pressDown = 1;
								buttonTag = Convert.ToInt16(rings.Tag);
								rings.Location = new Point(119 - buttonTag * 10, 485 - column1.TabIndex * 20);
								column1.TabIndex++;
								break;
							}
						}
					}
					else if (otkyda == 2)		//Со 2 стержня подняли
					{
						foreach (Button rings in ring)
						{
							if (rings.Tag == column2.Tag)
							{
								buttonTag = Convert.ToInt16(rings.Tag);
								columntag = Convert.ToInt16(column1.Tag);
								if (buttonTag < columntag)
								{
									pressUp = 0;
									pressDown = 1;
									rings.Location = new Point(119 - buttonTag * 10, 485 - column1.TabIndex * 20);
									column1.TabIndex++;         //Увеличиваем количество колец на стержне на 1	
									steps++;
									stepsLabel.Text = "Ходов: " + steps;
									stick1.Add(rings);
									column1.Tag = rings.Tag;
									stick2.RemoveAt(stick2.Count - 1);

									if (stick2.Count == 0)
										topRing.Tag = 8;
									else
										topRing = stick2[stick2.Count - 1];
									column2.Tag = topRing.Tag;
									break;
								}
								else
									MessageBox.Show("Вы не можете поставить большее кольцо на меньшее.", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
							}
						}
					}
					else if (otkyda == 3)
					{
						foreach (Button rings in ring)
						{
							if (rings.Tag == column3.Tag)
							{
								buttonTag = Convert.ToInt16(rings.Tag);
								columntag = Convert.ToInt16(column1.Tag);
								if (buttonTag < columntag)
								{
									pressUp = 0;
									pressDown = 1;
									rings.Location = new Point(119 - buttonTag * 10, 485 - column1.TabIndex * 20);
									column1.TabIndex++;
									steps++;
									stepsLabel.Text = "Ходов: " + steps;
									stick1.Add(rings);
									column1.Tag = rings.Tag;
									stick3.RemoveAt(stick3.Count - 1);

									if (stick3.Count == 0)
										topRing.Tag = 8;
									else
										topRing = stick3[stick3.Count - 1];
									column3.Tag = topRing.Tag;
									break;
								}
								else
									MessageBox.Show("Вы не можете поставить большее кольцо на меньшее.", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
							}
						}
					}
				}

				else if (down == 2)
				{
					if (otkyda == 1)
					{
						foreach (Button rings in ring)
						{
							if (rings.Tag == column1.Tag)
							{
								buttonTag = Convert.ToInt16(rings.Tag);
								columntag = Convert.ToInt16(column2.Tag);
								if (buttonTag < columntag)
								{
									pressUp = 0;
									pressDown = 1;
									rings.Location = new Point(375 - buttonTag * 10, 485 - column2.TabIndex * 20);
									column2.TabIndex++;
									steps++;
									stepsLabel.Text = "Ходов: " + steps;
									stick2.Add(rings);
									column2.Tag = rings.Tag;
									stick1.RemoveAt(stick1.Count - 1);

									if (column1.TabIndex == 0)
										topRing.Tag = 8;
									else
										topRing = stick1[stick1.Count - 1];
									column1.Tag = topRing.Tag;
									break;
								}
								else
									MessageBox.Show("Вы не можете поставить большее кольцо на меньшее.", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
							}
						}
					}
					else if (otkyda == 2)
					{
						foreach (Button rings in ring)
						{
							if (rings.Tag == column2.Tag)
							{
								pressUp = 0;
								pressDown = 1;
								buttonTag = Convert.ToInt16(rings.Tag);
								rings.Location = new Point(375 - buttonTag * 10, 485 - column2.TabIndex * 20);
								break;
							}
						}
					}
					else if (otkyda == 3)
					{
						foreach (Button rings in ring)
						{
							if (rings.Tag == column3.Tag)
							{
								buttonTag = Convert.ToInt16(rings.Tag);
								columntag = Convert.ToInt16(column2.Tag);
								if (buttonTag < columntag)
								{
									pressUp = 0;
									pressDown = 1;
									rings.Location = new Point(375 - buttonTag * 10, 485 - column2.TabIndex * 20);
									column2.TabIndex++;
									steps++;
									stepsLabel.Text = "Ходов: " + steps;
									stick2.Add(rings);
									column2.Tag = rings.Tag;
									stick3.RemoveAt(stick3.Count - 1);

									if (stick3.Count == 0)
										topRing.Tag = 8;
									else
										topRing = stick3[stick3.Count - 1];
									column3.Tag = topRing.Tag;
									break;
								}
								else
									MessageBox.Show("Вы не можете поставить большее кольцо на меньшее.", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
							}
						}
					}
				}

				else if (down == 3)
				{
					if (otkyda == 1)
					{
						foreach (Button rings in ring)
						{
							if (rings.Tag == column1.Tag)
							{
								buttonTag = Convert.ToInt16(rings.Tag);
								columntag = Convert.ToInt16(column3.Tag);
								if (buttonTag < columntag)
								{
									pressUp = 0;
									pressDown = 1;
									rings.Location = new Point(631 - buttonTag * 10, 485 - column3.TabIndex * 20);
									column3.TabIndex++;
									steps++;
									stepsLabel.Text = "Ходов: " + steps;
									stick3.Add(rings);
									column3.Tag = rings.Tag;
									stick1.RemoveAt(stick1.Count - 1);

									if (column1.TabIndex == 0)
										topRing.Tag = 8;
									else
										topRing = stick1[stick1.Count - 1];
									column1.Tag = topRing.Tag;
									break;
								}
								else
									MessageBox.Show("Вы не можете поставить большее кольцо на меньшее.", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);

							}
						}
					}
					else if (otkyda == 2)
					{
						foreach (Button rings in ring)
						{
							if (rings.Tag == column2.Tag)
							{
								buttonTag = Convert.ToInt16(rings.Tag);
								columntag = Convert.ToInt16(column3.Tag);
								if (buttonTag < columntag)
								{
									pressUp = 0;
									pressDown = 1;
									rings.Location = new Point(631 - buttonTag * 10, 485 - column3.TabIndex * 20);
									column3.TabIndex++;
									steps++;
									stepsLabel.Text = "Ходов: " + steps;
									stick3.Add(rings);
									column3.Tag = rings.Tag;
									stick2.RemoveAt(stick2.Count - 1);

									if (stick2.Count == 0)
										topRing.Tag = 8;
									else
										topRing = stick2[stick2.Count - 1];
									column2.Tag = topRing.Tag;
									break;
								}
								else
									MessageBox.Show("Вы не можете поставить большее кольцо на меньшее.", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
							}
						}
					}
					else if (otkyda == 3)
					{
						foreach (Button rings in ring)
						{
							if (rings.Tag == column3.Tag)
							{
								pressUp = 0;
								pressDown = 1;
								buttonTag = Convert.ToInt16(rings.Tag);
								rings.Location = new Point(631 - buttonTag * 10, 485 - column3.TabIndex * 20);
								break;
							}
						}
					}
				}
			}
			else
				MessageBox.Show("Сначала поднимите кольцо!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
		}

		private void up1_Click(object sender, EventArgs e)
		{
			up_click(1);
		}

		private void up2_Click(object sender, EventArgs e)
		{
			up_click(2);
		}

		private void up3_Click(object sender, EventArgs e)
		{
			up_click(3);
		}

		private void down1_Click(object sender, EventArgs e)
		{
			down_click(1);
		}

		private void down2_Click(object sender, EventArgs e)
		{
			down_click(2);
		}

		private void down3_Click(object sender, EventArgs e)
		{
			down_click(3);
		}
	}
}
