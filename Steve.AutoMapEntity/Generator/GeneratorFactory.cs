using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Steve.AutoMapEntity.Generator
{
    /// <summary>
    /// This abstract class is the factory class that provides the different styles that can be used to convert the property names.
    /// Author: mrsteve.bang@gmail.com
    /// </summary>
    public abstract class GeneratorFactory
    {
        /// <summary>
        /// The original style of the property names.
        /// This is the style that the property names are currently in. And it will be converted to the desired style.
        /// By default, it is PascalCase.
        /// </summary>
        public Styles OriginStyle { get; set; } = Styles.PascalCase;


        /// <summary>
        /// Handle the type and return the dictionary of the properties.
        /// </summary>
        /// <param name="type">The type of the object.</param>
        /// <returns></returns>
        public abstract IDictionary<string, object?> Handle(Type type);

        /// <summary>
        /// Convert the name of the property to the desired convention.
        /// </summary>
        /// <param name="name">The name of the property.</param>
        /// <returns></returns>
        public abstract string ConvertNameConvention(string name);


        /// <summary>
        /// Builder method to create the instance of the GeneratorFactory.
        /// </summary>
        /// <param name="style">The style of the property names.</param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException">This style is not supported.</exception>
        public static GeneratorFactory Builder(Styles style)
        {
            switch (style)
            {
                case Styles.CamelCase: return new GeneratorCamelCase();
                case Styles.SnakeCase: return new GeneratorSnakeCase();
                default: throw new NotImplementedException("This style is not supported.");
            }
        }
    }
}
