using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace WS
{
    /// <summary>
    /// Descripción breve de wservice
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class wservice : System.Web.Services.WebService
    {
        [WebMethod]
        public List<Restaurant> getAllRestaurant()
        {
            using (Model db = new Model())
            {
                var list = db.Restaurants.ToList();
                return list;
            }
        }


       [WebMethod]
        public string PostRestaurant(string Nombre, string Direccion, string RNC,
            string Telefono, string Persona_Encargada, int Cantidad_Emplados, DateTime Fecha_Creacion, DateTime Fecha_Modificacion,string Tipo_Comida,
            double Ventas_Mensuales_Promedio, string GuidReg)
        {
            using (Model db = new Model())
            {
                var rest = new Restaurant();
                rest.Nombre = Nombre;
                rest.Direccion = Direccion;
                rest.RNC = RNC;
                rest.Telefono = Telefono;
                rest.Persona_Encargada = Persona_Encargada;
                rest.Cantidad_Emplados = Cantidad_Emplados;
                rest.Fecha_Creacion = Fecha_Creacion;
                rest.Fecha_Modificacion = DateTime.Now.Date;
                rest.Tipo_Comida = Tipo_Comida;
                rest.Ventas_Mensuales_Promedio = Convert.ToDecimal( Ventas_Mensuales_Promedio);
                rest.GuidReg = Guid.NewGuid().ToString();

                db.Restaurants.Add(rest);
                db.SaveChanges();

                return "Restaurant Creado";
            }
        }

       

        [WebMethod]
        public string PutRestaurant(int id,string Nombre, string Direccion, string RNC,
            string Telefono, string Persona_Encargada, int Cantidad_Emplados, DateTime Fecha_Creacion, DateTime Fecha_Modificacion, string Tipo_Comida,
            double Ventas_Mensuales_Promedio, string GuidReg)
        {
            using (Model db = new Model())
            {
                var rest = new Restaurant();
                rest.ID = Convert.ToInt32(id);
                rest.Nombre = Nombre;
                rest.Direccion = Direccion;
                rest.RNC = RNC;
                rest.Telefono = Telefono;
                rest.Persona_Encargada = Persona_Encargada;
                rest.Cantidad_Emplados = Cantidad_Emplados;
                rest.Fecha_Creacion = DateTime.Now.Date;
                rest.Fecha_Modificacion = DateTime.Now.Date;
                rest.Tipo_Comida = Tipo_Comida;
                rest.Ventas_Mensuales_Promedio = Convert.ToDecimal(Ventas_Mensuales_Promedio);
                rest.GuidReg = Guid.NewGuid().ToString();

                db.Entry(rest).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();

                return "Restaurant Actualizado";
            }

        }


        [WebMethod]
        public string DeleteRestaurant(int id)
        {
            using (Model db = new Model())
            {
                var reliminar = db.Restaurants.Find(id);
                db.Restaurants.Remove(reliminar);
                db.SaveChanges();
                return "Restaurant eliminado";
            }
        }

        
        
    }

}

