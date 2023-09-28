using System;
using System.Collections.Generic;
using System.Data;
using System.Web.UI.WebControls;
using CAPA_BLL;


namespace miAplicacion
{
    public partial class index : System.Web.UI.Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                cargarLista();
                
            }
     

        }

        //Agrega el item seleccionado al ListBox
        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            lstBCarrito.Items.Add(DropDownList1.SelectedItem.ToString());
        }



        protected void btnComprar_Click(object sender, EventArgs e)
        {

            //Datatable que guardará los datos que serám llevados a la base de datos.
            DataTable dt = new DataTable();

            dt.Columns.Add("idItem");
            dt.Columns.Add("nombre");
            dt.Columns.Add("producto");

            string nombre = txtNombre.Text;
            int id = 0;

            //Se toma el numero de indice de cada item elegido para comprar.Este se usará como id de los items en la base de datos.
            foreach(ListItem lb in lstBCarrito.Items)
            {
                id = Convert.ToInt32(DropDownList1.Items.IndexOf(DropDownList1.Items.FindByText(lb.Text)));
                dt.Rows.Add(id, nombre, lb.Text);
            }

            ListaCompra listaCompra = new ListaCompra();

            if (listaCompra.Compra(dt))
            {
                lblConfirm.Text = "Compra realizada correctamente.";
            }
            else
            {
                lblConfirm.Text = "Hubo con error con su compra.";
            }

        }

        

        private void cargarLista()
        {
            List<string> _items = new List<string>
                {
                    "Silla",
                    "Messa",
                    "Televisor",
                    "Sofa",
                    "Heladera"
                };

            DropDownList1.DataSource = _items;
            DropDownList1.DataBind();
        }
    }
}