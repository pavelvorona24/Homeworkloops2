namespace Homework2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string iresult;
            int iEnd,  iCounter, strEnd, inumber;
            double inumberpow;
            strEnd = 0;
            iEnd = 10;
            lblOutput.Items.Clear();
            inumber = Convert.ToInt32(n1.Text);
            iCounter = strEnd;
            while (iCounter <= iEnd)
            {
                inumberpow = Math.Pow(inumber, iCounter);
                iresult = inumber.ToString() + " pow " + iCounter.ToString() + " = " + inumberpow.ToString();
                //This is the string that will by added to the
                //For example, if the user inputs 5, the first
                //value will be �5 * 1 = 5�
                lblOutput.Items.Add(iresult);
                iCounter = iCounter + 1; // alternatively you can write iCounter ++

                lblOutput.Text = inumberpow.ToString(); 
                
            }

            
        }
    }
}