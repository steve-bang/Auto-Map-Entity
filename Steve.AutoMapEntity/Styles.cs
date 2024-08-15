namespace Steve.AutoMapEntity
{
    /// <summary>
    /// This class provides the different styles that can be used to convert the property names.
    /// A style is a set of rules that define how the property names should be formatted.
    /// Author: mrsteve.bang@gmail.com
    /// </summary>
    public enum Styles
    {
        /// <summary>
        /// This style converts the property names to PascalCase. For example, "first_name" will be converted to "FirstName".
        /// </summary>
        PascalCase,

        /// <summary>
        /// This style converts the property names to camelCase. For example, "first_name" will be converted to "firstName".
        /// </summary>
        CamelCase,

        /// <summary>
        /// This style converts the property names to snake_case. For example, "FirstName" will be converted to "first_name".
        /// </summary>
        SnakeCase,

        /// <summary>
        /// This style converts the property names to kebab-case. For example, "FirstName" will be converted to "first-name".
        /// </summary>
        KebabCase
    }
}
