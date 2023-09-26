using System;
using System.Collections.Generic;
using System.Data;


namespace miAplicacion
{
    public partial class index : System.Web.UI.Page
    {
        DataTable dt = new DataTable();
        

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                cargarLista();
            }

        }

        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            dt.Columns.Add("idItem");
            dt.Columns.Add("nombre");
            dt.Columns.Add("item");

            dt.Rows.Add(Convert.ToInt32(DropDownList1.SelectedIndex), lblNombre.Text, DropDownList1.SelectedItem.Text);

            lstBCarrito.Items.Add(dt.Rows[0][2].ToString());

        }

        protected void btnComprar_Click(object sender, EventArgs e)
        {
   
            

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