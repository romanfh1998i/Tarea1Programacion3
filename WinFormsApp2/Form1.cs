namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Double sueldo, AFP, ASR, ISR, TotalDescuento, SueldoNeto;

            AFP=Double.Parse(txtSueldo.Text)*0.0291;
            ASR=Double.Parse(txtSueldo.Text)*0.0304;

            sueldo=Double.Parse(txtSueldo.Text);
            if(sueldo > 33384)
            {
                ISR=(sueldo - 33384) *0.15;
            }
            else
            {
                ISR=0;
            }
            TotalDescuento=ASR+AFP+ISR;
            SueldoNeto=TotalDescuento-sueldo;
            int fila = dgvSueldo.Rows.Add();
            dgvSueldo.Rows[fila].Cells["ASR"].Value=ASR;
            dgvSueldo.Rows[fila].Cells["ISR"].Value=ISR;
            dgvSueldo.Rows[fila].Cells["AFP"].Value=AFP;
            dgvSueldo.Rows[fila].Cells["Total_Descuento"].Value=TotalDescuento;
            dgvSueldo.Rows[fila].Cells["Sueldo_Neto"].Value=SueldoNeto;
        }
    }
}