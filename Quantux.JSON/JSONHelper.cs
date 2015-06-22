using System;
using System.Web.Script.Serialization;
using System.Runtime.InteropServices;

namespace Quantux.JSON
{
    [ComVisibleAttribute(true)]
    [Guid("5888E03B-2F4B-4A4D-9395-F90E7A8CBF0D")]
    [ProgId("Quantux.JSON.JSONHelper")]
    public static class JSONHelper
    {
        /// <summary>
        ///     Convierte una lista en un JSON sin limite en la profundidad de parseo.
        /// </summary>
        /// <param name="obj">Objeto a parsear</param>
        /// <returns>JSON</returns>
        public static string ToJSON(this object obj) {
            JavaScriptSerializer serializer = new JavaScriptSerializer();
            return serializer.Serialize(obj); 
        }

        /// <summary>
        ///     Convierte una lista en un JSON con limite en la profundidad de parseo.
        /// </summary>
        /// <param name="obj">Objeto a parsear</param>
        /// <param name="recursionDepth">Profundidad</param>
        /// <returns>JSON</returns>
        public static string ToJSON(this object obj, int recursionDepth) {
            JavaScriptSerializer serializer = new JavaScriptSerializer();
            serializer.RecursionLimit = recursionDepth;
            return serializer.Serialize(obj);
        }
    }
}
