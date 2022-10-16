using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

public partial class MainForm : Form
{
    public const int WM_NCLBUTTONDOWN = 0xA1;
    public const int HT_CAPTION = 0x2;

    [DllImportAttribute("user32.dll")]
    public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
    [DllImportAttribute("user32.dll")]
    public static extern bool ReleaseCapture();

    public MainForm()
    {
        InitializeComponent();
    }

    private void Form1_MouseDown(object sender, MouseEventArgs e)
    {
        if (e.Button == MouseButtons.Left)
        {
            ReleaseCapture();
            SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
        }
    }

    private void gunaButton16_Click(object sender, EventArgs e)
    {
        siticoneTextBox1.Text = "";

        foreach (string line in SplitToLines(siticoneTextBox4.Text))
        {
            if (line.Replace(" ", "").Replace(":", "").Replace("'\t".ToString(), "").Equals(""))
            {
                continue;
            }

            if (!line.Contains(":"))
            {
                continue;
            }

            int colons = 0;

            foreach (char c in line)
            {
                if (c.Equals(':'))
                {
                    colons++;
                }
            }

            if (colons > 1)
            {
                continue;
            }

            string[] splitted = line.Split(':');
            string header = splitted[0], value = splitted[1].Replace("\"", "\\\"");

            if (value.StartsWith(" "))
            {
                value = value.Substring(1);
            }

            string newLine = siticoneTextBox2.Text.Replace("%header%", header).Replace("%value%", value).Replace("(header)", header).Replace("(value)", value).Replace("{header}", header).Replace("{value}", value).Replace("[header]", header).Replace("[value]", value);

            if (siticoneTextBox1.Text == "")
            {
                siticoneTextBox1.Text = newLine;
            }
            else
            {
                siticoneTextBox1.Text += "\r\n" + newLine;
            }
        }
    }

    public static IEnumerable<string> SplitToLines(string input)
    {
        if (input == null)
        {
            yield break;
        }

        using (System.IO.StringReader reader = new System.IO.StringReader(input))
        {
            string line;

            while ((line = reader.ReadLine()) != null)
            {
                yield return line;
            }
        }
    }
}