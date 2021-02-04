using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ApiCalc.Controllers
{
    public class ProductoController : ApiController
    {
        [ActionName("ObtenerProducto")]
        [HttpPost]
        public Models.Producto ObtenerProducto([FromBody] Models.Producto objProducto)
        {
            return objProducto;
        }

        [ActionName("ObtenerObjeto")]
        [HttpPost]
        public HttpResponseMessage ObtenerObjeto([FromBody] Models.Producto objProducto)
        {           

            try
            {
                List<Models.Producto> ListadoProducto = new List<Models.Producto>();
                objProducto.nomProducto = "Christopher";
                objProducto.montoProducto = objProducto.montoProducto * 2;
                ListadoProducto.Add(objProducto);
                Models.Producto obj = new Models.Producto();
                obj.IdProducto = "300";
                obj.nomProducto = "Televisor";
                obj.montoProducto = 175.88;
                ListadoProducto.Add(obj);
                obj = new Models.Producto();
                obj.IdProducto = "600";
                obj.nomProducto = "Sala";
                obj.montoProducto = 2.78;
                ListadoProducto.Add(obj);

                var mensaje = Request.CreateResponse(HttpStatusCode.OK, ListadoProducto);
                return mensaje;
            }
            catch (Exception ex)
            {

                return Request.CreateErrorResponse(HttpStatusCode.BadRequest,ex);
            }
        }

        [ActionName("ObtenerDato")]
        [HttpGet]
        public string ObtenerDato()
        {
            return "Hola mundo";
        }
    }
}
