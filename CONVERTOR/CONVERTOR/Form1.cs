

namespace CONVERTOR
{
  
  public partial class Form1 : Form
  {
    public Form1()
   
   {
      InitializeComponent();
    }
    
          private void button1_Click(object sender, EventArgs e)
    
    {
        float number1 = float.Parse(txt1.Text);
        
        float ans = number1 / 1000;
        
        txt2.Text = ans.ToString();
        
    }
    
  }
  
}
