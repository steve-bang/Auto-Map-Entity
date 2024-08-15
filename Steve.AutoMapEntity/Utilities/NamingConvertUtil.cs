using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Steve.AutoMapEntity.Utilities
{
    /// <summary>
    /// This class provides the different styles that can be used to convert the property names.
    /// Author: mrsteve.bang@gmail.com
    /// </summary>
    public class NamingConvertUtil
    {
        /// <summary>
        /// Convert the name from one style to another.
        /// </summary>
        /// <param name="name">The name to be converted.</param>
        /// <param name="originStyle">The original style of the name.</param>
        /// <param name="targetStyle">The target style of the name.</param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException">This conversion is not supported.</exception>s
        public static string Convert(string name, Styles originStyle, Styles targetStyle)
        {
            if (string.IsNullOrEmpty(name))
            {
                return string.Empty;
            }

            if (originStyle == targetStyle)
            {
                return name;
            }

            if (originStyle == Styles.PascalCase && targetStyle == Styles.CamelCase)
            {
                return ConvertPascalToCamel(name);
            }

            else if (originStyle == Styles.CamelCase && targetStyle == Styles.PascalCase)
            {
                return ConvertCamelToPascal(name);
            }

            else if (originStyle == Styles.PascalCase && targetStyle == Styles.SnakeCase)
            {
                return ConvertPascalToSnake(name);
            }
            
            else if (originStyle == Styles.SnakeCase && targetStyle == Styles.PascalCase)
            {
                return ConvertSnakeToPascal(name);
            }
            else
            {
                throw new NotImplementedException("This conversion is not supported.");
            }
        }

        /// <summary>
        /// This method converts the PascalCase to camelCase.
        /// </summary>
        /// <param name="name">The name to be converted.</param>
        /// <returns></returns>
        public static string ConvertPascalToCamel(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                return string.Empty;
            }

            return char.ToLower(name[0]) + name.Substring(1);
        }

        /// <summary>
        /// Convert the CamelCase to PascalCase.
        /// </summary>
        /// <param name="name">The name to be converted.</param>
        /// <returns></returns>
        public static string ConvertCamelToPascal(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                return string.Empty;
            }

            return char.ToUpper(name[0]) + name.Substring(1);
        }

        /// <summary>
        /// Convert the PascalCase to SnakeCase.
        /// </summary>
        /// <param name="name">The name to be converted.</param>
        /// <returns></returns>
        public static string ConvertPascalToSnake(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                return string.Empty;
            }

            StringBuilder sb = new StringBuilder();
            foreach (char c in name)
            {
                if (char.IsUpper(c))
                {
                    sb.Append("_");
                    sb.Append(char.ToLower(c));
                }
                else
                {
                    sb.Append(c);
                }
            }

            // Remove the first underscore
            if (sb.Length > 0 && sb[0] == '_')
            {
                sb.Remove(0, 1);
            }

            return sb.ToString();
        }

        /// <summary>
        /// Convert the snake_case to PascalCase.
        /// </summary>
        /// <param name="name">The name to be converted.</param>
        /// <returns></returns>
        public static string ConvertSnakeToPascal(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                return string.Empty;
            }

            StringBuilder sb = new StringBuilder();
            bool toUpper = true;
            foreach (char c in name)
            {
                if (c == '_')
                {
                    toUpper = true;
                }
                else
                {
                    if (toUpper)
                    {
                        sb.Append(char.ToUpper(c));
                        toUpper = false;
                    }
                    else
                    {
                        sb.Append(c);
                    }
                }
            }

            return sb.ToString();
        }
    }
}
