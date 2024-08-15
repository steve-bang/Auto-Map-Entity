using Steve.AutoMapEntity.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Steve.AutoMapEntity.Generator
{
    /// <summary>
    /// This class converts the property names to SnakeCase.
    /// Author: mrsteve.bang@gmail.com
    /// </summary>
    public class GeneratorSnakeCase : GeneratorFactory
    {
        /// <summary>
        /// Convert the name of the property to the desired convention.
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public override string ConvertNameConvention(string name)
        {
            string result = string.Empty;
            if (string.IsNullOrEmpty(name))
            {
                return result;
            }

            result = NamingConvertUtil.Convert(name, OriginStyle, Styles.SnakeCase);

            return result;
        }

        public override IDictionary<string, object?> Handle(Type type)
        {
            var properties = type.GetProperties();
            var dictionary = new Dictionary<string, object?>();

            foreach (var property in properties)
            {
                string name = ConvertNameConvention(property.Name);

                dictionary.Add(name, property.GetValue(Activator.CreateInstance(type)));
            }

            return dictionary;
        }
    }
}
