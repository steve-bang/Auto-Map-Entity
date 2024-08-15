using Steve.AutoMapEntity.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Steve.AutoMapEntity.Generator
{
    /// <summary>
    /// This class converts the property names to CamelCase.
    /// Author: mrsteve.bang@gmail.com
    /// </summary>
    public class GeneratorCamelCase : GeneratorFactory
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

            switch (OriginStyle)
            {
                case Styles.CamelCase: result = name; break;
                case Styles.PascalCase: result = NamingConvertUtil.Convert(name, OriginStyle, Styles.PascalCase); break;
                case Styles.SnakeCase: result = NamingConvertUtil.Convert(name, OriginStyle, Styles.SnakeCase); break;
                case Styles.KebabCase: result = NamingConvertUtil.Convert(name, OriginStyle, Styles.KebabCase); break;
            }

            return result;
        }

        /// <inheritdoc/>
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
