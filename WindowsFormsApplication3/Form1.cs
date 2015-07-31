using System;
using System.Collections;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    delegate void Action();

    static void ForEach(IEnumerable l, Action a)
    {
      foreach (var x in l)
      {
        a();
      }
    }

    static void Times(int n, Action a)
    {
      ForEach(Enumerable.Range(0, n), a);
    }

    void Delay()
    {
      // forgive me for what to follow
      Application.DoEvents();
      Thread.Sleep((int)delaySrc.Value);
    }

    void LoadSettings()
    {
      ToolStripManager.LoadSettings(this);
      Delay();
    }

    private void button1_Click(object sender, EventArgs e)
    {
      ToolStripManager.SaveSettings(this);
    }

    private void button2_Click(object sender, EventArgs e)
    {
      Times(1, LoadSettings);
    }

    private void button3_Click(object sender, EventArgs e)
    {
      Times(2, LoadSettings);
    }

    private void button4_Click(object sender, EventArgs e)
    {
      Times(4, LoadSettings);
    }

    private void button5_Click(object sender, EventArgs e)
    {
      Times(8, LoadSettings);
    }

    private void button6_Click(object sender, EventArgs e)
    {
      WindowState = FormWindowState.Minimized;
      WindowState = FormWindowState.Normal;
    }

    private void button7_Click(object sender, EventArgs e)
    {
      Width -= 300;
      Times(3, Delay);
      Width += 300;
    }
  }
}
