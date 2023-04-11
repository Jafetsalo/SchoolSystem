namespace Insititucion_Educativa
{
    public partial class Form2 : Form
    {
        
        public Form2() 
        {
                  
            
            
            foreach (Labor labor in Form1.ListaLabores)
            {
                
                comboBoxLabores.Items.Add(labor.Nombre_Labor);
            
            }

            
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
