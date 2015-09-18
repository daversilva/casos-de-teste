using System;
using System.Xml.Serialization;

namespace CasosDeTeste.Test
{
    public static class EnumUtil
    {
        public static string RetornaNameDoAtributo(Enum tipoEnum)
        {
            var membro = tipoEnum.GetType().GetMember(tipoEnum.ToString());
            var atributo = membro[0].GetCustomAttributes(true);
            var valor = atributo.GetValue(0);

            return ((XmlEnumAttribute)valor).Name;
        }  
    }
}