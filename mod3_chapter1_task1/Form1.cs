using Microsoft.VisualBasic.ApplicationServices;
using System.Collections.Generic;
using System.Threading;

namespace mod3_chapter1_task1
{

    public partial class Form1 : Form
    {
        private CancellationTokenSource ctsPrime = new CancellationTokenSource();
        private CancellationTokenSource ctsFibonacci = new CancellationTokenSource();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int start = string.IsNullOrEmpty(textBox1.Text) ? 2 : int.Parse(textBox1.Text);
            int end = string.IsNullOrEmpty(textBox2.Text) ? int.MaxValue : int.Parse(textBox2.Text);

            Thread tPrime = new Thread(() =>
            {
                for (int i = start; i <= end; i++)
                {
                    if (IsPrime(i))
                    {
                        listBox1.Invoke((MethodInvoker)delegate
                        {
                            listBox1.Items.Add(i);
                        });
                    }

                    if (ctsPrime.IsCancellationRequested)
                    {
                        return;
                    }
                }
            });

            Thread tFibonacci = new Thread(() =>
            {
                GenerateFibonacci();
            });

            tPrime.Start();
            tFibonacci.Start();
        }

        private bool IsPrime(int number)
        {
            if (number < 2) return false;
            if (number == 2 || number == 3) return true;
            if (number % 2 == 0 || number % 3 == 0) return false;

            int sqrt = (int)Math.Sqrt(number);

            for (int i = 5; i <= sqrt; i += 6)
            {
                if (number % i == 0 || number % (i + 2) == 0)
                {
                    return false;
                }
            }

            return true;
        }

        private void GenerateFibonacci()
        {
            int a = 0, b = 1;

            while (!ctsFibonacci.IsCancellationRequested)
            {
                int temp = a;
                a = b;
                b = temp + b;

                listBox2.Invoke((MethodInvoker)delegate
                {
                    listBox2.Items.Add(a);
                });
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ctsPrime.Cancel();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ctsFibonacci.Cancel();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            ctsPrime = new CancellationTokenSource();
            Thread tPrime = new Thread(() =>
            {
                int start = listBox1.Items.Count > 0 ? (int)listBox1.Items[listBox1.Items.Count - 1] + 1 : 2;
                int end = string.IsNullOrEmpty(textBox2.Text) ? int.MaxValue : int.Parse(textBox2.Text);

                for (int i = start; i <= end; i++)
                {
                    if (IsPrime(i))
                    {
                        listBox1.Invoke((MethodInvoker)delegate
                        {
                            listBox1.Items.Add(i);
                        });
                    }

                    if (ctsPrime.IsCancellationRequested)
                    {
                        return;
                    }
                }
            });

            tPrime.Start();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ctsFibonacci = new CancellationTokenSource();
            Thread tFibonacci = new Thread(() =>
            {
                int a = listBox2.Items.Count > 0 ? (int)listBox2.Items[listBox2.Items.Count - 1] : 0;
                int b = listBox2.Items.Count > 1 ? (int)listBox2.Items[listBox2.Items.Count - 2] : 1;

                while (!ctsFibonacci.IsCancellationRequested)
                {
                    int temp = a;
                    a = b;
                    b = temp + b;

                    listBox2.Invoke((MethodInvoker)delegate
                    {
                        listBox2.Items.Add(a);
                    });
                }
            });

            tFibonacci.Start();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ctsPrime.Cancel();
            ctsFibonacci.Cancel();

            listBox1.Items.Clear();
            listBox2.Items.Clear();

            ctsPrime = new CancellationTokenSource();
            ctsFibonacci = new CancellationTokenSource();

            Thread tPrime = new Thread(() =>
            {
                int start = string.IsNullOrEmpty(textBox1.Text) ? 2 : int.Parse(textBox1.Text);
                int end = string.IsNullOrEmpty(textBox2.Text) ? int.MaxValue : int.Parse(textBox2.Text);

                for (int i = start; i <= end; i++)
                {
                    if (IsPrime(i))
                    {
                        listBox1.Invoke((MethodInvoker)delegate
                        {
                            listBox1.Items.Add(i);
                        });
                    }

                    if (ctsPrime.IsCancellationRequested)
                    {
                        return;
                    }
                }
            });

            Thread tFibonacci = new Thread(() =>
            {
                GenerateFibonacci();
            });

            tPrime.Start();
            tFibonacci.Start();
        }
    }
}

