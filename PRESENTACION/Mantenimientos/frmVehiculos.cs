using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//0. Referencia (proyecto > LOGICA)
//1. Incluir la librería
using LOGICA;

namespace PRESENTACION.Mantenimientos
{
    public partial class frmVehiculos : Form
    {
        //2. Instancia de la clase Vehiculos
        Vehiculos vehiculo = new Vehiculos();
        Marcas marca = new Marcas();

        public frmVehiculos()
        {
            InitializeComponent();
        }

        //3. Método que retorne los datos y los muestre en el GRID
        private void actualizarLista()
        {
            gridVehiculos.DataSource = vehiculo.listarVehiculos();
        }

        private void actualizarMarcas()
        {
            cboMarca.DataSource = marca.listarMarcas();
            cboMarca.DisplayMember = "marca";        //Display = mostrar (usuario final)
            cboMarca.ValueMember = "idmarca";        //Value = valor activo del elemento (PK)
            cboMarca.Text = "";
        }

        private void frmVehiculos_Load(object sender, EventArgs e)
        {
            //Agregando elementos al cboCategorias
            cboCategoria.Items.Add("Vehículos familiares");
            cboCategoria.Items.Add("Motos");
            cboCategoria.Items.Add("Camionetas");
            cboCategoria.Items.Add("Buses");

            //Cuando el formulario haya terminado de renderizarse en pantalla
            actualizarLista();

            //Actualizando la lista de marca
            actualizarMarcas();

            //Predeterminando control activo
            
        }

        private void reiniciarFormulario()
        {
            foreach (Control control in this.grupoControles.Controls)
            {
                //Asignamos a la propiedad Text = null
                if (control is TextBox || control is ComboBox)
                {
                    control.Text = null;
                }
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //1. Validar
            //Tipos: existencia del dato, formato del dato (AÑO), rangos (01/01/2089)
            //Modos: Local (Formulario) / Remotas (SGBD)

            //2. Proceso de inserción
            string placa = txtPlaca.Text.Trim();
            string afabricacion = txtAnio.Text.Trim();
            Int16 numero = Int16.Parse(txtNAsientos.Text);
            string uso = cboUso.Text.Trim();
            string categoria = cboCategoria.Text.Trim();
            int idmarca = int.Parse(cboMarca.SelectedValue.ToString());   //Object = genérico
            string modelo = txtModelo.Text.Trim();
            string numeroserie = txtNSerie.Text.Trim();
            string color = txtColor.Text.Trim();

            //3. Consulta al usuario
            if (MessageBox.Show("¿Está seguro de guardar?","SOAT Ver. 1.0",MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (vehiculo.registrarVehiculo(placa, afabricacion, numero, uso, categoria, idmarca, modelo, numeroserie, color) > 0)
                {
                    actualizarLista();
                    reiniciarFormulario();
                    MessageBox.Show("Guardado correctamente", "SOAT Ver. 1.0", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (gridVehiculos.Rows.Count == 0)
            {
                MessageBox.Show("Nada que eliminar");
            }
            else
            {
                if (gridVehiculos.CurrentRow == null)
                {
                    MessageBox.Show("Primero selecciona un elemento de la lista");
                }
                else
                {
                    if (MessageBox.Show("¿Desea eliminar el registro?","SOAT Ver. 1.0",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        //Capturar el ID (en la primera celda de la fila seleccionada)
                        int idvehiculo = Convert.ToInt32(gridVehiculos.CurrentRow.Cells[0].Value);
                        
                        if (vehiculo.eliminarVehiculo(idvehiculo) > 0)
                        {
                            //Actualizando el grid
                            this.actualizarLista();
                        }
                    }
                }
            }
        }
    }
}
