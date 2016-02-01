using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using System.Web.Mvc;
using System.Web.Mvc.Html;
using WorkEffect.Website.Data;

namespace WorkEffect.Website.Views
{
    public static class HtmlExtensions
    {
        public static MvcHtmlString CheckBoxListForEnum<T>(this HtmlHelper<T> htmlHelper, Type enumType, int value, string prefix)
        {
            return CheckBoxListForEnum(htmlHelper, enumType, value, prefix, false, null);
        }

        public static MvcHtmlString CheckBoxListForEnum<T>(this HtmlHelper<T> htmlHelper, Type enumType, int value, string prefix, ArrayList includedEnums)
        {
            return CheckBoxListForEnum(htmlHelper, enumType, value, prefix, false, includedEnums);
        }

        public static MvcHtmlString CheckBoxListForEnum<T>(this HtmlHelper<T> htmlHelper, Type enumType, int value, string prefix, bool horizontal)
        {
            return CheckBoxListForEnum(htmlHelper, enumType, value, prefix, horizontal, null);
        }

        public static MvcHtmlString CheckBoxListForEnum<T>(this HtmlHelper<T> htmlHelper, Type enumType, int value, string prefix, bool horizontal, ArrayList includedEnums)
        {
            var buff = new StringBuilder();

            var values = Enum.GetValues(enumType);
            foreach (Enum enumValue in values)
            {
                if (includedEnums == null || includedEnums.Contains(enumValue))
                {
                    int x = Convert.ToInt32(enumValue);
                    var name = Enum.GetName(enumType, x);
                    buff.AppendFormat("<input name=\"{0}.{1}\" type=\"checkbox\" ", prefix, name);
                    if ((value & x) == x)
                    {
                        buff.Append("checked");
                    }

                    buff.Append(" />");

                    var description = GetEnumDescription(enumValue);
                    buff.Append("&nbsp;")
                        .Append(htmlHelper.Label(description));
                    if (!horizontal)
                    {
                        buff.AppendLine("<br />");
                    }
                    else
                    {
                        buff.Append("&nbsp;&nbsp;");
                    }
                }
            }

            return MvcHtmlString.Create(buff.ToString());
        }

        public static MvcHtmlString RadioButtonListForEnum<T>(this HtmlHelper<T> htmlHelper, Type enumType, int value, string name)
        {
            return RadioButtonListForEnum(htmlHelper, enumType, value, name, false);
        }

        public static MvcHtmlString RadioButtonListForEnum<T>(this HtmlHelper<T> htmlHelper, Type enumType, int value, string name, Boolean horizontal)
        {
            var buff = new StringBuilder();
            foreach (int x in Enum.GetValues(enumType))
            {
                buff.Append(htmlHelper.RadioButton(name, x, value == x))
                    .Append(' ')
                    .Append(htmlHelper.Label(Enum.GetName(enumType, x)));
                if (!horizontal)
                {
                    buff.Append("<br />");
                }
                else
                {
                    buff.Append("&nbsp;&nbsp;");
                }
            }

            return MvcHtmlString.Create(buff.ToString());
        }

        public static MvcHtmlString EnumValuesList<T>(this HtmlHelper<T> htmlHelper, Type enumType, int value)
        {
            var buff = new StringBuilder();

            foreach (int x in Enum.GetValues(enumType))
            {
                if ((value & x) == x)
                {
                    buff.Append(Enum.GetName(enumType, x))
                        .Append("<br />");
                }
            }

            return MvcHtmlString.Create(buff.ToString());
        }

        private static string GetEnumDescription(Enum value)
        {
            // Get the Description attribute value for the enum value
            FieldInfo fi = value.GetType().GetField(value.ToString());
            DescriptionAttribute[] attributes = (DescriptionAttribute[])fi.GetCustomAttributes(typeof(DescriptionAttribute), false);
            if (attributes.Length > 0)
            {
                return attributes[0].Description;
            }
            else
            {
                return value.ToString();
            }
        }

        /// <summary>
        /// Creates the DropDown List (HTML Select Element) from LINQ 
        /// Expression where the expression returns an Enum type.
        /// </summary>
        /// <typeparam name="TModel">The type of the model.</typeparam>
        /// <typeparam name="TProperty">The type of the property.</typeparam>
        /// <param name="htmlHelper">The HTML helper.</param>
        /// <param name="expression">The expression.</param>
        /// <param name="htmlAttributes">The HTML attributes</param>
        /// <returns></returns>
        public static MvcHtmlString DropDownListForEnum<TModel, TProperty>(this HtmlHelper<TModel> htmlHelper, Expression<Func<TModel, TProperty>> expression, object htmlAttributes = null) where TModel : class
        {
            TProperty value = htmlHelper.ViewData.Model == null
                ? default(TProperty)
                : expression.Compile()(htmlHelper.ViewData.Model);
            string selected = value == null ? String.Empty : value.ToString();
            return htmlHelper.DropDownListFor(expression, CreateSelectList(expression.ReturnType, selected), htmlAttributes);
        }

        /// <summary>
        /// Creates the select list.
        /// </summary>
        /// <param name="enumType">Type of the enum.</param>
        /// <param name="selectedItem">The selected item.</param>
        /// <returns></returns>
        private static IEnumerable<SelectListItem> CreateSelectList(Type enumType, string selectedItem)
        {
            return (from object item in Enum.GetValues(enumType)
                    let fi = enumType.GetField(item.ToString())
                    let attribute = fi.GetCustomAttributes(typeof(DescriptionAttribute), true).FirstOrDefault()
                    let title = attribute == null ? item.ToString() : ((DescriptionAttribute)attribute).Description
                    select new SelectListItem
                    {
                        Value = item.ToString(),
                        Text = title,
                        Selected = selectedItem == item.ToString()
                    }).ToList();
        }
    }
}